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
    [NativeName("Name", "VkDeviceBufferMemoryRequirements")]
    [NativeName("Aliases", "VkDeviceBufferMemoryRequirementsKHR")]
    public unsafe partial struct DeviceBufferMemoryRequirements : IChainable
    {
        public DeviceBufferMemoryRequirements
        (
            StructureType? sType = StructureType.DeviceBufferMemoryRequirements,
            void* pNext = null,
            BufferCreateInfo* pCreateInfo = null
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

            if (pCreateInfo is not null)
            {
                PCreateInfo = pCreateInfo;
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
        [NativeName("Type", "VkBufferCreateInfo*")]
        [NativeName("Type.Name", "VkBufferCreateInfo")]
        [NativeName("Name", "pCreateInfo")]
        public BufferCreateInfo* PCreateInfo;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DeviceBufferMemoryRequirements;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
