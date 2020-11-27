// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_COLOR_YCbCrA")]
    public unsafe partial struct VIDEOCOLORYCbCrA
    {
        public VIDEOCOLORYCbCrA
        (
            float? y = null,
            float? cb = null,
            float? cr = null,
            float? a = null
        ) : this()
        {
            if (y is not null)
            {
                Y = y.Value;
            }

            if (cb is not null)
            {
                Cb = cb.Value;
            }

            if (cr is not null)
            {
                Cr = cr.Value;
            }

            if (a is not null)
            {
                A = a.Value;
            }
        }


        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "Y")]
        public float Y;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "Cb")]
        public float Cb;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "Cr")]
        public float Cr;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "A")]
        public float A;
    }
}
