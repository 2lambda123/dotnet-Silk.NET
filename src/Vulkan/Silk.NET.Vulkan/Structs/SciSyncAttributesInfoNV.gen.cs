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
    [NativeName("Name", "VkSciSyncAttributesInfoNV")]
    public unsafe partial struct SciSyncAttributesInfoNV : IChainable
    {
        public SciSyncAttributesInfoNV
        (
            StructureType? sType = StructureType.SciSyncAttributesInfoNV,
            void* pNext = null,
            SciSyncClientTypeNV? clientType = null,
            SciSyncPrimitiveTypeNV? primitiveType = null
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

            if (clientType is not null)
            {
                ClientType = clientType.Value;
            }

            if (primitiveType is not null)
            {
                PrimitiveType = primitiveType.Value;
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
        [NativeName("Type", "VkSciSyncClientTypeNV")]
        [NativeName("Type.Name", "VkSciSyncClientTypeNV")]
        [NativeName("Name", "clientType")]
        public SciSyncClientTypeNV ClientType;
/// <summary></summary>
        [NativeName("Type", "VkSciSyncPrimitiveTypeNV")]
        [NativeName("Type.Name", "VkSciSyncPrimitiveTypeNV")]
        [NativeName("Name", "primitiveType")]
        public SciSyncPrimitiveTypeNV PrimitiveType;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.SciSyncAttributesInfoNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
