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
    [NativeName("Name", "VkSamplerYcbcrConversionImageFormatPropertiesKHR")]
    public unsafe partial struct SamplerYcbcrConversionImageFormatPropertiesKHR
    {
        public SamplerYcbcrConversionImageFormatPropertiesKHR
        (
            StructureType? sType = StructureType.SamplerYcbcrConversionImageFormatProperties,
            void* pNext = null,
            uint? combinedImageSamplerDescriptorCount = null
        )
        {
            fixed (SamplerYcbcrConversionImageFormatPropertiesKHR* @this = &this)
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

            if (combinedImageSamplerDescriptorCount is not null)
            {
                CombinedImageSamplerDescriptorCount = combinedImageSamplerDescriptorCount.Value;
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
        [NativeName("Name", "combinedImageSamplerDescriptorCount")]
        public uint CombinedImageSamplerDescriptorCount;
    }
}
