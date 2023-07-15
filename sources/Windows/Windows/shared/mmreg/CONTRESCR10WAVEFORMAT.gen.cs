// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='CONTRESCR10WAVEFORMAT.xml' path='doc/member[@name="CONTRESCR10WAVEFORMAT"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct CONTRESCR10WAVEFORMAT
{
    /// <include file='CONTRESCR10WAVEFORMAT.xml' path='doc/member[@name="CONTRESCR10WAVEFORMAT.wfx"]/*'/>
    public WAVEFORMATEX wfx;
    /// <include file='CONTRESCR10WAVEFORMAT.xml' path='doc/member[@name="CONTRESCR10WAVEFORMAT.wSamplesPerBlock"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wSamplesPerBlock;
}