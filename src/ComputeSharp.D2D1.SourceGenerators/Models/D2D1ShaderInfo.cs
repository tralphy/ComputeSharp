using ComputeSharp.SourceGeneration.Helpers;
using ComputeSharp.SourceGeneration.Models;

namespace ComputeSharp.D2D1.SourceGenerators.Models;

/// <summary>
/// A model representing all necessary info for a full generation pass for a D2D1 shader.
/// </summary>
/// <param name="Hierarchy">The hierarchy info for the shader type.</param>
/// <param name="DispatchData">The gathered shader dispatch data.</param>
/// <param name="InputTypes">The gathered input types for the shader.</param>
/// <param name="ResourceTextureDescriptions">The gathered resource texture descriptions for the shader.</param>
/// <param name="HlslShaderSource">The processed HLSL source for the shader.</param>
/// <param name="OutputBuffer">The output buffer info for the shader.</param>
/// <param name="InputDescriptions">The gathered input descriptions for the shader.</param>
/// <param name="PixelOptions">The pixel options used by the shader.</param>
/// <param name="Diagnostcs">The discovered diagnostics, if any.</param>
internal sealed record D2D1ShaderInfo(
    HierarchyInfo Hierarchy,
    DispatchDataInfo DispatchData,
    InputTypesInfo InputTypes,
    ResourceTextureDescriptionsInfo ResourceTextureDescriptions,
    HlslShaderSourceInfo HlslShaderSource,
    OutputBufferInfo OutputBuffer,
    InputDescriptionsInfo InputDescriptions,
    D2D1PixelOptions PixelOptions,
    EquatableArray<DiagnosticInfo> Diagnostcs);