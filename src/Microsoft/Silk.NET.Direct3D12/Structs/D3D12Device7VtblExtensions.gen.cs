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

public unsafe static class D3D12Device7VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12Device7> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12Device7> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12Device7> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12Device7> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12Device7> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12Device7> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12Device7> thisVtbl, Guid* guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12Device7> thisVtbl, Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12Device7> thisVtbl, Guid* guid, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12Device7> thisVtbl, Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12Device7> thisVtbl, ref Guid guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12Device7> thisVtbl, ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12Device7> thisVtbl, ref Guid guid, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<ID3D12Device7> thisVtbl, ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D12Device7> thisVtbl, Guid* guid, uint DataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<ID3D12Device7> thisVtbl, Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D12Device7> thisVtbl, ref Guid guid, uint DataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<ID3D12Device7> thisVtbl, ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12Device7> thisVtbl, Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12Device7> thisVtbl, Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12Device7> thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<ID3D12Device7> thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetName(this ComPtr<ID3D12Device7> thisVtbl, char* Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, char*, int>)@this->LpVtbl[6])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName(this ComPtr<ID3D12Device7> thisVtbl, ref char Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, char*, int>)@this->LpVtbl[6])(@this, NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName(this ComPtr<ID3D12Device7> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, byte*, int>)@this->LpVtbl[6])(@this, NamePtr);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetNodeCount(this ComPtr<ID3D12Device7> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue(this ComPtr<ID3D12Device7> thisVtbl, CommandQueueDesc* pDesc, Guid* riid, void** ppCommandQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandQueueDesc*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, riid, ppCommandQueue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue(this ComPtr<ID3D12Device7> thisVtbl, CommandQueueDesc* pDesc, Guid* riid, ref void* ppCommandQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppCommandQueuePtr = &ppCommandQueue)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandQueueDesc*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, riid, ppCommandQueuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue(this ComPtr<ID3D12Device7> thisVtbl, CommandQueueDesc* pDesc, ref Guid riid, void** ppCommandQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandQueueDesc*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, riidPtr, ppCommandQueue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue(this ComPtr<ID3D12Device7> thisVtbl, CommandQueueDesc* pDesc, ref Guid riid, ref void* ppCommandQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppCommandQueuePtr = &ppCommandQueue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandQueueDesc*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, riidPtr, ppCommandQueuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue(this ComPtr<ID3D12Device7> thisVtbl, ref CommandQueueDesc pDesc, Guid* riid, void** ppCommandQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CommandQueueDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandQueueDesc*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, riid, ppCommandQueue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue(this ComPtr<ID3D12Device7> thisVtbl, ref CommandQueueDesc pDesc, Guid* riid, ref void* ppCommandQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CommandQueueDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppCommandQueuePtr = &ppCommandQueue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandQueueDesc*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, riid, ppCommandQueuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue(this ComPtr<ID3D12Device7> thisVtbl, ref CommandQueueDesc pDesc, ref Guid riid, void** ppCommandQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CommandQueueDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandQueueDesc*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, riidPtr, ppCommandQueue);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue(this ComPtr<ID3D12Device7> thisVtbl, ref CommandQueueDesc pDesc, ref Guid riid, ref void* ppCommandQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CommandQueueDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppCommandQueuePtr = &ppCommandQueue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandQueueDesc*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, riidPtr, ppCommandQueuePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandAllocator(this ComPtr<ID3D12Device7> thisVtbl, CommandListType type, Guid* riid, void** ppCommandAllocator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandListType, Guid*, void**, int>)@this->LpVtbl[9])(@this, type, riid, ppCommandAllocator);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandAllocator(this ComPtr<ID3D12Device7> thisVtbl, CommandListType type, Guid* riid, ref void* ppCommandAllocator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppCommandAllocatorPtr = &ppCommandAllocator)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandListType, Guid*, void**, int>)@this->LpVtbl[9])(@this, type, riid, ppCommandAllocatorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandAllocator(this ComPtr<ID3D12Device7> thisVtbl, CommandListType type, ref Guid riid, void** ppCommandAllocator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandListType, Guid*, void**, int>)@this->LpVtbl[9])(@this, type, riidPtr, ppCommandAllocator);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandAllocator(this ComPtr<ID3D12Device7> thisVtbl, CommandListType type, ref Guid riid, ref void* ppCommandAllocator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppCommandAllocatorPtr = &ppCommandAllocator)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandListType, Guid*, void**, int>)@this->LpVtbl[9])(@this, type, riidPtr, ppCommandAllocatorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState(this ComPtr<ID3D12Device7> thisVtbl, GraphicsPipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pDesc, riid, ppPipelineState);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState(this ComPtr<ID3D12Device7> thisVtbl, GraphicsPipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppPipelineStatePtr = &ppPipelineState)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pDesc, riid, ppPipelineStatePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState(this ComPtr<ID3D12Device7> thisVtbl, GraphicsPipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pDesc, riidPtr, ppPipelineState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState(this ComPtr<ID3D12Device7> thisVtbl, GraphicsPipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pDesc, riidPtr, ppPipelineStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState(this ComPtr<ID3D12Device7> thisVtbl, ref GraphicsPipelineStateDesc pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pDescPtr, riid, ppPipelineState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState(this ComPtr<ID3D12Device7> thisVtbl, ref GraphicsPipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pDescPtr, riid, ppPipelineStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState(this ComPtr<ID3D12Device7> thisVtbl, ref GraphicsPipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pDescPtr, riidPtr, ppPipelineState);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState(this ComPtr<ID3D12Device7> thisVtbl, ref GraphicsPipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pDescPtr, riidPtr, ppPipelineStatePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState(this ComPtr<ID3D12Device7> thisVtbl, ComputePipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[11])(@this, pDesc, riid, ppPipelineState);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState(this ComPtr<ID3D12Device7> thisVtbl, ComputePipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppPipelineStatePtr = &ppPipelineState)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[11])(@this, pDesc, riid, ppPipelineStatePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState(this ComPtr<ID3D12Device7> thisVtbl, ComputePipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[11])(@this, pDesc, riidPtr, ppPipelineState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState(this ComPtr<ID3D12Device7> thisVtbl, ComputePipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[11])(@this, pDesc, riidPtr, ppPipelineStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState(this ComPtr<ID3D12Device7> thisVtbl, ref ComputePipelineStateDesc pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[11])(@this, pDescPtr, riid, ppPipelineState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState(this ComPtr<ID3D12Device7> thisVtbl, ref ComputePipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[11])(@this, pDescPtr, riid, ppPipelineStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState(this ComPtr<ID3D12Device7> thisVtbl, ref ComputePipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[11])(@this, pDescPtr, riidPtr, ppPipelineState);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState(this ComPtr<ID3D12Device7> thisVtbl, ref ComputePipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[11])(@this, pDescPtr, riidPtr, ppPipelineStatePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, Guid* riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialState, riid, ppCommandList);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, Guid* riid, ref void* ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppCommandListPtr = &ppCommandList)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialState, riid, ppCommandListPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, ref Guid riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialState, riidPtr, ppCommandList);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, ref Guid riid, ref void* ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppCommandListPtr = &ppCommandList)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialState, riidPtr, ppCommandListPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ref ID3D12PipelineState pInitialState, Guid* riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialStatePtr, riid, ppCommandList);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ref ID3D12PipelineState pInitialState, Guid* riid, ref void* ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
        {
            fixed (void** ppCommandListPtr = &ppCommandList)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialStatePtr, riid, ppCommandListPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ref ID3D12PipelineState pInitialState, ref Guid riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialStatePtr, riidPtr, ppCommandList);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ref ID3D12PipelineState pInitialState, ref Guid riid, ref void* ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppCommandListPtr = &ppCommandList)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialStatePtr, riidPtr, ppCommandListPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState* pInitialState, Guid* riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialState, riid, ppCommandList);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState* pInitialState, Guid* riid, ref void* ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
        {
            fixed (void** ppCommandListPtr = &ppCommandList)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialState, riid, ppCommandListPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState* pInitialState, ref Guid riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialState, riidPtr, ppCommandList);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState* pInitialState, ref Guid riid, ref void* ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppCommandListPtr = &ppCommandList)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialState, riidPtr, ppCommandListPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ref ID3D12PipelineState pInitialState, Guid* riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
        {
            fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialStatePtr, riid, ppCommandList);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ref ID3D12PipelineState pInitialState, Guid* riid, ref void* ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
        {
            fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
            {
                fixed (void** ppCommandListPtr = &ppCommandList)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialStatePtr, riid, ppCommandListPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ref ID3D12PipelineState pInitialState, ref Guid riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
        {
            fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialStatePtr, riidPtr, ppCommandList);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ref ID3D12PipelineState pInitialState, ref Guid riid, ref void* ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
        {
            fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppCommandListPtr = &ppCommandList)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialStatePtr, riidPtr, ppCommandListPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckFeatureSupport(this ComPtr<ID3D12Device7> thisVtbl, Feature Feature, void* pFeatureSupportData, uint FeatureSupportDataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Feature, void*, uint, int>)@this->LpVtbl[13])(@this, Feature, pFeatureSupportData, FeatureSupportDataSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckFeatureSupport<T0>(this ComPtr<ID3D12Device7> thisVtbl, Feature Feature, ref T0 pFeatureSupportData, uint FeatureSupportDataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pFeatureSupportDataPtr = &pFeatureSupportData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Feature, void*, uint, int>)@this->LpVtbl[13])(@this, Feature, pFeatureSupportDataPtr, FeatureSupportDataSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap(this ComPtr<ID3D12Device7> thisVtbl, DescriptorHeapDesc* pDescriptorHeapDesc, Guid* riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, DescriptorHeapDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescriptorHeapDesc, riid, ppvHeap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap(this ComPtr<ID3D12Device7> thisVtbl, DescriptorHeapDesc* pDescriptorHeapDesc, Guid* riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvHeapPtr = &ppvHeap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, DescriptorHeapDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescriptorHeapDesc, riid, ppvHeapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap(this ComPtr<ID3D12Device7> thisVtbl, DescriptorHeapDesc* pDescriptorHeapDesc, ref Guid riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, DescriptorHeapDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescriptorHeapDesc, riidPtr, ppvHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap(this ComPtr<ID3D12Device7> thisVtbl, DescriptorHeapDesc* pDescriptorHeapDesc, ref Guid riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, DescriptorHeapDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescriptorHeapDesc, riidPtr, ppvHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap(this ComPtr<ID3D12Device7> thisVtbl, ref DescriptorHeapDesc pDescriptorHeapDesc, Guid* riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DescriptorHeapDesc* pDescriptorHeapDescPtr = &pDescriptorHeapDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, DescriptorHeapDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescriptorHeapDescPtr, riid, ppvHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap(this ComPtr<ID3D12Device7> thisVtbl, ref DescriptorHeapDesc pDescriptorHeapDesc, Guid* riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DescriptorHeapDesc* pDescriptorHeapDescPtr = &pDescriptorHeapDesc)
        {
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, DescriptorHeapDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescriptorHeapDescPtr, riid, ppvHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap(this ComPtr<ID3D12Device7> thisVtbl, ref DescriptorHeapDesc pDescriptorHeapDesc, ref Guid riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DescriptorHeapDesc* pDescriptorHeapDescPtr = &pDescriptorHeapDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, DescriptorHeapDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescriptorHeapDescPtr, riidPtr, ppvHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap(this ComPtr<ID3D12Device7> thisVtbl, ref DescriptorHeapDesc pDescriptorHeapDesc, ref Guid riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DescriptorHeapDesc* pDescriptorHeapDescPtr = &pDescriptorHeapDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, DescriptorHeapDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescriptorHeapDescPtr, riidPtr, ppvHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetDescriptorHandleIncrementSize(this ComPtr<ID3D12Device7> thisVtbl, DescriptorHeapType DescriptorHeapType)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, DescriptorHeapType, uint>)@this->LpVtbl[15])(@this, DescriptorHeapType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, void* pBlobWithRootSignature, nuint blobLengthInBytes, Guid* riid, void** ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[16])(@this, nodeMask, pBlobWithRootSignature, blobLengthInBytes, riid, ppvRootSignature);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, void* pBlobWithRootSignature, nuint blobLengthInBytes, Guid* riid, ref void* ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[16])(@this, nodeMask, pBlobWithRootSignature, blobLengthInBytes, riid, ppvRootSignaturePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, void* pBlobWithRootSignature, nuint blobLengthInBytes, ref Guid riid, void** ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[16])(@this, nodeMask, pBlobWithRootSignature, blobLengthInBytes, riidPtr, ppvRootSignature);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, void* pBlobWithRootSignature, nuint blobLengthInBytes, ref Guid riid, ref void* ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[16])(@this, nodeMask, pBlobWithRootSignature, blobLengthInBytes, riidPtr, ppvRootSignaturePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature<T0>(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, ref T0 pBlobWithRootSignature, nuint blobLengthInBytes, Guid* riid, void** ppvRootSignature) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pBlobWithRootSignaturePtr = &pBlobWithRootSignature)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[16])(@this, nodeMask, pBlobWithRootSignaturePtr, blobLengthInBytes, riid, ppvRootSignature);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature<T0>(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, ref T0 pBlobWithRootSignature, nuint blobLengthInBytes, Guid* riid, ref void* ppvRootSignature) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pBlobWithRootSignaturePtr = &pBlobWithRootSignature)
        {
            fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[16])(@this, nodeMask, pBlobWithRootSignaturePtr, blobLengthInBytes, riid, ppvRootSignaturePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature<T0>(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, ref T0 pBlobWithRootSignature, nuint blobLengthInBytes, ref Guid riid, void** ppvRootSignature) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pBlobWithRootSignaturePtr = &pBlobWithRootSignature)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[16])(@this, nodeMask, pBlobWithRootSignaturePtr, blobLengthInBytes, riidPtr, ppvRootSignature);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature<T0>(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, ref T0 pBlobWithRootSignature, nuint blobLengthInBytes, ref Guid riid, ref void* ppvRootSignature) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pBlobWithRootSignaturePtr = &pBlobWithRootSignature)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[16])(@this, nodeMask, pBlobWithRootSignaturePtr, blobLengthInBytes, riidPtr, ppvRootSignaturePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateConstantBufferView(this ComPtr<ID3D12Device7> thisVtbl, ConstantBufferViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ConstantBufferViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[17])(@this, pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static void CreateConstantBufferView(this ComPtr<ID3D12Device7> thisVtbl, ref ConstantBufferViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (ConstantBufferViewDesc* pDescPtr = &pDesc)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ConstantBufferViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[17])(@this, pDescPtr, DestDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateShaderResourceView(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pResource, ShaderResourceViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, ShaderResourceViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[18])(@this, pResource, pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateShaderResourceView(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pResource, ref ShaderResourceViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (ShaderResourceViewDesc* pDescPtr = &pDesc)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, ShaderResourceViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[18])(@this, pResource, pDescPtr, DestDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateShaderResourceView(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pResource, ShaderResourceViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, ShaderResourceViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[18])(@this, pResourcePtr, pDesc, DestDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static void CreateShaderResourceView(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pResource, ref ShaderResourceViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (ShaderResourceViewDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, ShaderResourceViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[18])(@this, pResourcePtr, pDescPtr, DestDescriptor);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pResource, ID3D12Resource* pCounterResource, UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[19])(@this, pResource, pCounterResource, pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pResource, ID3D12Resource* pCounterResource, ref UnorderedAccessViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (UnorderedAccessViewDesc* pDescPtr = &pDesc)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[19])(@this, pResource, pCounterResource, pDescPtr, DestDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pResource, ref ID3D12Resource pCounterResource, UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pCounterResourcePtr = &pCounterResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[19])(@this, pResource, pCounterResourcePtr, pDesc, DestDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pResource, ref ID3D12Resource pCounterResource, ref UnorderedAccessViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pCounterResourcePtr = &pCounterResource)
        {
            fixed (UnorderedAccessViewDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[19])(@this, pResource, pCounterResourcePtr, pDescPtr, DestDescriptor);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pResource, ID3D12Resource* pCounterResource, UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[19])(@this, pResourcePtr, pCounterResource, pDesc, DestDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pResource, ID3D12Resource* pCounterResource, ref UnorderedAccessViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (UnorderedAccessViewDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[19])(@this, pResourcePtr, pCounterResource, pDescPtr, DestDescriptor);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pResource, ref ID3D12Resource pCounterResource, UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D12Resource* pCounterResourcePtr = &pCounterResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[19])(@this, pResourcePtr, pCounterResourcePtr, pDesc, DestDescriptor);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void CreateUnorderedAccessView(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pResource, ref ID3D12Resource pCounterResource, ref UnorderedAccessViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D12Resource* pCounterResourcePtr = &pCounterResource)
            {
                fixed (UnorderedAccessViewDesc* pDescPtr = &pDesc)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[19])(@this, pResourcePtr, pCounterResourcePtr, pDescPtr, DestDescriptor);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateRenderTargetView(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pResource, RenderTargetViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, RenderTargetViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[20])(@this, pResource, pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateRenderTargetView(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pResource, ref RenderTargetViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (RenderTargetViewDesc* pDescPtr = &pDesc)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, RenderTargetViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[20])(@this, pResource, pDescPtr, DestDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateRenderTargetView(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pResource, RenderTargetViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, RenderTargetViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[20])(@this, pResourcePtr, pDesc, DestDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static void CreateRenderTargetView(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pResource, ref RenderTargetViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (RenderTargetViewDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, RenderTargetViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[20])(@this, pResourcePtr, pDescPtr, DestDescriptor);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateDepthStencilView(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pResource, DepthStencilViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, DepthStencilViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[21])(@this, pResource, pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateDepthStencilView(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pResource, ref DepthStencilViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (DepthStencilViewDesc* pDescPtr = &pDesc)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, DepthStencilViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[21])(@this, pResource, pDescPtr, DestDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateDepthStencilView(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pResource, DepthStencilViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, DepthStencilViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[21])(@this, pResourcePtr, pDesc, DestDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static void CreateDepthStencilView(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pResource, ref DepthStencilViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (DepthStencilViewDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, DepthStencilViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[21])(@this, pResourcePtr, pDescPtr, DestDescriptor);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateSampler(this ComPtr<ID3D12Device7> thisVtbl, SamplerDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, SamplerDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[22])(@this, pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static void CreateSampler(this ComPtr<ID3D12Device7> thisVtbl, ref SamplerDesc pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (SamplerDesc* pDescPtr = &pDesc)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, SamplerDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[22])(@this, pDescPtr, DestDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device7> thisVtbl, uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device7> thisVtbl, uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, ref uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device7> thisVtbl, uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, ref CpuDescriptorHandle pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizes, DescriptorHeapsType);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device7> thisVtbl, uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, ref CpuDescriptorHandle pSrcDescriptorRangeStarts, ref uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
        {
            fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device7> thisVtbl, uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, ref uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device7> thisVtbl, uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, ref uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, ref uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
        {
            fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device7> thisVtbl, uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, ref uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, ref CpuDescriptorHandle pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
        {
            fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizes, DescriptorHeapsType);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device7> thisVtbl, uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, ref uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, ref CpuDescriptorHandle pSrcDescriptorRangeStarts, ref uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
        {
            fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
            {
                fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device7> thisVtbl, uint NumDestDescriptorRanges, ref CpuDescriptorHandle pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device7> thisVtbl, uint NumDestDescriptorRanges, ref CpuDescriptorHandle pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, ref uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
        {
            fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device7> thisVtbl, uint NumDestDescriptorRanges, ref CpuDescriptorHandle pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, ref CpuDescriptorHandle pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
        {
            fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizes, DescriptorHeapsType);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device7> thisVtbl, uint NumDestDescriptorRanges, ref CpuDescriptorHandle pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, ref CpuDescriptorHandle pSrcDescriptorRangeStarts, ref uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
        {
            fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
            {
                fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device7> thisVtbl, uint NumDestDescriptorRanges, ref CpuDescriptorHandle pDestDescriptorRangeStarts, ref uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
        {
            fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device7> thisVtbl, uint NumDestDescriptorRanges, ref CpuDescriptorHandle pDestDescriptorRangeStarts, ref uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, ref uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
        {
            fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
            {
                fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device7> thisVtbl, uint NumDestDescriptorRanges, ref CpuDescriptorHandle pDestDescriptorRangeStarts, ref uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, ref CpuDescriptorHandle pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
        {
            fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
            {
                fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizes, DescriptorHeapsType);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void CopyDescriptors(this ComPtr<ID3D12Device7> thisVtbl, uint NumDestDescriptorRanges, ref CpuDescriptorHandle pDestDescriptorRangeStarts, ref uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, ref CpuDescriptorHandle pSrcDescriptorRangeStarts, ref uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
        {
            fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
            {
                fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
                {
                    fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void CopyDescriptorsSimple(this ComPtr<ID3D12Device7> thisVtbl, uint NumDescriptors, CpuDescriptorHandle DestDescriptorRangeStart, CpuDescriptorHandle SrcDescriptorRangeStart, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CpuDescriptorHandle, CpuDescriptorHandle, DescriptorHeapType, void>)@this->LpVtbl[24])(@this, NumDescriptors, DestDescriptorRangeStart, SrcDescriptorRangeStart, DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe ResourceAllocationInfo GetResourceAllocationInfo(this ComPtr<ID3D12Device7> thisVtbl, uint visibleMask, uint numResourceDescs, ResourceDesc* pResourceDescs)
    {
        var @this = thisVtbl.Handle;
        ResourceAllocationInfo silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        ResourceAllocationInfo* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceAllocationInfo*, uint, uint, ResourceDesc*, ResourceAllocationInfo*>)@this->LpVtbl[25])(@this, pSilkDotNetReturnFixupResult, visibleMask, numResourceDescs, pResourceDescs);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static ResourceAllocationInfo GetResourceAllocationInfo(this ComPtr<ID3D12Device7> thisVtbl, uint visibleMask, uint numResourceDescs, ref ResourceDesc pResourceDescs)
    {
        var @this = thisVtbl.Handle;
        ResourceAllocationInfo silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        ResourceAllocationInfo* ret = default;
        fixed (ResourceDesc* pResourceDescsPtr = &pResourceDescs)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceAllocationInfo*, uint, uint, ResourceDesc*, ResourceAllocationInfo*>)@this->LpVtbl[25])(@this, pSilkDotNetReturnFixupResult, visibleMask, numResourceDescs, pResourceDescsPtr);
        }
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static HeapProperties GetCustomHeapProperties(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, HeapType heapType)
    {
        var @this = thisVtbl.Handle;
        HeapProperties silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        HeapProperties* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, uint, HeapType, HeapProperties*>)@this->LpVtbl[26])(@this, pSilkDotNetReturnFixupResult, nodeMask, heapType);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvResourcePtr = &ppvResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResourcePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidResourcePtr = &riidResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidResourcePtr = &riidResource)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResource, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResource, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResource);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap(this ComPtr<ID3D12Device7> thisVtbl, HeapDesc* pDesc, Guid* riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, Guid*, void**, int>)@this->LpVtbl[28])(@this, pDesc, riid, ppvHeap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap(this ComPtr<ID3D12Device7> thisVtbl, HeapDesc* pDesc, Guid* riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvHeapPtr = &ppvHeap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, Guid*, void**, int>)@this->LpVtbl[28])(@this, pDesc, riid, ppvHeapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap(this ComPtr<ID3D12Device7> thisVtbl, HeapDesc* pDesc, ref Guid riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, Guid*, void**, int>)@this->LpVtbl[28])(@this, pDesc, riidPtr, ppvHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap(this ComPtr<ID3D12Device7> thisVtbl, HeapDesc* pDesc, ref Guid riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, Guid*, void**, int>)@this->LpVtbl[28])(@this, pDesc, riidPtr, ppvHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap(this ComPtr<ID3D12Device7> thisVtbl, ref HeapDesc pDesc, Guid* riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, Guid*, void**, int>)@this->LpVtbl[28])(@this, pDescPtr, riid, ppvHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap(this ComPtr<ID3D12Device7> thisVtbl, ref HeapDesc pDesc, Guid* riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, Guid*, void**, int>)@this->LpVtbl[28])(@this, pDescPtr, riid, ppvHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap(this ComPtr<ID3D12Device7> thisVtbl, ref HeapDesc pDesc, ref Guid riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, Guid*, void**, int>)@this->LpVtbl[28])(@this, pDescPtr, riidPtr, ppvHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap(this ComPtr<ID3D12Device7> thisVtbl, ref HeapDesc pDesc, ref Guid riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, Guid*, void**, int>)@this->LpVtbl[28])(@this, pDescPtr, riidPtr, ppvHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvResourcePtr = &ppvResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvResourcePtr = &ppvResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, ID3D12DeviceChild* pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, char* Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributes, Access, Name, pHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, ID3D12DeviceChild* pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, char* Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** pHandlePtr = &pHandle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributes, Access, Name, pHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, ID3D12DeviceChild* pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, ref char Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributes, Access, NamePtr, pHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, ID3D12DeviceChild* pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, ref char Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* NamePtr = &Name)
        {
            fixed (void** pHandlePtr = &pHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributes, Access, NamePtr, pHandlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, ID3D12DeviceChild* pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributes, Access, NamePtr, pHandle);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, ID3D12DeviceChild* pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
        fixed (void** pHandlePtr = &pHandle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributes, Access, NamePtr, pHandlePtr);
        }
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, ID3D12DeviceChild* pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, char* Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributesPtr, Access, Name, pHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, ID3D12DeviceChild* pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, char* Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
        {
            fixed (void** pHandlePtr = &pHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributesPtr, Access, Name, pHandlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, ID3D12DeviceChild* pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, ref char Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
        {
            fixed (char* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributesPtr, Access, NamePtr, pHandle);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, ID3D12DeviceChild* pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, ref char Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
        {
            fixed (char* NamePtr = &Name)
            {
                fixed (void** pHandlePtr = &pHandle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributesPtr, Access, NamePtr, pHandlePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, ID3D12DeviceChild* pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
        {
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributesPtr, Access, NamePtr, pHandle);
        SilkMarshal.Free((nint)NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, ID3D12DeviceChild* pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
        {
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
            fixed (void** pHandlePtr = &pHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributesPtr, Access, NamePtr, pHandlePtr);
            }
        SilkMarshal.Free((nint)NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12DeviceChild pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, char* Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, Name, pHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12DeviceChild pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, char* Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
            fixed (void** pHandlePtr = &pHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, Name, pHandlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12DeviceChild pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, ref char Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
            fixed (char* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, NamePtr, pHandle);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12DeviceChild pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, ref char Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
            fixed (char* NamePtr = &Name)
            {
                fixed (void** pHandlePtr = &pHandle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, NamePtr, pHandlePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12DeviceChild pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, NamePtr, pHandle);
        SilkMarshal.Free((nint)NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12DeviceChild pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
            fixed (void** pHandlePtr = &pHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, NamePtr, pHandlePtr);
            }
        SilkMarshal.Free((nint)NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12DeviceChild pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, char* Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, Name, pHandle);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12DeviceChild pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, char* Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
                fixed (void** pHandlePtr = &pHandle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, Name, pHandlePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12DeviceChild pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, ref char Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
                fixed (char* NamePtr = &Name)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, NamePtr, pHandle);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12DeviceChild pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, ref char Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
                fixed (char* NamePtr = &Name)
                {
                    fixed (void** pHandlePtr = &pHandle)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, NamePtr, pHandlePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12DeviceChild pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, NamePtr, pHandle);
        SilkMarshal.Free((nint)NamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12DeviceChild pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
                fixed (void** pHandlePtr = &pHandle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, NamePtr, pHandlePtr);
                }
        SilkMarshal.Free((nint)NamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, void* NTHandle, Guid* riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[32])(@this, NTHandle, riid, ppvObj);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, void* NTHandle, Guid* riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjPtr = &ppvObj)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[32])(@this, NTHandle, riid, ppvObjPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, void* NTHandle, ref Guid riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[32])(@this, NTHandle, riidPtr, ppvObj);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, void* NTHandle, ref Guid riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjPtr = &ppvObj)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[32])(@this, NTHandle, riidPtr, ppvObjPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle<T0>(this ComPtr<ID3D12Device7> thisVtbl, ref T0 NTHandle, Guid* riid, void** ppvObj) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* NTHandlePtr = &NTHandle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[32])(@this, NTHandlePtr, riid, ppvObj);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle<T0>(this ComPtr<ID3D12Device7> thisVtbl, ref T0 NTHandle, Guid* riid, ref void* ppvObj) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* NTHandlePtr = &NTHandle)
        {
            fixed (void** ppvObjPtr = &ppvObj)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[32])(@this, NTHandlePtr, riid, ppvObjPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle<T0>(this ComPtr<ID3D12Device7> thisVtbl, ref T0 NTHandle, ref Guid riid, void** ppvObj) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* NTHandlePtr = &NTHandle)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[32])(@this, NTHandlePtr, riidPtr, ppvObj);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle<T0>(this ComPtr<ID3D12Device7> thisVtbl, ref T0 NTHandle, ref Guid riid, ref void* ppvObj) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* NTHandlePtr = &NTHandle)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjPtr = &ppvObj)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[32])(@this, NTHandlePtr, riidPtr, ppvObjPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandleByName(this ComPtr<ID3D12Device7> thisVtbl, char* Name, uint Access, void** pNTHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, char*, uint, void**, int>)@this->LpVtbl[33])(@this, Name, Access, pNTHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandleByName(this ComPtr<ID3D12Device7> thisVtbl, char* Name, uint Access, ref void* pNTHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** pNTHandlePtr = &pNTHandle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, char*, uint, void**, int>)@this->LpVtbl[33])(@this, Name, Access, pNTHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandleByName(this ComPtr<ID3D12Device7> thisVtbl, ref char Name, uint Access, void** pNTHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, char*, uint, void**, int>)@this->LpVtbl[33])(@this, NamePtr, Access, pNTHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandleByName(this ComPtr<ID3D12Device7> thisVtbl, ref char Name, uint Access, ref void* pNTHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* NamePtr = &Name)
        {
            fixed (void** pNTHandlePtr = &pNTHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, char*, uint, void**, int>)@this->LpVtbl[33])(@this, NamePtr, Access, pNTHandlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandleByName(this ComPtr<ID3D12Device7> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, uint Access, void** pNTHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, byte*, uint, void**, int>)@this->LpVtbl[33])(@this, NamePtr, Access, pNTHandle);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandleByName(this ComPtr<ID3D12Device7> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, uint Access, ref void* pNTHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
        fixed (void** pNTHandlePtr = &pNTHandle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, byte*, uint, void**, int>)@this->LpVtbl[33])(@this, NamePtr, Access, pNTHandlePtr);
        }
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MakeResident(this ComPtr<ID3D12Device7> thisVtbl, uint NumObjects, ID3D12Pageable** ppObjects)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, ID3D12Pageable**, int>)@this->LpVtbl[34])(@this, NumObjects, ppObjects);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MakeResident(this ComPtr<ID3D12Device7> thisVtbl, uint NumObjects, ref ID3D12Pageable* ppObjects)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Pageable** ppObjectsPtr = &ppObjects)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, ID3D12Pageable**, int>)@this->LpVtbl[34])(@this, NumObjects, ppObjectsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Evict(this ComPtr<ID3D12Device7> thisVtbl, uint NumObjects, ID3D12Pageable** ppObjects)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, ID3D12Pageable**, int>)@this->LpVtbl[35])(@this, NumObjects, ppObjects);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Evict(this ComPtr<ID3D12Device7> thisVtbl, uint NumObjects, ref ID3D12Pageable* ppObjects)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Pageable** ppObjectsPtr = &ppObjects)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, ID3D12Pageable**, int>)@this->LpVtbl[35])(@this, NumObjects, ppObjectsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFence(this ComPtr<ID3D12Device7> thisVtbl, ulong InitialValue, FenceFlags Flags, Guid* riid, void** ppFence)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ulong, FenceFlags, Guid*, void**, int>)@this->LpVtbl[36])(@this, InitialValue, Flags, riid, ppFence);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFence(this ComPtr<ID3D12Device7> thisVtbl, ulong InitialValue, FenceFlags Flags, Guid* riid, ref void* ppFence)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppFencePtr = &ppFence)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ulong, FenceFlags, Guid*, void**, int>)@this->LpVtbl[36])(@this, InitialValue, Flags, riid, ppFencePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFence(this ComPtr<ID3D12Device7> thisVtbl, ulong InitialValue, FenceFlags Flags, ref Guid riid, void** ppFence)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ulong, FenceFlags, Guid*, void**, int>)@this->LpVtbl[36])(@this, InitialValue, Flags, riidPtr, ppFence);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFence(this ComPtr<ID3D12Device7> thisVtbl, ulong InitialValue, FenceFlags Flags, ref Guid riid, ref void* ppFence)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppFencePtr = &ppFence)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ulong, FenceFlags, Guid*, void**, int>)@this->LpVtbl[36])(@this, InitialValue, Flags, riidPtr, ppFencePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDeviceRemovedReason(this ComPtr<ID3D12Device7> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, int>)@this->LpVtbl[37])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ulong* pTotalBytesPtr = &pTotalBytes)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytesPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytesPtr, pTotalBytes);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
        {
            fixed (ulong* pTotalBytesPtr = &pTotalBytes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytesPtr, pTotalBytesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumRowsPtr = &pNumRows)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytes, pTotalBytes);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumRowsPtr = &pNumRows)
        {
            fixed (ulong* pTotalBytesPtr = &pTotalBytes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytes, pTotalBytesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumRowsPtr = &pNumRows)
        {
            fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytes);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumRowsPtr = &pNumRows)
        {
            fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
            {
                fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytes, pTotalBytes);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
        {
            fixed (ulong* pTotalBytesPtr = &pTotalBytes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytes, pTotalBytesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
        {
            fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytesPtr, pTotalBytes);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
        {
            fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
            {
                fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytesPtr, pTotalBytesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
        {
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytes, pTotalBytes);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
        {
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytes, pTotalBytesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
        {
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytes);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
        {
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytesPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytes);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (ulong* pTotalBytesPtr = &pTotalBytes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytesPtr, pTotalBytes);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
            {
                fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytesPtr, pTotalBytesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytes, pTotalBytes);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytes, pTotalBytesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytes);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytesPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytes, pTotalBytes);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytes, pTotalBytesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytesPtr, pTotalBytes);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytesPtr, pTotalBytesPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytes, pTotalBytes);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytes, pTotalBytesPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytes);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                    {
                        fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytesPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap(this ComPtr<ID3D12Device7> thisVtbl, QueryHeapDesc* pDesc, Guid* riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, QueryHeapDesc*, Guid*, void**, int>)@this->LpVtbl[39])(@this, pDesc, riid, ppvHeap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap(this ComPtr<ID3D12Device7> thisVtbl, QueryHeapDesc* pDesc, Guid* riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvHeapPtr = &ppvHeap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, QueryHeapDesc*, Guid*, void**, int>)@this->LpVtbl[39])(@this, pDesc, riid, ppvHeapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap(this ComPtr<ID3D12Device7> thisVtbl, QueryHeapDesc* pDesc, ref Guid riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, QueryHeapDesc*, Guid*, void**, int>)@this->LpVtbl[39])(@this, pDesc, riidPtr, ppvHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap(this ComPtr<ID3D12Device7> thisVtbl, QueryHeapDesc* pDesc, ref Guid riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, QueryHeapDesc*, Guid*, void**, int>)@this->LpVtbl[39])(@this, pDesc, riidPtr, ppvHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap(this ComPtr<ID3D12Device7> thisVtbl, ref QueryHeapDesc pDesc, Guid* riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (QueryHeapDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, QueryHeapDesc*, Guid*, void**, int>)@this->LpVtbl[39])(@this, pDescPtr, riid, ppvHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap(this ComPtr<ID3D12Device7> thisVtbl, ref QueryHeapDesc pDesc, Guid* riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (QueryHeapDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, QueryHeapDesc*, Guid*, void**, int>)@this->LpVtbl[39])(@this, pDescPtr, riid, ppvHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap(this ComPtr<ID3D12Device7> thisVtbl, ref QueryHeapDesc pDesc, ref Guid riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (QueryHeapDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, QueryHeapDesc*, Guid*, void**, int>)@this->LpVtbl[39])(@this, pDescPtr, riidPtr, ppvHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap(this ComPtr<ID3D12Device7> thisVtbl, ref QueryHeapDesc pDesc, ref Guid riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (QueryHeapDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, QueryHeapDesc*, Guid*, void**, int>)@this->LpVtbl[39])(@this, pDescPtr, riidPtr, ppvHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetStablePowerState(this ComPtr<ID3D12Device7> thisVtbl, int Enable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, int, int>)@this->LpVtbl[40])(@this, Enable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device7> thisVtbl, CommandSignatureDesc* pDesc, ID3D12RootSignature* pRootSignature, Guid* riid, void** ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDesc, pRootSignature, riid, ppvCommandSignature);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device7> thisVtbl, CommandSignatureDesc* pDesc, ID3D12RootSignature* pRootSignature, Guid* riid, ref void* ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDesc, pRootSignature, riid, ppvCommandSignaturePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device7> thisVtbl, CommandSignatureDesc* pDesc, ID3D12RootSignature* pRootSignature, ref Guid riid, void** ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDesc, pRootSignature, riidPtr, ppvCommandSignature);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device7> thisVtbl, CommandSignatureDesc* pDesc, ID3D12RootSignature* pRootSignature, ref Guid riid, ref void* ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDesc, pRootSignature, riidPtr, ppvCommandSignaturePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device7> thisVtbl, CommandSignatureDesc* pDesc, ref ID3D12RootSignature pRootSignature, Guid* riid, void** ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDesc, pRootSignaturePtr, riid, ppvCommandSignature);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device7> thisVtbl, CommandSignatureDesc* pDesc, ref ID3D12RootSignature pRootSignature, Guid* riid, ref void* ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
        {
            fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDesc, pRootSignaturePtr, riid, ppvCommandSignaturePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device7> thisVtbl, CommandSignatureDesc* pDesc, ref ID3D12RootSignature pRootSignature, ref Guid riid, void** ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDesc, pRootSignaturePtr, riidPtr, ppvCommandSignature);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device7> thisVtbl, CommandSignatureDesc* pDesc, ref ID3D12RootSignature pRootSignature, ref Guid riid, ref void* ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDesc, pRootSignaturePtr, riidPtr, ppvCommandSignaturePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device7> thisVtbl, ref CommandSignatureDesc pDesc, ID3D12RootSignature* pRootSignature, Guid* riid, void** ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CommandSignatureDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDescPtr, pRootSignature, riid, ppvCommandSignature);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device7> thisVtbl, ref CommandSignatureDesc pDesc, ID3D12RootSignature* pRootSignature, Guid* riid, ref void* ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CommandSignatureDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDescPtr, pRootSignature, riid, ppvCommandSignaturePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device7> thisVtbl, ref CommandSignatureDesc pDesc, ID3D12RootSignature* pRootSignature, ref Guid riid, void** ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CommandSignatureDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDescPtr, pRootSignature, riidPtr, ppvCommandSignature);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device7> thisVtbl, ref CommandSignatureDesc pDesc, ID3D12RootSignature* pRootSignature, ref Guid riid, ref void* ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CommandSignatureDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDescPtr, pRootSignature, riidPtr, ppvCommandSignaturePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device7> thisVtbl, ref CommandSignatureDesc pDesc, ref ID3D12RootSignature pRootSignature, Guid* riid, void** ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CommandSignatureDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDescPtr, pRootSignaturePtr, riid, ppvCommandSignature);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device7> thisVtbl, ref CommandSignatureDesc pDesc, ref ID3D12RootSignature pRootSignature, Guid* riid, ref void* ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CommandSignatureDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
            {
                fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDescPtr, pRootSignaturePtr, riid, ppvCommandSignaturePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device7> thisVtbl, ref CommandSignatureDesc pDesc, ref ID3D12RootSignature pRootSignature, ref Guid riid, void** ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CommandSignatureDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDescPtr, pRootSignaturePtr, riidPtr, ppvCommandSignature);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device7> thisVtbl, ref CommandSignatureDesc pDesc, ref ID3D12RootSignature pRootSignature, ref Guid riid, ref void* ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CommandSignatureDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDescPtr, pRootSignaturePtr, riidPtr, ppvCommandSignaturePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
        {
            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
        {
            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
        {
            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
        {
            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
        {
            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
        {
            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
        {
            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                        {
                            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                            }
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static Luid GetAdapterLuid(this ComPtr<ID3D12Device7> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Luid ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Luid>)@this->LpVtbl[43])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineLibrary(this ComPtr<ID3D12Device7> thisVtbl, void* pLibraryBlob, nuint BlobLength, Guid* riid, void** ppPipelineLibrary)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[44])(@this, pLibraryBlob, BlobLength, riid, ppPipelineLibrary);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineLibrary(this ComPtr<ID3D12Device7> thisVtbl, void* pLibraryBlob, nuint BlobLength, Guid* riid, ref void* ppPipelineLibrary)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppPipelineLibraryPtr = &ppPipelineLibrary)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[44])(@this, pLibraryBlob, BlobLength, riid, ppPipelineLibraryPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineLibrary(this ComPtr<ID3D12Device7> thisVtbl, void* pLibraryBlob, nuint BlobLength, ref Guid riid, void** ppPipelineLibrary)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[44])(@this, pLibraryBlob, BlobLength, riidPtr, ppPipelineLibrary);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineLibrary(this ComPtr<ID3D12Device7> thisVtbl, void* pLibraryBlob, nuint BlobLength, ref Guid riid, ref void* ppPipelineLibrary)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppPipelineLibraryPtr = &ppPipelineLibrary)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[44])(@this, pLibraryBlob, BlobLength, riidPtr, ppPipelineLibraryPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineLibrary<T0>(this ComPtr<ID3D12Device7> thisVtbl, ref T0 pLibraryBlob, nuint BlobLength, Guid* riid, void** ppPipelineLibrary) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pLibraryBlobPtr = &pLibraryBlob)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[44])(@this, pLibraryBlobPtr, BlobLength, riid, ppPipelineLibrary);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineLibrary<T0>(this ComPtr<ID3D12Device7> thisVtbl, ref T0 pLibraryBlob, nuint BlobLength, Guid* riid, ref void* ppPipelineLibrary) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pLibraryBlobPtr = &pLibraryBlob)
        {
            fixed (void** ppPipelineLibraryPtr = &ppPipelineLibrary)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[44])(@this, pLibraryBlobPtr, BlobLength, riid, ppPipelineLibraryPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineLibrary<T0>(this ComPtr<ID3D12Device7> thisVtbl, ref T0 pLibraryBlob, nuint BlobLength, ref Guid riid, void** ppPipelineLibrary) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pLibraryBlobPtr = &pLibraryBlob)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[44])(@this, pLibraryBlobPtr, BlobLength, riidPtr, ppPipelineLibrary);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineLibrary<T0>(this ComPtr<ID3D12Device7> thisVtbl, ref T0 pLibraryBlob, nuint BlobLength, ref Guid riid, ref void* ppPipelineLibrary) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pLibraryBlobPtr = &pLibraryBlob)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineLibraryPtr = &ppPipelineLibrary)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[44])(@this, pLibraryBlobPtr, BlobLength, riidPtr, ppPipelineLibraryPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEventOnMultipleFenceCompletion(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Fence** ppFences, ulong* pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, void* hEvent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Fence**, ulong*, uint, MultipleFenceWaitFlags, void*, int>)@this->LpVtbl[45])(@this, ppFences, pFenceValues, NumFences, Flags, hEvent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEventOnMultipleFenceCompletion<T0>(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Fence** ppFences, ulong* pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, ref T0 hEvent) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hEventPtr = &hEvent)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Fence**, ulong*, uint, MultipleFenceWaitFlags, void*, int>)@this->LpVtbl[45])(@this, ppFences, pFenceValues, NumFences, Flags, hEventPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEventOnMultipleFenceCompletion(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Fence** ppFences, ref ulong pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, void* hEvent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* pFenceValuesPtr = &pFenceValues)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Fence**, ulong*, uint, MultipleFenceWaitFlags, void*, int>)@this->LpVtbl[45])(@this, ppFences, pFenceValuesPtr, NumFences, Flags, hEvent);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEventOnMultipleFenceCompletion<T0>(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Fence** ppFences, ref ulong pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, ref T0 hEvent) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* pFenceValuesPtr = &pFenceValues)
        {
            fixed (void* hEventPtr = &hEvent)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Fence**, ulong*, uint, MultipleFenceWaitFlags, void*, int>)@this->LpVtbl[45])(@this, ppFences, pFenceValuesPtr, NumFences, Flags, hEventPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEventOnMultipleFenceCompletion(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Fence* ppFences, ulong* pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, void* hEvent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Fence** ppFencesPtr = &ppFences)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Fence**, ulong*, uint, MultipleFenceWaitFlags, void*, int>)@this->LpVtbl[45])(@this, ppFencesPtr, pFenceValues, NumFences, Flags, hEvent);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEventOnMultipleFenceCompletion<T0>(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Fence* ppFences, ulong* pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, ref T0 hEvent) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Fence** ppFencesPtr = &ppFences)
        {
            fixed (void* hEventPtr = &hEvent)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Fence**, ulong*, uint, MultipleFenceWaitFlags, void*, int>)@this->LpVtbl[45])(@this, ppFencesPtr, pFenceValues, NumFences, Flags, hEventPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEventOnMultipleFenceCompletion(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Fence* ppFences, ref ulong pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, void* hEvent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Fence** ppFencesPtr = &ppFences)
        {
            fixed (ulong* pFenceValuesPtr = &pFenceValues)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Fence**, ulong*, uint, MultipleFenceWaitFlags, void*, int>)@this->LpVtbl[45])(@this, ppFencesPtr, pFenceValuesPtr, NumFences, Flags, hEvent);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEventOnMultipleFenceCompletion<T0>(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Fence* ppFences, ref ulong pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, ref T0 hEvent) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Fence** ppFencesPtr = &ppFences)
        {
            fixed (ulong* pFenceValuesPtr = &pFenceValues)
            {
                fixed (void* hEventPtr = &hEvent)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Fence**, ulong*, uint, MultipleFenceWaitFlags, void*, int>)@this->LpVtbl[45])(@this, ppFencesPtr, pFenceValuesPtr, NumFences, Flags, hEventPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetResidencyPriority(this ComPtr<ID3D12Device7> thisVtbl, uint NumObjects, ID3D12Pageable** ppObjects, ResidencyPriority* pPriorities)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, ID3D12Pageable**, ResidencyPriority*, int>)@this->LpVtbl[46])(@this, NumObjects, ppObjects, pPriorities);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetResidencyPriority(this ComPtr<ID3D12Device7> thisVtbl, uint NumObjects, ID3D12Pageable** ppObjects, ref ResidencyPriority pPriorities)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResidencyPriority* pPrioritiesPtr = &pPriorities)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, ID3D12Pageable**, ResidencyPriority*, int>)@this->LpVtbl[46])(@this, NumObjects, ppObjects, pPrioritiesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetResidencyPriority(this ComPtr<ID3D12Device7> thisVtbl, uint NumObjects, ref ID3D12Pageable* ppObjects, ResidencyPriority* pPriorities)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Pageable** ppObjectsPtr = &ppObjects)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, ID3D12Pageable**, ResidencyPriority*, int>)@this->LpVtbl[46])(@this, NumObjects, ppObjectsPtr, pPriorities);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetResidencyPriority(this ComPtr<ID3D12Device7> thisVtbl, uint NumObjects, ref ID3D12Pageable* ppObjects, ref ResidencyPriority pPriorities)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Pageable** ppObjectsPtr = &ppObjects)
        {
            fixed (ResidencyPriority* pPrioritiesPtr = &pPriorities)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, ID3D12Pageable**, ResidencyPriority*, int>)@this->LpVtbl[46])(@this, NumObjects, ppObjectsPtr, pPrioritiesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineState(this ComPtr<ID3D12Device7> thisVtbl, PipelineStateStreamDesc* pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[47])(@this, pDesc, riid, ppPipelineState);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineState(this ComPtr<ID3D12Device7> thisVtbl, PipelineStateStreamDesc* pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppPipelineStatePtr = &ppPipelineState)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[47])(@this, pDesc, riid, ppPipelineStatePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineState(this ComPtr<ID3D12Device7> thisVtbl, PipelineStateStreamDesc* pDesc, ref Guid riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[47])(@this, pDesc, riidPtr, ppPipelineState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineState(this ComPtr<ID3D12Device7> thisVtbl, PipelineStateStreamDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[47])(@this, pDesc, riidPtr, ppPipelineStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineState(this ComPtr<ID3D12Device7> thisVtbl, ref PipelineStateStreamDesc pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[47])(@this, pDescPtr, riid, ppPipelineState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineState(this ComPtr<ID3D12Device7> thisVtbl, ref PipelineStateStreamDesc pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[47])(@this, pDescPtr, riid, ppPipelineStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineState(this ComPtr<ID3D12Device7> thisVtbl, ref PipelineStateStreamDesc pDesc, ref Guid riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[47])(@this, pDescPtr, riidPtr, ppPipelineState);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineState(this ComPtr<ID3D12Device7> thisVtbl, ref PipelineStateStreamDesc pDesc, ref Guid riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[47])(@this, pDescPtr, riidPtr, ppPipelineStatePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromAddress(this ComPtr<ID3D12Device7> thisVtbl, void* pAddress, Guid* riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[48])(@this, pAddress, riid, ppvHeap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromAddress(this ComPtr<ID3D12Device7> thisVtbl, void* pAddress, Guid* riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvHeapPtr = &ppvHeap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[48])(@this, pAddress, riid, ppvHeapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromAddress(this ComPtr<ID3D12Device7> thisVtbl, void* pAddress, ref Guid riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[48])(@this, pAddress, riidPtr, ppvHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromAddress(this ComPtr<ID3D12Device7> thisVtbl, void* pAddress, ref Guid riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[48])(@this, pAddress, riidPtr, ppvHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromAddress<T0>(this ComPtr<ID3D12Device7> thisVtbl, ref T0 pAddress, Guid* riid, void** ppvHeap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pAddressPtr = &pAddress)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[48])(@this, pAddressPtr, riid, ppvHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromAddress<T0>(this ComPtr<ID3D12Device7> thisVtbl, ref T0 pAddress, Guid* riid, ref void* ppvHeap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pAddressPtr = &pAddress)
        {
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[48])(@this, pAddressPtr, riid, ppvHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromAddress<T0>(this ComPtr<ID3D12Device7> thisVtbl, ref T0 pAddress, ref Guid riid, void** ppvHeap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pAddressPtr = &pAddress)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[48])(@this, pAddressPtr, riidPtr, ppvHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromAddress<T0>(this ComPtr<ID3D12Device7> thisVtbl, ref T0 pAddress, ref Guid riid, ref void* ppvHeap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pAddressPtr = &pAddress)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[48])(@this, pAddressPtr, riidPtr, ppvHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromFileMapping(this ComPtr<ID3D12Device7> thisVtbl, void* hFileMapping, Guid* riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[49])(@this, hFileMapping, riid, ppvHeap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromFileMapping(this ComPtr<ID3D12Device7> thisVtbl, void* hFileMapping, Guid* riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvHeapPtr = &ppvHeap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[49])(@this, hFileMapping, riid, ppvHeapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromFileMapping(this ComPtr<ID3D12Device7> thisVtbl, void* hFileMapping, ref Guid riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[49])(@this, hFileMapping, riidPtr, ppvHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromFileMapping(this ComPtr<ID3D12Device7> thisVtbl, void* hFileMapping, ref Guid riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[49])(@this, hFileMapping, riidPtr, ppvHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromFileMapping<T0>(this ComPtr<ID3D12Device7> thisVtbl, ref T0 hFileMapping, Guid* riid, void** ppvHeap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hFileMappingPtr = &hFileMapping)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[49])(@this, hFileMappingPtr, riid, ppvHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromFileMapping<T0>(this ComPtr<ID3D12Device7> thisVtbl, ref T0 hFileMapping, Guid* riid, ref void* ppvHeap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hFileMappingPtr = &hFileMapping)
        {
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[49])(@this, hFileMappingPtr, riid, ppvHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromFileMapping<T0>(this ComPtr<ID3D12Device7> thisVtbl, ref T0 hFileMapping, ref Guid riid, void** ppvHeap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hFileMappingPtr = &hFileMapping)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[49])(@this, hFileMappingPtr, riidPtr, ppvHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromFileMapping<T0>(this ComPtr<ID3D12Device7> thisVtbl, ref T0 hFileMapping, ref Guid riid, ref void* ppvHeap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hFileMappingPtr = &hFileMapping)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[49])(@this, hFileMappingPtr, riidPtr, ppvHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnqueueMakeResident(this ComPtr<ID3D12Device7> thisVtbl, ResidencyFlags Flags, uint NumObjects, ID3D12Pageable** ppObjects, ID3D12Fence* pFenceToSignal, ulong FenceValueToSignal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResidencyFlags, uint, ID3D12Pageable**, ID3D12Fence*, ulong, int>)@this->LpVtbl[50])(@this, Flags, NumObjects, ppObjects, pFenceToSignal, FenceValueToSignal);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnqueueMakeResident(this ComPtr<ID3D12Device7> thisVtbl, ResidencyFlags Flags, uint NumObjects, ID3D12Pageable** ppObjects, ref ID3D12Fence pFenceToSignal, ulong FenceValueToSignal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Fence* pFenceToSignalPtr = &pFenceToSignal)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResidencyFlags, uint, ID3D12Pageable**, ID3D12Fence*, ulong, int>)@this->LpVtbl[50])(@this, Flags, NumObjects, ppObjects, pFenceToSignalPtr, FenceValueToSignal);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnqueueMakeResident(this ComPtr<ID3D12Device7> thisVtbl, ResidencyFlags Flags, uint NumObjects, ref ID3D12Pageable* ppObjects, ID3D12Fence* pFenceToSignal, ulong FenceValueToSignal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Pageable** ppObjectsPtr = &ppObjects)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResidencyFlags, uint, ID3D12Pageable**, ID3D12Fence*, ulong, int>)@this->LpVtbl[50])(@this, Flags, NumObjects, ppObjectsPtr, pFenceToSignal, FenceValueToSignal);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnqueueMakeResident(this ComPtr<ID3D12Device7> thisVtbl, ResidencyFlags Flags, uint NumObjects, ref ID3D12Pageable* ppObjects, ref ID3D12Fence pFenceToSignal, ulong FenceValueToSignal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Pageable** ppObjectsPtr = &ppObjects)
        {
            fixed (ID3D12Fence* pFenceToSignalPtr = &pFenceToSignal)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResidencyFlags, uint, ID3D12Pageable**, ID3D12Fence*, ulong, int>)@this->LpVtbl[50])(@this, Flags, NumObjects, ppObjectsPtr, pFenceToSignalPtr, FenceValueToSignal);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList1(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, CommandListFlags flags, Guid* riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, CommandListFlags, Guid*, void**, int>)@this->LpVtbl[51])(@this, nodeMask, type, flags, riid, ppCommandList);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList1(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, CommandListFlags flags, Guid* riid, ref void* ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppCommandListPtr = &ppCommandList)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, CommandListFlags, Guid*, void**, int>)@this->LpVtbl[51])(@this, nodeMask, type, flags, riid, ppCommandListPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList1(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, CommandListFlags flags, ref Guid riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, CommandListFlags, Guid*, void**, int>)@this->LpVtbl[51])(@this, nodeMask, type, flags, riidPtr, ppCommandList);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList1(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, CommandListFlags flags, ref Guid riid, ref void* ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppCommandListPtr = &ppCommandList)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, CommandListFlags, Guid*, void**, int>)@this->LpVtbl[51])(@this, nodeMask, type, flags, riidPtr, ppCommandListPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession(this ComPtr<ID3D12Device7> thisVtbl, ProtectedResourceSessionDesc* pDesc, Guid* riid, void** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ProtectedResourceSessionDesc*, Guid*, void**, int>)@this->LpVtbl[52])(@this, pDesc, riid, ppSession);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession(this ComPtr<ID3D12Device7> thisVtbl, ProtectedResourceSessionDesc* pDesc, Guid* riid, ref void* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppSessionPtr = &ppSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ProtectedResourceSessionDesc*, Guid*, void**, int>)@this->LpVtbl[52])(@this, pDesc, riid, ppSessionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession(this ComPtr<ID3D12Device7> thisVtbl, ProtectedResourceSessionDesc* pDesc, ref Guid riid, void** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ProtectedResourceSessionDesc*, Guid*, void**, int>)@this->LpVtbl[52])(@this, pDesc, riidPtr, ppSession);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession(this ComPtr<ID3D12Device7> thisVtbl, ProtectedResourceSessionDesc* pDesc, ref Guid riid, ref void* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ProtectedResourceSessionDesc*, Guid*, void**, int>)@this->LpVtbl[52])(@this, pDesc, riidPtr, ppSessionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession(this ComPtr<ID3D12Device7> thisVtbl, ref ProtectedResourceSessionDesc pDesc, Guid* riid, void** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ProtectedResourceSessionDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ProtectedResourceSessionDesc*, Guid*, void**, int>)@this->LpVtbl[52])(@this, pDescPtr, riid, ppSession);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession(this ComPtr<ID3D12Device7> thisVtbl, ref ProtectedResourceSessionDesc pDesc, Guid* riid, ref void* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ProtectedResourceSessionDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ProtectedResourceSessionDesc*, Guid*, void**, int>)@this->LpVtbl[52])(@this, pDescPtr, riid, ppSessionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession(this ComPtr<ID3D12Device7> thisVtbl, ref ProtectedResourceSessionDesc pDesc, ref Guid riid, void** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ProtectedResourceSessionDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ProtectedResourceSessionDesc*, Guid*, void**, int>)@this->LpVtbl[52])(@this, pDescPtr, riidPtr, ppSession);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession(this ComPtr<ID3D12Device7> thisVtbl, ref ProtectedResourceSessionDesc pDesc, ref Guid riid, ref void* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ProtectedResourceSessionDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ProtectedResourceSessionDesc*, Guid*, void**, int>)@this->LpVtbl[52])(@this, pDescPtr, riidPtr, ppSessionPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvResourcePtr = &ppvResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResourcePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidResourcePtr = &riidResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidResourcePtr = &riidResource)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
        {
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
        {
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResource);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResource);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (Guid* riidResourcePtr = &riidResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (Guid* riidResourcePtr = &riidResource)
                        {
                            fixed (void** ppvResourcePtr = &ppvResource)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                            }
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1(this ComPtr<ID3D12Device7> thisVtbl, HeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDesc, pProtectedSession, riid, ppvHeap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1(this ComPtr<ID3D12Device7> thisVtbl, HeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvHeapPtr = &ppvHeap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDesc, pProtectedSession, riid, ppvHeapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1(this ComPtr<ID3D12Device7> thisVtbl, HeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDesc, pProtectedSession, riidPtr, ppvHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1(this ComPtr<ID3D12Device7> thisVtbl, HeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDesc, pProtectedSession, riidPtr, ppvHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1(this ComPtr<ID3D12Device7> thisVtbl, HeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDesc, pProtectedSessionPtr, riid, ppvHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1(this ComPtr<ID3D12Device7> thisVtbl, HeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
        {
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDesc, pProtectedSessionPtr, riid, ppvHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1(this ComPtr<ID3D12Device7> thisVtbl, HeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDesc, pProtectedSessionPtr, riidPtr, ppvHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1(this ComPtr<ID3D12Device7> thisVtbl, HeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDesc, pProtectedSessionPtr, riidPtr, ppvHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDescPtr, pProtectedSession, riid, ppvHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDescPtr, pProtectedSession, riid, ppvHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDescPtr, pProtectedSession, riidPtr, ppvHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDescPtr, pProtectedSession, riidPtr, ppvHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDescPtr, pProtectedSessionPtr, riid, ppvHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDescPtr, pProtectedSessionPtr, riid, ppvHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDescPtr, pProtectedSessionPtr, riidPtr, ppvHeap);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1(this ComPtr<ID3D12Device7> thisVtbl, ref HeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvHeapPtr = &ppvHeap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDescPtr, pProtectedSessionPtr, riidPtr, ppvHeapPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValue, pProtectedSession, riid, ppvResource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvResourcePtr = &ppvResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValue, pProtectedSession, riid, ppvResourcePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValue, pProtectedSession, riidPtr, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValue, pProtectedSession, riidPtr, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValue, pProtectedSessionPtr, riid, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValue, pProtectedSessionPtr, riid, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValue, pProtectedSessionPtr, riidPtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValue, pProtectedSessionPtr, riidPtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValuePtr, pProtectedSession, riid, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValuePtr, pProtectedSession, riid, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValuePtr, pProtectedSession, riidPtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValuePtr, pProtectedSession, riidPtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValuePtr, pProtectedSessionPtr, riid, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValuePtr, pProtectedSessionPtr, riid, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidPtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidPtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValue, pProtectedSession, riid, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValue, pProtectedSession, riid, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValue, pProtectedSession, riidPtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValue, pProtectedSession, riidPtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValue, pProtectedSessionPtr, riid, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValue, pProtectedSessionPtr, riid, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValue, pProtectedSessionPtr, riidPtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValue, pProtectedSessionPtr, riidPtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, pProtectedSession, riid, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, pProtectedSession, riid, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, pProtectedSession, riidPtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, pProtectedSession, riidPtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, pProtectedSessionPtr, riid, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, pProtectedSessionPtr, riid, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidPtr, ppvResource);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidPtr, ppvResourcePtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ResourceAllocationInfo GetResourceAllocationInfo1(this ComPtr<ID3D12Device7> thisVtbl, uint visibleMask, uint numResourceDescs, ResourceDesc* pResourceDescs, ResourceAllocationInfo1* pResourceAllocationInfo1)
    {
        var @this = thisVtbl.Handle;
        ResourceAllocationInfo silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        ResourceAllocationInfo* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceAllocationInfo*, uint, uint, ResourceDesc*, ResourceAllocationInfo1*, ResourceAllocationInfo*>)@this->LpVtbl[56])(@this, pSilkDotNetReturnFixupResult, visibleMask, numResourceDescs, pResourceDescs, pResourceAllocationInfo1);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ResourceAllocationInfo GetResourceAllocationInfo1(this ComPtr<ID3D12Device7> thisVtbl, uint visibleMask, uint numResourceDescs, ResourceDesc* pResourceDescs, ref ResourceAllocationInfo1 pResourceAllocationInfo1)
    {
        var @this = thisVtbl.Handle;
        ResourceAllocationInfo silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        ResourceAllocationInfo* ret = default;
        fixed (ResourceAllocationInfo1* pResourceAllocationInfo1Ptr = &pResourceAllocationInfo1)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceAllocationInfo*, uint, uint, ResourceDesc*, ResourceAllocationInfo1*, ResourceAllocationInfo*>)@this->LpVtbl[56])(@this, pSilkDotNetReturnFixupResult, visibleMask, numResourceDescs, pResourceDescs, pResourceAllocationInfo1Ptr);
        }
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ResourceAllocationInfo GetResourceAllocationInfo1(this ComPtr<ID3D12Device7> thisVtbl, uint visibleMask, uint numResourceDescs, ref ResourceDesc pResourceDescs, ResourceAllocationInfo1* pResourceAllocationInfo1)
    {
        var @this = thisVtbl.Handle;
        ResourceAllocationInfo silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        ResourceAllocationInfo* ret = default;
        fixed (ResourceDesc* pResourceDescsPtr = &pResourceDescs)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceAllocationInfo*, uint, uint, ResourceDesc*, ResourceAllocationInfo1*, ResourceAllocationInfo*>)@this->LpVtbl[56])(@this, pSilkDotNetReturnFixupResult, visibleMask, numResourceDescs, pResourceDescsPtr, pResourceAllocationInfo1);
        }
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static ResourceAllocationInfo GetResourceAllocationInfo1(this ComPtr<ID3D12Device7> thisVtbl, uint visibleMask, uint numResourceDescs, ref ResourceDesc pResourceDescs, ref ResourceAllocationInfo1 pResourceAllocationInfo1)
    {
        var @this = thisVtbl.Handle;
        ResourceAllocationInfo silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        ResourceAllocationInfo* ret = default;
        fixed (ResourceDesc* pResourceDescsPtr = &pResourceDescs)
        {
            fixed (ResourceAllocationInfo1* pResourceAllocationInfo1Ptr = &pResourceAllocationInfo1)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceAllocationInfo*, uint, uint, ResourceDesc*, ResourceAllocationInfo1*, ResourceAllocationInfo*>)@this->LpVtbl[56])(@this, pSilkDotNetReturnFixupResult, visibleMask, numResourceDescs, pResourceDescsPtr, pResourceAllocationInfo1Ptr);
            }
        }
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLifetimeTracker(this ComPtr<ID3D12Device7> thisVtbl, ID3D12LifetimeOwner* pOwner, Guid* riid, void** ppvTracker)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12LifetimeOwner*, Guid*, void**, int>)@this->LpVtbl[57])(@this, pOwner, riid, ppvTracker);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLifetimeTracker(this ComPtr<ID3D12Device7> thisVtbl, ID3D12LifetimeOwner* pOwner, Guid* riid, ref void* ppvTracker)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvTrackerPtr = &ppvTracker)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12LifetimeOwner*, Guid*, void**, int>)@this->LpVtbl[57])(@this, pOwner, riid, ppvTrackerPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLifetimeTracker(this ComPtr<ID3D12Device7> thisVtbl, ID3D12LifetimeOwner* pOwner, ref Guid riid, void** ppvTracker)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12LifetimeOwner*, Guid*, void**, int>)@this->LpVtbl[57])(@this, pOwner, riidPtr, ppvTracker);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLifetimeTracker(this ComPtr<ID3D12Device7> thisVtbl, ID3D12LifetimeOwner* pOwner, ref Guid riid, ref void* ppvTracker)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvTrackerPtr = &ppvTracker)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12LifetimeOwner*, Guid*, void**, int>)@this->LpVtbl[57])(@this, pOwner, riidPtr, ppvTrackerPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLifetimeTracker(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12LifetimeOwner pOwner, Guid* riid, void** ppvTracker)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12LifetimeOwner* pOwnerPtr = &pOwner)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12LifetimeOwner*, Guid*, void**, int>)@this->LpVtbl[57])(@this, pOwnerPtr, riid, ppvTracker);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLifetimeTracker(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12LifetimeOwner pOwner, Guid* riid, ref void* ppvTracker)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12LifetimeOwner* pOwnerPtr = &pOwner)
        {
            fixed (void** ppvTrackerPtr = &ppvTracker)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12LifetimeOwner*, Guid*, void**, int>)@this->LpVtbl[57])(@this, pOwnerPtr, riid, ppvTrackerPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLifetimeTracker(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12LifetimeOwner pOwner, ref Guid riid, void** ppvTracker)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12LifetimeOwner* pOwnerPtr = &pOwner)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12LifetimeOwner*, Guid*, void**, int>)@this->LpVtbl[57])(@this, pOwnerPtr, riidPtr, ppvTracker);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLifetimeTracker(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12LifetimeOwner pOwner, ref Guid riid, ref void* ppvTracker)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12LifetimeOwner* pOwnerPtr = &pOwner)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvTrackerPtr = &ppvTracker)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12LifetimeOwner*, Guid*, void**, int>)@this->LpVtbl[57])(@this, pOwnerPtr, riidPtr, ppvTrackerPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void RemoveDevice(this ComPtr<ID3D12Device7> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void>)@this->LpVtbl[58])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommands(this ComPtr<ID3D12Device7> thisVtbl, uint* pNumMetaCommands, MetaCommandDesc* pDescs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint*, MetaCommandDesc*, int>)@this->LpVtbl[59])(@this, pNumMetaCommands, pDescs);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommands(this ComPtr<ID3D12Device7> thisVtbl, uint* pNumMetaCommands, ref MetaCommandDesc pDescs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (MetaCommandDesc* pDescsPtr = &pDescs)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint*, MetaCommandDesc*, int>)@this->LpVtbl[59])(@this, pNumMetaCommands, pDescsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommands(this ComPtr<ID3D12Device7> thisVtbl, ref uint pNumMetaCommands, MetaCommandDesc* pDescs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pNumMetaCommandsPtr = &pNumMetaCommands)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint*, MetaCommandDesc*, int>)@this->LpVtbl[59])(@this, pNumMetaCommandsPtr, pDescs);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EnumerateMetaCommands(this ComPtr<ID3D12Device7> thisVtbl, ref uint pNumMetaCommands, ref MetaCommandDesc pDescs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pNumMetaCommandsPtr = &pNumMetaCommands)
        {
            fixed (MetaCommandDesc* pDescsPtr = &pDescs)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint*, MetaCommandDesc*, int>)@this->LpVtbl[59])(@this, pNumMetaCommandsPtr, pDescsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters(this ComPtr<ID3D12Device7> thisVtbl, Guid* CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, uint* pParameterCount, MetaCommandParameterDesc* pParameterDescs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandId, Stage, pTotalStructureSizeInBytes, pParameterCount, pParameterDescs);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters(this ComPtr<ID3D12Device7> thisVtbl, Guid* CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, uint* pParameterCount, ref MetaCommandParameterDesc pParameterDescs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (MetaCommandParameterDesc* pParameterDescsPtr = &pParameterDescs)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandId, Stage, pTotalStructureSizeInBytes, pParameterCount, pParameterDescsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters(this ComPtr<ID3D12Device7> thisVtbl, Guid* CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, ref uint pParameterCount, MetaCommandParameterDesc* pParameterDescs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pParameterCountPtr = &pParameterCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandId, Stage, pTotalStructureSizeInBytes, pParameterCountPtr, pParameterDescs);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters(this ComPtr<ID3D12Device7> thisVtbl, Guid* CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, ref uint pParameterCount, ref MetaCommandParameterDesc pParameterDescs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pParameterCountPtr = &pParameterCount)
        {
            fixed (MetaCommandParameterDesc* pParameterDescsPtr = &pParameterDescs)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandId, Stage, pTotalStructureSizeInBytes, pParameterCountPtr, pParameterDescsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters(this ComPtr<ID3D12Device7> thisVtbl, Guid* CommandId, MetaCommandParameterStage Stage, ref uint pTotalStructureSizeInBytes, uint* pParameterCount, MetaCommandParameterDesc* pParameterDescs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pTotalStructureSizeInBytesPtr = &pTotalStructureSizeInBytes)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandId, Stage, pTotalStructureSizeInBytesPtr, pParameterCount, pParameterDescs);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters(this ComPtr<ID3D12Device7> thisVtbl, Guid* CommandId, MetaCommandParameterStage Stage, ref uint pTotalStructureSizeInBytes, uint* pParameterCount, ref MetaCommandParameterDesc pParameterDescs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pTotalStructureSizeInBytesPtr = &pTotalStructureSizeInBytes)
        {
            fixed (MetaCommandParameterDesc* pParameterDescsPtr = &pParameterDescs)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandId, Stage, pTotalStructureSizeInBytesPtr, pParameterCount, pParameterDescsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters(this ComPtr<ID3D12Device7> thisVtbl, Guid* CommandId, MetaCommandParameterStage Stage, ref uint pTotalStructureSizeInBytes, ref uint pParameterCount, MetaCommandParameterDesc* pParameterDescs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pTotalStructureSizeInBytesPtr = &pTotalStructureSizeInBytes)
        {
            fixed (uint* pParameterCountPtr = &pParameterCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandId, Stage, pTotalStructureSizeInBytesPtr, pParameterCountPtr, pParameterDescs);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters(this ComPtr<ID3D12Device7> thisVtbl, Guid* CommandId, MetaCommandParameterStage Stage, ref uint pTotalStructureSizeInBytes, ref uint pParameterCount, ref MetaCommandParameterDesc pParameterDescs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pTotalStructureSizeInBytesPtr = &pTotalStructureSizeInBytes)
        {
            fixed (uint* pParameterCountPtr = &pParameterCount)
            {
                fixed (MetaCommandParameterDesc* pParameterDescsPtr = &pParameterDescs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandId, Stage, pTotalStructureSizeInBytesPtr, pParameterCountPtr, pParameterDescsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters(this ComPtr<ID3D12Device7> thisVtbl, ref Guid CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, uint* pParameterCount, MetaCommandParameterDesc* pParameterDescs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* CommandIdPtr = &CommandId)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandIdPtr, Stage, pTotalStructureSizeInBytes, pParameterCount, pParameterDescs);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters(this ComPtr<ID3D12Device7> thisVtbl, ref Guid CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, uint* pParameterCount, ref MetaCommandParameterDesc pParameterDescs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* CommandIdPtr = &CommandId)
        {
            fixed (MetaCommandParameterDesc* pParameterDescsPtr = &pParameterDescs)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandIdPtr, Stage, pTotalStructureSizeInBytes, pParameterCount, pParameterDescsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters(this ComPtr<ID3D12Device7> thisVtbl, ref Guid CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, ref uint pParameterCount, MetaCommandParameterDesc* pParameterDescs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* CommandIdPtr = &CommandId)
        {
            fixed (uint* pParameterCountPtr = &pParameterCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandIdPtr, Stage, pTotalStructureSizeInBytes, pParameterCountPtr, pParameterDescs);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters(this ComPtr<ID3D12Device7> thisVtbl, ref Guid CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, ref uint pParameterCount, ref MetaCommandParameterDesc pParameterDescs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* CommandIdPtr = &CommandId)
        {
            fixed (uint* pParameterCountPtr = &pParameterCount)
            {
                fixed (MetaCommandParameterDesc* pParameterDescsPtr = &pParameterDescs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandIdPtr, Stage, pTotalStructureSizeInBytes, pParameterCountPtr, pParameterDescsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters(this ComPtr<ID3D12Device7> thisVtbl, ref Guid CommandId, MetaCommandParameterStage Stage, ref uint pTotalStructureSizeInBytes, uint* pParameterCount, MetaCommandParameterDesc* pParameterDescs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* CommandIdPtr = &CommandId)
        {
            fixed (uint* pTotalStructureSizeInBytesPtr = &pTotalStructureSizeInBytes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandIdPtr, Stage, pTotalStructureSizeInBytesPtr, pParameterCount, pParameterDescs);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters(this ComPtr<ID3D12Device7> thisVtbl, ref Guid CommandId, MetaCommandParameterStage Stage, ref uint pTotalStructureSizeInBytes, uint* pParameterCount, ref MetaCommandParameterDesc pParameterDescs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* CommandIdPtr = &CommandId)
        {
            fixed (uint* pTotalStructureSizeInBytesPtr = &pTotalStructureSizeInBytes)
            {
                fixed (MetaCommandParameterDesc* pParameterDescsPtr = &pParameterDescs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandIdPtr, Stage, pTotalStructureSizeInBytesPtr, pParameterCount, pParameterDescsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters(this ComPtr<ID3D12Device7> thisVtbl, ref Guid CommandId, MetaCommandParameterStage Stage, ref uint pTotalStructureSizeInBytes, ref uint pParameterCount, MetaCommandParameterDesc* pParameterDescs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* CommandIdPtr = &CommandId)
        {
            fixed (uint* pTotalStructureSizeInBytesPtr = &pTotalStructureSizeInBytes)
            {
                fixed (uint* pParameterCountPtr = &pParameterCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandIdPtr, Stage, pTotalStructureSizeInBytesPtr, pParameterCountPtr, pParameterDescs);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EnumerateMetaCommandParameters(this ComPtr<ID3D12Device7> thisVtbl, ref Guid CommandId, MetaCommandParameterStage Stage, ref uint pTotalStructureSizeInBytes, ref uint pParameterCount, ref MetaCommandParameterDesc pParameterDescs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* CommandIdPtr = &CommandId)
        {
            fixed (uint* pTotalStructureSizeInBytesPtr = &pTotalStructureSizeInBytes)
            {
                fixed (uint* pParameterCountPtr = &pParameterCount)
                {
                    fixed (MetaCommandParameterDesc* pParameterDescsPtr = &pParameterDescs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandIdPtr, Stage, pTotalStructureSizeInBytesPtr, pParameterCountPtr, pParameterDescsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand(this ComPtr<ID3D12Device7> thisVtbl, Guid* CommandId, uint NodeMask, void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, void** ppMetaCommand)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandId, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riid, ppMetaCommand);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand(this ComPtr<ID3D12Device7> thisVtbl, Guid* CommandId, uint NodeMask, void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, ref void* ppMetaCommand)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppMetaCommandPtr = &ppMetaCommand)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandId, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riid, ppMetaCommandPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand(this ComPtr<ID3D12Device7> thisVtbl, Guid* CommandId, uint NodeMask, void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, ref Guid riid, void** ppMetaCommand)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandId, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riidPtr, ppMetaCommand);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand(this ComPtr<ID3D12Device7> thisVtbl, Guid* CommandId, uint NodeMask, void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, ref Guid riid, ref void* ppMetaCommand)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppMetaCommandPtr = &ppMetaCommand)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandId, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riidPtr, ppMetaCommandPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<T0>(this ComPtr<ID3D12Device7> thisVtbl, Guid* CommandId, uint NodeMask, ref T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, void** ppMetaCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pCreationParametersDataPtr = &pCreationParametersData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandId, NodeMask, pCreationParametersDataPtr, CreationParametersDataSizeInBytes, riid, ppMetaCommand);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<T0>(this ComPtr<ID3D12Device7> thisVtbl, Guid* CommandId, uint NodeMask, ref T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, ref void* ppMetaCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pCreationParametersDataPtr = &pCreationParametersData)
        {
            fixed (void** ppMetaCommandPtr = &ppMetaCommand)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandId, NodeMask, pCreationParametersDataPtr, CreationParametersDataSizeInBytes, riid, ppMetaCommandPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<T0>(this ComPtr<ID3D12Device7> thisVtbl, Guid* CommandId, uint NodeMask, ref T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, ref Guid riid, void** ppMetaCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pCreationParametersDataPtr = &pCreationParametersData)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandId, NodeMask, pCreationParametersDataPtr, CreationParametersDataSizeInBytes, riidPtr, ppMetaCommand);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<T0>(this ComPtr<ID3D12Device7> thisVtbl, Guid* CommandId, uint NodeMask, ref T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, ref Guid riid, ref void* ppMetaCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pCreationParametersDataPtr = &pCreationParametersData)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppMetaCommandPtr = &ppMetaCommand)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandId, NodeMask, pCreationParametersDataPtr, CreationParametersDataSizeInBytes, riidPtr, ppMetaCommandPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand(this ComPtr<ID3D12Device7> thisVtbl, ref Guid CommandId, uint NodeMask, void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, void** ppMetaCommand)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* CommandIdPtr = &CommandId)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandIdPtr, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riid, ppMetaCommand);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand(this ComPtr<ID3D12Device7> thisVtbl, ref Guid CommandId, uint NodeMask, void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, ref void* ppMetaCommand)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* CommandIdPtr = &CommandId)
        {
            fixed (void** ppMetaCommandPtr = &ppMetaCommand)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandIdPtr, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riid, ppMetaCommandPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand(this ComPtr<ID3D12Device7> thisVtbl, ref Guid CommandId, uint NodeMask, void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, ref Guid riid, void** ppMetaCommand)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* CommandIdPtr = &CommandId)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandIdPtr, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riidPtr, ppMetaCommand);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand(this ComPtr<ID3D12Device7> thisVtbl, ref Guid CommandId, uint NodeMask, void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, ref Guid riid, ref void* ppMetaCommand)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* CommandIdPtr = &CommandId)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppMetaCommandPtr = &ppMetaCommand)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandIdPtr, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riidPtr, ppMetaCommandPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<T0>(this ComPtr<ID3D12Device7> thisVtbl, ref Guid CommandId, uint NodeMask, ref T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, void** ppMetaCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* CommandIdPtr = &CommandId)
        {
            fixed (void* pCreationParametersDataPtr = &pCreationParametersData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandIdPtr, NodeMask, pCreationParametersDataPtr, CreationParametersDataSizeInBytes, riid, ppMetaCommand);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<T0>(this ComPtr<ID3D12Device7> thisVtbl, ref Guid CommandId, uint NodeMask, ref T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, ref void* ppMetaCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* CommandIdPtr = &CommandId)
        {
            fixed (void* pCreationParametersDataPtr = &pCreationParametersData)
            {
                fixed (void** ppMetaCommandPtr = &ppMetaCommand)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandIdPtr, NodeMask, pCreationParametersDataPtr, CreationParametersDataSizeInBytes, riid, ppMetaCommandPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<T0>(this ComPtr<ID3D12Device7> thisVtbl, ref Guid CommandId, uint NodeMask, ref T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, ref Guid riid, void** ppMetaCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* CommandIdPtr = &CommandId)
        {
            fixed (void* pCreationParametersDataPtr = &pCreationParametersData)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandIdPtr, NodeMask, pCreationParametersDataPtr, CreationParametersDataSizeInBytes, riidPtr, ppMetaCommand);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<T0>(this ComPtr<ID3D12Device7> thisVtbl, ref Guid CommandId, uint NodeMask, ref T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, ref Guid riid, ref void* ppMetaCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* CommandIdPtr = &CommandId)
        {
            fixed (void* pCreationParametersDataPtr = &pCreationParametersData)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppMetaCommandPtr = &ppMetaCommand)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandIdPtr, NodeMask, pCreationParametersDataPtr, CreationParametersDataSizeInBytes, riidPtr, ppMetaCommandPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObject(this ComPtr<ID3D12Device7> thisVtbl, StateObjectDesc* pDesc, Guid* riid, void** ppStateObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[62])(@this, pDesc, riid, ppStateObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObject(this ComPtr<ID3D12Device7> thisVtbl, StateObjectDesc* pDesc, Guid* riid, ref void* ppStateObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppStateObjectPtr = &ppStateObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[62])(@this, pDesc, riid, ppStateObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObject(this ComPtr<ID3D12Device7> thisVtbl, StateObjectDesc* pDesc, ref Guid riid, void** ppStateObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[62])(@this, pDesc, riidPtr, ppStateObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObject(this ComPtr<ID3D12Device7> thisVtbl, StateObjectDesc* pDesc, ref Guid riid, ref void* ppStateObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppStateObjectPtr = &ppStateObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[62])(@this, pDesc, riidPtr, ppStateObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObject(this ComPtr<ID3D12Device7> thisVtbl, ref StateObjectDesc pDesc, Guid* riid, void** ppStateObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (StateObjectDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[62])(@this, pDescPtr, riid, ppStateObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObject(this ComPtr<ID3D12Device7> thisVtbl, ref StateObjectDesc pDesc, Guid* riid, ref void* ppStateObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (StateObjectDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppStateObjectPtr = &ppStateObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[62])(@this, pDescPtr, riid, ppStateObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObject(this ComPtr<ID3D12Device7> thisVtbl, ref StateObjectDesc pDesc, ref Guid riid, void** ppStateObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (StateObjectDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[62])(@this, pDescPtr, riidPtr, ppStateObject);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObject(this ComPtr<ID3D12Device7> thisVtbl, ref StateObjectDesc pDesc, ref Guid riid, ref void* ppStateObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (StateObjectDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppStateObjectPtr = &ppStateObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[62])(@this, pDescPtr, riidPtr, ppStateObjectPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetRaytracingAccelerationStructurePrebuildInfo(this ComPtr<ID3D12Device7> thisVtbl, BuildRaytracingAccelerationStructureInputs* pDesc, RaytracingAccelerationStructurePrebuildInfo* pInfo)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, BuildRaytracingAccelerationStructureInputs*, RaytracingAccelerationStructurePrebuildInfo*, void>)@this->LpVtbl[63])(@this, pDesc, pInfo);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetRaytracingAccelerationStructurePrebuildInfo(this ComPtr<ID3D12Device7> thisVtbl, BuildRaytracingAccelerationStructureInputs* pDesc, ref RaytracingAccelerationStructurePrebuildInfo pInfo)
    {
        var @this = thisVtbl.Handle;
        fixed (RaytracingAccelerationStructurePrebuildInfo* pInfoPtr = &pInfo)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, BuildRaytracingAccelerationStructureInputs*, RaytracingAccelerationStructurePrebuildInfo*, void>)@this->LpVtbl[63])(@this, pDesc, pInfoPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetRaytracingAccelerationStructurePrebuildInfo(this ComPtr<ID3D12Device7> thisVtbl, ref BuildRaytracingAccelerationStructureInputs pDesc, RaytracingAccelerationStructurePrebuildInfo* pInfo)
    {
        var @this = thisVtbl.Handle;
        fixed (BuildRaytracingAccelerationStructureInputs* pDescPtr = &pDesc)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, BuildRaytracingAccelerationStructureInputs*, RaytracingAccelerationStructurePrebuildInfo*, void>)@this->LpVtbl[63])(@this, pDescPtr, pInfo);
        }
    }

    /// <summary>To be documented.</summary>
    public static void GetRaytracingAccelerationStructurePrebuildInfo(this ComPtr<ID3D12Device7> thisVtbl, ref BuildRaytracingAccelerationStructureInputs pDesc, ref RaytracingAccelerationStructurePrebuildInfo pInfo)
    {
        var @this = thisVtbl.Handle;
        fixed (BuildRaytracingAccelerationStructureInputs* pDescPtr = &pDesc)
        {
            fixed (RaytracingAccelerationStructurePrebuildInfo* pInfoPtr = &pInfo)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, BuildRaytracingAccelerationStructureInputs*, RaytracingAccelerationStructurePrebuildInfo*, void>)@this->LpVtbl[63])(@this, pDescPtr, pInfoPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe DriverMatchingIdentifierStatus CheckDriverMatchingIdentifier(this ComPtr<ID3D12Device7> thisVtbl, SerializedDataType SerializedDataType, SerializedDataDriverMatchingIdentifier* pIdentifierToCheck)
    {
        var @this = thisVtbl.Handle;
        DriverMatchingIdentifierStatus ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, SerializedDataType, SerializedDataDriverMatchingIdentifier*, DriverMatchingIdentifierStatus>)@this->LpVtbl[64])(@this, SerializedDataType, pIdentifierToCheck);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static DriverMatchingIdentifierStatus CheckDriverMatchingIdentifier(this ComPtr<ID3D12Device7> thisVtbl, SerializedDataType SerializedDataType, ref SerializedDataDriverMatchingIdentifier pIdentifierToCheck)
    {
        var @this = thisVtbl.Handle;
        DriverMatchingIdentifierStatus ret = default;
        fixed (SerializedDataDriverMatchingIdentifier* pIdentifierToCheckPtr = &pIdentifierToCheck)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, SerializedDataType, SerializedDataDriverMatchingIdentifier*, DriverMatchingIdentifierStatus>)@this->LpVtbl[64])(@this, SerializedDataType, pIdentifierToCheckPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetBackgroundProcessingMode(this ComPtr<ID3D12Device7> thisVtbl, BackgroundProcessingMode Mode, MeasurementsAction MeasurementsAction, void* hEventToSignalUponCompletion, int* pbFurtherMeasurementsDesired)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, BackgroundProcessingMode, MeasurementsAction, void*, int*, int>)@this->LpVtbl[65])(@this, Mode, MeasurementsAction, hEventToSignalUponCompletion, pbFurtherMeasurementsDesired);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetBackgroundProcessingMode(this ComPtr<ID3D12Device7> thisVtbl, BackgroundProcessingMode Mode, MeasurementsAction MeasurementsAction, void* hEventToSignalUponCompletion, ref int pbFurtherMeasurementsDesired)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pbFurtherMeasurementsDesiredPtr = &pbFurtherMeasurementsDesired)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, BackgroundProcessingMode, MeasurementsAction, void*, int*, int>)@this->LpVtbl[65])(@this, Mode, MeasurementsAction, hEventToSignalUponCompletion, pbFurtherMeasurementsDesiredPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetBackgroundProcessingMode<T0>(this ComPtr<ID3D12Device7> thisVtbl, BackgroundProcessingMode Mode, MeasurementsAction MeasurementsAction, ref T0 hEventToSignalUponCompletion, int* pbFurtherMeasurementsDesired) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hEventToSignalUponCompletionPtr = &hEventToSignalUponCompletion)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, BackgroundProcessingMode, MeasurementsAction, void*, int*, int>)@this->LpVtbl[65])(@this, Mode, MeasurementsAction, hEventToSignalUponCompletionPtr, pbFurtherMeasurementsDesired);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBackgroundProcessingMode<T0>(this ComPtr<ID3D12Device7> thisVtbl, BackgroundProcessingMode Mode, MeasurementsAction MeasurementsAction, ref T0 hEventToSignalUponCompletion, ref int pbFurtherMeasurementsDesired) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hEventToSignalUponCompletionPtr = &hEventToSignalUponCompletion)
        {
            fixed (int* pbFurtherMeasurementsDesiredPtr = &pbFurtherMeasurementsDesired)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, BackgroundProcessingMode, MeasurementsAction, void*, int*, int>)@this->LpVtbl[65])(@this, Mode, MeasurementsAction, hEventToSignalUponCompletionPtr, pbFurtherMeasurementsDesiredPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject(this ComPtr<ID3D12Device7> thisVtbl, StateObjectDesc* pAddition, ID3D12StateObject* pStateObjectToGrowFrom, Guid* riid, void** ppNewStateObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)@this->LpVtbl[66])(@this, pAddition, pStateObjectToGrowFrom, riid, ppNewStateObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject(this ComPtr<ID3D12Device7> thisVtbl, StateObjectDesc* pAddition, ID3D12StateObject* pStateObjectToGrowFrom, Guid* riid, ref void* ppNewStateObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppNewStateObjectPtr = &ppNewStateObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)@this->LpVtbl[66])(@this, pAddition, pStateObjectToGrowFrom, riid, ppNewStateObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject(this ComPtr<ID3D12Device7> thisVtbl, StateObjectDesc* pAddition, ID3D12StateObject* pStateObjectToGrowFrom, ref Guid riid, void** ppNewStateObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)@this->LpVtbl[66])(@this, pAddition, pStateObjectToGrowFrom, riidPtr, ppNewStateObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject(this ComPtr<ID3D12Device7> thisVtbl, StateObjectDesc* pAddition, ID3D12StateObject* pStateObjectToGrowFrom, ref Guid riid, ref void* ppNewStateObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppNewStateObjectPtr = &ppNewStateObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)@this->LpVtbl[66])(@this, pAddition, pStateObjectToGrowFrom, riidPtr, ppNewStateObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject(this ComPtr<ID3D12Device7> thisVtbl, StateObjectDesc* pAddition, ref ID3D12StateObject pStateObjectToGrowFrom, Guid* riid, void** ppNewStateObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12StateObject* pStateObjectToGrowFromPtr = &pStateObjectToGrowFrom)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)@this->LpVtbl[66])(@this, pAddition, pStateObjectToGrowFromPtr, riid, ppNewStateObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject(this ComPtr<ID3D12Device7> thisVtbl, StateObjectDesc* pAddition, ref ID3D12StateObject pStateObjectToGrowFrom, Guid* riid, ref void* ppNewStateObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12StateObject* pStateObjectToGrowFromPtr = &pStateObjectToGrowFrom)
        {
            fixed (void** ppNewStateObjectPtr = &ppNewStateObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)@this->LpVtbl[66])(@this, pAddition, pStateObjectToGrowFromPtr, riid, ppNewStateObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject(this ComPtr<ID3D12Device7> thisVtbl, StateObjectDesc* pAddition, ref ID3D12StateObject pStateObjectToGrowFrom, ref Guid riid, void** ppNewStateObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12StateObject* pStateObjectToGrowFromPtr = &pStateObjectToGrowFrom)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)@this->LpVtbl[66])(@this, pAddition, pStateObjectToGrowFromPtr, riidPtr, ppNewStateObject);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject(this ComPtr<ID3D12Device7> thisVtbl, StateObjectDesc* pAddition, ref ID3D12StateObject pStateObjectToGrowFrom, ref Guid riid, ref void* ppNewStateObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12StateObject* pStateObjectToGrowFromPtr = &pStateObjectToGrowFrom)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppNewStateObjectPtr = &ppNewStateObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)@this->LpVtbl[66])(@this, pAddition, pStateObjectToGrowFromPtr, riidPtr, ppNewStateObjectPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject(this ComPtr<ID3D12Device7> thisVtbl, ref StateObjectDesc pAddition, ID3D12StateObject* pStateObjectToGrowFrom, Guid* riid, void** ppNewStateObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (StateObjectDesc* pAdditionPtr = &pAddition)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)@this->LpVtbl[66])(@this, pAdditionPtr, pStateObjectToGrowFrom, riid, ppNewStateObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject(this ComPtr<ID3D12Device7> thisVtbl, ref StateObjectDesc pAddition, ID3D12StateObject* pStateObjectToGrowFrom, Guid* riid, ref void* ppNewStateObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (StateObjectDesc* pAdditionPtr = &pAddition)
        {
            fixed (void** ppNewStateObjectPtr = &ppNewStateObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)@this->LpVtbl[66])(@this, pAdditionPtr, pStateObjectToGrowFrom, riid, ppNewStateObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject(this ComPtr<ID3D12Device7> thisVtbl, ref StateObjectDesc pAddition, ID3D12StateObject* pStateObjectToGrowFrom, ref Guid riid, void** ppNewStateObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (StateObjectDesc* pAdditionPtr = &pAddition)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)@this->LpVtbl[66])(@this, pAdditionPtr, pStateObjectToGrowFrom, riidPtr, ppNewStateObject);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject(this ComPtr<ID3D12Device7> thisVtbl, ref StateObjectDesc pAddition, ID3D12StateObject* pStateObjectToGrowFrom, ref Guid riid, ref void* ppNewStateObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (StateObjectDesc* pAdditionPtr = &pAddition)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppNewStateObjectPtr = &ppNewStateObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)@this->LpVtbl[66])(@this, pAdditionPtr, pStateObjectToGrowFrom, riidPtr, ppNewStateObjectPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject(this ComPtr<ID3D12Device7> thisVtbl, ref StateObjectDesc pAddition, ref ID3D12StateObject pStateObjectToGrowFrom, Guid* riid, void** ppNewStateObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (StateObjectDesc* pAdditionPtr = &pAddition)
        {
            fixed (ID3D12StateObject* pStateObjectToGrowFromPtr = &pStateObjectToGrowFrom)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)@this->LpVtbl[66])(@this, pAdditionPtr, pStateObjectToGrowFromPtr, riid, ppNewStateObject);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject(this ComPtr<ID3D12Device7> thisVtbl, ref StateObjectDesc pAddition, ref ID3D12StateObject pStateObjectToGrowFrom, Guid* riid, ref void* ppNewStateObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (StateObjectDesc* pAdditionPtr = &pAddition)
        {
            fixed (ID3D12StateObject* pStateObjectToGrowFromPtr = &pStateObjectToGrowFrom)
            {
                fixed (void** ppNewStateObjectPtr = &ppNewStateObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)@this->LpVtbl[66])(@this, pAdditionPtr, pStateObjectToGrowFromPtr, riid, ppNewStateObjectPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject(this ComPtr<ID3D12Device7> thisVtbl, ref StateObjectDesc pAddition, ref ID3D12StateObject pStateObjectToGrowFrom, ref Guid riid, void** ppNewStateObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (StateObjectDesc* pAdditionPtr = &pAddition)
        {
            fixed (ID3D12StateObject* pStateObjectToGrowFromPtr = &pStateObjectToGrowFrom)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)@this->LpVtbl[66])(@this, pAdditionPtr, pStateObjectToGrowFromPtr, riidPtr, ppNewStateObject);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject(this ComPtr<ID3D12Device7> thisVtbl, ref StateObjectDesc pAddition, ref ID3D12StateObject pStateObjectToGrowFrom, ref Guid riid, ref void* ppNewStateObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (StateObjectDesc* pAdditionPtr = &pAddition)
        {
            fixed (ID3D12StateObject* pStateObjectToGrowFromPtr = &pStateObjectToGrowFrom)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppNewStateObjectPtr = &ppNewStateObject)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)@this->LpVtbl[66])(@this, pAdditionPtr, pStateObjectToGrowFromPtr, riidPtr, ppNewStateObjectPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession1(this ComPtr<ID3D12Device7> thisVtbl, ProtectedResourceSessionDesc1* pDesc, Guid* riid, void** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ProtectedResourceSessionDesc1*, Guid*, void**, int>)@this->LpVtbl[67])(@this, pDesc, riid, ppSession);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession1(this ComPtr<ID3D12Device7> thisVtbl, ProtectedResourceSessionDesc1* pDesc, Guid* riid, ref void* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppSessionPtr = &ppSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ProtectedResourceSessionDesc1*, Guid*, void**, int>)@this->LpVtbl[67])(@this, pDesc, riid, ppSessionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession1(this ComPtr<ID3D12Device7> thisVtbl, ProtectedResourceSessionDesc1* pDesc, ref Guid riid, void** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ProtectedResourceSessionDesc1*, Guid*, void**, int>)@this->LpVtbl[67])(@this, pDesc, riidPtr, ppSession);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession1(this ComPtr<ID3D12Device7> thisVtbl, ProtectedResourceSessionDesc1* pDesc, ref Guid riid, ref void* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ProtectedResourceSessionDesc1*, Guid*, void**, int>)@this->LpVtbl[67])(@this, pDesc, riidPtr, ppSessionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession1(this ComPtr<ID3D12Device7> thisVtbl, ref ProtectedResourceSessionDesc1 pDesc, Guid* riid, void** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ProtectedResourceSessionDesc1* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ProtectedResourceSessionDesc1*, Guid*, void**, int>)@this->LpVtbl[67])(@this, pDescPtr, riid, ppSession);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession1(this ComPtr<ID3D12Device7> thisVtbl, ref ProtectedResourceSessionDesc1 pDesc, Guid* riid, ref void* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ProtectedResourceSessionDesc1* pDescPtr = &pDesc)
        {
            fixed (void** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ProtectedResourceSessionDesc1*, Guid*, void**, int>)@this->LpVtbl[67])(@this, pDescPtr, riid, ppSessionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession1(this ComPtr<ID3D12Device7> thisVtbl, ref ProtectedResourceSessionDesc1 pDesc, ref Guid riid, void** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ProtectedResourceSessionDesc1* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ProtectedResourceSessionDesc1*, Guid*, void**, int>)@this->LpVtbl[67])(@this, pDescPtr, riidPtr, ppSession);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession1(this ComPtr<ID3D12Device7> thisVtbl, ref ProtectedResourceSessionDesc1 pDesc, ref Guid riid, ref void* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ProtectedResourceSessionDesc1* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ProtectedResourceSessionDesc1*, Guid*, void**, int>)@this->LpVtbl[67])(@this, pDescPtr, riidPtr, ppSessionPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D12Device7> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12Device7> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12Device7> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12Device7> thisVtbl, Guid* guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12Device7> thisVtbl, Guid* guid, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12Device7> thisVtbl, Guid* guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12Device7> thisVtbl, Span<Guid> guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12Device7> thisVtbl, Span<Guid> guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12Device7> thisVtbl, Span<Guid> guid, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<ID3D12Device7> thisVtbl, Span<Guid> guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<ID3D12Device7> thisVtbl, Guid* guid, uint DataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(guid, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D12Device7> thisVtbl, Span<Guid> guid, uint DataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<ID3D12Device7> thisVtbl, Span<Guid> guid, uint DataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12Device7> thisVtbl, Guid* guid, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(guid, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12Device7> thisVtbl, Span<Guid> guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<ID3D12Device7> thisVtbl, Span<Guid> guid, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetName(this ComPtr<ID3D12Device7> thisVtbl, Span<char> Name)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetName(ref Name.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue<TI0>(this ComPtr<ID3D12Device7> thisVtbl, CommandQueueDesc* pDesc, out ComPtr<TI0> ppCommandQueue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCommandQueue = default;
        return @this->CreateCommandQueue(pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCommandQueue.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue(this ComPtr<ID3D12Device7> thisVtbl, CommandQueueDesc* pDesc, Span<Guid> riid, void** ppCommandQueue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandQueue(pDesc, ref riid.GetPinnableReference(), ppCommandQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue(this ComPtr<ID3D12Device7> thisVtbl, CommandQueueDesc* pDesc, Span<Guid> riid, ref void* ppCommandQueue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandQueue(pDesc, ref riid.GetPinnableReference(), ref ppCommandQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue(this ComPtr<ID3D12Device7> thisVtbl, Span<CommandQueueDesc> pDesc, Guid* riid, void** ppCommandQueue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandQueue(ref pDesc.GetPinnableReference(), riid, ppCommandQueue);
    }

    /// <summary>To be documented.</summary>
    public static int CreateCommandQueue<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref CommandQueueDesc pDesc, out ComPtr<TI0> ppCommandQueue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCommandQueue = default;
        return @this->CreateCommandQueue(ref pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCommandQueue.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue(this ComPtr<ID3D12Device7> thisVtbl, Span<CommandQueueDesc> pDesc, Guid* riid, ref void* ppCommandQueue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandQueue(ref pDesc.GetPinnableReference(), riid, ref ppCommandQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue(this ComPtr<ID3D12Device7> thisVtbl, Span<CommandQueueDesc> pDesc, Span<Guid> riid, void** ppCommandQueue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandQueue(ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppCommandQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue(this ComPtr<ID3D12Device7> thisVtbl, Span<CommandQueueDesc> pDesc, Span<Guid> riid, ref void* ppCommandQueue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandQueue(ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppCommandQueue);
    }

    /// <summary>To be documented.</summary>
    public static int CreateCommandAllocator<TI0>(this ComPtr<ID3D12Device7> thisVtbl, CommandListType type, out ComPtr<TI0> ppCommandAllocator) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCommandAllocator = default;
        return @this->CreateCommandAllocator(type, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCommandAllocator.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandAllocator(this ComPtr<ID3D12Device7> thisVtbl, CommandListType type, Span<Guid> riid, void** ppCommandAllocator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandAllocator(type, ref riid.GetPinnableReference(), ppCommandAllocator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandAllocator(this ComPtr<ID3D12Device7> thisVtbl, CommandListType type, Span<Guid> riid, ref void* ppCommandAllocator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandAllocator(type, ref riid.GetPinnableReference(), ref ppCommandAllocator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState<TI0>(this ComPtr<ID3D12Device7> thisVtbl, GraphicsPipelineStateDesc* pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppPipelineState = default;
        return @this->CreateGraphicsPipelineState(pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState(this ComPtr<ID3D12Device7> thisVtbl, GraphicsPipelineStateDesc* pDesc, Span<Guid> riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGraphicsPipelineState(pDesc, ref riid.GetPinnableReference(), ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState(this ComPtr<ID3D12Device7> thisVtbl, GraphicsPipelineStateDesc* pDesc, Span<Guid> riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGraphicsPipelineState(pDesc, ref riid.GetPinnableReference(), ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState(this ComPtr<ID3D12Device7> thisVtbl, Span<GraphicsPipelineStateDesc> pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGraphicsPipelineState(ref pDesc.GetPinnableReference(), riid, ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static int CreateGraphicsPipelineState<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref GraphicsPipelineStateDesc pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppPipelineState = default;
        return @this->CreateGraphicsPipelineState(ref pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState(this ComPtr<ID3D12Device7> thisVtbl, Span<GraphicsPipelineStateDesc> pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGraphicsPipelineState(ref pDesc.GetPinnableReference(), riid, ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState(this ComPtr<ID3D12Device7> thisVtbl, Span<GraphicsPipelineStateDesc> pDesc, Span<Guid> riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGraphicsPipelineState(ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState(this ComPtr<ID3D12Device7> thisVtbl, Span<GraphicsPipelineStateDesc> pDesc, Span<Guid> riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGraphicsPipelineState(ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ComputePipelineStateDesc* pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppPipelineState = default;
        return @this->CreateComputePipelineState(pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState(this ComPtr<ID3D12Device7> thisVtbl, ComputePipelineStateDesc* pDesc, Span<Guid> riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateComputePipelineState(pDesc, ref riid.GetPinnableReference(), ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState(this ComPtr<ID3D12Device7> thisVtbl, ComputePipelineStateDesc* pDesc, Span<Guid> riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateComputePipelineState(pDesc, ref riid.GetPinnableReference(), ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState(this ComPtr<ID3D12Device7> thisVtbl, Span<ComputePipelineStateDesc> pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateComputePipelineState(ref pDesc.GetPinnableReference(), riid, ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static int CreateComputePipelineState<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref ComputePipelineStateDesc pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppPipelineState = default;
        return @this->CreateComputePipelineState(ref pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState(this ComPtr<ID3D12Device7> thisVtbl, Span<ComputePipelineStateDesc> pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateComputePipelineState(ref pDesc.GetPinnableReference(), riid, ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState(this ComPtr<ID3D12Device7> thisVtbl, Span<ComputePipelineStateDesc> pDesc, Span<Guid> riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateComputePipelineState(ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState(this ComPtr<ID3D12Device7> thisVtbl, Span<ComputePipelineStateDesc> pDesc, Span<Guid> riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateComputePipelineState(ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList<TI0>(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, out ComPtr<TI0> ppCommandList) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCommandList = default;
        return @this->CreateCommandList(nodeMask, type, pCommandAllocator, pInitialState, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCommandList.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, Span<Guid> riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandList(nodeMask, type, pCommandAllocator, pInitialState, ref riid.GetPinnableReference(), ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, Span<Guid> riid, ref void* ppCommandList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandList(nodeMask, type, pCommandAllocator, pInitialState, ref riid.GetPinnableReference(), ref ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, Span<ID3D12PipelineState> pInitialState, Guid* riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandList(nodeMask, type, pCommandAllocator, ref pInitialState.GetPinnableReference(), riid, ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList<TI0>(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ref ID3D12PipelineState pInitialState, out ComPtr<TI0> ppCommandList) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCommandList = default;
        return @this->CreateCommandList(nodeMask, type, pCommandAllocator, ref pInitialState, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCommandList.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, Span<ID3D12PipelineState> pInitialState, Guid* riid, ref void* ppCommandList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandList(nodeMask, type, pCommandAllocator, ref pInitialState.GetPinnableReference(), riid, ref ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, Span<ID3D12PipelineState> pInitialState, Span<Guid> riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandList(nodeMask, type, pCommandAllocator, ref pInitialState.GetPinnableReference(), ref riid.GetPinnableReference(), ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, Span<ID3D12PipelineState> pInitialState, Span<Guid> riid, ref void* ppCommandList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandList(nodeMask, type, pCommandAllocator, ref pInitialState.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, Span<ID3D12CommandAllocator> pCommandAllocator, ID3D12PipelineState* pInitialState, Guid* riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandList(nodeMask, type, ref pCommandAllocator.GetPinnableReference(), pInitialState, riid, ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList<TI0>(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState* pInitialState, out ComPtr<TI0> ppCommandList) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCommandList = default;
        return @this->CreateCommandList(nodeMask, type, ref pCommandAllocator, pInitialState, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCommandList.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, Span<ID3D12CommandAllocator> pCommandAllocator, ID3D12PipelineState* pInitialState, Guid* riid, ref void* ppCommandList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandList(nodeMask, type, ref pCommandAllocator.GetPinnableReference(), pInitialState, riid, ref ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, Span<ID3D12CommandAllocator> pCommandAllocator, ID3D12PipelineState* pInitialState, Span<Guid> riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandList(nodeMask, type, ref pCommandAllocator.GetPinnableReference(), pInitialState, ref riid.GetPinnableReference(), ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, Span<ID3D12CommandAllocator> pCommandAllocator, ID3D12PipelineState* pInitialState, Span<Guid> riid, ref void* ppCommandList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandList(nodeMask, type, ref pCommandAllocator.GetPinnableReference(), pInitialState, ref riid.GetPinnableReference(), ref ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, Span<ID3D12CommandAllocator> pCommandAllocator, Span<ID3D12PipelineState> pInitialState, Guid* riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandList(nodeMask, type, ref pCommandAllocator.GetPinnableReference(), ref pInitialState.GetPinnableReference(), riid, ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static int CreateCommandList<TI0>(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ref ID3D12PipelineState pInitialState, out ComPtr<TI0> ppCommandList) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCommandList = default;
        return @this->CreateCommandList(nodeMask, type, ref pCommandAllocator, ref pInitialState, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCommandList.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, Span<ID3D12CommandAllocator> pCommandAllocator, Span<ID3D12PipelineState> pInitialState, Guid* riid, ref void* ppCommandList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandList(nodeMask, type, ref pCommandAllocator.GetPinnableReference(), ref pInitialState.GetPinnableReference(), riid, ref ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, Span<ID3D12CommandAllocator> pCommandAllocator, Span<ID3D12PipelineState> pInitialState, Span<Guid> riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandList(nodeMask, type, ref pCommandAllocator.GetPinnableReference(), ref pInitialState.GetPinnableReference(), ref riid.GetPinnableReference(), ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, Span<ID3D12CommandAllocator> pCommandAllocator, Span<ID3D12PipelineState> pInitialState, Span<Guid> riid, ref void* ppCommandList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandList(nodeMask, type, ref pCommandAllocator.GetPinnableReference(), ref pInitialState.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static int CheckFeatureSupport<T0>(this ComPtr<ID3D12Device7> thisVtbl, Feature Feature, Span<T0> pFeatureSupportData, uint FeatureSupportDataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckFeatureSupport(Feature, ref pFeatureSupportData.GetPinnableReference(), FeatureSupportDataSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap<TI0>(this ComPtr<ID3D12Device7> thisVtbl, DescriptorHeapDesc* pDescriptorHeapDesc, out ComPtr<TI0> ppvHeap) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvHeap = default;
        return @this->CreateDescriptorHeap(pDescriptorHeapDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap(this ComPtr<ID3D12Device7> thisVtbl, DescriptorHeapDesc* pDescriptorHeapDesc, Span<Guid> riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDescriptorHeap(pDescriptorHeapDesc, ref riid.GetPinnableReference(), ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap(this ComPtr<ID3D12Device7> thisVtbl, DescriptorHeapDesc* pDescriptorHeapDesc, Span<Guid> riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDescriptorHeap(pDescriptorHeapDesc, ref riid.GetPinnableReference(), ref ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap(this ComPtr<ID3D12Device7> thisVtbl, Span<DescriptorHeapDesc> pDescriptorHeapDesc, Guid* riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDescriptorHeap(ref pDescriptorHeapDesc.GetPinnableReference(), riid, ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDescriptorHeap<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref DescriptorHeapDesc pDescriptorHeapDesc, out ComPtr<TI0> ppvHeap) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvHeap = default;
        return @this->CreateDescriptorHeap(ref pDescriptorHeapDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap(this ComPtr<ID3D12Device7> thisVtbl, Span<DescriptorHeapDesc> pDescriptorHeapDesc, Guid* riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDescriptorHeap(ref pDescriptorHeapDesc.GetPinnableReference(), riid, ref ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap(this ComPtr<ID3D12Device7> thisVtbl, Span<DescriptorHeapDesc> pDescriptorHeapDesc, Span<Guid> riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDescriptorHeap(ref pDescriptorHeapDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap(this ComPtr<ID3D12Device7> thisVtbl, Span<DescriptorHeapDesc> pDescriptorHeapDesc, Span<Guid> riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDescriptorHeap(ref pDescriptorHeapDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature<TI0>(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, void* pBlobWithRootSignature, nuint blobLengthInBytes, out ComPtr<TI0> ppvRootSignature) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvRootSignature = default;
        return @this->CreateRootSignature(nodeMask, pBlobWithRootSignature, blobLengthInBytes, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvRootSignature.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, void* pBlobWithRootSignature, nuint blobLengthInBytes, Span<Guid> riid, void** ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRootSignature(nodeMask, pBlobWithRootSignature, blobLengthInBytes, ref riid.GetPinnableReference(), ppvRootSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, void* pBlobWithRootSignature, nuint blobLengthInBytes, Span<Guid> riid, ref void* ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRootSignature(nodeMask, pBlobWithRootSignature, blobLengthInBytes, ref riid.GetPinnableReference(), ref ppvRootSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature<T0>(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, Span<T0> pBlobWithRootSignature, nuint blobLengthInBytes, Guid* riid, void** ppvRootSignature) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRootSignature(nodeMask, ref pBlobWithRootSignature.GetPinnableReference(), blobLengthInBytes, riid, ppvRootSignature);
    }

    /// <summary>To be documented.</summary>
    public static int CreateRootSignature<T0, TI0>(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, ref T0 pBlobWithRootSignature, nuint blobLengthInBytes, out ComPtr<TI0> ppvRootSignature) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvRootSignature = default;
        return @this->CreateRootSignature(nodeMask, ref pBlobWithRootSignature, blobLengthInBytes, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvRootSignature.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature<T0>(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, Span<T0> pBlobWithRootSignature, nuint blobLengthInBytes, Guid* riid, ref void* ppvRootSignature) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRootSignature(nodeMask, ref pBlobWithRootSignature.GetPinnableReference(), blobLengthInBytes, riid, ref ppvRootSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature<T0>(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, Span<T0> pBlobWithRootSignature, nuint blobLengthInBytes, Span<Guid> riid, void** ppvRootSignature) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRootSignature(nodeMask, ref pBlobWithRootSignature.GetPinnableReference(), blobLengthInBytes, ref riid.GetPinnableReference(), ppvRootSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature<T0>(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, Span<T0> pBlobWithRootSignature, nuint blobLengthInBytes, Span<Guid> riid, ref void* ppvRootSignature) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRootSignature(nodeMask, ref pBlobWithRootSignature.GetPinnableReference(), blobLengthInBytes, ref riid.GetPinnableReference(), ref ppvRootSignature);
    }

    /// <summary>To be documented.</summary>
    public static void CreateConstantBufferView(this ComPtr<ID3D12Device7> thisVtbl, Span<ConstantBufferViewDesc> pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateConstantBufferView(ref pDesc.GetPinnableReference(), DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateShaderResourceView(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pResource, Span<ShaderResourceViewDesc> pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateShaderResourceView(pResource, ref pDesc.GetPinnableReference(), DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateShaderResourceView(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pResource, ShaderResourceViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateShaderResourceView(ref pResource.GetPinnableReference(), pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static void CreateShaderResourceView(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pResource, Span<ShaderResourceViewDesc> pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateShaderResourceView(ref pResource.GetPinnableReference(), ref pDesc.GetPinnableReference(), DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pResource, ID3D12Resource* pCounterResource, Span<UnorderedAccessViewDesc> pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateUnorderedAccessView(pResource, pCounterResource, ref pDesc.GetPinnableReference(), DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pResource, Span<ID3D12Resource> pCounterResource, UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateUnorderedAccessView(pResource, ref pCounterResource.GetPinnableReference(), pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pResource, Span<ID3D12Resource> pCounterResource, Span<UnorderedAccessViewDesc> pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateUnorderedAccessView(pResource, ref pCounterResource.GetPinnableReference(), ref pDesc.GetPinnableReference(), DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pResource, ID3D12Resource* pCounterResource, UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateUnorderedAccessView(ref pResource.GetPinnableReference(), pCounterResource, pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pResource, ID3D12Resource* pCounterResource, Span<UnorderedAccessViewDesc> pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateUnorderedAccessView(ref pResource.GetPinnableReference(), pCounterResource, ref pDesc.GetPinnableReference(), DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pResource, Span<ID3D12Resource> pCounterResource, UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateUnorderedAccessView(ref pResource.GetPinnableReference(), ref pCounterResource.GetPinnableReference(), pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static void CreateUnorderedAccessView(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pResource, Span<ID3D12Resource> pCounterResource, Span<UnorderedAccessViewDesc> pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateUnorderedAccessView(ref pResource.GetPinnableReference(), ref pCounterResource.GetPinnableReference(), ref pDesc.GetPinnableReference(), DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateRenderTargetView(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pResource, Span<RenderTargetViewDesc> pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateRenderTargetView(pResource, ref pDesc.GetPinnableReference(), DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateRenderTargetView(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pResource, RenderTargetViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateRenderTargetView(ref pResource.GetPinnableReference(), pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static void CreateRenderTargetView(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pResource, Span<RenderTargetViewDesc> pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateRenderTargetView(ref pResource.GetPinnableReference(), ref pDesc.GetPinnableReference(), DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateDepthStencilView(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pResource, Span<DepthStencilViewDesc> pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateDepthStencilView(pResource, ref pDesc.GetPinnableReference(), DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateDepthStencilView(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pResource, DepthStencilViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateDepthStencilView(ref pResource.GetPinnableReference(), pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static void CreateDepthStencilView(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pResource, Span<DepthStencilViewDesc> pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateDepthStencilView(ref pResource.GetPinnableReference(), ref pDesc.GetPinnableReference(), DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static void CreateSampler(this ComPtr<ID3D12Device7> thisVtbl, Span<SamplerDesc> pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateSampler(ref pDesc.GetPinnableReference(), DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device7> thisVtbl, uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, Span<uint> pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyDescriptors(NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, ref pSrcDescriptorRangeSizes.GetPinnableReference(), DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device7> thisVtbl, uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, Span<CpuDescriptorHandle> pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyDescriptors(NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, ref pSrcDescriptorRangeStarts.GetPinnableReference(), pSrcDescriptorRangeSizes, DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device7> thisVtbl, uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, Span<CpuDescriptorHandle> pSrcDescriptorRangeStarts, Span<uint> pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyDescriptors(NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, ref pSrcDescriptorRangeStarts.GetPinnableReference(), ref pSrcDescriptorRangeSizes.GetPinnableReference(), DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device7> thisVtbl, uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, Span<uint> pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyDescriptors(NumDestDescriptorRanges, pDestDescriptorRangeStarts, ref pDestDescriptorRangeSizes.GetPinnableReference(), NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device7> thisVtbl, uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, Span<uint> pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, Span<uint> pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyDescriptors(NumDestDescriptorRanges, pDestDescriptorRangeStarts, ref pDestDescriptorRangeSizes.GetPinnableReference(), NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, ref pSrcDescriptorRangeSizes.GetPinnableReference(), DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device7> thisVtbl, uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, Span<uint> pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, Span<CpuDescriptorHandle> pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyDescriptors(NumDestDescriptorRanges, pDestDescriptorRangeStarts, ref pDestDescriptorRangeSizes.GetPinnableReference(), NumSrcDescriptorRanges, ref pSrcDescriptorRangeStarts.GetPinnableReference(), pSrcDescriptorRangeSizes, DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device7> thisVtbl, uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, Span<uint> pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, Span<CpuDescriptorHandle> pSrcDescriptorRangeStarts, Span<uint> pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyDescriptors(NumDestDescriptorRanges, pDestDescriptorRangeStarts, ref pDestDescriptorRangeSizes.GetPinnableReference(), NumSrcDescriptorRanges, ref pSrcDescriptorRangeStarts.GetPinnableReference(), ref pSrcDescriptorRangeSizes.GetPinnableReference(), DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device7> thisVtbl, uint NumDestDescriptorRanges, Span<CpuDescriptorHandle> pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyDescriptors(NumDestDescriptorRanges, ref pDestDescriptorRangeStarts.GetPinnableReference(), pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device7> thisVtbl, uint NumDestDescriptorRanges, Span<CpuDescriptorHandle> pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, Span<uint> pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyDescriptors(NumDestDescriptorRanges, ref pDestDescriptorRangeStarts.GetPinnableReference(), pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, ref pSrcDescriptorRangeSizes.GetPinnableReference(), DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device7> thisVtbl, uint NumDestDescriptorRanges, Span<CpuDescriptorHandle> pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, Span<CpuDescriptorHandle> pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyDescriptors(NumDestDescriptorRanges, ref pDestDescriptorRangeStarts.GetPinnableReference(), pDestDescriptorRangeSizes, NumSrcDescriptorRanges, ref pSrcDescriptorRangeStarts.GetPinnableReference(), pSrcDescriptorRangeSizes, DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device7> thisVtbl, uint NumDestDescriptorRanges, Span<CpuDescriptorHandle> pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, Span<CpuDescriptorHandle> pSrcDescriptorRangeStarts, Span<uint> pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyDescriptors(NumDestDescriptorRanges, ref pDestDescriptorRangeStarts.GetPinnableReference(), pDestDescriptorRangeSizes, NumSrcDescriptorRanges, ref pSrcDescriptorRangeStarts.GetPinnableReference(), ref pSrcDescriptorRangeSizes.GetPinnableReference(), DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device7> thisVtbl, uint NumDestDescriptorRanges, Span<CpuDescriptorHandle> pDestDescriptorRangeStarts, Span<uint> pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyDescriptors(NumDestDescriptorRanges, ref pDestDescriptorRangeStarts.GetPinnableReference(), ref pDestDescriptorRangeSizes.GetPinnableReference(), NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device7> thisVtbl, uint NumDestDescriptorRanges, Span<CpuDescriptorHandle> pDestDescriptorRangeStarts, Span<uint> pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, Span<uint> pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyDescriptors(NumDestDescriptorRanges, ref pDestDescriptorRangeStarts.GetPinnableReference(), ref pDestDescriptorRangeSizes.GetPinnableReference(), NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, ref pSrcDescriptorRangeSizes.GetPinnableReference(), DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device7> thisVtbl, uint NumDestDescriptorRanges, Span<CpuDescriptorHandle> pDestDescriptorRangeStarts, Span<uint> pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, Span<CpuDescriptorHandle> pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyDescriptors(NumDestDescriptorRanges, ref pDestDescriptorRangeStarts.GetPinnableReference(), ref pDestDescriptorRangeSizes.GetPinnableReference(), NumSrcDescriptorRanges, ref pSrcDescriptorRangeStarts.GetPinnableReference(), pSrcDescriptorRangeSizes, DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static void CopyDescriptors(this ComPtr<ID3D12Device7> thisVtbl, uint NumDestDescriptorRanges, Span<CpuDescriptorHandle> pDestDescriptorRangeStarts, Span<uint> pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, Span<CpuDescriptorHandle> pSrcDescriptorRangeStarts, Span<uint> pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyDescriptors(NumDestDescriptorRanges, ref pDestDescriptorRangeStarts.GetPinnableReference(), ref pDestDescriptorRangeSizes.GetPinnableReference(), NumSrcDescriptorRanges, ref pSrcDescriptorRangeStarts.GetPinnableReference(), ref pSrcDescriptorRangeSizes.GetPinnableReference(), DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static ResourceAllocationInfo GetResourceAllocationInfo(this ComPtr<ID3D12Device7> thisVtbl, uint visibleMask, uint numResourceDescs, Span<ResourceDesc> pResourceDescs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetResourceAllocationInfo(visibleMask, numResourceDescs, ref pResourceDescs.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Span<Guid> riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, ref riidResource.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Span<Guid> riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, ref riidResource.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), riidResource, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), riidResource, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, Span<Guid> riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), ref riidResource.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, Span<Guid> riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), ref riidResource.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, ref pDesc, InitialResourceState, pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, pOptimizedClearValue, riidResource, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Span<Guid> riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, pOptimizedClearValue, ref riidResource.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Span<Guid> riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, pOptimizedClearValue, ref riidResource.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), riidResource, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, ref pDesc, InitialResourceState, ref pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), riidResource, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, Span<Guid> riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), ref riidResource.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, Span<Guid> riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), ref riidResource.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(ref pHeapProperties.GetPinnableReference(), HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateCommittedResource(ref pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(ref pHeapProperties.GetPinnableReference(), HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Span<Guid> riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(ref pHeapProperties.GetPinnableReference(), HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, ref riidResource.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Span<Guid> riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(ref pHeapProperties.GetPinnableReference(), HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, ref riidResource.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(ref pHeapProperties.GetPinnableReference(), HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), riidResource, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateCommittedResource(ref pHeapProperties, HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(ref pHeapProperties.GetPinnableReference(), HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), riidResource, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, Span<Guid> riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(ref pHeapProperties.GetPinnableReference(), HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), ref riidResource.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, Span<Guid> riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(ref pHeapProperties.GetPinnableReference(), HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), ref riidResource.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(ref pHeapProperties.GetPinnableReference(), HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateCommittedResource(ref pHeapProperties, HeapFlags, ref pDesc, InitialResourceState, pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(ref pHeapProperties.GetPinnableReference(), HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, pOptimizedClearValue, riidResource, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Span<Guid> riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(ref pHeapProperties.GetPinnableReference(), HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, pOptimizedClearValue, ref riidResource.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Span<Guid> riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(ref pHeapProperties.GetPinnableReference(), HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, pOptimizedClearValue, ref riidResource.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(ref pHeapProperties.GetPinnableReference(), HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), riidResource, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static int CreateCommittedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateCommittedResource(ref pHeapProperties, HeapFlags, ref pDesc, InitialResourceState, ref pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(ref pHeapProperties.GetPinnableReference(), HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), riidResource, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, Span<Guid> riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(ref pHeapProperties.GetPinnableReference(), HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), ref riidResource.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, Span<Guid> riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(ref pHeapProperties.GetPinnableReference(), HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), ref riidResource.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap<TI0>(this ComPtr<ID3D12Device7> thisVtbl, HeapDesc* pDesc, out ComPtr<TI0> ppvHeap) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvHeap = default;
        return @this->CreateHeap(pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap(this ComPtr<ID3D12Device7> thisVtbl, HeapDesc* pDesc, Span<Guid> riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHeap(pDesc, ref riid.GetPinnableReference(), ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap(this ComPtr<ID3D12Device7> thisVtbl, HeapDesc* pDesc, Span<Guid> riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHeap(pDesc, ref riid.GetPinnableReference(), ref ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapDesc> pDesc, Guid* riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHeap(ref pDesc.GetPinnableReference(), riid, ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateHeap<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref HeapDesc pDesc, out ComPtr<TI0> ppvHeap) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvHeap = default;
        return @this->CreateHeap(ref pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapDesc> pDesc, Guid* riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHeap(ref pDesc.GetPinnableReference(), riid, ref ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapDesc> pDesc, Span<Guid> riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHeap(ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapDesc> pDesc, Span<Guid> riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHeap(ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreatePlacedResource(pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Span<Guid> riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, ref riid.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Span<Guid> riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, ref riid.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(pHeap, HeapOffset, pDesc, InitialState, ref pOptimizedClearValue.GetPinnableReference(), riid, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreatePlacedResource(pHeap, HeapOffset, pDesc, InitialState, ref pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(pHeap, HeapOffset, pDesc, InitialState, ref pOptimizedClearValue.GetPinnableReference(), riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, Span<Guid> riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(pHeap, HeapOffset, pDesc, InitialState, ref pOptimizedClearValue.GetPinnableReference(), ref riid.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, Span<Guid> riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(pHeap, HeapOffset, pDesc, InitialState, ref pOptimizedClearValue.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, Span<ResourceDesc> pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(pHeap, HeapOffset, ref pDesc.GetPinnableReference(), InitialState, pOptimizedClearValue, riid, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreatePlacedResource(pHeap, HeapOffset, ref pDesc, InitialState, pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, Span<ResourceDesc> pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(pHeap, HeapOffset, ref pDesc.GetPinnableReference(), InitialState, pOptimizedClearValue, riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, Span<ResourceDesc> pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Span<Guid> riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(pHeap, HeapOffset, ref pDesc.GetPinnableReference(), InitialState, pOptimizedClearValue, ref riid.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, Span<ResourceDesc> pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Span<Guid> riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(pHeap, HeapOffset, ref pDesc.GetPinnableReference(), InitialState, pOptimizedClearValue, ref riid.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, Span<ResourceDesc> pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(pHeap, HeapOffset, ref pDesc.GetPinnableReference(), InitialState, ref pOptimizedClearValue.GetPinnableReference(), riid, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreatePlacedResource(pHeap, HeapOffset, ref pDesc, InitialState, ref pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, Span<ResourceDesc> pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(pHeap, HeapOffset, ref pDesc.GetPinnableReference(), InitialState, ref pOptimizedClearValue.GetPinnableReference(), riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, Span<ResourceDesc> pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, Span<Guid> riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(pHeap, HeapOffset, ref pDesc.GetPinnableReference(), InitialState, ref pOptimizedClearValue.GetPinnableReference(), ref riid.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, Span<ResourceDesc> pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, Span<Guid> riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(pHeap, HeapOffset, ref pDesc.GetPinnableReference(), InitialState, ref pOptimizedClearValue.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Heap> pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(ref pHeap.GetPinnableReference(), HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreatePlacedResource(ref pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Heap> pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(ref pHeap.GetPinnableReference(), HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Heap> pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Span<Guid> riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(ref pHeap.GetPinnableReference(), HeapOffset, pDesc, InitialState, pOptimizedClearValue, ref riid.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Heap> pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Span<Guid> riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(ref pHeap.GetPinnableReference(), HeapOffset, pDesc, InitialState, pOptimizedClearValue, ref riid.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Heap> pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(ref pHeap.GetPinnableReference(), HeapOffset, pDesc, InitialState, ref pOptimizedClearValue.GetPinnableReference(), riid, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreatePlacedResource(ref pHeap, HeapOffset, pDesc, InitialState, ref pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Heap> pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(ref pHeap.GetPinnableReference(), HeapOffset, pDesc, InitialState, ref pOptimizedClearValue.GetPinnableReference(), riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Heap> pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, Span<Guid> riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(ref pHeap.GetPinnableReference(), HeapOffset, pDesc, InitialState, ref pOptimizedClearValue.GetPinnableReference(), ref riid.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Heap> pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, Span<Guid> riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(ref pHeap.GetPinnableReference(), HeapOffset, pDesc, InitialState, ref pOptimizedClearValue.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Heap> pHeap, ulong HeapOffset, Span<ResourceDesc> pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(ref pHeap.GetPinnableReference(), HeapOffset, ref pDesc.GetPinnableReference(), InitialState, pOptimizedClearValue, riid, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreatePlacedResource(ref pHeap, HeapOffset, ref pDesc, InitialState, pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Heap> pHeap, ulong HeapOffset, Span<ResourceDesc> pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(ref pHeap.GetPinnableReference(), HeapOffset, ref pDesc.GetPinnableReference(), InitialState, pOptimizedClearValue, riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Heap> pHeap, ulong HeapOffset, Span<ResourceDesc> pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Span<Guid> riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(ref pHeap.GetPinnableReference(), HeapOffset, ref pDesc.GetPinnableReference(), InitialState, pOptimizedClearValue, ref riid.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Heap> pHeap, ulong HeapOffset, Span<ResourceDesc> pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Span<Guid> riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(ref pHeap.GetPinnableReference(), HeapOffset, ref pDesc.GetPinnableReference(), InitialState, pOptimizedClearValue, ref riid.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Heap> pHeap, ulong HeapOffset, Span<ResourceDesc> pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(ref pHeap.GetPinnableReference(), HeapOffset, ref pDesc.GetPinnableReference(), InitialState, ref pOptimizedClearValue.GetPinnableReference(), riid, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static int CreatePlacedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreatePlacedResource(ref pHeap, HeapOffset, ref pDesc, InitialState, ref pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Heap> pHeap, ulong HeapOffset, Span<ResourceDesc> pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(ref pHeap.GetPinnableReference(), HeapOffset, ref pDesc.GetPinnableReference(), InitialState, ref pOptimizedClearValue.GetPinnableReference(), riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Heap> pHeap, ulong HeapOffset, Span<ResourceDesc> pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, Span<Guid> riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(ref pHeap.GetPinnableReference(), HeapOffset, ref pDesc.GetPinnableReference(), InitialState, ref pOptimizedClearValue.GetPinnableReference(), ref riid.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Heap> pHeap, ulong HeapOffset, Span<ResourceDesc> pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, Span<Guid> riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(ref pHeap.GetPinnableReference(), HeapOffset, ref pDesc.GetPinnableReference(), InitialState, ref pOptimizedClearValue.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateReservedResource(pDesc, InitialState, pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Span<Guid> riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource(pDesc, InitialState, pOptimizedClearValue, ref riid.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Span<Guid> riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource(pDesc, InitialState, pOptimizedClearValue, ref riid.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource(pDesc, InitialState, ref pOptimizedClearValue.GetPinnableReference(), riid, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateReservedResource(pDesc, InitialState, ref pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource(pDesc, InitialState, ref pOptimizedClearValue.GetPinnableReference(), riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, Span<Guid> riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource(pDesc, InitialState, ref pOptimizedClearValue.GetPinnableReference(), ref riid.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, Span<Guid> riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource(pDesc, InitialState, ref pOptimizedClearValue.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource(ref pDesc.GetPinnableReference(), InitialState, pOptimizedClearValue, riid, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateReservedResource(ref pDesc, InitialState, pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource(ref pDesc.GetPinnableReference(), InitialState, pOptimizedClearValue, riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Span<Guid> riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource(ref pDesc.GetPinnableReference(), InitialState, pOptimizedClearValue, ref riid.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Span<Guid> riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource(ref pDesc.GetPinnableReference(), InitialState, pOptimizedClearValue, ref riid.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource(ref pDesc.GetPinnableReference(), InitialState, ref pOptimizedClearValue.GetPinnableReference(), riid, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static int CreateReservedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateReservedResource(ref pDesc, InitialState, ref pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource(ref pDesc.GetPinnableReference(), InitialState, ref pOptimizedClearValue.GetPinnableReference(), riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, Span<Guid> riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource(ref pDesc.GetPinnableReference(), InitialState, ref pOptimizedClearValue.GetPinnableReference(), ref riid.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, Span<Guid> riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource(ref pDesc.GetPinnableReference(), InitialState, ref pOptimizedClearValue.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, ID3D12DeviceChild* pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, Span<char> Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(pObject, pAttributes, Access, ref Name.GetPinnableReference(), pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, ID3D12DeviceChild* pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, Span<char> Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(pObject, pAttributes, Access, ref Name.GetPinnableReference(), ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, ID3D12DeviceChild* pObject, Span<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint Access, char* Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(pObject, ref pAttributes.GetPinnableReference(), Access, Name, pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, ID3D12DeviceChild* pObject, Span<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint Access, char* Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(pObject, ref pAttributes.GetPinnableReference(), Access, Name, ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, ID3D12DeviceChild* pObject, Span<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint Access, Span<char> Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(pObject, ref pAttributes.GetPinnableReference(), Access, ref Name.GetPinnableReference(), pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, ID3D12DeviceChild* pObject, Span<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint Access, Span<char> Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(pObject, ref pAttributes.GetPinnableReference(), Access, ref Name.GetPinnableReference(), ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, ID3D12DeviceChild* pObject, Span<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint Access, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(pObject, ref pAttributes.GetPinnableReference(), Access, Name, pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, ID3D12DeviceChild* pObject, Span<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint Access, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(pObject, ref pAttributes.GetPinnableReference(), Access, Name, ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12DeviceChild> pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, char* Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(ref pObject.GetPinnableReference(), pAttributes, Access, Name, pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12DeviceChild> pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, char* Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(ref pObject.GetPinnableReference(), pAttributes, Access, Name, ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12DeviceChild> pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, Span<char> Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(ref pObject.GetPinnableReference(), pAttributes, Access, ref Name.GetPinnableReference(), pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12DeviceChild> pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, Span<char> Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(ref pObject.GetPinnableReference(), pAttributes, Access, ref Name.GetPinnableReference(), ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12DeviceChild> pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(ref pObject.GetPinnableReference(), pAttributes, Access, Name, pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12DeviceChild> pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(ref pObject.GetPinnableReference(), pAttributes, Access, Name, ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12DeviceChild> pObject, Span<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint Access, char* Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(ref pObject.GetPinnableReference(), ref pAttributes.GetPinnableReference(), Access, Name, pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12DeviceChild> pObject, Span<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint Access, char* Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(ref pObject.GetPinnableReference(), ref pAttributes.GetPinnableReference(), Access, Name, ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12DeviceChild> pObject, Span<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint Access, Span<char> Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(ref pObject.GetPinnableReference(), ref pAttributes.GetPinnableReference(), Access, ref Name.GetPinnableReference(), pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12DeviceChild> pObject, Span<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint Access, Span<char> Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(ref pObject.GetPinnableReference(), ref pAttributes.GetPinnableReference(), Access, ref Name.GetPinnableReference(), ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12DeviceChild> pObject, Span<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint Access, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(ref pObject.GetPinnableReference(), ref pAttributes.GetPinnableReference(), Access, Name, pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12DeviceChild> pObject, Span<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint Access, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(ref pObject.GetPinnableReference(), ref pAttributes.GetPinnableReference(), Access, Name, ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle<TI0>(this ComPtr<ID3D12Device7> thisVtbl, void* NTHandle, out ComPtr<TI0> ppvObj) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObj = default;
        return @this->OpenSharedHandle(NTHandle, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObj.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, void* NTHandle, Span<Guid> riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenSharedHandle(NTHandle, ref riid.GetPinnableReference(), ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle(this ComPtr<ID3D12Device7> thisVtbl, void* NTHandle, Span<Guid> riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenSharedHandle(NTHandle, ref riid.GetPinnableReference(), ref ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle<T0>(this ComPtr<ID3D12Device7> thisVtbl, Span<T0> NTHandle, Guid* riid, void** ppvObj) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenSharedHandle(ref NTHandle.GetPinnableReference(), riid, ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static int OpenSharedHandle<T0, TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref T0 NTHandle, out ComPtr<TI0> ppvObj) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObj = default;
        return @this->OpenSharedHandle(ref NTHandle, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObj.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle<T0>(this ComPtr<ID3D12Device7> thisVtbl, Span<T0> NTHandle, Guid* riid, ref void* ppvObj) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenSharedHandle(ref NTHandle.GetPinnableReference(), riid, ref ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle<T0>(this ComPtr<ID3D12Device7> thisVtbl, Span<T0> NTHandle, Span<Guid> riid, void** ppvObj) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenSharedHandle(ref NTHandle.GetPinnableReference(), ref riid.GetPinnableReference(), ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle<T0>(this ComPtr<ID3D12Device7> thisVtbl, Span<T0> NTHandle, Span<Guid> riid, ref void* ppvObj) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenSharedHandle(ref NTHandle.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandleByName(this ComPtr<ID3D12Device7> thisVtbl, Span<char> Name, uint Access, void** pNTHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenSharedHandleByName(ref Name.GetPinnableReference(), Access, pNTHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandleByName(this ComPtr<ID3D12Device7> thisVtbl, Span<char> Name, uint Access, ref void* pNTHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenSharedHandleByName(ref Name.GetPinnableReference(), Access, ref pNTHandle);
    }

    /// <summary>To be documented.</summary>
    public static int MakeResident<TI0>(this ComPtr<ID3D12Device7> thisVtbl, uint NumObjects, ref ComPtr<TI0> ppObjects) where TI0 : unmanaged, IComVtbl<ID3D12Pageable>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MakeResident(NumObjects, (ID3D12Pageable**) ppObjects.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int Evict<TI0>(this ComPtr<ID3D12Device7> thisVtbl, uint NumObjects, ref ComPtr<TI0> ppObjects) where TI0 : unmanaged, IComVtbl<ID3D12Pageable>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Evict(NumObjects, (ID3D12Pageable**) ppObjects.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateFence<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ulong InitialValue, FenceFlags Flags, out ComPtr<TI0> ppFence) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppFence = default;
        return @this->CreateFence(InitialValue, Flags, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppFence.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFence(this ComPtr<ID3D12Device7> thisVtbl, ulong InitialValue, FenceFlags Flags, Span<Guid> riid, void** ppFence)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFence(InitialValue, Flags, ref riid.GetPinnableReference(), ppFence);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFence(this ComPtr<ID3D12Device7> thisVtbl, ulong InitialValue, FenceFlags Flags, Span<Guid> riid, ref void* ppFence)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFence(InitialValue, Flags, ref riid.GetPinnableReference(), ref ppFence);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, Span<ulong> pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, ref pTotalBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, Span<ulong> pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, ref pRowSizeInBytes.GetPinnableReference(), pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, Span<ulong> pRowSizeInBytes, Span<ulong> pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, ref pRowSizeInBytes.GetPinnableReference(), ref pTotalBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, Span<uint> pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, ref pNumRows.GetPinnableReference(), pRowSizeInBytes, pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, Span<uint> pNumRows, ulong* pRowSizeInBytes, Span<ulong> pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, ref pNumRows.GetPinnableReference(), pRowSizeInBytes, ref pTotalBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, Span<uint> pNumRows, Span<ulong> pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, ref pNumRows.GetPinnableReference(), ref pRowSizeInBytes.GetPinnableReference(), pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, Span<uint> pNumRows, Span<ulong> pRowSizeInBytes, Span<ulong> pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, ref pNumRows.GetPinnableReference(), ref pRowSizeInBytes.GetPinnableReference(), ref pTotalBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, Span<PlacedSubresourceFootprint> pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, ref pLayouts.GetPinnableReference(), pNumRows, pRowSizeInBytes, pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, Span<PlacedSubresourceFootprint> pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, Span<ulong> pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, ref pLayouts.GetPinnableReference(), pNumRows, pRowSizeInBytes, ref pTotalBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, Span<PlacedSubresourceFootprint> pLayouts, uint* pNumRows, Span<ulong> pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, ref pLayouts.GetPinnableReference(), pNumRows, ref pRowSizeInBytes.GetPinnableReference(), pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, Span<PlacedSubresourceFootprint> pLayouts, uint* pNumRows, Span<ulong> pRowSizeInBytes, Span<ulong> pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, ref pLayouts.GetPinnableReference(), pNumRows, ref pRowSizeInBytes.GetPinnableReference(), ref pTotalBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, Span<PlacedSubresourceFootprint> pLayouts, Span<uint> pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, ref pLayouts.GetPinnableReference(), ref pNumRows.GetPinnableReference(), pRowSizeInBytes, pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, Span<PlacedSubresourceFootprint> pLayouts, Span<uint> pNumRows, ulong* pRowSizeInBytes, Span<ulong> pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, ref pLayouts.GetPinnableReference(), ref pNumRows.GetPinnableReference(), pRowSizeInBytes, ref pTotalBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, Span<PlacedSubresourceFootprint> pLayouts, Span<uint> pNumRows, Span<ulong> pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, ref pLayouts.GetPinnableReference(), ref pNumRows.GetPinnableReference(), ref pRowSizeInBytes.GetPinnableReference(), pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, Span<PlacedSubresourceFootprint> pLayouts, Span<uint> pNumRows, Span<ulong> pRowSizeInBytes, Span<ulong> pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, ref pLayouts.GetPinnableReference(), ref pNumRows.GetPinnableReference(), ref pRowSizeInBytes.GetPinnableReference(), ref pTotalBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(ref pResourceDesc.GetPinnableReference(), FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, Span<ulong> pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(ref pResourceDesc.GetPinnableReference(), FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, ref pTotalBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, Span<ulong> pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(ref pResourceDesc.GetPinnableReference(), FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, ref pRowSizeInBytes.GetPinnableReference(), pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, Span<ulong> pRowSizeInBytes, Span<ulong> pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(ref pResourceDesc.GetPinnableReference(), FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, ref pRowSizeInBytes.GetPinnableReference(), ref pTotalBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, Span<uint> pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(ref pResourceDesc.GetPinnableReference(), FirstSubresource, NumSubresources, BaseOffset, pLayouts, ref pNumRows.GetPinnableReference(), pRowSizeInBytes, pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, Span<uint> pNumRows, ulong* pRowSizeInBytes, Span<ulong> pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(ref pResourceDesc.GetPinnableReference(), FirstSubresource, NumSubresources, BaseOffset, pLayouts, ref pNumRows.GetPinnableReference(), pRowSizeInBytes, ref pTotalBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, Span<uint> pNumRows, Span<ulong> pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(ref pResourceDesc.GetPinnableReference(), FirstSubresource, NumSubresources, BaseOffset, pLayouts, ref pNumRows.GetPinnableReference(), ref pRowSizeInBytes.GetPinnableReference(), pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, Span<uint> pNumRows, Span<ulong> pRowSizeInBytes, Span<ulong> pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(ref pResourceDesc.GetPinnableReference(), FirstSubresource, NumSubresources, BaseOffset, pLayouts, ref pNumRows.GetPinnableReference(), ref pRowSizeInBytes.GetPinnableReference(), ref pTotalBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, Span<PlacedSubresourceFootprint> pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(ref pResourceDesc.GetPinnableReference(), FirstSubresource, NumSubresources, BaseOffset, ref pLayouts.GetPinnableReference(), pNumRows, pRowSizeInBytes, pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, Span<PlacedSubresourceFootprint> pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, Span<ulong> pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(ref pResourceDesc.GetPinnableReference(), FirstSubresource, NumSubresources, BaseOffset, ref pLayouts.GetPinnableReference(), pNumRows, pRowSizeInBytes, ref pTotalBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, Span<PlacedSubresourceFootprint> pLayouts, uint* pNumRows, Span<ulong> pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(ref pResourceDesc.GetPinnableReference(), FirstSubresource, NumSubresources, BaseOffset, ref pLayouts.GetPinnableReference(), pNumRows, ref pRowSizeInBytes.GetPinnableReference(), pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, Span<PlacedSubresourceFootprint> pLayouts, uint* pNumRows, Span<ulong> pRowSizeInBytes, Span<ulong> pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(ref pResourceDesc.GetPinnableReference(), FirstSubresource, NumSubresources, BaseOffset, ref pLayouts.GetPinnableReference(), pNumRows, ref pRowSizeInBytes.GetPinnableReference(), ref pTotalBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, Span<PlacedSubresourceFootprint> pLayouts, Span<uint> pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(ref pResourceDesc.GetPinnableReference(), FirstSubresource, NumSubresources, BaseOffset, ref pLayouts.GetPinnableReference(), ref pNumRows.GetPinnableReference(), pRowSizeInBytes, pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, Span<PlacedSubresourceFootprint> pLayouts, Span<uint> pNumRows, ulong* pRowSizeInBytes, Span<ulong> pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(ref pResourceDesc.GetPinnableReference(), FirstSubresource, NumSubresources, BaseOffset, ref pLayouts.GetPinnableReference(), ref pNumRows.GetPinnableReference(), pRowSizeInBytes, ref pTotalBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, Span<PlacedSubresourceFootprint> pLayouts, Span<uint> pNumRows, Span<ulong> pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(ref pResourceDesc.GetPinnableReference(), FirstSubresource, NumSubresources, BaseOffset, ref pLayouts.GetPinnableReference(), ref pNumRows.GetPinnableReference(), ref pRowSizeInBytes.GetPinnableReference(), pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static void GetCopyableFootprints(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, Span<PlacedSubresourceFootprint> pLayouts, Span<uint> pNumRows, Span<ulong> pRowSizeInBytes, Span<ulong> pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(ref pResourceDesc.GetPinnableReference(), FirstSubresource, NumSubresources, BaseOffset, ref pLayouts.GetPinnableReference(), ref pNumRows.GetPinnableReference(), ref pRowSizeInBytes.GetPinnableReference(), ref pTotalBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap<TI0>(this ComPtr<ID3D12Device7> thisVtbl, QueryHeapDesc* pDesc, out ComPtr<TI0> ppvHeap) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvHeap = default;
        return @this->CreateQueryHeap(pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap(this ComPtr<ID3D12Device7> thisVtbl, QueryHeapDesc* pDesc, Span<Guid> riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateQueryHeap(pDesc, ref riid.GetPinnableReference(), ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap(this ComPtr<ID3D12Device7> thisVtbl, QueryHeapDesc* pDesc, Span<Guid> riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateQueryHeap(pDesc, ref riid.GetPinnableReference(), ref ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap(this ComPtr<ID3D12Device7> thisVtbl, Span<QueryHeapDesc> pDesc, Guid* riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateQueryHeap(ref pDesc.GetPinnableReference(), riid, ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateQueryHeap<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref QueryHeapDesc pDesc, out ComPtr<TI0> ppvHeap) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvHeap = default;
        return @this->CreateQueryHeap(ref pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap(this ComPtr<ID3D12Device7> thisVtbl, Span<QueryHeapDesc> pDesc, Guid* riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateQueryHeap(ref pDesc.GetPinnableReference(), riid, ref ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap(this ComPtr<ID3D12Device7> thisVtbl, Span<QueryHeapDesc> pDesc, Span<Guid> riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateQueryHeap(ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap(this ComPtr<ID3D12Device7> thisVtbl, Span<QueryHeapDesc> pDesc, Span<Guid> riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateQueryHeap(ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature<TI0>(this ComPtr<ID3D12Device7> thisVtbl, CommandSignatureDesc* pDesc, ID3D12RootSignature* pRootSignature, out ComPtr<TI0> ppvCommandSignature) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvCommandSignature = default;
        return @this->CreateCommandSignature(pDesc, pRootSignature, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvCommandSignature.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device7> thisVtbl, CommandSignatureDesc* pDesc, ID3D12RootSignature* pRootSignature, Span<Guid> riid, void** ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandSignature(pDesc, pRootSignature, ref riid.GetPinnableReference(), ppvCommandSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device7> thisVtbl, CommandSignatureDesc* pDesc, ID3D12RootSignature* pRootSignature, Span<Guid> riid, ref void* ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandSignature(pDesc, pRootSignature, ref riid.GetPinnableReference(), ref ppvCommandSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device7> thisVtbl, CommandSignatureDesc* pDesc, Span<ID3D12RootSignature> pRootSignature, Guid* riid, void** ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandSignature(pDesc, ref pRootSignature.GetPinnableReference(), riid, ppvCommandSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature<TI0>(this ComPtr<ID3D12Device7> thisVtbl, CommandSignatureDesc* pDesc, ref ID3D12RootSignature pRootSignature, out ComPtr<TI0> ppvCommandSignature) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvCommandSignature = default;
        return @this->CreateCommandSignature(pDesc, ref pRootSignature, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvCommandSignature.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device7> thisVtbl, CommandSignatureDesc* pDesc, Span<ID3D12RootSignature> pRootSignature, Guid* riid, ref void* ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandSignature(pDesc, ref pRootSignature.GetPinnableReference(), riid, ref ppvCommandSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device7> thisVtbl, CommandSignatureDesc* pDesc, Span<ID3D12RootSignature> pRootSignature, Span<Guid> riid, void** ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandSignature(pDesc, ref pRootSignature.GetPinnableReference(), ref riid.GetPinnableReference(), ppvCommandSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device7> thisVtbl, CommandSignatureDesc* pDesc, Span<ID3D12RootSignature> pRootSignature, Span<Guid> riid, ref void* ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandSignature(pDesc, ref pRootSignature.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvCommandSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device7> thisVtbl, Span<CommandSignatureDesc> pDesc, ID3D12RootSignature* pRootSignature, Guid* riid, void** ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandSignature(ref pDesc.GetPinnableReference(), pRootSignature, riid, ppvCommandSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref CommandSignatureDesc pDesc, ID3D12RootSignature* pRootSignature, out ComPtr<TI0> ppvCommandSignature) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvCommandSignature = default;
        return @this->CreateCommandSignature(ref pDesc, pRootSignature, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvCommandSignature.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device7> thisVtbl, Span<CommandSignatureDesc> pDesc, ID3D12RootSignature* pRootSignature, Guid* riid, ref void* ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandSignature(ref pDesc.GetPinnableReference(), pRootSignature, riid, ref ppvCommandSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device7> thisVtbl, Span<CommandSignatureDesc> pDesc, ID3D12RootSignature* pRootSignature, Span<Guid> riid, void** ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandSignature(ref pDesc.GetPinnableReference(), pRootSignature, ref riid.GetPinnableReference(), ppvCommandSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device7> thisVtbl, Span<CommandSignatureDesc> pDesc, ID3D12RootSignature* pRootSignature, Span<Guid> riid, ref void* ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandSignature(ref pDesc.GetPinnableReference(), pRootSignature, ref riid.GetPinnableReference(), ref ppvCommandSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device7> thisVtbl, Span<CommandSignatureDesc> pDesc, Span<ID3D12RootSignature> pRootSignature, Guid* riid, void** ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandSignature(ref pDesc.GetPinnableReference(), ref pRootSignature.GetPinnableReference(), riid, ppvCommandSignature);
    }

    /// <summary>To be documented.</summary>
    public static int CreateCommandSignature<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref CommandSignatureDesc pDesc, ref ID3D12RootSignature pRootSignature, out ComPtr<TI0> ppvCommandSignature) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvCommandSignature = default;
        return @this->CreateCommandSignature(ref pDesc, ref pRootSignature, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvCommandSignature.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device7> thisVtbl, Span<CommandSignatureDesc> pDesc, Span<ID3D12RootSignature> pRootSignature, Guid* riid, ref void* ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandSignature(ref pDesc.GetPinnableReference(), ref pRootSignature.GetPinnableReference(), riid, ref ppvCommandSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device7> thisVtbl, Span<CommandSignatureDesc> pDesc, Span<ID3D12RootSignature> pRootSignature, Span<Guid> riid, void** ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandSignature(ref pDesc.GetPinnableReference(), ref pRootSignature.GetPinnableReference(), ref riid.GetPinnableReference(), ppvCommandSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device7> thisVtbl, Span<CommandSignatureDesc> pDesc, Span<ID3D12RootSignature> pRootSignature, Span<Guid> riid, ref void* ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandSignature(ref pDesc.GetPinnableReference(), ref pRootSignature.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvCommandSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, pNumTilesForEntireResource, ref pPackedMipDesc.GetPinnableReference(), pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, pNumTilesForEntireResource, ref pPackedMipDesc.GetPinnableReference(), pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, pNumTilesForEntireResource, ref pPackedMipDesc.GetPinnableReference(), pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, pNumTilesForEntireResource, ref pPackedMipDesc.GetPinnableReference(), pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, pNumTilesForEntireResource, ref pPackedMipDesc.GetPinnableReference(), ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, pNumTilesForEntireResource, ref pPackedMipDesc.GetPinnableReference(), ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, pNumTilesForEntireResource, ref pPackedMipDesc.GetPinnableReference(), ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, pNumTilesForEntireResource, ref pPackedMipDesc.GetPinnableReference(), ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, Span<uint> pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, ref pNumTilesForEntireResource.GetPinnableReference(), pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, Span<uint> pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, ref pNumTilesForEntireResource.GetPinnableReference(), pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, Span<uint> pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, ref pNumTilesForEntireResource.GetPinnableReference(), pPackedMipDesc, pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, Span<uint> pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, ref pNumTilesForEntireResource.GetPinnableReference(), pPackedMipDesc, pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, Span<uint> pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, ref pNumTilesForEntireResource.GetPinnableReference(), pPackedMipDesc, ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, Span<uint> pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, ref pNumTilesForEntireResource.GetPinnableReference(), pPackedMipDesc, ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, Span<uint> pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, ref pNumTilesForEntireResource.GetPinnableReference(), pPackedMipDesc, ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, Span<uint> pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, ref pNumTilesForEntireResource.GetPinnableReference(), pPackedMipDesc, ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, Span<uint> pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, ref pNumTilesForEntireResource.GetPinnableReference(), ref pPackedMipDesc.GetPinnableReference(), pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, Span<uint> pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, ref pNumTilesForEntireResource.GetPinnableReference(), ref pPackedMipDesc.GetPinnableReference(), pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, Span<uint> pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, ref pNumTilesForEntireResource.GetPinnableReference(), ref pPackedMipDesc.GetPinnableReference(), pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, Span<uint> pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, ref pNumTilesForEntireResource.GetPinnableReference(), ref pPackedMipDesc.GetPinnableReference(), pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, Span<uint> pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, ref pNumTilesForEntireResource.GetPinnableReference(), ref pPackedMipDesc.GetPinnableReference(), ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, Span<uint> pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, ref pNumTilesForEntireResource.GetPinnableReference(), ref pPackedMipDesc.GetPinnableReference(), ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, Span<uint> pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, ref pNumTilesForEntireResource.GetPinnableReference(), ref pPackedMipDesc.GetPinnableReference(), ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Resource* pTiledResource, Span<uint> pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, ref pNumTilesForEntireResource.GetPinnableReference(), ref pPackedMipDesc.GetPinnableReference(), ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), pNumTilesForEntireResource, pPackedMipDesc, ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), pNumTilesForEntireResource, pPackedMipDesc, ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), pNumTilesForEntireResource, pPackedMipDesc, ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), pNumTilesForEntireResource, pPackedMipDesc, ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pTiledResource, uint* pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), pNumTilesForEntireResource, ref pPackedMipDesc.GetPinnableReference(), pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pTiledResource, uint* pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), pNumTilesForEntireResource, ref pPackedMipDesc.GetPinnableReference(), pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pTiledResource, uint* pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), pNumTilesForEntireResource, ref pPackedMipDesc.GetPinnableReference(), pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pTiledResource, uint* pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), pNumTilesForEntireResource, ref pPackedMipDesc.GetPinnableReference(), pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pTiledResource, uint* pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), pNumTilesForEntireResource, ref pPackedMipDesc.GetPinnableReference(), ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pTiledResource, uint* pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), pNumTilesForEntireResource, ref pPackedMipDesc.GetPinnableReference(), ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pTiledResource, uint* pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), pNumTilesForEntireResource, ref pPackedMipDesc.GetPinnableReference(), ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pTiledResource, uint* pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), pNumTilesForEntireResource, ref pPackedMipDesc.GetPinnableReference(), ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<uint> pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), ref pNumTilesForEntireResource.GetPinnableReference(), pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<uint> pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), ref pNumTilesForEntireResource.GetPinnableReference(), pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<uint> pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), ref pNumTilesForEntireResource.GetPinnableReference(), pPackedMipDesc, pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<uint> pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), ref pNumTilesForEntireResource.GetPinnableReference(), pPackedMipDesc, pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<uint> pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), ref pNumTilesForEntireResource.GetPinnableReference(), pPackedMipDesc, ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<uint> pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), ref pNumTilesForEntireResource.GetPinnableReference(), pPackedMipDesc, ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<uint> pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), ref pNumTilesForEntireResource.GetPinnableReference(), pPackedMipDesc, ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<uint> pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), ref pNumTilesForEntireResource.GetPinnableReference(), pPackedMipDesc, ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<uint> pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), ref pNumTilesForEntireResource.GetPinnableReference(), ref pPackedMipDesc.GetPinnableReference(), pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<uint> pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), ref pNumTilesForEntireResource.GetPinnableReference(), ref pPackedMipDesc.GetPinnableReference(), pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<uint> pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), ref pNumTilesForEntireResource.GetPinnableReference(), ref pPackedMipDesc.GetPinnableReference(), pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<uint> pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), ref pNumTilesForEntireResource.GetPinnableReference(), ref pPackedMipDesc.GetPinnableReference(), pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<uint> pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), ref pNumTilesForEntireResource.GetPinnableReference(), ref pPackedMipDesc.GetPinnableReference(), ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<uint> pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), ref pNumTilesForEntireResource.GetPinnableReference(), ref pPackedMipDesc.GetPinnableReference(), ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<uint> pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), ref pNumTilesForEntireResource.GetPinnableReference(), ref pPackedMipDesc.GetPinnableReference(), ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static void GetResourceTiling(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<uint> pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), ref pNumTilesForEntireResource.GetPinnableReference(), ref pPackedMipDesc.GetPinnableReference(), ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineLibrary<TI0>(this ComPtr<ID3D12Device7> thisVtbl, void* pLibraryBlob, nuint BlobLength, out ComPtr<TI0> ppPipelineLibrary) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppPipelineLibrary = default;
        return @this->CreatePipelineLibrary(pLibraryBlob, BlobLength, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineLibrary.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineLibrary(this ComPtr<ID3D12Device7> thisVtbl, void* pLibraryBlob, nuint BlobLength, Span<Guid> riid, void** ppPipelineLibrary)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePipelineLibrary(pLibraryBlob, BlobLength, ref riid.GetPinnableReference(), ppPipelineLibrary);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineLibrary(this ComPtr<ID3D12Device7> thisVtbl, void* pLibraryBlob, nuint BlobLength, Span<Guid> riid, ref void* ppPipelineLibrary)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePipelineLibrary(pLibraryBlob, BlobLength, ref riid.GetPinnableReference(), ref ppPipelineLibrary);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineLibrary<T0>(this ComPtr<ID3D12Device7> thisVtbl, Span<T0> pLibraryBlob, nuint BlobLength, Guid* riid, void** ppPipelineLibrary) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePipelineLibrary(ref pLibraryBlob.GetPinnableReference(), BlobLength, riid, ppPipelineLibrary);
    }

    /// <summary>To be documented.</summary>
    public static int CreatePipelineLibrary<T0, TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref T0 pLibraryBlob, nuint BlobLength, out ComPtr<TI0> ppPipelineLibrary) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppPipelineLibrary = default;
        return @this->CreatePipelineLibrary(ref pLibraryBlob, BlobLength, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineLibrary.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineLibrary<T0>(this ComPtr<ID3D12Device7> thisVtbl, Span<T0> pLibraryBlob, nuint BlobLength, Guid* riid, ref void* ppPipelineLibrary) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePipelineLibrary(ref pLibraryBlob.GetPinnableReference(), BlobLength, riid, ref ppPipelineLibrary);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineLibrary<T0>(this ComPtr<ID3D12Device7> thisVtbl, Span<T0> pLibraryBlob, nuint BlobLength, Span<Guid> riid, void** ppPipelineLibrary) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePipelineLibrary(ref pLibraryBlob.GetPinnableReference(), BlobLength, ref riid.GetPinnableReference(), ppPipelineLibrary);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineLibrary<T0>(this ComPtr<ID3D12Device7> thisVtbl, Span<T0> pLibraryBlob, nuint BlobLength, Span<Guid> riid, ref void* ppPipelineLibrary) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePipelineLibrary(ref pLibraryBlob.GetPinnableReference(), BlobLength, ref riid.GetPinnableReference(), ref ppPipelineLibrary);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEventOnMultipleFenceCompletion<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref ComPtr<TI0> ppFences, ulong* pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, void* hEvent) where TI0 : unmanaged, IComVtbl<ID3D12Fence>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetEventOnMultipleFenceCompletion((ID3D12Fence**) ppFences.GetAddressOf(), pFenceValues, NumFences, Flags, hEvent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEventOnMultipleFenceCompletion<T0>(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Fence** ppFences, ulong* pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, Span<T0> hEvent) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetEventOnMultipleFenceCompletion(ppFences, pFenceValues, NumFences, Flags, ref hEvent.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEventOnMultipleFenceCompletion<T0, TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref ComPtr<TI0> ppFences, ulong* pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, ref T0 hEvent) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D12Fence>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetEventOnMultipleFenceCompletion((ID3D12Fence**) ppFences.GetAddressOf(), pFenceValues, NumFences, Flags, ref hEvent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEventOnMultipleFenceCompletion(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Fence** ppFences, Span<ulong> pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, void* hEvent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetEventOnMultipleFenceCompletion(ppFences, ref pFenceValues.GetPinnableReference(), NumFences, Flags, hEvent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEventOnMultipleFenceCompletion<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref ComPtr<TI0> ppFences, ref ulong pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, void* hEvent) where TI0 : unmanaged, IComVtbl<ID3D12Fence>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetEventOnMultipleFenceCompletion((ID3D12Fence**) ppFences.GetAddressOf(), ref pFenceValues, NumFences, Flags, hEvent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEventOnMultipleFenceCompletion<T0>(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Fence** ppFences, Span<ulong> pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, Span<T0> hEvent) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetEventOnMultipleFenceCompletion(ppFences, ref pFenceValues.GetPinnableReference(), NumFences, Flags, ref hEvent.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetEventOnMultipleFenceCompletion<T0, TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref ComPtr<TI0> ppFences, ref ulong pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, ref T0 hEvent) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D12Fence>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetEventOnMultipleFenceCompletion((ID3D12Fence**) ppFences.GetAddressOf(), ref pFenceValues, NumFences, Flags, ref hEvent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEventOnMultipleFenceCompletion<T0>(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Fence* ppFences, ulong* pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, Span<T0> hEvent) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetEventOnMultipleFenceCompletion(ref ppFences, pFenceValues, NumFences, Flags, ref hEvent.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEventOnMultipleFenceCompletion(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Fence* ppFences, Span<ulong> pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, void* hEvent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetEventOnMultipleFenceCompletion(ref ppFences, ref pFenceValues.GetPinnableReference(), NumFences, Flags, hEvent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEventOnMultipleFenceCompletion<T0>(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Fence* ppFences, Span<ulong> pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, Span<T0> hEvent) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetEventOnMultipleFenceCompletion(ref ppFences, ref pFenceValues.GetPinnableReference(), NumFences, Flags, ref hEvent.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetResidencyPriority<TI0>(this ComPtr<ID3D12Device7> thisVtbl, uint NumObjects, ref ComPtr<TI0> ppObjects, ResidencyPriority* pPriorities) where TI0 : unmanaged, IComVtbl<ID3D12Pageable>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetResidencyPriority(NumObjects, (ID3D12Pageable**) ppObjects.GetAddressOf(), pPriorities);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetResidencyPriority(this ComPtr<ID3D12Device7> thisVtbl, uint NumObjects, ID3D12Pageable** ppObjects, Span<ResidencyPriority> pPriorities)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetResidencyPriority(NumObjects, ppObjects, ref pPriorities.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetResidencyPriority<TI0>(this ComPtr<ID3D12Device7> thisVtbl, uint NumObjects, ref ComPtr<TI0> ppObjects, ref ResidencyPriority pPriorities) where TI0 : unmanaged, IComVtbl<ID3D12Pageable>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetResidencyPriority(NumObjects, (ID3D12Pageable**) ppObjects.GetAddressOf(), ref pPriorities);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetResidencyPriority(this ComPtr<ID3D12Device7> thisVtbl, uint NumObjects, ref ID3D12Pageable* ppObjects, Span<ResidencyPriority> pPriorities)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetResidencyPriority(NumObjects, ref ppObjects, ref pPriorities.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineState<TI0>(this ComPtr<ID3D12Device7> thisVtbl, PipelineStateStreamDesc* pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppPipelineState = default;
        return @this->CreatePipelineState(pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineState(this ComPtr<ID3D12Device7> thisVtbl, PipelineStateStreamDesc* pDesc, Span<Guid> riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePipelineState(pDesc, ref riid.GetPinnableReference(), ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineState(this ComPtr<ID3D12Device7> thisVtbl, PipelineStateStreamDesc* pDesc, Span<Guid> riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePipelineState(pDesc, ref riid.GetPinnableReference(), ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineState(this ComPtr<ID3D12Device7> thisVtbl, Span<PipelineStateStreamDesc> pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePipelineState(ref pDesc.GetPinnableReference(), riid, ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static int CreatePipelineState<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref PipelineStateStreamDesc pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppPipelineState = default;
        return @this->CreatePipelineState(ref pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineState(this ComPtr<ID3D12Device7> thisVtbl, Span<PipelineStateStreamDesc> pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePipelineState(ref pDesc.GetPinnableReference(), riid, ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineState(this ComPtr<ID3D12Device7> thisVtbl, Span<PipelineStateStreamDesc> pDesc, Span<Guid> riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePipelineState(ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineState(this ComPtr<ID3D12Device7> thisVtbl, Span<PipelineStateStreamDesc> pDesc, Span<Guid> riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePipelineState(ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromAddress<TI0>(this ComPtr<ID3D12Device7> thisVtbl, void* pAddress, out ComPtr<TI0> ppvHeap) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvHeap = default;
        return @this->OpenExistingHeapFromAddress(pAddress, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromAddress(this ComPtr<ID3D12Device7> thisVtbl, void* pAddress, Span<Guid> riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenExistingHeapFromAddress(pAddress, ref riid.GetPinnableReference(), ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromAddress(this ComPtr<ID3D12Device7> thisVtbl, void* pAddress, Span<Guid> riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenExistingHeapFromAddress(pAddress, ref riid.GetPinnableReference(), ref ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromAddress<T0>(this ComPtr<ID3D12Device7> thisVtbl, Span<T0> pAddress, Guid* riid, void** ppvHeap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenExistingHeapFromAddress(ref pAddress.GetPinnableReference(), riid, ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static int OpenExistingHeapFromAddress<T0, TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref T0 pAddress, out ComPtr<TI0> ppvHeap) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvHeap = default;
        return @this->OpenExistingHeapFromAddress(ref pAddress, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromAddress<T0>(this ComPtr<ID3D12Device7> thisVtbl, Span<T0> pAddress, Guid* riid, ref void* ppvHeap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenExistingHeapFromAddress(ref pAddress.GetPinnableReference(), riid, ref ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromAddress<T0>(this ComPtr<ID3D12Device7> thisVtbl, Span<T0> pAddress, Span<Guid> riid, void** ppvHeap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenExistingHeapFromAddress(ref pAddress.GetPinnableReference(), ref riid.GetPinnableReference(), ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromAddress<T0>(this ComPtr<ID3D12Device7> thisVtbl, Span<T0> pAddress, Span<Guid> riid, ref void* ppvHeap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenExistingHeapFromAddress(ref pAddress.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromFileMapping<TI0>(this ComPtr<ID3D12Device7> thisVtbl, void* hFileMapping, out ComPtr<TI0> ppvHeap) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvHeap = default;
        return @this->OpenExistingHeapFromFileMapping(hFileMapping, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromFileMapping(this ComPtr<ID3D12Device7> thisVtbl, void* hFileMapping, Span<Guid> riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenExistingHeapFromFileMapping(hFileMapping, ref riid.GetPinnableReference(), ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromFileMapping(this ComPtr<ID3D12Device7> thisVtbl, void* hFileMapping, Span<Guid> riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenExistingHeapFromFileMapping(hFileMapping, ref riid.GetPinnableReference(), ref ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromFileMapping<T0>(this ComPtr<ID3D12Device7> thisVtbl, Span<T0> hFileMapping, Guid* riid, void** ppvHeap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenExistingHeapFromFileMapping(ref hFileMapping.GetPinnableReference(), riid, ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static int OpenExistingHeapFromFileMapping<T0, TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref T0 hFileMapping, out ComPtr<TI0> ppvHeap) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvHeap = default;
        return @this->OpenExistingHeapFromFileMapping(ref hFileMapping, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromFileMapping<T0>(this ComPtr<ID3D12Device7> thisVtbl, Span<T0> hFileMapping, Guid* riid, ref void* ppvHeap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenExistingHeapFromFileMapping(ref hFileMapping.GetPinnableReference(), riid, ref ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromFileMapping<T0>(this ComPtr<ID3D12Device7> thisVtbl, Span<T0> hFileMapping, Span<Guid> riid, void** ppvHeap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenExistingHeapFromFileMapping(ref hFileMapping.GetPinnableReference(), ref riid.GetPinnableReference(), ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromFileMapping<T0>(this ComPtr<ID3D12Device7> thisVtbl, Span<T0> hFileMapping, Span<Guid> riid, ref void* ppvHeap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenExistingHeapFromFileMapping(ref hFileMapping.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnqueueMakeResident<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ResidencyFlags Flags, uint NumObjects, ref ComPtr<TI0> ppObjects, ID3D12Fence* pFenceToSignal, ulong FenceValueToSignal) where TI0 : unmanaged, IComVtbl<ID3D12Pageable>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->EnqueueMakeResident(Flags, NumObjects, (ID3D12Pageable**) ppObjects.GetAddressOf(), pFenceToSignal, FenceValueToSignal);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnqueueMakeResident(this ComPtr<ID3D12Device7> thisVtbl, ResidencyFlags Flags, uint NumObjects, ID3D12Pageable** ppObjects, Span<ID3D12Fence> pFenceToSignal, ulong FenceValueToSignal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnqueueMakeResident(Flags, NumObjects, ppObjects, ref pFenceToSignal.GetPinnableReference(), FenceValueToSignal);
    }

    /// <summary>To be documented.</summary>
    public static int EnqueueMakeResident<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ResidencyFlags Flags, uint NumObjects, ref ComPtr<TI0> ppObjects, ref ID3D12Fence pFenceToSignal, ulong FenceValueToSignal) where TI0 : unmanaged, IComVtbl<ID3D12Pageable>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->EnqueueMakeResident(Flags, NumObjects, (ID3D12Pageable**) ppObjects.GetAddressOf(), ref pFenceToSignal, FenceValueToSignal);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnqueueMakeResident(this ComPtr<ID3D12Device7> thisVtbl, ResidencyFlags Flags, uint NumObjects, ref ID3D12Pageable* ppObjects, Span<ID3D12Fence> pFenceToSignal, ulong FenceValueToSignal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnqueueMakeResident(Flags, NumObjects, ref ppObjects, ref pFenceToSignal.GetPinnableReference(), FenceValueToSignal);
    }

    /// <summary>To be documented.</summary>
    public static int CreateCommandList1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, CommandListFlags flags, out ComPtr<TI0> ppCommandList) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCommandList = default;
        return @this->CreateCommandList1(nodeMask, type, flags, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCommandList.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList1(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, CommandListFlags flags, Span<Guid> riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandList1(nodeMask, type, flags, ref riid.GetPinnableReference(), ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList1(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, CommandListFlags flags, Span<Guid> riid, ref void* ppCommandList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandList1(nodeMask, type, flags, ref riid.GetPinnableReference(), ref ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ProtectedResourceSessionDesc* pDesc, out ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppSession = default;
        return @this->CreateProtectedResourceSession(pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession(this ComPtr<ID3D12Device7> thisVtbl, ProtectedResourceSessionDesc* pDesc, Span<Guid> riid, void** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateProtectedResourceSession(pDesc, ref riid.GetPinnableReference(), ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession(this ComPtr<ID3D12Device7> thisVtbl, ProtectedResourceSessionDesc* pDesc, Span<Guid> riid, ref void* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateProtectedResourceSession(pDesc, ref riid.GetPinnableReference(), ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession(this ComPtr<ID3D12Device7> thisVtbl, Span<ProtectedResourceSessionDesc> pDesc, Guid* riid, void** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateProtectedResourceSession(ref pDesc.GetPinnableReference(), riid, ppSession);
    }

    /// <summary>To be documented.</summary>
    public static int CreateProtectedResourceSession<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref ProtectedResourceSessionDesc pDesc, out ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppSession = default;
        return @this->CreateProtectedResourceSession(ref pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession(this ComPtr<ID3D12Device7> thisVtbl, Span<ProtectedResourceSessionDesc> pDesc, Guid* riid, ref void* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateProtectedResourceSession(ref pDesc.GetPinnableReference(), riid, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession(this ComPtr<ID3D12Device7> thisVtbl, Span<ProtectedResourceSessionDesc> pDesc, Span<Guid> riid, void** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateProtectedResourceSession(ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession(this ComPtr<ID3D12Device7> thisVtbl, Span<ProtectedResourceSessionDesc> pDesc, Span<Guid> riid, ref void* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateProtectedResourceSession(ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Span<Guid> riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, ref riidResource.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Span<Guid> riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, ref riidResource.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, ref pProtectedSession.GetPinnableReference(), riidResource, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, ref pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, ref pProtectedSession.GetPinnableReference(), riidResource, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Span<Guid> riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, ref pProtectedSession.GetPinnableReference(), ref riidResource.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Span<Guid> riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, ref pProtectedSession.GetPinnableReference(), ref riidResource.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), pProtectedSession, riidResource, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue, pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), pProtectedSession, riidResource, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Span<Guid> riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), pProtectedSession, ref riidResource.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Span<Guid> riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), pProtectedSession, ref riidResource.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), ref pProtectedSession.GetPinnableReference(), riidResource, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue, ref pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), ref pProtectedSession.GetPinnableReference(), riidResource, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Span<Guid> riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), ref pProtectedSession.GetPinnableReference(), ref riidResource.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Span<Guid> riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), ref pProtectedSession.GetPinnableReference(), ref riidResource.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, ref pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Span<Guid> riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, pOptimizedClearValue, pProtectedSession, ref riidResource.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Span<Guid> riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, pOptimizedClearValue, pProtectedSession, ref riidResource.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, pOptimizedClearValue, ref pProtectedSession.GetPinnableReference(), riidResource, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, ref pDesc, InitialResourceState, pOptimizedClearValue, ref pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, pOptimizedClearValue, ref pProtectedSession.GetPinnableReference(), riidResource, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Span<Guid> riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, pOptimizedClearValue, ref pProtectedSession.GetPinnableReference(), ref riidResource.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Span<Guid> riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, pOptimizedClearValue, ref pProtectedSession.GetPinnableReference(), ref riidResource.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), pProtectedSession, riidResource, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, ref pDesc, InitialResourceState, ref pOptimizedClearValue, pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), pProtectedSession, riidResource, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Span<Guid> riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), pProtectedSession, ref riidResource.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Span<Guid> riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), pProtectedSession, ref riidResource.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), ref pProtectedSession.GetPinnableReference(), riidResource, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, ref pDesc, InitialResourceState, ref pOptimizedClearValue, ref pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), ref pProtectedSession.GetPinnableReference(), riidResource, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Span<Guid> riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), ref pProtectedSession.GetPinnableReference(), ref riidResource.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Span<Guid> riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), ref pProtectedSession.GetPinnableReference(), ref riidResource.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(ref pHeapProperties.GetPinnableReference(), HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateCommittedResource1(ref pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(ref pHeapProperties.GetPinnableReference(), HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Span<Guid> riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(ref pHeapProperties.GetPinnableReference(), HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, ref riidResource.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Span<Guid> riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(ref pHeapProperties.GetPinnableReference(), HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, ref riidResource.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(ref pHeapProperties.GetPinnableReference(), HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, ref pProtectedSession.GetPinnableReference(), riidResource, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateCommittedResource1(ref pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, ref pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(ref pHeapProperties.GetPinnableReference(), HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, ref pProtectedSession.GetPinnableReference(), riidResource, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Span<Guid> riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(ref pHeapProperties.GetPinnableReference(), HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, ref pProtectedSession.GetPinnableReference(), ref riidResource.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Span<Guid> riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(ref pHeapProperties.GetPinnableReference(), HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, ref pProtectedSession.GetPinnableReference(), ref riidResource.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(ref pHeapProperties.GetPinnableReference(), HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), pProtectedSession, riidResource, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateCommittedResource1(ref pHeapProperties, HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue, pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(ref pHeapProperties.GetPinnableReference(), HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), pProtectedSession, riidResource, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Span<Guid> riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(ref pHeapProperties.GetPinnableReference(), HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), pProtectedSession, ref riidResource.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Span<Guid> riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(ref pHeapProperties.GetPinnableReference(), HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), pProtectedSession, ref riidResource.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(ref pHeapProperties.GetPinnableReference(), HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), ref pProtectedSession.GetPinnableReference(), riidResource, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateCommittedResource1(ref pHeapProperties, HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue, ref pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(ref pHeapProperties.GetPinnableReference(), HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), ref pProtectedSession.GetPinnableReference(), riidResource, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Span<Guid> riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(ref pHeapProperties.GetPinnableReference(), HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), ref pProtectedSession.GetPinnableReference(), ref riidResource.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Span<Guid> riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(ref pHeapProperties.GetPinnableReference(), HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), ref pProtectedSession.GetPinnableReference(), ref riidResource.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(ref pHeapProperties.GetPinnableReference(), HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateCommittedResource1(ref pHeapProperties, HeapFlags, ref pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(ref pHeapProperties.GetPinnableReference(), HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Span<Guid> riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(ref pHeapProperties.GetPinnableReference(), HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, pOptimizedClearValue, pProtectedSession, ref riidResource.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Span<Guid> riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(ref pHeapProperties.GetPinnableReference(), HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, pOptimizedClearValue, pProtectedSession, ref riidResource.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(ref pHeapProperties.GetPinnableReference(), HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, pOptimizedClearValue, ref pProtectedSession.GetPinnableReference(), riidResource, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateCommittedResource1(ref pHeapProperties, HeapFlags, ref pDesc, InitialResourceState, pOptimizedClearValue, ref pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(ref pHeapProperties.GetPinnableReference(), HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, pOptimizedClearValue, ref pProtectedSession.GetPinnableReference(), riidResource, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Span<Guid> riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(ref pHeapProperties.GetPinnableReference(), HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, pOptimizedClearValue, ref pProtectedSession.GetPinnableReference(), ref riidResource.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Span<Guid> riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(ref pHeapProperties.GetPinnableReference(), HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, pOptimizedClearValue, ref pProtectedSession.GetPinnableReference(), ref riidResource.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(ref pHeapProperties.GetPinnableReference(), HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), pProtectedSession, riidResource, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateCommittedResource1(ref pHeapProperties, HeapFlags, ref pDesc, InitialResourceState, ref pOptimizedClearValue, pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(ref pHeapProperties.GetPinnableReference(), HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), pProtectedSession, riidResource, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Span<Guid> riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(ref pHeapProperties.GetPinnableReference(), HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), pProtectedSession, ref riidResource.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Span<Guid> riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(ref pHeapProperties.GetPinnableReference(), HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), pProtectedSession, ref riidResource.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(ref pHeapProperties.GetPinnableReference(), HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), ref pProtectedSession.GetPinnableReference(), riidResource, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static int CreateCommittedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateCommittedResource1(ref pHeapProperties, HeapFlags, ref pDesc, InitialResourceState, ref pOptimizedClearValue, ref pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(ref pHeapProperties.GetPinnableReference(), HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), ref pProtectedSession.GetPinnableReference(), riidResource, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Span<Guid> riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(ref pHeapProperties.GetPinnableReference(), HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), ref pProtectedSession.GetPinnableReference(), ref riidResource.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags HeapFlags, Span<ResourceDesc> pDesc, ResourceStates InitialResourceState, Span<ClearValue> pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Span<Guid> riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource1(ref pHeapProperties.GetPinnableReference(), HeapFlags, ref pDesc.GetPinnableReference(), InitialResourceState, ref pOptimizedClearValue.GetPinnableReference(), ref pProtectedSession.GetPinnableReference(), ref riidResource.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, HeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedSession, out ComPtr<TI0> ppvHeap) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvHeap = default;
        return @this->CreateHeap1(pDesc, pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1(this ComPtr<ID3D12Device7> thisVtbl, HeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedSession, Span<Guid> riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHeap1(pDesc, pProtectedSession, ref riid.GetPinnableReference(), ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1(this ComPtr<ID3D12Device7> thisVtbl, HeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedSession, Span<Guid> riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHeap1(pDesc, pProtectedSession, ref riid.GetPinnableReference(), ref ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1(this ComPtr<ID3D12Device7> thisVtbl, HeapDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedSession, Guid* riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHeap1(pDesc, ref pProtectedSession.GetPinnableReference(), riid, ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, HeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, out ComPtr<TI0> ppvHeap) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvHeap = default;
        return @this->CreateHeap1(pDesc, ref pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1(this ComPtr<ID3D12Device7> thisVtbl, HeapDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedSession, Guid* riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHeap1(pDesc, ref pProtectedSession.GetPinnableReference(), riid, ref ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1(this ComPtr<ID3D12Device7> thisVtbl, HeapDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedSession, Span<Guid> riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHeap1(pDesc, ref pProtectedSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1(this ComPtr<ID3D12Device7> thisVtbl, HeapDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedSession, Span<Guid> riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHeap1(pDesc, ref pProtectedSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHeap1(ref pDesc.GetPinnableReference(), pProtectedSession, riid, ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref HeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedSession, out ComPtr<TI0> ppvHeap) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvHeap = default;
        return @this->CreateHeap1(ref pDesc, pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHeap1(ref pDesc.GetPinnableReference(), pProtectedSession, riid, ref ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedSession, Span<Guid> riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHeap1(ref pDesc.GetPinnableReference(), pProtectedSession, ref riid.GetPinnableReference(), ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedSession, Span<Guid> riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHeap1(ref pDesc.GetPinnableReference(), pProtectedSession, ref riid.GetPinnableReference(), ref ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedSession, Guid* riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHeap1(ref pDesc.GetPinnableReference(), ref pProtectedSession.GetPinnableReference(), riid, ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateHeap1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref HeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, out ComPtr<TI0> ppvHeap) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvHeap = default;
        return @this->CreateHeap1(ref pDesc, ref pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedSession, Guid* riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHeap1(ref pDesc.GetPinnableReference(), ref pProtectedSession.GetPinnableReference(), riid, ref ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedSession, Span<Guid> riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHeap1(ref pDesc.GetPinnableReference(), ref pProtectedSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1(this ComPtr<ID3D12Device7> thisVtbl, Span<HeapDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedSession, Span<Guid> riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHeap1(ref pDesc.GetPinnableReference(), ref pProtectedSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateReservedResource1(pDesc, InitialState, pOptimizedClearValue, pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Span<Guid> riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource1(pDesc, InitialState, pOptimizedClearValue, pProtectedSession, ref riid.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Span<Guid> riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource1(pDesc, InitialState, pOptimizedClearValue, pProtectedSession, ref riid.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource1(pDesc, InitialState, pOptimizedClearValue, ref pProtectedSession.GetPinnableReference(), riid, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateReservedResource1(pDesc, InitialState, pOptimizedClearValue, ref pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource1(pDesc, InitialState, pOptimizedClearValue, ref pProtectedSession.GetPinnableReference(), riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Span<Guid> riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource1(pDesc, InitialState, pOptimizedClearValue, ref pProtectedSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Span<Guid> riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource1(pDesc, InitialState, pOptimizedClearValue, ref pProtectedSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource1(pDesc, InitialState, ref pOptimizedClearValue.GetPinnableReference(), pProtectedSession, riid, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateReservedResource1(pDesc, InitialState, ref pOptimizedClearValue, pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource1(pDesc, InitialState, ref pOptimizedClearValue.GetPinnableReference(), pProtectedSession, riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Span<Guid> riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource1(pDesc, InitialState, ref pOptimizedClearValue.GetPinnableReference(), pProtectedSession, ref riid.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Span<Guid> riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource1(pDesc, InitialState, ref pOptimizedClearValue.GetPinnableReference(), pProtectedSession, ref riid.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource1(pDesc, InitialState, ref pOptimizedClearValue.GetPinnableReference(), ref pProtectedSession.GetPinnableReference(), riid, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateReservedResource1(pDesc, InitialState, ref pOptimizedClearValue, ref pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource1(pDesc, InitialState, ref pOptimizedClearValue.GetPinnableReference(), ref pProtectedSession.GetPinnableReference(), riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Span<Guid> riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource1(pDesc, InitialState, ref pOptimizedClearValue.GetPinnableReference(), ref pProtectedSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Span<Guid> riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource1(pDesc, InitialState, ref pOptimizedClearValue.GetPinnableReference(), ref pProtectedSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource1(ref pDesc.GetPinnableReference(), InitialState, pOptimizedClearValue, pProtectedSession, riid, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateReservedResource1(ref pDesc, InitialState, pOptimizedClearValue, pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource1(ref pDesc.GetPinnableReference(), InitialState, pOptimizedClearValue, pProtectedSession, riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Span<Guid> riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource1(ref pDesc.GetPinnableReference(), InitialState, pOptimizedClearValue, pProtectedSession, ref riid.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Span<Guid> riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource1(ref pDesc.GetPinnableReference(), InitialState, pOptimizedClearValue, pProtectedSession, ref riid.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource1(ref pDesc.GetPinnableReference(), InitialState, pOptimizedClearValue, ref pProtectedSession.GetPinnableReference(), riid, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateReservedResource1(ref pDesc, InitialState, pOptimizedClearValue, ref pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource1(ref pDesc.GetPinnableReference(), InitialState, pOptimizedClearValue, ref pProtectedSession.GetPinnableReference(), riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Span<Guid> riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource1(ref pDesc.GetPinnableReference(), InitialState, pOptimizedClearValue, ref pProtectedSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Span<Guid> riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource1(ref pDesc.GetPinnableReference(), InitialState, pOptimizedClearValue, ref pProtectedSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource1(ref pDesc.GetPinnableReference(), InitialState, ref pOptimizedClearValue.GetPinnableReference(), pProtectedSession, riid, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateReservedResource1(ref pDesc, InitialState, ref pOptimizedClearValue, pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource1(ref pDesc.GetPinnableReference(), InitialState, ref pOptimizedClearValue.GetPinnableReference(), pProtectedSession, riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Span<Guid> riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource1(ref pDesc.GetPinnableReference(), InitialState, ref pOptimizedClearValue.GetPinnableReference(), pProtectedSession, ref riid.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Span<Guid> riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource1(ref pDesc.GetPinnableReference(), InitialState, ref pOptimizedClearValue.GetPinnableReference(), pProtectedSession, ref riid.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource1(ref pDesc.GetPinnableReference(), InitialState, ref pOptimizedClearValue.GetPinnableReference(), ref pProtectedSession.GetPinnableReference(), riid, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static int CreateReservedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateReservedResource1(ref pDesc, InitialState, ref pOptimizedClearValue, ref pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource1(ref pDesc.GetPinnableReference(), InitialState, ref pOptimizedClearValue.GetPinnableReference(), ref pProtectedSession.GetPinnableReference(), riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Span<Guid> riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource1(ref pDesc.GetPinnableReference(), InitialState, ref pOptimizedClearValue.GetPinnableReference(), ref pProtectedSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device7> thisVtbl, Span<ResourceDesc> pDesc, ResourceStates InitialState, Span<ClearValue> pOptimizedClearValue, Span<ID3D12ProtectedResourceSession> pProtectedSession, Span<Guid> riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource1(ref pDesc.GetPinnableReference(), InitialState, ref pOptimizedClearValue.GetPinnableReference(), ref pProtectedSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe ResourceAllocationInfo GetResourceAllocationInfo1(this ComPtr<ID3D12Device7> thisVtbl, uint visibleMask, uint numResourceDescs, ResourceDesc* pResourceDescs, Span<ResourceAllocationInfo1> pResourceAllocationInfo1)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetResourceAllocationInfo1(visibleMask, numResourceDescs, pResourceDescs, ref pResourceAllocationInfo1.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe ResourceAllocationInfo GetResourceAllocationInfo1(this ComPtr<ID3D12Device7> thisVtbl, uint visibleMask, uint numResourceDescs, Span<ResourceDesc> pResourceDescs, ResourceAllocationInfo1* pResourceAllocationInfo1)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetResourceAllocationInfo1(visibleMask, numResourceDescs, ref pResourceDescs.GetPinnableReference(), pResourceAllocationInfo1);
    }

    /// <summary>To be documented.</summary>
    public static ResourceAllocationInfo GetResourceAllocationInfo1(this ComPtr<ID3D12Device7> thisVtbl, uint visibleMask, uint numResourceDescs, Span<ResourceDesc> pResourceDescs, Span<ResourceAllocationInfo1> pResourceAllocationInfo1)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetResourceAllocationInfo1(visibleMask, numResourceDescs, ref pResourceDescs.GetPinnableReference(), ref pResourceAllocationInfo1.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLifetimeTracker<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ID3D12LifetimeOwner* pOwner, out ComPtr<TI0> ppvTracker) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvTracker = default;
        return @this->CreateLifetimeTracker(pOwner, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvTracker.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLifetimeTracker(this ComPtr<ID3D12Device7> thisVtbl, ID3D12LifetimeOwner* pOwner, Span<Guid> riid, void** ppvTracker)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLifetimeTracker(pOwner, ref riid.GetPinnableReference(), ppvTracker);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLifetimeTracker(this ComPtr<ID3D12Device7> thisVtbl, ID3D12LifetimeOwner* pOwner, Span<Guid> riid, ref void* ppvTracker)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLifetimeTracker(pOwner, ref riid.GetPinnableReference(), ref ppvTracker);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLifetimeTracker(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12LifetimeOwner> pOwner, Guid* riid, void** ppvTracker)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLifetimeTracker(ref pOwner.GetPinnableReference(), riid, ppvTracker);
    }

    /// <summary>To be documented.</summary>
    public static int CreateLifetimeTracker<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12LifetimeOwner pOwner, out ComPtr<TI0> ppvTracker) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvTracker = default;
        return @this->CreateLifetimeTracker(ref pOwner, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvTracker.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLifetimeTracker(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12LifetimeOwner> pOwner, Guid* riid, ref void* ppvTracker)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLifetimeTracker(ref pOwner.GetPinnableReference(), riid, ref ppvTracker);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLifetimeTracker(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12LifetimeOwner> pOwner, Span<Guid> riid, void** ppvTracker)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLifetimeTracker(ref pOwner.GetPinnableReference(), ref riid.GetPinnableReference(), ppvTracker);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLifetimeTracker(this ComPtr<ID3D12Device7> thisVtbl, Span<ID3D12LifetimeOwner> pOwner, Span<Guid> riid, ref void* ppvTracker)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLifetimeTracker(ref pOwner.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvTracker);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommands(this ComPtr<ID3D12Device7> thisVtbl, uint* pNumMetaCommands, Span<MetaCommandDesc> pDescs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnumerateMetaCommands(pNumMetaCommands, ref pDescs.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommands(this ComPtr<ID3D12Device7> thisVtbl, Span<uint> pNumMetaCommands, MetaCommandDesc* pDescs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnumerateMetaCommands(ref pNumMetaCommands.GetPinnableReference(), pDescs);
    }

    /// <summary>To be documented.</summary>
    public static int EnumerateMetaCommands(this ComPtr<ID3D12Device7> thisVtbl, Span<uint> pNumMetaCommands, Span<MetaCommandDesc> pDescs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnumerateMetaCommands(ref pNumMetaCommands.GetPinnableReference(), ref pDescs.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters(this ComPtr<ID3D12Device7> thisVtbl, Guid* CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, uint* pParameterCount, Span<MetaCommandParameterDesc> pParameterDescs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnumerateMetaCommandParameters(CommandId, Stage, pTotalStructureSizeInBytes, pParameterCount, ref pParameterDescs.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters(this ComPtr<ID3D12Device7> thisVtbl, Guid* CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, Span<uint> pParameterCount, MetaCommandParameterDesc* pParameterDescs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnumerateMetaCommandParameters(CommandId, Stage, pTotalStructureSizeInBytes, ref pParameterCount.GetPinnableReference(), pParameterDescs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters(this ComPtr<ID3D12Device7> thisVtbl, Guid* CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, Span<uint> pParameterCount, Span<MetaCommandParameterDesc> pParameterDescs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnumerateMetaCommandParameters(CommandId, Stage, pTotalStructureSizeInBytes, ref pParameterCount.GetPinnableReference(), ref pParameterDescs.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters(this ComPtr<ID3D12Device7> thisVtbl, Guid* CommandId, MetaCommandParameterStage Stage, Span<uint> pTotalStructureSizeInBytes, uint* pParameterCount, MetaCommandParameterDesc* pParameterDescs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnumerateMetaCommandParameters(CommandId, Stage, ref pTotalStructureSizeInBytes.GetPinnableReference(), pParameterCount, pParameterDescs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters(this ComPtr<ID3D12Device7> thisVtbl, Guid* CommandId, MetaCommandParameterStage Stage, Span<uint> pTotalStructureSizeInBytes, uint* pParameterCount, Span<MetaCommandParameterDesc> pParameterDescs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnumerateMetaCommandParameters(CommandId, Stage, ref pTotalStructureSizeInBytes.GetPinnableReference(), pParameterCount, ref pParameterDescs.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters(this ComPtr<ID3D12Device7> thisVtbl, Guid* CommandId, MetaCommandParameterStage Stage, Span<uint> pTotalStructureSizeInBytes, Span<uint> pParameterCount, MetaCommandParameterDesc* pParameterDescs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnumerateMetaCommandParameters(CommandId, Stage, ref pTotalStructureSizeInBytes.GetPinnableReference(), ref pParameterCount.GetPinnableReference(), pParameterDescs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters(this ComPtr<ID3D12Device7> thisVtbl, Guid* CommandId, MetaCommandParameterStage Stage, Span<uint> pTotalStructureSizeInBytes, Span<uint> pParameterCount, Span<MetaCommandParameterDesc> pParameterDescs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnumerateMetaCommandParameters(CommandId, Stage, ref pTotalStructureSizeInBytes.GetPinnableReference(), ref pParameterCount.GetPinnableReference(), ref pParameterDescs.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters(this ComPtr<ID3D12Device7> thisVtbl, Span<Guid> CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, uint* pParameterCount, MetaCommandParameterDesc* pParameterDescs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnumerateMetaCommandParameters(ref CommandId.GetPinnableReference(), Stage, pTotalStructureSizeInBytes, pParameterCount, pParameterDescs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters(this ComPtr<ID3D12Device7> thisVtbl, Span<Guid> CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, uint* pParameterCount, Span<MetaCommandParameterDesc> pParameterDescs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnumerateMetaCommandParameters(ref CommandId.GetPinnableReference(), Stage, pTotalStructureSizeInBytes, pParameterCount, ref pParameterDescs.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters(this ComPtr<ID3D12Device7> thisVtbl, Span<Guid> CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, Span<uint> pParameterCount, MetaCommandParameterDesc* pParameterDescs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnumerateMetaCommandParameters(ref CommandId.GetPinnableReference(), Stage, pTotalStructureSizeInBytes, ref pParameterCount.GetPinnableReference(), pParameterDescs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters(this ComPtr<ID3D12Device7> thisVtbl, Span<Guid> CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, Span<uint> pParameterCount, Span<MetaCommandParameterDesc> pParameterDescs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnumerateMetaCommandParameters(ref CommandId.GetPinnableReference(), Stage, pTotalStructureSizeInBytes, ref pParameterCount.GetPinnableReference(), ref pParameterDescs.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters(this ComPtr<ID3D12Device7> thisVtbl, Span<Guid> CommandId, MetaCommandParameterStage Stage, Span<uint> pTotalStructureSizeInBytes, uint* pParameterCount, MetaCommandParameterDesc* pParameterDescs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnumerateMetaCommandParameters(ref CommandId.GetPinnableReference(), Stage, ref pTotalStructureSizeInBytes.GetPinnableReference(), pParameterCount, pParameterDescs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters(this ComPtr<ID3D12Device7> thisVtbl, Span<Guid> CommandId, MetaCommandParameterStage Stage, Span<uint> pTotalStructureSizeInBytes, uint* pParameterCount, Span<MetaCommandParameterDesc> pParameterDescs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnumerateMetaCommandParameters(ref CommandId.GetPinnableReference(), Stage, ref pTotalStructureSizeInBytes.GetPinnableReference(), pParameterCount, ref pParameterDescs.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters(this ComPtr<ID3D12Device7> thisVtbl, Span<Guid> CommandId, MetaCommandParameterStage Stage, Span<uint> pTotalStructureSizeInBytes, Span<uint> pParameterCount, MetaCommandParameterDesc* pParameterDescs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnumerateMetaCommandParameters(ref CommandId.GetPinnableReference(), Stage, ref pTotalStructureSizeInBytes.GetPinnableReference(), ref pParameterCount.GetPinnableReference(), pParameterDescs);
    }

    /// <summary>To be documented.</summary>
    public static int EnumerateMetaCommandParameters(this ComPtr<ID3D12Device7> thisVtbl, Span<Guid> CommandId, MetaCommandParameterStage Stage, Span<uint> pTotalStructureSizeInBytes, Span<uint> pParameterCount, Span<MetaCommandParameterDesc> pParameterDescs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnumerateMetaCommandParameters(ref CommandId.GetPinnableReference(), Stage, ref pTotalStructureSizeInBytes.GetPinnableReference(), ref pParameterCount.GetPinnableReference(), ref pParameterDescs.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<TI0>(this ComPtr<ID3D12Device7> thisVtbl, Guid* CommandId, uint NodeMask, void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, out ComPtr<TI0> ppMetaCommand) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppMetaCommand = default;
        return @this->CreateMetaCommand(CommandId, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppMetaCommand.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand(this ComPtr<ID3D12Device7> thisVtbl, Guid* CommandId, uint NodeMask, void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, Span<Guid> riid, void** ppMetaCommand)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMetaCommand(CommandId, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, ref riid.GetPinnableReference(), ppMetaCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand(this ComPtr<ID3D12Device7> thisVtbl, Guid* CommandId, uint NodeMask, void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, Span<Guid> riid, ref void* ppMetaCommand)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMetaCommand(CommandId, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, ref riid.GetPinnableReference(), ref ppMetaCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<T0>(this ComPtr<ID3D12Device7> thisVtbl, Guid* CommandId, uint NodeMask, Span<T0> pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, void** ppMetaCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMetaCommand(CommandId, NodeMask, ref pCreationParametersData.GetPinnableReference(), CreationParametersDataSizeInBytes, riid, ppMetaCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<T0, TI0>(this ComPtr<ID3D12Device7> thisVtbl, Guid* CommandId, uint NodeMask, ref T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, out ComPtr<TI0> ppMetaCommand) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppMetaCommand = default;
        return @this->CreateMetaCommand(CommandId, NodeMask, ref pCreationParametersData, CreationParametersDataSizeInBytes, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppMetaCommand.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<T0>(this ComPtr<ID3D12Device7> thisVtbl, Guid* CommandId, uint NodeMask, Span<T0> pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, ref void* ppMetaCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMetaCommand(CommandId, NodeMask, ref pCreationParametersData.GetPinnableReference(), CreationParametersDataSizeInBytes, riid, ref ppMetaCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<T0>(this ComPtr<ID3D12Device7> thisVtbl, Guid* CommandId, uint NodeMask, Span<T0> pCreationParametersData, nuint CreationParametersDataSizeInBytes, Span<Guid> riid, void** ppMetaCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMetaCommand(CommandId, NodeMask, ref pCreationParametersData.GetPinnableReference(), CreationParametersDataSizeInBytes, ref riid.GetPinnableReference(), ppMetaCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<T0>(this ComPtr<ID3D12Device7> thisVtbl, Guid* CommandId, uint NodeMask, Span<T0> pCreationParametersData, nuint CreationParametersDataSizeInBytes, Span<Guid> riid, ref void* ppMetaCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMetaCommand(CommandId, NodeMask, ref pCreationParametersData.GetPinnableReference(), CreationParametersDataSizeInBytes, ref riid.GetPinnableReference(), ref ppMetaCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand(this ComPtr<ID3D12Device7> thisVtbl, Span<Guid> CommandId, uint NodeMask, void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, void** ppMetaCommand)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMetaCommand(ref CommandId.GetPinnableReference(), NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riid, ppMetaCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref Guid CommandId, uint NodeMask, void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, out ComPtr<TI0> ppMetaCommand) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppMetaCommand = default;
        return @this->CreateMetaCommand(ref CommandId, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppMetaCommand.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand(this ComPtr<ID3D12Device7> thisVtbl, Span<Guid> CommandId, uint NodeMask, void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, ref void* ppMetaCommand)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMetaCommand(ref CommandId.GetPinnableReference(), NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riid, ref ppMetaCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand(this ComPtr<ID3D12Device7> thisVtbl, Span<Guid> CommandId, uint NodeMask, void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, Span<Guid> riid, void** ppMetaCommand)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMetaCommand(ref CommandId.GetPinnableReference(), NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, ref riid.GetPinnableReference(), ppMetaCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand(this ComPtr<ID3D12Device7> thisVtbl, Span<Guid> CommandId, uint NodeMask, void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, Span<Guid> riid, ref void* ppMetaCommand)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMetaCommand(ref CommandId.GetPinnableReference(), NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, ref riid.GetPinnableReference(), ref ppMetaCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<T0>(this ComPtr<ID3D12Device7> thisVtbl, Span<Guid> CommandId, uint NodeMask, Span<T0> pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, void** ppMetaCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMetaCommand(ref CommandId.GetPinnableReference(), NodeMask, ref pCreationParametersData.GetPinnableReference(), CreationParametersDataSizeInBytes, riid, ppMetaCommand);
    }

    /// <summary>To be documented.</summary>
    public static int CreateMetaCommand<T0, TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref Guid CommandId, uint NodeMask, ref T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, out ComPtr<TI0> ppMetaCommand) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppMetaCommand = default;
        return @this->CreateMetaCommand(ref CommandId, NodeMask, ref pCreationParametersData, CreationParametersDataSizeInBytes, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppMetaCommand.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<T0>(this ComPtr<ID3D12Device7> thisVtbl, Span<Guid> CommandId, uint NodeMask, Span<T0> pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, ref void* ppMetaCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMetaCommand(ref CommandId.GetPinnableReference(), NodeMask, ref pCreationParametersData.GetPinnableReference(), CreationParametersDataSizeInBytes, riid, ref ppMetaCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<T0>(this ComPtr<ID3D12Device7> thisVtbl, Span<Guid> CommandId, uint NodeMask, Span<T0> pCreationParametersData, nuint CreationParametersDataSizeInBytes, Span<Guid> riid, void** ppMetaCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMetaCommand(ref CommandId.GetPinnableReference(), NodeMask, ref pCreationParametersData.GetPinnableReference(), CreationParametersDataSizeInBytes, ref riid.GetPinnableReference(), ppMetaCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<T0>(this ComPtr<ID3D12Device7> thisVtbl, Span<Guid> CommandId, uint NodeMask, Span<T0> pCreationParametersData, nuint CreationParametersDataSizeInBytes, Span<Guid> riid, ref void* ppMetaCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMetaCommand(ref CommandId.GetPinnableReference(), NodeMask, ref pCreationParametersData.GetPinnableReference(), CreationParametersDataSizeInBytes, ref riid.GetPinnableReference(), ref ppMetaCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObject<TI0>(this ComPtr<ID3D12Device7> thisVtbl, StateObjectDesc* pDesc, out ComPtr<TI0> ppStateObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppStateObject = default;
        return @this->CreateStateObject(pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppStateObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObject(this ComPtr<ID3D12Device7> thisVtbl, StateObjectDesc* pDesc, Span<Guid> riid, void** ppStateObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStateObject(pDesc, ref riid.GetPinnableReference(), ppStateObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObject(this ComPtr<ID3D12Device7> thisVtbl, StateObjectDesc* pDesc, Span<Guid> riid, ref void* ppStateObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStateObject(pDesc, ref riid.GetPinnableReference(), ref ppStateObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObject(this ComPtr<ID3D12Device7> thisVtbl, Span<StateObjectDesc> pDesc, Guid* riid, void** ppStateObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStateObject(ref pDesc.GetPinnableReference(), riid, ppStateObject);
    }

    /// <summary>To be documented.</summary>
    public static int CreateStateObject<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref StateObjectDesc pDesc, out ComPtr<TI0> ppStateObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppStateObject = default;
        return @this->CreateStateObject(ref pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppStateObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObject(this ComPtr<ID3D12Device7> thisVtbl, Span<StateObjectDesc> pDesc, Guid* riid, ref void* ppStateObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStateObject(ref pDesc.GetPinnableReference(), riid, ref ppStateObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObject(this ComPtr<ID3D12Device7> thisVtbl, Span<StateObjectDesc> pDesc, Span<Guid> riid, void** ppStateObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStateObject(ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppStateObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObject(this ComPtr<ID3D12Device7> thisVtbl, Span<StateObjectDesc> pDesc, Span<Guid> riid, ref void* ppStateObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStateObject(ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppStateObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetRaytracingAccelerationStructurePrebuildInfo(this ComPtr<ID3D12Device7> thisVtbl, BuildRaytracingAccelerationStructureInputs* pDesc, Span<RaytracingAccelerationStructurePrebuildInfo> pInfo)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetRaytracingAccelerationStructurePrebuildInfo(pDesc, ref pInfo.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetRaytracingAccelerationStructurePrebuildInfo(this ComPtr<ID3D12Device7> thisVtbl, Span<BuildRaytracingAccelerationStructureInputs> pDesc, RaytracingAccelerationStructurePrebuildInfo* pInfo)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetRaytracingAccelerationStructurePrebuildInfo(ref pDesc.GetPinnableReference(), pInfo);
    }

    /// <summary>To be documented.</summary>
    public static void GetRaytracingAccelerationStructurePrebuildInfo(this ComPtr<ID3D12Device7> thisVtbl, Span<BuildRaytracingAccelerationStructureInputs> pDesc, Span<RaytracingAccelerationStructurePrebuildInfo> pInfo)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetRaytracingAccelerationStructurePrebuildInfo(ref pDesc.GetPinnableReference(), ref pInfo.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static DriverMatchingIdentifierStatus CheckDriverMatchingIdentifier(this ComPtr<ID3D12Device7> thisVtbl, SerializedDataType SerializedDataType, Span<SerializedDataDriverMatchingIdentifier> pIdentifierToCheck)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckDriverMatchingIdentifier(SerializedDataType, ref pIdentifierToCheck.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetBackgroundProcessingMode(this ComPtr<ID3D12Device7> thisVtbl, BackgroundProcessingMode Mode, MeasurementsAction MeasurementsAction, void* hEventToSignalUponCompletion, Span<int> pbFurtherMeasurementsDesired)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetBackgroundProcessingMode(Mode, MeasurementsAction, hEventToSignalUponCompletion, ref pbFurtherMeasurementsDesired.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetBackgroundProcessingMode<T0>(this ComPtr<ID3D12Device7> thisVtbl, BackgroundProcessingMode Mode, MeasurementsAction MeasurementsAction, Span<T0> hEventToSignalUponCompletion, int* pbFurtherMeasurementsDesired) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetBackgroundProcessingMode(Mode, MeasurementsAction, ref hEventToSignalUponCompletion.GetPinnableReference(), pbFurtherMeasurementsDesired);
    }

    /// <summary>To be documented.</summary>
    public static int SetBackgroundProcessingMode<T0>(this ComPtr<ID3D12Device7> thisVtbl, BackgroundProcessingMode Mode, MeasurementsAction MeasurementsAction, Span<T0> hEventToSignalUponCompletion, Span<int> pbFurtherMeasurementsDesired) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetBackgroundProcessingMode(Mode, MeasurementsAction, ref hEventToSignalUponCompletion.GetPinnableReference(), ref pbFurtherMeasurementsDesired.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject<TI0>(this ComPtr<ID3D12Device7> thisVtbl, StateObjectDesc* pAddition, ID3D12StateObject* pStateObjectToGrowFrom, out ComPtr<TI0> ppNewStateObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppNewStateObject = default;
        return @this->AddToStateObject(pAddition, pStateObjectToGrowFrom, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppNewStateObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject(this ComPtr<ID3D12Device7> thisVtbl, StateObjectDesc* pAddition, ID3D12StateObject* pStateObjectToGrowFrom, Span<Guid> riid, void** ppNewStateObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddToStateObject(pAddition, pStateObjectToGrowFrom, ref riid.GetPinnableReference(), ppNewStateObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject(this ComPtr<ID3D12Device7> thisVtbl, StateObjectDesc* pAddition, ID3D12StateObject* pStateObjectToGrowFrom, Span<Guid> riid, ref void* ppNewStateObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddToStateObject(pAddition, pStateObjectToGrowFrom, ref riid.GetPinnableReference(), ref ppNewStateObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject(this ComPtr<ID3D12Device7> thisVtbl, StateObjectDesc* pAddition, Span<ID3D12StateObject> pStateObjectToGrowFrom, Guid* riid, void** ppNewStateObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddToStateObject(pAddition, ref pStateObjectToGrowFrom.GetPinnableReference(), riid, ppNewStateObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject<TI0>(this ComPtr<ID3D12Device7> thisVtbl, StateObjectDesc* pAddition, ref ID3D12StateObject pStateObjectToGrowFrom, out ComPtr<TI0> ppNewStateObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppNewStateObject = default;
        return @this->AddToStateObject(pAddition, ref pStateObjectToGrowFrom, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppNewStateObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject(this ComPtr<ID3D12Device7> thisVtbl, StateObjectDesc* pAddition, Span<ID3D12StateObject> pStateObjectToGrowFrom, Guid* riid, ref void* ppNewStateObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddToStateObject(pAddition, ref pStateObjectToGrowFrom.GetPinnableReference(), riid, ref ppNewStateObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject(this ComPtr<ID3D12Device7> thisVtbl, StateObjectDesc* pAddition, Span<ID3D12StateObject> pStateObjectToGrowFrom, Span<Guid> riid, void** ppNewStateObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddToStateObject(pAddition, ref pStateObjectToGrowFrom.GetPinnableReference(), ref riid.GetPinnableReference(), ppNewStateObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject(this ComPtr<ID3D12Device7> thisVtbl, StateObjectDesc* pAddition, Span<ID3D12StateObject> pStateObjectToGrowFrom, Span<Guid> riid, ref void* ppNewStateObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddToStateObject(pAddition, ref pStateObjectToGrowFrom.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppNewStateObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject(this ComPtr<ID3D12Device7> thisVtbl, Span<StateObjectDesc> pAddition, ID3D12StateObject* pStateObjectToGrowFrom, Guid* riid, void** ppNewStateObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddToStateObject(ref pAddition.GetPinnableReference(), pStateObjectToGrowFrom, riid, ppNewStateObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref StateObjectDesc pAddition, ID3D12StateObject* pStateObjectToGrowFrom, out ComPtr<TI0> ppNewStateObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppNewStateObject = default;
        return @this->AddToStateObject(ref pAddition, pStateObjectToGrowFrom, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppNewStateObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject(this ComPtr<ID3D12Device7> thisVtbl, Span<StateObjectDesc> pAddition, ID3D12StateObject* pStateObjectToGrowFrom, Guid* riid, ref void* ppNewStateObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddToStateObject(ref pAddition.GetPinnableReference(), pStateObjectToGrowFrom, riid, ref ppNewStateObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject(this ComPtr<ID3D12Device7> thisVtbl, Span<StateObjectDesc> pAddition, ID3D12StateObject* pStateObjectToGrowFrom, Span<Guid> riid, void** ppNewStateObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddToStateObject(ref pAddition.GetPinnableReference(), pStateObjectToGrowFrom, ref riid.GetPinnableReference(), ppNewStateObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject(this ComPtr<ID3D12Device7> thisVtbl, Span<StateObjectDesc> pAddition, ID3D12StateObject* pStateObjectToGrowFrom, Span<Guid> riid, ref void* ppNewStateObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddToStateObject(ref pAddition.GetPinnableReference(), pStateObjectToGrowFrom, ref riid.GetPinnableReference(), ref ppNewStateObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject(this ComPtr<ID3D12Device7> thisVtbl, Span<StateObjectDesc> pAddition, Span<ID3D12StateObject> pStateObjectToGrowFrom, Guid* riid, void** ppNewStateObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddToStateObject(ref pAddition.GetPinnableReference(), ref pStateObjectToGrowFrom.GetPinnableReference(), riid, ppNewStateObject);
    }

    /// <summary>To be documented.</summary>
    public static int AddToStateObject<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref StateObjectDesc pAddition, ref ID3D12StateObject pStateObjectToGrowFrom, out ComPtr<TI0> ppNewStateObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppNewStateObject = default;
        return @this->AddToStateObject(ref pAddition, ref pStateObjectToGrowFrom, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppNewStateObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject(this ComPtr<ID3D12Device7> thisVtbl, Span<StateObjectDesc> pAddition, Span<ID3D12StateObject> pStateObjectToGrowFrom, Guid* riid, ref void* ppNewStateObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddToStateObject(ref pAddition.GetPinnableReference(), ref pStateObjectToGrowFrom.GetPinnableReference(), riid, ref ppNewStateObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject(this ComPtr<ID3D12Device7> thisVtbl, Span<StateObjectDesc> pAddition, Span<ID3D12StateObject> pStateObjectToGrowFrom, Span<Guid> riid, void** ppNewStateObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddToStateObject(ref pAddition.GetPinnableReference(), ref pStateObjectToGrowFrom.GetPinnableReference(), ref riid.GetPinnableReference(), ppNewStateObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject(this ComPtr<ID3D12Device7> thisVtbl, Span<StateObjectDesc> pAddition, Span<ID3D12StateObject> pStateObjectToGrowFrom, Span<Guid> riid, ref void* ppNewStateObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddToStateObject(ref pAddition.GetPinnableReference(), ref pStateObjectToGrowFrom.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppNewStateObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ProtectedResourceSessionDesc1* pDesc, out ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppSession = default;
        return @this->CreateProtectedResourceSession1(pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession1(this ComPtr<ID3D12Device7> thisVtbl, ProtectedResourceSessionDesc1* pDesc, Span<Guid> riid, void** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateProtectedResourceSession1(pDesc, ref riid.GetPinnableReference(), ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession1(this ComPtr<ID3D12Device7> thisVtbl, ProtectedResourceSessionDesc1* pDesc, Span<Guid> riid, ref void* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateProtectedResourceSession1(pDesc, ref riid.GetPinnableReference(), ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession1(this ComPtr<ID3D12Device7> thisVtbl, Span<ProtectedResourceSessionDesc1> pDesc, Guid* riid, void** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateProtectedResourceSession1(ref pDesc.GetPinnableReference(), riid, ppSession);
    }

    /// <summary>To be documented.</summary>
    public static int CreateProtectedResourceSession1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref ProtectedResourceSessionDesc1 pDesc, out ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppSession = default;
        return @this->CreateProtectedResourceSession1(ref pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession1(this ComPtr<ID3D12Device7> thisVtbl, Span<ProtectedResourceSessionDesc1> pDesc, Guid* riid, ref void* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateProtectedResourceSession1(ref pDesc.GetPinnableReference(), riid, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession1(this ComPtr<ID3D12Device7> thisVtbl, Span<ProtectedResourceSessionDesc1> pDesc, Span<Guid> riid, void** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateProtectedResourceSession1(ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession1(this ComPtr<ID3D12Device7> thisVtbl, Span<ProtectedResourceSessionDesc1> pDesc, Span<Guid> riid, ref void* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateProtectedResourceSession1(ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D12Device7> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommandQueue<TI0>(this ComPtr<ID3D12Device7> thisVtbl, CommandQueueDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommandQueue(pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateCommandQueue<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref CommandQueueDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommandQueue(ref pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateCommandAllocator<TI0>(this ComPtr<ID3D12Device7> thisVtbl, CommandListType type) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommandAllocator(type, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateGraphicsPipelineState<TI0>(this ComPtr<ID3D12Device7> thisVtbl, GraphicsPipelineStateDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateGraphicsPipelineState(pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateGraphicsPipelineState<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref GraphicsPipelineStateDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateGraphicsPipelineState(ref pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateComputePipelineState<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ComputePipelineStateDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateComputePipelineState(pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateComputePipelineState<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref ComputePipelineStateDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateComputePipelineState(ref pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommandList<TI0>(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommandList(nodeMask, type, pCommandAllocator, pInitialState, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommandList<TI0>(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ref ID3D12PipelineState pInitialState) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommandList(nodeMask, type, pCommandAllocator, ref pInitialState, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommandList<TI0>(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState* pInitialState) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommandList(nodeMask, type, ref pCommandAllocator, pInitialState, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateCommandList<TI0>(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ref ID3D12PipelineState pInitialState) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommandList(nodeMask, type, ref pCommandAllocator, ref pInitialState, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateDescriptorHeap<TI0>(this ComPtr<ID3D12Device7> thisVtbl, DescriptorHeapDesc* pDescriptorHeapDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateDescriptorHeap(pDescriptorHeapDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateDescriptorHeap<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref DescriptorHeapDesc pDescriptorHeapDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateDescriptorHeap(ref pDescriptorHeapDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateRootSignature<TI0>(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, void* pBlobWithRootSignature, nuint blobLengthInBytes) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateRootSignature(nodeMask, pBlobWithRootSignature, blobLengthInBytes, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateRootSignature<T0, TI0>(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, ref T0 pBlobWithRootSignature, nuint blobLengthInBytes) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateRootSignature(nodeMask, ref pBlobWithRootSignature, blobLengthInBytes, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommittedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommittedResource(pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommittedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommittedResource(pHeapProperties, HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommittedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommittedResource(pHeapProperties, HeapFlags, ref pDesc, InitialResourceState, pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommittedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommittedResource(pHeapProperties, HeapFlags, ref pDesc, InitialResourceState, ref pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommittedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommittedResource(ref pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommittedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommittedResource(ref pHeapProperties, HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommittedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommittedResource(ref pHeapProperties, HeapFlags, ref pDesc, InitialResourceState, pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateCommittedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommittedResource(ref pHeapProperties, HeapFlags, ref pDesc, InitialResourceState, ref pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateHeap<TI0>(this ComPtr<ID3D12Device7> thisVtbl, HeapDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateHeap(pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateHeap<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref HeapDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateHeap(ref pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreatePlacedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreatePlacedResource(pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreatePlacedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreatePlacedResource(pHeap, HeapOffset, pDesc, InitialState, ref pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreatePlacedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreatePlacedResource(pHeap, HeapOffset, ref pDesc, InitialState, pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreatePlacedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreatePlacedResource(pHeap, HeapOffset, ref pDesc, InitialState, ref pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreatePlacedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreatePlacedResource(ref pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreatePlacedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreatePlacedResource(ref pHeap, HeapOffset, pDesc, InitialState, ref pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreatePlacedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreatePlacedResource(ref pHeap, HeapOffset, ref pDesc, InitialState, pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreatePlacedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreatePlacedResource(ref pHeap, HeapOffset, ref pDesc, InitialState, ref pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateReservedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateReservedResource(pDesc, InitialState, pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateReservedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateReservedResource(pDesc, InitialState, ref pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateReservedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateReservedResource(ref pDesc, InitialState, pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateReservedResource<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateReservedResource(ref pDesc, InitialState, ref pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> OpenSharedHandle<TI0>(this ComPtr<ID3D12Device7> thisVtbl, void* NTHandle) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->OpenSharedHandle(NTHandle, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> OpenSharedHandle<T0, TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref T0 NTHandle) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->OpenSharedHandle(ref NTHandle, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateFence<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ulong InitialValue, FenceFlags Flags) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateFence(InitialValue, Flags, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateQueryHeap<TI0>(this ComPtr<ID3D12Device7> thisVtbl, QueryHeapDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateQueryHeap(pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateQueryHeap<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref QueryHeapDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateQueryHeap(ref pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommandSignature<TI0>(this ComPtr<ID3D12Device7> thisVtbl, CommandSignatureDesc* pDesc, ID3D12RootSignature* pRootSignature) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommandSignature(pDesc, pRootSignature, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommandSignature<TI0>(this ComPtr<ID3D12Device7> thisVtbl, CommandSignatureDesc* pDesc, ref ID3D12RootSignature pRootSignature) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommandSignature(pDesc, ref pRootSignature, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommandSignature<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref CommandSignatureDesc pDesc, ID3D12RootSignature* pRootSignature) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommandSignature(ref pDesc, pRootSignature, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateCommandSignature<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref CommandSignatureDesc pDesc, ref ID3D12RootSignature pRootSignature) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommandSignature(ref pDesc, ref pRootSignature, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreatePipelineLibrary<TI0>(this ComPtr<ID3D12Device7> thisVtbl, void* pLibraryBlob, nuint BlobLength) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreatePipelineLibrary(pLibraryBlob, BlobLength, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreatePipelineLibrary<T0, TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref T0 pLibraryBlob, nuint BlobLength) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreatePipelineLibrary(ref pLibraryBlob, BlobLength, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreatePipelineState<TI0>(this ComPtr<ID3D12Device7> thisVtbl, PipelineStateStreamDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreatePipelineState(pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreatePipelineState<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref PipelineStateStreamDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreatePipelineState(ref pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> OpenExistingHeapFromAddress<TI0>(this ComPtr<ID3D12Device7> thisVtbl, void* pAddress) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->OpenExistingHeapFromAddress(pAddress, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> OpenExistingHeapFromAddress<T0, TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref T0 pAddress) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->OpenExistingHeapFromAddress(ref pAddress, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> OpenExistingHeapFromFileMapping<TI0>(this ComPtr<ID3D12Device7> thisVtbl, void* hFileMapping) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->OpenExistingHeapFromFileMapping(hFileMapping, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> OpenExistingHeapFromFileMapping<T0, TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref T0 hFileMapping) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->OpenExistingHeapFromFileMapping(ref hFileMapping, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateCommandList1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, uint nodeMask, CommandListType type, CommandListFlags flags) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommandList1(nodeMask, type, flags, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateProtectedResourceSession<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ProtectedResourceSessionDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateProtectedResourceSession(pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateProtectedResourceSession<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref ProtectedResourceSessionDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateProtectedResourceSession(ref pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommittedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommittedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, ref pProtectedSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommittedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue, pProtectedSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommittedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue, ref pProtectedSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommittedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommittedResource1(pHeapProperties, HeapFlags, ref pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommittedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommittedResource1(pHeapProperties, HeapFlags, ref pDesc, InitialResourceState, pOptimizedClearValue, ref pProtectedSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommittedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommittedResource1(pHeapProperties, HeapFlags, ref pDesc, InitialResourceState, ref pOptimizedClearValue, pProtectedSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommittedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommittedResource1(pHeapProperties, HeapFlags, ref pDesc, InitialResourceState, ref pOptimizedClearValue, ref pProtectedSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommittedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommittedResource1(ref pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommittedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommittedResource1(ref pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, ref pProtectedSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommittedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommittedResource1(ref pHeapProperties, HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue, pProtectedSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommittedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommittedResource1(ref pHeapProperties, HeapFlags, pDesc, InitialResourceState, ref pOptimizedClearValue, ref pProtectedSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommittedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommittedResource1(ref pHeapProperties, HeapFlags, ref pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommittedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommittedResource1(ref pHeapProperties, HeapFlags, ref pDesc, InitialResourceState, pOptimizedClearValue, ref pProtectedSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommittedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommittedResource1(ref pHeapProperties, HeapFlags, ref pDesc, InitialResourceState, ref pOptimizedClearValue, pProtectedSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateCommittedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommittedResource1(ref pHeapProperties, HeapFlags, ref pDesc, InitialResourceState, ref pOptimizedClearValue, ref pProtectedSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateHeap1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, HeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateHeap1(pDesc, pProtectedSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateHeap1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, HeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateHeap1(pDesc, ref pProtectedSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateHeap1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref HeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateHeap1(ref pDesc, pProtectedSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateHeap1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref HeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateHeap1(ref pDesc, ref pProtectedSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateReservedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateReservedResource1(pDesc, InitialState, pOptimizedClearValue, pProtectedSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateReservedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateReservedResource1(pDesc, InitialState, pOptimizedClearValue, ref pProtectedSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateReservedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateReservedResource1(pDesc, InitialState, ref pOptimizedClearValue, pProtectedSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateReservedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateReservedResource1(pDesc, InitialState, ref pOptimizedClearValue, ref pProtectedSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateReservedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateReservedResource1(ref pDesc, InitialState, pOptimizedClearValue, pProtectedSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateReservedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateReservedResource1(ref pDesc, InitialState, pOptimizedClearValue, ref pProtectedSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateReservedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateReservedResource1(ref pDesc, InitialState, ref pOptimizedClearValue, pProtectedSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateReservedResource1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateReservedResource1(ref pDesc, InitialState, ref pOptimizedClearValue, ref pProtectedSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateLifetimeTracker<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ID3D12LifetimeOwner* pOwner) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateLifetimeTracker(pOwner, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateLifetimeTracker<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref ID3D12LifetimeOwner pOwner) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateLifetimeTracker(ref pOwner, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateMetaCommand<TI0>(this ComPtr<ID3D12Device7> thisVtbl, Guid* CommandId, uint NodeMask, void* pCreationParametersData, nuint CreationParametersDataSizeInBytes) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateMetaCommand(CommandId, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateMetaCommand<T0, TI0>(this ComPtr<ID3D12Device7> thisVtbl, Guid* CommandId, uint NodeMask, ref T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateMetaCommand(CommandId, NodeMask, ref pCreationParametersData, CreationParametersDataSizeInBytes, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateMetaCommand<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref Guid CommandId, uint NodeMask, void* pCreationParametersData, nuint CreationParametersDataSizeInBytes) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateMetaCommand(ref CommandId, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateMetaCommand<T0, TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref Guid CommandId, uint NodeMask, ref T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateMetaCommand(ref CommandId, NodeMask, ref pCreationParametersData, CreationParametersDataSizeInBytes, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateStateObject<TI0>(this ComPtr<ID3D12Device7> thisVtbl, StateObjectDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateStateObject(pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateStateObject<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref StateObjectDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateStateObject(ref pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> AddToStateObject<TI0>(this ComPtr<ID3D12Device7> thisVtbl, StateObjectDesc* pAddition, ID3D12StateObject* pStateObjectToGrowFrom) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->AddToStateObject(pAddition, pStateObjectToGrowFrom, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> AddToStateObject<TI0>(this ComPtr<ID3D12Device7> thisVtbl, StateObjectDesc* pAddition, ref ID3D12StateObject pStateObjectToGrowFrom) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->AddToStateObject(pAddition, ref pStateObjectToGrowFrom, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> AddToStateObject<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref StateObjectDesc pAddition, ID3D12StateObject* pStateObjectToGrowFrom) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->AddToStateObject(ref pAddition, pStateObjectToGrowFrom, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> AddToStateObject<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref StateObjectDesc pAddition, ref ID3D12StateObject pStateObjectToGrowFrom) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->AddToStateObject(ref pAddition, ref pStateObjectToGrowFrom, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateProtectedResourceSession1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ProtectedResourceSessionDesc1* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateProtectedResourceSession1(pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateProtectedResourceSession1<TI0>(this ComPtr<ID3D12Device7> thisVtbl, ref ProtectedResourceSessionDesc1 pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateProtectedResourceSession1(ref pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
