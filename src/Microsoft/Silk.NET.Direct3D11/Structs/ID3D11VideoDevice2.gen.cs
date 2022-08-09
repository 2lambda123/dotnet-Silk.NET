// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Guid("59c0cb01-35f0-4a70-8f67-87905c906a53")]
    [NativeName("Name", "ID3D11VideoDevice2")]
    public unsafe partial struct ID3D11VideoDevice2 : IComVtbl<ID3D11VideoDevice2>, IComVtbl<ID3D11VideoDevice1>, IComVtbl<ID3D11VideoDevice>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("59c0cb01-35f0-4a70-8f67-87905c906a53");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID3D11VideoDevice1(ID3D11VideoDevice2 val)
            => Unsafe.As<ID3D11VideoDevice2, ID3D11VideoDevice1>(ref val);

        public static implicit operator ID3D11VideoDevice(ID3D11VideoDevice2 val)
            => Unsafe.As<ID3D11VideoDevice2, ID3D11VideoDevice>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11VideoDevice2 val)
            => Unsafe.As<ID3D11VideoDevice2, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D11VideoDevice2
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(VideoDecoderDesc* pVideoDesc, VideoDecoderConfig* pConfig, ID3D11VideoDecoder** ppDecoder)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDesc, pConfig, ppDecoder);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(VideoDecoderDesc* pVideoDesc, VideoDecoderConfig* pConfig, ref ID3D11VideoDecoder* ppDecoder)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder** ppDecoderPtr = &ppDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDesc, pConfig, ppDecoderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(VideoDecoderDesc* pVideoDesc, ref VideoDecoderConfig pConfig, ID3D11VideoDecoder** ppDecoder)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDesc, pConfigPtr, ppDecoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(VideoDecoderDesc* pVideoDesc, ref VideoDecoderConfig pConfig, ref ID3D11VideoDecoder* ppDecoder)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
            {
                fixed (ID3D11VideoDecoder** ppDecoderPtr = &ppDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDesc, pConfigPtr, ppDecoderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(ref VideoDecoderDesc pVideoDesc, VideoDecoderConfig* pConfig, ID3D11VideoDecoder** ppDecoder)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pVideoDescPtr = &pVideoDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDescPtr, pConfig, ppDecoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(ref VideoDecoderDesc pVideoDesc, VideoDecoderConfig* pConfig, ref ID3D11VideoDecoder* ppDecoder)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (ID3D11VideoDecoder** ppDecoderPtr = &ppDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDescPtr, pConfig, ppDecoderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(ref VideoDecoderDesc pVideoDesc, ref VideoDecoderConfig pConfig, ID3D11VideoDecoder** ppDecoder)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDescPtr, pConfigPtr, ppDecoder);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(ref VideoDecoderDesc pVideoDesc, ref VideoDecoderConfig pConfig, ref ID3D11VideoDecoder* ppDecoder)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
                {
                    fixed (ID3D11VideoDecoder** ppDecoderPtr = &ppDecoder)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDescPtr, pConfigPtr, ppDecoderPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor(ID3D11VideoProcessorEnumerator* pEnum, uint RateConversionIndex, ID3D11VideoProcessor** ppVideoProcessor)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int>)@this->LpVtbl[4])(@this, pEnum, RateConversionIndex, ppVideoProcessor);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor(ID3D11VideoProcessorEnumerator* pEnum, uint RateConversionIndex, ref ID3D11VideoProcessor* ppVideoProcessor)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor** ppVideoProcessorPtr = &ppVideoProcessor)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int>)@this->LpVtbl[4])(@this, pEnum, RateConversionIndex, ppVideoProcessorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor(ref ID3D11VideoProcessorEnumerator pEnum, uint RateConversionIndex, ID3D11VideoProcessor** ppVideoProcessor)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int>)@this->LpVtbl[4])(@this, pEnumPtr, RateConversionIndex, ppVideoProcessor);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor(ref ID3D11VideoProcessorEnumerator pEnum, uint RateConversionIndex, ref ID3D11VideoProcessor* ppVideoProcessor)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                fixed (ID3D11VideoProcessor** ppVideoProcessorPtr = &ppVideoProcessor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int>)@this->LpVtbl[4])(@this, pEnumPtr, RateConversionIndex, ppVideoProcessorPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateAuthenticatedChannel(AuthenticatedChannelType ChannelType, ID3D11AuthenticatedChannel** ppAuthenticatedChannel)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, AuthenticatedChannelType, ID3D11AuthenticatedChannel**, int>)@this->LpVtbl[5])(@this, ChannelType, ppAuthenticatedChannel);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateAuthenticatedChannel(AuthenticatedChannelType ChannelType, ref ID3D11AuthenticatedChannel* ppAuthenticatedChannel)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11AuthenticatedChannel** ppAuthenticatedChannelPtr = &ppAuthenticatedChannel)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, AuthenticatedChannelType, ID3D11AuthenticatedChannel**, int>)@this->LpVtbl[5])(@this, ChannelType, ppAuthenticatedChannelPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession(Guid* pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfile, pKeyExchangeType, ppCryptoSession);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession(Guid* pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfile, pKeyExchangeType, ppCryptoSessionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession(Guid* pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfile, pKeyExchangeTypePtr, ppCryptoSession);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession(Guid* pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfile, pKeyExchangeTypePtr, ppCryptoSessionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession(Guid* pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeType, ppCryptoSession);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession(Guid* pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeType, ppCryptoSessionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession(Guid* pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeTypePtr, ppCryptoSession);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession(Guid* pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeTypePtr, ppCryptoSessionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession(ref Guid pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeType, ppCryptoSession);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession(ref Guid pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeType, ppCryptoSessionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession(ref Guid pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeTypePtr, ppCryptoSession);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession(ref Guid pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeTypePtr, ppCryptoSessionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession(ref Guid pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeType, ppCryptoSession);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession(ref Guid pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeType, ppCryptoSessionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession(ref Guid pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeTypePtr, ppCryptoSession);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession(ref Guid pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                    {
                        fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeTypePtr, ppCryptoSessionPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderOutputView(ID3D11Resource* pResource, VideoDecoderOutputViewDesc* pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResource, pDesc, ppVDOVView);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderOutputView(ID3D11Resource* pResource, VideoDecoderOutputViewDesc* pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoderOutputView** ppVDOVViewPtr = &ppVDOVView)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResource, pDesc, ppVDOVViewPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderOutputView(ID3D11Resource* pResource, ref VideoDecoderOutputViewDesc pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderOutputViewDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResource, pDescPtr, ppVDOVView);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderOutputView(ID3D11Resource* pResource, ref VideoDecoderOutputViewDesc pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderOutputViewDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D11VideoDecoderOutputView** ppVDOVViewPtr = &ppVDOVView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResource, pDescPtr, ppVDOVViewPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderOutputView(ref ID3D11Resource pResource, VideoDecoderOutputViewDesc* pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResourcePtr, pDesc, ppVDOVView);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderOutputView(ref ID3D11Resource pResource, VideoDecoderOutputViewDesc* pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (ID3D11VideoDecoderOutputView** ppVDOVViewPtr = &ppVDOVView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResourcePtr, pDesc, ppVDOVViewPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderOutputView(ref ID3D11Resource pResource, ref VideoDecoderOutputViewDesc pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (VideoDecoderOutputViewDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResourcePtr, pDescPtr, ppVDOVView);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderOutputView(ref ID3D11Resource pResource, ref VideoDecoderOutputViewDesc pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (VideoDecoderOutputViewDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D11VideoDecoderOutputView** ppVDOVViewPtr = &ppVDOVView)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResourcePtr, pDescPtr, ppVDOVViewPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorInputViewDesc* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnum, pDesc, ppVPIView);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnum, pDesc, ppVPIViewPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorInputViewDesc pDesc, ID3D11VideoProcessorInputView** ppVPIView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnum, pDescPtr, ppVPIView);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnum, pDescPtr, ppVPIViewPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorInputViewDesc* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnumPtr, pDesc, ppVPIView);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnumPtr, pDesc, ppVPIViewPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorInputViewDesc pDesc, ID3D11VideoProcessorInputView** ppVPIView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnumPtr, pDescPtr, ppVPIView);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnumPtr, pDescPtr, ppVPIViewPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorInputViewDesc* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnum, pDesc, ppVPIView);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnum, pDesc, ppVPIViewPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorInputViewDesc pDesc, ID3D11VideoProcessorInputView** ppVPIView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnum, pDescPtr, ppVPIView);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnum, pDescPtr, ppVPIViewPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorInputViewDesc* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnumPtr, pDesc, ppVPIView);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnumPtr, pDesc, ppVPIViewPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorInputViewDesc pDesc, ID3D11VideoProcessorInputView** ppVPIView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnumPtr, pDescPtr, ppVPIView);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
                    {
                        fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnumPtr, pDescPtr, ppVPIViewPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorOutputViewDesc* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnum, pDesc, ppVPOView);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnum, pDesc, ppVPOViewPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorOutputViewDesc pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnum, pDescPtr, ppVPOView);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnum, pDescPtr, ppVPOViewPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorOutputViewDesc* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnumPtr, pDesc, ppVPOView);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnumPtr, pDesc, ppVPOViewPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorOutputViewDesc pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnumPtr, pDescPtr, ppVPOView);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnumPtr, pDescPtr, ppVPOViewPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorOutputViewDesc* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnum, pDesc, ppVPOView);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnum, pDesc, ppVPOViewPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorOutputViewDesc pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnum, pDescPtr, ppVPOView);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnum, pDescPtr, ppVPOViewPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorOutputViewDesc* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnumPtr, pDesc, ppVPOView);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnumPtr, pDesc, ppVPOViewPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorOutputViewDesc pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnumPtr, pDescPtr, ppVPOView);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
                    {
                        fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnumPtr, pDescPtr, ppVPOViewPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorEnumerator(VideoProcessorContentDesc* pDesc, ID3D11VideoProcessorEnumerator** ppEnum)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoProcessorContentDesc*, ID3D11VideoProcessorEnumerator**, int>)@this->LpVtbl[10])(@this, pDesc, ppEnum);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorEnumerator(VideoProcessorContentDesc* pDesc, ref ID3D11VideoProcessorEnumerator* ppEnum)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessorEnumerator** ppEnumPtr = &ppEnum)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoProcessorContentDesc*, ID3D11VideoProcessorEnumerator**, int>)@this->LpVtbl[10])(@this, pDesc, ppEnumPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorEnumerator(ref VideoProcessorContentDesc pDesc, ID3D11VideoProcessorEnumerator** ppEnum)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoProcessorContentDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoProcessorContentDesc*, ID3D11VideoProcessorEnumerator**, int>)@this->LpVtbl[10])(@this, pDescPtr, ppEnum);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorEnumerator(ref VideoProcessorContentDesc pDesc, ref ID3D11VideoProcessorEnumerator* ppEnum)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoProcessorContentDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D11VideoProcessorEnumerator** ppEnumPtr = &ppEnum)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoProcessorContentDesc*, ID3D11VideoProcessorEnumerator**, int>)@this->LpVtbl[10])(@this, pDescPtr, ppEnumPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetVideoDecoderProfileCount()
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, uint>)@this->LpVtbl[11])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoDecoderProfile(uint Index, Guid* pDecoderProfile)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, uint, Guid*, int>)@this->LpVtbl[12])(@this, Index, pDecoderProfile);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVideoDecoderProfile(uint Index, ref Guid pDecoderProfile)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, uint, Guid*, int>)@this->LpVtbl[12])(@this, Index, pDecoderProfilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderFormat(Guid* pDecoderProfile, Silk.NET.DXGI.Format Format, int* pSupported)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Silk.NET.DXGI.Format, int*, int>)@this->LpVtbl[13])(@this, pDecoderProfile, Format, pSupported);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderFormat(Guid* pDecoderProfile, Silk.NET.DXGI.Format Format, ref int pSupported)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pSupportedPtr = &pSupported)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Silk.NET.DXGI.Format, int*, int>)@this->LpVtbl[13])(@this, pDecoderProfile, Format, pSupportedPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderFormat(ref Guid pDecoderProfile, Silk.NET.DXGI.Format Format, int* pSupported)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Silk.NET.DXGI.Format, int*, int>)@this->LpVtbl[13])(@this, pDecoderProfilePtr, Format, pSupported);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckVideoDecoderFormat(ref Guid pDecoderProfile, Silk.NET.DXGI.Format Format, ref int pSupported)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (int* pSupportedPtr = &pSupported)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Silk.NET.DXGI.Format, int*, int>)@this->LpVtbl[13])(@this, pDecoderProfilePtr, Format, pSupportedPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoDecoderConfigCount(VideoDecoderDesc* pDesc, uint* pCount)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, uint*, int>)@this->LpVtbl[14])(@this, pDesc, pCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoDecoderConfigCount(VideoDecoderDesc* pDesc, ref uint pCount)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, uint*, int>)@this->LpVtbl[14])(@this, pDesc, pCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoDecoderConfigCount(ref VideoDecoderDesc pDesc, uint* pCount)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, uint*, int>)@this->LpVtbl[14])(@this, pDescPtr, pCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVideoDecoderConfigCount(ref VideoDecoderDesc pDesc, ref uint pCount)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pDescPtr = &pDesc)
            {
                fixed (uint* pCountPtr = &pCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, uint*, int>)@this->LpVtbl[14])(@this, pDescPtr, pCountPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoDecoderConfig(VideoDecoderDesc* pDesc, uint Index, VideoDecoderConfig* pConfig)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, uint, VideoDecoderConfig*, int>)@this->LpVtbl[15])(@this, pDesc, Index, pConfig);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoDecoderConfig(VideoDecoderDesc* pDesc, uint Index, ref VideoDecoderConfig pConfig)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, uint, VideoDecoderConfig*, int>)@this->LpVtbl[15])(@this, pDesc, Index, pConfigPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoDecoderConfig(ref VideoDecoderDesc pDesc, uint Index, VideoDecoderConfig* pConfig)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, uint, VideoDecoderConfig*, int>)@this->LpVtbl[15])(@this, pDescPtr, Index, pConfig);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVideoDecoderConfig(ref VideoDecoderDesc pDesc, uint Index, ref VideoDecoderConfig pConfig)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pDescPtr = &pDesc)
            {
                fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, uint, VideoDecoderConfig*, int>)@this->LpVtbl[15])(@this, pDescPtr, Index, pConfigPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContentProtectionCaps(Guid* pCryptoType, Guid* pDecoderProfile, VideoContentProtectionCaps* pCaps)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoType, pDecoderProfile, pCaps);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContentProtectionCaps(Guid* pCryptoType, Guid* pDecoderProfile, ref VideoContentProtectionCaps pCaps)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoContentProtectionCaps* pCapsPtr = &pCaps)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoType, pDecoderProfile, pCapsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContentProtectionCaps(Guid* pCryptoType, ref Guid pDecoderProfile, VideoContentProtectionCaps* pCaps)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoType, pDecoderProfilePtr, pCaps);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContentProtectionCaps(Guid* pCryptoType, ref Guid pDecoderProfile, ref VideoContentProtectionCaps pCaps)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (VideoContentProtectionCaps* pCapsPtr = &pCaps)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoType, pDecoderProfilePtr, pCapsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContentProtectionCaps(ref Guid pCryptoType, Guid* pDecoderProfile, VideoContentProtectionCaps* pCaps)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoTypePtr, pDecoderProfile, pCaps);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContentProtectionCaps(ref Guid pCryptoType, Guid* pDecoderProfile, ref VideoContentProtectionCaps pCaps)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (VideoContentProtectionCaps* pCapsPtr = &pCaps)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoTypePtr, pDecoderProfile, pCapsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContentProtectionCaps(ref Guid pCryptoType, ref Guid pDecoderProfile, VideoContentProtectionCaps* pCaps)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoTypePtr, pDecoderProfilePtr, pCaps);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetContentProtectionCaps(ref Guid pCryptoType, ref Guid pDecoderProfile, ref VideoContentProtectionCaps pCaps)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (VideoContentProtectionCaps* pCapsPtr = &pCaps)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoTypePtr, pDecoderProfilePtr, pCapsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckCryptoKeyExchange(Guid* pCryptoType, Guid* pDecoderProfile, uint Index, Guid* pKeyExchangeType)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoType, pDecoderProfile, Index, pKeyExchangeType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckCryptoKeyExchange(Guid* pCryptoType, Guid* pDecoderProfile, uint Index, ref Guid pKeyExchangeType)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoType, pDecoderProfile, Index, pKeyExchangeTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckCryptoKeyExchange(Guid* pCryptoType, ref Guid pDecoderProfile, uint Index, Guid* pKeyExchangeType)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoType, pDecoderProfilePtr, Index, pKeyExchangeType);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckCryptoKeyExchange(Guid* pCryptoType, ref Guid pDecoderProfile, uint Index, ref Guid pKeyExchangeType)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoType, pDecoderProfilePtr, Index, pKeyExchangeTypePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckCryptoKeyExchange(ref Guid pCryptoType, Guid* pDecoderProfile, uint Index, Guid* pKeyExchangeType)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoTypePtr, pDecoderProfile, Index, pKeyExchangeType);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckCryptoKeyExchange(ref Guid pCryptoType, Guid* pDecoderProfile, uint Index, ref Guid pKeyExchangeType)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoTypePtr, pDecoderProfile, Index, pKeyExchangeTypePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckCryptoKeyExchange(ref Guid pCryptoType, ref Guid pDecoderProfile, uint Index, Guid* pKeyExchangeType)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoTypePtr, pDecoderProfilePtr, Index, pKeyExchangeType);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckCryptoKeyExchange(ref Guid pCryptoType, ref Guid pDecoderProfile, uint Index, ref Guid pKeyExchangeType)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoTypePtr, pDecoderProfilePtr, Index, pKeyExchangeTypePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, void*, int>)@this->LpVtbl[18])(@this, guid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, void*, int>)@this->LpVtbl[18])(@this, guid, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, void*, int>)@this->LpVtbl[18])(@this, guidPtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, void*, int>)@this->LpVtbl[18])(@this, guidPtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[19])(@this, guid, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[19])(@this, guid, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[19])(@this, guidPtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[19])(@this, guidPtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCryptoSessionPrivateDataSize(Guid* pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfile, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCryptoSessionPrivateDataSize(Guid* pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, uint* pPrivateInputSize, ref uint pPrivateOutputSize)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfile, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSizePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCryptoSessionPrivateDataSize(Guid* pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ref uint pPrivateInputSize, uint* pPrivateOutputSize)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfile, pKeyExchangeType, pPrivateInputSizePtr, pPrivateOutputSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCryptoSessionPrivateDataSize(Guid* pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ref uint pPrivateInputSize, ref uint pPrivateOutputSize)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
            {
                fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfile, pKeyExchangeType, pPrivateInputSizePtr, pPrivateOutputSizePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCryptoSessionPrivateDataSize(Guid* pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfile, pKeyExchangeTypePtr, pPrivateInputSize, pPrivateOutputSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCryptoSessionPrivateDataSize(Guid* pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, uint* pPrivateInputSize, ref uint pPrivateOutputSize)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfile, pKeyExchangeTypePtr, pPrivateInputSize, pPrivateOutputSizePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCryptoSessionPrivateDataSize(Guid* pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ref uint pPrivateInputSize, uint* pPrivateOutputSize)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfile, pKeyExchangeTypePtr, pPrivateInputSizePtr, pPrivateOutputSize);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCryptoSessionPrivateDataSize(Guid* pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ref uint pPrivateInputSize, ref uint pPrivateOutputSize)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                {
                    fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfile, pKeyExchangeTypePtr, pPrivateInputSizePtr, pPrivateOutputSizePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCryptoSessionPrivateDataSize(Guid* pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCryptoSessionPrivateDataSize(Guid* pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, uint* pPrivateInputSize, ref uint pPrivateOutputSize)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSizePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCryptoSessionPrivateDataSize(Guid* pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, ref uint pPrivateInputSize, uint* pPrivateOutputSize)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeType, pPrivateInputSizePtr, pPrivateOutputSize);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCryptoSessionPrivateDataSize(Guid* pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, ref uint pPrivateInputSize, ref uint pPrivateOutputSize)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                {
                    fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeType, pPrivateInputSizePtr, pPrivateOutputSizePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCryptoSessionPrivateDataSize(Guid* pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeTypePtr, pPrivateInputSize, pPrivateOutputSize);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCryptoSessionPrivateDataSize(Guid* pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, uint* pPrivateInputSize, ref uint pPrivateOutputSize)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeTypePtr, pPrivateInputSize, pPrivateOutputSizePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCryptoSessionPrivateDataSize(Guid* pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ref uint pPrivateInputSize, uint* pPrivateOutputSize)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeTypePtr, pPrivateInputSizePtr, pPrivateOutputSize);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCryptoSessionPrivateDataSize(Guid* pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ref uint pPrivateInputSize, ref uint pPrivateOutputSize)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                    {
                        fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeTypePtr, pPrivateInputSizePtr, pPrivateOutputSizePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCryptoSessionPrivateDataSize(ref Guid pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCryptoSessionPrivateDataSize(ref Guid pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, uint* pPrivateInputSize, ref uint pPrivateOutputSize)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSizePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCryptoSessionPrivateDataSize(ref Guid pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ref uint pPrivateInputSize, uint* pPrivateOutputSize)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeType, pPrivateInputSizePtr, pPrivateOutputSize);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCryptoSessionPrivateDataSize(ref Guid pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ref uint pPrivateInputSize, ref uint pPrivateOutputSize)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                {
                    fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeType, pPrivateInputSizePtr, pPrivateOutputSizePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCryptoSessionPrivateDataSize(ref Guid pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeTypePtr, pPrivateInputSize, pPrivateOutputSize);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCryptoSessionPrivateDataSize(ref Guid pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, uint* pPrivateInputSize, ref uint pPrivateOutputSize)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeTypePtr, pPrivateInputSize, pPrivateOutputSizePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCryptoSessionPrivateDataSize(ref Guid pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ref uint pPrivateInputSize, uint* pPrivateOutputSize)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeTypePtr, pPrivateInputSizePtr, pPrivateOutputSize);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCryptoSessionPrivateDataSize(ref Guid pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ref uint pPrivateInputSize, ref uint pPrivateOutputSize)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                    {
                        fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeTypePtr, pPrivateInputSizePtr, pPrivateOutputSizePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCryptoSessionPrivateDataSize(ref Guid pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSize);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCryptoSessionPrivateDataSize(ref Guid pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, uint* pPrivateInputSize, ref uint pPrivateOutputSize)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSizePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCryptoSessionPrivateDataSize(ref Guid pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, ref uint pPrivateInputSize, uint* pPrivateOutputSize)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeType, pPrivateInputSizePtr, pPrivateOutputSize);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCryptoSessionPrivateDataSize(ref Guid pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, ref uint pPrivateInputSize, ref uint pPrivateOutputSize)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                    {
                        fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeType, pPrivateInputSizePtr, pPrivateOutputSizePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCryptoSessionPrivateDataSize(ref Guid pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeTypePtr, pPrivateInputSize, pPrivateOutputSize);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCryptoSessionPrivateDataSize(ref Guid pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, uint* pPrivateInputSize, ref uint pPrivateOutputSize)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                    {
                        fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeTypePtr, pPrivateInputSize, pPrivateOutputSizePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCryptoSessionPrivateDataSize(ref Guid pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ref uint pPrivateInputSize, uint* pPrivateOutputSize)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                    {
                        fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeTypePtr, pPrivateInputSizePtr, pPrivateOutputSize);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCryptoSessionPrivateDataSize(ref Guid pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ref uint pPrivateInputSize, ref uint pPrivateOutputSize)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                    {
                        fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                        {
                            fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeTypePtr, pPrivateInputSizePtr, pPrivateOutputSizePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoDecoderCaps(Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, Guid* pCryptoType, uint* pDecoderCaps)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfile, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoType, pDecoderCaps);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoDecoderCaps(Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, Guid* pCryptoType, ref uint pDecoderCaps)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDecoderCapsPtr = &pDecoderCaps)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfile, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoType, pDecoderCapsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoDecoderCaps(Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, ref Guid pCryptoType, uint* pDecoderCaps)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfile, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoTypePtr, pDecoderCaps);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoDecoderCaps(Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, ref Guid pCryptoType, ref uint pDecoderCaps)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (uint* pDecoderCapsPtr = &pDecoderCaps)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfile, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoTypePtr, pDecoderCapsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoDecoderCaps(Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, ref Silk.NET.DXGI.Rational pFrameRate, uint BitRate, Guid* pCryptoType, uint* pDecoderCaps)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfile, SampleWidth, SampleHeight, pFrameRatePtr, BitRate, pCryptoType, pDecoderCaps);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoDecoderCaps(Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, ref Silk.NET.DXGI.Rational pFrameRate, uint BitRate, Guid* pCryptoType, ref uint pDecoderCaps)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (uint* pDecoderCapsPtr = &pDecoderCaps)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfile, SampleWidth, SampleHeight, pFrameRatePtr, BitRate, pCryptoType, pDecoderCapsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoDecoderCaps(Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, ref Silk.NET.DXGI.Rational pFrameRate, uint BitRate, ref Guid pCryptoType, uint* pDecoderCaps)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfile, SampleWidth, SampleHeight, pFrameRatePtr, BitRate, pCryptoTypePtr, pDecoderCaps);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoDecoderCaps(Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, ref Silk.NET.DXGI.Rational pFrameRate, uint BitRate, ref Guid pCryptoType, ref uint pDecoderCaps)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (uint* pDecoderCapsPtr = &pDecoderCaps)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfile, SampleWidth, SampleHeight, pFrameRatePtr, BitRate, pCryptoTypePtr, pDecoderCapsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoDecoderCaps(ref Guid pDecoderProfile, uint SampleWidth, uint SampleHeight, Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, Guid* pCryptoType, uint* pDecoderCaps)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfilePtr, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoType, pDecoderCaps);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoDecoderCaps(ref Guid pDecoderProfile, uint SampleWidth, uint SampleHeight, Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, Guid* pCryptoType, ref uint pDecoderCaps)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (uint* pDecoderCapsPtr = &pDecoderCaps)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfilePtr, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoType, pDecoderCapsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoDecoderCaps(ref Guid pDecoderProfile, uint SampleWidth, uint SampleHeight, Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, ref Guid pCryptoType, uint* pDecoderCaps)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfilePtr, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoTypePtr, pDecoderCaps);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoDecoderCaps(ref Guid pDecoderProfile, uint SampleWidth, uint SampleHeight, Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, ref Guid pCryptoType, ref uint pDecoderCaps)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (uint* pDecoderCapsPtr = &pDecoderCaps)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfilePtr, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoTypePtr, pDecoderCapsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoDecoderCaps(ref Guid pDecoderProfile, uint SampleWidth, uint SampleHeight, ref Silk.NET.DXGI.Rational pFrameRate, uint BitRate, Guid* pCryptoType, uint* pDecoderCaps)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfilePtr, SampleWidth, SampleHeight, pFrameRatePtr, BitRate, pCryptoType, pDecoderCaps);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoDecoderCaps(ref Guid pDecoderProfile, uint SampleWidth, uint SampleHeight, ref Silk.NET.DXGI.Rational pFrameRate, uint BitRate, Guid* pCryptoType, ref uint pDecoderCaps)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (uint* pDecoderCapsPtr = &pDecoderCaps)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfilePtr, SampleWidth, SampleHeight, pFrameRatePtr, BitRate, pCryptoType, pDecoderCapsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoDecoderCaps(ref Guid pDecoderProfile, uint SampleWidth, uint SampleHeight, ref Silk.NET.DXGI.Rational pFrameRate, uint BitRate, ref Guid pCryptoType, uint* pDecoderCaps)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (Guid* pCryptoTypePtr = &pCryptoType)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfilePtr, SampleWidth, SampleHeight, pFrameRatePtr, BitRate, pCryptoTypePtr, pDecoderCaps);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVideoDecoderCaps(ref Guid pDecoderProfile, uint SampleWidth, uint SampleHeight, ref Silk.NET.DXGI.Rational pFrameRate, uint BitRate, ref Guid pCryptoType, ref uint pDecoderCaps)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (Guid* pCryptoTypePtr = &pCryptoType)
                    {
                        fixed (uint* pDecoderCapsPtr = &pDecoderCaps)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfilePtr, SampleWidth, SampleHeight, pFrameRatePtr, BitRate, pCryptoTypePtr, pDecoderCapsPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupported, pRealTimeHint);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, ref int pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pRealTimeHintPtr = &pRealTimeHint)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupported, pRealTimeHintPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, int* pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pSupportedPtr = &pSupported)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupportedPtr, pRealTimeHint);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, ref int pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pSupportedPtr = &pSupported)
            {
                fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupportedPtr, pRealTimeHintPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, int* pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDescPtr, pSupported, pRealTimeHint);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, ref int pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
            {
                fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDescPtr, pSupported, pRealTimeHintPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, int* pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
            {
                fixed (int* pSupportedPtr = &pSupported)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDescPtr, pSupportedPtr, pRealTimeHint);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, ref int pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
            {
                fixed (int* pSupportedPtr = &pSupported)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDescPtr, pSupportedPtr, pRealTimeHintPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDesc, pSupported, pRealTimeHint);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, ref int pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDesc, pSupported, pRealTimeHintPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, int* pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (int* pSupportedPtr = &pSupported)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDesc, pSupportedPtr, pRealTimeHint);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, ref int pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (int* pSupportedPtr = &pSupported)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDesc, pSupportedPtr, pRealTimeHintPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, int* pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDescPtr, pSupported, pRealTimeHint);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, ref int pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDescPtr, pSupported, pRealTimeHintPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, int* pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    fixed (int* pSupportedPtr = &pSupported)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDescPtr, pSupportedPtr, pRealTimeHint);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, ref int pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    fixed (int* pSupportedPtr = &pSupported)
                    {
                        fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDescPtr, pSupportedPtr, pRealTimeHintPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDesc, pSupported, pRealTimeHint);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, ref int pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDesc, pSupported, pRealTimeHintPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, int* pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (int* pSupportedPtr = &pSupported)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDesc, pSupportedPtr, pRealTimeHint);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, ref int pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (int* pSupportedPtr = &pSupported)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDesc, pSupportedPtr, pRealTimeHintPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, int* pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDescPtr, pSupported, pRealTimeHint);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, ref int pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDescPtr, pSupported, pRealTimeHintPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, int* pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    fixed (int* pSupportedPtr = &pSupported)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDescPtr, pSupportedPtr, pRealTimeHint);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, ref int pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    fixed (int* pSupportedPtr = &pSupported)
                    {
                        fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDescPtr, pSupportedPtr, pRealTimeHintPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDesc, pSupported, pRealTimeHint);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, ref int pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDesc, pSupported, pRealTimeHintPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, int* pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (int* pSupportedPtr = &pSupported)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDesc, pSupportedPtr, pRealTimeHint);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, ref int pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (int* pSupportedPtr = &pSupported)
                    {
                        fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDesc, pSupportedPtr, pRealTimeHintPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, int* pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDescPtr, pSupported, pRealTimeHint);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, ref int pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                    {
                        fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDescPtr, pSupported, pRealTimeHintPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, int* pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                    {
                        fixed (int* pSupportedPtr = &pSupported)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDescPtr, pSupportedPtr, pRealTimeHint);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, ref int pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                    {
                        fixed (int* pSupportedPtr = &pSupported)
                        {
                            fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDescPtr, pSupportedPtr, pRealTimeHintPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupported, pRealTimeHint);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, ref int pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupported, pRealTimeHintPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, int* pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (int* pSupportedPtr = &pSupported)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupportedPtr, pRealTimeHint);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, ref int pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (int* pSupportedPtr = &pSupported)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupportedPtr, pRealTimeHintPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, int* pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pOutputDescPtr, pSupported, pRealTimeHint);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, ref int pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pOutputDescPtr, pSupported, pRealTimeHintPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, int* pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    fixed (int* pSupportedPtr = &pSupported)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pOutputDescPtr, pSupportedPtr, pRealTimeHint);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, ref int pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    fixed (int* pSupportedPtr = &pSupported)
                    {
                        fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pOutputDescPtr, pSupportedPtr, pRealTimeHintPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDesc, pSupported, pRealTimeHint);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, ref int pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDesc, pSupported, pRealTimeHintPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, int* pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (int* pSupportedPtr = &pSupported)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDesc, pSupportedPtr, pRealTimeHint);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, ref int pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (int* pSupportedPtr = &pSupported)
                    {
                        fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDesc, pSupportedPtr, pRealTimeHintPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, int* pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDescPtr, pSupported, pRealTimeHint);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, ref int pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                    {
                        fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDescPtr, pSupported, pRealTimeHintPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, int* pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                    {
                        fixed (int* pSupportedPtr = &pSupported)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDescPtr, pSupportedPtr, pRealTimeHint);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, ref int pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                    {
                        fixed (int* pSupportedPtr = &pSupported)
                        {
                            fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDescPtr, pSupportedPtr, pRealTimeHintPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDesc, pSupported, pRealTimeHint);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, ref int pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDesc, pSupported, pRealTimeHintPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, int* pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (int* pSupportedPtr = &pSupported)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDesc, pSupportedPtr, pRealTimeHint);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, ref int pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (int* pSupportedPtr = &pSupported)
                    {
                        fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDesc, pSupportedPtr, pRealTimeHintPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, int* pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDescPtr, pSupported, pRealTimeHint);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, ref int pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                    {
                        fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDescPtr, pSupported, pRealTimeHintPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, int* pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                    {
                        fixed (int* pSupportedPtr = &pSupported)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDescPtr, pSupportedPtr, pRealTimeHint);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, ref int pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                    {
                        fixed (int* pSupportedPtr = &pSupported)
                        {
                            fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDescPtr, pSupportedPtr, pRealTimeHintPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDesc, pSupported, pRealTimeHint);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, ref int pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                    {
                        fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDesc, pSupported, pRealTimeHintPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, int* pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                    {
                        fixed (int* pSupportedPtr = &pSupported)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDesc, pSupportedPtr, pRealTimeHint);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, ref int pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                    {
                        fixed (int* pSupportedPtr = &pSupported)
                        {
                            fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDesc, pSupportedPtr, pRealTimeHintPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, int* pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                    {
                        fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDescPtr, pSupported, pRealTimeHint);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, ref int pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                    {
                        fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                        {
                            fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDescPtr, pSupported, pRealTimeHintPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, int* pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                    {
                        fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                        {
                            fixed (int* pSupportedPtr = &pSupported)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDescPtr, pSupportedPtr, pRealTimeHint);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, ref int pRealTimeHint)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                    {
                        fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                        {
                            fixed (int* pSupportedPtr = &pSupported)
                            {
                                fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDescPtr, pSupportedPtr, pRealTimeHintPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RecommendVideoDecoderDownsampleParameters(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pRecommendedOutputDesc)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pRecommendedOutputDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RecommendVideoDecoderDownsampleParameters(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pRecommendedOutputDesc)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoSampleDesc* pRecommendedOutputDescPtr = &pRecommendedOutputDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pRecommendedOutputDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RecommendVideoDecoderDownsampleParameters(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pRecommendedOutputDesc)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pRecommendedOutputDesc);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RecommendVideoDecoderDownsampleParameters(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pRecommendedOutputDesc)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (VideoSampleDesc* pRecommendedOutputDescPtr = &pRecommendedOutputDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pRecommendedOutputDescPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RecommendVideoDecoderDownsampleParameters(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pRecommendedOutputDesc)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pRecommendedOutputDesc);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RecommendVideoDecoderDownsampleParameters(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pRecommendedOutputDesc)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (VideoSampleDesc* pRecommendedOutputDescPtr = &pRecommendedOutputDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pRecommendedOutputDescPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RecommendVideoDecoderDownsampleParameters(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pRecommendedOutputDesc)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pRecommendedOutputDesc);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RecommendVideoDecoderDownsampleParameters(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pRecommendedOutputDesc)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (VideoSampleDesc* pRecommendedOutputDescPtr = &pRecommendedOutputDesc)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pRecommendedOutputDescPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RecommendVideoDecoderDownsampleParameters(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pRecommendedOutputDesc)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pRecommendedOutputDesc);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RecommendVideoDecoderDownsampleParameters(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pRecommendedOutputDesc)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (VideoSampleDesc* pRecommendedOutputDescPtr = &pRecommendedOutputDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pRecommendedOutputDescPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RecommendVideoDecoderDownsampleParameters(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pRecommendedOutputDesc)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pRecommendedOutputDesc);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RecommendVideoDecoderDownsampleParameters(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pRecommendedOutputDesc)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (VideoSampleDesc* pRecommendedOutputDescPtr = &pRecommendedOutputDesc)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pRecommendedOutputDescPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RecommendVideoDecoderDownsampleParameters(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pRecommendedOutputDesc)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pRecommendedOutputDesc);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RecommendVideoDecoderDownsampleParameters(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pRecommendedOutputDesc)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (VideoSampleDesc* pRecommendedOutputDescPtr = &pRecommendedOutputDesc)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pRecommendedOutputDescPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RecommendVideoDecoderDownsampleParameters(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pRecommendedOutputDesc)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pRecommendedOutputDesc);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RecommendVideoDecoderDownsampleParameters(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pRecommendedOutputDesc)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
            {
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                    {
                        fixed (VideoSampleDesc* pRecommendedOutputDescPtr = &pRecommendedOutputDesc)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pRecommendedOutputDescPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckFeatureSupport(FeatureVideo Feature, void* pFeatureSupportData, uint FeatureSupportDataSize)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, FeatureVideo, void*, uint, int>)@this->LpVtbl[24])(@this, Feature, pFeatureSupportData, FeatureSupportDataSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckFeatureSupport<T0>(FeatureVideo Feature, ref T0 pFeatureSupportData, uint FeatureSupportDataSize) where T0 : unmanaged
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pFeatureSupportDataPtr = &pFeatureSupportData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, FeatureVideo, void*, uint, int>)@this->LpVtbl[24])(@this, Feature, pFeatureSupportDataPtr, FeatureSupportDataSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int NegotiateCryptoSessionKeyExchangeMT(ID3D11CryptoSession* pCryptoSession, CryptoSessionKeyExchangeFlags flags, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11CryptoSession*, CryptoSessionKeyExchangeFlags, uint, void*, int>)@this->LpVtbl[25])(@this, pCryptoSession, flags, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int NegotiateCryptoSessionKeyExchangeMT<T0>(ID3D11CryptoSession* pCryptoSession, CryptoSessionKeyExchangeFlags flags, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11CryptoSession*, CryptoSessionKeyExchangeFlags, uint, void*, int>)@this->LpVtbl[25])(@this, pCryptoSession, flags, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int NegotiateCryptoSessionKeyExchangeMT(ref ID3D11CryptoSession pCryptoSession, CryptoSessionKeyExchangeFlags flags, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11CryptoSession*, CryptoSessionKeyExchangeFlags, uint, void*, int>)@this->LpVtbl[25])(@this, pCryptoSessionPtr, flags, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int NegotiateCryptoSessionKeyExchangeMT<T0>(ref ID3D11CryptoSession pCryptoSession, CryptoSessionKeyExchangeFlags flags, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11CryptoSession*, CryptoSessionKeyExchangeFlags, uint, void*, int>)@this->LpVtbl[25])(@this, pCryptoSessionPtr, flags, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder<TI0>(VideoDecoderDesc* pVideoDesc, VideoDecoderConfig* pConfig, ref ComPtr<TI0> ppDecoder) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoDecoder(pVideoDesc, pConfig, (ID3D11VideoDecoder**) ppDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder<TI0>(VideoDecoderDesc* pVideoDesc, ref VideoDecoderConfig pConfig, ref ComPtr<TI0> ppDecoder) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoDecoder(pVideoDesc, ref pConfig, (ID3D11VideoDecoder**) ppDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder<TI0>(ref VideoDecoderDesc pVideoDesc, VideoDecoderConfig* pConfig, ref ComPtr<TI0> ppDecoder) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoDecoder(ref pVideoDesc, pConfig, (ID3D11VideoDecoder**) ppDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoDecoder<TI0>(ref VideoDecoderDesc pVideoDesc, ref VideoDecoderConfig pConfig, ref ComPtr<TI0> ppDecoder) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoDecoder(ref pVideoDesc, ref pConfig, (ID3D11VideoDecoder**) ppDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor<TI0>(ID3D11VideoProcessorEnumerator* pEnum, uint RateConversionIndex, ref ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessor(pEnum, RateConversionIndex, (ID3D11VideoProcessor**) ppVideoProcessor.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoProcessor<TI0>(ref ID3D11VideoProcessorEnumerator pEnum, uint RateConversionIndex, ref ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessor(ref pEnum, RateConversionIndex, (ID3D11VideoProcessor**) ppVideoProcessor.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateAuthenticatedChannel<TI0>(AuthenticatedChannelType ChannelType, ref ComPtr<TI0> ppAuthenticatedChannel) where TI0 : unmanaged, IComVtbl<ID3D11AuthenticatedChannel>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateAuthenticatedChannel(ChannelType, (ID3D11AuthenticatedChannel**) ppAuthenticatedChannel.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession<TI0>(Guid* pCryptoType, Guid* pDecoderProfile, out ComPtr<TI0> ppCryptoSession) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCryptoSession = default;
            return @this->CreateCryptoSession(pCryptoType, pDecoderProfile, SilkMarshal.GuidPtrOf<TI0>(), (ID3D11CryptoSession**) ppCryptoSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession<TI0>(Guid* pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ref ComPtr<TI0> ppCryptoSession) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCryptoSession(pCryptoType, pDecoderProfile, ref pKeyExchangeType, (ID3D11CryptoSession**) ppCryptoSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession<TI0>(Guid* pCryptoType, ref Guid pDecoderProfile, out ComPtr<TI0> ppCryptoSession) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCryptoSession = default;
            return @this->CreateCryptoSession(pCryptoType, ref pDecoderProfile, SilkMarshal.GuidPtrOf<TI0>(), (ID3D11CryptoSession**) ppCryptoSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession<TI0>(Guid* pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ref ComPtr<TI0> ppCryptoSession) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCryptoSession(pCryptoType, ref pDecoderProfile, ref pKeyExchangeType, (ID3D11CryptoSession**) ppCryptoSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession<TI0>(ref Guid pCryptoType, Guid* pDecoderProfile, out ComPtr<TI0> ppCryptoSession) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCryptoSession = default;
            return @this->CreateCryptoSession(ref pCryptoType, pDecoderProfile, SilkMarshal.GuidPtrOf<TI0>(), (ID3D11CryptoSession**) ppCryptoSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession<TI0>(ref Guid pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ref ComPtr<TI0> ppCryptoSession) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCryptoSession(ref pCryptoType, pDecoderProfile, ref pKeyExchangeType, (ID3D11CryptoSession**) ppCryptoSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCryptoSession<TI0>(ref Guid pCryptoType, ref Guid pDecoderProfile, out ComPtr<TI0> ppCryptoSession) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCryptoSession = default;
            return @this->CreateCryptoSession(ref pCryptoType, ref pDecoderProfile, SilkMarshal.GuidPtrOf<TI0>(), (ID3D11CryptoSession**) ppCryptoSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCryptoSession<TI0>(ref Guid pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ref ComPtr<TI0> ppCryptoSession) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCryptoSession(ref pCryptoType, ref pDecoderProfile, ref pKeyExchangeType, (ID3D11CryptoSession**) ppCryptoSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderOutputView<TI0>(ID3D11Resource* pResource, VideoDecoderOutputViewDesc* pDesc, ref ComPtr<TI0> ppVDOVView) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoderOutputView>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoDecoderOutputView(pResource, pDesc, (ID3D11VideoDecoderOutputView**) ppVDOVView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderOutputView<TI0>(ID3D11Resource* pResource, ref VideoDecoderOutputViewDesc pDesc, ref ComPtr<TI0> ppVDOVView) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoderOutputView>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoDecoderOutputView(pResource, ref pDesc, (ID3D11VideoDecoderOutputView**) ppVDOVView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderOutputView<TI0>(ref ID3D11Resource pResource, VideoDecoderOutputViewDesc* pDesc, ref ComPtr<TI0> ppVDOVView) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoderOutputView>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoDecoderOutputView(ref pResource, pDesc, (ID3D11VideoDecoderOutputView**) ppVDOVView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoDecoderOutputView<TI0>(ref ID3D11Resource pResource, ref VideoDecoderOutputViewDesc pDesc, ref ComPtr<TI0> ppVDOVView) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoderOutputView>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoDecoderOutputView(ref pResource, ref pDesc, (ID3D11VideoDecoderOutputView**) ppVDOVView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView<TI0>(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorInputViewDesc* pDesc, ref ComPtr<TI0> ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorInputView>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorInputView(pResource, pEnum, pDesc, (ID3D11VideoProcessorInputView**) ppVPIView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView<TI0>(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorInputViewDesc pDesc, ref ComPtr<TI0> ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorInputView>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorInputView(pResource, pEnum, ref pDesc, (ID3D11VideoProcessorInputView**) ppVPIView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView<TI0>(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorInputViewDesc* pDesc, ref ComPtr<TI0> ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorInputView>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorInputView(pResource, ref pEnum, pDesc, (ID3D11VideoProcessorInputView**) ppVPIView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView<TI0>(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorInputViewDesc pDesc, ref ComPtr<TI0> ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorInputView>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorInputView(pResource, ref pEnum, ref pDesc, (ID3D11VideoProcessorInputView**) ppVPIView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView<TI0>(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorInputViewDesc* pDesc, ref ComPtr<TI0> ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorInputView>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorInputView(ref pResource, pEnum, pDesc, (ID3D11VideoProcessorInputView**) ppVPIView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView<TI0>(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorInputViewDesc pDesc, ref ComPtr<TI0> ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorInputView>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorInputView(ref pResource, pEnum, ref pDesc, (ID3D11VideoProcessorInputView**) ppVPIView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView<TI0>(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorInputViewDesc* pDesc, ref ComPtr<TI0> ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorInputView>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorInputView(ref pResource, ref pEnum, pDesc, (ID3D11VideoProcessorInputView**) ppVPIView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoProcessorInputView<TI0>(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorInputViewDesc pDesc, ref ComPtr<TI0> ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorInputView>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorInputView(ref pResource, ref pEnum, ref pDesc, (ID3D11VideoProcessorInputView**) ppVPIView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView<TI0>(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorOutputViewDesc* pDesc, ref ComPtr<TI0> ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorOutputView(pResource, pEnum, pDesc, (ID3D11VideoProcessorOutputView**) ppVPOView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView<TI0>(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorOutputViewDesc pDesc, ref ComPtr<TI0> ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorOutputView(pResource, pEnum, ref pDesc, (ID3D11VideoProcessorOutputView**) ppVPOView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView<TI0>(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorOutputViewDesc* pDesc, ref ComPtr<TI0> ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorOutputView(pResource, ref pEnum, pDesc, (ID3D11VideoProcessorOutputView**) ppVPOView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView<TI0>(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorOutputViewDesc pDesc, ref ComPtr<TI0> ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorOutputView(pResource, ref pEnum, ref pDesc, (ID3D11VideoProcessorOutputView**) ppVPOView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView<TI0>(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorOutputViewDesc* pDesc, ref ComPtr<TI0> ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorOutputView(ref pResource, pEnum, pDesc, (ID3D11VideoProcessorOutputView**) ppVPOView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView<TI0>(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorOutputViewDesc pDesc, ref ComPtr<TI0> ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorOutputView(ref pResource, pEnum, ref pDesc, (ID3D11VideoProcessorOutputView**) ppVPOView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView<TI0>(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorOutputViewDesc* pDesc, ref ComPtr<TI0> ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorOutputView(ref pResource, ref pEnum, pDesc, (ID3D11VideoProcessorOutputView**) ppVPOView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoProcessorOutputView<TI0>(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorOutputViewDesc pDesc, ref ComPtr<TI0> ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorOutputView(ref pResource, ref pEnum, ref pDesc, (ID3D11VideoProcessorOutputView**) ppVPOView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorEnumerator<TI0>(VideoProcessorContentDesc* pDesc, ref ComPtr<TI0> ppEnum) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorEnumerator(pDesc, (ID3D11VideoProcessorEnumerator**) ppEnum.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoProcessorEnumerator<TI0>(ref VideoProcessorContentDesc pDesc, ref ComPtr<TI0> ppEnum) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorEnumerator(ref pDesc, (ID3D11VideoProcessorEnumerator**) ppEnum.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateCryptoSession<TI0>(Guid* pCryptoType, Guid* pDecoderProfile) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCryptoSession(pCryptoType, pDecoderProfile, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateCryptoSession<TI0>(Guid* pCryptoType, ref Guid pDecoderProfile) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCryptoSession(pCryptoType, ref pDecoderProfile, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateCryptoSession<TI0>(ref Guid pCryptoType, Guid* pDecoderProfile) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCryptoSession(ref pCryptoType, pDecoderProfile, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateCryptoSession<TI0>(ref Guid pCryptoType, ref Guid pDecoderProfile) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCryptoSession(ref pCryptoType, ref pDecoderProfile, out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
