// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_DEVICE_IO_CAPABILITY_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_IO_CAPABILITY_DESCRIPTOR"]/*'/>
[SupportedOSPlatform("windows10.0")]
public partial struct STORAGE_DEVICE_IO_CAPABILITY_DESCRIPTOR
{
    /// <include file='STORAGE_DEVICE_IO_CAPABILITY_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_IO_CAPABILITY_DESCRIPTOR.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_DEVICE_IO_CAPABILITY_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_IO_CAPABILITY_DESCRIPTOR.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_DEVICE_IO_CAPABILITY_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_IO_CAPABILITY_DESCRIPTOR.LunMaxIoCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint LunMaxIoCount;
    /// <include file='STORAGE_DEVICE_IO_CAPABILITY_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_IO_CAPABILITY_DESCRIPTOR.AdapterMaxIoCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint AdapterMaxIoCount;
}