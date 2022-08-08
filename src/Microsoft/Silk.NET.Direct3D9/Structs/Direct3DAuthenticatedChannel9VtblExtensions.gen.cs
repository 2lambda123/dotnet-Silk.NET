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

public unsafe static class Direct3DAuthenticatedChannel9VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDirect3DAuthenticatedChannel9>
    {
        var @this = (IDirect3DAuthenticatedChannel9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DAuthenticatedChannel9>
    {
        var @this = (IDirect3DAuthenticatedChannel9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDirect3DAuthenticatedChannel9>
    {
        var @this = (IDirect3DAuthenticatedChannel9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DAuthenticatedChannel9>
    {
        var @this = (IDirect3DAuthenticatedChannel9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DAuthenticatedChannel9>
    {
        var @this = (IDirect3DAuthenticatedChannel9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DAuthenticatedChannel9>
    {
        var @this = (IDirect3DAuthenticatedChannel9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCertificateSize<TThis>(this TThis thisVtbl, uint* pCertificateSize) where TThis : IComVtbl<IDirect3DAuthenticatedChannel9>
    {
        var @this = (IDirect3DAuthenticatedChannel9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint*, int>)@this->LpVtbl[3])(@this, pCertificateSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCertificateSize<TThis>(this TThis thisVtbl, ref uint pCertificateSize) where TThis : IComVtbl<IDirect3DAuthenticatedChannel9>
    {
        var @this = (IDirect3DAuthenticatedChannel9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pCertificateSizePtr = &pCertificateSize)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint*, int>)@this->LpVtbl[3])(@this, pCertificateSizePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCertificate<TThis>(this TThis thisVtbl, uint CertifacteSize, byte* ppCertificate) where TThis : IComVtbl<IDirect3DAuthenticatedChannel9>
    {
        var @this = (IDirect3DAuthenticatedChannel9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, byte*, int>)@this->LpVtbl[4])(@this, CertifacteSize, ppCertificate);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCertificate<TThis>(this TThis thisVtbl, uint CertifacteSize, ref byte ppCertificate) where TThis : IComVtbl<IDirect3DAuthenticatedChannel9>
    {
        var @this = (IDirect3DAuthenticatedChannel9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* ppCertificatePtr = &ppCertificate)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, byte*, int>)@this->LpVtbl[4])(@this, CertifacteSize, ppCertificatePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCertificate<TThis>(this TThis thisVtbl, uint CertifacteSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string ppCertificate) where TThis : IComVtbl<IDirect3DAuthenticatedChannel9>
    {
        var @this = (IDirect3DAuthenticatedChannel9*) thisVtbl.AsVtblPtr();
        int ret = default;
        var ppCertificatePtr = (byte*) SilkMarshal.StringToPtr(ppCertificate, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, byte*, int>)@this->LpVtbl[4])(@this, CertifacteSize, ppCertificatePtr);
        SilkMarshal.Free((nint)ppCertificatePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int NegotiateKeyExchange<TThis>(this TThis thisVtbl, uint DataSize, void* pData) where TThis : IComVtbl<IDirect3DAuthenticatedChannel9>
    {
        var @this = (IDirect3DAuthenticatedChannel9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, void*, int>)@this->LpVtbl[5])(@this, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int NegotiateKeyExchange<T0, TThis>(this TThis thisVtbl, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDirect3DAuthenticatedChannel9>
    {
        var @this = (IDirect3DAuthenticatedChannel9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, void*, int>)@this->LpVtbl[5])(@this, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Query<TThis>(this TThis thisVtbl, uint InputSize, void* pInput, uint OutputSize, void* pOutput) where TThis : IComVtbl<IDirect3DAuthenticatedChannel9>
    {
        var @this = (IDirect3DAuthenticatedChannel9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, void*, uint, void*, int>)@this->LpVtbl[6])(@this, InputSize, pInput, OutputSize, pOutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Query<T0, TThis>(this TThis thisVtbl, uint InputSize, void* pInput, uint OutputSize, ref T0 pOutput) where T0 : unmanaged where TThis : IComVtbl<IDirect3DAuthenticatedChannel9>
    {
        var @this = (IDirect3DAuthenticatedChannel9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pOutputPtr = &pOutput)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, void*, uint, void*, int>)@this->LpVtbl[6])(@this, InputSize, pInput, OutputSize, pOutputPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Query<T0, TThis>(this TThis thisVtbl, uint InputSize, ref T0 pInput, uint OutputSize, void* pOutput) where T0 : unmanaged where TThis : IComVtbl<IDirect3DAuthenticatedChannel9>
    {
        var @this = (IDirect3DAuthenticatedChannel9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pInputPtr = &pInput)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, void*, uint, void*, int>)@this->LpVtbl[6])(@this, InputSize, pInputPtr, OutputSize, pOutput);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Query<T0, T1, TThis>(this TThis thisVtbl, uint InputSize, ref T0 pInput, uint OutputSize, ref T1 pOutput) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<IDirect3DAuthenticatedChannel9>
    {
        var @this = (IDirect3DAuthenticatedChannel9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pInputPtr = &pInput)
        {
            fixed (void* pOutputPtr = &pOutput)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, void*, uint, void*, int>)@this->LpVtbl[6])(@this, InputSize, pInputPtr, OutputSize, pOutputPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Configure<TThis>(this TThis thisVtbl, uint InputSize, void* pInput, AuthenticatedchannelConfigureOutput* pOutput) where TThis : IComVtbl<IDirect3DAuthenticatedChannel9>
    {
        var @this = (IDirect3DAuthenticatedChannel9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, void*, AuthenticatedchannelConfigureOutput*, int>)@this->LpVtbl[7])(@this, InputSize, pInput, pOutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Configure<TThis>(this TThis thisVtbl, uint InputSize, void* pInput, ref AuthenticatedchannelConfigureOutput pOutput) where TThis : IComVtbl<IDirect3DAuthenticatedChannel9>
    {
        var @this = (IDirect3DAuthenticatedChannel9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (AuthenticatedchannelConfigureOutput* pOutputPtr = &pOutput)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, void*, AuthenticatedchannelConfigureOutput*, int>)@this->LpVtbl[7])(@this, InputSize, pInput, pOutputPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Configure<T0, TThis>(this TThis thisVtbl, uint InputSize, ref T0 pInput, AuthenticatedchannelConfigureOutput* pOutput) where T0 : unmanaged where TThis : IComVtbl<IDirect3DAuthenticatedChannel9>
    {
        var @this = (IDirect3DAuthenticatedChannel9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pInputPtr = &pInput)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, void*, AuthenticatedchannelConfigureOutput*, int>)@this->LpVtbl[7])(@this, InputSize, pInputPtr, pOutput);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Configure<T0, TThis>(this TThis thisVtbl, uint InputSize, ref T0 pInput, ref AuthenticatedchannelConfigureOutput pOutput) where T0 : unmanaged where TThis : IComVtbl<IDirect3DAuthenticatedChannel9>
    {
        var @this = (IDirect3DAuthenticatedChannel9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pInputPtr = &pInput)
        {
            fixed (AuthenticatedchannelConfigureOutput* pOutputPtr = &pOutput)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, void*, AuthenticatedchannelConfigureOutput*, int>)@this->LpVtbl[7])(@this, InputSize, pInputPtr, pOutputPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDirect3DAuthenticatedChannel9>
    {
        var @this = (IDirect3DAuthenticatedChannel9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DAuthenticatedChannel9>
    {
        var @this = (IDirect3DAuthenticatedChannel9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetCertificateSize<TThis>(this TThis thisVtbl, Span<uint> pCertificateSize) where TThis : IComVtbl<IDirect3DAuthenticatedChannel9>
    {
        var @this = (IDirect3DAuthenticatedChannel9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCertificateSize(ref pCertificateSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetCertificate<TThis>(this TThis thisVtbl, uint CertifacteSize, Span<byte> ppCertificate) where TThis : IComVtbl<IDirect3DAuthenticatedChannel9>
    {
        var @this = (IDirect3DAuthenticatedChannel9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCertificate(CertifacteSize, ref ppCertificate.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int NegotiateKeyExchange<T0, TThis>(this TThis thisVtbl, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDirect3DAuthenticatedChannel9>
    {
        var @this = (IDirect3DAuthenticatedChannel9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->NegotiateKeyExchange(DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Query<T0, TThis>(this TThis thisVtbl, uint InputSize, void* pInput, uint OutputSize, Span<T0> pOutput) where T0 : unmanaged where TThis : IComVtbl<IDirect3DAuthenticatedChannel9>
    {
        var @this = (IDirect3DAuthenticatedChannel9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Query(InputSize, pInput, OutputSize, ref pOutput.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Query<T0, TThis>(this TThis thisVtbl, uint InputSize, Span<T0> pInput, uint OutputSize, void* pOutput) where T0 : unmanaged where TThis : IComVtbl<IDirect3DAuthenticatedChannel9>
    {
        var @this = (IDirect3DAuthenticatedChannel9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Query(InputSize, ref pInput.GetPinnableReference(), OutputSize, pOutput);
    }

    /// <summary>To be documented.</summary>
    public static int Query<T0, T1, TThis>(this TThis thisVtbl, uint InputSize, Span<T0> pInput, uint OutputSize, Span<T1> pOutput) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<IDirect3DAuthenticatedChannel9>
    {
        var @this = (IDirect3DAuthenticatedChannel9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Query(InputSize, ref pInput.GetPinnableReference(), OutputSize, ref pOutput.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Configure<TThis>(this TThis thisVtbl, uint InputSize, void* pInput, Span<AuthenticatedchannelConfigureOutput> pOutput) where TThis : IComVtbl<IDirect3DAuthenticatedChannel9>
    {
        var @this = (IDirect3DAuthenticatedChannel9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Configure(InputSize, pInput, ref pOutput.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Configure<T0, TThis>(this TThis thisVtbl, uint InputSize, Span<T0> pInput, AuthenticatedchannelConfigureOutput* pOutput) where T0 : unmanaged where TThis : IComVtbl<IDirect3DAuthenticatedChannel9>
    {
        var @this = (IDirect3DAuthenticatedChannel9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Configure(InputSize, ref pInput.GetPinnableReference(), pOutput);
    }

    /// <summary>To be documented.</summary>
    public static int Configure<T0, TThis>(this TThis thisVtbl, uint InputSize, Span<T0> pInput, Span<AuthenticatedchannelConfigureOutput> pOutput) where T0 : unmanaged where TThis : IComVtbl<IDirect3DAuthenticatedChannel9>
    {
        var @this = (IDirect3DAuthenticatedChannel9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Configure(InputSize, ref pInput.GetPinnableReference(), ref pOutput.GetPinnableReference());
    }

}
