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
    [NativeName("Name", "XrPosef")]
    public unsafe partial struct Posef
    {
        public Posef
        (
            Quaternionf? orientation = null,
            Vector3f? position = null
        )
        {
            fixed (Posef* @this = &this)
            {
                // all fields automatically initialized here
            }

            if (orientation is not null)
            {
                Orientation = orientation.Value;
            }

            if (position is not null)
            {
                Position = position.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrQuaternionf")]
        [NativeName("Type.Name", "XrQuaternionf")]
        [NativeName("Name", "orientation")]
        public Quaternionf Orientation;
/// <summary></summary>
        [NativeName("Type", "XrVector3f")]
        [NativeName("Type.Name", "XrVector3f")]
        [NativeName("Name", "position")]
        public Vector3f Position;
    }
}
