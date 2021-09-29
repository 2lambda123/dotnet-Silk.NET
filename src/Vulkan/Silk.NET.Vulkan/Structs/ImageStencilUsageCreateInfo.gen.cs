// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan;

[NativeName("Name", "VkImageStencilUsageCreateInfo")]
public unsafe partial struct ImageStencilUsageCreateInfo
{
    public ImageStencilUsageCreateInfo
    (
            StructureType? sType = StructureType.ImageStencilUsageCreateInfo,
            void* pNext = null,
            ImageUsageFlags? stencilUsage = null
    ) : this()
    {
        if (sType is not null)
        {
            SType = sType.Value;
        }

        if (pNext is not null)
        {
            PNext = pNext;
        }

        if (stencilUsage is not null)
        {
            StencilUsage = stencilUsage.Value;
        }
    }

/// <summary></summary>
    [NativeName("Type", "VkStructureType")]
    [NativeName("Type.Name", "VkStructureType")]
    [NativeName("Name", "sType")]
    public StructureType SType;
/// <summary></summary>
    [NativeName("Type", "void*")]
    [NativeName("Type.Name", "void")]
    [NativeName("Name", "pNext")]
    public void* PNext;
/// <summary></summary>
    [NativeName("Type", "VkImageUsageFlags")]
    [NativeName("Type.Name", "VkImageUsageFlags")]
    [NativeName("Name", "stencilUsage")]
    public ImageUsageFlags StencilUsage;
}
