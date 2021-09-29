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

[Guid("51218251-1e33-4617-9ccb-4d3a4367e7bb")]
[NativeName("Name", "ID3D11Texture2D1")]
public unsafe partial struct ID3D11Texture2D1
{
    public static readonly Guid Guid = new("51218251-1e33-4617-9ccb-4d3a4367e7bb");

    public static implicit operator ID3D11Texture2D(ID3D11Texture2D1 val)
        => Unsafe.As<ID3D11Texture2D1, ID3D11Texture2D>(ref val);

    public static implicit operator ID3D11Resource(ID3D11Texture2D1 val)
        => Unsafe.As<ID3D11Texture2D1, ID3D11Resource>(ref val);

    public static implicit operator ID3D11DeviceChild(ID3D11Texture2D1 val)
        => Unsafe.As<ID3D11Texture2D1, ID3D11DeviceChild>(ref val);

    public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11Texture2D1 val)
        => Unsafe.As<ID3D11Texture2D1, Silk.NET.Core.Native.IUnknown>(ref val);

    public ID3D11Texture2D1
    (
            void** lpVtbl = null
    ) : this()
    {
        if (lpVtbl is not null)
        {
            LpVtbl = lpVtbl;
        }
    }


    [NativeName("Type", "")]
    [NativeName("Type.Name", "")]
    [NativeName("Name", "lpVtbl")]
    public void** LpVtbl;
    /// <summary>To be documented.</summary>
    public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
    {
        var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ID3D11Texture2D1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
    {
        var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<ID3D11Texture2D1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
    {
        var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ID3D11Texture2D1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
    {
        var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Texture2D1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public readonly uint AddRef()
    {
        var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, uint>)LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public readonly uint Release()
    {
        var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, uint>)LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public readonly unsafe void GetDevice(ID3D11Device** ppDevice)
    {
        var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
        ((delegate* unmanaged[Cdecl]<ID3D11Texture2D1*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevice);
    }

    /// <summary>To be documented.</summary>
    public readonly unsafe void GetDevice(ref ID3D11Device* ppDevice)
    {
        var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
        fixed (ID3D11Device** ppDevicePtr = &ppDevice)
        {
            ((delegate* unmanaged[Cdecl]<ID3D11Texture2D1*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevicePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
    {
        var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ID3D11Texture2D1*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public readonly unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
        int ret = default;
        fixed (T0* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Cdecl]<ID3D11Texture2D1*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guid, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public readonly unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
    {
        var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Cdecl]<ID3D11Texture2D1*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public readonly unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Texture2D1*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public readonly unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
    {
        var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ID3D11Texture2D1*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public readonly unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Texture2D1*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public readonly unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
    {
        var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Texture2D1*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public readonly int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Texture2D1*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, void* pData)
    {
        var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ID3D11Texture2D1*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public readonly unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
        int ret = default;
        fixed (T0* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Cdecl]<ID3D11Texture2D1*, Guid*, uint, T0*, int>)LpVtbl[5])(@this, guid, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public readonly unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
    {
        var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ID3D11Texture2D1*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public readonly int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Texture2D1*, Guid*, uint, T0*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ID3D11Texture2D1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
    {
        var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Cdecl]<ID3D11Texture2D1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public readonly unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ID3D11Texture2D1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public readonly int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
    {
        var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Texture2D1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public readonly unsafe void GetType(ResourceDimension* pResourceDimension)
    {
        var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
        ((delegate* unmanaged[Cdecl]<ID3D11Texture2D1*, ResourceDimension*, void>)LpVtbl[7])(@this, pResourceDimension);
    }

    /// <summary>To be documented.</summary>
    public readonly void GetType(ref ResourceDimension pResourceDimension)
    {
        var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
        fixed (ResourceDimension* pResourceDimensionPtr = &pResourceDimension)
        {
            ((delegate* unmanaged[Cdecl]<ID3D11Texture2D1*, ResourceDimension*, void>)LpVtbl[7])(@this, pResourceDimensionPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public readonly void SetEvictionPriority(uint EvictionPriority)
    {
        var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
        ((delegate* unmanaged[Cdecl]<ID3D11Texture2D1*, uint, void>)LpVtbl[8])(@this, EvictionPriority);
    }

    /// <summary>To be documented.</summary>
    public readonly uint GetEvictionPriority()
    {
        var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, uint>)LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public readonly unsafe void GetDesc(Texture2DDesc* pDesc)
    {
        var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
        ((delegate* unmanaged[Cdecl]<ID3D11Texture2D1*, Texture2DDesc*, void>)LpVtbl[10])(@this, pDesc);
    }

    /// <summary>To be documented.</summary>
    public readonly void GetDesc(ref Texture2DDesc pDesc)
    {
        var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
        fixed (Texture2DDesc* pDescPtr = &pDesc)
        {
            ((delegate* unmanaged[Cdecl]<ID3D11Texture2D1*, Texture2DDesc*, void>)LpVtbl[10])(@this, pDescPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public readonly unsafe void GetDesc1(Texture2DDesc1* pDesc)
    {
        var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
        ((delegate* unmanaged[Cdecl]<ID3D11Texture2D1*, Texture2DDesc1*, void>)LpVtbl[11])(@this, pDesc);
    }

    /// <summary>To be documented.</summary>
    public readonly void GetDesc1(ref Texture2DDesc1 pDesc)
    {
        var @this = (ID3D11Texture2D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
        fixed (Texture2DDesc1* pDescPtr = &pDesc)
        {
            ((delegate* unmanaged[Cdecl]<ID3D11Texture2D1*, Texture2DDesc1*, void>)LpVtbl[11])(@this, pDescPtr);
        }
    }

}
