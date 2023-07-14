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

public unsafe static class DWriteRemoteFontFileStreamVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadFileFragment(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** fragmentStart, ulong fileOffset, ulong fragmentSize, void** fragmentContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, void**, ulong, ulong, void**, int>)@this->LpVtbl[3])(@this, fragmentStart, fileOffset, fragmentSize, fragmentContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadFileFragment(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** fragmentStart, ulong fileOffset, ulong fragmentSize, ref void* fragmentContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** fragmentContextPtr = &fragmentContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, void**, ulong, ulong, void**, int>)@this->LpVtbl[3])(@this, fragmentStart, fileOffset, fragmentSize, fragmentContextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadFileFragment(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in void* fragmentStart, ulong fileOffset, ulong fragmentSize, void** fragmentContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** fragmentStartPtr = &fragmentStart)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, void**, ulong, ulong, void**, int>)@this->LpVtbl[3])(@this, fragmentStartPtr, fileOffset, fragmentSize, fragmentContext);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadFileFragment(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in void* fragmentStart, ulong fileOffset, ulong fragmentSize, ref void* fragmentContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** fragmentStartPtr = &fragmentStart)
        {
            fixed (void** fragmentContextPtr = &fragmentContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, void**, ulong, ulong, void**, int>)@this->LpVtbl[3])(@this, fragmentStartPtr, fileOffset, fragmentSize, fragmentContextPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ReleaseFileFragment(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, void* fragmentContext)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, void*, void>)@this->LpVtbl[4])(@this, fragmentContext);
    }

    /// <summary>To be documented.</summary>
    public static void ReleaseFileFragment<T0>(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, ref T0 fragmentContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* fragmentContextPtr = &fragmentContext)
        {
            ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, void*, void>)@this->LpVtbl[4])(@this, fragmentContextPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFileSize(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, ulong* fileSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, ulong*, int>)@this->LpVtbl[5])(@this, fileSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFileSize(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, ref ulong fileSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* fileSizePtr = &fileSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, ulong*, int>)@this->LpVtbl[5])(@this, fileSizePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLastWriteTime(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, ulong* lastWriteTime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, ulong*, int>)@this->LpVtbl[6])(@this, lastWriteTime);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetLastWriteTime(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, ref ulong lastWriteTime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* lastWriteTimePtr = &lastWriteTime)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, ulong*, int>)@this->LpVtbl[6])(@this, lastWriteTimePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLocalFileSize(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, ulong* localFileSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, ulong*, int>)@this->LpVtbl[7])(@this, localFileSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetLocalFileSize(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, ref ulong localFileSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* localFileSizePtr = &localFileSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, ulong*, int>)@this->LpVtbl[7])(@this, localFileSizePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFileFragmentLocality(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, ulong fileOffset, ulong fragmentSize, int* isLocal, ulong* partialSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, ulong, ulong, int*, ulong*, int>)@this->LpVtbl[8])(@this, fileOffset, fragmentSize, isLocal, partialSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFileFragmentLocality(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, ulong fileOffset, ulong fragmentSize, int* isLocal, ref ulong partialSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* partialSizePtr = &partialSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, ulong, ulong, int*, ulong*, int>)@this->LpVtbl[8])(@this, fileOffset, fragmentSize, isLocal, partialSizePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFileFragmentLocality(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, ulong fileOffset, ulong fragmentSize, ref int isLocal, ulong* partialSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* isLocalPtr = &isLocal)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, ulong, ulong, int*, ulong*, int>)@this->LpVtbl[8])(@this, fileOffset, fragmentSize, isLocalPtr, partialSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFileFragmentLocality(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, ulong fileOffset, ulong fragmentSize, ref int isLocal, ref ulong partialSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* isLocalPtr = &isLocal)
        {
            fixed (ulong* partialSizePtr = &partialSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, ulong, ulong, int*, ulong*, int>)@this->LpVtbl[8])(@this, fileOffset, fragmentSize, isLocalPtr, partialSizePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Locality GetLocality(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Locality ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, Locality>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDownload(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* downloadOperationID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FileFragment* fileFragments, uint fragmentCount, IDWriteAsyncResult** asyncResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, Guid*, FileFragment*, uint, IDWriteAsyncResult**, int>)@this->LpVtbl[10])(@this, downloadOperationID, fileFragments, fragmentCount, asyncResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDownload(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* downloadOperationID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FileFragment* fileFragments, uint fragmentCount, ref IDWriteAsyncResult* asyncResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteAsyncResult** asyncResultPtr = &asyncResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, Guid*, FileFragment*, uint, IDWriteAsyncResult**, int>)@this->LpVtbl[10])(@this, downloadOperationID, fileFragments, fragmentCount, asyncResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDownload(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* downloadOperationID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in FileFragment fileFragments, uint fragmentCount, IDWriteAsyncResult** asyncResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FileFragment* fileFragmentsPtr = &fileFragments)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, Guid*, FileFragment*, uint, IDWriteAsyncResult**, int>)@this->LpVtbl[10])(@this, downloadOperationID, fileFragmentsPtr, fragmentCount, asyncResult);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDownload(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* downloadOperationID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in FileFragment fileFragments, uint fragmentCount, ref IDWriteAsyncResult* asyncResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FileFragment* fileFragmentsPtr = &fileFragments)
        {
            fixed (IDWriteAsyncResult** asyncResultPtr = &asyncResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, Guid*, FileFragment*, uint, IDWriteAsyncResult**, int>)@this->LpVtbl[10])(@this, downloadOperationID, fileFragmentsPtr, fragmentCount, asyncResultPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDownload(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Guid downloadOperationID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FileFragment* fileFragments, uint fragmentCount, IDWriteAsyncResult** asyncResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* downloadOperationIDPtr = &downloadOperationID)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, Guid*, FileFragment*, uint, IDWriteAsyncResult**, int>)@this->LpVtbl[10])(@this, downloadOperationIDPtr, fileFragments, fragmentCount, asyncResult);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDownload(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Guid downloadOperationID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FileFragment* fileFragments, uint fragmentCount, ref IDWriteAsyncResult* asyncResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* downloadOperationIDPtr = &downloadOperationID)
        {
            fixed (IDWriteAsyncResult** asyncResultPtr = &asyncResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, Guid*, FileFragment*, uint, IDWriteAsyncResult**, int>)@this->LpVtbl[10])(@this, downloadOperationIDPtr, fileFragments, fragmentCount, asyncResultPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDownload(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Guid downloadOperationID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in FileFragment fileFragments, uint fragmentCount, IDWriteAsyncResult** asyncResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* downloadOperationIDPtr = &downloadOperationID)
        {
            fixed (FileFragment* fileFragmentsPtr = &fileFragments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, Guid*, FileFragment*, uint, IDWriteAsyncResult**, int>)@this->LpVtbl[10])(@this, downloadOperationIDPtr, fileFragmentsPtr, fragmentCount, asyncResult);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDownload(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Guid downloadOperationID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in FileFragment fileFragments, uint fragmentCount, ref IDWriteAsyncResult* asyncResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* downloadOperationIDPtr = &downloadOperationID)
        {
            fixed (FileFragment* fileFragmentsPtr = &fileFragments)
            {
                fixed (IDWriteAsyncResult** asyncResultPtr = &asyncResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, Guid*, FileFragment*, uint, IDWriteAsyncResult**, int>)@this->LpVtbl[10])(@this, downloadOperationIDPtr, fileFragmentsPtr, fragmentCount, asyncResultPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void ReleaseFileFragment<T0>(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, Span<T0> fragmentContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ReleaseFileFragment(ref fragmentContext.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetFileSize(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, Span<ulong> fileSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFileSize(ref fileSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetLastWriteTime(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, Span<ulong> lastWriteTime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLastWriteTime(ref lastWriteTime.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetLocalFileSize(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, Span<ulong> localFileSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLocalFileSize(ref localFileSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFileFragmentLocality(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, ulong fileOffset, ulong fragmentSize, int* isLocal, Span<ulong> partialSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFileFragmentLocality(fileOffset, fragmentSize, isLocal, ref partialSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFileFragmentLocality(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, ulong fileOffset, ulong fragmentSize, Span<int> isLocal, ulong* partialSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFileFragmentLocality(fileOffset, fragmentSize, ref isLocal.GetPinnableReference(), partialSize);
    }

    /// <summary>To be documented.</summary>
    public static int GetFileFragmentLocality(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, ulong fileOffset, ulong fragmentSize, Span<int> isLocal, Span<ulong> partialSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFileFragmentLocality(fileOffset, fragmentSize, ref isLocal.GetPinnableReference(), ref partialSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDownload<TI0>(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* downloadOperationID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FileFragment* fileFragments, uint fragmentCount, ref ComPtr<TI0> asyncResult) where TI0 : unmanaged, IComVtbl<IDWriteAsyncResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginDownload(downloadOperationID, fileFragments, fragmentCount, (IDWriteAsyncResult**) asyncResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDownload(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* downloadOperationID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FileFragment> fileFragments, uint fragmentCount, IDWriteAsyncResult** asyncResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginDownload(downloadOperationID, in fileFragments.GetPinnableReference(), fragmentCount, asyncResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDownload<TI0>(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* downloadOperationID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in FileFragment fileFragments, uint fragmentCount, ref ComPtr<TI0> asyncResult) where TI0 : unmanaged, IComVtbl<IDWriteAsyncResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginDownload(downloadOperationID, in fileFragments, fragmentCount, (IDWriteAsyncResult**) asyncResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDownload(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* downloadOperationID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FileFragment> fileFragments, uint fragmentCount, ref IDWriteAsyncResult* asyncResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginDownload(downloadOperationID, in fileFragments.GetPinnableReference(), fragmentCount, ref asyncResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDownload(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> downloadOperationID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FileFragment* fileFragments, uint fragmentCount, IDWriteAsyncResult** asyncResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginDownload(in downloadOperationID.GetPinnableReference(), fileFragments, fragmentCount, asyncResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDownload<TI0>(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Guid downloadOperationID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FileFragment* fileFragments, uint fragmentCount, ref ComPtr<TI0> asyncResult) where TI0 : unmanaged, IComVtbl<IDWriteAsyncResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginDownload(in downloadOperationID, fileFragments, fragmentCount, (IDWriteAsyncResult**) asyncResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDownload(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> downloadOperationID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FileFragment* fileFragments, uint fragmentCount, ref IDWriteAsyncResult* asyncResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginDownload(in downloadOperationID.GetPinnableReference(), fileFragments, fragmentCount, ref asyncResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDownload(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> downloadOperationID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FileFragment> fileFragments, uint fragmentCount, IDWriteAsyncResult** asyncResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginDownload(in downloadOperationID.GetPinnableReference(), in fileFragments.GetPinnableReference(), fragmentCount, asyncResult);
    }

    /// <summary>To be documented.</summary>
    public static int BeginDownload<TI0>(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Guid downloadOperationID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in FileFragment fileFragments, uint fragmentCount, ref ComPtr<TI0> asyncResult) where TI0 : unmanaged, IComVtbl<IDWriteAsyncResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginDownload(in downloadOperationID, in fileFragments, fragmentCount, (IDWriteAsyncResult**) asyncResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDownload(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> downloadOperationID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FileFragment> fileFragments, uint fragmentCount, ref IDWriteAsyncResult* asyncResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginDownload(in downloadOperationID.GetPinnableReference(), in fileFragments.GetPinnableReference(), fragmentCount, ref asyncResult);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteRemoteFontFileStream> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
