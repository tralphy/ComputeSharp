using System.Runtime.CompilerServices;
using CommunityToolkit.Diagnostics;
using ComputeSharp.__Internals;
using ComputeSharp.Graphics.Helpers;
using ComputeSharp.Interop;
using TerraFX.Interop.DirectX;

#pragma warning disable CS0618

namespace ComputeSharp;

/// <summary>
/// A <see langword="class"/> that contains extension methods for the <see cref="ComputeContext"/> type, used to run compute shaders.
/// </summary>
public static class ComputeContextExtensions
{
    /// <summary>
    /// Inserts a resource barrier for a specific resource.
    /// </summary>
    /// <typeparam name="T">The type of items stored on the buffer.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to insert the resource barrier.</param>
    /// <param name="buffer">The input <see cref="ReadWriteBuffer{T}"/> instance to insert the barrier for.</param>
    public static unsafe void Barrier<T>(this in ComputeContext context, ReadWriteBuffer<T> buffer)
        where T : unmanaged
    {
        Guard.IsNotNull(buffer);

        using ReferenceTracker.Lease lease = default;

        context.Barrier(buffer.ValidateAndGetID3D12Resource(context.GraphicsDevice, out Unsafe.AsRef(in lease)));
    }

    /// <summary>
    /// Inserts a resource barrier for a specific resource.
    /// </summary>
    /// <typeparam name="T">The type of items stored on the texture.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to insert the resource barrier.</param>
    /// <param name="texture">The input <see cref="ReadWriteTexture1D{T}"/> instance to insert the barrier for.</param>
    public static unsafe void Barrier<T>(this in ComputeContext context, ReadWriteTexture1D<T> texture)
        where T : unmanaged
    {
        Guard.IsNotNull(texture);

        using ReferenceTracker.Lease lease = default;

        context.Barrier(texture.ValidateAndGetID3D12Resource(context.GraphicsDevice, out Unsafe.AsRef(in lease)));
    }

    /// <summary>
    /// Inserts a resource barrier for a specific resource.
    /// </summary>
    /// <typeparam name="T">The type of items stored on the texture.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to insert the resource barrier.</param>
    /// <param name="texture">The input <see cref="ReadWriteTexture2D{T}"/> instance to insert the barrier for.</param>
    public static unsafe void Barrier<T>(this in ComputeContext context, ReadWriteTexture2D<T> texture)
        where T : unmanaged
    {
        Guard.IsNotNull(texture);

        using ReferenceTracker.Lease lease = default;

        context.Barrier(texture.ValidateAndGetID3D12Resource(context.GraphicsDevice, out Unsafe.AsRef(in lease)));
    }

    /// <summary>
    /// Inserts a resource barrier for a specific resource.
    /// </summary>
    /// <typeparam name="T">The type of items stored on the texture.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to insert the resource barrier.</param>
    /// <param name="texture">The input <see cref="ReadWriteBuffer{T}"/> instance to insert the barrier for.</param>
    public static unsafe void Barrier<T>(this in ComputeContext context, ReadWriteTexture3D<T> texture)
        where T : unmanaged
    {
        Guard.IsNotNull(texture);

        using ReferenceTracker.Lease lease = default;

        context.Barrier(texture.ValidateAndGetID3D12Resource(context.GraphicsDevice, out Unsafe.AsRef(in lease)));
    }

    /// <summary>
    /// Inserts a resource barrier for a specific resource.
    /// </summary>
    /// <typeparam name="T">The type of items stored on the texture.</typeparam>
    /// <typeparam name="TPixel">The type of pixels used on the GPU side.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to insert the resource barrier.</param>
    /// <param name="texture">The input <see cref="ReadWriteTexture1D{T,TPixel}"/> instance to insert the barrier for.</param>
    public static unsafe void Barrier<T, TPixel>(this in ComputeContext context, ReadWriteTexture1D<T, TPixel> texture)
        where T : unmanaged, IPixel<T, TPixel>
        where TPixel : unmanaged
    {
        Guard.IsNotNull(texture);

        using ReferenceTracker.Lease lease = default;

        context.Barrier(texture.ValidateAndGetID3D12Resource(context.GraphicsDevice, out Unsafe.AsRef(in lease)));
    }

    /// <summary>
    /// Inserts a resource barrier for a specific resource.
    /// </summary>
    /// <typeparam name="T">The type of items stored on the texture.</typeparam>
    /// <typeparam name="TPixel">The type of pixels used on the GPU side.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to insert the resource barrier.</param>
    /// <param name="texture">The input <see cref="ReadWriteTexture2D{T,TPixel}"/> instance to insert the barrier for.</param>
    public static unsafe void Barrier<T, TPixel>(this in ComputeContext context, ReadWriteTexture2D<T, TPixel> texture)
        where T : unmanaged, IPixel<T, TPixel>
        where TPixel : unmanaged
    {
        Guard.IsNotNull(texture);

        using ReferenceTracker.Lease lease = default;

        context.Barrier(texture.ValidateAndGetID3D12Resource(context.GraphicsDevice, out Unsafe.AsRef(in lease)));
    }

    /// <summary>
    /// Inserts a resource barrier for a specific resource.
    /// </summary>
    /// <typeparam name="T">The type of items stored on the texture.</typeparam>
    /// <typeparam name="TPixel">The type of pixels used on the GPU side.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to insert the resource barrier.</param>
    /// <param name="texture">The input <see cref="ReadWriteTexture3D{T,TPixel}"/> instance to insert the barrier for.</param>
    public static unsafe void Barrier<T, TPixel>(this in ComputeContext context, ReadWriteTexture3D<T, TPixel> texture)
        where T : unmanaged, IPixel<T, TPixel>
        where TPixel : unmanaged
    {
        Guard.IsNotNull(texture);

        using ReferenceTracker.Lease lease = default;

        context.Barrier(texture.ValidateAndGetID3D12Resource(context.GraphicsDevice, out Unsafe.AsRef(in lease)));
    }

