// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

internal unsafe partial struct D3D12_RESOURCE_TRANSITION_BARRIER
{
    public ID3D12Resource* pResource;

    public uint Subresource;

    public D3D12_RESOURCE_STATES StateBefore;

    public D3D12_RESOURCE_STATES StateAfter;
}