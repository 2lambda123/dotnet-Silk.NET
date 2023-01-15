// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkValidationCheckEXT")]
    public enum ValidationCheckEXT : int
    {
        [Obsolete("Deprecated in favour of \"AllExt\"")]
        [NativeName("Name", "VK_VALIDATION_CHECK_ALL_EXT")]
        ValidationCheckAllExt = 0,
        [Obsolete("Deprecated in favour of \"ShadersExt\"")]
        [NativeName("Name", "VK_VALIDATION_CHECK_SHADERS_EXT")]
        ValidationCheckShadersExt = 1,
        [NativeName("Name", "VK_VALIDATION_CHECK_ALL_EXT")]
        AllExt = 0,
        [NativeName("Name", "VK_VALIDATION_CHECK_SHADERS_EXT")]
        ShadersExt = 1,
    }
}
