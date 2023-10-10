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

namespace Silk.NET.Core.Native;

public unsafe static class InspectableVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IInspectable> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IInspectable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IInspectable> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IInspectable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IInspectable> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IInspectable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IInspectable> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IInspectable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IInspectable> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IInspectable*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IInspectable> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IInspectable*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIids(this ComPtr<IInspectable> thisVtbl, uint* iidCount, Guid** iids)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IInspectable*, uint*, Guid**, int>)@this->LpVtbl[3])(@this, iidCount, iids);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIids(this ComPtr<IInspectable> thisVtbl, uint* iidCount, ref Guid* iids)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid** iidsPtr = &iids)
        {
            ret = ((delegate* unmanaged[Stdcall]<IInspectable*, uint*, Guid**, int>)@this->LpVtbl[3])(@this, iidCount, iidsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIids(this ComPtr<IInspectable> thisVtbl, ref uint iidCount, Guid** iids)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* iidCountPtr = &iidCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IInspectable*, uint*, Guid**, int>)@this->LpVtbl[3])(@this, iidCountPtr, iids);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIids(this ComPtr<IInspectable> thisVtbl, ref uint iidCount, ref Guid* iids)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* iidCountPtr = &iidCount)
        {
            fixed (Guid** iidsPtr = &iids)
            {
                ret = ((delegate* unmanaged[Stdcall]<IInspectable*, uint*, Guid**, int>)@this->LpVtbl[3])(@this, iidCountPtr, iidsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRuntimeClassName(this ComPtr<IInspectable> thisVtbl, WinString* className)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IInspectable*, WinString*, int>)@this->LpVtbl[4])(@this, className);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetRuntimeClassName(this ComPtr<IInspectable> thisVtbl, ref WinString className)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (WinString* classNamePtr = &className)
        {
            ret = ((delegate* unmanaged[Stdcall]<IInspectable*, WinString*, int>)@this->LpVtbl[4])(@this, classNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTrustLevel(this ComPtr<IInspectable> thisVtbl, TrustLevel* trustLevel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IInspectable*, TrustLevel*, int>)@this->LpVtbl[5])(@this, trustLevel);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetTrustLevel(this ComPtr<IInspectable> thisVtbl, ref TrustLevel trustLevel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TrustLevel* trustLevelPtr = &trustLevel)
        {
            ret = ((delegate* unmanaged[Stdcall]<IInspectable*, TrustLevel*, int>)@this->LpVtbl[5])(@this, trustLevelPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IInspectable> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IInspectable> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IInspectable> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIids(this ComPtr<IInspectable> thisVtbl, Span<uint> iidCount, Guid** iids)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetIids(ref iidCount.GetPinnableReference(), iids);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIids(this ComPtr<IInspectable> thisVtbl, Span<uint> iidCount, ref Guid* iids)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetIids(ref iidCount.GetPinnableReference(), ref iids);
    }

    /// <summary>To be documented.</summary>
    public static int GetRuntimeClassName(this ComPtr<IInspectable> thisVtbl, Span<WinString> className)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRuntimeClassName(ref className.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetTrustLevel(this ComPtr<IInspectable> thisVtbl, Span<TrustLevel> trustLevel)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTrustLevel(ref trustLevel.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IInspectable> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
