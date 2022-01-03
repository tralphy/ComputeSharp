﻿using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
#if WINDOWS_UWP
using ComputeSharp.Uwp.Extensions;
#else
using ComputeSharp.WinUI.Extensions;
#endif
using Microsoft.Toolkit.Diagnostics;

#pragma warning disable CS0420

#if WINDOWS_UWP
namespace ComputeSharp.Uwp.Helpers;
#else
namespace ComputeSharp.WinUI.Helpers;
#endif

/// <inheritdoc/>
partial class SwapChainManager<TOwner>
{
    /// <summary>
    /// Starts the current render loop.
    /// </summary>
    /// <param name="frameRequestQueue">The <see cref="IFrameRequestQueue"/> instance to use, if available.</param>
    /// <param name="shaderRunner">The <see cref="IShaderRunner"/> instance to use to render frames.</param>
    public async void StartRenderLoop(IFrameRequestQueue? frameRequestQueue, IShaderRunner shaderRunner)
    {
        ThrowIfDisposed();

        Guard.IsNotNull(shaderRunner, nameof(shaderRunner));

        using (await this.setupSemaphore.LockAsync())
        {
            this.renderCancellationTokenSource?.Cancel();
            
            await this.renderSemaphore.WaitAsync();

            Thread newRenderThread = new(static args => ((SwapChainManager<TOwner>)args!).SwitchAndStartRenderLoop());

            this.frameRequestQueue = frameRequestQueue;
            this.shaderRunner = shaderRunner;
            this.renderCancellationTokenSource = new CancellationTokenSource();
            this.renderThread = newRenderThread;
            this.renderSemaphore = new SemaphoreSlim(0, 1);

            newRenderThread.Start(this);
        }
    }

    /// <summary>
    /// Stops the current render loop, if one is running.
    /// </summary>
    public async void StopRenderLoop()
    {
        ThrowIfDisposed();

        using (await this.setupSemaphore.LockAsync())
        {
            this.renderCancellationTokenSource?.Cancel();
        }
    }

    /// <summary>
    /// Queues a change in the dynamic resolution mode.
    /// </summary>
    /// <param name="isDynamicResolutionEnabled">Whether or not to use dynamic resolution.</param>
    public async void QueueDynamicResolutionModeChange(bool isDynamicResolutionEnabled)
    {
        ThrowIfDisposed();

        using (await this.setupSemaphore.LockAsync())
        {
            // If there is a render thread currently running, stop it and restart it
            if (this.renderCancellationTokenSource?.IsCancellationRequested == false)
            {
                this.renderCancellationTokenSource?.Cancel();

                await this.renderSemaphore.WaitAsync();

                Thread newRenderThread = new(static args => ((SwapChainManager<TOwner>)args!).SwitchAndStartRenderLoop());

                this.renderCancellationTokenSource = new CancellationTokenSource();
                this.renderThread = newRenderThread;
                this.renderSemaphore = new SemaphoreSlim(0, 1);
                this.isDynamicResolutionEnabled = isDynamicResolutionEnabled;

                newRenderThread.Start(this);
            }
            else
            {
                this.isDynamicResolutionEnabled = isDynamicResolutionEnabled;
            }
        }
    }

    /// <summary>
    /// Queues a resize operation.
    /// </summary>
    /// <param name="width">The width of the render resolution.</param>
    /// <param name="height">The height of the render resolution.</param>
    public void QueueResize(double width, double height)
    {
        ThrowIfDisposed();

        this.width = (float)width;
        this.height = (float)height;

        this.isResizePending = true;
    }

    /// <summary>
    /// Queues a change in the composition scale factors.
    /// </summary>
    /// <param name="compositionScaleX">The composition scale on the X axis.</param>
    /// <param name="compositionScaleY">The composition scale on the Y axis</param>
    public void QueueCompositionScaleChange(double compositionScaleX, double compositionScaleY)
    {
        ThrowIfDisposed();

        this.compositionScaleX = (float)compositionScaleX;
        this.compositionScaleY = (float)compositionScaleY;

        this.isResizePending = true;
    }

    /// <summary>
    /// Queues a change in the resolution scale factor.
    /// </summary>
    /// <param name="resolutionScale">The resolution scale factor to use.</param>
    public void QueueResolutionScaleChange(double resolutionScale)
    {
        ThrowIfDisposed();

        this.resolutionScale = (float)resolutionScale;

        this.isResizePending = true;
    }

    /// <summary>
    /// Selects the right render loop to start.
    /// </summary>
    private void SwitchAndStartRenderLoop()
    {
        try
        {
            OnRenderingStarted();

            if (this.isDynamicResolutionEnabled)
            {
                this.targetResolutionScale = 1.0f;

                RenderLoopWithDynamicResolution();
            }
            else
            {
                this.targetResolutionScale = this.resolutionScale;

                RenderLoop();
            }

            OnRenderingStopped();
        }
        catch (Exception e)
        {
            OnRenderingFailed(e);
        }
        finally
        {
            this.renderSemaphore.Release();
        }
    }

