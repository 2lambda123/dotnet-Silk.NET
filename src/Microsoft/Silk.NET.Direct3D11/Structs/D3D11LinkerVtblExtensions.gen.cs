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

public unsafe static class D3D11LinkerVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, byte* pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, byte* pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetName, uFlags, ppShaderBlob, ppErrorBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, byte* pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBuffer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, byte* pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, byte* pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pTargetNamePtr = &pTargetName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, byte* pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pTargetNamePtr = &pTargetName)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, byte* pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pTargetNamePtr = &pTargetName)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, byte* pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pTargetNamePtr = &pTargetName)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, byte* pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
        SilkMarshal.Free((nint)pTargetNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, byte* pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
        }
        SilkMarshal.Free((nint)pTargetNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, byte* pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
        fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
        }
        SilkMarshal.Free((nint)pTargetNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, byte* pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
        fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
            }
        }
        SilkMarshal.Free((nint)pTargetNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, ref byte pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pEntryNamePtr = &pEntryName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, ref byte pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pEntryNamePtr = &pEntryName)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBufferPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, ref byte pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pEntryNamePtr = &pEntryName)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBuffer);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, ref byte pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pEntryNamePtr = &pEntryName)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, ref byte pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pEntryNamePtr = &pEntryName)
        {
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, ref byte pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pEntryNamePtr = &pEntryName)
        {
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, ref byte pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pEntryNamePtr = &pEntryName)
        {
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, ref byte pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pEntryNamePtr = &pEntryName)
        {
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, ref byte pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pEntryNamePtr = &pEntryName)
        {
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
        SilkMarshal.Free((nint)pTargetNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, ref byte pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pEntryNamePtr = &pEntryName)
        {
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
            }
        SilkMarshal.Free((nint)pTargetNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, ref byte pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pEntryNamePtr = &pEntryName)
        {
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
            }
        SilkMarshal.Free((nint)pTargetNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, ref byte pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pEntryNamePtr = &pEntryName)
        {
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                }
            }
        SilkMarshal.Free((nint)pTargetNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBufferPtr);
        }
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
        fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBuffer);
        }
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
        fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
            }
        }
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
        fixed (byte* pTargetNamePtr = &pTargetName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
        }
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
        fixed (byte* pTargetNamePtr = &pTargetName)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
            }
        }
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
        fixed (byte* pTargetNamePtr = &pTargetName)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
            }
        }
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
        fixed (byte* pTargetNamePtr = &pTargetName)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
        SilkMarshal.Free((nint)pTargetNamePtr);
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
        }
        SilkMarshal.Free((nint)pTargetNamePtr);
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
        fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
        }
        SilkMarshal.Free((nint)pTargetNamePtr);
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pEntry, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
        fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
            }
        }
        SilkMarshal.Free((nint)pTargetNamePtr);
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, byte* pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, byte* pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetName, uFlags, ppShaderBlob, ppErrorBufferPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, byte* pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBuffer);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, byte* pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, byte* pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, byte* pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, byte* pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, byte* pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, byte* pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
        SilkMarshal.Free((nint)pTargetNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, byte* pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
            }
        SilkMarshal.Free((nint)pTargetNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, byte* pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
            }
        SilkMarshal.Free((nint)pTargetNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, byte* pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                }
            }
        SilkMarshal.Free((nint)pTargetNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, ref byte pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, ref byte pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBufferPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, ref byte pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, ref byte pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, ref byte pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, ref byte pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, ref byte pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, ref byte pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, ref byte pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
        SilkMarshal.Free((nint)pTargetNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, ref byte pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                }
        SilkMarshal.Free((nint)pTargetNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, ref byte pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                }
        SilkMarshal.Free((nint)pTargetNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, ref byte pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                    }
                }
        SilkMarshal.Free((nint)pTargetNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
        SilkMarshal.Free((nint)pEntryNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBufferPtr);
            }
        SilkMarshal.Free((nint)pEntryNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBuffer);
            }
        SilkMarshal.Free((nint)pEntryNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                }
            }
        SilkMarshal.Free((nint)pEntryNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
            }
        SilkMarshal.Free((nint)pEntryNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                }
            }
        SilkMarshal.Free((nint)pEntryNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                }
            }
        SilkMarshal.Free((nint)pEntryNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                    }
                }
            }
        SilkMarshal.Free((nint)pEntryNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
        SilkMarshal.Free((nint)pTargetNamePtr);
        SilkMarshal.Free((nint)pEntryNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
            }
        SilkMarshal.Free((nint)pTargetNamePtr);
        SilkMarshal.Free((nint)pEntryNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
            }
        SilkMarshal.Free((nint)pTargetNamePtr);
        SilkMarshal.Free((nint)pEntryNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pEntry, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
        {
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
        var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                }
            }
        SilkMarshal.Free((nint)pTargetNamePtr);
        SilkMarshal.Free((nint)pEntryNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UseLibrary<TThis>(this TThis thisVtbl, ID3D11ModuleInstance* pLibraryMI) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, int>)@this->LpVtbl[4])(@this, pLibraryMI);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int UseLibrary<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance pLibraryMI) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance* pLibraryMIPtr = &pLibraryMI)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, int>)@this->LpVtbl[4])(@this, pLibraryMIPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddClipPlaneFromCBuffer<TThis>(this TThis thisVtbl, uint uCBufferSlot, uint uCBufferEntry) where TThis : IComVtbl<ID3D11Linker>
    {
        var @this = (ID3D11Linker*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, uint, uint, int>)@this->LpVtbl[5])(@this, uCBufferSlot, uCBufferEntry);
        return ret;
    }

}
