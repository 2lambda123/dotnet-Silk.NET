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

namespace Silk.NET.Core.Win32Extras
{
    [Guid("0000010f-0000-0000-c000-000000000046")]
    [NativeName("Name", "IAdviseSink")]
    public unsafe partial struct IAdviseSink : IComVtbl<IAdviseSink>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("0000010f-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IAdviseSink val)
            => Unsafe.As<IAdviseSink, Silk.NET.Core.Native.IUnknown>(ref val);

        public IAdviseSink
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
            var @this = (IAdviseSink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAdviseSink*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IAdviseSink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAdviseSink*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IAdviseSink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAdviseSink*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IAdviseSink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IAdviseSink*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IAdviseSink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAdviseSink*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IAdviseSink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAdviseSink*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OnDataChange(TagFORMATETC* pFormatetc, TagSTGMEDIUM* pStgmed)
        {
            var @this = (IAdviseSink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IAdviseSink*, TagFORMATETC*, TagSTGMEDIUM*, void>)@this->LpVtbl[3])(@this, pFormatetc, pStgmed);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OnDataChange(TagFORMATETC* pFormatetc, ref TagSTGMEDIUM pStgmed)
        {
            var @this = (IAdviseSink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TagSTGMEDIUM* pStgmedPtr = &pStgmed)
            {
                ((delegate* unmanaged[Cdecl]<IAdviseSink*, TagFORMATETC*, TagSTGMEDIUM*, void>)@this->LpVtbl[3])(@this, pFormatetc, pStgmedPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OnDataChange(ref TagFORMATETC pFormatetc, TagSTGMEDIUM* pStgmed)
        {
            var @this = (IAdviseSink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TagFORMATETC* pFormatetcPtr = &pFormatetc)
            {
                ((delegate* unmanaged[Cdecl]<IAdviseSink*, TagFORMATETC*, TagSTGMEDIUM*, void>)@this->LpVtbl[3])(@this, pFormatetcPtr, pStgmed);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void OnDataChange(ref TagFORMATETC pFormatetc, ref TagSTGMEDIUM pStgmed)
        {
            var @this = (IAdviseSink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TagFORMATETC* pFormatetcPtr = &pFormatetc)
            {
                fixed (TagSTGMEDIUM* pStgmedPtr = &pStgmed)
                {
                    ((delegate* unmanaged[Cdecl]<IAdviseSink*, TagFORMATETC*, TagSTGMEDIUM*, void>)@this->LpVtbl[3])(@this, pFormatetcPtr, pStgmedPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void OnViewChange(uint dwAspect, int lindex)
        {
            var @this = (IAdviseSink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IAdviseSink*, uint, int, void>)@this->LpVtbl[4])(@this, dwAspect, lindex);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OnRename(IMoniker* pmk)
        {
            var @this = (IAdviseSink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IAdviseSink*, IMoniker*, void>)@this->LpVtbl[5])(@this, pmk);
        }

        /// <summary>To be documented.</summary>
        public readonly void OnRename(ref IMoniker pmk)
        {
            var @this = (IAdviseSink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IMoniker* pmkPtr = &pmk)
            {
                ((delegate* unmanaged[Cdecl]<IAdviseSink*, IMoniker*, void>)@this->LpVtbl[5])(@this, pmkPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void OnSave()
        {
            var @this = (IAdviseSink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IAdviseSink*, void>)@this->LpVtbl[6])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly void OnClose()
        {
            var @this = (IAdviseSink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IAdviseSink*, void>)@this->LpVtbl[7])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IAdviseSink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void OnRename<TI0>(ComPtr<TI0> pmk) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IAdviseSink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OnRename((IMoniker*) pmk.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IAdviseSink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
