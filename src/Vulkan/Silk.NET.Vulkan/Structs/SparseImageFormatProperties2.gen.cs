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
    [NativeName("Name", "VkSparseImageFormatProperties2")]
    public unsafe partial struct SparseImageFormatProperties2 : IStructuredType
    {
        public SparseImageFormatProperties2
        (
            StructureType? sType = StructureType.SparseImageFormatProperties2,
            void* pNext = null,
            SparseImageFormatProperties? properties = null
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

            if (properties is not null)
            {
                Properties = properties.Value;
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
        [NativeName("Type", "VkSparseImageFormatProperties")]
        [NativeName("Type.Name", "VkSparseImageFormatProperties")]
        [NativeName("Name", "properties")]
        public SparseImageFormatProperties Properties;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.SparseImageFormatProperties2;
        }
    }
}
