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

namespace Silk.NET.DirectStorage;

public unsafe static class DStorageCustomDecompressionQueueVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDStorageCustomDecompressionQueue> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDStorageCustomDecompressionQueue> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDStorageCustomDecompressionQueue> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDStorageCustomDecompressionQueue> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDStorageCustomDecompressionQueue> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDStorageCustomDecompressionQueue> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe nint* GetEvent(this ComPtr<IDStorageCustomDecompressionQueue> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        nint* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue*, nint*>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRequests(this ComPtr<IDStorageCustomDecompressionQueue> thisVtbl, uint maxRequests, CustomDecompressionRequest* requests, uint* numRequests)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue*, uint, CustomDecompressionRequest*, uint*, int>)@this->LpVtbl[4])(@this, maxRequests, requests, numRequests);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRequests(this ComPtr<IDStorageCustomDecompressionQueue> thisVtbl, uint maxRequests, CustomDecompressionRequest* requests, ref uint numRequests)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* numRequestsPtr = &numRequests)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue*, uint, CustomDecompressionRequest*, uint*, int>)@this->LpVtbl[4])(@this, maxRequests, requests, numRequestsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRequests(this ComPtr<IDStorageCustomDecompressionQueue> thisVtbl, uint maxRequests, ref CustomDecompressionRequest requests, uint* numRequests)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CustomDecompressionRequest* requestsPtr = &requests)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue*, uint, CustomDecompressionRequest*, uint*, int>)@this->LpVtbl[4])(@this, maxRequests, requestsPtr, numRequests);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetRequests(this ComPtr<IDStorageCustomDecompressionQueue> thisVtbl, uint maxRequests, ref CustomDecompressionRequest requests, ref uint numRequests)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CustomDecompressionRequest* requestsPtr = &requests)
        {
            fixed (uint* numRequestsPtr = &numRequests)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue*, uint, CustomDecompressionRequest*, uint*, int>)@this->LpVtbl[4])(@this, maxRequests, requestsPtr, numRequestsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetRequestResults(this ComPtr<IDStorageCustomDecompressionQueue> thisVtbl, uint numResults, CustomDecompressionResult* results)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue*, uint, CustomDecompressionResult*, int>)@this->LpVtbl[5])(@this, numResults, results);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetRequestResults(this ComPtr<IDStorageCustomDecompressionQueue> thisVtbl, uint numResults, ref CustomDecompressionResult results)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CustomDecompressionResult* resultsPtr = &results)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue*, uint, CustomDecompressionResult*, int>)@this->LpVtbl[5])(@this, numResults, resultsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDStorageCustomDecompressionQueue> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDStorageCustomDecompressionQueue> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDStorageCustomDecompressionQueue> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRequests(this ComPtr<IDStorageCustomDecompressionQueue> thisVtbl, uint maxRequests, CustomDecompressionRequest* requests, Span<uint> numRequests)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRequests(maxRequests, requests, ref numRequests.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRequests(this ComPtr<IDStorageCustomDecompressionQueue> thisVtbl, uint maxRequests, Span<CustomDecompressionRequest> requests, uint* numRequests)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRequests(maxRequests, ref requests.GetPinnableReference(), numRequests);
    }

    /// <summary>To be documented.</summary>
    public static int GetRequests(this ComPtr<IDStorageCustomDecompressionQueue> thisVtbl, uint maxRequests, Span<CustomDecompressionRequest> requests, Span<uint> numRequests)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRequests(maxRequests, ref requests.GetPinnableReference(), ref numRequests.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetRequestResults(this ComPtr<IDStorageCustomDecompressionQueue> thisVtbl, uint numResults, Span<CustomDecompressionResult> results)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetRequestResults(numResults, ref results.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDStorageCustomDecompressionQueue> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
