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

public unsafe static class D3D11VideoProcessorEnumeratorVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDevice<TThis>(this TThis thisVtbl, ID3D11Device** ppDevice) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, ID3D11Device**, void>)@this->LpVtbl[3])(@this, ppDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDevice<TThis>(this TThis thisVtbl, ref ID3D11Device* ppDevice) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Device** ppDevicePtr = &ppDevice)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, ID3D11Device**, void>)@this->LpVtbl[3])(@this, ppDevicePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, ref uint pDataSize, void* pData) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, ref uint pDataSize, void* pData) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guid, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guidPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guidPtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guid, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guidPtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guidPtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorContentDesc<TThis>(this TThis thisVtbl, VideoProcessorContentDesc* pContentDesc) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, VideoProcessorContentDesc*, int>)@this->LpVtbl[7])(@this, pContentDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoProcessorContentDesc<TThis>(this TThis thisVtbl, ref VideoProcessorContentDesc pContentDesc) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessorContentDesc* pContentDescPtr = &pContentDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, VideoProcessorContentDesc*, int>)@this->LpVtbl[7])(@this, pContentDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoProcessorFormat<TThis>(this TThis thisVtbl, Silk.NET.DXGI.Format Format, uint* pFlags) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, Silk.NET.DXGI.Format, uint*, int>)@this->LpVtbl[8])(@this, Format, pFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckVideoProcessorFormat<TThis>(this TThis thisVtbl, Silk.NET.DXGI.Format Format, ref uint pFlags) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pFlagsPtr = &pFlags)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, Silk.NET.DXGI.Format, uint*, int>)@this->LpVtbl[8])(@this, Format, pFlagsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorCaps<TThis>(this TThis thisVtbl, VideoProcessorCaps* pCaps) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, VideoProcessorCaps*, int>)@this->LpVtbl[9])(@this, pCaps);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoProcessorCaps<TThis>(this TThis thisVtbl, ref VideoProcessorCaps pCaps) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessorCaps* pCapsPtr = &pCaps)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, VideoProcessorCaps*, int>)@this->LpVtbl[9])(@this, pCapsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorRateConversionCaps<TThis>(this TThis thisVtbl, uint TypeIndex, VideoProcessorRateConversionCaps* pCaps) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, uint, VideoProcessorRateConversionCaps*, int>)@this->LpVtbl[10])(@this, TypeIndex, pCaps);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoProcessorRateConversionCaps<TThis>(this TThis thisVtbl, uint TypeIndex, ref VideoProcessorRateConversionCaps pCaps) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessorRateConversionCaps* pCapsPtr = &pCaps)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, uint, VideoProcessorRateConversionCaps*, int>)@this->LpVtbl[10])(@this, TypeIndex, pCapsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorCustomRate<TThis>(this TThis thisVtbl, uint TypeIndex, uint CustomRateIndex, VideoProcessorCustomRate* pRate) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, uint, uint, VideoProcessorCustomRate*, int>)@this->LpVtbl[11])(@this, TypeIndex, CustomRateIndex, pRate);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoProcessorCustomRate<TThis>(this TThis thisVtbl, uint TypeIndex, uint CustomRateIndex, ref VideoProcessorCustomRate pRate) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessorCustomRate* pRatePtr = &pRate)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, uint, uint, VideoProcessorCustomRate*, int>)@this->LpVtbl[11])(@this, TypeIndex, CustomRateIndex, pRatePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorFilterRange<TThis>(this TThis thisVtbl, VideoProcessorFilter Filter, VideoProcessorFilterRange* pRange) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, VideoProcessorFilter, VideoProcessorFilterRange*, int>)@this->LpVtbl[12])(@this, Filter, pRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoProcessorFilterRange<TThis>(this TThis thisVtbl, VideoProcessorFilter Filter, ref VideoProcessorFilterRange pRange) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessorFilterRange* pRangePtr = &pRange)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator*, VideoProcessorFilter, VideoProcessorFilterRange*, int>)@this->LpVtbl[12])(@this, Filter, pRangePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void GetDevice<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppDevice) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->GetDevice((ID3D11Device**) ppDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(guid, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, Span<uint> pDataSize, void* pData) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> guid, Span<uint> pDataSize, void* pData) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(guid, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> guid, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(guid, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Span<Guid> guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Span<Guid> guid, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoProcessorContentDesc<TThis>(this TThis thisVtbl, Span<VideoProcessorContentDesc> pContentDesc) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetVideoProcessorContentDesc(ref pContentDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CheckVideoProcessorFormat<TThis>(this TThis thisVtbl, Silk.NET.DXGI.Format Format, Span<uint> pFlags) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CheckVideoProcessorFormat(Format, ref pFlags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoProcessorCaps<TThis>(this TThis thisVtbl, Span<VideoProcessorCaps> pCaps) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetVideoProcessorCaps(ref pCaps.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoProcessorRateConversionCaps<TThis>(this TThis thisVtbl, uint TypeIndex, Span<VideoProcessorRateConversionCaps> pCaps) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetVideoProcessorRateConversionCaps(TypeIndex, ref pCaps.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoProcessorCustomRate<TThis>(this TThis thisVtbl, uint TypeIndex, uint CustomRateIndex, Span<VideoProcessorCustomRate> pRate) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetVideoProcessorCustomRate(TypeIndex, CustomRateIndex, ref pRate.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoProcessorFilterRange<TThis>(this TThis thisVtbl, VideoProcessorFilter Filter, Span<VideoProcessorFilterRange> pRange) where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetVideoProcessorFilterRange(Filter, ref pRange.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0, TThis>(this TThis thisVtbl) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D11VideoProcessorEnumerator>
    {
        var @this = (ID3D11VideoProcessorEnumerator*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
