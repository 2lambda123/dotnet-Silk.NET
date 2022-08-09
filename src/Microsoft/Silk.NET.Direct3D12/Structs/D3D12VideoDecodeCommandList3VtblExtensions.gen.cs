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

public unsafe static class D3D12VideoDecodeCommandList3VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Guid* guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Guid* guid, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ref Guid guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ref Guid guid, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Guid* guid, uint DataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ref Guid guid, uint DataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetName(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, char* Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, char*, int>)@this->LpVtbl[6])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ref char Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, char*, int>)@this->LpVtbl[6])(@this, NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, byte*, int>)@this->LpVtbl[6])(@this, NamePtr);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Guid* riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Guid* riid, ref void* ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvDevicePtr = &ppvDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ref Guid riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ref Guid riid, ref void* ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvDevicePtr = &ppvDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static CommandListType GetType(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        CommandListType ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, CommandListType>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Close(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, int>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Reset(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ID3D12CommandAllocator* pAllocator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12CommandAllocator*, int>)@this->LpVtbl[10])(@this, pAllocator);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Reset(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ref ID3D12CommandAllocator pAllocator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12CommandAllocator* pAllocatorPtr = &pAllocator)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12CommandAllocator*, int>)@this->LpVtbl[10])(@this, pAllocatorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void ClearState(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, void>)@this->LpVtbl[11])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResourceBarrier(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, uint NumBarriers, ResourceBarrier* pBarriers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, uint, ResourceBarrier*, void>)@this->LpVtbl[12])(@this, NumBarriers, pBarriers);
    }

    /// <summary>To be documented.</summary>
    public static void ResourceBarrier(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, uint NumBarriers, ref ResourceBarrier pBarriers)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceBarrier* pBarriersPtr = &pBarriers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, uint, ResourceBarrier*, void>)@this->LpVtbl[12])(@this, NumBarriers, pBarriersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardResource(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ID3D12Resource* pResource, DiscardRegion* pRegion)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[13])(@this, pResource, pRegion);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardResource(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ID3D12Resource* pResource, ref DiscardRegion pRegion)
    {
        var @this = thisVtbl.Handle;
        fixed (DiscardRegion* pRegionPtr = &pRegion)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[13])(@this, pResource, pRegionPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardResource(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ref ID3D12Resource pResource, DiscardRegion* pRegion)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[13])(@this, pResourcePtr, pRegion);
        }
    }

    /// <summary>To be documented.</summary>
    public static void DiscardResource(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ref ID3D12Resource pResource, ref DiscardRegion pRegion)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (DiscardRegion* pRegionPtr = &pRegion)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[13])(@this, pResourcePtr, pRegionPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void BeginQuery(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[14])(@this, pQueryHeap, Type, Index);
    }

    /// <summary>To be documented.</summary>
    public static void BeginQuery(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint Index)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[14])(@this, pQueryHeapPtr, Type, Index);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EndQuery(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[15])(@this, pQueryHeap, Type, Index);
    }

    /// <summary>To be documented.</summary>
    public static void EndQuery(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint Index)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[15])(@this, pQueryHeapPtr, Type, Index);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveQueryData(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[16])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveQueryData(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDestinationBufferPtr = &pDestinationBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[16])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveQueryData(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[16])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
        }
    }

    /// <summary>To be documented.</summary>
    public static void ResolveQueryData(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
        {
            fixed (ID3D12Resource* pDestinationBufferPtr = &pDestinationBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[16])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetPredication(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ID3D12Resource* pBuffer, ulong AlignedBufferOffset, PredicationOp Operation)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12Resource*, ulong, PredicationOp, void>)@this->LpVtbl[17])(@this, pBuffer, AlignedBufferOffset, Operation);
    }

    /// <summary>To be documented.</summary>
    public static void SetPredication(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ref ID3D12Resource pBuffer, ulong AlignedBufferOffset, PredicationOp Operation)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pBufferPtr = &pBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12Resource*, ulong, PredicationOp, void>)@this->LpVtbl[17])(@this, pBufferPtr, AlignedBufferOffset, Operation);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetMarker(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, uint Metadata, void* pData, uint Size)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, uint, void*, uint, void>)@this->LpVtbl[18])(@this, Metadata, pData, Size);
    }

    /// <summary>To be documented.</summary>
    public static void SetMarker<T0>(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, uint Metadata, ref T0 pData, uint Size) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* pDataPtr = &pData)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, uint, void*, uint, void>)@this->LpVtbl[18])(@this, Metadata, pDataPtr, Size);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void BeginEvent(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, uint Metadata, void* pData, uint Size)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, uint, void*, uint, void>)@this->LpVtbl[19])(@this, Metadata, pData, Size);
    }

    /// <summary>To be documented.</summary>
    public static void BeginEvent<T0>(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, uint Metadata, ref T0 pData, uint Size) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* pDataPtr = &pData)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, uint, void*, uint, void>)@this->LpVtbl[19])(@this, Metadata, pDataPtr, Size);
        }
    }

    /// <summary>To be documented.</summary>
    public static void EndEvent(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, void>)@this->LpVtbl[20])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecodeFrame(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ID3D12VideoDecoder* pDecoder, VideoDecodeOutputStreamArguments* pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)@this->LpVtbl[21])(@this, pDecoder, pOutputArguments, pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecodeFrame(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ID3D12VideoDecoder* pDecoder, VideoDecodeOutputStreamArguments* pOutputArguments, ref VideoDecodeInputStreamArguments pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (VideoDecodeInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)@this->LpVtbl[21])(@this, pDecoder, pOutputArguments, pInputArgumentsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecodeFrame(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ID3D12VideoDecoder* pDecoder, ref VideoDecodeOutputStreamArguments pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (VideoDecodeOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)@this->LpVtbl[21])(@this, pDecoder, pOutputArgumentsPtr, pInputArguments);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecodeFrame(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ID3D12VideoDecoder* pDecoder, ref VideoDecodeOutputStreamArguments pOutputArguments, ref VideoDecodeInputStreamArguments pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (VideoDecodeOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
        {
            fixed (VideoDecodeInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)@this->LpVtbl[21])(@this, pDecoder, pOutputArgumentsPtr, pInputArgumentsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecodeFrame(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ref ID3D12VideoDecoder pDecoder, VideoDecodeOutputStreamArguments* pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoDecoder* pDecoderPtr = &pDecoder)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)@this->LpVtbl[21])(@this, pDecoderPtr, pOutputArguments, pInputArguments);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecodeFrame(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ref ID3D12VideoDecoder pDecoder, VideoDecodeOutputStreamArguments* pOutputArguments, ref VideoDecodeInputStreamArguments pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoDecoder* pDecoderPtr = &pDecoder)
        {
            fixed (VideoDecodeInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)@this->LpVtbl[21])(@this, pDecoderPtr, pOutputArguments, pInputArgumentsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecodeFrame(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ref ID3D12VideoDecoder pDecoder, ref VideoDecodeOutputStreamArguments pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoDecoder* pDecoderPtr = &pDecoder)
        {
            fixed (VideoDecodeOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)@this->LpVtbl[21])(@this, pDecoderPtr, pOutputArgumentsPtr, pInputArguments);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void DecodeFrame(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ref ID3D12VideoDecoder pDecoder, ref VideoDecodeOutputStreamArguments pOutputArguments, ref VideoDecodeInputStreamArguments pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoDecoder* pDecoderPtr = &pDecoder)
        {
            fixed (VideoDecodeOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
            {
                fixed (VideoDecodeInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)@this->LpVtbl[21])(@this, pDecoderPtr, pOutputArgumentsPtr, pInputArgumentsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void WriteBufferImmediate(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, uint Count, WritebufferimmediateParameter* pParams, WritebufferimmediateMode* pModes)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[22])(@this, Count, pParams, pModes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void WriteBufferImmediate(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, uint Count, WritebufferimmediateParameter* pParams, ref WritebufferimmediateMode pModes)
    {
        var @this = thisVtbl.Handle;
        fixed (WritebufferimmediateMode* pModesPtr = &pModes)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[22])(@this, Count, pParams, pModesPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void WriteBufferImmediate(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, uint Count, ref WritebufferimmediateParameter pParams, WritebufferimmediateMode* pModes)
    {
        var @this = thisVtbl.Handle;
        fixed (WritebufferimmediateParameter* pParamsPtr = &pParams)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[22])(@this, Count, pParamsPtr, pModes);
        }
    }

    /// <summary>To be documented.</summary>
    public static void WriteBufferImmediate(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, uint Count, ref WritebufferimmediateParameter pParams, ref WritebufferimmediateMode pModes)
    {
        var @this = thisVtbl.Handle;
        fixed (WritebufferimmediateParameter* pParamsPtr = &pParams)
        {
            fixed (WritebufferimmediateMode* pModesPtr = &pModes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[22])(@this, Count, pParamsPtr, pModesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecodeFrame1(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ID3D12VideoDecoder* pDecoder, VideoDecodeOutputStreamArguments1* pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)@this->LpVtbl[23])(@this, pDecoder, pOutputArguments, pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecodeFrame1(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ID3D12VideoDecoder* pDecoder, VideoDecodeOutputStreamArguments1* pOutputArguments, ref VideoDecodeInputStreamArguments pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (VideoDecodeInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)@this->LpVtbl[23])(@this, pDecoder, pOutputArguments, pInputArgumentsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecodeFrame1(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ID3D12VideoDecoder* pDecoder, ref VideoDecodeOutputStreamArguments1 pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (VideoDecodeOutputStreamArguments1* pOutputArgumentsPtr = &pOutputArguments)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)@this->LpVtbl[23])(@this, pDecoder, pOutputArgumentsPtr, pInputArguments);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecodeFrame1(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ID3D12VideoDecoder* pDecoder, ref VideoDecodeOutputStreamArguments1 pOutputArguments, ref VideoDecodeInputStreamArguments pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (VideoDecodeOutputStreamArguments1* pOutputArgumentsPtr = &pOutputArguments)
        {
            fixed (VideoDecodeInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)@this->LpVtbl[23])(@this, pDecoder, pOutputArgumentsPtr, pInputArgumentsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecodeFrame1(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ref ID3D12VideoDecoder pDecoder, VideoDecodeOutputStreamArguments1* pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoDecoder* pDecoderPtr = &pDecoder)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)@this->LpVtbl[23])(@this, pDecoderPtr, pOutputArguments, pInputArguments);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecodeFrame1(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ref ID3D12VideoDecoder pDecoder, VideoDecodeOutputStreamArguments1* pOutputArguments, ref VideoDecodeInputStreamArguments pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoDecoder* pDecoderPtr = &pDecoder)
        {
            fixed (VideoDecodeInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)@this->LpVtbl[23])(@this, pDecoderPtr, pOutputArguments, pInputArgumentsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecodeFrame1(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ref ID3D12VideoDecoder pDecoder, ref VideoDecodeOutputStreamArguments1 pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoDecoder* pDecoderPtr = &pDecoder)
        {
            fixed (VideoDecodeOutputStreamArguments1* pOutputArgumentsPtr = &pOutputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)@this->LpVtbl[23])(@this, pDecoderPtr, pOutputArgumentsPtr, pInputArguments);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void DecodeFrame1(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ref ID3D12VideoDecoder pDecoder, ref VideoDecodeOutputStreamArguments1 pOutputArguments, ref VideoDecodeInputStreamArguments pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoDecoder* pDecoderPtr = &pDecoder)
        {
            fixed (VideoDecodeOutputStreamArguments1* pOutputArgumentsPtr = &pOutputArguments)
            {
                fixed (VideoDecodeInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)@this->LpVtbl[23])(@this, pDecoderPtr, pOutputArgumentsPtr, pInputArgumentsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetProtectedResourceSession(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ID3D12ProtectedResourceSession* pProtectedResourceSession)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12ProtectedResourceSession*, void>)@this->LpVtbl[24])(@this, pProtectedResourceSession);
    }

    /// <summary>To be documented.</summary>
    public static void SetProtectedResourceSession(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ref ID3D12ProtectedResourceSession pProtectedResourceSession)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12ProtectedResourceSession*, void>)@this->LpVtbl[24])(@this, pProtectedResourceSessionPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void InitializeExtensionCommand(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ID3D12VideoExtensionCommand* pExtensionCommand, void* pInitializationParameters, nuint InitializationParametersSizeInBytes)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12VideoExtensionCommand*, void*, nuint, void>)@this->LpVtbl[25])(@this, pExtensionCommand, pInitializationParameters, InitializationParametersSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void InitializeExtensionCommand<T0>(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ID3D12VideoExtensionCommand* pExtensionCommand, ref T0 pInitializationParameters, nuint InitializationParametersSizeInBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* pInitializationParametersPtr = &pInitializationParameters)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12VideoExtensionCommand*, void*, nuint, void>)@this->LpVtbl[25])(@this, pExtensionCommand, pInitializationParametersPtr, InitializationParametersSizeInBytes);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void InitializeExtensionCommand(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ref ID3D12VideoExtensionCommand pExtensionCommand, void* pInitializationParameters, nuint InitializationParametersSizeInBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12VideoExtensionCommand*, void*, nuint, void>)@this->LpVtbl[25])(@this, pExtensionCommandPtr, pInitializationParameters, InitializationParametersSizeInBytes);
        }
    }

    /// <summary>To be documented.</summary>
    public static void InitializeExtensionCommand<T0>(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ref ID3D12VideoExtensionCommand pExtensionCommand, ref T0 pInitializationParameters, nuint InitializationParametersSizeInBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
        {
            fixed (void* pInitializationParametersPtr = &pInitializationParameters)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12VideoExtensionCommand*, void*, nuint, void>)@this->LpVtbl[25])(@this, pExtensionCommandPtr, pInitializationParametersPtr, InitializationParametersSizeInBytes);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteExtensionCommand(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ID3D12VideoExtensionCommand* pExtensionCommand, void* pExecutionParameters, nuint ExecutionParametersSizeInBytes)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12VideoExtensionCommand*, void*, nuint, void>)@this->LpVtbl[26])(@this, pExtensionCommand, pExecutionParameters, ExecutionParametersSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteExtensionCommand<T0>(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ID3D12VideoExtensionCommand* pExtensionCommand, ref T0 pExecutionParameters, nuint ExecutionParametersSizeInBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* pExecutionParametersPtr = &pExecutionParameters)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12VideoExtensionCommand*, void*, nuint, void>)@this->LpVtbl[26])(@this, pExtensionCommand, pExecutionParametersPtr, ExecutionParametersSizeInBytes);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteExtensionCommand(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ref ID3D12VideoExtensionCommand pExtensionCommand, void* pExecutionParameters, nuint ExecutionParametersSizeInBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12VideoExtensionCommand*, void*, nuint, void>)@this->LpVtbl[26])(@this, pExtensionCommandPtr, pExecutionParameters, ExecutionParametersSizeInBytes);
        }
    }

    /// <summary>To be documented.</summary>
    public static void ExecuteExtensionCommand<T0>(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ref ID3D12VideoExtensionCommand pExtensionCommand, ref T0 pExecutionParameters, nuint ExecutionParametersSizeInBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
        {
            fixed (void* pExecutionParametersPtr = &pExecutionParameters)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, ID3D12VideoExtensionCommand*, void*, nuint, void>)@this->LpVtbl[26])(@this, pExtensionCommandPtr, pExecutionParametersPtr, ExecutionParametersSizeInBytes);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void Barrier(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, uint NumBarrierGroups, BarrierGroup* pBarrierGroups)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, uint, BarrierGroup*, void>)@this->LpVtbl[27])(@this, NumBarrierGroups, pBarrierGroups);
    }

    /// <summary>To be documented.</summary>
    public static void Barrier(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, uint NumBarrierGroups, ref BarrierGroup pBarrierGroups)
    {
        var @this = thisVtbl.Handle;
        fixed (BarrierGroup* pBarrierGroupsPtr = &pBarrierGroups)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList3*, uint, BarrierGroup*, void>)@this->LpVtbl[27])(@this, NumBarrierGroups, pBarrierGroupsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Guid* guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Guid* guid, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Guid* guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Span<Guid> guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Span<Guid> guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Span<Guid> guid, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Span<Guid> guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Guid* guid, uint DataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(guid, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Span<Guid> guid, uint DataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Span<Guid> guid, uint DataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Guid* guid, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(guid, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Span<Guid> guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Span<Guid> guid, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetName(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Span<char> Name)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetName(ref Name.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDevice<TI0>(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, out ComPtr<TI0> ppvDevice) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvDevice = default;
        return @this->GetDevice(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Span<Guid> riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDevice(ref riid.GetPinnableReference(), ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Span<Guid> riid, ref void* ppvDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDevice(ref riid.GetPinnableReference(), ref ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static int Reset(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Span<ID3D12CommandAllocator> pAllocator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Reset(ref pAllocator.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void ResourceBarrier(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, uint NumBarriers, Span<ResourceBarrier> pBarriers)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResourceBarrier(NumBarriers, ref pBarriers.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardResource(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ID3D12Resource* pResource, Span<DiscardRegion> pRegion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DiscardResource(pResource, ref pRegion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardResource(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Span<ID3D12Resource> pResource, DiscardRegion* pRegion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DiscardResource(ref pResource.GetPinnableReference(), pRegion);
    }

    /// <summary>To be documented.</summary>
    public static void DiscardResource(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Span<ID3D12Resource> pResource, Span<DiscardRegion> pRegion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DiscardResource(ref pResource.GetPinnableReference(), ref pRegion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void BeginQuery(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Span<ID3D12QueryHeap> pQueryHeap, QueryType Type, uint Index)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->BeginQuery(ref pQueryHeap.GetPinnableReference(), Type, Index);
    }

    /// <summary>To be documented.</summary>
    public static void EndQuery(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Span<ID3D12QueryHeap> pQueryHeap, QueryType Type, uint Index)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->EndQuery(ref pQueryHeap.GetPinnableReference(), Type, Index);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveQueryData(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, Span<ID3D12Resource> pDestinationBuffer, ulong AlignedDestinationBufferOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResolveQueryData(pQueryHeap, Type, StartIndex, NumQueries, ref pDestinationBuffer.GetPinnableReference(), AlignedDestinationBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveQueryData(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Span<ID3D12QueryHeap> pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResolveQueryData(ref pQueryHeap.GetPinnableReference(), Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static void ResolveQueryData(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Span<ID3D12QueryHeap> pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, Span<ID3D12Resource> pDestinationBuffer, ulong AlignedDestinationBufferOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResolveQueryData(ref pQueryHeap.GetPinnableReference(), Type, StartIndex, NumQueries, ref pDestinationBuffer.GetPinnableReference(), AlignedDestinationBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static void SetPredication(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Span<ID3D12Resource> pBuffer, ulong AlignedBufferOffset, PredicationOp Operation)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetPredication(ref pBuffer.GetPinnableReference(), AlignedBufferOffset, Operation);
    }

    /// <summary>To be documented.</summary>
    public static void SetMarker<T0>(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, uint Metadata, Span<T0> pData, uint Size) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetMarker(Metadata, ref pData.GetPinnableReference(), Size);
    }

    /// <summary>To be documented.</summary>
    public static void BeginEvent<T0>(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, uint Metadata, Span<T0> pData, uint Size) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->BeginEvent(Metadata, ref pData.GetPinnableReference(), Size);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecodeFrame(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ID3D12VideoDecoder* pDecoder, VideoDecodeOutputStreamArguments* pOutputArguments, Span<VideoDecodeInputStreamArguments> pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DecodeFrame(pDecoder, pOutputArguments, ref pInputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecodeFrame(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ID3D12VideoDecoder* pDecoder, Span<VideoDecodeOutputStreamArguments> pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DecodeFrame(pDecoder, ref pOutputArguments.GetPinnableReference(), pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecodeFrame(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ID3D12VideoDecoder* pDecoder, Span<VideoDecodeOutputStreamArguments> pOutputArguments, Span<VideoDecodeInputStreamArguments> pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DecodeFrame(pDecoder, ref pOutputArguments.GetPinnableReference(), ref pInputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecodeFrame(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Span<ID3D12VideoDecoder> pDecoder, VideoDecodeOutputStreamArguments* pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DecodeFrame(ref pDecoder.GetPinnableReference(), pOutputArguments, pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecodeFrame(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Span<ID3D12VideoDecoder> pDecoder, VideoDecodeOutputStreamArguments* pOutputArguments, Span<VideoDecodeInputStreamArguments> pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DecodeFrame(ref pDecoder.GetPinnableReference(), pOutputArguments, ref pInputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecodeFrame(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Span<ID3D12VideoDecoder> pDecoder, Span<VideoDecodeOutputStreamArguments> pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DecodeFrame(ref pDecoder.GetPinnableReference(), ref pOutputArguments.GetPinnableReference(), pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static void DecodeFrame(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Span<ID3D12VideoDecoder> pDecoder, Span<VideoDecodeOutputStreamArguments> pOutputArguments, Span<VideoDecodeInputStreamArguments> pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DecodeFrame(ref pDecoder.GetPinnableReference(), ref pOutputArguments.GetPinnableReference(), ref pInputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void WriteBufferImmediate(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, uint Count, WritebufferimmediateParameter* pParams, Span<WritebufferimmediateMode> pModes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->WriteBufferImmediate(Count, pParams, ref pModes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void WriteBufferImmediate(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, uint Count, Span<WritebufferimmediateParameter> pParams, WritebufferimmediateMode* pModes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->WriteBufferImmediate(Count, ref pParams.GetPinnableReference(), pModes);
    }

    /// <summary>To be documented.</summary>
    public static void WriteBufferImmediate(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, uint Count, Span<WritebufferimmediateParameter> pParams, Span<WritebufferimmediateMode> pModes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->WriteBufferImmediate(Count, ref pParams.GetPinnableReference(), ref pModes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecodeFrame1(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ID3D12VideoDecoder* pDecoder, VideoDecodeOutputStreamArguments1* pOutputArguments, Span<VideoDecodeInputStreamArguments> pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DecodeFrame1(pDecoder, pOutputArguments, ref pInputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecodeFrame1(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ID3D12VideoDecoder* pDecoder, Span<VideoDecodeOutputStreamArguments1> pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DecodeFrame1(pDecoder, ref pOutputArguments.GetPinnableReference(), pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecodeFrame1(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ID3D12VideoDecoder* pDecoder, Span<VideoDecodeOutputStreamArguments1> pOutputArguments, Span<VideoDecodeInputStreamArguments> pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DecodeFrame1(pDecoder, ref pOutputArguments.GetPinnableReference(), ref pInputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecodeFrame1(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Span<ID3D12VideoDecoder> pDecoder, VideoDecodeOutputStreamArguments1* pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DecodeFrame1(ref pDecoder.GetPinnableReference(), pOutputArguments, pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecodeFrame1(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Span<ID3D12VideoDecoder> pDecoder, VideoDecodeOutputStreamArguments1* pOutputArguments, Span<VideoDecodeInputStreamArguments> pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DecodeFrame1(ref pDecoder.GetPinnableReference(), pOutputArguments, ref pInputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecodeFrame1(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Span<ID3D12VideoDecoder> pDecoder, Span<VideoDecodeOutputStreamArguments1> pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DecodeFrame1(ref pDecoder.GetPinnableReference(), ref pOutputArguments.GetPinnableReference(), pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static void DecodeFrame1(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Span<ID3D12VideoDecoder> pDecoder, Span<VideoDecodeOutputStreamArguments1> pOutputArguments, Span<VideoDecodeInputStreamArguments> pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DecodeFrame1(ref pDecoder.GetPinnableReference(), ref pOutputArguments.GetPinnableReference(), ref pInputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SetProtectedResourceSession(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetProtectedResourceSession(ref pProtectedResourceSession.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void InitializeExtensionCommand<T0>(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ID3D12VideoExtensionCommand* pExtensionCommand, Span<T0> pInitializationParameters, nuint InitializationParametersSizeInBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->InitializeExtensionCommand(pExtensionCommand, ref pInitializationParameters.GetPinnableReference(), InitializationParametersSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void InitializeExtensionCommand(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Span<ID3D12VideoExtensionCommand> pExtensionCommand, void* pInitializationParameters, nuint InitializationParametersSizeInBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->InitializeExtensionCommand(ref pExtensionCommand.GetPinnableReference(), pInitializationParameters, InitializationParametersSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static void InitializeExtensionCommand<T0>(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Span<ID3D12VideoExtensionCommand> pExtensionCommand, Span<T0> pInitializationParameters, nuint InitializationParametersSizeInBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->InitializeExtensionCommand(ref pExtensionCommand.GetPinnableReference(), ref pInitializationParameters.GetPinnableReference(), InitializationParametersSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteExtensionCommand<T0>(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, ID3D12VideoExtensionCommand* pExtensionCommand, Span<T0> pExecutionParameters, nuint ExecutionParametersSizeInBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ExecuteExtensionCommand(pExtensionCommand, ref pExecutionParameters.GetPinnableReference(), ExecutionParametersSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteExtensionCommand(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Span<ID3D12VideoExtensionCommand> pExtensionCommand, void* pExecutionParameters, nuint ExecutionParametersSizeInBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ExecuteExtensionCommand(ref pExtensionCommand.GetPinnableReference(), pExecutionParameters, ExecutionParametersSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static void ExecuteExtensionCommand<T0>(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, Span<ID3D12VideoExtensionCommand> pExtensionCommand, Span<T0> pExecutionParameters, nuint ExecutionParametersSizeInBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ExecuteExtensionCommand(ref pExtensionCommand.GetPinnableReference(), ref pExecutionParameters.GetPinnableReference(), ExecutionParametersSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static void Barrier(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl, uint NumBarrierGroups, Span<BarrierGroup> pBarrierGroups)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->Barrier(NumBarrierGroups, ref pBarrierGroups.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetDevice<TI0>(this ComPtr<ID3D12VideoDecodeCommandList3> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetDevice(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