    /// <summary>
    /// Inserts a resource barrier for a specific resource.
    /// </summary>
    /// <typeparam name="TPixel">The type of pixels stored on the texture.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to insert the resource barrier.</param>
    /// <param name="texture">The input <see cref="IReadWriteNormalizedTexture1D{TPixel}"/> instance to insert the barrier for.</param>
    public static unsafe void Barrier<TPixel>(this in ComputeContext context, IReadWriteNormalizedTexture1D<TPixel> texture)
        where TPixel : unmanaged
    {
        Guard.IsNotNull(texture);

        using ReferenceTracker.Lease lease = default;

        context.Barrier(((GraphicsResourceHelper.IGraphicsResource)texture).ValidateAndGetID3D12Resource(context.GraphicsDevice, out Unsafe.AsRef(in lease)));
    }

    /// <summary>
    /// Inserts a resource barrier for a specific resource.
    /// </summary>
    /// <typeparam name="TPixel">The type of pixels stored on the texture.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to insert the resource barrier.</param>
    /// <param name="texture">The input <see cref="IReadWriteNormalizedTexture2D{TPixel}"/> instance to insert the barrier for.</param>
    public static unsafe void Barrier<TPixel>(this in ComputeContext context, IReadWriteNormalizedTexture2D<TPixel> texture)
        where TPixel : unmanaged
    {
        Guard.IsNotNull(texture);

        using ReferenceTracker.Lease lease = default;

        context.Barrier(((GraphicsResourceHelper.IGraphicsResource)texture).ValidateAndGetID3D12Resource(context.GraphicsDevice, out Unsafe.AsRef(in lease)));
    }

    /// <summary>
    /// Inserts a resource barrier for a specific resource.
    /// </summary>
    /// <typeparam name="TPixel">The type of pixels stored on the texture.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to insert the resource barrier.</param>
    /// <param name="texture">The input <see cref="IReadWriteNormalizedTexture3D{TPixel}"/> instance to insert the barrier for.</param>
    public static unsafe void Barrier<TPixel>(this in ComputeContext context, IReadWriteNormalizedTexture3D<TPixel> texture)
        where TPixel : unmanaged
    {
        Guard.IsNotNull(texture);

        using ReferenceTracker.Lease lease = default;

        context.Barrier(((GraphicsResourceHelper.IGraphicsResource)texture).ValidateAndGetID3D12Resource(context.GraphicsDevice, out Unsafe.AsRef(in lease)));
    }

    /// <summary>
    /// Clears a specific resource.
    /// </summary>
    /// <typeparam name="T">The type of items stored on the buffer.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to clear the resource.</param>
    /// <param name="buffer">The input <see cref="ReadWriteBuffer{T}"/> instance to clear.</param>
    public static unsafe void Clear<T>(this in ComputeContext context, ReadWriteBuffer<T> buffer)
        where T : unmanaged
    {
        Guard.IsNotNull(buffer);

        (D3D12_GPU_DESCRIPTOR_HANDLE Gpu, D3D12_CPU_DESCRIPTOR_HANDLE Cpu) handles = buffer.ValidateAndGetGpuAndCpuDescriptorHandlesForClear(context.GraphicsDevice);

        context.Clear(buffer.D3D12Resource, handles.Gpu, handles.Cpu, isNormalized: false);
    }

    /// <summary>
    /// Clears a specific resource.
    /// </summary>
    /// <typeparam name="T">The type of items stored on the texture.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to clear the resource.</param>
    /// <param name="texture">The input <see cref="ReadWriteTexture1D{T}"/> instance to clear.</param>
    public static unsafe void Clear<T>(this in ComputeContext context, ReadWriteTexture1D<T> texture)
        where T : unmanaged
    {
        Guard.IsNotNull(texture);

        (D3D12_GPU_DESCRIPTOR_HANDLE Gpu, D3D12_CPU_DESCRIPTOR_HANDLE Cpu) handles = texture.ValidateAndGetGpuAndCpuDescriptorHandlesForClear(context.GraphicsDevice, out bool isNormalized);

        context.Clear(texture.D3D12Resource, handles.Gpu, handles.Cpu, isNormalized);
    }

    /// <summary>
    /// Clears a specific resource.
    /// </summary>
    /// <typeparam name="T">The type of items stored on the texture.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to clear the resource.</param>
    /// <param name="texture">The input <see cref="ReadWriteTexture2D{T}"/> instance to clear.</param>
    public static unsafe void Clear<T>(this in ComputeContext context, ReadWriteTexture2D<T> texture)
        where T : unmanaged
    {
        Guard.IsNotNull(texture);

        (D3D12_GPU_DESCRIPTOR_HANDLE Gpu, D3D12_CPU_DESCRIPTOR_HANDLE Cpu) handles = texture.ValidateAndGetGpuAndCpuDescriptorHandlesForClear(context.GraphicsDevice, out bool isNormalized);

        context.Clear(texture.D3D12Resource, handles.Gpu, handles.Cpu, isNormalized);
    }

