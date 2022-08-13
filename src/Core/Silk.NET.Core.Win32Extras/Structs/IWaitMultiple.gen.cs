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
    [Guid("0000002b-0000-0000-c000-000000000046")]
    [NativeName("Name", "IWaitMultiple")]
    public unsafe partial struct IWaitMultiple
    {
        public static readonly Guid Guid = new("0000002b-0000-0000-c000-000000000046");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWaitMultiple val)
            => Unsafe.As<IWaitMultiple, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWaitMultiple
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
            var @this = (IWaitMultiple*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IWaitMultiple*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWaitMultiple*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IWaitMultiple*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWaitMultiple*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IWaitMultiple*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWaitMultiple*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IWaitMultiple*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWaitMultiple*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IWaitMultiple*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWaitMultiple*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IWaitMultiple*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WaitMultiple(uint timeout, ISynchronize** pSync)
        {
            var @this = (IWaitMultiple*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IWaitMultiple*, uint, ISynchronize**, int>)LpVtbl[3])(@this, timeout, pSync);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WaitMultiple(uint timeout, ref ISynchronize* pSync)
        {
            var @this = (IWaitMultiple*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISynchronize** pSyncPtr = &pSync)
            {
                ret = ((delegate* unmanaged[Cdecl]<IWaitMultiple*, uint, ISynchronize**, int>)LpVtbl[3])(@this, timeout, pSyncPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddSynchronize(ISynchronize* pSync)
        {
            var @this = (IWaitMultiple*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IWaitMultiple*, ISynchronize*, int>)LpVtbl[4])(@this, pSync);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddSynchronize(ref ISynchronize pSync)
        {
            var @this = (IWaitMultiple*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISynchronize* pSyncPtr = &pSync)
            {
                ret = ((delegate* unmanaged[Cdecl]<IWaitMultiple*, ISynchronize*, int>)LpVtbl[4])(@this, pSyncPtr);
            }
            return ret;
        }

    }
}
