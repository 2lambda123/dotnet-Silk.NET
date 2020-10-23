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
    [NativeName("Name", "XrHandMeshUpdateInfoMSFT")]
    public unsafe partial struct HandMeshUpdateInfoMSFT
    {
        public HandMeshUpdateInfoMSFT
        (
            StructureType? type = StructureType.TypeHandMeshUpdateInfoMsft,
            void* next = null,
            long? time = null,
            HandPoseTypeMSFT? handPoseType = null
        )
        {
            fixed (HandMeshUpdateInfoMSFT* @this = &this)
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

            if (time is not null)
            {
                Time = time.Value;
            }

            if (handPoseType is not null)
            {
                HandPoseType = handPoseType.Value;
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
        [NativeName("Type", "XrTime")]
        [NativeName("Type.Name", "XrTime")]
        [NativeName("Name", "time")]
        public long Time;
/// <summary></summary>
        [NativeName("Type", "XrHandPoseTypeMSFT")]
        [NativeName("Type.Name", "XrHandPoseTypeMSFT")]
        [NativeName("Name", "handPoseType")]
        public HandPoseTypeMSFT HandPoseType;
    }
}
