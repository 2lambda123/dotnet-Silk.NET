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
    [NativeName("Name", "VkRenderPassCreateInfo")]
    public unsafe partial struct RenderPassCreateInfo
    {
        public RenderPassCreateInfo
        (
            StructureType? sType = StructureType.RenderPassCreateInfo,
            void* pNext = null,
            RenderPassCreateFlags? flags = null,
            uint? attachmentCount = null,
            AttachmentDescription* pAttachments = null,
            uint? subpassCount = null,
            SubpassDescription* pSubpasses = null,
            uint? dependencyCount = null,
            SubpassDependency* pDependencies = null
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

            if (attachmentCount is not null)
            {
                AttachmentCount = attachmentCount.Value;
            }

            if (pAttachments is not null)
            {
                PAttachments = pAttachments;
            }

            if (subpassCount is not null)
            {
                SubpassCount = subpassCount.Value;
            }

            if (pSubpasses is not null)
            {
                PSubpasses = pSubpasses;
            }

            if (dependencyCount is not null)
            {
                DependencyCount = dependencyCount.Value;
            }

            if (pDependencies is not null)
            {
                PDependencies = pDependencies;
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
        [NativeName("Type", "VkRenderPassCreateFlags")]
        [NativeName("Type.Name", "VkRenderPassCreateFlags")]
        [NativeName("Name", "flags")]
        public RenderPassCreateFlags Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "attachmentCount")]
        public uint AttachmentCount;
/// <summary></summary>
        [NativeName("Type", "VkAttachmentDescription*")]
        [NativeName("Type.Name", "VkAttachmentDescription")]
        [NativeName("Name", "pAttachments")]
        public AttachmentDescription* PAttachments;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "subpassCount")]
        public uint SubpassCount;
/// <summary></summary>
        [NativeName("Type", "VkSubpassDescription*")]
        [NativeName("Type.Name", "VkSubpassDescription")]
        [NativeName("Name", "pSubpasses")]
        public SubpassDescription* PSubpasses;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "dependencyCount")]
        public uint DependencyCount;
/// <summary></summary>
        [NativeName("Type", "VkSubpassDependency*")]
        [NativeName("Type.Name", "VkSubpassDependency")]
        [NativeName("Name", "pDependencies")]
        public SubpassDependency* PDependencies;
    }
}
