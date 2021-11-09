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
    [NativeName("Name", "VkPhysicalDeviceSubgroupSizeControlFeaturesEXT")]
    public unsafe partial struct PhysicalDeviceSubgroupSizeControlFeaturesEXT : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2Khr>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceSubgroupSizeControlFeaturesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceSubgroupSizeControlFeaturesExt,
            void* pNext = null,
            Bool32? subgroupSizeControl = null,
            Bool32? computeFullSubgroups = null
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

            if (subgroupSizeControl is not null)
            {
                SubgroupSizeControl = subgroupSizeControl.Value;
            }

            if (computeFullSubgroups is not null)
            {
                ComputeFullSubgroups = computeFullSubgroups.Value;
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
        [NativeName("Name", "subgroupSizeControl")]
        public Bool32 SubgroupSizeControl;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "computeFullSubgroups")]
        public Bool32 ComputeFullSubgroups;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceSubgroupSizeControlFeaturesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
