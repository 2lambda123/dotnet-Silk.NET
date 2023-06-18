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

public unsafe static class D3D12DeviceRemovedExtendedDataSettings1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DeviceRemovedExtendedDataSettings1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12DeviceRemovedExtendedDataSettings1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12DeviceRemovedExtendedDataSettings1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetAutoBreadcrumbsEnablement(this ComPtr<ID3D12DeviceRemovedExtendedDataSettings1> thisVtbl, DredEnablement Enablement)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings1*, DredEnablement, void>)@this->LpVtbl[3])(@this, Enablement);
    }

    /// <summary>To be documented.</summary>
    public static void SetPageFaultEnablement(this ComPtr<ID3D12DeviceRemovedExtendedDataSettings1> thisVtbl, DredEnablement Enablement)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings1*, DredEnablement, void>)@this->LpVtbl[4])(@this, Enablement);
    }

    /// <summary>To be documented.</summary>
    public static void SetWatsonDumpEnablement(this ComPtr<ID3D12DeviceRemovedExtendedDataSettings1> thisVtbl, DredEnablement Enablement)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings1*, DredEnablement, void>)@this->LpVtbl[5])(@this, Enablement);
    }

    /// <summary>To be documented.</summary>
    public static void SetBreadcrumbContextEnablement(this ComPtr<ID3D12DeviceRemovedExtendedDataSettings1> thisVtbl, DredEnablement Enablement)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings1*, DredEnablement, void>)@this->LpVtbl[6])(@this, Enablement);
    }

}
