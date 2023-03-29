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

public unsafe static class D3DIncludeVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] byte* pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] void** ppData, uint* pBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileName, pParentData, ppData, pBytes);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] byte* pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] void** ppData, ref uint pBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pBytesPtr = &pBytes)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileName, pParentData, ppData, pBytesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] byte* pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] in void* ppData, uint* pBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppDataPtr = &ppData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileName, pParentData, ppDataPtr, pBytes);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] byte* pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] in void* ppData, ref uint pBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppDataPtr = &ppData)
        {
            fixed (uint* pBytesPtr = &pBytes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileName, pParentData, ppDataPtr, pBytesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] in byte pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] void** ppData, uint* pBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pFileNamePtr = &pFileName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppData, pBytes);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] in byte pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] void** ppData, ref uint pBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pFileNamePtr = &pFileName)
        {
            fixed (uint* pBytesPtr = &pBytes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppData, pBytesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] in byte pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] in void* ppData, uint* pBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pFileNamePtr = &pFileName)
        {
            fixed (void** ppDataPtr = &ppData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppDataPtr, pBytes);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] in byte pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] in void* ppData, ref uint pBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pFileNamePtr = &pFileName)
        {
            fixed (void** ppDataPtr = &ppData)
            {
                fixed (uint* pBytesPtr = &pBytes)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppDataPtr, pBytesPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] void** ppData, uint* pBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppData, pBytes);
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] void** ppData, ref uint pBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
        fixed (uint* pBytesPtr = &pBytes)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppData, pBytesPtr);
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] in void* ppData, uint* pBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
        fixed (void** ppDataPtr = &ppData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppDataPtr, pBytes);
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] in void* ppData, ref uint pBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
        fixed (void** ppDataPtr = &ppData)
        {
            fixed (uint* pBytesPtr = &pBytes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppDataPtr, pBytesPtr);
            }
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Close(this ComPtr<ID3DInclude> thisVtbl, [Flow(FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, void*, int>)@this->LpVtbl[1])(@this, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] byte* pFileName, [Flow(FlowDirection.In)] Span<T0> pParentData, [Flow(FlowDirection.In)] void** ppData, Span<uint> pBytes) where T0 : struct
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        fixed (void* pParentDataSpp = pParentData)
            return @this->Open(IncludeType, pFileName, pParentDataSpp, ppData, ref pBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] byte* pFileName, [Flow(FlowDirection.In)] Span<T0> pParentData, [Flow(FlowDirection.In)] in void* ppData, uint* pBytes) where T0 : struct
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        fixed (void* pParentDataSpp = pParentData)
            return @this->Open(IncludeType, pFileName, pParentDataSpp, in ppData, pBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] byte* pFileName, [Flow(FlowDirection.In)] Span<T0> pParentData, [Flow(FlowDirection.In)] in void* ppData, Span<uint> pBytes) where T0 : struct
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        fixed (void* pParentDataSpp = pParentData)
            return @this->Open(IncludeType, pFileName, pParentDataSpp, in ppData, ref pBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pFileName, [Flow(FlowDirection.In)] Span<T0> pParentData, [Flow(FlowDirection.In)] void** ppData, uint* pBytes) where T0 : struct
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        fixed (void* pParentDataSpp = pParentData)
            return @this->Open(IncludeType, in pFileName.GetPinnableReference(), pParentDataSpp, ppData, pBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pFileName, [Flow(FlowDirection.In)] Span<T0> pParentData, [Flow(FlowDirection.In)] void** ppData, Span<uint> pBytes) where T0 : struct
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        fixed (void* pParentDataSpp = pParentData)
            return @this->Open(IncludeType, in pFileName.GetPinnableReference(), pParentDataSpp, ppData, ref pBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pFileName, [Flow(FlowDirection.In)] Span<T0> pParentData, [Flow(FlowDirection.In)] in void* ppData, uint* pBytes) where T0 : struct
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        fixed (void* pParentDataSpp = pParentData)
            return @this->Open(IncludeType, in pFileName.GetPinnableReference(), pParentDataSpp, in ppData, pBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pFileName, [Flow(FlowDirection.In)] Span<T0> pParentData, [Flow(FlowDirection.In)] in void* ppData, Span<uint> pBytes) where T0 : struct
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        fixed (void* pParentDataSpp = pParentData)
            return @this->Open(IncludeType, in pFileName.GetPinnableReference(), pParentDataSpp, in ppData, ref pBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFileName, [Flow(FlowDirection.In)] Span<T0> pParentData, [Flow(FlowDirection.In)] void** ppData, uint* pBytes) where T0 : struct
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        fixed (void* pParentDataSpp = pParentData)
            return @this->Open(IncludeType, pFileName, pParentDataSpp, ppData, pBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFileName, [Flow(FlowDirection.In)] Span<T0> pParentData, [Flow(FlowDirection.In)] void** ppData, Span<uint> pBytes) where T0 : struct
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        fixed (void* pParentDataSpp = pParentData)
            return @this->Open(IncludeType, pFileName, pParentDataSpp, ppData, ref pBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFileName, [Flow(FlowDirection.In)] Span<T0> pParentData, [Flow(FlowDirection.In)] in void* ppData, uint* pBytes) where T0 : struct
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        fixed (void* pParentDataSpp = pParentData)
            return @this->Open(IncludeType, pFileName, pParentDataSpp, in ppData, pBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFileName, [Flow(FlowDirection.In)] Span<T0> pParentData, [Flow(FlowDirection.In)] in void* ppData, Span<uint> pBytes) where T0 : struct
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        fixed (void* pParentDataSpp = pParentData)
            return @this->Open(IncludeType, pFileName, pParentDataSpp, in ppData, ref pBytes.GetPinnableReference());
    }

}
