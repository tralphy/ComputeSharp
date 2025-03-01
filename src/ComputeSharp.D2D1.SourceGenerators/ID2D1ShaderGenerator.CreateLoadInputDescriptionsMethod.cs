using System;
using System.Collections.Immutable;
using ComputeSharp.D2D1.SourceGenerators.Models;
using ComputeSharp.SourceGeneration.Extensions;
using ComputeSharp.SourceGeneration.Helpers;
using ComputeSharp.SourceGeneration.Models;
using Microsoft.CodeAnalysis;
using static ComputeSharp.SourceGeneration.Diagnostics.DiagnosticDescriptors;

namespace ComputeSharp.D2D1.SourceGenerators;

/// <inheritdoc/>
partial class ID2D1ShaderGenerator
{
    /// <summary>
    /// A helper with all logic to generate the <c>LoadInputDescriptions</c> method.
    /// </summary>
    private static partial class LoadInputDescriptions
    {
        /// <summary>
        /// Extracts the input descriptions for the current shader.
        /// </summary>
        /// <param name="diagnostics">The collection of produced <see cref="DiagnosticInfo"/> instances.</param>
        /// <param name="structDeclarationSymbol">The input <see cref="INamedTypeSymbol"/> instance to process.</param>
        /// <param name="inputDescriptions">The produced input descriptions for the shader.</param>
        public static void GetInfo(
            ImmutableArrayBuilder<DiagnosticInfo> diagnostics,
            INamedTypeSymbol structDeclarationSymbol,
            out ImmutableArray<InputDescription> inputDescriptions)
        {
            int inputCount = 0;

            using ImmutableArrayBuilder<InputDescription> inputDescriptionsBuilder = ImmutableArrayBuilder<InputDescription>.Rent();

            foreach (AttributeData attributeData in structDeclarationSymbol.GetAttributes())
            {
                switch (attributeData.AttributeClass?.GetFullyQualifiedMetadataName())
                {
                    case "ComputeSharp.D2D1.D2DInputCountAttribute":
                        inputCount = (int)attributeData.ConstructorArguments[0].Value!;
                        break;
                    case "ComputeSharp.D2D1.D2DInputDescriptionAttribute":
                        if (attributeData.ConstructorArguments.Length == 2)
                        {
                            int index = (int)attributeData.ConstructorArguments[0].Value!;
                            D2D1Filter filter = (D2D1Filter)attributeData.ConstructorArguments[1].Value!;

                            _ = attributeData.TryGetNamedArgument("LevelOfDetailCount", out int levelOfDetailCount);

                            inputDescriptionsBuilder.Add(new InputDescription((uint)index, filter, levelOfDetailCount));
                        }

                        break;
                    default:
                        break;
                }
            }

            inputDescriptions = ImmutableArray<InputDescription>.Empty;

            // Validate the input count (ignore if invalid, this will be validated by GetInputType() generator)
            if (inputCount is not (>= 0 and <= 8))
            {
                return;
            }

            // All simple indices must be in range
            foreach (InputDescription inputDescription in inputDescriptionsBuilder.WrittenSpan)
            {
                if (inputDescription.Index >= inputCount)
                {
                    diagnostics.Add(OutOfRangeInputDescriptionIndex, structDeclarationSymbol, structDeclarationSymbol);

                    return;
                }
            }

            Span<bool> selectedInputDescriptionIndices = stackalloc bool[8];

            selectedInputDescriptionIndices.Clear();

            // All input description indices must be unique
            foreach (InputDescription inputDescription in inputDescriptionsBuilder.WrittenSpan)
            {
                ref bool isInputDescriptionIndexUsed = ref selectedInputDescriptionIndices[(int)inputDescription.Index];

                if (isInputDescriptionIndexUsed)
                {
                    diagnostics.Add(RepeatedD2DInputDescriptionIndices, structDeclarationSymbol, structDeclarationSymbol);

                    return;
                }

                isInputDescriptionIndexUsed = true;
            }

            inputDescriptions = inputDescriptionsBuilder.ToImmutable();
        }
    }
}