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

public unsafe static class Direct3DVertexShader9VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDirect3DVertexShader9>
    {
        var @this = (IDirect3DVertexShader9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexShader9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DVertexShader9>
    {
        var @this = (IDirect3DVertexShader9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexShader9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDirect3DVertexShader9>
    {
        var @this = (IDirect3DVertexShader9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexShader9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DVertexShader9>
    {
        var @this = (IDirect3DVertexShader9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexShader9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DVertexShader9>
    {
        var @this = (IDirect3DVertexShader9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexShader9*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DVertexShader9>
    {
        var @this = (IDirect3DVertexShader9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexShader9*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, IDirect3DDevice9** ppDevice) where TThis : IComVtbl<IDirect3DVertexShader9>
    {
        var @this = (IDirect3DVertexShader9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexShader9*, IDirect3DDevice9**, int>)@this->LpVtbl[3])(@this, ppDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, ref IDirect3DDevice9* ppDevice) where TThis : IComVtbl<IDirect3DVertexShader9>
    {
        var @this = (IDirect3DVertexShader9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DDevice9** ppDevicePtr = &ppDevice)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexShader9*, IDirect3DDevice9**, int>)@this->LpVtbl[3])(@this, ppDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFunction<TThis>(this TThis thisVtbl, void* arg0, uint* pSizeOfData) where TThis : IComVtbl<IDirect3DVertexShader9>
    {
        var @this = (IDirect3DVertexShader9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexShader9*, void*, uint*, int>)@this->LpVtbl[4])(@this, arg0, pSizeOfData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFunction<TThis>(this TThis thisVtbl, void* arg0, ref uint pSizeOfData) where TThis : IComVtbl<IDirect3DVertexShader9>
    {
        var @this = (IDirect3DVertexShader9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pSizeOfDataPtr = &pSizeOfData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexShader9*, void*, uint*, int>)@this->LpVtbl[4])(@this, arg0, pSizeOfDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFunction<T0, TThis>(this TThis thisVtbl, ref T0 arg0, uint* pSizeOfData) where T0 : unmanaged where TThis : IComVtbl<IDirect3DVertexShader9>
    {
        var @this = (IDirect3DVertexShader9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* arg0Ptr = &arg0)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexShader9*, void*, uint*, int>)@this->LpVtbl[4])(@this, arg0Ptr, pSizeOfData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFunction<T0, TThis>(this TThis thisVtbl, ref T0 arg0, ref uint pSizeOfData) where T0 : unmanaged where TThis : IComVtbl<IDirect3DVertexShader9>
    {
        var @this = (IDirect3DVertexShader9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* arg0Ptr = &arg0)
        {
            fixed (uint* pSizeOfDataPtr = &pSizeOfData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexShader9*, void*, uint*, int>)@this->LpVtbl[4])(@this, arg0Ptr, pSizeOfDataPtr);
            }
        }
        return ret;
    }

}
