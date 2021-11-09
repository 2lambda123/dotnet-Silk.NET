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
    [NativeName("Name", "VkPhysicalDeviceFragmentShadingRateKHR")]
    public unsafe partial struct PhysicalDeviceFragmentShadingRateKHR : IStructuredType
    {
        public PhysicalDeviceFragmentShadingRateKHR
        (
            StructureType? sType = StructureType.PhysicalDeviceFragmentShadingRateKhr,
            void* pNext = null,
            SampleCountFlags? sampleCounts = null,
            Extent2D? fragmentSize = null
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

            if (sampleCounts is not null)
            {
                SampleCounts = sampleCounts.Value;
            }

            if (fragmentSize is not null)
            {
                FragmentSize = fragmentSize.Value;
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
        [NativeName("Type", "VkSampleCountFlags")]
        [NativeName("Type.Name", "VkSampleCountFlags")]
        [NativeName("Name", "sampleCounts")]
        public SampleCountFlags SampleCounts;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "fragmentSize")]
        public Extent2D FragmentSize;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceFragmentShadingRateKhr;
        }
    }
}
