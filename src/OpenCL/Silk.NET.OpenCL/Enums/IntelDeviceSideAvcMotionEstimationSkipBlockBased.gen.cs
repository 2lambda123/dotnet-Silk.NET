// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_intel_device_side_avc_motion_estimation_skip_block_based")]
    public enum IntelDeviceSideAvcMotionEstimationSkipBlockBased : int
    {
        [NativeName("Name", "CL_AVC_ME_BLOCK_BASED_SKIP_4x4_INTEL")]
        AvcMEBlockBasedSkip4x4Intel = 0x0,
        [NativeName("Name", "CL_AVC_ME_BLOCK_BASED_SKIP_8x8_INTEL")]
        AvcMEBlockBasedSkip8x8Intel = 0x80,
    }
}
