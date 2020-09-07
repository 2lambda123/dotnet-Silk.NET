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

namespace Silk.NET.Direct3D11
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d11_3_L1281_C5")]
    public unsafe partial struct AnonymousRecordD3d113L1281C5
    {
        public AnonymousRecordD3d113L1281C5
        (
            BufferRtv buffer = default,
            Tex1DRtv texture1D = default,
            Tex1DArrayRtv texture1DArray = default,
            Tex2DRtv1 texture2D = default,
            Tex2DArrayRtv1 texture2DArray = default,
            Tex2DmsRtv texture2DMS = default,
            Tex2DmsArrayRtv texture2DMSArray = default,
            Tex3DRtv texture3D = default
        )
        {
            Buffer = buffer;
            Texture1D = texture1D;
            Texture1DArray = texture1DArray;
            Texture2D = texture2D;
            Texture2DArray = texture2DArray;
            Texture2DMS = texture2DMS;
            Texture2DMSArray = texture2DMSArray;
            Texture3D = texture3D;
        }


        [FieldOffset(0)]
        [NativeName("Type", "D3D11_BUFFER_RTV")]
        [NativeName("Type.Name", "D3D11_BUFFER_RTV")]
        [NativeName("Name", "Buffer")]
        public BufferRtv Buffer;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEX1D_RTV")]
        [NativeName("Type.Name", "D3D11_TEX1D_RTV")]
        [NativeName("Name", "Texture1D")]
        public Tex1DRtv Texture1D;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEX1D_ARRAY_RTV")]
        [NativeName("Type.Name", "D3D11_TEX1D_ARRAY_RTV")]
        [NativeName("Name", "Texture1DArray")]
        public Tex1DArrayRtv Texture1DArray;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEX2D_RTV1")]
        [NativeName("Type.Name", "D3D11_TEX2D_RTV1")]
        [NativeName("Name", "Texture2D")]
        public Tex2DRtv1 Texture2D;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEX2D_ARRAY_RTV1")]
        [NativeName("Type.Name", "D3D11_TEX2D_ARRAY_RTV1")]
        [NativeName("Name", "Texture2DArray")]
        public Tex2DArrayRtv1 Texture2DArray;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEX2DMS_RTV")]
        [NativeName("Type.Name", "D3D11_TEX2DMS_RTV")]
        [NativeName("Name", "Texture2DMS")]
        public Tex2DmsRtv Texture2DMS;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEX2DMS_ARRAY_RTV")]
        [NativeName("Type.Name", "D3D11_TEX2DMS_ARRAY_RTV")]
        [NativeName("Name", "Texture2DMSArray")]
        public Tex2DmsArrayRtv Texture2DMSArray;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEX3D_RTV")]
        [NativeName("Type.Name", "D3D11_TEX3D_RTV")]
        [NativeName("Name", "Texture3D")]
        public Tex3DRtv Texture3D;
    }
}
