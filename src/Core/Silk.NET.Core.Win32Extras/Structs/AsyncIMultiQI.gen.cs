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
    [Guid("000e0020-0000-0000-c000-000000000046")]
    [NativeName("Name", "AsyncIMultiQI")]
    public unsafe partial struct AsyncIMultiQI
    {
        public static readonly Guid Guid = new("000e0020-0000-0000-c000-000000000046");

        public static implicit operator Silk.NET.Core.Native.IUnknown(AsyncIMultiQI val)
            => Unsafe.As<AsyncIMultiQI, Silk.NET.Core.Native.IUnknown>(ref val);

        public AsyncIMultiQI
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
            var @this = (AsyncIMultiQI*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<AsyncIMultiQI*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (AsyncIMultiQI*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<AsyncIMultiQI*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (AsyncIMultiQI*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<AsyncIMultiQI*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (AsyncIMultiQI*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<AsyncIMultiQI*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (AsyncIMultiQI*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<AsyncIMultiQI*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (AsyncIMultiQI*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<AsyncIMultiQI*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginQueryMultipleInterfaces(uint cMQIs, TagMULTIQI* pMQIs)
        {
            var @this = (AsyncIMultiQI*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<AsyncIMultiQI*, uint, TagMULTIQI*, int>)LpVtbl[3])(@this, cMQIs, pMQIs);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BeginQueryMultipleInterfaces(uint cMQIs, ref TagMULTIQI pMQIs)
        {
            var @this = (AsyncIMultiQI*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TagMULTIQI* pMQIsPtr = &pMQIs)
            {
                ret = ((delegate* unmanaged[Cdecl]<AsyncIMultiQI*, uint, TagMULTIQI*, int>)LpVtbl[3])(@this, cMQIs, pMQIsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FinishQueryMultipleInterfaces(TagMULTIQI* pMQIs)
        {
            var @this = (AsyncIMultiQI*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<AsyncIMultiQI*, TagMULTIQI*, int>)LpVtbl[4])(@this, pMQIs);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FinishQueryMultipleInterfaces(ref TagMULTIQI pMQIs)
        {
            var @this = (AsyncIMultiQI*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TagMULTIQI* pMQIsPtr = &pMQIs)
            {
                ret = ((delegate* unmanaged[Cdecl]<AsyncIMultiQI*, TagMULTIQI*, int>)LpVtbl[4])(@this, pMQIsPtr);
            }
            return ret;
        }

    }
}
