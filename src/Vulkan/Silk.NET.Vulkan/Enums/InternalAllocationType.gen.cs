// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan;

[NativeName("Name", "VkInternalAllocationType")]
public enum InternalAllocationType : int
{
    [NativeName("Name", "VK_INTERNAL_ALLOCATION_TYPE_EXECUTABLE")]
    Executable = 0,
}
