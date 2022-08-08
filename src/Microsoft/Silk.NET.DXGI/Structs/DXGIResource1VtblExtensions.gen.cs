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

namespace Silk.NET.DXGI;

public unsafe static class DXGIResource1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknownPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknown);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknownPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, ref uint pDataSize, void* pData) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, ref uint pDataSize, void* pData) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Guid* riid, void** ppParent) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppParent) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppParentPtr = &ppParent)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParentPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, ref Guid riid, void** ppParent) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParent);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppParent) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppParentPtr = &ppParent)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParentPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Guid* riid, void** ppDevice) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppDevice) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppDevicePtr = &ppDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, ref Guid riid, void** ppDevice) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppDevice) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppDevicePtr = &ppDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppDevicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSharedHandle<TThis>(this TThis thisVtbl, void** pSharedHandle) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, void**, int>)@this->LpVtbl[8])(@this, pSharedHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSharedHandle<TThis>(this TThis thisVtbl, ref void* pSharedHandle) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** pSharedHandlePtr = &pSharedHandle)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, void**, int>)@this->LpVtbl[8])(@this, pSharedHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUsage<TThis>(this TThis thisVtbl, uint* pUsage) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, uint*, int>)@this->LpVtbl[9])(@this, pUsage);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetUsage<TThis>(this TThis thisVtbl, ref uint pUsage) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pUsagePtr = &pUsage)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, uint*, int>)@this->LpVtbl[9])(@this, pUsagePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetEvictionPriority<TThis>(this TThis thisVtbl, uint EvictionPriority) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, uint, int>)@this->LpVtbl[10])(@this, EvictionPriority);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEvictionPriority<TThis>(this TThis thisVtbl, uint* pEvictionPriority) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, uint*, int>)@this->LpVtbl[11])(@this, pEvictionPriority);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetEvictionPriority<TThis>(this TThis thisVtbl, ref uint pEvictionPriority) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pEvictionPriorityPtr = &pEvictionPriority)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, uint*, int>)@this->LpVtbl[11])(@this, pEvictionPriorityPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSubresourceSurface<TThis>(this TThis thisVtbl, uint index, IDXGISurface2** ppSurface) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, uint, IDXGISurface2**, int>)@this->LpVtbl[12])(@this, index, ppSurface);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSubresourceSurface<TThis>(this TThis thisVtbl, uint index, ref IDXGISurface2* ppSurface) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGISurface2** ppSurfacePtr = &ppSurface)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, uint, IDXGISurface2**, int>)@this->LpVtbl[12])(@this, index, ppSurfacePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint dwAccess, char* lpName, void** pHandle) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[13])(@this, pAttributes, dwAccess, lpName, pHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint dwAccess, char* lpName, ref void* pHandle) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** pHandlePtr = &pHandle)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[13])(@this, pAttributes, dwAccess, lpName, pHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint dwAccess, ref char lpName, void** pHandle) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* lpNamePtr = &lpName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[13])(@this, pAttributes, dwAccess, lpNamePtr, pHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint dwAccess, ref char lpName, ref void* pHandle) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* lpNamePtr = &lpName)
        {
            fixed (void** pHandlePtr = &pHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[13])(@this, pAttributes, dwAccess, lpNamePtr, pHandlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint dwAccess, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpName, void** pHandle) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        var lpNamePtr = (byte*) SilkMarshal.StringToPtr(lpName, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[13])(@this, pAttributes, dwAccess, lpNamePtr, pHandle);
        SilkMarshal.Free((nint)lpNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint dwAccess, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpName, ref void* pHandle) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        var lpNamePtr = (byte*) SilkMarshal.StringToPtr(lpName, NativeStringEncoding.LPWStr);
        fixed (void** pHandlePtr = &pHandle)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[13])(@this, pAttributes, dwAccess, lpNamePtr, pHandlePtr);
        }
        SilkMarshal.Free((nint)lpNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint dwAccess, char* lpName, void** pHandle) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[13])(@this, pAttributesPtr, dwAccess, lpName, pHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint dwAccess, char* lpName, ref void* pHandle) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
        {
            fixed (void** pHandlePtr = &pHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[13])(@this, pAttributesPtr, dwAccess, lpName, pHandlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint dwAccess, ref char lpName, void** pHandle) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
        {
            fixed (char* lpNamePtr = &lpName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[13])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandle);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint dwAccess, ref char lpName, ref void* pHandle) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
        {
            fixed (char* lpNamePtr = &lpName)
            {
                fixed (void** pHandlePtr = &pHandle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[13])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandlePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint dwAccess, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpName, void** pHandle) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
        {
        var lpNamePtr = (byte*) SilkMarshal.StringToPtr(lpName, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[13])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandle);
        SilkMarshal.Free((nint)lpNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint dwAccess, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpName, ref void* pHandle) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
        {
        var lpNamePtr = (byte*) SilkMarshal.StringToPtr(lpName, NativeStringEncoding.LPWStr);
            fixed (void** pHandlePtr = &pHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[13])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandlePtr);
            }
        SilkMarshal.Free((nint)lpNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(Name, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref Name.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> Name, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref Name.GetPinnableReference(), DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pUnknown) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(Name, in pUnknown.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Span<Guid> Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref Name.GetPinnableReference(), pUnknown);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Span<Guid> Name, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pUnknown) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref Name.GetPinnableReference(), in pUnknown.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(Name, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, Span<uint> pDataSize, void* pData) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(Name, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(Name, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> Name, uint* pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> Name, Span<uint> pDataSize, void* pData) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> Name, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppParent) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetParent(ref riid.GetPinnableReference(), ppParent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppParent) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetParent(ref riid.GetPinnableReference(), ref ppParent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppDevice) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDevice(ref riid.GetPinnableReference(), ppDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppDevice) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDevice(ref riid.GetPinnableReference(), ref ppDevice);
    }

    /// <summary>To be documented.</summary>
    public static int GetUsage<TThis>(this TThis thisVtbl, Span<uint> pUsage) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetUsage(ref pUsage.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetEvictionPriority<TThis>(this TThis thisVtbl, Span<uint> pEvictionPriority) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetEvictionPriority(ref pEvictionPriority.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint dwAccess, Span<char> lpName, void** pHandle) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSharedHandle(pAttributes, dwAccess, ref lpName.GetPinnableReference(), pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint dwAccess, Span<char> lpName, ref void* pHandle) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSharedHandle(pAttributes, dwAccess, ref lpName.GetPinnableReference(), ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint dwAccess, char* lpName, void** pHandle) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSharedHandle(ref pAttributes.GetPinnableReference(), dwAccess, lpName, pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint dwAccess, char* lpName, ref void* pHandle) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSharedHandle(ref pAttributes.GetPinnableReference(), dwAccess, lpName, ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint dwAccess, Span<char> lpName, void** pHandle) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSharedHandle(ref pAttributes.GetPinnableReference(), dwAccess, ref lpName.GetPinnableReference(), pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint dwAccess, Span<char> lpName, ref void* pHandle) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSharedHandle(ref pAttributes.GetPinnableReference(), dwAccess, ref lpName.GetPinnableReference(), ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint dwAccess, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpName, void** pHandle) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSharedHandle(ref pAttributes.GetPinnableReference(), dwAccess, lpName, pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint dwAccess, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpName, ref void* pHandle) where TThis : IComVtbl<IDXGIResource1>
    {
        var @this = (IDXGIResource1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSharedHandle(ref pAttributes.GetPinnableReference(), dwAccess, lpName, ref pHandle);
    }

}
