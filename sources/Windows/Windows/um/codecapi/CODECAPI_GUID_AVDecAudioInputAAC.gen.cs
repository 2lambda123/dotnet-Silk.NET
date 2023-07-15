// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='CODECAPI_GUID_AVDecAudioInputAAC.xml' path='doc/member[@name="CODECAPI_GUID_AVDecAudioInputAAC"]/*'/>
[Guid("97DF7828-B94A-47E2-A4BC-51194DB22A4D")]
public unsafe partial struct CODECAPI_GUID_AVDecAudioInputAAC : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_GUID_AVDecAudioInputAAC));
}