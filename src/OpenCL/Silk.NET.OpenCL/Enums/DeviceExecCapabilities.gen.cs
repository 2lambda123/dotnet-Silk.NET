// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_device_exec_capabilities")]
    public enum DeviceExecCapabilities : ulong
    {
        [NativeName("Name", "CL_EXEC_KERNEL")]
        ExecKernel = 0x1,
        [NativeName("Name", "CL_EXEC_NATIVE_KERNEL")]
        ExecNativeKernel = 0x2,
    }
}
