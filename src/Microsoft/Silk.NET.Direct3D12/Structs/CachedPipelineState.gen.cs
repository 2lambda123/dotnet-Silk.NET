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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_CACHED_PIPELINE_STATE")]
    public unsafe partial struct CachedPipelineState
    {
        public CachedPipelineState
        (
            void* pCachedBlob = null,
            uint? cachedBlobSizeInBytes = null
        ) : this()
        {
            if (pCachedBlob is not null)
            {
                PCachedBlob = pCachedBlob;
            }

            if (cachedBlobSizeInBytes is not null)
            {
                CachedBlobSizeInBytes = cachedBlobSizeInBytes.Value;
            }
        }


        [NativeName("Type", "const void *")]
        [NativeName("Type.Name", "const void *")]
        [NativeName("Name", "pCachedBlob")]
        public void* PCachedBlob;

        [NativeName("Type", "SIZE_T")]
        [NativeName("Type.Name", "SIZE_T")]
        [NativeName("Name", "CachedBlobSizeInBytes")]
        public uint CachedBlobSizeInBytes;
    }
}
