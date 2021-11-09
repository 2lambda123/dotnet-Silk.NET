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
    [NativeName("Name", "VkSubpassShadingPipelineCreateInfoHUAWEI")]
    public unsafe partial struct SubpassShadingPipelineCreateInfoHUAWEI : IStructuredType
    {
        public SubpassShadingPipelineCreateInfoHUAWEI
        (
            StructureType? sType = StructureType.SubpassShadingPipelineCreateInfoHuawei,
            void* pNext = null,
            RenderPass? renderPass = null,
            uint? subpass = null
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

            if (renderPass is not null)
            {
                RenderPass = renderPass.Value;
            }

            if (subpass is not null)
            {
                Subpass = subpass.Value;
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
        [NativeName("Type", "VkRenderPass")]
        [NativeName("Type.Name", "VkRenderPass")]
        [NativeName("Name", "renderPass")]
        public RenderPass RenderPass;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "subpass")]
        public uint Subpass;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.SubpassShadingPipelineCreateInfoHuawei;
        }
    }
}
