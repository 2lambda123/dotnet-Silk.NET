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

namespace Silk.NET.SDL
{
    [NativeName("Name", "SDL_atomic_t")]
    public unsafe partial struct AtomicT
    {
        public AtomicT
        (
            int? value = null
        )
        {
            fixed (AtomicT* @this = &this)
            {
                // all fields automatically initialized here
            }

            if (value is not null)
            {
                Value = value.Value;
            }
        }


        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "value")]
        public int Value;
    }
}
