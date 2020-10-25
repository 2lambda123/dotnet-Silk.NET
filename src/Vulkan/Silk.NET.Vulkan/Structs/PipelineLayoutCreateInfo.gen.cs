// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPipelineLayoutCreateInfo")]
    public unsafe partial struct PipelineLayoutCreateInfo
    {
        public PipelineLayoutCreateInfo
        (
            StructureType? sType = StructureType.PipelineLayoutCreateInfo,
            void* pNext = null,
            uint? flags = null,
            uint? setLayoutCount = null,
            DescriptorSetLayout* pSetLayouts = null,
            uint? pushConstantRangeCount = null,
            PushConstantRange* pPushConstantRanges = null
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

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (setLayoutCount is not null)
            {
                SetLayoutCount = setLayoutCount.Value;
            }

            if (pSetLayouts is not null)
            {
                PSetLayouts = pSetLayouts;
            }

            if (pushConstantRangeCount is not null)
            {
                PushConstantRangeCount = pushConstantRangeCount.Value;
            }

            if (pPushConstantRanges is not null)
            {
                PPushConstantRanges = pPushConstantRanges;
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
        [NativeName("Type", "VkPipelineLayoutCreateFlags")]
        [NativeName("Type.Name", "VkPipelineLayoutCreateFlags")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "setLayoutCount")]
        public uint SetLayoutCount;
/// <summary></summary>
        [NativeName("Type", "VkDescriptorSetLayout*")]
        [NativeName("Type.Name", "VkDescriptorSetLayout")]
        [NativeName("Name", "pSetLayouts")]
        public DescriptorSetLayout* PSetLayouts;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pushConstantRangeCount")]
        public uint PushConstantRangeCount;
/// <summary></summary>
        [NativeName("Type", "VkPushConstantRange*")]
        [NativeName("Type.Name", "VkPushConstantRange")]
        [NativeName("Name", "pPushConstantRanges")]
        public PushConstantRange* PPushConstantRanges;
    }
}
