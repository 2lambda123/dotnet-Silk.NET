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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrCompositionLayerBaseHeader")]
    public unsafe partial struct CompositionLayerBaseHeader
    {
        public CompositionLayerBaseHeader
        (
            StructureType? type = null,
            void* next = null,
            CompositionLayerFlags? layerFlags = null,
            Space? space = null
        )
        {
            fixed (CompositionLayerBaseHeader* @this = &this)
            {
                // all fields automatically initialized here
            }

            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (layerFlags is not null)
            {
                LayerFlags = layerFlags.Value;
            }

            if (space is not null)
            {
                Space = space.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "XrCompositionLayerFlags")]
        [NativeName("Type.Name", "XrCompositionLayerFlags")]
        [NativeName("Name", "layerFlags")]
        public CompositionLayerFlags LayerFlags;
/// <summary></summary>
        [NativeName("Type", "XrSpace")]
        [NativeName("Type.Name", "XrSpace")]
        [NativeName("Name", "space")]
        public Space Space;
    }
}
