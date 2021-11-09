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
    [NativeName("Name", "VkVideoSessionParametersCreateInfoKHR")]
    public unsafe partial struct VideoSessionParametersCreateInfoKHR : IStructuredType
    {
        public VideoSessionParametersCreateInfoKHR
        (
            StructureType? sType = StructureType.VideoSessionParametersCreateInfoKhr,
            void* pNext = null,
            VideoSessionParametersKHR? videoSessionParametersTemplate = null,
            VideoSessionKHR? videoSession = null
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

            if (videoSessionParametersTemplate is not null)
            {
                VideoSessionParametersTemplate = videoSessionParametersTemplate.Value;
            }

            if (videoSession is not null)
            {
                VideoSession = videoSession.Value;
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
        [NativeName("Type", "VkVideoSessionParametersKHR")]
        [NativeName("Type.Name", "VkVideoSessionParametersKHR")]
        [NativeName("Name", "videoSessionParametersTemplate")]
        public VideoSessionParametersKHR VideoSessionParametersTemplate;
/// <summary></summary>
        [NativeName("Type", "VkVideoSessionKHR")]
        [NativeName("Type.Name", "VkVideoSessionKHR")]
        [NativeName("Name", "videoSession")]
        public VideoSessionKHR VideoSession;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoSessionParametersCreateInfoKhr;
        }
    }
}
