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

[NativeName("Name", "VkAccelerationStructureGeometryInstancesDataKHR")]
public unsafe partial struct AccelerationStructureGeometryInstancesDataKHR
{
    public AccelerationStructureGeometryInstancesDataKHR
    (
            StructureType? sType = StructureType.AccelerationStructureGeometryInstancesDataKhr,
            void* pNext = null,
            Bool32? arrayOfPointers = null,
            DeviceOrHostAddressConstKHR? data = null
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

        if (arrayOfPointers is not null)
        {
            ArrayOfPointers = arrayOfPointers.Value;
        }

        if (data is not null)
        {
            Data = data.Value;
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
    [NativeName("Type", "VkBool32")]
    [NativeName("Type.Name", "VkBool32")]
    [NativeName("Name", "arrayOfPointers")]
    public Bool32 ArrayOfPointers;
/// <summary></summary>
    [NativeName("Type", "VkDeviceOrHostAddressConstKHR")]
    [NativeName("Type.Name", "VkDeviceOrHostAddressConstKHR")]
    [NativeName("Name", "data")]
    public DeviceOrHostAddressConstKHR Data;
}
