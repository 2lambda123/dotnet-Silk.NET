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

public unsafe static class DStorageQueue2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDStorageQueue2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDStorageQueue2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDStorageQueue2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EnqueueRequest(this ComPtr<IDStorageQueue2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Request* request)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, Request*, void>)@this->LpVtbl[3])(@this, request);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EnqueueStatus(this ComPtr<IDStorageQueue2> thisVtbl, IDStorageStatusArray* statusArray, uint index)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, IDStorageStatusArray*, uint, void>)@this->LpVtbl[4])(@this, statusArray, index);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EnqueueSignal(this ComPtr<IDStorageQueue2> thisVtbl, Silk.NET.Direct3D12.ID3D12Fence* fence, ulong value)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, Silk.NET.Direct3D12.ID3D12Fence*, ulong, void>)@this->LpVtbl[5])(@this, fence, value);
    }

    /// <summary>To be documented.</summary>
    public static void Submit(this ComPtr<IDStorageQueue2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, void>)@this->LpVtbl[6])(@this);
    }

    /// <summary>To be documented.</summary>
    public static void CancelRequestsWithTag(this ComPtr<IDStorageQueue2> thisVtbl, ulong mask, ulong value)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, ulong, ulong, void>)@this->LpVtbl[7])(@this, mask, value);
    }

    /// <summary>To be documented.</summary>
    public static void Close(this ComPtr<IDStorageQueue2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, void>)@this->LpVtbl[8])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* GetErrorEvent(this ComPtr<IDStorageQueue2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, void*>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RetrieveErrorRecord(this ComPtr<IDStorageQueue2> thisVtbl, ErrorRecord* record)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, ErrorRecord*, void>)@this->LpVtbl[10])(@this, record);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void Query(this ComPtr<IDStorageQueue2> thisVtbl, QueueInfo* info)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, QueueInfo*, void>)@this->LpVtbl[11])(@this, info);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EnqueueSetEvent(this ComPtr<IDStorageQueue2> thisVtbl, void* handle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, void*, void>)@this->LpVtbl[12])(@this, handle);
    }

    /// <summary>To be documented.</summary>
    public static CompressionSupport GetCompressionSupport(this ComPtr<IDStorageQueue2> thisVtbl, CompressionFormat format)
    {
        var @this = thisVtbl.Handle;
        CompressionSupport ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue2*, CompressionFormat, CompressionSupport>)@this->LpVtbl[13])(@this, format);
        return ret;
    }

}