    /// <summary>
    /// Clears a specific resource.
    /// </summary>
    /// <typeparam name="T">The type of items stored on the texture.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to clear the resource.</param>
    /// <param name="texture">The input <see cref="ReadWriteBuffer{T}"/> instance to clear.</param>
    public static unsafe void Clear<T>(this in ComputeContext context, ReadWriteTexture3D<T> texture)
        where T : unmanaged
    {
        Guard.IsNotNull(texture);

        (D3D12_GPU_DESCRIPTOR_HANDLE Gpu, D3D12_CPU_DESCRIPTOR_HANDLE Cpu) handles = texture.ValidateAndGetGpuAndCpuDescriptorHandlesForClear(context.GraphicsDevice, out bool isNormalized);

        context.Clear(texture.D3D12Resource, handles.Gpu, handles.Cpu, isNormalized);
    }

    /// <summary>
    /// Clears a specific resource.
    /// </summary>
    /// <typeparam name="T">The type of items stored on the texture.</typeparam>
    /// <typeparam name="TPixel">The type of pixels used on the GPU side.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to clear the resource.</param>
    /// <param name="texture">The input <see cref="ReadWriteTexture1D{T,TPixel}"/> instance to clear.</param>
    public static unsafe void Clear<T, TPixel>(this in ComputeContext context, ReadWriteTexture1D<T, TPixel> texture)
        where T : unmanaged, IPixel<T, TPixel>
        where TPixel : unmanaged
    {
        Guard.IsNotNull(texture);

        (D3D12_GPU_DESCRIPTOR_HANDLE Gpu, D3D12_CPU_DESCRIPTOR_HANDLE Cpu) handles = texture.ValidateAndGetGpuAndCpuDescriptorHandlesForClear(context.GraphicsDevice, out _);

        context.Clear(texture.D3D12Resource, handles.Gpu, handles.Cpu, true);
    }

    /// <summary>
    /// Clears a specific resource.
    /// </summary>
    /// <typeparam name="T">The type of items stored on the texture.</typeparam>
    /// <typeparam name="TPixel">The type of pixels used on the GPU side.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to clear the resource.</param>
    /// <param name="texture">The input <see cref="ReadWriteTexture2D{T,TPixel}"/> instance to clear.</param>
    public static unsafe void Clear<T, TPixel>(this in ComputeContext context, ReadWriteTexture2D<T, TPixel> texture)
        where T : unmanaged, IPixel<T, TPixel>
        where TPixel : unmanaged
    {
        Guard.IsNotNull(texture);

        (D3D12_GPU_DESCRIPTOR_HANDLE Gpu, D3D12_CPU_DESCRIPTOR_HANDLE Cpu) handles = texture.ValidateAndGetGpuAndCpuDescriptorHandlesForClear(context.GraphicsDevice, out _);

        context.Clear(texture.D3D12Resource, handles.Gpu, handles.Cpu, true);
    }

    /// <summary>
    /// Clears a specific resource.
    /// </summary>
    /// <typeparam name="T">The type of items stored on the texture.</typeparam>
    /// <typeparam name="TPixel">The type of pixels used on the GPU side.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to clear the resource.</param>
    /// <param name="texture">The input <see cref="ReadWriteTexture3D{T,TPixel}"/> instance to clear.</param>
    public static unsafe void Clear<T, TPixel>(this in ComputeContext context, ReadWriteTexture3D<T, TPixel> texture)
        where T : unmanaged, IPixel<T, TPixel>
        where TPixel : unmanaged
    {
        Guard.IsNotNull(texture);

        (D3D12_GPU_DESCRIPTOR_HANDLE Gpu, D3D12_CPU_DESCRIPTOR_HANDLE Cpu) handles = texture.ValidateAndGetGpuAndCpuDescriptorHandlesForClear(context.GraphicsDevice, out _);

        context.Clear(texture.D3D12Resource, handles.Gpu, handles.Cpu, true);
    }

    /// <summary>
    /// Clears a specific resource.
    /// </summary>
    /// <typeparam name="TPixel">The type of pixels stored on the texture.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to clear the resource.</param>
    /// <param name="texture">The input <see cref="IReadWriteNormalizedTexture1D{TPixel}"/> instance to clear.</param>
    public static unsafe void Clear<TPixel>(this in ComputeContext context, IReadWriteNormalizedTexture1D<TPixel> texture)
        where TPixel : unmanaged
    {
        Guard.IsNotNull(texture);

        (D3D12_GPU_DESCRIPTOR_HANDLE Gpu, D3D12_CPU_DESCRIPTOR_HANDLE Cpu) handles = ((GraphicsResourceHelper.IGraphicsResource)texture).ValidateAndGetGpuAndCpuDescriptorHandlesForClear(context.GraphicsDevice, out _);

        using ReferenceTracker.Lease lease = default;

        context.Clear(((GraphicsResourceHelper.IGraphicsResource)texture).ValidateAndGetID3D12Resource(context.GraphicsDevice, out Unsafe.AsRef(in lease)), handles.Gpu, handles.Cpu, true);
    }

    /// <summary>
    /// Clears a specific resource.
    /// </summary>
    /// <typeparam name="TPixel">The type of pixels stored on the texture.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to clear the resource.</param>
    /// <param name="texture">The input <see cref="IReadWriteNormalizedTexture2D{TPixel}"/> instance to clear.</param>
    public static unsafe void Clear<TPixel>(this in ComputeContext context, IReadWriteNormalizedTexture2D<TPixel> texture)
        where TPixel : unmanaged
    {
        Guard.IsNotNull(texture);

        (D3D12_GPU_DESCRIPTOR_HANDLE Gpu, D3D12_CPU_DESCRIPTOR_HANDLE Cpu) handles = ((GraphicsResourceHelper.IGraphicsResource)texture).ValidateAndGetGpuAndCpuDescriptorHandlesForClear(context.GraphicsDevice, out _);

        using ReferenceTracker.Lease lease = default;

        context.Clear(((GraphicsResourceHelper.IGraphicsResource)texture).ValidateAndGetID3D12Resource(context.GraphicsDevice, out Unsafe.AsRef(in lease)), handles.Gpu, handles.Cpu, true);
    }

