// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [NativeName("Name", "cl_intel_device_side_avc_motion_estimation.minor")]
    public enum IntelDeviceSideAvcMotionEstimationMinor : int
    {
        [NativeName("Name", "CL_AVC_ME_MINOR_8x8_INTEL")]
        Cl8x8 = 0x0,
        [NativeName("Name", "CL_AVC_ME_MINOR_8x4_INTEL")]
        Cl8x4 = 0x1,
        [NativeName("Name", "CL_AVC_ME_MINOR_4x8_INTEL")]
        Cl4x8 = 0x2,
        [NativeName("Name", "CL_AVC_ME_MINOR_4x4_INTEL")]
        Cl4x4 = 0x3,
    }
}
