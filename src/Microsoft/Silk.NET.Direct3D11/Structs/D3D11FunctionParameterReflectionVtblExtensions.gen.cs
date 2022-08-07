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

public unsafe static class D3D11FunctionParameterReflectionVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc<TThis>(this TThis thisVtbl, ParameterDesc* pDesc) where TThis : IComVtbl<ID3D11FunctionParameterReflection>
    {
        var @this = (ID3D11FunctionParameterReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionParameterReflection*, ParameterDesc*, int>)@this->LpVtbl[0])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc<TThis>(this TThis thisVtbl, ref ParameterDesc pDesc) where TThis : IComVtbl<ID3D11FunctionParameterReflection>
    {
        var @this = (ID3D11FunctionParameterReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ParameterDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionParameterReflection*, ParameterDesc*, int>)@this->LpVtbl[0])(@this, pDescPtr);
        }
        return ret;
    }

}
