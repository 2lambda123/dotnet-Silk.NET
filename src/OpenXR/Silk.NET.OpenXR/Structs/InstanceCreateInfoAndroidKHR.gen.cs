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
    [NativeName("Name", "XrInstanceCreateInfoAndroidKHR")]
    public unsafe partial struct InstanceCreateInfoAndroidKHR
    {
        public InstanceCreateInfoAndroidKHR
        (
            StructureType? type = StructureType.TypeInstanceCreateInfoAndroidKhr,
            void* next = null,
            void* applicationVM = null,
            void* applicationActivity = null
        )
        {
            fixed (InstanceCreateInfoAndroidKHR* @this = &this)
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

            if (applicationVM is not null)
            {
                ApplicationVM = applicationVM;
            }

            if (applicationActivity is not null)
            {
                ApplicationActivity = applicationActivity;
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
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "applicationVM")]
        public void* ApplicationVM;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "applicationActivity")]
        public void* ApplicationActivity;
    }
}
