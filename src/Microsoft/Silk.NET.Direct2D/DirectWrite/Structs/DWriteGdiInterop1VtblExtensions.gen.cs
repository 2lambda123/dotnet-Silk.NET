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

public unsafe static class DWriteGdiInterop1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteGdiInterop1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteGdiInterop1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteGdiInterop1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFromLOGFONT(this ComPtr<IDWriteGdiInterop1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* logFont, IDWriteFont** font)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, void*, IDWriteFont**, int>)@this->LpVtbl[3])(@this, logFont, font);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConvertFontToLOGFONT(this ComPtr<IDWriteGdiInterop1> thisVtbl, IDWriteFont* font, void* logFont, int* isSystemFont)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, IDWriteFont*, void*, int*, int>)@this->LpVtbl[4])(@this, font, logFont, isSystemFont);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConvertFontFaceToLOGFONT(this ComPtr<IDWriteGdiInterop1> thisVtbl, IDWriteFontFace* font, void* logFont)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, IDWriteFontFace*, void*, int>)@this->LpVtbl[5])(@this, font, logFont);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFaceFromHdc(this ComPtr<IDWriteGdiInterop1> thisVtbl, nint hdc, IDWriteFontFace** fontFace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, nint, IDWriteFontFace**, int>)@this->LpVtbl[6])(@this, hdc, fontFace);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapRenderTarget(this ComPtr<IDWriteGdiInterop1> thisVtbl, nint hdc, uint width, uint height, IDWriteBitmapRenderTarget** renderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, nint, uint, uint, IDWriteBitmapRenderTarget**, int>)@this->LpVtbl[7])(@this, hdc, width, height, renderTarget);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontSignature(this ComPtr<IDWriteGdiInterop1> thisVtbl, IDWriteFont* font, void* fontSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, IDWriteFont*, void*, int>)@this->LpVtbl[10])(@this, font, fontSignature);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFontsByLOGFONT(this ComPtr<IDWriteGdiInterop1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* logFont, IDWriteFontSet* fontSet, IDWriteFontSet** filteredSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, void*, IDWriteFontSet*, IDWriteFontSet**, int>)@this->LpVtbl[11])(@this, logFont, fontSet, filteredSet);
        return ret;
    }

}