    /// <summary>
    /// The core render loop.
    /// </summary>
    private void RenderLoop()
    {
        Stopwatch renderStopwatch = this.renderStopwatch ??= new();
        CancellationToken cancellationToken = this.renderCancellationTokenSource!.Token;

        if (!OnFrameRequest(out object? parameter, cancellationToken))
        {
            return;
        }

        // Start the initial frame separately, before the timer starts. This ensures that
        // resuming after a pause correctly renders the first frame at the right time.
        OnResize();
        OnUpdate(renderStopwatch.Elapsed, parameter);
        OnPresent();

        renderStopwatch.Start();

        // Main render loop, until cancellation is requested
        while (!cancellationToken.IsCancellationRequested)
        {
            if (!OnFrameRequest(out parameter, cancellationToken))
            {
                return;
            }

            OnResize();
            OnUpdate(renderStopwatch.Elapsed, parameter);
            OnPresent();
        }

        renderStopwatch.Stop();
    }

    /// <summary>
    /// The core render loop with dynamic resolution.
    /// </summary>
    private void RenderLoopWithDynamicResolution()
    {
        Stopwatch renderStopwatch = this.renderStopwatch ??= new();
        CancellationToken cancellationToken = this.renderCancellationTokenSource!.Token;

        DynamicResolutionManager.Create(out DynamicResolutionManager frameTimeWatcher);
        
        if (!OnFrameRequest(out object? parameter, cancellationToken))
        {
            return;
        }

        Stopwatch frameStopwatch = Stopwatch.StartNew();

        OnResize();
        OnUpdate(renderStopwatch.Elapsed, parameter);
        OnPresent();

        renderStopwatch.Start();

        while (!cancellationToken.IsCancellationRequested)
        {
            // Evaluate the dynamic resolution frame time step, if the mode is enabled
            if (frameTimeWatcher.Advance(frameStopwatch.ElapsedTicks, ref this.targetResolutionScale))
            {
                this.isResizePending = true;
            }

            if (!OnFrameRequest(out parameter, cancellationToken))
            {
                return;
            }

            frameStopwatch.Restart();

            OnResize();
            OnUpdate(renderStopwatch.Elapsed, parameter);
            OnPresent();
        }

        renderStopwatch.Stop();
    }

    /// <summary>
    /// Waits for a new frame request and retrieves its parameter.
    /// </summary>
    /// <param name="parameter">The input parameter for the frame to render.</param>
    /// <param name="token">A token to cancel waiting for a new frame.</param>
    /// <returns>Whether the operation was canceled.</returns>
    private bool OnFrameRequest(out object? parameter, CancellationToken token)
    {
        if (this.frameRequestQueue is IFrameRequestQueue frameRequestQueue)
        {
            [MethodImpl(MethodImplOptions.NoInlining)]
            static bool WaitForFrameRequest(IFrameRequestQueue frameRequestQueue, out object? parameter, CancellationToken token)
            {
                try
                {
                    // Wait for a new frame request
                    frameRequestQueue.Dequeue(out parameter, token);

                    return true;
                }
                catch (OperationCanceledException)
                {
                    parameter = null;

                    return false;
                }
            }

            return WaitForFrameRequest(frameRequestQueue, out parameter, token);
        }

        parameter = null;

        return true;
    }

    /// <summary>
    /// Resizes the current application, if needed.
    /// </summary>
    private void OnResize()
    {
        if (this.isResizePending)
        {
            ApplyResize();

            this.isResizePending = false;
        }
    }

    /// <summary>
    /// Updates the render resolution, if needed, and renders a new frame.
    /// </summary>
    /// <param name="time">The current time since the start of the application.</param>
    /// <param name="parameter">The input parameter for the frame being rendered.</param>
    private void OnUpdate(TimeSpan time, object? parameter)
    {
        this.shaderRunner!.Execute(this.texture!, time, parameter);
    }

    /// <summary>
    /// Presents the last rendered frame for the current application.
    /// </summary>
    private unsafe partial void OnPresent();

    /// <summary>
    /// Raises <see cref="RenderingStarted"/>.
    /// </summary>
    private void OnRenderingStarted()
    {
        _ = this.dispatcherQueue.TryEnqueue(() => RenderingStarted?.Invoke(this.owner, EventArgs.Empty));
    }

    /// <summary>
    /// Raises <see cref="RenderingStopped"/>.
    /// </summary>
    private void OnRenderingStopped()
    {
        _ = this.dispatcherQueue.TryEnqueue(() => RenderingStopped?.Invoke(this.owner, EventArgs.Empty));
    }

    /// <summary>
    /// Raises <see cref="RenderingFailed"/>.
    /// </summary>
    /// <param name="e">The <see cref="Exception"/> being thrown that caused rendering to stop.</param>
    private void OnRenderingFailed(Exception e)
    {
        _ = this.dispatcherQueue.TryEnqueue(() => RenderingFailed?.Invoke(this.owner, e));
    }

    /// <summary>
    /// Stops the current render loop, if one is running, and waits for it.
    /// </summary>
    /// <remarks>This method doesn't check for disposal.</remarks>
    private void UnsafeStopRenderLoopAndWait()
    {
        ThrowIfDisposed();

        this.setupSemaphore.Wait();

        this.renderCancellationTokenSource?.Cancel();
        this.renderSemaphore.Wait();
    }
}