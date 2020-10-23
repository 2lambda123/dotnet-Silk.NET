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

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiTexture")]
    public unsafe partial struct Texture
    {
        public Texture
        (
            uint? mWidth = null,
            uint? mHeight = null,
            Texel* pcData = null,
            AssimpString? mFilename = null
        )
        {
            fixed (Texture* @this = &this)
            {
                // all fields automatically initialized here
            }

            if (mWidth is not null)
            {
                MWidth = mWidth.Value;
            }

            if (mHeight is not null)
            {
                MHeight = mHeight.Value;
            }

            if (pcData is not null)
            {
                PcData = pcData;
            }

            if (mFilename is not null)
            {
                MFilename = mFilename.Value;
            }
        }


        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mWidth")]
        public uint MWidth;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mHeight")]
        public uint MHeight;
        [NativeName("Type", "char [9]")]
        [NativeName("Type.Name", "char [9]")]
        [NativeName("Name", "achFormatHint")]
        public fixed byte AchFormatHint[9];

        [NativeName("Type", "aiTexel *")]
        [NativeName("Type.Name", "aiTexel *")]
        [NativeName("Name", "pcData")]
        public Texel* PcData;

        [NativeName("Type", "aiString")]
        [NativeName("Type.Name", "aiString")]
        [NativeName("Name", "mFilename")]
        public AssimpString MFilename;
    }
}
