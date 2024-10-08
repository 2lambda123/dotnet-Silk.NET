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
    [Guid("00020403-0000-0000-c000-000000000046")]
    [NativeName("Name", "ITypeComp")]
    public unsafe partial struct ITypeComp : IComVtbl<ITypeComp>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("00020403-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ITypeComp val)
            => Unsafe.As<ITypeComp, Silk.NET.Core.Native.IUnknown>(ref val);

        public ITypeComp
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
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Bind(char* szName, uint lHashVal, ushort wFlags, ITypeInfo** ppTInfo, DescKind* pDescKind, BindPtr* pBindPtr)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, char*, uint, ushort, ITypeInfo**, DescKind*, BindPtr*, int>)@this->LpVtbl[3])(@this, szName, lHashVal, wFlags, ppTInfo, pDescKind, pBindPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Bind(char* szName, uint lHashVal, ushort wFlags, ITypeInfo** ppTInfo, DescKind* pDescKind, ref BindPtr pBindPtr)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BindPtr* pBindPtrPtr = &pBindPtr)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, char*, uint, ushort, ITypeInfo**, DescKind*, BindPtr*, int>)@this->LpVtbl[3])(@this, szName, lHashVal, wFlags, ppTInfo, pDescKind, pBindPtrPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Bind(char* szName, uint lHashVal, ushort wFlags, ITypeInfo** ppTInfo, ref DescKind pDescKind, BindPtr* pBindPtr)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DescKind* pDescKindPtr = &pDescKind)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, char*, uint, ushort, ITypeInfo**, DescKind*, BindPtr*, int>)@this->LpVtbl[3])(@this, szName, lHashVal, wFlags, ppTInfo, pDescKindPtr, pBindPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Bind(char* szName, uint lHashVal, ushort wFlags, ITypeInfo** ppTInfo, ref DescKind pDescKind, ref BindPtr pBindPtr)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DescKind* pDescKindPtr = &pDescKind)
            {
                fixed (BindPtr* pBindPtrPtr = &pBindPtr)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, char*, uint, ushort, ITypeInfo**, DescKind*, BindPtr*, int>)@this->LpVtbl[3])(@this, szName, lHashVal, wFlags, ppTInfo, pDescKindPtr, pBindPtrPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Bind(char* szName, uint lHashVal, ushort wFlags, ref ITypeInfo* ppTInfo, DescKind* pDescKind, BindPtr* pBindPtr)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, char*, uint, ushort, ITypeInfo**, DescKind*, BindPtr*, int>)@this->LpVtbl[3])(@this, szName, lHashVal, wFlags, ppTInfoPtr, pDescKind, pBindPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Bind(char* szName, uint lHashVal, ushort wFlags, ref ITypeInfo* ppTInfo, DescKind* pDescKind, ref BindPtr pBindPtr)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
            {
                fixed (BindPtr* pBindPtrPtr = &pBindPtr)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, char*, uint, ushort, ITypeInfo**, DescKind*, BindPtr*, int>)@this->LpVtbl[3])(@this, szName, lHashVal, wFlags, ppTInfoPtr, pDescKind, pBindPtrPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Bind(char* szName, uint lHashVal, ushort wFlags, ref ITypeInfo* ppTInfo, ref DescKind pDescKind, BindPtr* pBindPtr)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
            {
                fixed (DescKind* pDescKindPtr = &pDescKind)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, char*, uint, ushort, ITypeInfo**, DescKind*, BindPtr*, int>)@this->LpVtbl[3])(@this, szName, lHashVal, wFlags, ppTInfoPtr, pDescKindPtr, pBindPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Bind(char* szName, uint lHashVal, ushort wFlags, ref ITypeInfo* ppTInfo, ref DescKind pDescKind, ref BindPtr pBindPtr)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
            {
                fixed (DescKind* pDescKindPtr = &pDescKind)
                {
                    fixed (BindPtr* pBindPtrPtr = &pBindPtr)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, char*, uint, ushort, ITypeInfo**, DescKind*, BindPtr*, int>)@this->LpVtbl[3])(@this, szName, lHashVal, wFlags, ppTInfoPtr, pDescKindPtr, pBindPtrPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Bind(ref char szName, uint lHashVal, ushort wFlags, ITypeInfo** ppTInfo, DescKind* pDescKind, BindPtr* pBindPtr)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szNamePtr = &szName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, char*, uint, ushort, ITypeInfo**, DescKind*, BindPtr*, int>)@this->LpVtbl[3])(@this, szNamePtr, lHashVal, wFlags, ppTInfo, pDescKind, pBindPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Bind(ref char szName, uint lHashVal, ushort wFlags, ITypeInfo** ppTInfo, DescKind* pDescKind, ref BindPtr pBindPtr)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szNamePtr = &szName)
            {
                fixed (BindPtr* pBindPtrPtr = &pBindPtr)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, char*, uint, ushort, ITypeInfo**, DescKind*, BindPtr*, int>)@this->LpVtbl[3])(@this, szNamePtr, lHashVal, wFlags, ppTInfo, pDescKind, pBindPtrPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Bind(ref char szName, uint lHashVal, ushort wFlags, ITypeInfo** ppTInfo, ref DescKind pDescKind, BindPtr* pBindPtr)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szNamePtr = &szName)
            {
                fixed (DescKind* pDescKindPtr = &pDescKind)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, char*, uint, ushort, ITypeInfo**, DescKind*, BindPtr*, int>)@this->LpVtbl[3])(@this, szNamePtr, lHashVal, wFlags, ppTInfo, pDescKindPtr, pBindPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Bind(ref char szName, uint lHashVal, ushort wFlags, ITypeInfo** ppTInfo, ref DescKind pDescKind, ref BindPtr pBindPtr)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szNamePtr = &szName)
            {
                fixed (DescKind* pDescKindPtr = &pDescKind)
                {
                    fixed (BindPtr* pBindPtrPtr = &pBindPtr)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, char*, uint, ushort, ITypeInfo**, DescKind*, BindPtr*, int>)@this->LpVtbl[3])(@this, szNamePtr, lHashVal, wFlags, ppTInfo, pDescKindPtr, pBindPtrPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Bind(ref char szName, uint lHashVal, ushort wFlags, ref ITypeInfo* ppTInfo, DescKind* pDescKind, BindPtr* pBindPtr)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szNamePtr = &szName)
            {
                fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, char*, uint, ushort, ITypeInfo**, DescKind*, BindPtr*, int>)@this->LpVtbl[3])(@this, szNamePtr, lHashVal, wFlags, ppTInfoPtr, pDescKind, pBindPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Bind(ref char szName, uint lHashVal, ushort wFlags, ref ITypeInfo* ppTInfo, DescKind* pDescKind, ref BindPtr pBindPtr)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szNamePtr = &szName)
            {
                fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
                {
                    fixed (BindPtr* pBindPtrPtr = &pBindPtr)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, char*, uint, ushort, ITypeInfo**, DescKind*, BindPtr*, int>)@this->LpVtbl[3])(@this, szNamePtr, lHashVal, wFlags, ppTInfoPtr, pDescKind, pBindPtrPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Bind(ref char szName, uint lHashVal, ushort wFlags, ref ITypeInfo* ppTInfo, ref DescKind pDescKind, BindPtr* pBindPtr)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szNamePtr = &szName)
            {
                fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
                {
                    fixed (DescKind* pDescKindPtr = &pDescKind)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, char*, uint, ushort, ITypeInfo**, DescKind*, BindPtr*, int>)@this->LpVtbl[3])(@this, szNamePtr, lHashVal, wFlags, ppTInfoPtr, pDescKindPtr, pBindPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Bind(ref char szName, uint lHashVal, ushort wFlags, ref ITypeInfo* ppTInfo, ref DescKind pDescKind, ref BindPtr pBindPtr)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szNamePtr = &szName)
            {
                fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
                {
                    fixed (DescKind* pDescKindPtr = &pDescKind)
                    {
                        fixed (BindPtr* pBindPtrPtr = &pBindPtr)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, char*, uint, ushort, ITypeInfo**, DescKind*, BindPtr*, int>)@this->LpVtbl[3])(@this, szNamePtr, lHashVal, wFlags, ppTInfoPtr, pDescKindPtr, pBindPtrPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Bind([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, uint lHashVal, ushort wFlags, ITypeInfo** ppTInfo, DescKind* pDescKind, BindPtr* pBindPtr)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szNamePtr = (byte*) SilkMarshal.StringToPtr(szName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, byte*, uint, ushort, ITypeInfo**, DescKind*, BindPtr*, int>)@this->LpVtbl[3])(@this, szNamePtr, lHashVal, wFlags, ppTInfo, pDescKind, pBindPtr);
            SilkMarshal.Free((nint)szNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Bind([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, uint lHashVal, ushort wFlags, ITypeInfo** ppTInfo, DescKind* pDescKind, ref BindPtr pBindPtr)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szNamePtr = (byte*) SilkMarshal.StringToPtr(szName, NativeStringEncoding.UTF8);
            fixed (BindPtr* pBindPtrPtr = &pBindPtr)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, byte*, uint, ushort, ITypeInfo**, DescKind*, BindPtr*, int>)@this->LpVtbl[3])(@this, szNamePtr, lHashVal, wFlags, ppTInfo, pDescKind, pBindPtrPtr);
            }
            SilkMarshal.Free((nint)szNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Bind([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, uint lHashVal, ushort wFlags, ITypeInfo** ppTInfo, ref DescKind pDescKind, BindPtr* pBindPtr)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szNamePtr = (byte*) SilkMarshal.StringToPtr(szName, NativeStringEncoding.UTF8);
            fixed (DescKind* pDescKindPtr = &pDescKind)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, byte*, uint, ushort, ITypeInfo**, DescKind*, BindPtr*, int>)@this->LpVtbl[3])(@this, szNamePtr, lHashVal, wFlags, ppTInfo, pDescKindPtr, pBindPtr);
            }
            SilkMarshal.Free((nint)szNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Bind([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, uint lHashVal, ushort wFlags, ITypeInfo** ppTInfo, ref DescKind pDescKind, ref BindPtr pBindPtr)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szNamePtr = (byte*) SilkMarshal.StringToPtr(szName, NativeStringEncoding.UTF8);
            fixed (DescKind* pDescKindPtr = &pDescKind)
            {
                fixed (BindPtr* pBindPtrPtr = &pBindPtr)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, byte*, uint, ushort, ITypeInfo**, DescKind*, BindPtr*, int>)@this->LpVtbl[3])(@this, szNamePtr, lHashVal, wFlags, ppTInfo, pDescKindPtr, pBindPtrPtr);
                }
            }
            SilkMarshal.Free((nint)szNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Bind([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, uint lHashVal, ushort wFlags, ref ITypeInfo* ppTInfo, DescKind* pDescKind, BindPtr* pBindPtr)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szNamePtr = (byte*) SilkMarshal.StringToPtr(szName, NativeStringEncoding.UTF8);
            fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, byte*, uint, ushort, ITypeInfo**, DescKind*, BindPtr*, int>)@this->LpVtbl[3])(@this, szNamePtr, lHashVal, wFlags, ppTInfoPtr, pDescKind, pBindPtr);
            }
            SilkMarshal.Free((nint)szNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Bind([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, uint lHashVal, ushort wFlags, ref ITypeInfo* ppTInfo, DescKind* pDescKind, ref BindPtr pBindPtr)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szNamePtr = (byte*) SilkMarshal.StringToPtr(szName, NativeStringEncoding.UTF8);
            fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
            {
                fixed (BindPtr* pBindPtrPtr = &pBindPtr)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, byte*, uint, ushort, ITypeInfo**, DescKind*, BindPtr*, int>)@this->LpVtbl[3])(@this, szNamePtr, lHashVal, wFlags, ppTInfoPtr, pDescKind, pBindPtrPtr);
                }
            }
            SilkMarshal.Free((nint)szNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Bind([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, uint lHashVal, ushort wFlags, ref ITypeInfo* ppTInfo, ref DescKind pDescKind, BindPtr* pBindPtr)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szNamePtr = (byte*) SilkMarshal.StringToPtr(szName, NativeStringEncoding.UTF8);
            fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
            {
                fixed (DescKind* pDescKindPtr = &pDescKind)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, byte*, uint, ushort, ITypeInfo**, DescKind*, BindPtr*, int>)@this->LpVtbl[3])(@this, szNamePtr, lHashVal, wFlags, ppTInfoPtr, pDescKindPtr, pBindPtr);
                }
            }
            SilkMarshal.Free((nint)szNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Bind([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, uint lHashVal, ushort wFlags, ref ITypeInfo* ppTInfo, ref DescKind pDescKind, ref BindPtr pBindPtr)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szNamePtr = (byte*) SilkMarshal.StringToPtr(szName, NativeStringEncoding.UTF8);
            fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
            {
                fixed (DescKind* pDescKindPtr = &pDescKind)
                {
                    fixed (BindPtr* pBindPtrPtr = &pBindPtr)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, byte*, uint, ushort, ITypeInfo**, DescKind*, BindPtr*, int>)@this->LpVtbl[3])(@this, szNamePtr, lHashVal, wFlags, ppTInfoPtr, pDescKindPtr, pBindPtrPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)szNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindType(char* szName, uint lHashVal, ITypeInfo** ppTInfo, ITypeComp** ppTComp)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, char*, uint, ITypeInfo**, ITypeComp**, int>)@this->LpVtbl[4])(@this, szName, lHashVal, ppTInfo, ppTComp);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindType(char* szName, uint lHashVal, ITypeInfo** ppTInfo, ref ITypeComp* ppTComp)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeComp** ppTCompPtr = &ppTComp)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, char*, uint, ITypeInfo**, ITypeComp**, int>)@this->LpVtbl[4])(@this, szName, lHashVal, ppTInfo, ppTCompPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindType(char* szName, uint lHashVal, ref ITypeInfo* ppTInfo, ITypeComp** ppTComp)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, char*, uint, ITypeInfo**, ITypeComp**, int>)@this->LpVtbl[4])(@this, szName, lHashVal, ppTInfoPtr, ppTComp);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindType(char* szName, uint lHashVal, ref ITypeInfo* ppTInfo, ref ITypeComp* ppTComp)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
            {
                fixed (ITypeComp** ppTCompPtr = &ppTComp)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, char*, uint, ITypeInfo**, ITypeComp**, int>)@this->LpVtbl[4])(@this, szName, lHashVal, ppTInfoPtr, ppTCompPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindType(ref char szName, uint lHashVal, ITypeInfo** ppTInfo, ITypeComp** ppTComp)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szNamePtr = &szName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, char*, uint, ITypeInfo**, ITypeComp**, int>)@this->LpVtbl[4])(@this, szNamePtr, lHashVal, ppTInfo, ppTComp);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindType(ref char szName, uint lHashVal, ITypeInfo** ppTInfo, ref ITypeComp* ppTComp)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szNamePtr = &szName)
            {
                fixed (ITypeComp** ppTCompPtr = &ppTComp)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, char*, uint, ITypeInfo**, ITypeComp**, int>)@this->LpVtbl[4])(@this, szNamePtr, lHashVal, ppTInfo, ppTCompPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindType(ref char szName, uint lHashVal, ref ITypeInfo* ppTInfo, ITypeComp** ppTComp)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szNamePtr = &szName)
            {
                fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, char*, uint, ITypeInfo**, ITypeComp**, int>)@this->LpVtbl[4])(@this, szNamePtr, lHashVal, ppTInfoPtr, ppTComp);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindType(ref char szName, uint lHashVal, ref ITypeInfo* ppTInfo, ref ITypeComp* ppTComp)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szNamePtr = &szName)
            {
                fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
                {
                    fixed (ITypeComp** ppTCompPtr = &ppTComp)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, char*, uint, ITypeInfo**, ITypeComp**, int>)@this->LpVtbl[4])(@this, szNamePtr, lHashVal, ppTInfoPtr, ppTCompPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindType([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, uint lHashVal, ITypeInfo** ppTInfo, ITypeComp** ppTComp)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szNamePtr = (byte*) SilkMarshal.StringToPtr(szName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, byte*, uint, ITypeInfo**, ITypeComp**, int>)@this->LpVtbl[4])(@this, szNamePtr, lHashVal, ppTInfo, ppTComp);
            SilkMarshal.Free((nint)szNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindType([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, uint lHashVal, ITypeInfo** ppTInfo, ref ITypeComp* ppTComp)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szNamePtr = (byte*) SilkMarshal.StringToPtr(szName, NativeStringEncoding.UTF8);
            fixed (ITypeComp** ppTCompPtr = &ppTComp)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, byte*, uint, ITypeInfo**, ITypeComp**, int>)@this->LpVtbl[4])(@this, szNamePtr, lHashVal, ppTInfo, ppTCompPtr);
            }
            SilkMarshal.Free((nint)szNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindType([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, uint lHashVal, ref ITypeInfo* ppTInfo, ITypeComp** ppTComp)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szNamePtr = (byte*) SilkMarshal.StringToPtr(szName, NativeStringEncoding.UTF8);
            fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, byte*, uint, ITypeInfo**, ITypeComp**, int>)@this->LpVtbl[4])(@this, szNamePtr, lHashVal, ppTInfoPtr, ppTComp);
            }
            SilkMarshal.Free((nint)szNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindType([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, uint lHashVal, ref ITypeInfo* ppTInfo, ref ITypeComp* ppTComp)
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szNamePtr = (byte*) SilkMarshal.StringToPtr(szName, NativeStringEncoding.UTF8);
            fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
            {
                fixed (ITypeComp** ppTCompPtr = &ppTComp)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeComp*, byte*, uint, ITypeInfo**, ITypeComp**, int>)@this->LpVtbl[4])(@this, szNamePtr, lHashVal, ppTInfoPtr, ppTCompPtr);
                }
            }
            SilkMarshal.Free((nint)szNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Bind<TI0>(char* szName, uint lHashVal, ushort wFlags, ref ComPtr<TI0> ppTInfo, DescKind* pDescKind, BindPtr* pBindPtr) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Bind(szName, lHashVal, wFlags, (ITypeInfo**) ppTInfo.GetAddressOf(), pDescKind, pBindPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Bind<TI0>(char* szName, uint lHashVal, ushort wFlags, ref ComPtr<TI0> ppTInfo, DescKind* pDescKind, ref BindPtr pBindPtr) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Bind(szName, lHashVal, wFlags, (ITypeInfo**) ppTInfo.GetAddressOf(), pDescKind, ref pBindPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Bind<TI0>(char* szName, uint lHashVal, ushort wFlags, ref ComPtr<TI0> ppTInfo, ref DescKind pDescKind, BindPtr* pBindPtr) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Bind(szName, lHashVal, wFlags, (ITypeInfo**) ppTInfo.GetAddressOf(), ref pDescKind, pBindPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Bind<TI0>(char* szName, uint lHashVal, ushort wFlags, ref ComPtr<TI0> ppTInfo, ref DescKind pDescKind, ref BindPtr pBindPtr) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Bind(szName, lHashVal, wFlags, (ITypeInfo**) ppTInfo.GetAddressOf(), ref pDescKind, ref pBindPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Bind<TI0>(ref char szName, uint lHashVal, ushort wFlags, ref ComPtr<TI0> ppTInfo, DescKind* pDescKind, BindPtr* pBindPtr) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Bind(ref szName, lHashVal, wFlags, (ITypeInfo**) ppTInfo.GetAddressOf(), pDescKind, pBindPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Bind<TI0>(ref char szName, uint lHashVal, ushort wFlags, ref ComPtr<TI0> ppTInfo, DescKind* pDescKind, ref BindPtr pBindPtr) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Bind(ref szName, lHashVal, wFlags, (ITypeInfo**) ppTInfo.GetAddressOf(), pDescKind, ref pBindPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Bind<TI0>(ref char szName, uint lHashVal, ushort wFlags, ref ComPtr<TI0> ppTInfo, ref DescKind pDescKind, BindPtr* pBindPtr) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Bind(ref szName, lHashVal, wFlags, (ITypeInfo**) ppTInfo.GetAddressOf(), ref pDescKind, pBindPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly int Bind<TI0>(ref char szName, uint lHashVal, ushort wFlags, ref ComPtr<TI0> ppTInfo, ref DescKind pDescKind, ref BindPtr pBindPtr) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Bind(ref szName, lHashVal, wFlags, (ITypeInfo**) ppTInfo.GetAddressOf(), ref pDescKind, ref pBindPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Bind<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, uint lHashVal, ushort wFlags, ref ComPtr<TI0> ppTInfo, DescKind* pDescKind, BindPtr* pBindPtr) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Bind(szName, lHashVal, wFlags, (ITypeInfo**) ppTInfo.GetAddressOf(), pDescKind, pBindPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Bind<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, uint lHashVal, ushort wFlags, ref ComPtr<TI0> ppTInfo, DescKind* pDescKind, ref BindPtr pBindPtr) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Bind(szName, lHashVal, wFlags, (ITypeInfo**) ppTInfo.GetAddressOf(), pDescKind, ref pBindPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Bind<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, uint lHashVal, ushort wFlags, ref ComPtr<TI0> ppTInfo, ref DescKind pDescKind, BindPtr* pBindPtr) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Bind(szName, lHashVal, wFlags, (ITypeInfo**) ppTInfo.GetAddressOf(), ref pDescKind, pBindPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly int Bind<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, uint lHashVal, ushort wFlags, ref ComPtr<TI0> ppTInfo, ref DescKind pDescKind, ref BindPtr pBindPtr) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Bind(szName, lHashVal, wFlags, (ITypeInfo**) ppTInfo.GetAddressOf(), ref pDescKind, ref pBindPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindType<TI0, TI1>(char* szName, uint lHashVal, ref ComPtr<TI0> ppTInfo, ref ComPtr<TI1> ppTComp) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ITypeComp>, IComVtbl<TI1>
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BindType(szName, lHashVal, (ITypeInfo**) ppTInfo.GetAddressOf(), (ITypeComp**) ppTComp.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindType<TI0>(char* szName, uint lHashVal, ref ComPtr<TI0> ppTInfo, ref ITypeComp* ppTComp) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BindType(szName, lHashVal, (ITypeInfo**) ppTInfo.GetAddressOf(), ref ppTComp);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindType<TI0>(char* szName, uint lHashVal, ref ITypeInfo* ppTInfo, ref ComPtr<TI0> ppTComp) where TI0 : unmanaged, IComVtbl<ITypeComp>, IComVtbl<TI0>
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BindType(szName, lHashVal, ref ppTInfo, (ITypeComp**) ppTComp.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int BindType<TI0, TI1>(ref char szName, uint lHashVal, ref ComPtr<TI0> ppTInfo, ref ComPtr<TI1> ppTComp) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ITypeComp>, IComVtbl<TI1>
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BindType(ref szName, lHashVal, (ITypeInfo**) ppTInfo.GetAddressOf(), (ITypeComp**) ppTComp.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindType<TI0>(ref char szName, uint lHashVal, ref ComPtr<TI0> ppTInfo, ref ITypeComp* ppTComp) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BindType(ref szName, lHashVal, (ITypeInfo**) ppTInfo.GetAddressOf(), ref ppTComp);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindType<TI0>(ref char szName, uint lHashVal, ref ITypeInfo* ppTInfo, ref ComPtr<TI0> ppTComp) where TI0 : unmanaged, IComVtbl<ITypeComp>, IComVtbl<TI0>
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BindType(ref szName, lHashVal, ref ppTInfo, (ITypeComp**) ppTComp.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int BindType<TI0, TI1>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, uint lHashVal, ref ComPtr<TI0> ppTInfo, ref ComPtr<TI1> ppTComp) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ITypeComp>, IComVtbl<TI1>
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BindType(szName, lHashVal, (ITypeInfo**) ppTInfo.GetAddressOf(), (ITypeComp**) ppTComp.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindType<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, uint lHashVal, ref ComPtr<TI0> ppTInfo, ref ITypeComp* ppTComp) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BindType(szName, lHashVal, (ITypeInfo**) ppTInfo.GetAddressOf(), ref ppTComp);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindType<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, uint lHashVal, ref ITypeInfo* ppTInfo, ref ComPtr<TI0> ppTComp) where TI0 : unmanaged, IComVtbl<ITypeComp>, IComVtbl<TI0>
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BindType(szName, lHashVal, ref ppTInfo, (ITypeComp**) ppTComp.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ITypeComp*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