    /// <summary>
    /// Clears a specific resource.
    /// </summary>
    /// <typeparam name="TPixel">The type of pixels stored on the texture.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to clear the resource.</param>
    /// <param name="texture">The input <see cref="IReadWriteNormalizedTexture3D{TPixel}"/> instance to clear.</param>
    public static unsafe void Clear<TPixel>(this in ComputeContext context, IReadWriteNormalizedTexture3D<TPixel> texture)
        where TPixel : unmanaged
    {
        Guard.IsNotNull(texture);

        (D3D12_GPU_DESCRIPTOR_HANDLE Gpu, D3D12_CPU_DESCRIPTOR_HANDLE Cpu) handles = ((GraphicsResourceHelper.IGraphicsResource)texture).ValidateAndGetGpuAndCpuDescriptorHandlesForClear(context.GraphicsDevice, out _);

        using ReferenceTracker.Lease lease = default;

        context.Clear(((GraphicsResourceHelper.IGraphicsResource)texture).ValidateAndGetID3D12Resource(context.GraphicsDevice, out Unsafe.AsRef(in lease)), handles.Gpu, handles.Cpu, true);
    }

    /// <summary>
    /// Fills a specific texture with a given value.
    /// </summary>
    /// <typeparam name="T">The type of items stored on the texture.</typeparam>
    /// <typeparam name="TPixel">The type of pixels used on the GPU side.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to fill the resource.</param>
    /// <param name="texture">The input <see cref="ReadWriteTexture1D{T,TPixel}"/> instance to fill.</param>
    /// <param name="value">The value to use to fill <paramref name="texture"/>.</param>
    public static unsafe void Fill<T, TPixel>(this in ComputeContext context, ReadWriteTexture1D<T, TPixel> texture, T value)
        where T : unmanaged, IPixel<T, TPixel>
        where TPixel : unmanaged
    {
        Guard.IsNotNull(texture);

        (D3D12_GPU_DESCRIPTOR_HANDLE Gpu, D3D12_CPU_DESCRIPTOR_HANDLE Cpu) handles = texture.ValidateAndGetGpuAndCpuDescriptorHandlesForClear(context.GraphicsDevice, out _);

        context.Fill(texture.D3D12Resource, handles.Gpu, handles.Cpu, DXGIFormatHelper.ExtendToNormalizedValue(value.ToPixel()));
    }

    /// <summary>
    /// Fills a specific texture with a given value.
    /// </summary>
    /// <typeparam name="T">The type of items stored on the texture.</typeparam>
    /// <typeparam name="TPixel">The type of pixels used on the GPU side.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to fill the resource.</param>
    /// <param name="texture">The input <see cref="ReadWriteTexture2D{T,TPixel}"/> instance to fill.</param>
    /// <param name="value">The value to use to fill <paramref name="texture"/>.</param>
    public static unsafe void Fill<T, TPixel>(this in ComputeContext context, ReadWriteTexture2D<T, TPixel> texture, T value)
        where T : unmanaged, IPixel<T, TPixel>
        where TPixel : unmanaged
    {
        Guard.IsNotNull(texture);

        (D3D12_GPU_DESCRIPTOR_HANDLE Gpu, D3D12_CPU_DESCRIPTOR_HANDLE Cpu) handles = texture.ValidateAndGetGpuAndCpuDescriptorHandlesForClear(context.GraphicsDevice, out _);

        context.Fill(texture.D3D12Resource, handles.Gpu, handles.Cpu, DXGIFormatHelper.ExtendToNormalizedValue(value.ToPixel()));
    }

    /// <summary>
    /// Fills a specific texture with a given value.
    /// </summary>
    /// <typeparam name="T">The type of items stored on the texture.</typeparam>
    /// <typeparam name="TPixel">The type of pixels used on the GPU side.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to fill the resource.</param>
    /// <param name="texture">The input <see cref="ReadWriteTexture3D{T,TPixel}"/> instance to fill.</param>
    /// <param name="value">The value to use to fill <paramref name="texture"/>.</param>
    public static unsafe void Fill<T, TPixel>(this in ComputeContext context, ReadWriteTexture3D<T, TPixel> texture, T value)
        where T : unmanaged, IPixel<T, TPixel>
        where TPixel : unmanaged
    {
        Guard.IsNotNull(texture);

        (D3D12_GPU_DESCRIPTOR_HANDLE Gpu, D3D12_CPU_DESCRIPTOR_HANDLE Cpu) handles = texture.ValidateAndGetGpuAndCpuDescriptorHandlesForClear(context.GraphicsDevice, out _);

        context.Fill(texture.D3D12Resource, handles.Gpu, handles.Cpu, DXGIFormatHelper.ExtendToNormalizedValue(value.ToPixel()));
    }

    /// <summary>
    /// Fills a specific texture with a given value.
    /// </summary>
    /// <typeparam name="TPixel">The type of pixels stored on the texture.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to fill the resource.</param>
    /// <param name="texture">The input <see cref="IReadWriteNormalizedTexture1D{TPixel}"/> instance to fill.</param>
    /// <param name="value">The value to use to fill <paramref name="texture"/>.</param>
    public static unsafe void Fill<TPixel>(this in ComputeContext context, IReadWriteNormalizedTexture1D<TPixel> texture, TPixel value)
        where TPixel : unmanaged
    {
        Guard.IsNotNull(texture);

        (D3D12_GPU_DESCRIPTOR_HANDLE Gpu, D3D12_CPU_DESCRIPTOR_HANDLE Cpu) handles = ((GraphicsResourceHelper.IGraphicsResource)texture).ValidateAndGetGpuAndCpuDescriptorHandlesForClear(context.GraphicsDevice, out _);

        using ReferenceTracker.Lease lease = default;

        context.Fill(
            ((GraphicsResourceHelper.IGraphicsResource)texture).ValidateAndGetID3D12Resource(context.GraphicsDevice, out Unsafe.AsRef(in lease)),
            handles.Gpu,
            handles.Cpu,
            DXGIFormatHelper.ExtendToNormalizedValue(value));
    }

