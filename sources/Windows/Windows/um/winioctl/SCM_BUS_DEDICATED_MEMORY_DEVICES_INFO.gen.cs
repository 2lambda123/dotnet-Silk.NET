// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='SCM_BUS_DEDICATED_MEMORY_DEVICES_INFO.xml' path='doc/member[@name="SCM_BUS_DEDICATED_MEMORY_DEVICES_INFO"]/*'/>
public partial struct SCM_BUS_DEDICATED_MEMORY_DEVICES_INFO
{
    /// <include file='SCM_BUS_DEDICATED_MEMORY_DEVICES_INFO.xml' path='doc/member[@name="SCM_BUS_DEDICATED_MEMORY_DEVICES_INFO.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='SCM_BUS_DEDICATED_MEMORY_DEVICES_INFO.xml' path='doc/member[@name="SCM_BUS_DEDICATED_MEMORY_DEVICES_INFO.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='SCM_BUS_DEDICATED_MEMORY_DEVICES_INFO.xml' path='doc/member[@name="SCM_BUS_DEDICATED_MEMORY_DEVICES_INFO.DeviceCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DeviceCount;
    /// <include file='SCM_BUS_DEDICATED_MEMORY_DEVICES_INFO.xml' path='doc/member[@name="SCM_BUS_DEDICATED_MEMORY_DEVICES_INFO.Devices"]/*'/>
    [NativeTypeName("SCM_BUS_DEDICATED_MEMORY_DEVICE_INFO[1]")]
    public _Devices_e__FixedBuffer Devices;
    /// <include file='_Devices_e__FixedBuffer.xml' path='doc/member[@name="_Devices_e__FixedBuffer"]/*'/>
    public partial struct _Devices_e__FixedBuffer
    {
        public SCM_BUS_DEDICATED_MEMORY_DEVICE_INFO e0;
        [UnscopedRef]
        public ref SCM_BUS_DEDICATED_MEMORY_DEVICE_INFO this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<SCM_BUS_DEDICATED_MEMORY_DEVICE_INFO> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}