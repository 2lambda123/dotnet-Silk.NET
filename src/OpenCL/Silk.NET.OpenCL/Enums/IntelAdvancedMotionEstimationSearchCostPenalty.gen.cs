// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_intel_advanced_motion_estimation_search_cost_penalty")]
    public enum IntelAdvancedMotionEstimationSearchCostPenalty : int
    {
        [NativeName("Name", "CL_ME_COST_PENALTY_NONE_INTEL")]
        MECostPenaltyNoneIntel = 0x0,
        [NativeName("Name", "CL_ME_COST_PENALTY_LOW_INTEL")]
        MECostPenaltyLowIntel = 0x1,
        [NativeName("Name", "CL_ME_COST_PENALTY_NORMAL_INTEL")]
        MECostPenaltyNormalIntel = 0x2,
        [NativeName("Name", "CL_ME_COST_PENALTY_HIGH_INTEL")]
        MECostPenaltyHighIntel = 0x3,
    }
}
