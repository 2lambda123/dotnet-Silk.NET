// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/processthreadsapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='PROCESS_MEMORY_EXHAUSTION_INFO.xml' path='doc/member[@name="PROCESS_MEMORY_EXHAUSTION_INFO"]/*'/>
[SupportedOSPlatform("windows10.0.10586.0")]
public partial struct PROCESS_MEMORY_EXHAUSTION_INFO
{
    /// <include file='PROCESS_MEMORY_EXHAUSTION_INFO.xml' path='doc/member[@name="PROCESS_MEMORY_EXHAUSTION_INFO.Version"]/*'/>
    public ushort Version;
    /// <include file='PROCESS_MEMORY_EXHAUSTION_INFO.xml' path='doc/member[@name="PROCESS_MEMORY_EXHAUSTION_INFO.Reserved"]/*'/>
    public ushort Reserved;
    /// <include file='PROCESS_MEMORY_EXHAUSTION_INFO.xml' path='doc/member[@name="PROCESS_MEMORY_EXHAUSTION_INFO.Type"]/*'/>
    public PROCESS_MEMORY_EXHAUSTION_TYPE Type;
    /// <include file='PROCESS_MEMORY_EXHAUSTION_INFO.xml' path='doc/member[@name="PROCESS_MEMORY_EXHAUSTION_INFO.Value"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint Value;
}