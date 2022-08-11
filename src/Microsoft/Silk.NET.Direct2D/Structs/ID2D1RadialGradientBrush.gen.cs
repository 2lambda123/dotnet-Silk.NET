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
    [Guid("2cd906ac-12e2-11dc-9fed-001143a055f9")]
    [NativeName("Name", "ID2D1RadialGradientBrush")]
    public unsafe partial struct ID2D1RadialGradientBrush
    {
        public static readonly Guid Guid = new("2cd906ac-12e2-11dc-9fed-001143a055f9");

        public static implicit operator ID2D1Brush(ID2D1RadialGradientBrush val)
            => Unsafe.As<ID2D1RadialGradientBrush, ID2D1Brush>(ref val);

        public static implicit operator ID2D1Resource(ID2D1RadialGradientBrush val)
            => Unsafe.As<ID2D1RadialGradientBrush, ID2D1Resource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1RadialGradientBrush val)
            => Unsafe.As<ID2D1RadialGradientBrush, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1RadialGradientBrush
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
            var @this = (ID2D1RadialGradientBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1RadialGradientBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1RadialGradientBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1RadialGradientBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1RadialGradientBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1RadialGradientBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1RadialGradientBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, ID2D1Factory**, void>)LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ref ID2D1Factory* factory)
        {
            var @this = (ID2D1RadialGradientBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Factory** factoryPtr = &factory)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, ID2D1Factory**, void>)LpVtbl[3])(@this, factoryPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void SetOpacity(float opacity)
        {
            var @this = (ID2D1RadialGradientBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, float, void>)LpVtbl[4])(@this, opacity);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetTransform(Silk.NET.Maths.Matrix3X2<float>* transform)
        {
            var @this = (ID2D1RadialGradientBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, Silk.NET.Maths.Matrix3X2<float>*, void>)LpVtbl[5])(@this, transform);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetTransform(ref Silk.NET.Maths.Matrix3X2<float> transform)
        {
            var @this = (ID2D1RadialGradientBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, Silk.NET.Maths.Matrix3X2<float>*, void>)LpVtbl[5])(@this, transformPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly float GetOpacity()
        {
            var @this = (ID2D1RadialGradientBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, float>)LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetTransform(Silk.NET.Maths.Matrix3X2<float>* transform)
        {
            var @this = (ID2D1RadialGradientBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, Silk.NET.Maths.Matrix3X2<float>*, void>)LpVtbl[7])(@this, transform);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetTransform(ref Silk.NET.Maths.Matrix3X2<float> transform)
        {
            var @this = (ID2D1RadialGradientBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, Silk.NET.Maths.Matrix3X2<float>*, void>)LpVtbl[7])(@this, transformPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void SetCenter(Silk.NET.Maths.Vector2D<float> center)
        {
            var @this = (ID2D1RadialGradientBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, Silk.NET.Maths.Vector2D<float>, void>)LpVtbl[8])(@this, center);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetGradientOriginOffset(Silk.NET.Maths.Vector2D<float> gradientOriginOffset)
        {
            var @this = (ID2D1RadialGradientBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, Silk.NET.Maths.Vector2D<float>, void>)LpVtbl[9])(@this, gradientOriginOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetRadiusX(float radiusX)
        {
            var @this = (ID2D1RadialGradientBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, float, void>)LpVtbl[10])(@this, radiusX);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetRadiusY(float radiusY)
        {
            var @this = (ID2D1RadialGradientBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, float, void>)LpVtbl[11])(@this, radiusY);
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Maths.Vector2D<float> GetCenter()
        {
            Silk.NET.Maths.Vector2D<float> silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID2D1RadialGradientBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Maths.Vector2D<float>* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<float>*>)LpVtbl[12])(@this, pSilkDotNetReturnFixupResult);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Maths.Vector2D<float> GetGradientOriginOffset()
        {
            Silk.NET.Maths.Vector2D<float> silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID2D1RadialGradientBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Maths.Vector2D<float>* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<float>*>)LpVtbl[13])(@this, pSilkDotNetReturnFixupResult);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly float GetRadiusX()
        {
            var @this = (ID2D1RadialGradientBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, float>)LpVtbl[14])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly float GetRadiusY()
        {
            var @this = (ID2D1RadialGradientBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, float>)LpVtbl[15])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetGradientStopCollection(ID2D1GradientStopCollection** gradientStopCollection)
        {
            var @this = (ID2D1RadialGradientBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, ID2D1GradientStopCollection**, void>)LpVtbl[16])(@this, gradientStopCollection);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetGradientStopCollection(ref ID2D1GradientStopCollection* gradientStopCollection)
        {
            var @this = (ID2D1RadialGradientBrush*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1GradientStopCollection** gradientStopCollectionPtr = &gradientStopCollection)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, ID2D1GradientStopCollection**, void>)LpVtbl[16])(@this, gradientStopCollectionPtr);
            }
        }

    }
}
