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

public unsafe static class D3D12ShaderReflectionVariableVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc(this ComPtr<ID3D12ShaderReflectionVariable> thisVtbl, ShaderVariableDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionVariable*, ShaderVariableDesc*, int>)@this->LpVtbl[0])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12ShaderReflectionType* GetType(this ComPtr<ID3D12ShaderReflectionVariable> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ID3D12ShaderReflectionType* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionVariable*, ID3D12ShaderReflectionType*>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12ShaderReflectionConstantBuffer* GetBuffer(this ComPtr<ID3D12ShaderReflectionVariable> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ID3D12ShaderReflectionConstantBuffer* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionVariable*, ID3D12ShaderReflectionConstantBuffer*>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetInterfaceSlot(this ComPtr<ID3D12ShaderReflectionVariable> thisVtbl, uint uArrayIndex)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionVariable*, uint, uint>)@this->LpVtbl[3])(@this, uArrayIndex);
        return ret;
    }

}