    /// <summary>
    /// Fills a specific texture with a given value.
    /// </summary>
    /// <typeparam name="TPixel">The type of pixels stored on the texture.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to fill the resource.</param>
    /// <param name="texture">The input <see cref="IReadWriteNormalizedTexture2D{TPixel}"/> instance to fill.</param>
    /// <param name="value">The value to use to fill <paramref name="texture"/>.</param>
    public static unsafe void Fill<TPixel>(this in ComputeContext context, IReadWriteNormalizedTexture2D<TPixel> texture, TPixel value)
        where TPixel : unmanaged
    {
        Guard.IsNotNull(texture);

        (D3D12_GPU_DESCRIPTOR_HANDLE Gpu, D3D12_CPU_DESCRIPTOR_HANDLE Cpu) handles = ((GraphicsResourceHelper.IGraphicsResource)texture).ValidateAndGetGpuAndCpuDescriptorHandlesForClear(context.GraphicsDevice, out _);

        using ReferenceTracker.Lease lease = default;

        context.Fill(
            ((GraphicsResourceHelper.IGraphicsResource)texture).ValidateAndGetID3D12Resource(context.GraphicsDevice, out Unsafe.AsRef(in lease)),
            handles.Gpu,
            handles.Cpu,
            DXGIFormatHelper.ExtendToNormalizedValue(value));
    }

    /// <summary>
    /// Fills a specific texture with a given value.
    /// </summary>
    /// <typeparam name="TPixel">The type of pixels stored on the texture.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to fill the resource.</param>
    /// <param name="texture">The input <see cref="IReadWriteNormalizedTexture3D{TPixel}"/> instance to fill.</param>
    /// <param name="value">The value to use to fill <paramref name="texture"/>.</param>
    public static unsafe void Fill<TPixel>(this in ComputeContext context, IReadWriteNormalizedTexture3D<TPixel> texture, TPixel value)
        where TPixel : unmanaged
    {
        Guard.IsNotNull(texture);

        (D3D12_GPU_DESCRIPTOR_HANDLE Gpu, D3D12_CPU_DESCRIPTOR_HANDLE Cpu) handles = ((GraphicsResourceHelper.IGraphicsResource)texture).ValidateAndGetGpuAndCpuDescriptorHandlesForClear(context.GraphicsDevice, out _);

        using ReferenceTracker.Lease lease = default;

        context.Fill(
            ((GraphicsResourceHelper.IGraphicsResource)texture).ValidateAndGetID3D12Resource(context.GraphicsDevice, out Unsafe.AsRef(in lease)),
            handles.Gpu,
            handles.Cpu,
            DXGIFormatHelper.ExtendToNormalizedValue(value));
    }

    /// <summary>
    /// Runs the input shader on a target <see cref="ComputeContext"/> instance, with the specified parameters.
    /// </summary>
    /// <typeparam name="T">The type of compute shader to run.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to run the shader.</param>
    /// <param name="x">The number of iterations to run on the X axis.</param>
    /// <param name="shader">The input <typeparamref name="T"/> instance representing the compute shader to run.</param>
    public static void For<T>(this in ComputeContext context, int x, in T shader)
        where T : struct, IComputeShader
    {
        context.Run(x, ref Unsafe.AsRef(in shader));
    }

    /// <summary>
    /// Runs the input shader on a target <see cref="ComputeContext"/> instance, with the specified parameters.
    /// </summary>
    /// <typeparam name="T">The type of compute shader to run.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to run the shader.</param>
    /// <param name="x">The number of iterations to run on the X axis.</param>
    /// <param name="y">The number of iterations to run on the Y axis.</param>
    /// <param name="shader">The input <typeparamref name="T"/> instance representing the compute shader to run.</param>
    public static void For<T>(this in ComputeContext context, int x, int y, in T shader)
        where T : struct, IComputeShader
    {
        context.Run(x, y, ref Unsafe.AsRef(in shader));
    }

    /// <summary>
    /// Runs the input shader on a target <see cref="ComputeContext"/> instance, with the specified parameters.
    /// </summary>
    /// <typeparam name="T">The type of compute shader to run.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to run the shader.</param>
    /// <param name="x">The number of iterations to run on the X axis.</param>
    /// <param name="y">The number of iterations to run on the Y axis.</param>
    /// <param name="z">The number of iterations to run on the Z axis.</param>
    /// <param name="shader">The input <typeparamref name="T"/> instance representing the compute shader to run.</param>
    public static void For<T>(this in ComputeContext context, int x, int y, int z, in T shader)
        where T : struct, IComputeShader
    {
        context.Run(x, y, z, ref Unsafe.AsRef(in shader));
    }

