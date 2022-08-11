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

namespace Silk.NET.Direct2D
{
    [Guid("852f2087-802c-4037-ab60-ff2e7ee6fc01")]
    [NativeName("Name", "ID2D1Device3")]
    public unsafe partial struct ID2D1Device3
    {
        public static readonly Guid Guid = new("852f2087-802c-4037-ab60-ff2e7ee6fc01");

        public static implicit operator ID2D1Device2(ID2D1Device3 val)
            => Unsafe.As<ID2D1Device3, ID2D1Device2>(ref val);

        public static implicit operator ID2D1Device1(ID2D1Device3 val)
            => Unsafe.As<ID2D1Device3, ID2D1Device1>(ref val);

        public static implicit operator ID2D1Device(ID2D1Device3 val)
            => Unsafe.As<ID2D1Device3, ID2D1Device>(ref val);

        public static implicit operator ID2D1Resource(ID2D1Device3 val)
            => Unsafe.As<ID2D1Device3, ID2D1Resource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1Device3 val)
            => Unsafe.As<ID2D1Device3, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1Device3
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
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device3*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Device3*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Device3*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Device3*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device3*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device3*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1Device3*, ID2D1Factory**, void>)LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ref ID2D1Factory* factory)
        {
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Factory** factoryPtr = &factory)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1Device3*, ID2D1Factory**, void>)LpVtbl[3])(@this, factoryPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDeviceContext(DeviceContextOptions options, ID2D1DeviceContext** deviceContext)
        {
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device3*, DeviceContextOptions, ID2D1DeviceContext**, int>)LpVtbl[4])(@this, options, deviceContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDeviceContext(DeviceContextOptions options, ref ID2D1DeviceContext* deviceContext)
        {
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1DeviceContext** deviceContextPtr = &deviceContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Device3*, DeviceContextOptions, ID2D1DeviceContext**, int>)LpVtbl[4])(@this, options, deviceContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePrintControl(IWICImagingFactory* wicFactory, IPrintDocumentPackageTarget* documentTarget, PrintControlProperties* printControlProperties, ID2D1PrintControl** printControl)
        {
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device3*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)LpVtbl[5])(@this, wicFactory, documentTarget, printControlProperties, printControl);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePrintControl(IWICImagingFactory* wicFactory, IPrintDocumentPackageTarget* documentTarget, PrintControlProperties* printControlProperties, ref ID2D1PrintControl* printControl)
        {
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1PrintControl** printControlPtr = &printControl)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Device3*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)LpVtbl[5])(@this, wicFactory, documentTarget, printControlProperties, printControlPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePrintControl(IWICImagingFactory* wicFactory, IPrintDocumentPackageTarget* documentTarget, ref PrintControlProperties printControlProperties, ID2D1PrintControl** printControl)
        {
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PrintControlProperties* printControlPropertiesPtr = &printControlProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Device3*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)LpVtbl[5])(@this, wicFactory, documentTarget, printControlPropertiesPtr, printControl);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePrintControl(IWICImagingFactory* wicFactory, IPrintDocumentPackageTarget* documentTarget, ref PrintControlProperties printControlProperties, ref ID2D1PrintControl* printControl)
        {
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PrintControlProperties* printControlPropertiesPtr = &printControlProperties)
            {
                fixed (ID2D1PrintControl** printControlPtr = &printControl)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Device3*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)LpVtbl[5])(@this, wicFactory, documentTarget, printControlPropertiesPtr, printControlPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePrintControl(IWICImagingFactory* wicFactory, ref IPrintDocumentPackageTarget documentTarget, PrintControlProperties* printControlProperties, ID2D1PrintControl** printControl)
        {
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IPrintDocumentPackageTarget* documentTargetPtr = &documentTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Device3*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)LpVtbl[5])(@this, wicFactory, documentTargetPtr, printControlProperties, printControl);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePrintControl(IWICImagingFactory* wicFactory, ref IPrintDocumentPackageTarget documentTarget, PrintControlProperties* printControlProperties, ref ID2D1PrintControl* printControl)
        {
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IPrintDocumentPackageTarget* documentTargetPtr = &documentTarget)
            {
                fixed (ID2D1PrintControl** printControlPtr = &printControl)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Device3*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)LpVtbl[5])(@this, wicFactory, documentTargetPtr, printControlProperties, printControlPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePrintControl(IWICImagingFactory* wicFactory, ref IPrintDocumentPackageTarget documentTarget, ref PrintControlProperties printControlProperties, ID2D1PrintControl** printControl)
        {
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IPrintDocumentPackageTarget* documentTargetPtr = &documentTarget)
            {
                fixed (PrintControlProperties* printControlPropertiesPtr = &printControlProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Device3*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)LpVtbl[5])(@this, wicFactory, documentTargetPtr, printControlPropertiesPtr, printControl);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePrintControl(IWICImagingFactory* wicFactory, ref IPrintDocumentPackageTarget documentTarget, ref PrintControlProperties printControlProperties, ref ID2D1PrintControl* printControl)
        {
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IPrintDocumentPackageTarget* documentTargetPtr = &documentTarget)
            {
                fixed (PrintControlProperties* printControlPropertiesPtr = &printControlProperties)
                {
                    fixed (ID2D1PrintControl** printControlPtr = &printControl)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1Device3*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)LpVtbl[5])(@this, wicFactory, documentTargetPtr, printControlPropertiesPtr, printControlPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePrintControl(ref IWICImagingFactory wicFactory, IPrintDocumentPackageTarget* documentTarget, PrintControlProperties* printControlProperties, ID2D1PrintControl** printControl)
        {
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICImagingFactory* wicFactoryPtr = &wicFactory)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Device3*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)LpVtbl[5])(@this, wicFactoryPtr, documentTarget, printControlProperties, printControl);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePrintControl(ref IWICImagingFactory wicFactory, IPrintDocumentPackageTarget* documentTarget, PrintControlProperties* printControlProperties, ref ID2D1PrintControl* printControl)
        {
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICImagingFactory* wicFactoryPtr = &wicFactory)
            {
                fixed (ID2D1PrintControl** printControlPtr = &printControl)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Device3*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)LpVtbl[5])(@this, wicFactoryPtr, documentTarget, printControlProperties, printControlPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePrintControl(ref IWICImagingFactory wicFactory, IPrintDocumentPackageTarget* documentTarget, ref PrintControlProperties printControlProperties, ID2D1PrintControl** printControl)
        {
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICImagingFactory* wicFactoryPtr = &wicFactory)
            {
                fixed (PrintControlProperties* printControlPropertiesPtr = &printControlProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Device3*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)LpVtbl[5])(@this, wicFactoryPtr, documentTarget, printControlPropertiesPtr, printControl);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePrintControl(ref IWICImagingFactory wicFactory, IPrintDocumentPackageTarget* documentTarget, ref PrintControlProperties printControlProperties, ref ID2D1PrintControl* printControl)
        {
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICImagingFactory* wicFactoryPtr = &wicFactory)
            {
                fixed (PrintControlProperties* printControlPropertiesPtr = &printControlProperties)
                {
                    fixed (ID2D1PrintControl** printControlPtr = &printControl)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1Device3*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)LpVtbl[5])(@this, wicFactoryPtr, documentTarget, printControlPropertiesPtr, printControlPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePrintControl(ref IWICImagingFactory wicFactory, ref IPrintDocumentPackageTarget documentTarget, PrintControlProperties* printControlProperties, ID2D1PrintControl** printControl)
        {
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICImagingFactory* wicFactoryPtr = &wicFactory)
            {
                fixed (IPrintDocumentPackageTarget* documentTargetPtr = &documentTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Device3*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)LpVtbl[5])(@this, wicFactoryPtr, documentTargetPtr, printControlProperties, printControl);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePrintControl(ref IWICImagingFactory wicFactory, ref IPrintDocumentPackageTarget documentTarget, PrintControlProperties* printControlProperties, ref ID2D1PrintControl* printControl)
        {
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICImagingFactory* wicFactoryPtr = &wicFactory)
            {
                fixed (IPrintDocumentPackageTarget* documentTargetPtr = &documentTarget)
                {
                    fixed (ID2D1PrintControl** printControlPtr = &printControl)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1Device3*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)LpVtbl[5])(@this, wicFactoryPtr, documentTargetPtr, printControlProperties, printControlPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePrintControl(ref IWICImagingFactory wicFactory, ref IPrintDocumentPackageTarget documentTarget, ref PrintControlProperties printControlProperties, ID2D1PrintControl** printControl)
        {
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICImagingFactory* wicFactoryPtr = &wicFactory)
            {
                fixed (IPrintDocumentPackageTarget* documentTargetPtr = &documentTarget)
                {
                    fixed (PrintControlProperties* printControlPropertiesPtr = &printControlProperties)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1Device3*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)LpVtbl[5])(@this, wicFactoryPtr, documentTargetPtr, printControlPropertiesPtr, printControl);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePrintControl(ref IWICImagingFactory wicFactory, ref IPrintDocumentPackageTarget documentTarget, ref PrintControlProperties printControlProperties, ref ID2D1PrintControl* printControl)
        {
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICImagingFactory* wicFactoryPtr = &wicFactory)
            {
                fixed (IPrintDocumentPackageTarget* documentTargetPtr = &documentTarget)
                {
                    fixed (PrintControlProperties* printControlPropertiesPtr = &printControlProperties)
                    {
                        fixed (ID2D1PrintControl** printControlPtr = &printControl)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device3*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)LpVtbl[5])(@this, wicFactoryPtr, documentTargetPtr, printControlPropertiesPtr, printControlPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetMaximumTextureMemory(ulong maximumInBytes)
        {
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1Device3*, ulong, void>)LpVtbl[6])(@this, maximumInBytes);
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetMaximumTextureMemory()
        {
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device3*, ulong>)LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearResources(uint millisecondsSinceUse)
        {
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1Device3*, uint, void>)LpVtbl[8])(@this, millisecondsSinceUse);
        }

        /// <summary>To be documented.</summary>
        public readonly RenderingPriority GetRenderingPriority()
        {
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            RenderingPriority ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device3*, RenderingPriority>)LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetRenderingPriority(RenderingPriority renderingPriority)
        {
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1Device3*, RenderingPriority, void>)LpVtbl[10])(@this, renderingPriority);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FlushDeviceContexts(ID2D1Bitmap* bitmap)
        {
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1Device3*, ID2D1Bitmap*, void>)LpVtbl[11])(@this, bitmap);
        }

        /// <summary>To be documented.</summary>
        public readonly void FlushDeviceContexts(ref ID2D1Bitmap bitmap)
        {
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1Device3*, ID2D1Bitmap*, void>)LpVtbl[11])(@this, bitmapPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDxgiDevice(Silk.NET.DXGI.IDXGIDevice** dxgiDevice)
        {
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device3*, Silk.NET.DXGI.IDXGIDevice**, int>)LpVtbl[12])(@this, dxgiDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDxgiDevice(ref Silk.NET.DXGI.IDXGIDevice* dxgiDevice)
        {
            var @this = (ID2D1Device3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGIDevice** dxgiDevicePtr = &dxgiDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Device3*, Silk.NET.DXGI.IDXGIDevice**, int>)LpVtbl[12])(@this, dxgiDevicePtr);
            }
            return ret;
        }

    }
}
