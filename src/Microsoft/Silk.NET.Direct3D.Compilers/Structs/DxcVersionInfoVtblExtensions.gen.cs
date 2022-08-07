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

namespace Silk.NET.Direct3D.Compilers;

public unsafe static class DxcVersionInfoVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDxcVersionInfo>
    {
        var @this = (IDxcVersionInfo*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDxcVersionInfo>
    {
        var @this = (IDxcVersionInfo*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDxcVersionInfo>
    {
        var @this = (IDxcVersionInfo*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDxcVersionInfo>
    {
        var @this = (IDxcVersionInfo*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcVersionInfo>
    {
        var @this = (IDxcVersionInfo*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcVersionInfo>
    {
        var @this = (IDxcVersionInfo*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVersion<TThis>(this TThis thisVtbl, uint* pMajor, uint* pMinor) where TThis : IComVtbl<IDxcVersionInfo>
    {
        var @this = (IDxcVersionInfo*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo*, uint*, uint*, int>)@this->LpVtbl[3])(@this, pMajor, pMinor);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVersion<TThis>(this TThis thisVtbl, uint* pMajor, ref uint pMinor) where TThis : IComVtbl<IDxcVersionInfo>
    {
        var @this = (IDxcVersionInfo*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pMinorPtr = &pMinor)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo*, uint*, uint*, int>)@this->LpVtbl[3])(@this, pMajor, pMinorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVersion<TThis>(this TThis thisVtbl, ref uint pMajor, uint* pMinor) where TThis : IComVtbl<IDxcVersionInfo>
    {
        var @this = (IDxcVersionInfo*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pMajorPtr = &pMajor)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo*, uint*, uint*, int>)@this->LpVtbl[3])(@this, pMajorPtr, pMinor);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVersion<TThis>(this TThis thisVtbl, ref uint pMajor, ref uint pMinor) where TThis : IComVtbl<IDxcVersionInfo>
    {
        var @this = (IDxcVersionInfo*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pMajorPtr = &pMajor)
        {
            fixed (uint* pMinorPtr = &pMinor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo*, uint*, uint*, int>)@this->LpVtbl[3])(@this, pMajorPtr, pMinorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFlags<TThis>(this TThis thisVtbl, uint* pFlags) where TThis : IComVtbl<IDxcVersionInfo>
    {
        var @this = (IDxcVersionInfo*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo*, uint*, int>)@this->LpVtbl[4])(@this, pFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFlags<TThis>(this TThis thisVtbl, ref uint pFlags) where TThis : IComVtbl<IDxcVersionInfo>
    {
        var @this = (IDxcVersionInfo*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pFlagsPtr = &pFlags)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo*, uint*, int>)@this->LpVtbl[4])(@this, pFlagsPtr);
        }
        return ret;
    }

}