    /// <summary>
    /// Runs the input shader on a target <see cref="ComputeContext"/> instance, with the specified parameters.
    /// </summary>
    /// <typeparam name="T">The type of compute shader to run.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to run the shader.</param>
    /// <param name="x">The number of iterations to run on the X axis.</param>
    /// <param name="y">The number of iterations to run on the Y axis.</param>
    /// <param name="z">The number of iterations to run on the Z axis.</param>
    /// <param name="threadsX">The number of threads in each thread group for the X axis.</param>
    /// <param name="threadsY">The number of threads in each thread group for the Y axis.</param>
    /// <param name="threadsZ">The number of threads in each thread group for the Z axis.</param>
    /// <param name="shader">The input <typeparamref name="T"/> instance representing the compute shader to run.</param>
    public static void For<T>(this in ComputeContext context, int x, int y, int z, int threadsX, int threadsY, int threadsZ, in T shader)
        where T : struct, IComputeShader
    {
        context.Run(x, y, z, threadsX, threadsY, threadsZ, ref Unsafe.AsRef(in shader));
    }

    /// <summary>
    /// Runs the input shader on a target <see cref="ComputeContext"/> instance, with the specified parameters.
    /// </summary>
    /// <typeparam name="T">The type of pixel shader to run.</typeparam>
    /// <typeparam name="TPixel">The type of pixels being processed by the shader.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to run the shader.</param>
    /// <param name="texture">The target texture to apply the pixel shader to.</param>
    public static void ForEach<T, TPixel>(this in ComputeContext context, IReadWriteNormalizedTexture2D<TPixel> texture)
        where T : struct, IPixelShader<TPixel>
        where TPixel : unmanaged
    {
        Guard.IsNotNull(texture);

        context.Run(texture, ref Unsafe.AsRef(default(T)));
    }

    /// <summary>
    /// Runs the input shader on a target <see cref="ComputeContext"/> instance, with the specified parameters.
    /// </summary>
    /// <typeparam name="T">The type of pixel shader to run.</typeparam>
    /// <typeparam name="TPixel">The type of pixels being processed by the shader.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to run the shader.</param>
    /// <param name="texture">The target texture to apply the pixel shader to.</param>
    /// <param name="shader">The input <typeparamref name="T"/> instance representing the pixel shader to run.</param>
    public static void ForEach<T, TPixel>(this in ComputeContext context, IReadWriteNormalizedTexture2D<TPixel> texture, in T shader)
        where T : struct, IPixelShader<TPixel>
        where TPixel : unmanaged
    {
        Guard.IsNotNull(texture);

        context.Run(texture, ref Unsafe.AsRef(in shader));
    }

    /// <summary>
    /// Transitions the state of a specific resource.
    /// </summary>
    /// <param name="context">The <see cref="ComputeContext"/> to use to transition the resource.</param>
    /// <param name="texture">The input <see cref="ReadWriteTexture1D{T}"/> instance to transition.</param>
    /// <param name="resourceState">The state to transition the input resource to.</param>
    public static unsafe void Transition(this in ComputeContext context, ReadWriteTexture1D<float> texture, ResourceState resourceState)
    {
        Guard.IsNotNull(texture);

        using ReferenceTracker.Lease lease = default;

        (D3D12_RESOURCE_STATES Before, D3D12_RESOURCE_STATES After) states = texture.ValidateAndGetID3D12ResourceAndTransitionStates(context.GraphicsDevice, resourceState, out ID3D12Resource* d3D12Resource, out Unsafe.AsRef(in lease));

        context.Transition(d3D12Resource, states.Before, states.After);
    }

    /// <summary>
    /// Transitions the state of a specific resource.
    /// </summary>
    /// <param name="context">The <see cref="ComputeContext"/> to use to transition the resource.</param>
    /// <param name="texture">The input <see cref="ReadWriteTexture1D{T}"/> instance to transition.</param>
    /// <param name="resourceState">The state to transition the input resource to.</param>
    public static unsafe void Transition(this in ComputeContext context, ReadWriteTexture1D<Float2> texture, ResourceState resourceState)
    {
        Guard.IsNotNull(texture);

        using ReferenceTracker.Lease lease = default;

        (D3D12_RESOURCE_STATES Before, D3D12_RESOURCE_STATES After) states = texture.ValidateAndGetID3D12ResourceAndTransitionStates(context.GraphicsDevice, resourceState, out ID3D12Resource* d3D12Resource, out Unsafe.AsRef(in lease));

        context.Transition(d3D12Resource, states.Before, states.After);
    }

    /// <summary>
    /// Transitions the state of a specific resource.
    /// </summary>
    /// <param name="context">The <see cref="ComputeContext"/> to use to transition the resource.</param>
    /// <param name="texture">The input <see cref="ReadWriteTexture1D{T}"/> instance to transition.</param>
    /// <param name="resourceState">The state to transition the input resource to.</param>
    public static unsafe void Transition(this in ComputeContext context, ReadWriteTexture1D<Float3> texture, ResourceState resourceState)
    {
        Guard.IsNotNull(texture);

        using ReferenceTracker.Lease lease = default;

        (D3D12_RESOURCE_STATES Before, D3D12_RESOURCE_STATES After) states = texture.ValidateAndGetID3D12ResourceAndTransitionStates(context.GraphicsDevice, resourceState, out ID3D12Resource* d3D12Resource, out Unsafe.AsRef(in lease));

        context.Transition(d3D12Resource, states.Before, states.After);
    }

    /// <summary>
    /// Transitions the state of a specific resource.
    /// </summary>
    /// <param name="context">The <see cref="ComputeContext"/> to use to transition the resource.</param>
    /// <param name="texture">The input <see cref="ReadWriteTexture1D{T}"/> instance to transition.</param>
    /// <param name="resourceState">The state to transition the input resource to.</param>
    public static unsafe void Transition(this in ComputeContext context, ReadWriteTexture1D<Float4> texture, ResourceState resourceState)
    {
        Guard.IsNotNull(texture);

        using ReferenceTracker.Lease lease = default;

        (D3D12_RESOURCE_STATES Before, D3D12_RESOURCE_STATES After) states = texture.ValidateAndGetID3D12ResourceAndTransitionStates(context.GraphicsDevice, resourceState, out ID3D12Resource* d3D12Resource, out Unsafe.AsRef(in lease));

        context.Transition(d3D12Resource, states.Before, states.After);
    }

