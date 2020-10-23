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
    [NativeName("Name", "VkPhysicalDeviceLineRasterizationFeaturesEXT")]
    public unsafe partial struct PhysicalDeviceLineRasterizationFeaturesEXT
    {
        public PhysicalDeviceLineRasterizationFeaturesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceLineRasterizationFeaturesExt,
            void* pNext = null,
            Bool32? rectangularLines = null,
            Bool32? bresenhamLines = null,
            Bool32? smoothLines = null,
            Bool32? stippledRectangularLines = null,
            Bool32? stippledBresenhamLines = null,
            Bool32? stippledSmoothLines = null
        )
        {
            fixed (PhysicalDeviceLineRasterizationFeaturesEXT* @this = &this)
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

            if (rectangularLines is not null)
            {
                RectangularLines = rectangularLines.Value;
            }

            if (bresenhamLines is not null)
            {
                BresenhamLines = bresenhamLines.Value;
            }

            if (smoothLines is not null)
            {
                SmoothLines = smoothLines.Value;
            }

            if (stippledRectangularLines is not null)
            {
                StippledRectangularLines = stippledRectangularLines.Value;
            }

            if (stippledBresenhamLines is not null)
            {
                StippledBresenhamLines = stippledBresenhamLines.Value;
            }

            if (stippledSmoothLines is not null)
            {
                StippledSmoothLines = stippledSmoothLines.Value;
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
        [NativeName("Name", "rectangularLines")]
        public Bool32 RectangularLines;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "bresenhamLines")]
        public Bool32 BresenhamLines;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "smoothLines")]
        public Bool32 SmoothLines;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "stippledRectangularLines")]
        public Bool32 StippledRectangularLines;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "stippledBresenhamLines")]
        public Bool32 StippledBresenhamLines;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "stippledSmoothLines")]
        public Bool32 StippledSmoothLines;
    }
}
