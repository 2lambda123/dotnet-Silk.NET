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

namespace Silk.NET.Direct3D11;

public unsafe static class D3D11VideoDeviceVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11VideoDevice> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11VideoDevice> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D11VideoDevice> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D11VideoDevice> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D11VideoDevice> thisVtbl, VideoDecoderDesc* pVideoDesc, VideoDecoderConfig* pConfig, ID3D11VideoDecoder** ppDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDesc, pConfig, ppDecoder);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D11VideoDevice> thisVtbl, VideoDecoderDesc* pVideoDesc, VideoDecoderConfig* pConfig, ref ID3D11VideoDecoder* ppDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11VideoDecoder** ppDecoderPtr = &ppDecoder)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDesc, pConfig, ppDecoderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D11VideoDevice> thisVtbl, VideoDecoderDesc* pVideoDesc, ref VideoDecoderConfig pConfig, ID3D11VideoDecoder** ppDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDesc, pConfigPtr, ppDecoder);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D11VideoDevice> thisVtbl, VideoDecoderDesc* pVideoDesc, ref VideoDecoderConfig pConfig, ref ID3D11VideoDecoder* ppDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
        {
            fixed (ID3D11VideoDecoder** ppDecoderPtr = &ppDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDesc, pConfigPtr, ppDecoderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D11VideoDevice> thisVtbl, ref VideoDecoderDesc pVideoDesc, VideoDecoderConfig* pConfig, ID3D11VideoDecoder** ppDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pVideoDescPtr = &pVideoDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDescPtr, pConfig, ppDecoder);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D11VideoDevice> thisVtbl, ref VideoDecoderDesc pVideoDesc, VideoDecoderConfig* pConfig, ref ID3D11VideoDecoder* ppDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (ID3D11VideoDecoder** ppDecoderPtr = &ppDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDescPtr, pConfig, ppDecoderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D11VideoDevice> thisVtbl, ref VideoDecoderDesc pVideoDesc, ref VideoDecoderConfig pConfig, ID3D11VideoDecoder** ppDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDescPtr, pConfigPtr, ppDecoder);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D11VideoDevice> thisVtbl, ref VideoDecoderDesc pVideoDesc, ref VideoDecoderConfig pConfig, ref ID3D11VideoDecoder* ppDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
            {
                fixed (ID3D11VideoDecoder** ppDecoderPtr = &ppDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDescPtr, pConfigPtr, ppDecoderPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11VideoProcessorEnumerator* pEnum, uint RateConversionIndex, ID3D11VideoProcessor** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int>)@this->LpVtbl[4])(@this, pEnum, RateConversionIndex, ppVideoProcessor);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11VideoProcessorEnumerator* pEnum, uint RateConversionIndex, ref ID3D11VideoProcessor* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11VideoProcessor** ppVideoProcessorPtr = &ppVideoProcessor)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int>)@this->LpVtbl[4])(@this, pEnum, RateConversionIndex, ppVideoProcessorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11VideoProcessorEnumerator pEnum, uint RateConversionIndex, ID3D11VideoProcessor** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int>)@this->LpVtbl[4])(@this, pEnumPtr, RateConversionIndex, ppVideoProcessor);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11VideoProcessorEnumerator pEnum, uint RateConversionIndex, ref ID3D11VideoProcessor* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
        {
            fixed (ID3D11VideoProcessor** ppVideoProcessorPtr = &ppVideoProcessor)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int>)@this->LpVtbl[4])(@this, pEnumPtr, RateConversionIndex, ppVideoProcessorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAuthenticatedChannel(this ComPtr<ID3D11VideoDevice> thisVtbl, AuthenticatedChannelType ChannelType, ID3D11AuthenticatedChannel** ppAuthenticatedChannel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, AuthenticatedChannelType, ID3D11AuthenticatedChannel**, int>)@this->LpVtbl[5])(@this, ChannelType, ppAuthenticatedChannel);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAuthenticatedChannel(this ComPtr<ID3D11VideoDevice> thisVtbl, AuthenticatedChannelType ChannelType, ref ID3D11AuthenticatedChannel* ppAuthenticatedChannel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11AuthenticatedChannel** ppAuthenticatedChannelPtr = &ppAuthenticatedChannel)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, AuthenticatedChannelType, ID3D11AuthenticatedChannel**, int>)@this->LpVtbl[5])(@this, ChannelType, ppAuthenticatedChannelPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfile, pKeyExchangeType, ppCryptoSession);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfile, pKeyExchangeType, ppCryptoSessionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfile, pKeyExchangeTypePtr, ppCryptoSession);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
        {
            fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfile, pKeyExchangeTypePtr, ppCryptoSessionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeType, ppCryptoSession);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeType, ppCryptoSessionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeTypePtr, ppCryptoSession);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeTypePtr, ppCryptoSessionPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice> thisVtbl, ref Guid pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeType, ppCryptoSession);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice> thisVtbl, ref Guid pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeType, ppCryptoSessionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice> thisVtbl, ref Guid pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeTypePtr, ppCryptoSession);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice> thisVtbl, ref Guid pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeTypePtr, ppCryptoSessionPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice> thisVtbl, ref Guid pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeType, ppCryptoSession);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice> thisVtbl, ref Guid pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeType, ppCryptoSessionPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice> thisVtbl, ref Guid pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeTypePtr, ppCryptoSession);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice> thisVtbl, ref Guid pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeTypePtr, ppCryptoSessionPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11Resource* pResource, VideoDecoderOutputViewDesc* pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResource, pDesc, ppVDOVView);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11Resource* pResource, VideoDecoderOutputViewDesc* pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11VideoDecoderOutputView** ppVDOVViewPtr = &ppVDOVView)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResource, pDesc, ppVDOVViewPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11Resource* pResource, ref VideoDecoderOutputViewDesc pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderOutputViewDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResource, pDescPtr, ppVDOVView);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11Resource* pResource, ref VideoDecoderOutputViewDesc pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderOutputViewDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D11VideoDecoderOutputView** ppVDOVViewPtr = &ppVDOVView)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResource, pDescPtr, ppVDOVViewPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11Resource pResource, VideoDecoderOutputViewDesc* pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResourcePtr, pDesc, ppVDOVView);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11Resource pResource, VideoDecoderOutputViewDesc* pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D11VideoDecoderOutputView** ppVDOVViewPtr = &ppVDOVView)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResourcePtr, pDesc, ppVDOVViewPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11Resource pResource, ref VideoDecoderOutputViewDesc pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (VideoDecoderOutputViewDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResourcePtr, pDescPtr, ppVDOVView);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11Resource pResource, ref VideoDecoderOutputViewDesc pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (VideoDecoderOutputViewDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D11VideoDecoderOutputView** ppVDOVViewPtr = &ppVDOVView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResourcePtr, pDescPtr, ppVDOVViewPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorInputViewDesc* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnum, pDesc, ppVPIView);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnum, pDesc, ppVPIViewPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorInputViewDesc pDesc, ID3D11VideoProcessorInputView** ppVPIView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnum, pDescPtr, ppVPIView);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnum, pDescPtr, ppVPIViewPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorInputViewDesc* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnumPtr, pDesc, ppVPIView);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
        {
            fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnumPtr, pDesc, ppVPIViewPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorInputViewDesc pDesc, ID3D11VideoProcessorInputView** ppVPIView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
        {
            fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnumPtr, pDescPtr, ppVPIView);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
        {
            fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnumPtr, pDescPtr, ppVPIViewPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorInputViewDesc* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnum, pDesc, ppVPIView);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnum, pDesc, ppVPIViewPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorInputViewDesc pDesc, ID3D11VideoProcessorInputView** ppVPIView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnum, pDescPtr, ppVPIView);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnum, pDescPtr, ppVPIViewPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorInputViewDesc* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnumPtr, pDesc, ppVPIView);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnumPtr, pDesc, ppVPIViewPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorInputViewDesc pDesc, ID3D11VideoProcessorInputView** ppVPIView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnumPtr, pDescPtr, ppVPIView);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnumPtr, pDescPtr, ppVPIViewPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorOutputViewDesc* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnum, pDesc, ppVPOView);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnum, pDesc, ppVPOViewPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorOutputViewDesc pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnum, pDescPtr, ppVPOView);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnum, pDescPtr, ppVPOViewPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorOutputViewDesc* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnumPtr, pDesc, ppVPOView);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
        {
            fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnumPtr, pDesc, ppVPOViewPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorOutputViewDesc pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
        {
            fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnumPtr, pDescPtr, ppVPOView);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
        {
            fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnumPtr, pDescPtr, ppVPOViewPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorOutputViewDesc* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnum, pDesc, ppVPOView);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnum, pDesc, ppVPOViewPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorOutputViewDesc pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnum, pDescPtr, ppVPOView);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnum, pDescPtr, ppVPOViewPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorOutputViewDesc* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnumPtr, pDesc, ppVPOView);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnumPtr, pDesc, ppVPOViewPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorOutputViewDesc pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnumPtr, pDescPtr, ppVPOView);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnumPtr, pDescPtr, ppVPOViewPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorEnumerator(this ComPtr<ID3D11VideoDevice> thisVtbl, VideoProcessorContentDesc* pDesc, ID3D11VideoProcessorEnumerator** ppEnum)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoProcessorContentDesc*, ID3D11VideoProcessorEnumerator**, int>)@this->LpVtbl[10])(@this, pDesc, ppEnum);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorEnumerator(this ComPtr<ID3D11VideoDevice> thisVtbl, VideoProcessorContentDesc* pDesc, ref ID3D11VideoProcessorEnumerator* ppEnum)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11VideoProcessorEnumerator** ppEnumPtr = &ppEnum)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoProcessorContentDesc*, ID3D11VideoProcessorEnumerator**, int>)@this->LpVtbl[10])(@this, pDesc, ppEnumPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorEnumerator(this ComPtr<ID3D11VideoDevice> thisVtbl, ref VideoProcessorContentDesc pDesc, ID3D11VideoProcessorEnumerator** ppEnum)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessorContentDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoProcessorContentDesc*, ID3D11VideoProcessorEnumerator**, int>)@this->LpVtbl[10])(@this, pDescPtr, ppEnum);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorEnumerator(this ComPtr<ID3D11VideoDevice> thisVtbl, ref VideoProcessorContentDesc pDesc, ref ID3D11VideoProcessorEnumerator* ppEnum)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessorContentDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D11VideoProcessorEnumerator** ppEnumPtr = &ppEnum)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoProcessorContentDesc*, ID3D11VideoProcessorEnumerator**, int>)@this->LpVtbl[10])(@this, pDescPtr, ppEnumPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetVideoDecoderProfileCount(this ComPtr<ID3D11VideoDevice> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, uint>)@this->LpVtbl[11])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderProfile(this ComPtr<ID3D11VideoDevice> thisVtbl, uint Index, Guid* pDecoderProfile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, uint, Guid*, int>)@this->LpVtbl[12])(@this, Index, pDecoderProfile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoDecoderProfile(this ComPtr<ID3D11VideoDevice> thisVtbl, uint Index, ref Guid pDecoderProfile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, uint, Guid*, int>)@this->LpVtbl[12])(@this, Index, pDecoderProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderFormat(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pDecoderProfile, Silk.NET.DXGI.Format Format, int* pSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Silk.NET.DXGI.Format, int*, int>)@this->LpVtbl[13])(@this, pDecoderProfile, Format, pSupported);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderFormat(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pDecoderProfile, Silk.NET.DXGI.Format Format, ref int pSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pSupportedPtr = &pSupported)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Silk.NET.DXGI.Format, int*, int>)@this->LpVtbl[13])(@this, pDecoderProfile, Format, pSupportedPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderFormat(this ComPtr<ID3D11VideoDevice> thisVtbl, ref Guid pDecoderProfile, Silk.NET.DXGI.Format Format, int* pSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Silk.NET.DXGI.Format, int*, int>)@this->LpVtbl[13])(@this, pDecoderProfilePtr, Format, pSupported);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckVideoDecoderFormat(this ComPtr<ID3D11VideoDevice> thisVtbl, ref Guid pDecoderProfile, Silk.NET.DXGI.Format Format, ref int pSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (int* pSupportedPtr = &pSupported)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Silk.NET.DXGI.Format, int*, int>)@this->LpVtbl[13])(@this, pDecoderProfilePtr, Format, pSupportedPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderConfigCount(this ComPtr<ID3D11VideoDevice> thisVtbl, VideoDecoderDesc* pDesc, uint* pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDesc*, uint*, int>)@this->LpVtbl[14])(@this, pDesc, pCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderConfigCount(this ComPtr<ID3D11VideoDevice> thisVtbl, VideoDecoderDesc* pDesc, ref uint pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDesc*, uint*, int>)@this->LpVtbl[14])(@this, pDesc, pCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderConfigCount(this ComPtr<ID3D11VideoDevice> thisVtbl, ref VideoDecoderDesc pDesc, uint* pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDesc*, uint*, int>)@this->LpVtbl[14])(@this, pDescPtr, pCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoDecoderConfigCount(this ComPtr<ID3D11VideoDevice> thisVtbl, ref VideoDecoderDesc pDesc, ref uint pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDesc*, uint*, int>)@this->LpVtbl[14])(@this, pDescPtr, pCountPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderConfig(this ComPtr<ID3D11VideoDevice> thisVtbl, VideoDecoderDesc* pDesc, uint Index, VideoDecoderConfig* pConfig)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDesc*, uint, VideoDecoderConfig*, int>)@this->LpVtbl[15])(@this, pDesc, Index, pConfig);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderConfig(this ComPtr<ID3D11VideoDevice> thisVtbl, VideoDecoderDesc* pDesc, uint Index, ref VideoDecoderConfig pConfig)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDesc*, uint, VideoDecoderConfig*, int>)@this->LpVtbl[15])(@this, pDesc, Index, pConfigPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderConfig(this ComPtr<ID3D11VideoDevice> thisVtbl, ref VideoDecoderDesc pDesc, uint Index, VideoDecoderConfig* pConfig)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDesc*, uint, VideoDecoderConfig*, int>)@this->LpVtbl[15])(@this, pDescPtr, Index, pConfig);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoDecoderConfig(this ComPtr<ID3D11VideoDevice> thisVtbl, ref VideoDecoderDesc pDesc, uint Index, ref VideoDecoderConfig pConfig)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDesc*, uint, VideoDecoderConfig*, int>)@this->LpVtbl[15])(@this, pDescPtr, Index, pConfigPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pCryptoType, Guid* pDecoderProfile, VideoContentProtectionCaps* pCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoType, pDecoderProfile, pCaps);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pCryptoType, Guid* pDecoderProfile, ref VideoContentProtectionCaps pCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoContentProtectionCaps* pCapsPtr = &pCaps)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoType, pDecoderProfile, pCapsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pCryptoType, ref Guid pDecoderProfile, VideoContentProtectionCaps* pCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoType, pDecoderProfilePtr, pCaps);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pCryptoType, ref Guid pDecoderProfile, ref VideoContentProtectionCaps pCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (VideoContentProtectionCaps* pCapsPtr = &pCaps)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoType, pDecoderProfilePtr, pCapsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<ID3D11VideoDevice> thisVtbl, ref Guid pCryptoType, Guid* pDecoderProfile, VideoContentProtectionCaps* pCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoTypePtr, pDecoderProfile, pCaps);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<ID3D11VideoDevice> thisVtbl, ref Guid pCryptoType, Guid* pDecoderProfile, ref VideoContentProtectionCaps pCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (VideoContentProtectionCaps* pCapsPtr = &pCaps)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoTypePtr, pDecoderProfile, pCapsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<ID3D11VideoDevice> thisVtbl, ref Guid pCryptoType, ref Guid pDecoderProfile, VideoContentProtectionCaps* pCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoTypePtr, pDecoderProfilePtr, pCaps);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetContentProtectionCaps(this ComPtr<ID3D11VideoDevice> thisVtbl, ref Guid pCryptoType, ref Guid pDecoderProfile, ref VideoContentProtectionCaps pCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (VideoContentProtectionCaps* pCapsPtr = &pCaps)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoTypePtr, pDecoderProfilePtr, pCapsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoKeyExchange(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pCryptoType, Guid* pDecoderProfile, uint Index, Guid* pKeyExchangeType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoType, pDecoderProfile, Index, pKeyExchangeType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoKeyExchange(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pCryptoType, Guid* pDecoderProfile, uint Index, ref Guid pKeyExchangeType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoType, pDecoderProfile, Index, pKeyExchangeTypePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoKeyExchange(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pCryptoType, ref Guid pDecoderProfile, uint Index, Guid* pKeyExchangeType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoType, pDecoderProfilePtr, Index, pKeyExchangeType);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoKeyExchange(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pCryptoType, ref Guid pDecoderProfile, uint Index, ref Guid pKeyExchangeType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoType, pDecoderProfilePtr, Index, pKeyExchangeTypePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoKeyExchange(this ComPtr<ID3D11VideoDevice> thisVtbl, ref Guid pCryptoType, Guid* pDecoderProfile, uint Index, Guid* pKeyExchangeType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoTypePtr, pDecoderProfile, Index, pKeyExchangeType);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoKeyExchange(this ComPtr<ID3D11VideoDevice> thisVtbl, ref Guid pCryptoType, Guid* pDecoderProfile, uint Index, ref Guid pKeyExchangeType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoTypePtr, pDecoderProfile, Index, pKeyExchangeTypePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoKeyExchange(this ComPtr<ID3D11VideoDevice> thisVtbl, ref Guid pCryptoType, ref Guid pDecoderProfile, uint Index, Guid* pKeyExchangeType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoTypePtr, pDecoderProfilePtr, Index, pKeyExchangeType);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckCryptoKeyExchange(this ComPtr<ID3D11VideoDevice> thisVtbl, ref Guid pCryptoType, ref Guid pDecoderProfile, uint Index, ref Guid pKeyExchangeType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoTypePtr, pDecoderProfilePtr, Index, pKeyExchangeTypePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* guid, uint DataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, uint, void*, int>)@this->LpVtbl[18])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, uint, void*, int>)@this->LpVtbl[18])(@this, guid, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D11VideoDevice> thisVtbl, ref Guid guid, uint DataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, uint, void*, int>)@this->LpVtbl[18])(@this, guidPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<ID3D11VideoDevice> thisVtbl, ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, uint, void*, int>)@this->LpVtbl[18])(@this, guidPtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[19])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[19])(@this, guid, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D11VideoDevice> thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[19])(@this, guidPtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<ID3D11VideoDevice> thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[19])(@this, guidPtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, VideoDecoderDesc* pVideoDesc, VideoDecoderConfig* pConfig, ref ComPtr<TI0> ppDecoder) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoder(pVideoDesc, pConfig, (ID3D11VideoDecoder**) ppDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D11VideoDevice> thisVtbl, VideoDecoderDesc* pVideoDesc, Span<VideoDecoderConfig> pConfig, ID3D11VideoDecoder** ppDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(pVideoDesc, ref pConfig.GetPinnableReference(), ppDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, VideoDecoderDesc* pVideoDesc, ref VideoDecoderConfig pConfig, ref ComPtr<TI0> ppDecoder) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoder(pVideoDesc, ref pConfig, (ID3D11VideoDecoder**) ppDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D11VideoDevice> thisVtbl, VideoDecoderDesc* pVideoDesc, Span<VideoDecoderConfig> pConfig, ref ID3D11VideoDecoder* ppDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(pVideoDesc, ref pConfig.GetPinnableReference(), ref ppDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<VideoDecoderDesc> pVideoDesc, VideoDecoderConfig* pConfig, ID3D11VideoDecoder** ppDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(ref pVideoDesc.GetPinnableReference(), pConfig, ppDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, ref VideoDecoderDesc pVideoDesc, VideoDecoderConfig* pConfig, ref ComPtr<TI0> ppDecoder) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoder(ref pVideoDesc, pConfig, (ID3D11VideoDecoder**) ppDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<VideoDecoderDesc> pVideoDesc, VideoDecoderConfig* pConfig, ref ID3D11VideoDecoder* ppDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(ref pVideoDesc.GetPinnableReference(), pConfig, ref ppDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<VideoDecoderDesc> pVideoDesc, Span<VideoDecoderConfig> pConfig, ID3D11VideoDecoder** ppDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(ref pVideoDesc.GetPinnableReference(), ref pConfig.GetPinnableReference(), ppDecoder);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoDecoder<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, ref VideoDecoderDesc pVideoDesc, ref VideoDecoderConfig pConfig, ref ComPtr<TI0> ppDecoder) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoder(ref pVideoDesc, ref pConfig, (ID3D11VideoDecoder**) ppDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<VideoDecoderDesc> pVideoDesc, Span<VideoDecoderConfig> pConfig, ref ID3D11VideoDecoder* ppDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(ref pVideoDesc.GetPinnableReference(), ref pConfig.GetPinnableReference(), ref ppDecoder);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoProcessor<TI0, TI1>(this ComPtr<ID3D11VideoDevice> thisVtbl, ComPtr<TI0> pEnum, uint RateConversionIndex, ref ComPtr<TI1> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessor((ID3D11VideoProcessorEnumerator*) pEnum.Handle, RateConversionIndex, (ID3D11VideoProcessor**) ppVideoProcessor.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, ComPtr<TI0> pEnum, uint RateConversionIndex, ref ID3D11VideoProcessor* ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessor((ID3D11VideoProcessorEnumerator*) pEnum.Handle, RateConversionIndex, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<ID3D11VideoProcessorEnumerator> pEnum, uint RateConversionIndex, ID3D11VideoProcessor** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor(ref pEnum.GetPinnableReference(), RateConversionIndex, ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoProcessor<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11VideoProcessorEnumerator pEnum, uint RateConversionIndex, ref ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessor(ref pEnum, RateConversionIndex, (ID3D11VideoProcessor**) ppVideoProcessor.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<ID3D11VideoProcessorEnumerator> pEnum, uint RateConversionIndex, ref ID3D11VideoProcessor* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor(ref pEnum.GetPinnableReference(), RateConversionIndex, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static int CreateAuthenticatedChannel<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, AuthenticatedChannelType ChannelType, ref ComPtr<TI0> ppAuthenticatedChannel) where TI0 : unmanaged, IComVtbl<ID3D11AuthenticatedChannel>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateAuthenticatedChannel(ChannelType, (ID3D11AuthenticatedChannel**) ppAuthenticatedChannel.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pCryptoType, Guid* pDecoderProfile, out ComPtr<TI0> ppCryptoSession) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCryptoSession = default;
        return @this->CreateCryptoSession(pCryptoType, pDecoderProfile, SilkMarshal.GuidPtrOf<TI0>(), (ID3D11CryptoSession**) ppCryptoSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pCryptoType, Guid* pDecoderProfile, Span<Guid> pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(pCryptoType, pDecoderProfile, ref pKeyExchangeType.GetPinnableReference(), ppCryptoSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ref ComPtr<TI0> ppCryptoSession) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCryptoSession(pCryptoType, pDecoderProfile, ref pKeyExchangeType, (ID3D11CryptoSession**) ppCryptoSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pCryptoType, Guid* pDecoderProfile, Span<Guid> pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(pCryptoType, pDecoderProfile, ref pKeyExchangeType.GetPinnableReference(), ref ppCryptoSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pCryptoType, Span<Guid> pDecoderProfile, Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(pCryptoType, ref pDecoderProfile.GetPinnableReference(), pKeyExchangeType, ppCryptoSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pCryptoType, ref Guid pDecoderProfile, out ComPtr<TI0> ppCryptoSession) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCryptoSession = default;
        return @this->CreateCryptoSession(pCryptoType, ref pDecoderProfile, SilkMarshal.GuidPtrOf<TI0>(), (ID3D11CryptoSession**) ppCryptoSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pCryptoType, Span<Guid> pDecoderProfile, Guid* pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(pCryptoType, ref pDecoderProfile.GetPinnableReference(), pKeyExchangeType, ref ppCryptoSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pCryptoType, Span<Guid> pDecoderProfile, Span<Guid> pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(pCryptoType, ref pDecoderProfile.GetPinnableReference(), ref pKeyExchangeType.GetPinnableReference(), ppCryptoSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ref ComPtr<TI0> ppCryptoSession) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCryptoSession(pCryptoType, ref pDecoderProfile, ref pKeyExchangeType, (ID3D11CryptoSession**) ppCryptoSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pCryptoType, Span<Guid> pDecoderProfile, Span<Guid> pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(pCryptoType, ref pDecoderProfile.GetPinnableReference(), ref pKeyExchangeType.GetPinnableReference(), ref ppCryptoSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<Guid> pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(ref pCryptoType.GetPinnableReference(), pDecoderProfile, pKeyExchangeType, ppCryptoSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, ref Guid pCryptoType, Guid* pDecoderProfile, out ComPtr<TI0> ppCryptoSession) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCryptoSession = default;
        return @this->CreateCryptoSession(ref pCryptoType, pDecoderProfile, SilkMarshal.GuidPtrOf<TI0>(), (ID3D11CryptoSession**) ppCryptoSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<Guid> pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(ref pCryptoType.GetPinnableReference(), pDecoderProfile, pKeyExchangeType, ref ppCryptoSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<Guid> pCryptoType, Guid* pDecoderProfile, Span<Guid> pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(ref pCryptoType.GetPinnableReference(), pDecoderProfile, ref pKeyExchangeType.GetPinnableReference(), ppCryptoSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, ref Guid pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ref ComPtr<TI0> ppCryptoSession) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCryptoSession(ref pCryptoType, pDecoderProfile, ref pKeyExchangeType, (ID3D11CryptoSession**) ppCryptoSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<Guid> pCryptoType, Guid* pDecoderProfile, Span<Guid> pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(ref pCryptoType.GetPinnableReference(), pDecoderProfile, ref pKeyExchangeType.GetPinnableReference(), ref ppCryptoSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<Guid> pCryptoType, Span<Guid> pDecoderProfile, Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(ref pCryptoType.GetPinnableReference(), ref pDecoderProfile.GetPinnableReference(), pKeyExchangeType, ppCryptoSession);
    }

    /// <summary>To be documented.</summary>
    public static int CreateCryptoSession<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, ref Guid pCryptoType, ref Guid pDecoderProfile, out ComPtr<TI0> ppCryptoSession) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCryptoSession = default;
        return @this->CreateCryptoSession(ref pCryptoType, ref pDecoderProfile, SilkMarshal.GuidPtrOf<TI0>(), (ID3D11CryptoSession**) ppCryptoSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<Guid> pCryptoType, Span<Guid> pDecoderProfile, Guid* pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(ref pCryptoType.GetPinnableReference(), ref pDecoderProfile.GetPinnableReference(), pKeyExchangeType, ref ppCryptoSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<Guid> pCryptoType, Span<Guid> pDecoderProfile, Span<Guid> pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(ref pCryptoType.GetPinnableReference(), ref pDecoderProfile.GetPinnableReference(), ref pKeyExchangeType.GetPinnableReference(), ppCryptoSession);
    }

    /// <summary>To be documented.</summary>
    public static int CreateCryptoSession<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, ref Guid pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ref ComPtr<TI0> ppCryptoSession) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCryptoSession(ref pCryptoType, ref pDecoderProfile, ref pKeyExchangeType, (ID3D11CryptoSession**) ppCryptoSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<Guid> pCryptoType, Span<Guid> pDecoderProfile, Span<Guid> pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(ref pCryptoType.GetPinnableReference(), ref pDecoderProfile.GetPinnableReference(), ref pKeyExchangeType.GetPinnableReference(), ref ppCryptoSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView<TI0, TI1>(this ComPtr<ID3D11VideoDevice> thisVtbl, ComPtr<TI0> pResource, VideoDecoderOutputViewDesc* pDesc, ref ComPtr<TI1> ppVDOVView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoDecoderOutputView>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoderOutputView((ID3D11Resource*) pResource.Handle, pDesc, (ID3D11VideoDecoderOutputView**) ppVDOVView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, ComPtr<TI0> pResource, VideoDecoderOutputViewDesc* pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoderOutputView((ID3D11Resource*) pResource.Handle, pDesc, ref ppVDOVView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11Resource* pResource, Span<VideoDecoderOutputViewDesc> pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderOutputView(pResource, ref pDesc.GetPinnableReference(), ppVDOVView);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoDecoderOutputView<TI0, TI1>(this ComPtr<ID3D11VideoDevice> thisVtbl, ComPtr<TI0> pResource, ref VideoDecoderOutputViewDesc pDesc, ref ComPtr<TI1> ppVDOVView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoDecoderOutputView>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoderOutputView((ID3D11Resource*) pResource.Handle, ref pDesc, (ID3D11VideoDecoderOutputView**) ppVDOVView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11Resource* pResource, Span<VideoDecoderOutputViewDesc> pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderOutputView(pResource, ref pDesc.GetPinnableReference(), ref ppVDOVView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, ComPtr<TI0> pResource, ref VideoDecoderOutputViewDesc pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoderOutputView((ID3D11Resource*) pResource.Handle, ref pDesc, ref ppVDOVView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<ID3D11Resource> pResource, VideoDecoderOutputViewDesc* pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderOutputView(ref pResource.GetPinnableReference(), pDesc, ppVDOVView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11Resource pResource, VideoDecoderOutputViewDesc* pDesc, ref ComPtr<TI0> ppVDOVView) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoderOutputView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoderOutputView(ref pResource, pDesc, (ID3D11VideoDecoderOutputView**) ppVDOVView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<ID3D11Resource> pResource, VideoDecoderOutputViewDesc* pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderOutputView(ref pResource.GetPinnableReference(), pDesc, ref ppVDOVView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<ID3D11Resource> pResource, Span<VideoDecoderOutputViewDesc> pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderOutputView(ref pResource.GetPinnableReference(), ref pDesc.GetPinnableReference(), ppVDOVView);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoDecoderOutputView<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11Resource pResource, ref VideoDecoderOutputViewDesc pDesc, ref ComPtr<TI0> ppVDOVView) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoderOutputView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoderOutputView(ref pResource, ref pDesc, (ID3D11VideoDecoderOutputView**) ppVDOVView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<ID3D11Resource> pResource, Span<VideoDecoderOutputViewDesc> pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderOutputView(ref pResource.GetPinnableReference(), ref pDesc.GetPinnableReference(), ref ppVDOVView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TI0, TI1, TI2>(this ComPtr<ID3D11VideoDevice> thisVtbl, ComPtr<TI0> pResource, ComPtr<TI1> pEnum, VideoProcessorInputViewDesc* pDesc, ref ComPtr<TI2> ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11VideoProcessorInputView>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorInputView((ID3D11Resource*) pResource.Handle, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, pDesc, (ID3D11VideoProcessorInputView**) ppVPIView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TI0, TI1>(this ComPtr<ID3D11VideoDevice> thisVtbl, ComPtr<TI0> pResource, ComPtr<TI1> pEnum, VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorInputView((ID3D11Resource*) pResource.Handle, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, pDesc, ref ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, Span<VideoProcessorInputViewDesc> pDesc, ID3D11VideoProcessorInputView** ppVPIView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorInputView(pResource, pEnum, ref pDesc.GetPinnableReference(), ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoProcessorInputView<TI0, TI1, TI2>(this ComPtr<ID3D11VideoDevice> thisVtbl, ComPtr<TI0> pResource, ComPtr<TI1> pEnum, ref VideoProcessorInputViewDesc pDesc, ref ComPtr<TI2> ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11VideoProcessorInputView>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorInputView((ID3D11Resource*) pResource.Handle, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, ref pDesc, (ID3D11VideoProcessorInputView**) ppVPIView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, Span<VideoProcessorInputViewDesc> pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorInputView(pResource, pEnum, ref pDesc.GetPinnableReference(), ref ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TI0, TI1>(this ComPtr<ID3D11VideoDevice> thisVtbl, ComPtr<TI0> pResource, ComPtr<TI1> pEnum, ref VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorInputView((ID3D11Resource*) pResource.Handle, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, ref pDesc, ref ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11Resource* pResource, Span<ID3D11VideoProcessorEnumerator> pEnum, VideoProcessorInputViewDesc* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorInputView(pResource, ref pEnum.GetPinnableReference(), pDesc, ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TI0, TI1>(this ComPtr<ID3D11VideoDevice> thisVtbl, ComPtr<TI0> pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorInputViewDesc* pDesc, ref ComPtr<TI1> ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorInputView>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorInputView((ID3D11Resource*) pResource.Handle, ref pEnum, pDesc, (ID3D11VideoProcessorInputView**) ppVPIView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11Resource* pResource, Span<ID3D11VideoProcessorEnumerator> pEnum, VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorInputView(pResource, ref pEnum.GetPinnableReference(), pDesc, ref ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, ComPtr<TI0> pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorInputView((ID3D11Resource*) pResource.Handle, ref pEnum, pDesc, ref ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11Resource* pResource, Span<ID3D11VideoProcessorEnumerator> pEnum, Span<VideoProcessorInputViewDesc> pDesc, ID3D11VideoProcessorInputView** ppVPIView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorInputView(pResource, ref pEnum.GetPinnableReference(), ref pDesc.GetPinnableReference(), ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoProcessorInputView<TI0, TI1>(this ComPtr<ID3D11VideoDevice> thisVtbl, ComPtr<TI0> pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorInputViewDesc pDesc, ref ComPtr<TI1> ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorInputView>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorInputView((ID3D11Resource*) pResource.Handle, ref pEnum, ref pDesc, (ID3D11VideoProcessorInputView**) ppVPIView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11Resource* pResource, Span<ID3D11VideoProcessorEnumerator> pEnum, Span<VideoProcessorInputViewDesc> pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorInputView(pResource, ref pEnum.GetPinnableReference(), ref pDesc.GetPinnableReference(), ref ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, ComPtr<TI0> pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorInputView((ID3D11Resource*) pResource.Handle, ref pEnum, ref pDesc, ref ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<ID3D11Resource> pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorInputViewDesc* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorInputView(ref pResource.GetPinnableReference(), pEnum, pDesc, ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TI0, TI1>(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11Resource pResource, ComPtr<TI0> pEnum, VideoProcessorInputViewDesc* pDesc, ref ComPtr<TI1> ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorInputView>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorInputView(ref pResource, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, pDesc, (ID3D11VideoProcessorInputView**) ppVPIView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<ID3D11Resource> pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorInputView(ref pResource.GetPinnableReference(), pEnum, pDesc, ref ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11Resource pResource, ComPtr<TI0> pEnum, VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorInputView(ref pResource, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, pDesc, ref ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<ID3D11Resource> pResource, ID3D11VideoProcessorEnumerator* pEnum, Span<VideoProcessorInputViewDesc> pDesc, ID3D11VideoProcessorInputView** ppVPIView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorInputView(ref pResource.GetPinnableReference(), pEnum, ref pDesc.GetPinnableReference(), ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoProcessorInputView<TI0, TI1>(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11Resource pResource, ComPtr<TI0> pEnum, ref VideoProcessorInputViewDesc pDesc, ref ComPtr<TI1> ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorInputView>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorInputView(ref pResource, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, ref pDesc, (ID3D11VideoProcessorInputView**) ppVPIView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<ID3D11Resource> pResource, ID3D11VideoProcessorEnumerator* pEnum, Span<VideoProcessorInputViewDesc> pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorInputView(ref pResource.GetPinnableReference(), pEnum, ref pDesc.GetPinnableReference(), ref ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11Resource pResource, ComPtr<TI0> pEnum, ref VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorInputView(ref pResource, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, ref pDesc, ref ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<ID3D11Resource> pResource, Span<ID3D11VideoProcessorEnumerator> pEnum, VideoProcessorInputViewDesc* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorInputView(ref pResource.GetPinnableReference(), ref pEnum.GetPinnableReference(), pDesc, ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorInputViewDesc* pDesc, ref ComPtr<TI0> ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorInputView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorInputView(ref pResource, ref pEnum, pDesc, (ID3D11VideoProcessorInputView**) ppVPIView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<ID3D11Resource> pResource, Span<ID3D11VideoProcessorEnumerator> pEnum, VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorInputView(ref pResource.GetPinnableReference(), ref pEnum.GetPinnableReference(), pDesc, ref ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<ID3D11Resource> pResource, Span<ID3D11VideoProcessorEnumerator> pEnum, Span<VideoProcessorInputViewDesc> pDesc, ID3D11VideoProcessorInputView** ppVPIView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorInputView(ref pResource.GetPinnableReference(), ref pEnum.GetPinnableReference(), ref pDesc.GetPinnableReference(), ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoProcessorInputView<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorInputViewDesc pDesc, ref ComPtr<TI0> ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorInputView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorInputView(ref pResource, ref pEnum, ref pDesc, (ID3D11VideoProcessorInputView**) ppVPIView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<ID3D11Resource> pResource, Span<ID3D11VideoProcessorEnumerator> pEnum, Span<VideoProcessorInputViewDesc> pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorInputView(ref pResource.GetPinnableReference(), ref pEnum.GetPinnableReference(), ref pDesc.GetPinnableReference(), ref ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TI0, TI1, TI2>(this ComPtr<ID3D11VideoDevice> thisVtbl, ComPtr<TI0> pResource, ComPtr<TI1> pEnum, VideoProcessorOutputViewDesc* pDesc, ref ComPtr<TI2> ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorOutputView((ID3D11Resource*) pResource.Handle, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, pDesc, (ID3D11VideoProcessorOutputView**) ppVPOView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TI0, TI1>(this ComPtr<ID3D11VideoDevice> thisVtbl, ComPtr<TI0> pResource, ComPtr<TI1> pEnum, VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorOutputView((ID3D11Resource*) pResource.Handle, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, pDesc, ref ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, Span<VideoProcessorOutputViewDesc> pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorOutputView(pResource, pEnum, ref pDesc.GetPinnableReference(), ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoProcessorOutputView<TI0, TI1, TI2>(this ComPtr<ID3D11VideoDevice> thisVtbl, ComPtr<TI0> pResource, ComPtr<TI1> pEnum, ref VideoProcessorOutputViewDesc pDesc, ref ComPtr<TI2> ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorOutputView((ID3D11Resource*) pResource.Handle, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, ref pDesc, (ID3D11VideoProcessorOutputView**) ppVPOView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, Span<VideoProcessorOutputViewDesc> pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorOutputView(pResource, pEnum, ref pDesc.GetPinnableReference(), ref ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TI0, TI1>(this ComPtr<ID3D11VideoDevice> thisVtbl, ComPtr<TI0> pResource, ComPtr<TI1> pEnum, ref VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorOutputView((ID3D11Resource*) pResource.Handle, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, ref pDesc, ref ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11Resource* pResource, Span<ID3D11VideoProcessorEnumerator> pEnum, VideoProcessorOutputViewDesc* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorOutputView(pResource, ref pEnum.GetPinnableReference(), pDesc, ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TI0, TI1>(this ComPtr<ID3D11VideoDevice> thisVtbl, ComPtr<TI0> pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorOutputViewDesc* pDesc, ref ComPtr<TI1> ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorOutputView((ID3D11Resource*) pResource.Handle, ref pEnum, pDesc, (ID3D11VideoProcessorOutputView**) ppVPOView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11Resource* pResource, Span<ID3D11VideoProcessorEnumerator> pEnum, VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorOutputView(pResource, ref pEnum.GetPinnableReference(), pDesc, ref ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, ComPtr<TI0> pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorOutputView((ID3D11Resource*) pResource.Handle, ref pEnum, pDesc, ref ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11Resource* pResource, Span<ID3D11VideoProcessorEnumerator> pEnum, Span<VideoProcessorOutputViewDesc> pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorOutputView(pResource, ref pEnum.GetPinnableReference(), ref pDesc.GetPinnableReference(), ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoProcessorOutputView<TI0, TI1>(this ComPtr<ID3D11VideoDevice> thisVtbl, ComPtr<TI0> pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorOutputViewDesc pDesc, ref ComPtr<TI1> ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorOutputView((ID3D11Resource*) pResource.Handle, ref pEnum, ref pDesc, (ID3D11VideoProcessorOutputView**) ppVPOView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, ID3D11Resource* pResource, Span<ID3D11VideoProcessorEnumerator> pEnum, Span<VideoProcessorOutputViewDesc> pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorOutputView(pResource, ref pEnum.GetPinnableReference(), ref pDesc.GetPinnableReference(), ref ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, ComPtr<TI0> pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorOutputView((ID3D11Resource*) pResource.Handle, ref pEnum, ref pDesc, ref ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<ID3D11Resource> pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorOutputViewDesc* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorOutputView(ref pResource.GetPinnableReference(), pEnum, pDesc, ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TI0, TI1>(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11Resource pResource, ComPtr<TI0> pEnum, VideoProcessorOutputViewDesc* pDesc, ref ComPtr<TI1> ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorOutputView(ref pResource, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, pDesc, (ID3D11VideoProcessorOutputView**) ppVPOView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<ID3D11Resource> pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorOutputView(ref pResource.GetPinnableReference(), pEnum, pDesc, ref ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11Resource pResource, ComPtr<TI0> pEnum, VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorOutputView(ref pResource, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, pDesc, ref ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<ID3D11Resource> pResource, ID3D11VideoProcessorEnumerator* pEnum, Span<VideoProcessorOutputViewDesc> pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorOutputView(ref pResource.GetPinnableReference(), pEnum, ref pDesc.GetPinnableReference(), ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoProcessorOutputView<TI0, TI1>(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11Resource pResource, ComPtr<TI0> pEnum, ref VideoProcessorOutputViewDesc pDesc, ref ComPtr<TI1> ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorOutputView(ref pResource, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, ref pDesc, (ID3D11VideoProcessorOutputView**) ppVPOView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<ID3D11Resource> pResource, ID3D11VideoProcessorEnumerator* pEnum, Span<VideoProcessorOutputViewDesc> pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorOutputView(ref pResource.GetPinnableReference(), pEnum, ref pDesc.GetPinnableReference(), ref ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11Resource pResource, ComPtr<TI0> pEnum, ref VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorOutputView(ref pResource, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, ref pDesc, ref ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<ID3D11Resource> pResource, Span<ID3D11VideoProcessorEnumerator> pEnum, VideoProcessorOutputViewDesc* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorOutputView(ref pResource.GetPinnableReference(), ref pEnum.GetPinnableReference(), pDesc, ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorOutputViewDesc* pDesc, ref ComPtr<TI0> ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorOutputView(ref pResource, ref pEnum, pDesc, (ID3D11VideoProcessorOutputView**) ppVPOView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<ID3D11Resource> pResource, Span<ID3D11VideoProcessorEnumerator> pEnum, VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorOutputView(ref pResource.GetPinnableReference(), ref pEnum.GetPinnableReference(), pDesc, ref ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<ID3D11Resource> pResource, Span<ID3D11VideoProcessorEnumerator> pEnum, Span<VideoProcessorOutputViewDesc> pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorOutputView(ref pResource.GetPinnableReference(), ref pEnum.GetPinnableReference(), ref pDesc.GetPinnableReference(), ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoProcessorOutputView<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorOutputViewDesc pDesc, ref ComPtr<TI0> ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorOutputView(ref pResource, ref pEnum, ref pDesc, (ID3D11VideoProcessorOutputView**) ppVPOView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<ID3D11Resource> pResource, Span<ID3D11VideoProcessorEnumerator> pEnum, Span<VideoProcessorOutputViewDesc> pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorOutputView(ref pResource.GetPinnableReference(), ref pEnum.GetPinnableReference(), ref pDesc.GetPinnableReference(), ref ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorEnumerator<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, VideoProcessorContentDesc* pDesc, ref ComPtr<TI0> ppEnum) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorEnumerator(pDesc, (ID3D11VideoProcessorEnumerator**) ppEnum.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorEnumerator(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<VideoProcessorContentDesc> pDesc, ID3D11VideoProcessorEnumerator** ppEnum)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorEnumerator(ref pDesc.GetPinnableReference(), ppEnum);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoProcessorEnumerator<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, ref VideoProcessorContentDesc pDesc, ref ComPtr<TI0> ppEnum) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorEnumerator(ref pDesc, (ID3D11VideoProcessorEnumerator**) ppEnum.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorEnumerator(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<VideoProcessorContentDesc> pDesc, ref ID3D11VideoProcessorEnumerator* ppEnum)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorEnumerator(ref pDesc.GetPinnableReference(), ref ppEnum);
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoDecoderProfile(this ComPtr<ID3D11VideoDevice> thisVtbl, uint Index, Span<Guid> pDecoderProfile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoDecoderProfile(Index, ref pDecoderProfile.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderFormat(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pDecoderProfile, Silk.NET.DXGI.Format Format, Span<int> pSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderFormat(pDecoderProfile, Format, ref pSupported.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderFormat(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<Guid> pDecoderProfile, Silk.NET.DXGI.Format Format, int* pSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderFormat(ref pDecoderProfile.GetPinnableReference(), Format, pSupported);
    }

    /// <summary>To be documented.</summary>
    public static int CheckVideoDecoderFormat(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<Guid> pDecoderProfile, Silk.NET.DXGI.Format Format, Span<int> pSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderFormat(ref pDecoderProfile.GetPinnableReference(), Format, ref pSupported.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderConfigCount(this ComPtr<ID3D11VideoDevice> thisVtbl, VideoDecoderDesc* pDesc, Span<uint> pCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoDecoderConfigCount(pDesc, ref pCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderConfigCount(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<VideoDecoderDesc> pDesc, uint* pCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoDecoderConfigCount(ref pDesc.GetPinnableReference(), pCount);
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoDecoderConfigCount(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<VideoDecoderDesc> pDesc, Span<uint> pCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoDecoderConfigCount(ref pDesc.GetPinnableReference(), ref pCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderConfig(this ComPtr<ID3D11VideoDevice> thisVtbl, VideoDecoderDesc* pDesc, uint Index, Span<VideoDecoderConfig> pConfig)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoDecoderConfig(pDesc, Index, ref pConfig.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderConfig(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<VideoDecoderDesc> pDesc, uint Index, VideoDecoderConfig* pConfig)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoDecoderConfig(ref pDesc.GetPinnableReference(), Index, pConfig);
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoDecoderConfig(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<VideoDecoderDesc> pDesc, uint Index, Span<VideoDecoderConfig> pConfig)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoDecoderConfig(ref pDesc.GetPinnableReference(), Index, ref pConfig.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pCryptoType, Guid* pDecoderProfile, Span<VideoContentProtectionCaps> pCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetContentProtectionCaps(pCryptoType, pDecoderProfile, ref pCaps.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pCryptoType, Span<Guid> pDecoderProfile, VideoContentProtectionCaps* pCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetContentProtectionCaps(pCryptoType, ref pDecoderProfile.GetPinnableReference(), pCaps);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pCryptoType, Span<Guid> pDecoderProfile, Span<VideoContentProtectionCaps> pCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetContentProtectionCaps(pCryptoType, ref pDecoderProfile.GetPinnableReference(), ref pCaps.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<Guid> pCryptoType, Guid* pDecoderProfile, VideoContentProtectionCaps* pCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetContentProtectionCaps(ref pCryptoType.GetPinnableReference(), pDecoderProfile, pCaps);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<Guid> pCryptoType, Guid* pDecoderProfile, Span<VideoContentProtectionCaps> pCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetContentProtectionCaps(ref pCryptoType.GetPinnableReference(), pDecoderProfile, ref pCaps.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<Guid> pCryptoType, Span<Guid> pDecoderProfile, VideoContentProtectionCaps* pCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetContentProtectionCaps(ref pCryptoType.GetPinnableReference(), ref pDecoderProfile.GetPinnableReference(), pCaps);
    }

    /// <summary>To be documented.</summary>
    public static int GetContentProtectionCaps(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<Guid> pCryptoType, Span<Guid> pDecoderProfile, Span<VideoContentProtectionCaps> pCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetContentProtectionCaps(ref pCryptoType.GetPinnableReference(), ref pDecoderProfile.GetPinnableReference(), ref pCaps.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoKeyExchange(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pCryptoType, Guid* pDecoderProfile, uint Index, Span<Guid> pKeyExchangeType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckCryptoKeyExchange(pCryptoType, pDecoderProfile, Index, ref pKeyExchangeType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoKeyExchange(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pCryptoType, Span<Guid> pDecoderProfile, uint Index, Guid* pKeyExchangeType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckCryptoKeyExchange(pCryptoType, ref pDecoderProfile.GetPinnableReference(), Index, pKeyExchangeType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoKeyExchange(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pCryptoType, Span<Guid> pDecoderProfile, uint Index, Span<Guid> pKeyExchangeType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckCryptoKeyExchange(pCryptoType, ref pDecoderProfile.GetPinnableReference(), Index, ref pKeyExchangeType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoKeyExchange(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<Guid> pCryptoType, Guid* pDecoderProfile, uint Index, Guid* pKeyExchangeType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckCryptoKeyExchange(ref pCryptoType.GetPinnableReference(), pDecoderProfile, Index, pKeyExchangeType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoKeyExchange(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<Guid> pCryptoType, Guid* pDecoderProfile, uint Index, Span<Guid> pKeyExchangeType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckCryptoKeyExchange(ref pCryptoType.GetPinnableReference(), pDecoderProfile, Index, ref pKeyExchangeType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoKeyExchange(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<Guid> pCryptoType, Span<Guid> pDecoderProfile, uint Index, Guid* pKeyExchangeType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckCryptoKeyExchange(ref pCryptoType.GetPinnableReference(), ref pDecoderProfile.GetPinnableReference(), Index, pKeyExchangeType);
    }

    /// <summary>To be documented.</summary>
    public static int CheckCryptoKeyExchange(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<Guid> pCryptoType, Span<Guid> pDecoderProfile, uint Index, Span<Guid> pKeyExchangeType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckCryptoKeyExchange(ref pCryptoType.GetPinnableReference(), ref pDecoderProfile.GetPinnableReference(), Index, ref pKeyExchangeType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* guid, uint DataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(guid, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<Guid> guid, uint DataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<Guid> guid, uint DataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* guid, [Flow(FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* guid, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(guid, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<Guid> guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(ref guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<ID3D11VideoDevice> thisVtbl, Span<Guid> guid, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCryptoSession<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pCryptoType, Guid* pDecoderProfile) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCryptoSession(pCryptoType, pDecoderProfile, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCryptoSession<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, Guid* pCryptoType, ref Guid pDecoderProfile) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCryptoSession(pCryptoType, ref pDecoderProfile, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCryptoSession<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, ref Guid pCryptoType, Guid* pDecoderProfile) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCryptoSession(ref pCryptoType, pDecoderProfile, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateCryptoSession<TI0>(this ComPtr<ID3D11VideoDevice> thisVtbl, ref Guid pCryptoType, ref Guid pDecoderProfile) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCryptoSession(ref pCryptoType, ref pDecoderProfile, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
