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
    [Guid("bae8b344-23fc-4071-8cb5-d05d6f073848")]
    [NativeName("Name", "ID2D1InkStyle")]
    public unsafe partial struct ID2D1InkStyle
    {
        public static readonly Guid Guid = new("bae8b344-23fc-4071-8cb5-d05d6f073848");

        public static implicit operator ID2D1Resource(ID2D1InkStyle val)
            => Unsafe.As<ID2D1InkStyle, ID2D1Resource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1InkStyle val)
            => Unsafe.As<ID2D1InkStyle, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1InkStyle
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
            var @this = (ID2D1InkStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1InkStyle*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1InkStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1InkStyle*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1InkStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1InkStyle*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1InkStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1InkStyle*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1InkStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1InkStyle*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1InkStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1InkStyle*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1InkStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1InkStyle*, ID2D1Factory**, void>)LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ref ID2D1Factory* factory)
        {
            var @this = (ID2D1InkStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Factory** factoryPtr = &factory)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1InkStyle*, ID2D1Factory**, void>)LpVtbl[3])(@this, factoryPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetNibTransform(Silk.NET.Maths.Matrix3X2<float>* transform)
        {
            var @this = (ID2D1InkStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, void>)LpVtbl[4])(@this, transform);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetNibTransform(ref Silk.NET.Maths.Matrix3X2<float> transform)
        {
            var @this = (ID2D1InkStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, void>)LpVtbl[4])(@this, transformPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetNibTransform(Silk.NET.Maths.Matrix3X2<float>* transform)
        {
            var @this = (ID2D1InkStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, void>)LpVtbl[5])(@this, transform);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetNibTransform(ref Silk.NET.Maths.Matrix3X2<float> transform)
        {
            var @this = (ID2D1InkStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, void>)LpVtbl[5])(@this, transformPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void SetNibShape(InkNibShape nibShape)
        {
            var @this = (ID2D1InkStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1InkStyle*, InkNibShape, void>)LpVtbl[6])(@this, nibShape);
        }

        /// <summary>To be documented.</summary>
        public readonly InkNibShape GetNibShape()
        {
            var @this = (ID2D1InkStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            InkNibShape ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1InkStyle*, InkNibShape>)LpVtbl[7])(@this);
            return ret;
        }

    }
}
