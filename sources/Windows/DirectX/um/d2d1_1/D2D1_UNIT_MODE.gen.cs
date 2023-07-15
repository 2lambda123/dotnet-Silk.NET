// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_UNIT_MODE.xml' path='doc/member[@name="D2D1_UNIT_MODE"]/*'/>
public enum D2D1_UNIT_MODE
{
    /// <include file='D2D1_UNIT_MODE.xml' path='doc/member[@name="D2D1_UNIT_MODE.D2D1_UNIT_MODE_DIPS"]/*'/>
    D2D1_UNIT_MODE_DIPS = 0,
    /// <include file='D2D1_UNIT_MODE.xml' path='doc/member[@name="D2D1_UNIT_MODE.D2D1_UNIT_MODE_PIXELS"]/*'/>
    D2D1_UNIT_MODE_PIXELS = 1,
    /// <include file='D2D1_UNIT_MODE.xml' path='doc/member[@name="D2D1_UNIT_MODE.D2D1_UNIT_MODE_FORCE_DWORD"]/*'/>
    D2D1_UNIT_MODE_FORCE_DWORD = unchecked((int)(0xffffffff)),
}