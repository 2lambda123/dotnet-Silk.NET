// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D3D11_MAPPED_SUBRESOURCE.xml' path='doc/member[@name="D3D11_MAPPED_SUBRESOURCE"]/*'/>
public unsafe partial struct D3D11_MAPPED_SUBRESOURCE
{
    /// <include file='D3D11_MAPPED_SUBRESOURCE.xml' path='doc/member[@name="D3D11_MAPPED_SUBRESOURCE.pData"]/*'/>
    public void* pData;
    /// <include file='D3D11_MAPPED_SUBRESOURCE.xml' path='doc/member[@name="D3D11_MAPPED_SUBRESOURCE.RowPitch"]/*'/>
    public uint RowPitch;
    /// <include file='D3D11_MAPPED_SUBRESOURCE.xml' path='doc/member[@name="D3D11_MAPPED_SUBRESOURCE.DepthPitch"]/*'/>
    public uint DepthPitch;
}