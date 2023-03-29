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

namespace Silk.NET.Core.Win32Extras;

public unsafe static class SequentialStreamVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISequentialStream> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISequentialStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISequentialStream> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISequentialStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISequentialStream> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISequentialStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISequentialStream> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISequentialStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ISequentialStream> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISequentialStream*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ISequentialStream> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISequentialStream*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<ISequentialStream> thisVtbl, void* pv, uint cb, uint* pcbRead)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISequentialStream*, void*, uint, uint*, int>)@this->LpVtbl[3])(@this, pv, cb, pcbRead);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<ISequentialStream> thisVtbl, void* pv, uint cb, ref uint pcbRead)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcbReadPtr = &pcbRead)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISequentialStream*, void*, uint, uint*, int>)@this->LpVtbl[3])(@this, pv, cb, pcbReadPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Write(this ComPtr<ISequentialStream> thisVtbl, [Flow(FlowDirection.In)] void* pv, uint cb, uint* pcbWritten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISequentialStream*, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, pv, cb, pcbWritten);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Write(this ComPtr<ISequentialStream> thisVtbl, [Flow(FlowDirection.In)] void* pv, uint cb, ref uint pcbWritten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcbWrittenPtr = &pcbWritten)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISequentialStream*, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, pv, cb, pcbWrittenPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ISequentialStream> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISequentialStream> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISequentialStream> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int Read<T0>(this ComPtr<ISequentialStream> thisVtbl, Span<T0> pv, uint cb, Span<uint> pcbRead) where T0 : struct
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        fixed (void* pvSpp = pv)
            return @this->Read(pvSpp, cb, ref pcbRead.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Write<T0>(this ComPtr<ISequentialStream> thisVtbl, [Flow(FlowDirection.In)] Span<T0> pv, uint cb, Span<uint> pcbWritten) where T0 : struct
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        fixed (void* pvSpp = pv)
            return @this->Write(pvSpp, cb, ref pcbWritten.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ISequentialStream> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
