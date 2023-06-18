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

namespace Silk.NET.Direct3D12;

public unsafe static class D3D12ResourceVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12Resource> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12Resource> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12Resource> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12Resource> thisVtbl, Guid* guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D12Resource> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12Resource> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetName(this ComPtr<ID3D12Resource> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, char*, int>)@this->LpVtbl[6])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12Resource> thisVtbl, Guid* riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Map(this ComPtr<ID3D12Resource> thisVtbl, uint Subresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Range* pReadRange, void** ppData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, uint, Range*, void**, int>)@this->LpVtbl[8])(@this, Subresource, pReadRange, ppData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void Unmap(this ComPtr<ID3D12Resource> thisVtbl, uint Subresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Range* pWrittenRange)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Resource*, uint, Range*, void>)@this->LpVtbl[9])(@this, Subresource, pWrittenRange);
    }

    /// <summary>To be documented.</summary>
    public static ResourceDesc GetDesc(this ComPtr<ID3D12Resource> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ResourceDesc silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        ResourceDesc* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, ResourceDesc*, ResourceDesc*>)@this->LpVtbl[10])(@this, pSilkDotNetReturnFixupResult);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetGPUVirtualAddress(this ComPtr<ID3D12Resource> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, ulong>)@this->LpVtbl[11])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteToSubresource(this ComPtr<ID3D12Resource> thisVtbl, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, uint, Box*, void*, uint, uint, int>)@this->LpVtbl[12])(@this, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadFromSubresource(this ComPtr<ID3D12Resource> thisVtbl, void* pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, void*, uint, uint, uint, Box*, int>)@this->LpVtbl[13])(@this, pDstData, DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBox);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetHeapProperties(this ComPtr<ID3D12Resource> thisVtbl, HeapProperties* pHeapProperties, HeapFlags* pHeapFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, HeapProperties*, HeapFlags*, int>)@this->LpVtbl[14])(@this, pHeapProperties, pHeapFlags);
        return ret;
    }

}
