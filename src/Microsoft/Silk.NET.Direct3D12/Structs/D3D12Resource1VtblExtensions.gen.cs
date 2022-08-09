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

namespace Silk.NET.Direct3D12;

public unsafe static class D3D12Resource1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, ref uint pDataSize, void* pData) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, ref uint pDataSize, void* pData) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetName<TThis>(this TThis thisVtbl, char* Name) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, char*, int>)@this->LpVtbl[6])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName<TThis>(this TThis thisVtbl, ref char Name) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, char*, int>)@this->LpVtbl[6])(@this, NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, byte*, int>)@this->LpVtbl[6])(@this, NamePtr);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Guid* riid, void** ppvDevice) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvDevice) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvDevicePtr = &ppvDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvDevice) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvDevice) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvDevicePtr = &ppvDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Map<TThis>(this TThis thisVtbl, uint Subresource, Range* pReadRange, void** ppData) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, uint, Range*, void**, int>)@this->LpVtbl[8])(@this, Subresource, pReadRange, ppData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Map<TThis>(this TThis thisVtbl, uint Subresource, Range* pReadRange, ref void* ppData) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppDataPtr = &ppData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, uint, Range*, void**, int>)@this->LpVtbl[8])(@this, Subresource, pReadRange, ppDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Map<TThis>(this TThis thisVtbl, uint Subresource, ref Range pReadRange, void** ppData) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Range* pReadRangePtr = &pReadRange)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, uint, Range*, void**, int>)@this->LpVtbl[8])(@this, Subresource, pReadRangePtr, ppData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Map<TThis>(this TThis thisVtbl, uint Subresource, ref Range pReadRange, ref void* ppData) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Range* pReadRangePtr = &pReadRange)
        {
            fixed (void** ppDataPtr = &ppData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, uint, Range*, void**, int>)@this->LpVtbl[8])(@this, Subresource, pReadRangePtr, ppDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void Unmap<TThis>(this TThis thisVtbl, uint Subresource, Range* pWrittenRange) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, uint, Range*, void>)@this->LpVtbl[9])(@this, Subresource, pWrittenRange);
    }

    /// <summary>To be documented.</summary>
    public static void Unmap<TThis>(this TThis thisVtbl, uint Subresource, ref Range pWrittenRange) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        fixed (Range* pWrittenRangePtr = &pWrittenRange)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, uint, Range*, void>)@this->LpVtbl[9])(@this, Subresource, pWrittenRangePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static ResourceDesc GetDesc<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        ResourceDesc ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, ResourceDesc>)@this->LpVtbl[10])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetGPUVirtualAddress<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, ulong>)@this->LpVtbl[11])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteToSubresource<TThis>(this TThis thisVtbl, uint DstSubresource, Box* pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, uint, Box*, void*, uint, uint, int>)@this->LpVtbl[12])(@this, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteToSubresource<T0, TThis>(this TThis thisVtbl, uint DstSubresource, Box* pDstBox, ref T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pSrcDataPtr = &pSrcData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, uint, Box*, void*, uint, uint, int>)@this->LpVtbl[12])(@this, DstSubresource, pDstBox, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteToSubresource<TThis>(this TThis thisVtbl, uint DstSubresource, ref Box pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Box* pDstBoxPtr = &pDstBox)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, uint, Box*, void*, uint, uint, int>)@this->LpVtbl[12])(@this, DstSubresource, pDstBoxPtr, pSrcData, SrcRowPitch, SrcDepthPitch);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int WriteToSubresource<T0, TThis>(this TThis thisVtbl, uint DstSubresource, ref Box pDstBox, ref T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Box* pDstBoxPtr = &pDstBox)
        {
            fixed (void* pSrcDataPtr = &pSrcData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, uint, Box*, void*, uint, uint, int>)@this->LpVtbl[12])(@this, DstSubresource, pDstBoxPtr, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadFromSubresource<TThis>(this TThis thisVtbl, void* pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, Box* pSrcBox) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, void*, uint, uint, uint, Box*, int>)@this->LpVtbl[13])(@this, pDstData, DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBox);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadFromSubresource<TThis>(this TThis thisVtbl, void* pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, ref Box pSrcBox) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Box* pSrcBoxPtr = &pSrcBox)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, void*, uint, uint, uint, Box*, int>)@this->LpVtbl[13])(@this, pDstData, DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBoxPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadFromSubresource<T0, TThis>(this TThis thisVtbl, ref T0 pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, Box* pSrcBox) where T0 : unmanaged where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDstDataPtr = &pDstData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, void*, uint, uint, uint, Box*, int>)@this->LpVtbl[13])(@this, pDstDataPtr, DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBox);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ReadFromSubresource<T0, TThis>(this TThis thisVtbl, ref T0 pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, ref Box pSrcBox) where T0 : unmanaged where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDstDataPtr = &pDstData)
        {
            fixed (Box* pSrcBoxPtr = &pSrcBox)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, void*, uint, uint, uint, Box*, int>)@this->LpVtbl[13])(@this, pDstDataPtr, DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBoxPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetHeapProperties<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags* pHeapFlags) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, HeapProperties*, HeapFlags*, int>)@this->LpVtbl[14])(@this, pHeapProperties, pHeapFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetHeapProperties<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, ref HeapFlags pHeapFlags) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapFlags* pHeapFlagsPtr = &pHeapFlags)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, HeapProperties*, HeapFlags*, int>)@this->LpVtbl[14])(@this, pHeapProperties, pHeapFlagsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetHeapProperties<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags* pHeapFlags) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, HeapProperties*, HeapFlags*, int>)@this->LpVtbl[14])(@this, pHeapPropertiesPtr, pHeapFlags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetHeapProperties<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, ref HeapFlags pHeapFlags) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (HeapFlags* pHeapFlagsPtr = &pHeapFlags)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, HeapProperties*, HeapFlags*, int>)@this->LpVtbl[14])(@this, pHeapPropertiesPtr, pHeapFlagsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetProtectedResourceSession<TThis>(this TThis thisVtbl, Guid* riid, void** ppProtectedSession) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, void**, int>)@this->LpVtbl[15])(@this, riid, ppProtectedSession);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetProtectedResourceSession<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppProtectedSession) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppProtectedSessionPtr = &ppProtectedSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, void**, int>)@this->LpVtbl[15])(@this, riid, ppProtectedSessionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetProtectedResourceSession<TThis>(this TThis thisVtbl, ref Guid riid, void** ppProtectedSession) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, void**, int>)@this->LpVtbl[15])(@this, riidPtr, ppProtectedSession);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetProtectedResourceSession<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppProtectedSession) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppProtectedSessionPtr = &ppProtectedSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource1*, Guid*, void**, int>)@this->LpVtbl[15])(@this, riidPtr, ppProtectedSessionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(guid, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, Span<uint> pDataSize, void* pData) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> guid, Span<uint> pDataSize, void* pData) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(guid, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> guid, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(guid, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Span<Guid> guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Span<Guid> guid, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetName<TThis>(this TThis thisVtbl, Span<char> Name) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetName(ref Name.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDevice<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvDevice) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvDevice = default;
        return @this->GetDevice(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvDevice) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDevice(ref riid.GetPinnableReference(), ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvDevice) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDevice(ref riid.GetPinnableReference(), ref ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Map<TThis>(this TThis thisVtbl, uint Subresource, Span<Range> pReadRange, void** ppData) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Map(Subresource, ref pReadRange.GetPinnableReference(), ppData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Map<TThis>(this TThis thisVtbl, uint Subresource, Span<Range> pReadRange, ref void* ppData) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Map(Subresource, ref pReadRange.GetPinnableReference(), ref ppData);
    }

    /// <summary>To be documented.</summary>
    public static void Unmap<TThis>(this TThis thisVtbl, uint Subresource, Span<Range> pWrittenRange) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->Unmap(Subresource, ref pWrittenRange.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteToSubresource<T0, TThis>(this TThis thisVtbl, uint DstSubresource, Box* pDstBox, Span<T0> pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->WriteToSubresource(DstSubresource, pDstBox, ref pSrcData.GetPinnableReference(), SrcRowPitch, SrcDepthPitch);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteToSubresource<TThis>(this TThis thisVtbl, uint DstSubresource, Span<Box> pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->WriteToSubresource(DstSubresource, ref pDstBox.GetPinnableReference(), pSrcData, SrcRowPitch, SrcDepthPitch);
    }

    /// <summary>To be documented.</summary>
    public static int WriteToSubresource<T0, TThis>(this TThis thisVtbl, uint DstSubresource, Span<Box> pDstBox, Span<T0> pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->WriteToSubresource(DstSubresource, ref pDstBox.GetPinnableReference(), ref pSrcData.GetPinnableReference(), SrcRowPitch, SrcDepthPitch);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadFromSubresource<TThis>(this TThis thisVtbl, void* pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, Span<Box> pSrcBox) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ReadFromSubresource(pDstData, DstRowPitch, DstDepthPitch, SrcSubresource, ref pSrcBox.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadFromSubresource<T0, TThis>(this TThis thisVtbl, Span<T0> pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, Box* pSrcBox) where T0 : unmanaged where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ReadFromSubresource(ref pDstData.GetPinnableReference(), DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBox);
    }

    /// <summary>To be documented.</summary>
    public static int ReadFromSubresource<T0, TThis>(this TThis thisVtbl, Span<T0> pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, Span<Box> pSrcBox) where T0 : unmanaged where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ReadFromSubresource(ref pDstData.GetPinnableReference(), DstRowPitch, DstDepthPitch, SrcSubresource, ref pSrcBox.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetHeapProperties<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, Span<HeapFlags> pHeapFlags) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetHeapProperties(pHeapProperties, ref pHeapFlags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetHeapProperties<TThis>(this TThis thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags* pHeapFlags) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetHeapProperties(ref pHeapProperties.GetPinnableReference(), pHeapFlags);
    }

    /// <summary>To be documented.</summary>
    public static int GetHeapProperties<TThis>(this TThis thisVtbl, Span<HeapProperties> pHeapProperties, Span<HeapFlags> pHeapFlags) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetHeapProperties(ref pHeapProperties.GetPinnableReference(), ref pHeapFlags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetProtectedResourceSession<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppProtectedSession) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppProtectedSession = default;
        return @this->GetProtectedResourceSession(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppProtectedSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetProtectedResourceSession<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppProtectedSession) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetProtectedResourceSession(ref riid.GetPinnableReference(), ppProtectedSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetProtectedResourceSession<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppProtectedSession) where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetProtectedResourceSession(ref riid.GetPinnableReference(), ref ppProtectedSession);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0, TThis>(this TThis thisVtbl) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetDevice<TI0, TThis>(this TThis thisVtbl) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetDevice(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetProtectedResourceSession<TI0, TThis>(this TThis thisVtbl) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12Resource1>
    {
        var @this = (ID3D12Resource1*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetProtectedResourceSession(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
