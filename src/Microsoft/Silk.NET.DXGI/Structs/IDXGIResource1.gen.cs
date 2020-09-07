// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "IDXGIResource1")]
    public unsafe partial struct IDXGIResource1
    {
        public IDXGIResource1
        (
            void** lpVtbl = default
        )
        {
            LpVtbl = lpVtbl;
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIResource1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDXGIResource1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDXGIResource1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDXGIResource1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDXGIResource1* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDXGIResource1*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDXGIResource1* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDXGIResource1*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(Guid* Name, uint DataSize, void* pData)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIResource1*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData<T0>(Guid* Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<IDXGIResource1*, Guid*, uint, T0*, int>)LpVtbl[3])(@this, Name, DataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(ref Guid Name, uint DataSize, void* pData)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<IDXGIResource1*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateData<T0>(ref Guid Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<IDXGIResource1*, Guid*, uint, T0*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] Silk.NET.Core.Runtime.Windows.IUnknown* pUnknown)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIResource1*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknown);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Runtime.Windows.IUnknown pUnknown)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pUnknownPtr = &pUnknown)
                {
                    ret = ((delegate* cdecl<IDXGIResource1*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknownPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] Silk.NET.Core.Runtime.Windows.IUnknown* pUnknown)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<IDXGIResource1*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknown);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Runtime.Windows.IUnknown pUnknown)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pUnknownPtr = &pUnknown)
                    {
                        ret = ((delegate* cdecl<IDXGIResource1*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknownPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIResource1*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<IDXGIResource1*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* Name, ref uint pDataSize, void* pData)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* cdecl<IDXGIResource1*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<IDXGIResource1*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid Name, uint* pDataSize, void* pData)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<IDXGIResource1*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<IDXGIResource1*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid Name, ref uint pDataSize, void* pData)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        ret = ((delegate* cdecl<IDXGIResource1*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetPrivateData<T0>(ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        fixed (T0* pDataPtr = &pData)
                        {
                            ret = ((delegate* cdecl<IDXGIResource1*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(Guid* riid, void** ppParent)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIResource1*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParent);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(Guid* riid, ref void* ppParent)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (void** ppParentPtr = &ppParent)
                {
                    ret = ((delegate* cdecl<IDXGIResource1*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParentPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(ref Guid riid, void** ppParent)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDXGIResource1*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParent);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(ref Guid riid, ref void* ppParent)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppParentPtr = &ppParent)
                    {
                        ret = ((delegate* cdecl<IDXGIResource1*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParentPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(Guid* riid, void** ppDevice)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIResource1*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppDevice);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(Guid* riid, ref void* ppDevice)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (void** ppDevicePtr = &ppDevice)
                {
                    ret = ((delegate* cdecl<IDXGIResource1*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppDevicePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(ref Guid riid, void** ppDevice)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDXGIResource1*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppDevice);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(ref Guid riid, ref void* ppDevice)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppDevicePtr = &ppDevice)
                    {
                        ret = ((delegate* cdecl<IDXGIResource1*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppDevicePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetSharedHandle(void** pSharedHandle)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIResource1*, void**, int>)LpVtbl[8])(@this, pSharedHandle);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetSharedHandle(ref void* pSharedHandle)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
                    ret = ((delegate* cdecl<IDXGIResource1*, void**, int>)LpVtbl[8])(@this, pSharedHandlePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetUsage(uint* pUsage)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIResource1*, uint*, int>)LpVtbl[9])(@this, pUsage);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetUsage(ref uint pUsage)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (uint* pUsagePtr = &pUsage)
                {
                    ret = ((delegate* cdecl<IDXGIResource1*, uint*, int>)LpVtbl[9])(@this, pUsagePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetEvictionPriority(uint EvictionPriority)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIResource1*, uint, int>)LpVtbl[10])(@this, EvictionPriority);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetEvictionPriority(uint* pEvictionPriority)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIResource1*, uint*, int>)LpVtbl[11])(@this, pEvictionPriority);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetEvictionPriority(ref uint pEvictionPriority)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (uint* pEvictionPriorityPtr = &pEvictionPriority)
                {
                    ret = ((delegate* cdecl<IDXGIResource1*, uint*, int>)LpVtbl[11])(@this, pEvictionPriorityPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSubresourceSurface(uint index, IDXGISurface2** ppSurface)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIResource1*, uint, IDXGISurface2**, int>)LpVtbl[12])(@this, index, ppSurface);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSubresourceSurface(uint index, ref IDXGISurface2* ppSurface)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (IDXGISurface2** ppSurfacePtr = &ppSurface)
                {
                    ret = ((delegate* cdecl<IDXGIResource1*, uint, IDXGISurface2**, int>)LpVtbl[12])(@this, index, ppSurfacePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSharedHandle(Silk.NET.Core.Runtime.Windows.SecurityAttributes* pAttributes, uint dwAccess, char* lpName, void** pHandle)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIResource1*, Silk.NET.Core.Runtime.Windows.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[13])(@this, pAttributes, dwAccess, lpName, pHandle);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSharedHandle(Silk.NET.Core.Runtime.Windows.SecurityAttributes* pAttributes, uint dwAccess, char* lpName, ref void* pHandle)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (void** pHandlePtr = &pHandle)
                {
                    ret = ((delegate* cdecl<IDXGIResource1*, Silk.NET.Core.Runtime.Windows.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[13])(@this, pAttributes, dwAccess, lpName, pHandlePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSharedHandle(Silk.NET.Core.Runtime.Windows.SecurityAttributes* pAttributes, uint dwAccess, ref char lpName, void** pHandle)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (char* lpNamePtr = &lpName)
                {
                    ret = ((delegate* cdecl<IDXGIResource1*, Silk.NET.Core.Runtime.Windows.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[13])(@this, pAttributes, dwAccess, lpNamePtr, pHandle);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSharedHandle(Silk.NET.Core.Runtime.Windows.SecurityAttributes* pAttributes, uint dwAccess, ref char lpName, ref void* pHandle)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (char* lpNamePtr = &lpName)
                {
                    fixed (void** pHandlePtr = &pHandle)
                    {
                        ret = ((delegate* cdecl<IDXGIResource1*, Silk.NET.Core.Runtime.Windows.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[13])(@this, pAttributes, dwAccess, lpNamePtr, pHandlePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSharedHandle(Silk.NET.Core.Runtime.Windows.SecurityAttributes* pAttributes, uint dwAccess, string lpName, void** pHandle)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
            var lpNamePtr = (byte*) Marshal.StringToHGlobalAnsi(lpName);
                ret = ((delegate* cdecl<IDXGIResource1*, Silk.NET.Core.Runtime.Windows.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[13])(@this, pAttributes, dwAccess, lpNamePtr, pHandle);
            Marshal.FreeHGlobal((IntPtr)lpNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSharedHandle(Silk.NET.Core.Runtime.Windows.SecurityAttributes* pAttributes, uint dwAccess, string lpName, ref void* pHandle)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
            var lpNamePtr = (byte*) Marshal.StringToHGlobalAnsi(lpName);
                fixed (void** pHandlePtr = &pHandle)
                {
                    ret = ((delegate* cdecl<IDXGIResource1*, Silk.NET.Core.Runtime.Windows.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[13])(@this, pAttributes, dwAccess, lpNamePtr, pHandlePtr);
                }
            Marshal.FreeHGlobal((IntPtr)lpNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSharedHandle(ref Silk.NET.Core.Runtime.Windows.SecurityAttributes pAttributes, uint dwAccess, char* lpName, void** pHandle)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.SecurityAttributes* pAttributesPtr = &pAttributes)
                {
                    ret = ((delegate* cdecl<IDXGIResource1*, Silk.NET.Core.Runtime.Windows.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[13])(@this, pAttributesPtr, dwAccess, lpName, pHandle);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSharedHandle(ref Silk.NET.Core.Runtime.Windows.SecurityAttributes pAttributes, uint dwAccess, char* lpName, ref void* pHandle)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.SecurityAttributes* pAttributesPtr = &pAttributes)
                {
                    fixed (void** pHandlePtr = &pHandle)
                    {
                        ret = ((delegate* cdecl<IDXGIResource1*, Silk.NET.Core.Runtime.Windows.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[13])(@this, pAttributesPtr, dwAccess, lpName, pHandlePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSharedHandle(ref Silk.NET.Core.Runtime.Windows.SecurityAttributes pAttributes, uint dwAccess, ref char lpName, void** pHandle)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.SecurityAttributes* pAttributesPtr = &pAttributes)
                {
                    fixed (char* lpNamePtr = &lpName)
                    {
                        ret = ((delegate* cdecl<IDXGIResource1*, Silk.NET.Core.Runtime.Windows.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[13])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandle);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSharedHandle(ref Silk.NET.Core.Runtime.Windows.SecurityAttributes pAttributes, uint dwAccess, ref char lpName, ref void* pHandle)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.SecurityAttributes* pAttributesPtr = &pAttributes)
                {
                    fixed (char* lpNamePtr = &lpName)
                    {
                        fixed (void** pHandlePtr = &pHandle)
                        {
                            ret = ((delegate* cdecl<IDXGIResource1*, Silk.NET.Core.Runtime.Windows.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[13])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandlePtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSharedHandle(ref Silk.NET.Core.Runtime.Windows.SecurityAttributes pAttributes, uint dwAccess, string lpName, void** pHandle)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.SecurityAttributes* pAttributesPtr = &pAttributes)
                {
            var lpNamePtr = (byte*) Marshal.StringToHGlobalAnsi(lpName);
                    ret = ((delegate* cdecl<IDXGIResource1*, Silk.NET.Core.Runtime.Windows.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[13])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandle);
            Marshal.FreeHGlobal((IntPtr)lpNamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSharedHandle(ref Silk.NET.Core.Runtime.Windows.SecurityAttributes pAttributes, uint dwAccess, string lpName, ref void* pHandle)
        {
            fixed (IDXGIResource1* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.SecurityAttributes* pAttributesPtr = &pAttributes)
                {
            var lpNamePtr = (byte*) Marshal.StringToHGlobalAnsi(lpName);
                    fixed (void** pHandlePtr = &pHandle)
                    {
                        ret = ((delegate* cdecl<IDXGIResource1*, Silk.NET.Core.Runtime.Windows.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[13])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandlePtr);
                    }
            Marshal.FreeHGlobal((IntPtr)lpNamePtr);
                }
                return ret;
            }
        }

    }
}
