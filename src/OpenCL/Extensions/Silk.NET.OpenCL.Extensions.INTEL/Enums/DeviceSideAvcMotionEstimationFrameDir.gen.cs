// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [Flags]
    [NativeName("Name", "cl_intel_device_side_avc_motion_estimation.frame.dir")]
    public enum DeviceSideAvcMotionEstimationFrameDir : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_AVC_ME_FRAME_FORWARD_INTEL")]
        Forward = 0x1,
        [NativeName("Name", "CL_AVC_ME_FRAME_BACKWARD_INTEL")]
        Backward = 0x2,
        [NativeName("Name", "CL_AVC_ME_FRAME_DUAL_INTEL")]
        Dual = 0x3,
    }
}
