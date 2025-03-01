// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

internal enum D3D12_CROSS_NODE_SHARING_TIER
{
    D3D12_CROSS_NODE_SHARING_TIER_NOT_SUPPORTED = 0,
    D3D12_CROSS_NODE_SHARING_TIER_1_EMULATED = 1,
    D3D12_CROSS_NODE_SHARING_TIER_1 = 2,
    D3D12_CROSS_NODE_SHARING_TIER_2 = 3,
    D3D12_CROSS_NODE_SHARING_TIER_3 = 4,
}