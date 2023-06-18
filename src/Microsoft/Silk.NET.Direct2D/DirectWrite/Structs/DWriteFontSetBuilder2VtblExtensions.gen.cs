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

public unsafe static class DWriteFontSetBuilder2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteFontSetBuilder2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteFontSetBuilder2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFontFaceReference(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, IDWriteFontFaceReference* fontFaceReference)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, IDWriteFontFaceReference*, int>)@this->LpVtbl[4])(@this, fontFaceReference);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFontSet(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, IDWriteFontSet* fontSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, IDWriteFontSet*, int>)@this->LpVtbl[5])(@this, fontSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontSet(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, IDWriteFontSet** fontSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, IDWriteFontSet**, int>)@this->LpVtbl[6])(@this, fontSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFontFile(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, IDWriteFontFile*, int>)@this->LpVtbl[7])(@this, fontFile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, IDWriteFontFile* fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, IDWriteFontFile*, uint, FontSimulations, FontAxisValue*, uint, FontAxisRange*, uint, FontProperty*, uint, int>)@this->LpVtbl[8])(@this, fontFile, fontFaceIndex, fontSimulations, fontAxisValues, fontAxisValueCount, fontAxisRanges, fontAxisRangeCount, properties, propertyCount);
        return ret;
    }

}
