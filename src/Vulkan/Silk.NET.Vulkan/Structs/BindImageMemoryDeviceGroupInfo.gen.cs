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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkBindImageMemoryDeviceGroupInfo")]
    public unsafe partial struct BindImageMemoryDeviceGroupInfo : IStructuredType
    {
        public BindImageMemoryDeviceGroupInfo
        (
            StructureType? sType = StructureType.BindImageMemoryDeviceGroupInfo,
            void* pNext = null,
            uint? deviceIndexCount = null,
            uint* pDeviceIndices = null,
            uint? splitInstanceBindRegionCount = null,
            Rect2D* pSplitInstanceBindRegions = null
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

            if (deviceIndexCount is not null)
            {
                DeviceIndexCount = deviceIndexCount.Value;
            }

            if (pDeviceIndices is not null)
            {
                PDeviceIndices = pDeviceIndices;
            }

            if (splitInstanceBindRegionCount is not null)
            {
                SplitInstanceBindRegionCount = splitInstanceBindRegionCount.Value;
            }

            if (pSplitInstanceBindRegions is not null)
            {
                PSplitInstanceBindRegions = pSplitInstanceBindRegions;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "deviceIndexCount")]
        public uint DeviceIndexCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pDeviceIndices")]
        public uint* PDeviceIndices;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "splitInstanceBindRegionCount")]
        public uint SplitInstanceBindRegionCount;
/// <summary></summary>
        [NativeName("Type", "VkRect2D*")]
        [NativeName("Type.Name", "VkRect2D")]
        [NativeName("Name", "pSplitInstanceBindRegions")]
        public Rect2D* PSplitInstanceBindRegions;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.BindImageMemoryDeviceGroupInfo;
        }
    }
}