    /// <summary>
    /// Transitions the state of a specific resource.
    /// </summary>
    /// <typeparam name="T">The type of items stored on the texture.</typeparam>
    /// <typeparam name="TPixel">The type of pixels used on the GPU side.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to transition the resource.</param>
    /// <param name="texture">The input <see cref="ReadWriteTexture1D{T,TPixel}"/> instance to transition.</param>
    /// <param name="resourceState">The state to transition the input resource to.</param>
    public static unsafe void Transition<T, TPixel>(this in ComputeContext context, ReadWriteTexture1D<T, TPixel> texture, ResourceState resourceState)
        where T : unmanaged, IPixel<T, TPixel>
        where TPixel : unmanaged
    {
        Guard.IsNotNull(texture);

        using ReferenceTracker.Lease lease = default;

        (D3D12_RESOURCE_STATES Before, D3D12_RESOURCE_STATES After) states = texture.ValidateAndGetID3D12ResourceAndTransitionStates(context.GraphicsDevice, resourceState, out ID3D12Resource* d3D12Resource, out Unsafe.AsRef(in lease));

        context.Transition(d3D12Resource, states.Before, states.After);
    }

    /// <summary>
    /// Transitions the state of a specific resource.
    /// </summary>
    /// <param name="context">The <see cref="ComputeContext"/> to use to transition the resource.</param>
    /// <param name="texture">The input <see cref="ReadWriteTexture2D{T}"/> instance to transition.</param>
    /// <param name="resourceState">The state to transition the input resource to.</param>
    public static unsafe void Transition(this in ComputeContext context, ReadWriteTexture2D<float> texture, ResourceState resourceState)
    {
        Guard.IsNotNull(texture);

        using ReferenceTracker.Lease lease = default;

        (D3D12_RESOURCE_STATES Before, D3D12_RESOURCE_STATES After) states = texture.ValidateAndGetID3D12ResourceAndTransitionStates(context.GraphicsDevice, resourceState, out ID3D12Resource* d3D12Resource, out Unsafe.AsRef(in lease));

        context.Transition(d3D12Resource, states.Before, states.After);
    }

    /// <summary>
    /// Transitions the state of a specific resource.
    /// </summary>
    /// <param name="context">The <see cref="ComputeContext"/> to use to transition the resource.</param>
    /// <param name="texture">The input <see cref="ReadWriteTexture2D{T}"/> instance to transition.</param>
    /// <param name="resourceState">The state to transition the input resource to.</param>
    public static unsafe void Transition(this in ComputeContext context, ReadWriteTexture2D<Float2> texture, ResourceState resourceState)
    {
        Guard.IsNotNull(texture);

        using ReferenceTracker.Lease lease = default;

        (D3D12_RESOURCE_STATES Before, D3D12_RESOURCE_STATES After) states = texture.ValidateAndGetID3D12ResourceAndTransitionStates(context.GraphicsDevice, resourceState, out ID3D12Resource* d3D12Resource, out Unsafe.AsRef(in lease));

        context.Transition(d3D12Resource, states.Before, states.After);
    }

    /// <summary>
    /// Transitions the state of a specific resource.
    /// </summary>
    /// <param name="context">The <see cref="ComputeContext"/> to use to transition the resource.</param>
    /// <param name="texture">The input <see cref="ReadWriteTexture2D{T}"/> instance to transition.</param>
    /// <param name="resourceState">The state to transition the input resource to.</param>
    public static unsafe void Transition(this in ComputeContext context, ReadWriteTexture2D<Float3> texture, ResourceState resourceState)
    {
        Guard.IsNotNull(texture);

        using ReferenceTracker.Lease lease = default;

        (D3D12_RESOURCE_STATES Before, D3D12_RESOURCE_STATES After) states = texture.ValidateAndGetID3D12ResourceAndTransitionStates(context.GraphicsDevice, resourceState, out ID3D12Resource* d3D12Resource, out Unsafe.AsRef(in lease));

        context.Transition(d3D12Resource, states.Before, states.After);
    }

    /// <summary>
    /// Transitions the state of a specific resource.
    /// </summary>
    /// <param name="context">The <see cref="ComputeContext"/> to use to transition the resource.</param>
    /// <param name="texture">The input <see cref="ReadWriteTexture2D{T}"/> instance to transition.</param>
    /// <param name="resourceState">The state to transition the input resource to.</param>
    public static unsafe void Transition(this in ComputeContext context, ReadWriteTexture2D<Float4> texture, ResourceState resourceState)
    {
        Guard.IsNotNull(texture);

        using ReferenceTracker.Lease lease = default;

        (D3D12_RESOURCE_STATES Before, D3D12_RESOURCE_STATES After) states = texture.ValidateAndGetID3D12ResourceAndTransitionStates(context.GraphicsDevice, resourceState, out ID3D12Resource* d3D12Resource, out Unsafe.AsRef(in lease));

        context.Transition(d3D12Resource, states.Before, states.After);
    }

