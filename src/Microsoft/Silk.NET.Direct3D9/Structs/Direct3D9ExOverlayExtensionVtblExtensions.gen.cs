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

namespace Silk.NET.Direct3D9;

public unsafe static class Direct3D9ExOverlayExtensionVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDirect3D9ExOverlayExtension>
    {
        var @this = (IDirect3D9ExOverlayExtension*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9ExOverlayExtension*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3D9ExOverlayExtension>
    {
        var @this = (IDirect3D9ExOverlayExtension*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9ExOverlayExtension*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDirect3D9ExOverlayExtension>
    {
        var @this = (IDirect3D9ExOverlayExtension*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9ExOverlayExtension*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3D9ExOverlayExtension>
    {
        var @this = (IDirect3D9ExOverlayExtension*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9ExOverlayExtension*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3D9ExOverlayExtension>
    {
        var @this = (IDirect3D9ExOverlayExtension*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9ExOverlayExtension*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3D9ExOverlayExtension>
    {
        var @this = (IDirect3D9ExOverlayExtension*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9ExOverlayExtension*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckDeviceOverlayType<TThis>(this TThis thisVtbl, uint Adapter, Devtype DevType, uint OverlayWidth, uint OverlayHeight, Format OverlayFormat, Displaymodeex* pDisplayMode, Displayrotation DisplayRotation, Overlaycaps* pOverlayCaps) where TThis : IComVtbl<IDirect3D9ExOverlayExtension>
    {
        var @this = (IDirect3D9ExOverlayExtension*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9ExOverlayExtension*, uint, Devtype, uint, uint, Format, Displaymodeex*, Displayrotation, Overlaycaps*, int>)@this->LpVtbl[3])(@this, Adapter, DevType, OverlayWidth, OverlayHeight, OverlayFormat, pDisplayMode, DisplayRotation, pOverlayCaps);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckDeviceOverlayType<TThis>(this TThis thisVtbl, uint Adapter, Devtype DevType, uint OverlayWidth, uint OverlayHeight, Format OverlayFormat, Displaymodeex* pDisplayMode, Displayrotation DisplayRotation, ref Overlaycaps pOverlayCaps) where TThis : IComVtbl<IDirect3D9ExOverlayExtension>
    {
        var @this = (IDirect3D9ExOverlayExtension*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Overlaycaps* pOverlayCapsPtr = &pOverlayCaps)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9ExOverlayExtension*, uint, Devtype, uint, uint, Format, Displaymodeex*, Displayrotation, Overlaycaps*, int>)@this->LpVtbl[3])(@this, Adapter, DevType, OverlayWidth, OverlayHeight, OverlayFormat, pDisplayMode, DisplayRotation, pOverlayCapsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckDeviceOverlayType<TThis>(this TThis thisVtbl, uint Adapter, Devtype DevType, uint OverlayWidth, uint OverlayHeight, Format OverlayFormat, ref Displaymodeex pDisplayMode, Displayrotation DisplayRotation, Overlaycaps* pOverlayCaps) where TThis : IComVtbl<IDirect3D9ExOverlayExtension>
    {
        var @this = (IDirect3D9ExOverlayExtension*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Displaymodeex* pDisplayModePtr = &pDisplayMode)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9ExOverlayExtension*, uint, Devtype, uint, uint, Format, Displaymodeex*, Displayrotation, Overlaycaps*, int>)@this->LpVtbl[3])(@this, Adapter, DevType, OverlayWidth, OverlayHeight, OverlayFormat, pDisplayModePtr, DisplayRotation, pOverlayCaps);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckDeviceOverlayType<TThis>(this TThis thisVtbl, uint Adapter, Devtype DevType, uint OverlayWidth, uint OverlayHeight, Format OverlayFormat, ref Displaymodeex pDisplayMode, Displayrotation DisplayRotation, ref Overlaycaps pOverlayCaps) where TThis : IComVtbl<IDirect3D9ExOverlayExtension>
    {
        var @this = (IDirect3D9ExOverlayExtension*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Displaymodeex* pDisplayModePtr = &pDisplayMode)
        {
            fixed (Overlaycaps* pOverlayCapsPtr = &pOverlayCaps)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9ExOverlayExtension*, uint, Devtype, uint, uint, Format, Displaymodeex*, Displayrotation, Overlaycaps*, int>)@this->LpVtbl[3])(@this, Adapter, DevType, OverlayWidth, OverlayHeight, OverlayFormat, pDisplayModePtr, DisplayRotation, pOverlayCapsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDirect3D9ExOverlayExtension>
    {
        var @this = (IDirect3D9ExOverlayExtension*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDirect3D9ExOverlayExtension>
    {
        var @this = (IDirect3D9ExOverlayExtension*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3D9ExOverlayExtension>
    {
        var @this = (IDirect3D9ExOverlayExtension*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckDeviceOverlayType<TThis>(this TThis thisVtbl, uint Adapter, Devtype DevType, uint OverlayWidth, uint OverlayHeight, Format OverlayFormat, Displaymodeex* pDisplayMode, Displayrotation DisplayRotation, Span<Overlaycaps> pOverlayCaps) where TThis : IComVtbl<IDirect3D9ExOverlayExtension>
    {
        var @this = (IDirect3D9ExOverlayExtension*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CheckDeviceOverlayType(Adapter, DevType, OverlayWidth, OverlayHeight, OverlayFormat, pDisplayMode, DisplayRotation, ref pOverlayCaps.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckDeviceOverlayType<TThis>(this TThis thisVtbl, uint Adapter, Devtype DevType, uint OverlayWidth, uint OverlayHeight, Format OverlayFormat, Span<Displaymodeex> pDisplayMode, Displayrotation DisplayRotation, Overlaycaps* pOverlayCaps) where TThis : IComVtbl<IDirect3D9ExOverlayExtension>
    {
        var @this = (IDirect3D9ExOverlayExtension*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CheckDeviceOverlayType(Adapter, DevType, OverlayWidth, OverlayHeight, OverlayFormat, ref pDisplayMode.GetPinnableReference(), DisplayRotation, pOverlayCaps);
    }

    /// <summary>To be documented.</summary>
    public static int CheckDeviceOverlayType<TThis>(this TThis thisVtbl, uint Adapter, Devtype DevType, uint OverlayWidth, uint OverlayHeight, Format OverlayFormat, Span<Displaymodeex> pDisplayMode, Displayrotation DisplayRotation, Span<Overlaycaps> pOverlayCaps) where TThis : IComVtbl<IDirect3D9ExOverlayExtension>
    {
        var @this = (IDirect3D9ExOverlayExtension*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CheckDeviceOverlayType(Adapter, DevType, OverlayWidth, OverlayHeight, OverlayFormat, ref pDisplayMode.GetPinnableReference(), DisplayRotation, ref pOverlayCaps.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0, TThis>(this TThis thisVtbl) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDirect3D9ExOverlayExtension>
    {
        var @this = (IDirect3D9ExOverlayExtension*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
