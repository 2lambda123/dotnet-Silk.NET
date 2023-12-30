// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;

/// <include file='D3D12_SUBRESOURCE_RANGE_UINT64.xml' path='doc/member[@name="D3D12_SUBRESOURCE_RANGE_UINT64"]/*'/>
public partial struct D3D12_SUBRESOURCE_RANGE_UINT64
{
    /// <include file='D3D12_SUBRESOURCE_RANGE_UINT64.xml' path='doc/member[@name="D3D12_SUBRESOURCE_RANGE_UINT64.Subresource"]/*'/>

    public uint Subresource;

    /// <include file='D3D12_SUBRESOURCE_RANGE_UINT64.xml' path='doc/member[@name="D3D12_SUBRESOURCE_RANGE_UINT64.Range"]/*'/>

    public D3D12_RANGE_UINT64 Range;
}
