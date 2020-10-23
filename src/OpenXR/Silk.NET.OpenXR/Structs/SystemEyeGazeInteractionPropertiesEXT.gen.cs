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
    [NativeName("Name", "XrSystemEyeGazeInteractionPropertiesEXT")]
    public unsafe partial struct SystemEyeGazeInteractionPropertiesEXT
    {
        public SystemEyeGazeInteractionPropertiesEXT
        (
            StructureType? type = StructureType.TypeSystemEyeGazeInteractionPropertiesExt,
            void* next = null,
            uint? supportsEyeGazeInteraction = null
        )
        {
            fixed (SystemEyeGazeInteractionPropertiesEXT* @this = &this)
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

            if (supportsEyeGazeInteraction is not null)
            {
                SupportsEyeGazeInteraction = supportsEyeGazeInteraction.Value;
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
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "supportsEyeGazeInteraction")]
        public uint SupportsEyeGazeInteraction;
    }
}