    /// <summary>
    /// Transitions the state of a specific resource.
    /// </summary>
    /// <typeparam name="T">The type of items stored on the texture.</typeparam>
    /// <typeparam name="TPixel">The type of pixels used on the GPU side.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to transition the resource.</param>
    /// <param name="texture">The input <see cref="ReadWriteTexture2D{T,TPixel}"/> instance to transition.</param>
    /// <param name="resourceState">The state to transition the input resource to.</param>
    public static unsafe void Transition<T, TPixel>(this in ComputeContext context, ReadWriteTexture2D<T, TPixel> texture, ResourceState resourceState)
        where T : unmanaged, IPixel<T, TPixel>
        where TPixel : unmanaged
    {
        Guard.IsNotNull(texture);

        using ReferenceTracker.Lease lease = default;

        (D3D12_RESOURCE_STATES Before, D3D12_RESOURCE_STATES After) states = texture.ValidateAndGetID3D12ResourceAndTransitionStates(context.GraphicsDevice, resourceState, out ID3D12Resource* d3D12Resource, out Unsafe.AsRef(in lease));

        context.Transition(d3D12Resource, states.Before, states.After);
    }

    /// <summary>
    /// Transitions the state of a specific resource.
    /// </summary>
    /// <param name="context">The <see cref="ComputeContext"/> to use to transition the resource.</param>
    /// <param name="texture">The input <see cref="ReadWriteTexture3D{T}"/> instance to transition.</param>
    /// <param name="resourceState">The state to transition the input resource to.</param>
    public static unsafe void Transition(this in ComputeContext context, ReadWriteTexture3D<float> texture, ResourceState resourceState)
    {
        Guard.IsNotNull(texture);

        using ReferenceTracker.Lease lease = default;

        (D3D12_RESOURCE_STATES Before, D3D12_RESOURCE_STATES After) states = texture.ValidateAndGetID3D12ResourceAndTransitionStates(context.GraphicsDevice, resourceState, out ID3D12Resource* d3D12Resource, out Unsafe.AsRef(in lease));

        context.Transition(d3D12Resource, states.Before, states.After);
    }

    /// <summary>
    /// Transitions the state of a specific resource.
    /// </summary>
    /// <param name="context">The <see cref="ComputeContext"/> to use to transition the resource.</param>
    /// <param name="texture">The input <see cref="ReadWriteTexture3D{T}"/> instance to transition.</param>
    /// <param name="resourceState">The state to transition the input resource to.</param>
    public static unsafe void Transition(this in ComputeContext context, ReadWriteTexture3D<Float2> texture, ResourceState resourceState)
    {
        Guard.IsNotNull(texture);

        using ReferenceTracker.Lease lease = default;

        (D3D12_RESOURCE_STATES Before, D3D12_RESOURCE_STATES After) states = texture.ValidateAndGetID3D12ResourceAndTransitionStates(context.GraphicsDevice, resourceState, out ID3D12Resource* d3D12Resource, out Unsafe.AsRef(in lease));

        context.Transition(d3D12Resource, states.Before, states.After);
    }

    /// <summary>
    /// Transitions the state of a specific resource.
    /// </summary>
    /// <param name="context">The <see cref="ComputeContext"/> to use to transition the resource.</param>
    /// <param name="texture">The input <see cref="ReadWriteTexture3D{T}"/> instance to transition.</param>
    /// <param name="resourceState">The state to transition the input resource to.</param>
    public static unsafe void Transition(this in ComputeContext context, ReadWriteTexture3D<Float3> texture, ResourceState resourceState)
    {
        Guard.IsNotNull(texture);

        using ReferenceTracker.Lease lease = default;

        (D3D12_RESOURCE_STATES Before, D3D12_RESOURCE_STATES After) states = texture.ValidateAndGetID3D12ResourceAndTransitionStates(context.GraphicsDevice, resourceState, out ID3D12Resource* d3D12Resource, out Unsafe.AsRef(in lease));

        context.Transition(d3D12Resource, states.Before, states.After);
    }

    /// <summary>
    /// Transitions the state of a specific resource.
    /// </summary>
    /// <param name="context">The <see cref="ComputeContext"/> to use to transition the resource.</param>
    /// <param name="texture">The input <see cref="ReadWriteTexture3D{T}"/> instance to transition.</param>
    /// <param name="resourceState">The state to transition the input resource to.</param>
    public static unsafe void Transition(this in ComputeContext context, ReadWriteTexture3D<Float4> texture, ResourceState resourceState)
    {
        Guard.IsNotNull(texture);

        using ReferenceTracker.Lease lease = default;

        (D3D12_RESOURCE_STATES Before, D3D12_RESOURCE_STATES After) states = texture.ValidateAndGetID3D12ResourceAndTransitionStates(context.GraphicsDevice, resourceState, out ID3D12Resource* d3D12Resource, out Unsafe.AsRef(in lease));

        context.Transition(d3D12Resource, states.Before, states.After);
    }

    /// <summary>
    /// Transitions the state of a specific resource.
    /// </summary>
    /// <typeparam name="T">The type of items stored on the texture.</typeparam>
    /// <typeparam name="TPixel">The type of pixels used on the GPU side.</typeparam>
    /// <param name="context">The <see cref="ComputeContext"/> to use to transition the resource.</param>
    /// <param name="texture">The input <see cref="ReadWriteTexture3D{T,TPixel}"/> instance to transition.</param>
    /// <param name="resourceState">The state to transition the input resource to.</param>
    public static unsafe void Transition<T, TPixel>(this in ComputeContext context, ReadWriteTexture3D<T, TPixel> texture, ResourceState resourceState)
        where T : unmanaged, IPixel<T, TPixel>
        where TPixel : unmanaged
    {
        Guard.IsNotNull(texture);

        using ReferenceTracker.Lease lease = default;

        (D3D12_RESOURCE_STATES Before, D3D12_RESOURCE_STATES After) states = texture.ValidateAndGetID3D12ResourceAndTransitionStates(context.GraphicsDevice, resourceState, out ID3D12Resource* d3D12Resource, out Unsafe.AsRef(in lease));

        context.Transition(d3D12Resource, states.Before, states.After);
    }
}