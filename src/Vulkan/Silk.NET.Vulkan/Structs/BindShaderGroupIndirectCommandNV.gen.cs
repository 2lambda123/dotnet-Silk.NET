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
    [NativeName("Name", "VkBindShaderGroupIndirectCommandNV")]
    public unsafe partial struct BindShaderGroupIndirectCommandNV
    {
        public BindShaderGroupIndirectCommandNV
        (
            uint? groupIndex = null
        )
        {
            fixed (BindShaderGroupIndirectCommandNV* @this = &this)
            {
                // all fields automatically initialized here
            }

            if (groupIndex is not null)
            {
                GroupIndex = groupIndex.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "groupIndex")]
        public uint GroupIndex;
    }
}
