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

namespace Silk.NET.Direct3D11.Extensions.D3D11On12;

public unsafe static class D3D11On12Device2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11On12Device2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D11On12Device2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D11On12Device2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource(this ComPtr<ID3D11On12Device2> thisVtbl, Silk.NET.Core.Native.IUnknown* pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Guid* riid, void** ppResource11)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device2*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12, pFlags11, InState, OutState, riid, ppResource11);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ReleaseWrappedResources(this ComPtr<ID3D11On12Device2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Resource** ppResources, uint NumResources)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11On12Device2*, ID3D11Resource**, uint, void>)@this->LpVtbl[4])(@this, ppResources, NumResources);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AcquireWrappedResources(this ComPtr<ID3D11On12Device2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Resource** ppResources, uint NumResources)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11On12Device2*, ID3D11Resource**, uint, void>)@this->LpVtbl[5])(@this, ppResources, NumResources);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetD3D12Device(this ComPtr<ID3D11On12Device2> thisVtbl, Guid* riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device2*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppvDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UnwrapUnderlyingResource(this ComPtr<ID3D11On12Device2> thisVtbl, ID3D11Resource* pResource11, Silk.NET.Direct3D12.ID3D12CommandQueue* pCommandQueue, Guid* riid, void** ppvResource12)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device2*, ID3D11Resource*, Silk.NET.Direct3D12.ID3D12CommandQueue*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pResource11, pCommandQueue, riid, ppvResource12);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReturnUnderlyingResource(this ComPtr<ID3D11On12Device2> thisVtbl, ID3D11Resource* pResource11, uint NumSync, ulong* pSignalValues, Silk.NET.Direct3D12.ID3D12Fence** ppFences)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device2*, ID3D11Resource*, uint, ulong*, Silk.NET.Direct3D12.ID3D12Fence**, int>)@this->LpVtbl[8])(@this, pResource11, NumSync, pSignalValues, ppFences);
        return ret;
    }

}
