// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPhysicalDeviceVariablePointersFeaturesKHR")]
    public unsafe partial struct PhysicalDeviceVariablePointersFeaturesKHR
    {
        public PhysicalDeviceVariablePointersFeaturesKHR
        (
            StructureType? sType = StructureType.PhysicalDeviceVariablePointersFeatures,
            void* pNext = null,
            Bool32? variablePointersStorageBuffer = null,
            Bool32? variablePointers = null
        )
        {
            fixed (PhysicalDeviceVariablePointersFeaturesKHR* @this = &this)
            {
                // all fields automatically initialized here
            }

            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (variablePointersStorageBuffer is not null)
            {
                VariablePointersStorageBuffer = variablePointersStorageBuffer.Value;
            }

            if (variablePointers is not null)
            {
                VariablePointers = variablePointers.Value;
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
        [NativeName("Name", "variablePointersStorageBuffer")]
        public Bool32 VariablePointersStorageBuffer;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "variablePointers")]
        public Bool32 VariablePointers;
    }
}
