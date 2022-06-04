// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrHandJointSetEXT")]
    public enum HandJointSetEXT : int
    {
        [NativeName("Name", "XR_HAND_JOINT_SET_DEFAULT_EXT")]
        HandJointSetDefaultExt = 0,
        [NativeName("Name", "XR_HAND_JOINT_SET_HAND_WITH_FOREARM_ULTRALEAP")]
        HandJointSetHandWithForearmUltraleap = 1000149000,
    }
}
