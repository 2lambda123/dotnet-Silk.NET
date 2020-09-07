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
    [NativeName("Name", "D3D11_VIDEO_DECODER_BEGIN_FRAME_CRYPTO_SESSION")]
    public unsafe partial struct VideoDecoderBeginFrameCryptoSession
    {
        public VideoDecoderBeginFrameCryptoSession
        (
            ID3D11CryptoSession* pCryptoSession = default,
            uint blobSize = default,
            void* pBlob = default,
            Guid* pKeyInfoId = default,
            uint privateDataSize = default,
            void* pPrivateData = default
        )
        {
            PCryptoSession = pCryptoSession;
            BlobSize = blobSize;
            PBlob = pBlob;
            PKeyInfoId = pKeyInfoId;
            PrivateDataSize = privateDataSize;
            PPrivateData = pPrivateData;
        }


        [NativeName("Type", "ID3D11CryptoSession *")]
        [NativeName("Type.Name", "ID3D11CryptoSession *")]
        [NativeName("Name", "pCryptoSession")]
        public ID3D11CryptoSession* PCryptoSession;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BlobSize")]
        public uint BlobSize;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "pBlob")]
        public void* PBlob;

        [NativeName("Type", "GUID *")]
        [NativeName("Type.Name", "GUID *")]
        [NativeName("Name", "pKeyInfoId")]
        public Guid* PKeyInfoId;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "PrivateDataSize")]
        public uint PrivateDataSize;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "pPrivateData")]
        public void* PPrivateData;
    }
}
