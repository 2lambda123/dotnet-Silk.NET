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
    [NativeName("Name", "VkDescriptorPoolSize")]
    public unsafe partial struct DescriptorPoolSize
    {
        public DescriptorPoolSize
        (
            DescriptorType? type = null,
            uint? descriptorCount = null
        )
        {
            fixed (DescriptorPoolSize* @this = &this)
            {
                // all fields automatically initialized here
            }

            if (type is not null)
            {
                Type = type.Value;
            }

            if (descriptorCount is not null)
            {
                DescriptorCount = descriptorCount.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkDescriptorType")]
        [NativeName("Type.Name", "VkDescriptorType")]
        [NativeName("Name", "type")]
        public DescriptorType Type;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "descriptorCount")]
        public uint DescriptorCount;
    }
}
