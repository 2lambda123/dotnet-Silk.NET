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

public unsafe static class D3D12GraphicsCommandList2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Guid* guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Guid* guid, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref Guid guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref Guid guid, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Guid* guid, uint DataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref Guid guid, uint DataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetName(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, char* Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, char*, int>)@this->LpVtbl[6])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref char Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, char*, int>)@this->LpVtbl[6])(@this, NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, byte*, int>)@this->LpVtbl[6])(@this, NamePtr);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Guid* riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Guid* riid, ref void* ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvDevicePtr = &ppvDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref Guid riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref Guid riid, ref void* ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvDevicePtr = &ppvDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static CommandListType GetType(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        CommandListType ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, CommandListType>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Close(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, int>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Reset(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12CommandAllocator* pAllocator, ID3D12PipelineState* pInitialState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12CommandAllocator*, ID3D12PipelineState*, int>)@this->LpVtbl[10])(@this, pAllocator, pInitialState);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Reset(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12CommandAllocator* pAllocator, ref ID3D12PipelineState pInitialState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12CommandAllocator*, ID3D12PipelineState*, int>)@this->LpVtbl[10])(@this, pAllocator, pInitialStatePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Reset(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12CommandAllocator pAllocator, ID3D12PipelineState* pInitialState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12CommandAllocator* pAllocatorPtr = &pAllocator)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12CommandAllocator*, ID3D12PipelineState*, int>)@this->LpVtbl[10])(@this, pAllocatorPtr, pInitialState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Reset(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12CommandAllocator pAllocator, ref ID3D12PipelineState pInitialState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12CommandAllocator* pAllocatorPtr = &pAllocator)
        {
            fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12CommandAllocator*, ID3D12PipelineState*, int>)@this->LpVtbl[10])(@this, pAllocatorPtr, pInitialStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearState(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12PipelineState* pPipelineState)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12PipelineState*, void>)@this->LpVtbl[11])(@this, pPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static void ClearState(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12PipelineState pPipelineState)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12PipelineState* pPipelineStatePtr = &pPipelineState)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12PipelineState*, void>)@this->LpVtbl[11])(@this, pPipelineStatePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void DrawInstanced(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint VertexCountPerInstance, uint InstanceCount, uint StartVertexLocation, uint StartInstanceLocation)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, uint, uint, uint, void>)@this->LpVtbl[12])(@this, VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
    }

    /// <summary>To be documented.</summary>
    public static void DrawIndexedInstanced(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint IndexCountPerInstance, uint InstanceCount, uint StartIndexLocation, int BaseVertexLocation, uint StartInstanceLocation)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, uint, uint, int, uint, void>)@this->LpVtbl[13])(@this, IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
    }

    /// <summary>To be documented.</summary>
    public static void Dispatch(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint ThreadGroupCountX, uint ThreadGroupCountY, uint ThreadGroupCountZ)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, uint, uint, void>)@this->LpVtbl[14])(@this, ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyBufferRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, ulong NumBytes)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void>)@this->LpVtbl[15])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, NumBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyBufferRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, ulong NumBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void>)@this->LpVtbl[15])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, NumBytes);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyBufferRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, ulong NumBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void>)@this->LpVtbl[15])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, NumBytes);
        }
    }

    /// <summary>To be documented.</summary>
    public static void CopyBufferRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, ulong NumBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void>)@this->LpVtbl[15])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, NumBytes);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTextureRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, TextureCopyLocation* pDst, uint DstX, uint DstY, uint DstZ, TextureCopyLocation* pSrc, Box* pSrcBox)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)@this->LpVtbl[16])(@this, pDst, DstX, DstY, DstZ, pSrc, pSrcBox);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTextureRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, TextureCopyLocation* pDst, uint DstX, uint DstY, uint DstZ, TextureCopyLocation* pSrc, ref Box pSrcBox)
    {
        var @this = thisVtbl.Handle;
        fixed (Box* pSrcBoxPtr = &pSrcBox)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)@this->LpVtbl[16])(@this, pDst, DstX, DstY, DstZ, pSrc, pSrcBoxPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTextureRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, TextureCopyLocation* pDst, uint DstX, uint DstY, uint DstZ, ref TextureCopyLocation pSrc, Box* pSrcBox)
    {
        var @this = thisVtbl.Handle;
        fixed (TextureCopyLocation* pSrcPtr = &pSrc)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)@this->LpVtbl[16])(@this, pDst, DstX, DstY, DstZ, pSrcPtr, pSrcBox);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTextureRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, TextureCopyLocation* pDst, uint DstX, uint DstY, uint DstZ, ref TextureCopyLocation pSrc, ref Box pSrcBox)
    {
        var @this = thisVtbl.Handle;
        fixed (TextureCopyLocation* pSrcPtr = &pSrc)
        {
            fixed (Box* pSrcBoxPtr = &pSrcBox)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)@this->LpVtbl[16])(@this, pDst, DstX, DstY, DstZ, pSrcPtr, pSrcBoxPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTextureRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref TextureCopyLocation pDst, uint DstX, uint DstY, uint DstZ, TextureCopyLocation* pSrc, Box* pSrcBox)
    {
        var @this = thisVtbl.Handle;
        fixed (TextureCopyLocation* pDstPtr = &pDst)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)@this->LpVtbl[16])(@this, pDstPtr, DstX, DstY, DstZ, pSrc, pSrcBox);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTextureRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref TextureCopyLocation pDst, uint DstX, uint DstY, uint DstZ, TextureCopyLocation* pSrc, ref Box pSrcBox)
    {
        var @this = thisVtbl.Handle;
        fixed (TextureCopyLocation* pDstPtr = &pDst)
        {
            fixed (Box* pSrcBoxPtr = &pSrcBox)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)@this->LpVtbl[16])(@this, pDstPtr, DstX, DstY, DstZ, pSrc, pSrcBoxPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTextureRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref TextureCopyLocation pDst, uint DstX, uint DstY, uint DstZ, ref TextureCopyLocation pSrc, Box* pSrcBox)
    {
        var @this = thisVtbl.Handle;
        fixed (TextureCopyLocation* pDstPtr = &pDst)
        {
            fixed (TextureCopyLocation* pSrcPtr = &pSrc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)@this->LpVtbl[16])(@this, pDstPtr, DstX, DstY, DstZ, pSrcPtr, pSrcBox);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void CopyTextureRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref TextureCopyLocation pDst, uint DstX, uint DstY, uint DstZ, ref TextureCopyLocation pSrc, ref Box pSrcBox)
    {
        var @this = thisVtbl.Handle;
        fixed (TextureCopyLocation* pDstPtr = &pDst)
        {
            fixed (TextureCopyLocation* pSrcPtr = &pSrc)
            {
                fixed (Box* pSrcBoxPtr = &pSrcBox)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)@this->LpVtbl[16])(@this, pDstPtr, DstX, DstY, DstZ, pSrcPtr, pSrcBoxPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyResource(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstResource, ID3D12Resource* pSrcResource)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ID3D12Resource*, void>)@this->LpVtbl[17])(@this, pDstResource, pSrcResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyResource(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstResource, ref ID3D12Resource pSrcResource)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ID3D12Resource*, void>)@this->LpVtbl[17])(@this, pDstResource, pSrcResourcePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyResource(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstResource, ID3D12Resource* pSrcResource)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ID3D12Resource*, void>)@this->LpVtbl[17])(@this, pDstResourcePtr, pSrcResource);
        }
    }

    /// <summary>To be documented.</summary>
    public static void CopyResource(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstResource, ref ID3D12Resource pSrcResource)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ID3D12Resource*, void>)@this->LpVtbl[17])(@this, pDstResourcePtr, pSrcResourcePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pBufferPtr = &pBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
        {
            fixed (ID3D12Resource* pBufferPtr = &pBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
        {
            fixed (ID3D12Resource* pBufferPtr = &pBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
        {
            fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
        {
            fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
            {
                fixed (ID3D12Resource* pBufferPtr = &pBuffer)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (ID3D12Resource* pBufferPtr = &pBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
            {
                fixed (ID3D12Resource* pBufferPtr = &pBuffer)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
            {
                fixed (ID3D12Resource* pBufferPtr = &pBuffer)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
            {
                fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void CopyTiles(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
            {
                fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                {
                    fixed (ID3D12Resource* pBufferPtr = &pBuffer)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresource(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstResource, uint DstSubresource, ID3D12Resource* pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, uint, ID3D12Resource*, uint, Silk.NET.DXGI.Format, void>)@this->LpVtbl[19])(@this, pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresource(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstResource, uint DstSubresource, ref ID3D12Resource pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, uint, ID3D12Resource*, uint, Silk.NET.DXGI.Format, void>)@this->LpVtbl[19])(@this, pDstResource, DstSubresource, pSrcResourcePtr, SrcSubresource, Format);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresource(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstResource, uint DstSubresource, ID3D12Resource* pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, uint, ID3D12Resource*, uint, Silk.NET.DXGI.Format, void>)@this->LpVtbl[19])(@this, pDstResourcePtr, DstSubresource, pSrcResource, SrcSubresource, Format);
        }
    }

    /// <summary>To be documented.</summary>
    public static void ResolveSubresource(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstResource, uint DstSubresource, ref ID3D12Resource pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, uint, ID3D12Resource*, uint, Silk.NET.DXGI.Format, void>)@this->LpVtbl[19])(@this, pDstResourcePtr, DstSubresource, pSrcResourcePtr, SrcSubresource, Format);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void IASetPrimitiveTopology(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Silk.NET.Core.Native.D3DPrimitiveTopology PrimitiveTopology)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, Silk.NET.Core.Native.D3DPrimitiveTopology, void>)@this->LpVtbl[20])(@this, PrimitiveTopology);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSSetViewports(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint NumViewports, Viewport* pViewports)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, Viewport*, void>)@this->LpVtbl[21])(@this, NumViewports, pViewports);
    }

    /// <summary>To be documented.</summary>
    public static void RSSetViewports(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint NumViewports, ref Viewport pViewports)
    {
        var @this = thisVtbl.Handle;
        fixed (Viewport* pViewportsPtr = &pViewports)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, Viewport*, void>)@this->LpVtbl[21])(@this, NumViewports, pViewportsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSSetScissorRects(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[22])(@this, NumRects, pRects);
    }

    /// <summary>To be documented.</summary>
    public static void RSSetScissorRects(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[22])(@this, NumRects, pRectsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetBlendFactor(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, [Count(Count = 4)] float* BlendFactor)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, float*, void>)@this->LpVtbl[23])(@this, BlendFactor);
    }

    /// <summary>To be documented.</summary>
    public static void OMSetBlendFactor(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, [Count(Count = 4)] ref float BlendFactor)
    {
        var @this = thisVtbl.Handle;
        fixed (float* BlendFactorPtr = &BlendFactor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, float*, void>)@this->LpVtbl[23])(@this, BlendFactorPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void OMSetStencilRef(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint StencilRef)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, void>)@this->LpVtbl[24])(@this, StencilRef);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetPipelineState(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12PipelineState* pPipelineState)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12PipelineState*, void>)@this->LpVtbl[25])(@this, pPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static void SetPipelineState(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12PipelineState pPipelineState)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12PipelineState* pPipelineStatePtr = &pPipelineState)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12PipelineState*, void>)@this->LpVtbl[25])(@this, pPipelineStatePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResourceBarrier(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint NumBarriers, ResourceBarrier* pBarriers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, ResourceBarrier*, void>)@this->LpVtbl[26])(@this, NumBarriers, pBarriers);
    }

    /// <summary>To be documented.</summary>
    public static void ResourceBarrier(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint NumBarriers, ref ResourceBarrier pBarriers)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceBarrier* pBarriersPtr = &pBarriers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, ResourceBarrier*, void>)@this->LpVtbl[26])(@this, NumBarriers, pBarriersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteBundle(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12GraphicsCommandList* pCommandList)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12GraphicsCommandList*, void>)@this->LpVtbl[27])(@this, pCommandList);
    }

    /// <summary>To be documented.</summary>
    public static void ExecuteBundle(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12GraphicsCommandList pCommandList)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12GraphicsCommandList* pCommandListPtr = &pCommandList)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12GraphicsCommandList*, void>)@this->LpVtbl[27])(@this, pCommandListPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetDescriptorHeaps(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint NumDescriptorHeaps, ID3D12DescriptorHeap** ppDescriptorHeaps)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, ID3D12DescriptorHeap**, void>)@this->LpVtbl[28])(@this, NumDescriptorHeaps, ppDescriptorHeaps);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetDescriptorHeaps(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint NumDescriptorHeaps, ref ID3D12DescriptorHeap* ppDescriptorHeaps)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12DescriptorHeap** ppDescriptorHeapsPtr = &ppDescriptorHeaps)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, ID3D12DescriptorHeap**, void>)@this->LpVtbl[28])(@this, NumDescriptorHeaps, ppDescriptorHeapsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetComputeRootSignature(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12RootSignature* pRootSignature)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12RootSignature*, void>)@this->LpVtbl[29])(@this, pRootSignature);
    }

    /// <summary>To be documented.</summary>
    public static void SetComputeRootSignature(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12RootSignature pRootSignature)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12RootSignature*, void>)@this->LpVtbl[29])(@this, pRootSignaturePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetGraphicsRootSignature(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12RootSignature* pRootSignature)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12RootSignature*, void>)@this->LpVtbl[30])(@this, pRootSignature);
    }

    /// <summary>To be documented.</summary>
    public static void SetGraphicsRootSignature(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12RootSignature pRootSignature)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12RootSignature*, void>)@this->LpVtbl[30])(@this, pRootSignaturePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void SetComputeRootDescriptorTable(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint RootParameterIndex, GpuDescriptorHandle BaseDescriptor)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, GpuDescriptorHandle, void>)@this->LpVtbl[31])(@this, RootParameterIndex, BaseDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static void SetGraphicsRootDescriptorTable(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint RootParameterIndex, GpuDescriptorHandle BaseDescriptor)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, GpuDescriptorHandle, void>)@this->LpVtbl[32])(@this, RootParameterIndex, BaseDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static void SetComputeRoot32BitConstant(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint RootParameterIndex, uint SrcData, uint DestOffsetIn32BitValues)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, uint, uint, void>)@this->LpVtbl[33])(@this, RootParameterIndex, SrcData, DestOffsetIn32BitValues);
    }

    /// <summary>To be documented.</summary>
    public static void SetGraphicsRoot32BitConstant(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint RootParameterIndex, uint SrcData, uint DestOffsetIn32BitValues)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, uint, uint, void>)@this->LpVtbl[34])(@this, RootParameterIndex, SrcData, DestOffsetIn32BitValues);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetComputeRoot32BitConstants(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint RootParameterIndex, uint Num32BitValuesToSet, void* pSrcData, uint DestOffsetIn32BitValues)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, uint, void*, uint, void>)@this->LpVtbl[35])(@this, RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
    }

    /// <summary>To be documented.</summary>
    public static void SetComputeRoot32BitConstants<T0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint RootParameterIndex, uint Num32BitValuesToSet, ref T0 pSrcData, uint DestOffsetIn32BitValues) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* pSrcDataPtr = &pSrcData)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, uint, void*, uint, void>)@this->LpVtbl[35])(@this, RootParameterIndex, Num32BitValuesToSet, pSrcDataPtr, DestOffsetIn32BitValues);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetGraphicsRoot32BitConstants(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint RootParameterIndex, uint Num32BitValuesToSet, void* pSrcData, uint DestOffsetIn32BitValues)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, uint, void*, uint, void>)@this->LpVtbl[36])(@this, RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
    }

    /// <summary>To be documented.</summary>
    public static void SetGraphicsRoot32BitConstants<T0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint RootParameterIndex, uint Num32BitValuesToSet, ref T0 pSrcData, uint DestOffsetIn32BitValues) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* pSrcDataPtr = &pSrcData)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, uint, void*, uint, void>)@this->LpVtbl[36])(@this, RootParameterIndex, Num32BitValuesToSet, pSrcDataPtr, DestOffsetIn32BitValues);
        }
    }

    /// <summary>To be documented.</summary>
    public static void SetComputeRootConstantBufferView(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint RootParameterIndex, ulong BufferLocation)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, ulong, void>)@this->LpVtbl[37])(@this, RootParameterIndex, BufferLocation);
    }

    /// <summary>To be documented.</summary>
    public static void SetGraphicsRootConstantBufferView(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint RootParameterIndex, ulong BufferLocation)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, ulong, void>)@this->LpVtbl[38])(@this, RootParameterIndex, BufferLocation);
    }

    /// <summary>To be documented.</summary>
    public static void SetComputeRootShaderResourceView(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint RootParameterIndex, ulong BufferLocation)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, ulong, void>)@this->LpVtbl[39])(@this, RootParameterIndex, BufferLocation);
    }

    /// <summary>To be documented.</summary>
    public static void SetGraphicsRootShaderResourceView(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint RootParameterIndex, ulong BufferLocation)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, ulong, void>)@this->LpVtbl[40])(@this, RootParameterIndex, BufferLocation);
    }

    /// <summary>To be documented.</summary>
    public static void SetComputeRootUnorderedAccessView(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint RootParameterIndex, ulong BufferLocation)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, ulong, void>)@this->LpVtbl[41])(@this, RootParameterIndex, BufferLocation);
    }

    /// <summary>To be documented.</summary>
    public static void SetGraphicsRootUnorderedAccessView(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint RootParameterIndex, ulong BufferLocation)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, ulong, void>)@this->LpVtbl[42])(@this, RootParameterIndex, BufferLocation);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetIndexBuffer(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, IndexBufferView* pView)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, IndexBufferView*, void>)@this->LpVtbl[43])(@this, pView);
    }

    /// <summary>To be documented.</summary>
    public static void IASetIndexBuffer(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref IndexBufferView pView)
    {
        var @this = thisVtbl.Handle;
        fixed (IndexBufferView* pViewPtr = &pView)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, IndexBufferView*, void>)@this->LpVtbl[43])(@this, pViewPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint StartSlot, uint NumViews, VertexBufferView* pViews)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, uint, VertexBufferView*, void>)@this->LpVtbl[44])(@this, StartSlot, NumViews, pViews);
    }

    /// <summary>To be documented.</summary>
    public static void IASetVertexBuffers(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint StartSlot, uint NumViews, ref VertexBufferView pViews)
    {
        var @this = thisVtbl.Handle;
        fixed (VertexBufferView* pViewsPtr = &pViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, uint, VertexBufferView*, void>)@this->LpVtbl[44])(@this, StartSlot, NumViews, pViewsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SOSetTargets(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint StartSlot, uint NumViews, StreamOutputBufferView* pViews)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, uint, StreamOutputBufferView*, void>)@this->LpVtbl[45])(@this, StartSlot, NumViews, pViews);
    }

    /// <summary>To be documented.</summary>
    public static void SOSetTargets(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint StartSlot, uint NumViews, ref StreamOutputBufferView pViews)
    {
        var @this = thisVtbl.Handle;
        fixed (StreamOutputBufferView* pViewsPtr = &pViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, uint, StreamOutputBufferView*, void>)@this->LpVtbl[45])(@this, StartSlot, NumViews, pViewsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargets(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint NumRenderTargetDescriptors, CpuDescriptorHandle* pRenderTargetDescriptors, int RTsSingleHandleToDescriptorRange, CpuDescriptorHandle* pDepthStencilDescriptor)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, CpuDescriptorHandle*, int, CpuDescriptorHandle*, void>)@this->LpVtbl[46])(@this, NumRenderTargetDescriptors, pRenderTargetDescriptors, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargets(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint NumRenderTargetDescriptors, CpuDescriptorHandle* pRenderTargetDescriptors, int RTsSingleHandleToDescriptorRange, ref CpuDescriptorHandle pDepthStencilDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (CpuDescriptorHandle* pDepthStencilDescriptorPtr = &pDepthStencilDescriptor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, CpuDescriptorHandle*, int, CpuDescriptorHandle*, void>)@this->LpVtbl[46])(@this, NumRenderTargetDescriptors, pRenderTargetDescriptors, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptorPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargets(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint NumRenderTargetDescriptors, ref CpuDescriptorHandle pRenderTargetDescriptors, int RTsSingleHandleToDescriptorRange, CpuDescriptorHandle* pDepthStencilDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (CpuDescriptorHandle* pRenderTargetDescriptorsPtr = &pRenderTargetDescriptors)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, CpuDescriptorHandle*, int, CpuDescriptorHandle*, void>)@this->LpVtbl[46])(@this, NumRenderTargetDescriptors, pRenderTargetDescriptorsPtr, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static void OMSetRenderTargets(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint NumRenderTargetDescriptors, ref CpuDescriptorHandle pRenderTargetDescriptors, int RTsSingleHandleToDescriptorRange, ref CpuDescriptorHandle pDepthStencilDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (CpuDescriptorHandle* pRenderTargetDescriptorsPtr = &pRenderTargetDescriptors)
        {
            fixed (CpuDescriptorHandle* pDepthStencilDescriptorPtr = &pDepthStencilDescriptor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, CpuDescriptorHandle*, int, CpuDescriptorHandle*, void>)@this->LpVtbl[46])(@this, NumRenderTargetDescriptors, pRenderTargetDescriptorsPtr, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptorPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearDepthStencilView(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, CpuDescriptorHandle DepthStencilView, ClearFlags ClearFlags, float Depth, byte Stencil, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, CpuDescriptorHandle, ClearFlags, float, byte, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[47])(@this, DepthStencilView, ClearFlags, Depth, Stencil, NumRects, pRects);
    }

    /// <summary>To be documented.</summary>
    public static void ClearDepthStencilView(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, CpuDescriptorHandle DepthStencilView, ClearFlags ClearFlags, float Depth, byte Stencil, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, CpuDescriptorHandle, ClearFlags, float, byte, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[47])(@this, DepthStencilView, ClearFlags, Depth, Stencil, NumRects, pRectsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearRenderTargetView(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, CpuDescriptorHandle RenderTargetView, [Count(Count = 4)] float* ColorRGBA, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, CpuDescriptorHandle, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[48])(@this, RenderTargetView, ColorRGBA, NumRects, pRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearRenderTargetView(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, CpuDescriptorHandle RenderTargetView, [Count(Count = 4)] float* ColorRGBA, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, CpuDescriptorHandle, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[48])(@this, RenderTargetView, ColorRGBA, NumRects, pRectsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearRenderTargetView(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, CpuDescriptorHandle RenderTargetView, [Count(Count = 4)] ref float ColorRGBA, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects)
    {
        var @this = thisVtbl.Handle;
        fixed (float* ColorRGBAPtr = &ColorRGBA)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, CpuDescriptorHandle, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[48])(@this, RenderTargetView, ColorRGBAPtr, NumRects, pRects);
        }
    }

    /// <summary>To be documented.</summary>
    public static void ClearRenderTargetView(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, CpuDescriptorHandle RenderTargetView, [Count(Count = 4)] ref float ColorRGBA, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects)
    {
        var @this = thisVtbl.Handle;
        fixed (float* ColorRGBAPtr = &ColorRGBA)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, CpuDescriptorHandle, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[48])(@this, RenderTargetView, ColorRGBAPtr, NumRects, pRectsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] uint* Values, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] uint* Values, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRectsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] ref uint Values, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* ValuesPtr = &Values)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, ValuesPtr, NumRects, pRects);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] ref uint Values, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* ValuesPtr = &Values)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, ValuesPtr, NumRects, pRectsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] uint* Values, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, Values, NumRects, pRects);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] uint* Values, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, Values, NumRects, pRectsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] ref uint Values, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (uint* ValuesPtr = &Values)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, ValuesPtr, NumRects, pRects);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void ClearUnorderedAccessViewUint(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] ref uint Values, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (uint* ValuesPtr = &Values)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, ValuesPtr, NumRects, pRectsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] float* Values, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] float* Values, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRectsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] ref float Values, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects)
    {
        var @this = thisVtbl.Handle;
        fixed (float* ValuesPtr = &Values)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, ValuesPtr, NumRects, pRects);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] ref float Values, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects)
    {
        var @this = thisVtbl.Handle;
        fixed (float* ValuesPtr = &Values)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, ValuesPtr, NumRects, pRectsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] float* Values, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, Values, NumRects, pRects);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] float* Values, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, Values, NumRects, pRectsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] ref float Values, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (float* ValuesPtr = &Values)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, ValuesPtr, NumRects, pRects);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void ClearUnorderedAccessViewFloat(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] ref float Values, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (float* ValuesPtr = &Values)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, ValuesPtr, NumRects, pRectsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardResource(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pResource, DiscardRegion* pRegion)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[51])(@this, pResource, pRegion);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardResource(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pResource, ref DiscardRegion pRegion)
    {
        var @this = thisVtbl.Handle;
        fixed (DiscardRegion* pRegionPtr = &pRegion)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[51])(@this, pResource, pRegionPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardResource(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pResource, DiscardRegion* pRegion)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[51])(@this, pResourcePtr, pRegion);
        }
    }

    /// <summary>To be documented.</summary>
    public static void DiscardResource(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pResource, ref DiscardRegion pRegion)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (DiscardRegion* pRegionPtr = &pRegion)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[51])(@this, pResourcePtr, pRegionPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void BeginQuery(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[52])(@this, pQueryHeap, Type, Index);
    }

    /// <summary>To be documented.</summary>
    public static void BeginQuery(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint Index)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[52])(@this, pQueryHeapPtr, Type, Index);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EndQuery(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[53])(@this, pQueryHeap, Type, Index);
    }

    /// <summary>To be documented.</summary>
    public static void EndQuery(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint Index)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[53])(@this, pQueryHeapPtr, Type, Index);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveQueryData(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[54])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveQueryData(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDestinationBufferPtr = &pDestinationBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[54])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveQueryData(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[54])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
        }
    }

    /// <summary>To be documented.</summary>
    public static void ResolveQueryData(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
        {
            fixed (ID3D12Resource* pDestinationBufferPtr = &pDestinationBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[54])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetPredication(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pBuffer, ulong AlignedBufferOffset, PredicationOp Operation)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, PredicationOp, void>)@this->LpVtbl[55])(@this, pBuffer, AlignedBufferOffset, Operation);
    }

    /// <summary>To be documented.</summary>
    public static void SetPredication(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pBuffer, ulong AlignedBufferOffset, PredicationOp Operation)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pBufferPtr = &pBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, PredicationOp, void>)@this->LpVtbl[55])(@this, pBufferPtr, AlignedBufferOffset, Operation);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetMarker(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint Metadata, void* pData, uint Size)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, void*, uint, void>)@this->LpVtbl[56])(@this, Metadata, pData, Size);
    }

    /// <summary>To be documented.</summary>
    public static void SetMarker<T0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint Metadata, ref T0 pData, uint Size) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* pDataPtr = &pData)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, void*, uint, void>)@this->LpVtbl[56])(@this, Metadata, pDataPtr, Size);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void BeginEvent(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint Metadata, void* pData, uint Size)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, void*, uint, void>)@this->LpVtbl[57])(@this, Metadata, pData, Size);
    }

    /// <summary>To be documented.</summary>
    public static void BeginEvent<T0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint Metadata, ref T0 pData, uint Size) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* pDataPtr = &pData)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, void*, uint, void>)@this->LpVtbl[57])(@this, Metadata, pDataPtr, Size);
        }
    }

    /// <summary>To be documented.</summary>
    public static void EndEvent(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, void>)@this->LpVtbl[58])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteIndirect(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12CommandSignature* pCommandSignature, uint MaxCommandCount, ID3D12Resource* pArgumentBuffer, ulong ArgumentBufferOffset, ID3D12Resource* pCountBuffer, ulong CountBufferOffset)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)@this->LpVtbl[59])(@this, pCommandSignature, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteIndirect(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12CommandSignature* pCommandSignature, uint MaxCommandCount, ID3D12Resource* pArgumentBuffer, ulong ArgumentBufferOffset, ref ID3D12Resource pCountBuffer, ulong CountBufferOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pCountBufferPtr = &pCountBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)@this->LpVtbl[59])(@this, pCommandSignature, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBufferPtr, CountBufferOffset);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteIndirect(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12CommandSignature* pCommandSignature, uint MaxCommandCount, ref ID3D12Resource pArgumentBuffer, ulong ArgumentBufferOffset, ID3D12Resource* pCountBuffer, ulong CountBufferOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pArgumentBufferPtr = &pArgumentBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)@this->LpVtbl[59])(@this, pCommandSignature, MaxCommandCount, pArgumentBufferPtr, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteIndirect(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12CommandSignature* pCommandSignature, uint MaxCommandCount, ref ID3D12Resource pArgumentBuffer, ulong ArgumentBufferOffset, ref ID3D12Resource pCountBuffer, ulong CountBufferOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pArgumentBufferPtr = &pArgumentBuffer)
        {
            fixed (ID3D12Resource* pCountBufferPtr = &pCountBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)@this->LpVtbl[59])(@this, pCommandSignature, MaxCommandCount, pArgumentBufferPtr, ArgumentBufferOffset, pCountBufferPtr, CountBufferOffset);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteIndirect(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12CommandSignature pCommandSignature, uint MaxCommandCount, ID3D12Resource* pArgumentBuffer, ulong ArgumentBufferOffset, ID3D12Resource* pCountBuffer, ulong CountBufferOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12CommandSignature* pCommandSignaturePtr = &pCommandSignature)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)@this->LpVtbl[59])(@this, pCommandSignaturePtr, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteIndirect(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12CommandSignature pCommandSignature, uint MaxCommandCount, ID3D12Resource* pArgumentBuffer, ulong ArgumentBufferOffset, ref ID3D12Resource pCountBuffer, ulong CountBufferOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12CommandSignature* pCommandSignaturePtr = &pCommandSignature)
        {
            fixed (ID3D12Resource* pCountBufferPtr = &pCountBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)@this->LpVtbl[59])(@this, pCommandSignaturePtr, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBufferPtr, CountBufferOffset);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteIndirect(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12CommandSignature pCommandSignature, uint MaxCommandCount, ref ID3D12Resource pArgumentBuffer, ulong ArgumentBufferOffset, ID3D12Resource* pCountBuffer, ulong CountBufferOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12CommandSignature* pCommandSignaturePtr = &pCommandSignature)
        {
            fixed (ID3D12Resource* pArgumentBufferPtr = &pArgumentBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)@this->LpVtbl[59])(@this, pCommandSignaturePtr, MaxCommandCount, pArgumentBufferPtr, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void ExecuteIndirect(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12CommandSignature pCommandSignature, uint MaxCommandCount, ref ID3D12Resource pArgumentBuffer, ulong ArgumentBufferOffset, ref ID3D12Resource pCountBuffer, ulong CountBufferOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12CommandSignature* pCommandSignaturePtr = &pCommandSignature)
        {
            fixed (ID3D12Resource* pArgumentBufferPtr = &pArgumentBuffer)
            {
                fixed (ID3D12Resource* pCountBufferPtr = &pCountBuffer)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)@this->LpVtbl[59])(@this, pCommandSignaturePtr, MaxCommandCount, pArgumentBufferPtr, ArgumentBufferOffset, pCountBufferPtr, CountBufferOffset);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
        {
            fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
        {
            fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
        {
            fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
        {
            fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
            {
                fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
            {
                fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
                fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
                fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
                fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
                {
                    fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
        {
            fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
        {
            fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
        {
            fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
        {
            fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
            {
                fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
            {
                fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
                fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
                fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
                fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
                {
                    fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void OMSetDepthBounds(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, float Min, float Max)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, float, float, void>)@this->LpVtbl[62])(@this, Min, Max);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetSamplePositions(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint NumSamplesPerPixel, uint NumPixels, SamplePosition* pSamplePositions)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, uint, SamplePosition*, void>)@this->LpVtbl[63])(@this, NumSamplesPerPixel, NumPixels, pSamplePositions);
    }

    /// <summary>To be documented.</summary>
    public static void SetSamplePositions(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint NumSamplesPerPixel, uint NumPixels, ref SamplePosition pSamplePositions)
    {
        var @this = thisVtbl.Handle;
        fixed (SamplePosition* pSamplePositionsPtr = &pSamplePositions)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, uint, SamplePosition*, void>)@this->LpVtbl[63])(@this, NumSamplesPerPixel, NumPixels, pSamplePositionsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresourceRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, ID3D12Resource* pSrcResource, uint SrcSubresource, Silk.NET.Maths.Rectangle<int>* pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)@this->LpVtbl[64])(@this, pDstResource, DstSubresource, DstX, DstY, pSrcResource, SrcSubresource, pSrcRect, Format, ResolveMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresourceRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, ID3D12Resource* pSrcResource, uint SrcSubresource, ref Silk.NET.Maths.Rectangle<int> pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Rectangle<int>* pSrcRectPtr = &pSrcRect)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)@this->LpVtbl[64])(@this, pDstResource, DstSubresource, DstX, DstY, pSrcResource, SrcSubresource, pSrcRectPtr, Format, ResolveMode);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresourceRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, ref ID3D12Resource pSrcResource, uint SrcSubresource, Silk.NET.Maths.Rectangle<int>* pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)@this->LpVtbl[64])(@this, pDstResource, DstSubresource, DstX, DstY, pSrcResourcePtr, SrcSubresource, pSrcRect, Format, ResolveMode);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresourceRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, ref ID3D12Resource pSrcResource, uint SrcSubresource, ref Silk.NET.Maths.Rectangle<int> pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pSrcRectPtr = &pSrcRect)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)@this->LpVtbl[64])(@this, pDstResource, DstSubresource, DstX, DstY, pSrcResourcePtr, SrcSubresource, pSrcRectPtr, Format, ResolveMode);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresourceRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, ID3D12Resource* pSrcResource, uint SrcSubresource, Silk.NET.Maths.Rectangle<int>* pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)@this->LpVtbl[64])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, pSrcResource, SrcSubresource, pSrcRect, Format, ResolveMode);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresourceRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, ID3D12Resource* pSrcResource, uint SrcSubresource, ref Silk.NET.Maths.Rectangle<int> pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pSrcRectPtr = &pSrcRect)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)@this->LpVtbl[64])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, pSrcResource, SrcSubresource, pSrcRectPtr, Format, ResolveMode);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresourceRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, ref ID3D12Resource pSrcResource, uint SrcSubresource, Silk.NET.Maths.Rectangle<int>* pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)@this->LpVtbl[64])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, pSrcResourcePtr, SrcSubresource, pSrcRect, Format, ResolveMode);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void ResolveSubresourceRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, ref ID3D12Resource pSrcResource, uint SrcSubresource, ref Silk.NET.Maths.Rectangle<int> pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pSrcRectPtr = &pSrcRect)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)@this->LpVtbl[64])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, pSrcResourcePtr, SrcSubresource, pSrcRectPtr, Format, ResolveMode);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void SetViewInstanceMask(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint Mask)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, void>)@this->LpVtbl[65])(@this, Mask);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void WriteBufferImmediate(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint Count, WritebufferimmediateParameter* pParams, WritebufferimmediateMode* pModes)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[66])(@this, Count, pParams, pModes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void WriteBufferImmediate(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint Count, WritebufferimmediateParameter* pParams, ref WritebufferimmediateMode pModes)
    {
        var @this = thisVtbl.Handle;
        fixed (WritebufferimmediateMode* pModesPtr = &pModes)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[66])(@this, Count, pParams, pModesPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void WriteBufferImmediate(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint Count, ref WritebufferimmediateParameter pParams, WritebufferimmediateMode* pModes)
    {
        var @this = thisVtbl.Handle;
        fixed (WritebufferimmediateParameter* pParamsPtr = &pParams)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[66])(@this, Count, pParamsPtr, pModes);
        }
    }

    /// <summary>To be documented.</summary>
    public static void WriteBufferImmediate(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint Count, ref WritebufferimmediateParameter pParams, ref WritebufferimmediateMode pModes)
    {
        var @this = thisVtbl.Handle;
        fixed (WritebufferimmediateParameter* pParamsPtr = &pParams)
        {
            fixed (WritebufferimmediateMode* pModesPtr = &pModes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[66])(@this, Count, pParamsPtr, pModesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Guid* guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Guid* guid, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Guid* guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<Guid> guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<Guid> guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<Guid> guid, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<Guid> guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Guid* guid, uint DataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(guid, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<Guid> guid, uint DataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<Guid> guid, uint DataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Guid* guid, [Flow(FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Guid* guid, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(guid, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<Guid> guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(ref guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<Guid> guid, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetName(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<char> Name)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetName(ref Name.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDevice<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, out ComPtr<TI0> ppvDevice) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvDevice = default;
        return @this->GetDevice(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<Guid> riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDevice(ref riid.GetPinnableReference(), ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<Guid> riid, ref void* ppvDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDevice(ref riid.GetPinnableReference(), ref ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static int Reset<TI0, TI1>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pAllocator, ComPtr<TI1> pInitialState) where TI0 : unmanaged, IComVtbl<ID3D12CommandAllocator>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12PipelineState>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Reset((ID3D12CommandAllocator*) pAllocator.Handle, (ID3D12PipelineState*) pInitialState.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Reset(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12CommandAllocator* pAllocator, Span<ID3D12PipelineState> pInitialState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Reset(pAllocator, ref pInitialState.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Reset<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pAllocator, ref ID3D12PipelineState pInitialState) where TI0 : unmanaged, IComVtbl<ID3D12CommandAllocator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Reset((ID3D12CommandAllocator*) pAllocator.Handle, ref pInitialState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Reset(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12CommandAllocator> pAllocator, ID3D12PipelineState* pInitialState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Reset(ref pAllocator.GetPinnableReference(), pInitialState);
    }

    /// <summary>To be documented.</summary>
    public static int Reset<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12CommandAllocator pAllocator, ComPtr<TI0> pInitialState) where TI0 : unmanaged, IComVtbl<ID3D12PipelineState>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Reset(ref pAllocator, (ID3D12PipelineState*) pInitialState.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int Reset(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12CommandAllocator> pAllocator, Span<ID3D12PipelineState> pInitialState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Reset(ref pAllocator.GetPinnableReference(), ref pInitialState.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void ClearState<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pPipelineState) where TI0 : unmanaged, IComVtbl<ID3D12PipelineState>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ClearState((ID3D12PipelineState*) pPipelineState.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void ClearState(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12PipelineState> pPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClearState(ref pPipelineState.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void CopyBufferRegion<TI0, TI1>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pDstBuffer, ulong DstOffset, ComPtr<TI1> pSrcBuffer, ulong SrcOffset, ulong NumBytes) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyBufferRegion((ID3D12Resource*) pDstBuffer.Handle, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, NumBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyBufferRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, Span<ID3D12Resource> pSrcBuffer, ulong SrcOffset, ulong NumBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyBufferRegion(pDstBuffer, DstOffset, ref pSrcBuffer.GetPinnableReference(), SrcOffset, NumBytes);
    }

    /// <summary>To be documented.</summary>
    public static void CopyBufferRegion<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, ulong NumBytes) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyBufferRegion((ID3D12Resource*) pDstBuffer.Handle, DstOffset, ref pSrcBuffer, SrcOffset, NumBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyBufferRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, ulong NumBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyBufferRegion(ref pDstBuffer.GetPinnableReference(), DstOffset, pSrcBuffer, SrcOffset, NumBytes);
    }

    /// <summary>To be documented.</summary>
    public static void CopyBufferRegion<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ComPtr<TI0> pSrcBuffer, ulong SrcOffset, ulong NumBytes) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyBufferRegion(ref pDstBuffer, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, NumBytes);
    }

    /// <summary>To be documented.</summary>
    public static void CopyBufferRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pDstBuffer, ulong DstOffset, Span<ID3D12Resource> pSrcBuffer, ulong SrcOffset, ulong NumBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyBufferRegion(ref pDstBuffer.GetPinnableReference(), DstOffset, ref pSrcBuffer.GetPinnableReference(), SrcOffset, NumBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTextureRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, TextureCopyLocation* pDst, uint DstX, uint DstY, uint DstZ, TextureCopyLocation* pSrc, Span<Box> pSrcBox)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTextureRegion(pDst, DstX, DstY, DstZ, pSrc, ref pSrcBox.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTextureRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, TextureCopyLocation* pDst, uint DstX, uint DstY, uint DstZ, Span<TextureCopyLocation> pSrc, Box* pSrcBox)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTextureRegion(pDst, DstX, DstY, DstZ, ref pSrc.GetPinnableReference(), pSrcBox);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTextureRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, TextureCopyLocation* pDst, uint DstX, uint DstY, uint DstZ, Span<TextureCopyLocation> pSrc, Span<Box> pSrcBox)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTextureRegion(pDst, DstX, DstY, DstZ, ref pSrc.GetPinnableReference(), ref pSrcBox.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTextureRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<TextureCopyLocation> pDst, uint DstX, uint DstY, uint DstZ, TextureCopyLocation* pSrc, Box* pSrcBox)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTextureRegion(ref pDst.GetPinnableReference(), DstX, DstY, DstZ, pSrc, pSrcBox);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTextureRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<TextureCopyLocation> pDst, uint DstX, uint DstY, uint DstZ, TextureCopyLocation* pSrc, Span<Box> pSrcBox)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTextureRegion(ref pDst.GetPinnableReference(), DstX, DstY, DstZ, pSrc, ref pSrcBox.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTextureRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<TextureCopyLocation> pDst, uint DstX, uint DstY, uint DstZ, Span<TextureCopyLocation> pSrc, Box* pSrcBox)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTextureRegion(ref pDst.GetPinnableReference(), DstX, DstY, DstZ, ref pSrc.GetPinnableReference(), pSrcBox);
    }

    /// <summary>To be documented.</summary>
    public static void CopyTextureRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<TextureCopyLocation> pDst, uint DstX, uint DstY, uint DstZ, Span<TextureCopyLocation> pSrc, Span<Box> pSrcBox)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTextureRegion(ref pDst.GetPinnableReference(), DstX, DstY, DstZ, ref pSrc.GetPinnableReference(), ref pSrcBox.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void CopyResource<TI0, TI1>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pDstResource, ComPtr<TI1> pSrcResource) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyResource((ID3D12Resource*) pDstResource.Handle, (ID3D12Resource*) pSrcResource.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyResource(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstResource, Span<ID3D12Resource> pSrcResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyResource(pDstResource, ref pSrcResource.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void CopyResource<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pDstResource, ref ID3D12Resource pSrcResource) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyResource((ID3D12Resource*) pDstResource.Handle, ref pSrcResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyResource(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pDstResource, ID3D12Resource* pSrcResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyResource(ref pDstResource.GetPinnableReference(), pSrcResource);
    }

    /// <summary>To be documented.</summary>
    public static void CopyResource<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstResource, ComPtr<TI0> pSrcResource) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyResource(ref pDstResource, (ID3D12Resource*) pSrcResource.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void CopyResource(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pDstResource, Span<ID3D12Resource> pSrcResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyResource(ref pDstResource.GetPinnableReference(), ref pSrcResource.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TI0, TI1>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ComPtr<TI1> pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTiles((ID3D12Resource*) pTiledResource.Handle, pTileRegionStartCoordinate, pTileRegionSize, (ID3D12Resource*) pBuffer.Handle, BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, Span<ID3D12Resource> pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTiles(pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, ref pBuffer.GetPinnableReference(), BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTiles((ID3D12Resource*) pTiledResource.Handle, pTileRegionStartCoordinate, pTileRegionSize, ref pBuffer, BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, Span<TileRegionSize> pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTiles(pTiledResource, pTileRegionStartCoordinate, ref pTileRegionSize.GetPinnableReference(), pBuffer, BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TI0, TI1>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ComPtr<TI1> pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTiles((ID3D12Resource*) pTiledResource.Handle, pTileRegionStartCoordinate, ref pTileRegionSize, (ID3D12Resource*) pBuffer.Handle, BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, Span<TileRegionSize> pTileRegionSize, Span<ID3D12Resource> pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTiles(pTiledResource, pTileRegionStartCoordinate, ref pTileRegionSize.GetPinnableReference(), ref pBuffer.GetPinnableReference(), BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTiles((ID3D12Resource*) pTiledResource.Handle, pTileRegionStartCoordinate, ref pTileRegionSize, ref pBuffer, BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pTiledResource, Span<TiledResourceCoordinate> pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTiles(pTiledResource, ref pTileRegionStartCoordinate.GetPinnableReference(), pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TI0, TI1>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ComPtr<TI1> pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTiles((ID3D12Resource*) pTiledResource.Handle, ref pTileRegionStartCoordinate, pTileRegionSize, (ID3D12Resource*) pBuffer.Handle, BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pTiledResource, Span<TiledResourceCoordinate> pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, Span<ID3D12Resource> pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTiles(pTiledResource, ref pTileRegionStartCoordinate.GetPinnableReference(), pTileRegionSize, ref pBuffer.GetPinnableReference(), BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTiles((ID3D12Resource*) pTiledResource.Handle, ref pTileRegionStartCoordinate, pTileRegionSize, ref pBuffer, BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pTiledResource, Span<TiledResourceCoordinate> pTileRegionStartCoordinate, Span<TileRegionSize> pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTiles(pTiledResource, ref pTileRegionStartCoordinate.GetPinnableReference(), ref pTileRegionSize.GetPinnableReference(), pBuffer, BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static void CopyTiles<TI0, TI1>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ComPtr<TI1> pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTiles((ID3D12Resource*) pTiledResource.Handle, ref pTileRegionStartCoordinate, ref pTileRegionSize, (ID3D12Resource*) pBuffer.Handle, BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pTiledResource, Span<TiledResourceCoordinate> pTileRegionStartCoordinate, Span<TileRegionSize> pTileRegionSize, Span<ID3D12Resource> pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTiles(pTiledResource, ref pTileRegionStartCoordinate.GetPinnableReference(), ref pTileRegionSize.GetPinnableReference(), ref pBuffer.GetPinnableReference(), BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static void CopyTiles<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTiles((ID3D12Resource*) pTiledResource.Handle, ref pTileRegionStartCoordinate, ref pTileRegionSize, ref pBuffer, BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTiles(ref pTiledResource.GetPinnableReference(), pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ComPtr<TI0> pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTiles(ref pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, (ID3D12Resource*) pBuffer.Handle, BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, Span<ID3D12Resource> pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTiles(ref pTiledResource.GetPinnableReference(), pTileRegionStartCoordinate, pTileRegionSize, ref pBuffer.GetPinnableReference(), BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, Span<TileRegionSize> pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTiles(ref pTiledResource.GetPinnableReference(), pTileRegionStartCoordinate, ref pTileRegionSize.GetPinnableReference(), pBuffer, BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ComPtr<TI0> pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTiles(ref pTiledResource, pTileRegionStartCoordinate, ref pTileRegionSize, (ID3D12Resource*) pBuffer.Handle, BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, Span<TileRegionSize> pTileRegionSize, Span<ID3D12Resource> pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTiles(ref pTiledResource.GetPinnableReference(), pTileRegionStartCoordinate, ref pTileRegionSize.GetPinnableReference(), ref pBuffer.GetPinnableReference(), BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<TiledResourceCoordinate> pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTiles(ref pTiledResource.GetPinnableReference(), ref pTileRegionStartCoordinate.GetPinnableReference(), pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ComPtr<TI0> pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTiles(ref pTiledResource, ref pTileRegionStartCoordinate, pTileRegionSize, (ID3D12Resource*) pBuffer.Handle, BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<TiledResourceCoordinate> pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, Span<ID3D12Resource> pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTiles(ref pTiledResource.GetPinnableReference(), ref pTileRegionStartCoordinate.GetPinnableReference(), pTileRegionSize, ref pBuffer.GetPinnableReference(), BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<TiledResourceCoordinate> pTileRegionStartCoordinate, Span<TileRegionSize> pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTiles(ref pTiledResource.GetPinnableReference(), ref pTileRegionStartCoordinate.GetPinnableReference(), ref pTileRegionSize.GetPinnableReference(), pBuffer, BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static void CopyTiles<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ComPtr<TI0> pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTiles(ref pTiledResource, ref pTileRegionStartCoordinate, ref pTileRegionSize, (ID3D12Resource*) pBuffer.Handle, BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static void CopyTiles(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<TiledResourceCoordinate> pTileRegionStartCoordinate, Span<TileRegionSize> pTileRegionSize, Span<ID3D12Resource> pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTiles(ref pTiledResource.GetPinnableReference(), ref pTileRegionStartCoordinate.GetPinnableReference(), ref pTileRegionSize.GetPinnableReference(), ref pBuffer.GetPinnableReference(), BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static void ResolveSubresource<TI0, TI1>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pDstResource, uint DstSubresource, ComPtr<TI1> pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ResolveSubresource((ID3D12Resource*) pDstResource.Handle, DstSubresource, (ID3D12Resource*) pSrcResource.Handle, SrcSubresource, Format);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresource(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstResource, uint DstSubresource, Span<ID3D12Resource> pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResolveSubresource(pDstResource, DstSubresource, ref pSrcResource.GetPinnableReference(), SrcSubresource, Format);
    }

    /// <summary>To be documented.</summary>
    public static void ResolveSubresource<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pDstResource, uint DstSubresource, ref ID3D12Resource pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ResolveSubresource((ID3D12Resource*) pDstResource.Handle, DstSubresource, ref pSrcResource, SrcSubresource, Format);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresource(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pDstResource, uint DstSubresource, ID3D12Resource* pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResolveSubresource(ref pDstResource.GetPinnableReference(), DstSubresource, pSrcResource, SrcSubresource, Format);
    }

    /// <summary>To be documented.</summary>
    public static void ResolveSubresource<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstResource, uint DstSubresource, ComPtr<TI0> pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ResolveSubresource(ref pDstResource, DstSubresource, (ID3D12Resource*) pSrcResource.Handle, SrcSubresource, Format);
    }

    /// <summary>To be documented.</summary>
    public static void ResolveSubresource(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pDstResource, uint DstSubresource, Span<ID3D12Resource> pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResolveSubresource(ref pDstResource.GetPinnableReference(), DstSubresource, ref pSrcResource.GetPinnableReference(), SrcSubresource, Format);
    }

    /// <summary>To be documented.</summary>
    public static void RSSetViewports(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint NumViewports, Span<Viewport> pViewports)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->RSSetViewports(NumViewports, ref pViewports.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void RSSetScissorRects(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint NumRects, Span<Silk.NET.Maths.Rectangle<int>> pRects)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->RSSetScissorRects(NumRects, ref pRects.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void OMSetBlendFactor(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, [Count(Count = 4)] Span<float> BlendFactor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->OMSetBlendFactor(ref BlendFactor.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SetPipelineState<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pPipelineState) where TI0 : unmanaged, IComVtbl<ID3D12PipelineState>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->SetPipelineState((ID3D12PipelineState*) pPipelineState.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void SetPipelineState(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12PipelineState> pPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetPipelineState(ref pPipelineState.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void ResourceBarrier(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint NumBarriers, Span<ResourceBarrier> pBarriers)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResourceBarrier(NumBarriers, ref pBarriers.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void ExecuteBundle<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pCommandList) where TI0 : unmanaged, IComVtbl<ID3D12GraphicsCommandList>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ExecuteBundle((ID3D12GraphicsCommandList*) pCommandList.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void ExecuteBundle(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12GraphicsCommandList> pCommandList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ExecuteBundle(ref pCommandList.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SetDescriptorHeaps<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint NumDescriptorHeaps, ref ComPtr<TI0> ppDescriptorHeaps) where TI0 : unmanaged, IComVtbl<ID3D12DescriptorHeap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->SetDescriptorHeaps(NumDescriptorHeaps, (ID3D12DescriptorHeap**) ppDescriptorHeaps.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void SetComputeRootSignature<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pRootSignature) where TI0 : unmanaged, IComVtbl<ID3D12RootSignature>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->SetComputeRootSignature((ID3D12RootSignature*) pRootSignature.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void SetComputeRootSignature(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12RootSignature> pRootSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetComputeRootSignature(ref pRootSignature.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SetGraphicsRootSignature<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pRootSignature) where TI0 : unmanaged, IComVtbl<ID3D12RootSignature>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->SetGraphicsRootSignature((ID3D12RootSignature*) pRootSignature.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void SetGraphicsRootSignature(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12RootSignature> pRootSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetGraphicsRootSignature(ref pRootSignature.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SetComputeRoot32BitConstants<T0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint RootParameterIndex, uint Num32BitValuesToSet, Span<T0> pSrcData, uint DestOffsetIn32BitValues) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetComputeRoot32BitConstants(RootParameterIndex, Num32BitValuesToSet, ref pSrcData.GetPinnableReference(), DestOffsetIn32BitValues);
    }

    /// <summary>To be documented.</summary>
    public static void SetGraphicsRoot32BitConstants<T0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint RootParameterIndex, uint Num32BitValuesToSet, Span<T0> pSrcData, uint DestOffsetIn32BitValues) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetGraphicsRoot32BitConstants(RootParameterIndex, Num32BitValuesToSet, ref pSrcData.GetPinnableReference(), DestOffsetIn32BitValues);
    }

    /// <summary>To be documented.</summary>
    public static void IASetIndexBuffer(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<IndexBufferView> pView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->IASetIndexBuffer(ref pView.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void IASetVertexBuffers(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint StartSlot, uint NumViews, Span<VertexBufferView> pViews)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->IASetVertexBuffers(StartSlot, NumViews, ref pViews.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SOSetTargets(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint StartSlot, uint NumViews, Span<StreamOutputBufferView> pViews)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SOSetTargets(StartSlot, NumViews, ref pViews.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargets(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint NumRenderTargetDescriptors, CpuDescriptorHandle* pRenderTargetDescriptors, int RTsSingleHandleToDescriptorRange, Span<CpuDescriptorHandle> pDepthStencilDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->OMSetRenderTargets(NumRenderTargetDescriptors, pRenderTargetDescriptors, RTsSingleHandleToDescriptorRange, ref pDepthStencilDescriptor.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargets(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint NumRenderTargetDescriptors, Span<CpuDescriptorHandle> pRenderTargetDescriptors, int RTsSingleHandleToDescriptorRange, CpuDescriptorHandle* pDepthStencilDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->OMSetRenderTargets(NumRenderTargetDescriptors, ref pRenderTargetDescriptors.GetPinnableReference(), RTsSingleHandleToDescriptorRange, pDepthStencilDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static void OMSetRenderTargets(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint NumRenderTargetDescriptors, Span<CpuDescriptorHandle> pRenderTargetDescriptors, int RTsSingleHandleToDescriptorRange, Span<CpuDescriptorHandle> pDepthStencilDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->OMSetRenderTargets(NumRenderTargetDescriptors, ref pRenderTargetDescriptors.GetPinnableReference(), RTsSingleHandleToDescriptorRange, ref pDepthStencilDescriptor.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void ClearDepthStencilView(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, CpuDescriptorHandle DepthStencilView, ClearFlags ClearFlags, float Depth, byte Stencil, uint NumRects, Span<Silk.NET.Maths.Rectangle<int>> pRects)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClearDepthStencilView(DepthStencilView, ClearFlags, Depth, Stencil, NumRects, ref pRects.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearRenderTargetView(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, CpuDescriptorHandle RenderTargetView, [Count(Count = 4)] float* ColorRGBA, uint NumRects, Span<Silk.NET.Maths.Rectangle<int>> pRects)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClearRenderTargetView(RenderTargetView, ColorRGBA, NumRects, ref pRects.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearRenderTargetView(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, CpuDescriptorHandle RenderTargetView, [Count(Count = 4)] Span<float> ColorRGBA, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClearRenderTargetView(RenderTargetView, ref ColorRGBA.GetPinnableReference(), NumRects, pRects);
    }

    /// <summary>To be documented.</summary>
    public static void ClearRenderTargetView(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, CpuDescriptorHandle RenderTargetView, [Count(Count = 4)] Span<float> ColorRGBA, uint NumRects, Span<Silk.NET.Maths.Rectangle<int>> pRects)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClearRenderTargetView(RenderTargetView, ref ColorRGBA.GetPinnableReference(), NumRects, ref pRects.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ComPtr<TI0> pResource, [Count(Count = 4)] uint* Values, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ClearUnorderedAccessViewUint(ViewGPUHandleInCurrentHeap, ViewCPUHandle, (ID3D12Resource*) pResource.Handle, Values, NumRects, pRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] uint* Values, uint NumRects, Span<Silk.NET.Maths.Rectangle<int>> pRects)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClearUnorderedAccessViewUint(ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, ref pRects.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ComPtr<TI0> pResource, [Count(Count = 4)] uint* Values, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ClearUnorderedAccessViewUint(ViewGPUHandleInCurrentHeap, ViewCPUHandle, (ID3D12Resource*) pResource.Handle, Values, NumRects, ref pRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] Span<uint> Values, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClearUnorderedAccessViewUint(ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, ref Values.GetPinnableReference(), NumRects, pRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ComPtr<TI0> pResource, [Count(Count = 4)] ref uint Values, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ClearUnorderedAccessViewUint(ViewGPUHandleInCurrentHeap, ViewCPUHandle, (ID3D12Resource*) pResource.Handle, ref Values, NumRects, pRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] Span<uint> Values, uint NumRects, Span<Silk.NET.Maths.Rectangle<int>> pRects)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClearUnorderedAccessViewUint(ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, ref Values.GetPinnableReference(), NumRects, ref pRects.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void ClearUnorderedAccessViewUint<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ComPtr<TI0> pResource, [Count(Count = 4)] ref uint Values, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ClearUnorderedAccessViewUint(ViewGPUHandleInCurrentHeap, ViewCPUHandle, (ID3D12Resource*) pResource.Handle, ref Values, NumRects, ref pRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, Span<ID3D12Resource> pResource, [Count(Count = 4)] uint* Values, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClearUnorderedAccessViewUint(ViewGPUHandleInCurrentHeap, ViewCPUHandle, ref pResource.GetPinnableReference(), Values, NumRects, pRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, Span<ID3D12Resource> pResource, [Count(Count = 4)] uint* Values, uint NumRects, Span<Silk.NET.Maths.Rectangle<int>> pRects)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClearUnorderedAccessViewUint(ViewGPUHandleInCurrentHeap, ViewCPUHandle, ref pResource.GetPinnableReference(), Values, NumRects, ref pRects.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, Span<ID3D12Resource> pResource, [Count(Count = 4)] Span<uint> Values, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClearUnorderedAccessViewUint(ViewGPUHandleInCurrentHeap, ViewCPUHandle, ref pResource.GetPinnableReference(), ref Values.GetPinnableReference(), NumRects, pRects);
    }

    /// <summary>To be documented.</summary>
    public static void ClearUnorderedAccessViewUint(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, Span<ID3D12Resource> pResource, [Count(Count = 4)] Span<uint> Values, uint NumRects, Span<Silk.NET.Maths.Rectangle<int>> pRects)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClearUnorderedAccessViewUint(ViewGPUHandleInCurrentHeap, ViewCPUHandle, ref pResource.GetPinnableReference(), ref Values.GetPinnableReference(), NumRects, ref pRects.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ComPtr<TI0> pResource, [Count(Count = 4)] float* Values, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ClearUnorderedAccessViewFloat(ViewGPUHandleInCurrentHeap, ViewCPUHandle, (ID3D12Resource*) pResource.Handle, Values, NumRects, pRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] float* Values, uint NumRects, Span<Silk.NET.Maths.Rectangle<int>> pRects)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClearUnorderedAccessViewFloat(ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, ref pRects.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ComPtr<TI0> pResource, [Count(Count = 4)] float* Values, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ClearUnorderedAccessViewFloat(ViewGPUHandleInCurrentHeap, ViewCPUHandle, (ID3D12Resource*) pResource.Handle, Values, NumRects, ref pRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] Span<float> Values, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClearUnorderedAccessViewFloat(ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, ref Values.GetPinnableReference(), NumRects, pRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ComPtr<TI0> pResource, [Count(Count = 4)] ref float Values, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ClearUnorderedAccessViewFloat(ViewGPUHandleInCurrentHeap, ViewCPUHandle, (ID3D12Resource*) pResource.Handle, ref Values, NumRects, pRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] Span<float> Values, uint NumRects, Span<Silk.NET.Maths.Rectangle<int>> pRects)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClearUnorderedAccessViewFloat(ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, ref Values.GetPinnableReference(), NumRects, ref pRects.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void ClearUnorderedAccessViewFloat<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ComPtr<TI0> pResource, [Count(Count = 4)] ref float Values, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ClearUnorderedAccessViewFloat(ViewGPUHandleInCurrentHeap, ViewCPUHandle, (ID3D12Resource*) pResource.Handle, ref Values, NumRects, ref pRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, Span<ID3D12Resource> pResource, [Count(Count = 4)] float* Values, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClearUnorderedAccessViewFloat(ViewGPUHandleInCurrentHeap, ViewCPUHandle, ref pResource.GetPinnableReference(), Values, NumRects, pRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, Span<ID3D12Resource> pResource, [Count(Count = 4)] float* Values, uint NumRects, Span<Silk.NET.Maths.Rectangle<int>> pRects)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClearUnorderedAccessViewFloat(ViewGPUHandleInCurrentHeap, ViewCPUHandle, ref pResource.GetPinnableReference(), Values, NumRects, ref pRects.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, Span<ID3D12Resource> pResource, [Count(Count = 4)] Span<float> Values, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClearUnorderedAccessViewFloat(ViewGPUHandleInCurrentHeap, ViewCPUHandle, ref pResource.GetPinnableReference(), ref Values.GetPinnableReference(), NumRects, pRects);
    }

    /// <summary>To be documented.</summary>
    public static void ClearUnorderedAccessViewFloat(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, Span<ID3D12Resource> pResource, [Count(Count = 4)] Span<float> Values, uint NumRects, Span<Silk.NET.Maths.Rectangle<int>> pRects)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClearUnorderedAccessViewFloat(ViewGPUHandleInCurrentHeap, ViewCPUHandle, ref pResource.GetPinnableReference(), ref Values.GetPinnableReference(), NumRects, ref pRects.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardResource<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pResource, DiscardRegion* pRegion) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DiscardResource((ID3D12Resource*) pResource.Handle, pRegion);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardResource(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pResource, Span<DiscardRegion> pRegion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DiscardResource(pResource, ref pRegion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void DiscardResource<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pResource, ref DiscardRegion pRegion) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DiscardResource((ID3D12Resource*) pResource.Handle, ref pRegion);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardResource(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pResource, DiscardRegion* pRegion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DiscardResource(ref pResource.GetPinnableReference(), pRegion);
    }

    /// <summary>To be documented.</summary>
    public static void DiscardResource(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pResource, Span<DiscardRegion> pRegion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DiscardResource(ref pResource.GetPinnableReference(), ref pRegion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void BeginQuery<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pQueryHeap, QueryType Type, uint Index) where TI0 : unmanaged, IComVtbl<ID3D12QueryHeap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->BeginQuery((ID3D12QueryHeap*) pQueryHeap.Handle, Type, Index);
    }

    /// <summary>To be documented.</summary>
    public static void BeginQuery(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12QueryHeap> pQueryHeap, QueryType Type, uint Index)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->BeginQuery(ref pQueryHeap.GetPinnableReference(), Type, Index);
    }

    /// <summary>To be documented.</summary>
    public static void EndQuery<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pQueryHeap, QueryType Type, uint Index) where TI0 : unmanaged, IComVtbl<ID3D12QueryHeap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->EndQuery((ID3D12QueryHeap*) pQueryHeap.Handle, Type, Index);
    }

    /// <summary>To be documented.</summary>
    public static void EndQuery(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12QueryHeap> pQueryHeap, QueryType Type, uint Index)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->EndQuery(ref pQueryHeap.GetPinnableReference(), Type, Index);
    }

    /// <summary>To be documented.</summary>
    public static void ResolveQueryData<TI0, TI1>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ComPtr<TI1> pDestinationBuffer, ulong AlignedDestinationBufferOffset) where TI0 : unmanaged, IComVtbl<ID3D12QueryHeap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ResolveQueryData((ID3D12QueryHeap*) pQueryHeap.Handle, Type, StartIndex, NumQueries, (ID3D12Resource*) pDestinationBuffer.Handle, AlignedDestinationBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveQueryData(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, Span<ID3D12Resource> pDestinationBuffer, ulong AlignedDestinationBufferOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResolveQueryData(pQueryHeap, Type, StartIndex, NumQueries, ref pDestinationBuffer.GetPinnableReference(), AlignedDestinationBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static void ResolveQueryData<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset) where TI0 : unmanaged, IComVtbl<ID3D12QueryHeap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ResolveQueryData((ID3D12QueryHeap*) pQueryHeap.Handle, Type, StartIndex, NumQueries, ref pDestinationBuffer, AlignedDestinationBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveQueryData(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12QueryHeap> pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResolveQueryData(ref pQueryHeap.GetPinnableReference(), Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static void ResolveQueryData<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ComPtr<TI0> pDestinationBuffer, ulong AlignedDestinationBufferOffset) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ResolveQueryData(ref pQueryHeap, Type, StartIndex, NumQueries, (ID3D12Resource*) pDestinationBuffer.Handle, AlignedDestinationBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static void ResolveQueryData(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12QueryHeap> pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, Span<ID3D12Resource> pDestinationBuffer, ulong AlignedDestinationBufferOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResolveQueryData(ref pQueryHeap.GetPinnableReference(), Type, StartIndex, NumQueries, ref pDestinationBuffer.GetPinnableReference(), AlignedDestinationBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static void SetPredication<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pBuffer, ulong AlignedBufferOffset, PredicationOp Operation) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->SetPredication((ID3D12Resource*) pBuffer.Handle, AlignedBufferOffset, Operation);
    }

    /// <summary>To be documented.</summary>
    public static void SetPredication(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pBuffer, ulong AlignedBufferOffset, PredicationOp Operation)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetPredication(ref pBuffer.GetPinnableReference(), AlignedBufferOffset, Operation);
    }

    /// <summary>To be documented.</summary>
    public static void SetMarker<T0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint Metadata, Span<T0> pData, uint Size) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetMarker(Metadata, ref pData.GetPinnableReference(), Size);
    }

    /// <summary>To be documented.</summary>
    public static void BeginEvent<T0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint Metadata, Span<T0> pData, uint Size) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->BeginEvent(Metadata, ref pData.GetPinnableReference(), Size);
    }

    /// <summary>To be documented.</summary>
    public static void ExecuteIndirect<TI0, TI1, TI2>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pCommandSignature, uint MaxCommandCount, ComPtr<TI1> pArgumentBuffer, ulong ArgumentBufferOffset, ComPtr<TI2> pCountBuffer, ulong CountBufferOffset) where TI0 : unmanaged, IComVtbl<ID3D12CommandSignature>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ExecuteIndirect((ID3D12CommandSignature*) pCommandSignature.Handle, MaxCommandCount, (ID3D12Resource*) pArgumentBuffer.Handle, ArgumentBufferOffset, (ID3D12Resource*) pCountBuffer.Handle, CountBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteIndirect(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12CommandSignature* pCommandSignature, uint MaxCommandCount, ID3D12Resource* pArgumentBuffer, ulong ArgumentBufferOffset, Span<ID3D12Resource> pCountBuffer, ulong CountBufferOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ExecuteIndirect(pCommandSignature, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, ref pCountBuffer.GetPinnableReference(), CountBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static void ExecuteIndirect<TI0, TI1>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pCommandSignature, uint MaxCommandCount, ComPtr<TI1> pArgumentBuffer, ulong ArgumentBufferOffset, ref ID3D12Resource pCountBuffer, ulong CountBufferOffset) where TI0 : unmanaged, IComVtbl<ID3D12CommandSignature>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ExecuteIndirect((ID3D12CommandSignature*) pCommandSignature.Handle, MaxCommandCount, (ID3D12Resource*) pArgumentBuffer.Handle, ArgumentBufferOffset, ref pCountBuffer, CountBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteIndirect(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12CommandSignature* pCommandSignature, uint MaxCommandCount, Span<ID3D12Resource> pArgumentBuffer, ulong ArgumentBufferOffset, ID3D12Resource* pCountBuffer, ulong CountBufferOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ExecuteIndirect(pCommandSignature, MaxCommandCount, ref pArgumentBuffer.GetPinnableReference(), ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static void ExecuteIndirect<TI0, TI1>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pCommandSignature, uint MaxCommandCount, ref ID3D12Resource pArgumentBuffer, ulong ArgumentBufferOffset, ComPtr<TI1> pCountBuffer, ulong CountBufferOffset) where TI0 : unmanaged, IComVtbl<ID3D12CommandSignature>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ExecuteIndirect((ID3D12CommandSignature*) pCommandSignature.Handle, MaxCommandCount, ref pArgumentBuffer, ArgumentBufferOffset, (ID3D12Resource*) pCountBuffer.Handle, CountBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteIndirect(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12CommandSignature* pCommandSignature, uint MaxCommandCount, Span<ID3D12Resource> pArgumentBuffer, ulong ArgumentBufferOffset, Span<ID3D12Resource> pCountBuffer, ulong CountBufferOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ExecuteIndirect(pCommandSignature, MaxCommandCount, ref pArgumentBuffer.GetPinnableReference(), ArgumentBufferOffset, ref pCountBuffer.GetPinnableReference(), CountBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static void ExecuteIndirect<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pCommandSignature, uint MaxCommandCount, ref ID3D12Resource pArgumentBuffer, ulong ArgumentBufferOffset, ref ID3D12Resource pCountBuffer, ulong CountBufferOffset) where TI0 : unmanaged, IComVtbl<ID3D12CommandSignature>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ExecuteIndirect((ID3D12CommandSignature*) pCommandSignature.Handle, MaxCommandCount, ref pArgumentBuffer, ArgumentBufferOffset, ref pCountBuffer, CountBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteIndirect(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12CommandSignature> pCommandSignature, uint MaxCommandCount, ID3D12Resource* pArgumentBuffer, ulong ArgumentBufferOffset, ID3D12Resource* pCountBuffer, ulong CountBufferOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ExecuteIndirect(ref pCommandSignature.GetPinnableReference(), MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static void ExecuteIndirect<TI0, TI1>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12CommandSignature pCommandSignature, uint MaxCommandCount, ComPtr<TI0> pArgumentBuffer, ulong ArgumentBufferOffset, ComPtr<TI1> pCountBuffer, ulong CountBufferOffset) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ExecuteIndirect(ref pCommandSignature, MaxCommandCount, (ID3D12Resource*) pArgumentBuffer.Handle, ArgumentBufferOffset, (ID3D12Resource*) pCountBuffer.Handle, CountBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteIndirect(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12CommandSignature> pCommandSignature, uint MaxCommandCount, ID3D12Resource* pArgumentBuffer, ulong ArgumentBufferOffset, Span<ID3D12Resource> pCountBuffer, ulong CountBufferOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ExecuteIndirect(ref pCommandSignature.GetPinnableReference(), MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, ref pCountBuffer.GetPinnableReference(), CountBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static void ExecuteIndirect<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12CommandSignature pCommandSignature, uint MaxCommandCount, ComPtr<TI0> pArgumentBuffer, ulong ArgumentBufferOffset, ref ID3D12Resource pCountBuffer, ulong CountBufferOffset) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ExecuteIndirect(ref pCommandSignature, MaxCommandCount, (ID3D12Resource*) pArgumentBuffer.Handle, ArgumentBufferOffset, ref pCountBuffer, CountBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteIndirect(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12CommandSignature> pCommandSignature, uint MaxCommandCount, Span<ID3D12Resource> pArgumentBuffer, ulong ArgumentBufferOffset, ID3D12Resource* pCountBuffer, ulong CountBufferOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ExecuteIndirect(ref pCommandSignature.GetPinnableReference(), MaxCommandCount, ref pArgumentBuffer.GetPinnableReference(), ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static void ExecuteIndirect<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12CommandSignature pCommandSignature, uint MaxCommandCount, ref ID3D12Resource pArgumentBuffer, ulong ArgumentBufferOffset, ComPtr<TI0> pCountBuffer, ulong CountBufferOffset) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ExecuteIndirect(ref pCommandSignature, MaxCommandCount, ref pArgumentBuffer, ArgumentBufferOffset, (ID3D12Resource*) pCountBuffer.Handle, CountBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static void ExecuteIndirect(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12CommandSignature> pCommandSignature, uint MaxCommandCount, Span<ID3D12Resource> pArgumentBuffer, ulong ArgumentBufferOffset, Span<ID3D12Resource> pCountBuffer, ulong CountBufferOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ExecuteIndirect(ref pCommandSignature.GetPinnableReference(), MaxCommandCount, ref pArgumentBuffer.GetPinnableReference(), ArgumentBufferOffset, ref pCountBuffer.GetPinnableReference(), CountBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT<TI0, TI1, TI2>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pDstBuffer, ulong DstOffset, ComPtr<TI1> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ComPtr<TI2> ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->AtomicCopyBufferUINT((ID3D12Resource*) pDstBuffer.Handle, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, Dependencies, (ID3D12Resource**) ppDependentResources.GetAddressOf(), pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, Span<SubresourceRangeUint64> pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AtomicCopyBufferUINT(pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, ref pDependentSubresourceRanges.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void AtomicCopyBufferUINT<TI0, TI1, TI2>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pDstBuffer, ulong DstOffset, ComPtr<TI1> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ComPtr<TI2> ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->AtomicCopyBufferUINT((ID3D12Resource*) pDstBuffer.Handle, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, Dependencies, (ID3D12Resource**) ppDependentResources.GetAddressOf(), ref pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT<TI0, TI1>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pDstBuffer, ulong DstOffset, ComPtr<TI1> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->AtomicCopyBufferUINT((ID3D12Resource*) pDstBuffer.Handle, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, Dependencies, ref ppDependentResources, pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, Span<SubresourceRangeUint64> pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AtomicCopyBufferUINT(pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ref ppDependentResources, ref pDependentSubresourceRanges.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT<TI0, TI1>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pDstBuffer, ulong DstOffset, ComPtr<TI1> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->AtomicCopyBufferUINT((ID3D12Resource*) pDstBuffer.Handle, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, Dependencies, ref ppDependentResources, ref pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, Span<ID3D12Resource> pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AtomicCopyBufferUINT(pDstBuffer, DstOffset, ref pSrcBuffer.GetPinnableReference(), SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT<TI0, TI1>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ComPtr<TI1> ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->AtomicCopyBufferUINT((ID3D12Resource*) pDstBuffer.Handle, DstOffset, ref pSrcBuffer, SrcOffset, Dependencies, (ID3D12Resource**) ppDependentResources.GetAddressOf(), pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, Span<ID3D12Resource> pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, Span<SubresourceRangeUint64> pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AtomicCopyBufferUINT(pDstBuffer, DstOffset, ref pSrcBuffer.GetPinnableReference(), SrcOffset, Dependencies, ppDependentResources, ref pDependentSubresourceRanges.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void AtomicCopyBufferUINT<TI0, TI1>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ComPtr<TI1> ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->AtomicCopyBufferUINT((ID3D12Resource*) pDstBuffer.Handle, DstOffset, ref pSrcBuffer, SrcOffset, Dependencies, (ID3D12Resource**) ppDependentResources.GetAddressOf(), ref pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, Span<ID3D12Resource> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AtomicCopyBufferUINT(pDstBuffer, DstOffset, ref pSrcBuffer.GetPinnableReference(), SrcOffset, Dependencies, ref ppDependentResources, pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->AtomicCopyBufferUINT((ID3D12Resource*) pDstBuffer.Handle, DstOffset, ref pSrcBuffer, SrcOffset, Dependencies, ref ppDependentResources, pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, Span<ID3D12Resource> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, Span<SubresourceRangeUint64> pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AtomicCopyBufferUINT(pDstBuffer, DstOffset, ref pSrcBuffer.GetPinnableReference(), SrcOffset, Dependencies, ref ppDependentResources, ref pDependentSubresourceRanges.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->AtomicCopyBufferUINT((ID3D12Resource*) pDstBuffer.Handle, DstOffset, ref pSrcBuffer, SrcOffset, Dependencies, ref ppDependentResources, ref pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AtomicCopyBufferUINT(ref pDstBuffer.GetPinnableReference(), DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT<TI0, TI1>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ComPtr<TI0> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ComPtr<TI1> ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->AtomicCopyBufferUINT(ref pDstBuffer, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, Dependencies, (ID3D12Resource**) ppDependentResources.GetAddressOf(), pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, Span<SubresourceRangeUint64> pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AtomicCopyBufferUINT(ref pDstBuffer.GetPinnableReference(), DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, ref pDependentSubresourceRanges.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void AtomicCopyBufferUINT<TI0, TI1>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ComPtr<TI0> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ComPtr<TI1> ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->AtomicCopyBufferUINT(ref pDstBuffer, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, Dependencies, (ID3D12Resource**) ppDependentResources.GetAddressOf(), ref pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AtomicCopyBufferUINT(ref pDstBuffer.GetPinnableReference(), DstOffset, pSrcBuffer, SrcOffset, Dependencies, ref ppDependentResources, pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ComPtr<TI0> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->AtomicCopyBufferUINT(ref pDstBuffer, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, Dependencies, ref ppDependentResources, pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, Span<SubresourceRangeUint64> pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AtomicCopyBufferUINT(ref pDstBuffer.GetPinnableReference(), DstOffset, pSrcBuffer, SrcOffset, Dependencies, ref ppDependentResources, ref pDependentSubresourceRanges.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ComPtr<TI0> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->AtomicCopyBufferUINT(ref pDstBuffer, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, Dependencies, ref ppDependentResources, ref pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pDstBuffer, ulong DstOffset, Span<ID3D12Resource> pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AtomicCopyBufferUINT(ref pDstBuffer.GetPinnableReference(), DstOffset, ref pSrcBuffer.GetPinnableReference(), SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ComPtr<TI0> ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->AtomicCopyBufferUINT(ref pDstBuffer, DstOffset, ref pSrcBuffer, SrcOffset, Dependencies, (ID3D12Resource**) ppDependentResources.GetAddressOf(), pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pDstBuffer, ulong DstOffset, Span<ID3D12Resource> pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, Span<SubresourceRangeUint64> pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AtomicCopyBufferUINT(ref pDstBuffer.GetPinnableReference(), DstOffset, ref pSrcBuffer.GetPinnableReference(), SrcOffset, Dependencies, ppDependentResources, ref pDependentSubresourceRanges.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void AtomicCopyBufferUINT<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ComPtr<TI0> ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->AtomicCopyBufferUINT(ref pDstBuffer, DstOffset, ref pSrcBuffer, SrcOffset, Dependencies, (ID3D12Resource**) ppDependentResources.GetAddressOf(), ref pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pDstBuffer, ulong DstOffset, Span<ID3D12Resource> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AtomicCopyBufferUINT(ref pDstBuffer.GetPinnableReference(), DstOffset, ref pSrcBuffer.GetPinnableReference(), SrcOffset, Dependencies, ref ppDependentResources, pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pDstBuffer, ulong DstOffset, Span<ID3D12Resource> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, Span<SubresourceRangeUint64> pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AtomicCopyBufferUINT(ref pDstBuffer.GetPinnableReference(), DstOffset, ref pSrcBuffer.GetPinnableReference(), SrcOffset, Dependencies, ref ppDependentResources, ref pDependentSubresourceRanges.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64<TI0, TI1, TI2>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pDstBuffer, ulong DstOffset, ComPtr<TI1> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ComPtr<TI2> ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->AtomicCopyBufferUINT64((ID3D12Resource*) pDstBuffer.Handle, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, Dependencies, (ID3D12Resource**) ppDependentResources.GetAddressOf(), pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, Span<SubresourceRangeUint64> pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AtomicCopyBufferUINT64(pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, ref pDependentSubresourceRanges.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void AtomicCopyBufferUINT64<TI0, TI1, TI2>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pDstBuffer, ulong DstOffset, ComPtr<TI1> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ComPtr<TI2> ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->AtomicCopyBufferUINT64((ID3D12Resource*) pDstBuffer.Handle, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, Dependencies, (ID3D12Resource**) ppDependentResources.GetAddressOf(), ref pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64<TI0, TI1>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pDstBuffer, ulong DstOffset, ComPtr<TI1> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->AtomicCopyBufferUINT64((ID3D12Resource*) pDstBuffer.Handle, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, Dependencies, ref ppDependentResources, pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, Span<SubresourceRangeUint64> pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AtomicCopyBufferUINT64(pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ref ppDependentResources, ref pDependentSubresourceRanges.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64<TI0, TI1>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pDstBuffer, ulong DstOffset, ComPtr<TI1> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->AtomicCopyBufferUINT64((ID3D12Resource*) pDstBuffer.Handle, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, Dependencies, ref ppDependentResources, ref pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, Span<ID3D12Resource> pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AtomicCopyBufferUINT64(pDstBuffer, DstOffset, ref pSrcBuffer.GetPinnableReference(), SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64<TI0, TI1>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ComPtr<TI1> ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->AtomicCopyBufferUINT64((ID3D12Resource*) pDstBuffer.Handle, DstOffset, ref pSrcBuffer, SrcOffset, Dependencies, (ID3D12Resource**) ppDependentResources.GetAddressOf(), pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, Span<ID3D12Resource> pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, Span<SubresourceRangeUint64> pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AtomicCopyBufferUINT64(pDstBuffer, DstOffset, ref pSrcBuffer.GetPinnableReference(), SrcOffset, Dependencies, ppDependentResources, ref pDependentSubresourceRanges.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void AtomicCopyBufferUINT64<TI0, TI1>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ComPtr<TI1> ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->AtomicCopyBufferUINT64((ID3D12Resource*) pDstBuffer.Handle, DstOffset, ref pSrcBuffer, SrcOffset, Dependencies, (ID3D12Resource**) ppDependentResources.GetAddressOf(), ref pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, Span<ID3D12Resource> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AtomicCopyBufferUINT64(pDstBuffer, DstOffset, ref pSrcBuffer.GetPinnableReference(), SrcOffset, Dependencies, ref ppDependentResources, pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->AtomicCopyBufferUINT64((ID3D12Resource*) pDstBuffer.Handle, DstOffset, ref pSrcBuffer, SrcOffset, Dependencies, ref ppDependentResources, pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, Span<ID3D12Resource> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, Span<SubresourceRangeUint64> pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AtomicCopyBufferUINT64(pDstBuffer, DstOffset, ref pSrcBuffer.GetPinnableReference(), SrcOffset, Dependencies, ref ppDependentResources, ref pDependentSubresourceRanges.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->AtomicCopyBufferUINT64((ID3D12Resource*) pDstBuffer.Handle, DstOffset, ref pSrcBuffer, SrcOffset, Dependencies, ref ppDependentResources, ref pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AtomicCopyBufferUINT64(ref pDstBuffer.GetPinnableReference(), DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64<TI0, TI1>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ComPtr<TI0> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ComPtr<TI1> ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->AtomicCopyBufferUINT64(ref pDstBuffer, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, Dependencies, (ID3D12Resource**) ppDependentResources.GetAddressOf(), pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, Span<SubresourceRangeUint64> pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AtomicCopyBufferUINT64(ref pDstBuffer.GetPinnableReference(), DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, ref pDependentSubresourceRanges.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void AtomicCopyBufferUINT64<TI0, TI1>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ComPtr<TI0> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ComPtr<TI1> ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->AtomicCopyBufferUINT64(ref pDstBuffer, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, Dependencies, (ID3D12Resource**) ppDependentResources.GetAddressOf(), ref pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AtomicCopyBufferUINT64(ref pDstBuffer.GetPinnableReference(), DstOffset, pSrcBuffer, SrcOffset, Dependencies, ref ppDependentResources, pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ComPtr<TI0> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->AtomicCopyBufferUINT64(ref pDstBuffer, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, Dependencies, ref ppDependentResources, pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, Span<SubresourceRangeUint64> pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AtomicCopyBufferUINT64(ref pDstBuffer.GetPinnableReference(), DstOffset, pSrcBuffer, SrcOffset, Dependencies, ref ppDependentResources, ref pDependentSubresourceRanges.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ComPtr<TI0> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->AtomicCopyBufferUINT64(ref pDstBuffer, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, Dependencies, ref ppDependentResources, ref pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pDstBuffer, ulong DstOffset, Span<ID3D12Resource> pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AtomicCopyBufferUINT64(ref pDstBuffer.GetPinnableReference(), DstOffset, ref pSrcBuffer.GetPinnableReference(), SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ComPtr<TI0> ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->AtomicCopyBufferUINT64(ref pDstBuffer, DstOffset, ref pSrcBuffer, SrcOffset, Dependencies, (ID3D12Resource**) ppDependentResources.GetAddressOf(), pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pDstBuffer, ulong DstOffset, Span<ID3D12Resource> pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, Span<SubresourceRangeUint64> pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AtomicCopyBufferUINT64(ref pDstBuffer.GetPinnableReference(), DstOffset, ref pSrcBuffer.GetPinnableReference(), SrcOffset, Dependencies, ppDependentResources, ref pDependentSubresourceRanges.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void AtomicCopyBufferUINT64<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ComPtr<TI0> ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->AtomicCopyBufferUINT64(ref pDstBuffer, DstOffset, ref pSrcBuffer, SrcOffset, Dependencies, (ID3D12Resource**) ppDependentResources.GetAddressOf(), ref pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pDstBuffer, ulong DstOffset, Span<ID3D12Resource> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AtomicCopyBufferUINT64(ref pDstBuffer.GetPinnableReference(), DstOffset, ref pSrcBuffer.GetPinnableReference(), SrcOffset, Dependencies, ref ppDependentResources, pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pDstBuffer, ulong DstOffset, Span<ID3D12Resource> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, Span<SubresourceRangeUint64> pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->AtomicCopyBufferUINT64(ref pDstBuffer.GetPinnableReference(), DstOffset, ref pSrcBuffer.GetPinnableReference(), SrcOffset, Dependencies, ref ppDependentResources, ref pDependentSubresourceRanges.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SetSamplePositions(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint NumSamplesPerPixel, uint NumPixels, Span<SamplePosition> pSamplePositions)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetSamplePositions(NumSamplesPerPixel, NumPixels, ref pSamplePositions.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresourceRegion<TI0, TI1>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pDstResource, uint DstSubresource, uint DstX, uint DstY, ComPtr<TI1> pSrcResource, uint SrcSubresource, Silk.NET.Maths.Rectangle<int>* pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ResolveSubresourceRegion((ID3D12Resource*) pDstResource.Handle, DstSubresource, DstX, DstY, (ID3D12Resource*) pSrcResource.Handle, SrcSubresource, pSrcRect, Format, ResolveMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresourceRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, ID3D12Resource* pSrcResource, uint SrcSubresource, Span<Silk.NET.Maths.Rectangle<int>> pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResolveSubresourceRegion(pDstResource, DstSubresource, DstX, DstY, pSrcResource, SrcSubresource, ref pSrcRect.GetPinnableReference(), Format, ResolveMode);
    }

    /// <summary>To be documented.</summary>
    public static void ResolveSubresourceRegion<TI0, TI1>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pDstResource, uint DstSubresource, uint DstX, uint DstY, ComPtr<TI1> pSrcResource, uint SrcSubresource, ref Silk.NET.Maths.Rectangle<int> pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ResolveSubresourceRegion((ID3D12Resource*) pDstResource.Handle, DstSubresource, DstX, DstY, (ID3D12Resource*) pSrcResource.Handle, SrcSubresource, ref pSrcRect, Format, ResolveMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresourceRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, Span<ID3D12Resource> pSrcResource, uint SrcSubresource, Silk.NET.Maths.Rectangle<int>* pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResolveSubresourceRegion(pDstResource, DstSubresource, DstX, DstY, ref pSrcResource.GetPinnableReference(), SrcSubresource, pSrcRect, Format, ResolveMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresourceRegion<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pDstResource, uint DstSubresource, uint DstX, uint DstY, ref ID3D12Resource pSrcResource, uint SrcSubresource, Silk.NET.Maths.Rectangle<int>* pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ResolveSubresourceRegion((ID3D12Resource*) pDstResource.Handle, DstSubresource, DstX, DstY, ref pSrcResource, SrcSubresource, pSrcRect, Format, ResolveMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresourceRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, Span<ID3D12Resource> pSrcResource, uint SrcSubresource, Span<Silk.NET.Maths.Rectangle<int>> pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResolveSubresourceRegion(pDstResource, DstSubresource, DstX, DstY, ref pSrcResource.GetPinnableReference(), SrcSubresource, ref pSrcRect.GetPinnableReference(), Format, ResolveMode);
    }

    /// <summary>To be documented.</summary>
    public static void ResolveSubresourceRegion<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ComPtr<TI0> pDstResource, uint DstSubresource, uint DstX, uint DstY, ref ID3D12Resource pSrcResource, uint SrcSubresource, ref Silk.NET.Maths.Rectangle<int> pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ResolveSubresourceRegion((ID3D12Resource*) pDstResource.Handle, DstSubresource, DstX, DstY, ref pSrcResource, SrcSubresource, ref pSrcRect, Format, ResolveMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresourceRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pDstResource, uint DstSubresource, uint DstX, uint DstY, ID3D12Resource* pSrcResource, uint SrcSubresource, Silk.NET.Maths.Rectangle<int>* pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResolveSubresourceRegion(ref pDstResource.GetPinnableReference(), DstSubresource, DstX, DstY, pSrcResource, SrcSubresource, pSrcRect, Format, ResolveMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresourceRegion<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, ComPtr<TI0> pSrcResource, uint SrcSubresource, Silk.NET.Maths.Rectangle<int>* pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ResolveSubresourceRegion(ref pDstResource, DstSubresource, DstX, DstY, (ID3D12Resource*) pSrcResource.Handle, SrcSubresource, pSrcRect, Format, ResolveMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresourceRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pDstResource, uint DstSubresource, uint DstX, uint DstY, ID3D12Resource* pSrcResource, uint SrcSubresource, Span<Silk.NET.Maths.Rectangle<int>> pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResolveSubresourceRegion(ref pDstResource.GetPinnableReference(), DstSubresource, DstX, DstY, pSrcResource, SrcSubresource, ref pSrcRect.GetPinnableReference(), Format, ResolveMode);
    }

    /// <summary>To be documented.</summary>
    public static void ResolveSubresourceRegion<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ref ID3D12Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, ComPtr<TI0> pSrcResource, uint SrcSubresource, ref Silk.NET.Maths.Rectangle<int> pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ResolveSubresourceRegion(ref pDstResource, DstSubresource, DstX, DstY, (ID3D12Resource*) pSrcResource.Handle, SrcSubresource, ref pSrcRect, Format, ResolveMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresourceRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pDstResource, uint DstSubresource, uint DstX, uint DstY, Span<ID3D12Resource> pSrcResource, uint SrcSubresource, Silk.NET.Maths.Rectangle<int>* pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResolveSubresourceRegion(ref pDstResource.GetPinnableReference(), DstSubresource, DstX, DstY, ref pSrcResource.GetPinnableReference(), SrcSubresource, pSrcRect, Format, ResolveMode);
    }

    /// <summary>To be documented.</summary>
    public static void ResolveSubresourceRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Span<ID3D12Resource> pDstResource, uint DstSubresource, uint DstX, uint DstY, Span<ID3D12Resource> pSrcResource, uint SrcSubresource, Span<Silk.NET.Maths.Rectangle<int>> pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResolveSubresourceRegion(ref pDstResource.GetPinnableReference(), DstSubresource, DstX, DstY, ref pSrcResource.GetPinnableReference(), SrcSubresource, ref pSrcRect.GetPinnableReference(), Format, ResolveMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void WriteBufferImmediate(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint Count, WritebufferimmediateParameter* pParams, Span<WritebufferimmediateMode> pModes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->WriteBufferImmediate(Count, pParams, ref pModes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void WriteBufferImmediate(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint Count, Span<WritebufferimmediateParameter> pParams, WritebufferimmediateMode* pModes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->WriteBufferImmediate(Count, ref pParams.GetPinnableReference(), pModes);
    }

    /// <summary>To be documented.</summary>
    public static void WriteBufferImmediate(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint Count, Span<WritebufferimmediateParameter> pParams, Span<WritebufferimmediateMode> pModes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->WriteBufferImmediate(Count, ref pParams.GetPinnableReference(), ref pModes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetDevice<TI0>(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetDevice(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
