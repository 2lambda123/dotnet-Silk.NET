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

namespace Silk.NET.DirectWrite;

public unsafe static class DWriteRenderingParamsVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteRenderingParams> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteRenderingParams> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteRenderingParams> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static float GetGamma(this ComPtr<IDWriteRenderingParams> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        float ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams*, float>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static float GetEnhancedContrast(this ComPtr<IDWriteRenderingParams> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        float ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams*, float>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static float GetClearTypeLevel(this ComPtr<IDWriteRenderingParams> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        float ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams*, float>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static PixelGeometry GetPixelGeometry(this ComPtr<IDWriteRenderingParams> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        PixelGeometry ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams*, PixelGeometry>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static RenderingMode GetRenderingMode(this ComPtr<IDWriteRenderingParams> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        RenderingMode ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams*, RenderingMode>)@this->LpVtbl[7])(@this);
        return ret;
    }

}
