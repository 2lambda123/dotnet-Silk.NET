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
    [NativeName("Name", "XrControllerModelNodeStateMSFT")]
    public unsafe partial struct ControllerModelNodeStateMSFT
    {
        public ControllerModelNodeStateMSFT
        (
            StructureType? type = StructureType.TypeControllerModelNodeStateMsft,
            void* next = null,
            Posef? nodePose = null
        )
        {
            fixed (ControllerModelNodeStateMSFT* @this = &this)
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

            if (nodePose is not null)
            {
                NodePose = nodePose.Value;
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
        [NativeName("Type", "XrPosef")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "nodePose")]
        public Posef NodePose;
    }
}
