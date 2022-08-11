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
    [Guid("94f81a73-9212-4376-9c58-b16a3a0d3992")]
    [NativeName("Name", "ID2D1Factory2")]
    public unsafe partial struct ID2D1Factory2
    {
        public static readonly Guid Guid = new("94f81a73-9212-4376-9c58-b16a3a0d3992");

        public static implicit operator ID2D1Factory1(ID2D1Factory2 val)
            => Unsafe.As<ID2D1Factory2, ID2D1Factory1>(ref val);

        public static implicit operator ID2D1Factory(ID2D1Factory2 val)
            => Unsafe.As<ID2D1Factory2, ID2D1Factory>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1Factory2 val)
            => Unsafe.As<ID2D1Factory2, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1Factory2
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
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ReloadSystemMetrics()
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, int>)LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDesktopDpi(float* dpiX, float* dpiY)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, float*, float*, void>)LpVtbl[4])(@this, dpiX, dpiY);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDesktopDpi(float* dpiX, ref float dpiY)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* dpiYPtr = &dpiY)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, float*, float*, void>)LpVtbl[4])(@this, dpiX, dpiYPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDesktopDpi(ref float dpiX, float* dpiY)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* dpiXPtr = &dpiX)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, float*, float*, void>)LpVtbl[4])(@this, dpiXPtr, dpiY);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void GetDesktopDpi(ref float dpiX, ref float dpiY)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* dpiXPtr = &dpiX)
            {
                fixed (float* dpiYPtr = &dpiY)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, float*, float*, void>)LpVtbl[4])(@this, dpiXPtr, dpiYPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRectangleGeometry(Silk.NET.Maths.Box2D<float>* rectangle, ID2D1RectangleGeometry** rectangleGeometry)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Silk.NET.Maths.Box2D<float>*, ID2D1RectangleGeometry**, int>)LpVtbl[5])(@this, rectangle, rectangleGeometry);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRectangleGeometry(Silk.NET.Maths.Box2D<float>* rectangle, ref ID2D1RectangleGeometry* rectangleGeometry)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1RectangleGeometry** rectangleGeometryPtr = &rectangleGeometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Silk.NET.Maths.Box2D<float>*, ID2D1RectangleGeometry**, int>)LpVtbl[5])(@this, rectangle, rectangleGeometryPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRectangleGeometry(ref Silk.NET.Maths.Box2D<float> rectangle, ID2D1RectangleGeometry** rectangleGeometry)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* rectanglePtr = &rectangle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Silk.NET.Maths.Box2D<float>*, ID2D1RectangleGeometry**, int>)LpVtbl[5])(@this, rectanglePtr, rectangleGeometry);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRectangleGeometry(ref Silk.NET.Maths.Box2D<float> rectangle, ref ID2D1RectangleGeometry* rectangleGeometry)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* rectanglePtr = &rectangle)
            {
                fixed (ID2D1RectangleGeometry** rectangleGeometryPtr = &rectangleGeometry)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Silk.NET.Maths.Box2D<float>*, ID2D1RectangleGeometry**, int>)LpVtbl[5])(@this, rectanglePtr, rectangleGeometryPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRoundedRectangleGeometry(RoundedRect* roundedRectangle, ID2D1RoundedRectangleGeometry** roundedRectangleGeometry)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, RoundedRect*, ID2D1RoundedRectangleGeometry**, int>)LpVtbl[6])(@this, roundedRectangle, roundedRectangleGeometry);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRoundedRectangleGeometry(RoundedRect* roundedRectangle, ref ID2D1RoundedRectangleGeometry* roundedRectangleGeometry)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1RoundedRectangleGeometry** roundedRectangleGeometryPtr = &roundedRectangleGeometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, RoundedRect*, ID2D1RoundedRectangleGeometry**, int>)LpVtbl[6])(@this, roundedRectangle, roundedRectangleGeometryPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRoundedRectangleGeometry(ref RoundedRect roundedRectangle, ID2D1RoundedRectangleGeometry** roundedRectangleGeometry)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RoundedRect* roundedRectanglePtr = &roundedRectangle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, RoundedRect*, ID2D1RoundedRectangleGeometry**, int>)LpVtbl[6])(@this, roundedRectanglePtr, roundedRectangleGeometry);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRoundedRectangleGeometry(ref RoundedRect roundedRectangle, ref ID2D1RoundedRectangleGeometry* roundedRectangleGeometry)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RoundedRect* roundedRectanglePtr = &roundedRectangle)
            {
                fixed (ID2D1RoundedRectangleGeometry** roundedRectangleGeometryPtr = &roundedRectangleGeometry)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, RoundedRect*, ID2D1RoundedRectangleGeometry**, int>)LpVtbl[6])(@this, roundedRectanglePtr, roundedRectangleGeometryPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEllipseGeometry(Ellipse* ellipse, ID2D1EllipseGeometry** ellipseGeometry)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Ellipse*, ID2D1EllipseGeometry**, int>)LpVtbl[7])(@this, ellipse, ellipseGeometry);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEllipseGeometry(Ellipse* ellipse, ref ID2D1EllipseGeometry* ellipseGeometry)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1EllipseGeometry** ellipseGeometryPtr = &ellipseGeometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Ellipse*, ID2D1EllipseGeometry**, int>)LpVtbl[7])(@this, ellipse, ellipseGeometryPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEllipseGeometry(ref Ellipse ellipse, ID2D1EllipseGeometry** ellipseGeometry)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Ellipse* ellipsePtr = &ellipse)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Ellipse*, ID2D1EllipseGeometry**, int>)LpVtbl[7])(@this, ellipsePtr, ellipseGeometry);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEllipseGeometry(ref Ellipse ellipse, ref ID2D1EllipseGeometry* ellipseGeometry)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Ellipse* ellipsePtr = &ellipse)
            {
                fixed (ID2D1EllipseGeometry** ellipseGeometryPtr = &ellipseGeometry)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Ellipse*, ID2D1EllipseGeometry**, int>)LpVtbl[7])(@this, ellipsePtr, ellipseGeometryPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGeometryGroup(FillMode fillMode, ID2D1Geometry** geometries, uint geometriesCount, ID2D1GeometryGroup** geometryGroup)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, FillMode, ID2D1Geometry**, uint, ID2D1GeometryGroup**, int>)LpVtbl[8])(@this, fillMode, geometries, geometriesCount, geometryGroup);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGeometryGroup(FillMode fillMode, ID2D1Geometry** geometries, uint geometriesCount, ref ID2D1GeometryGroup* geometryGroup)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1GeometryGroup** geometryGroupPtr = &geometryGroup)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, FillMode, ID2D1Geometry**, uint, ID2D1GeometryGroup**, int>)LpVtbl[8])(@this, fillMode, geometries, geometriesCount, geometryGroupPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGeometryGroup(FillMode fillMode, ref ID2D1Geometry* geometries, uint geometriesCount, ID2D1GeometryGroup** geometryGroup)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry** geometriesPtr = &geometries)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, FillMode, ID2D1Geometry**, uint, ID2D1GeometryGroup**, int>)LpVtbl[8])(@this, fillMode, geometriesPtr, geometriesCount, geometryGroup);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGeometryGroup(FillMode fillMode, ref ID2D1Geometry* geometries, uint geometriesCount, ref ID2D1GeometryGroup* geometryGroup)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry** geometriesPtr = &geometries)
            {
                fixed (ID2D1GeometryGroup** geometryGroupPtr = &geometryGroup)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, FillMode, ID2D1Geometry**, uint, ID2D1GeometryGroup**, int>)LpVtbl[8])(@this, fillMode, geometriesPtr, geometriesCount, geometryGroupPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedGeometry(ID2D1Geometry* sourceGeometry, Silk.NET.Maths.Matrix3X2<float>* transform, ID2D1TransformedGeometry** transformedGeometry)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)LpVtbl[9])(@this, sourceGeometry, transform, transformedGeometry);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedGeometry(ID2D1Geometry* sourceGeometry, Silk.NET.Maths.Matrix3X2<float>* transform, ref ID2D1TransformedGeometry* transformedGeometry)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1TransformedGeometry** transformedGeometryPtr = &transformedGeometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)LpVtbl[9])(@this, sourceGeometry, transform, transformedGeometryPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedGeometry(ID2D1Geometry* sourceGeometry, ref Silk.NET.Maths.Matrix3X2<float> transform, ID2D1TransformedGeometry** transformedGeometry)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)LpVtbl[9])(@this, sourceGeometry, transformPtr, transformedGeometry);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedGeometry(ID2D1Geometry* sourceGeometry, ref Silk.NET.Maths.Matrix3X2<float> transform, ref ID2D1TransformedGeometry* transformedGeometry)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
            {
                fixed (ID2D1TransformedGeometry** transformedGeometryPtr = &transformedGeometry)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)LpVtbl[9])(@this, sourceGeometry, transformPtr, transformedGeometryPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedGeometry(ref ID2D1Geometry sourceGeometry, Silk.NET.Maths.Matrix3X2<float>* transform, ID2D1TransformedGeometry** transformedGeometry)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* sourceGeometryPtr = &sourceGeometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)LpVtbl[9])(@this, sourceGeometryPtr, transform, transformedGeometry);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedGeometry(ref ID2D1Geometry sourceGeometry, Silk.NET.Maths.Matrix3X2<float>* transform, ref ID2D1TransformedGeometry* transformedGeometry)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* sourceGeometryPtr = &sourceGeometry)
            {
                fixed (ID2D1TransformedGeometry** transformedGeometryPtr = &transformedGeometry)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)LpVtbl[9])(@this, sourceGeometryPtr, transform, transformedGeometryPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedGeometry(ref ID2D1Geometry sourceGeometry, ref Silk.NET.Maths.Matrix3X2<float> transform, ID2D1TransformedGeometry** transformedGeometry)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* sourceGeometryPtr = &sourceGeometry)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)LpVtbl[9])(@this, sourceGeometryPtr, transformPtr, transformedGeometry);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedGeometry(ref ID2D1Geometry sourceGeometry, ref Silk.NET.Maths.Matrix3X2<float> transform, ref ID2D1TransformedGeometry* transformedGeometry)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* sourceGeometryPtr = &sourceGeometry)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
                {
                    fixed (ID2D1TransformedGeometry** transformedGeometryPtr = &transformedGeometry)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)LpVtbl[9])(@this, sourceGeometryPtr, transformPtr, transformedGeometryPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePathGeometry(ID2D1PathGeometry** pathGeometry)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, ID2D1PathGeometry**, int>)LpVtbl[10])(@this, pathGeometry);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePathGeometry(ref ID2D1PathGeometry* pathGeometry)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1PathGeometry** pathGeometryPtr = &pathGeometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, ID2D1PathGeometry**, int>)LpVtbl[10])(@this, pathGeometryPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokeStyle(StrokeStyleProperties* strokeStyleProperties, float* dashes, uint dashesCount, ID2D1StrokeStyle** strokeStyle)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)LpVtbl[11])(@this, strokeStyleProperties, dashes, dashesCount, strokeStyle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokeStyle(StrokeStyleProperties* strokeStyleProperties, float* dashes, uint dashesCount, ref ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1StrokeStyle** strokeStylePtr = &strokeStyle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)LpVtbl[11])(@this, strokeStyleProperties, dashes, dashesCount, strokeStylePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokeStyle(StrokeStyleProperties* strokeStyleProperties, ref float dashes, uint dashesCount, ID2D1StrokeStyle** strokeStyle)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* dashesPtr = &dashes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)LpVtbl[11])(@this, strokeStyleProperties, dashesPtr, dashesCount, strokeStyle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokeStyle(StrokeStyleProperties* strokeStyleProperties, ref float dashes, uint dashesCount, ref ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* dashesPtr = &dashes)
            {
                fixed (ID2D1StrokeStyle** strokeStylePtr = &strokeStyle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)LpVtbl[11])(@this, strokeStyleProperties, dashesPtr, dashesCount, strokeStylePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokeStyle(ref StrokeStyleProperties strokeStyleProperties, float* dashes, uint dashesCount, ID2D1StrokeStyle** strokeStyle)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StrokeStyleProperties* strokeStylePropertiesPtr = &strokeStyleProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)LpVtbl[11])(@this, strokeStylePropertiesPtr, dashes, dashesCount, strokeStyle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokeStyle(ref StrokeStyleProperties strokeStyleProperties, float* dashes, uint dashesCount, ref ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StrokeStyleProperties* strokeStylePropertiesPtr = &strokeStyleProperties)
            {
                fixed (ID2D1StrokeStyle** strokeStylePtr = &strokeStyle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)LpVtbl[11])(@this, strokeStylePropertiesPtr, dashes, dashesCount, strokeStylePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokeStyle(ref StrokeStyleProperties strokeStyleProperties, ref float dashes, uint dashesCount, ID2D1StrokeStyle** strokeStyle)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StrokeStyleProperties* strokeStylePropertiesPtr = &strokeStyleProperties)
            {
                fixed (float* dashesPtr = &dashes)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)LpVtbl[11])(@this, strokeStylePropertiesPtr, dashesPtr, dashesCount, strokeStyle);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokeStyle(ref StrokeStyleProperties strokeStyleProperties, ref float dashes, uint dashesCount, ref ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StrokeStyleProperties* strokeStylePropertiesPtr = &strokeStyleProperties)
            {
                fixed (float* dashesPtr = &dashes)
                {
                    fixed (ID2D1StrokeStyle** strokeStylePtr = &strokeStyle)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)LpVtbl[11])(@this, strokeStylePropertiesPtr, dashesPtr, dashesCount, strokeStylePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDrawingStateBlock(DrawingStateDescription* drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ID2D1DrawingStateBlock** drawingStateBlock)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, DrawingStateDescription*, IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)LpVtbl[12])(@this, drawingStateDescription, textRenderingParams, drawingStateBlock);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDrawingStateBlock(DrawingStateDescription* drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ref ID2D1DrawingStateBlock* drawingStateBlock)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1DrawingStateBlock** drawingStateBlockPtr = &drawingStateBlock)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, DrawingStateDescription*, IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)LpVtbl[12])(@this, drawingStateDescription, textRenderingParams, drawingStateBlockPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDrawingStateBlock(DrawingStateDescription* drawingStateDescription, ref IDWriteRenderingParams textRenderingParams, ID2D1DrawingStateBlock** drawingStateBlock)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteRenderingParams* textRenderingParamsPtr = &textRenderingParams)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, DrawingStateDescription*, IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)LpVtbl[12])(@this, drawingStateDescription, textRenderingParamsPtr, drawingStateBlock);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDrawingStateBlock(DrawingStateDescription* drawingStateDescription, ref IDWriteRenderingParams textRenderingParams, ref ID2D1DrawingStateBlock* drawingStateBlock)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteRenderingParams* textRenderingParamsPtr = &textRenderingParams)
            {
                fixed (ID2D1DrawingStateBlock** drawingStateBlockPtr = &drawingStateBlock)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, DrawingStateDescription*, IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)LpVtbl[12])(@this, drawingStateDescription, textRenderingParamsPtr, drawingStateBlockPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDrawingStateBlock(ref DrawingStateDescription drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ID2D1DrawingStateBlock** drawingStateBlock)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DrawingStateDescription* drawingStateDescriptionPtr = &drawingStateDescription)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, DrawingStateDescription*, IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)LpVtbl[12])(@this, drawingStateDescriptionPtr, textRenderingParams, drawingStateBlock);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDrawingStateBlock(ref DrawingStateDescription drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ref ID2D1DrawingStateBlock* drawingStateBlock)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DrawingStateDescription* drawingStateDescriptionPtr = &drawingStateDescription)
            {
                fixed (ID2D1DrawingStateBlock** drawingStateBlockPtr = &drawingStateBlock)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, DrawingStateDescription*, IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)LpVtbl[12])(@this, drawingStateDescriptionPtr, textRenderingParams, drawingStateBlockPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDrawingStateBlock(ref DrawingStateDescription drawingStateDescription, ref IDWriteRenderingParams textRenderingParams, ID2D1DrawingStateBlock** drawingStateBlock)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DrawingStateDescription* drawingStateDescriptionPtr = &drawingStateDescription)
            {
                fixed (IDWriteRenderingParams* textRenderingParamsPtr = &textRenderingParams)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, DrawingStateDescription*, IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)LpVtbl[12])(@this, drawingStateDescriptionPtr, textRenderingParamsPtr, drawingStateBlock);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDrawingStateBlock(ref DrawingStateDescription drawingStateDescription, ref IDWriteRenderingParams textRenderingParams, ref ID2D1DrawingStateBlock* drawingStateBlock)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DrawingStateDescription* drawingStateDescriptionPtr = &drawingStateDescription)
            {
                fixed (IDWriteRenderingParams* textRenderingParamsPtr = &textRenderingParams)
                {
                    fixed (ID2D1DrawingStateBlock** drawingStateBlockPtr = &drawingStateBlock)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, DrawingStateDescription*, IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)LpVtbl[12])(@this, drawingStateDescriptionPtr, textRenderingParamsPtr, drawingStateBlockPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWicBitmapRenderTarget(IWICBitmap* target, RenderTargetProperties* renderTargetProperties, ID2D1RenderTarget** renderTarget)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, IWICBitmap*, RenderTargetProperties*, ID2D1RenderTarget**, int>)LpVtbl[13])(@this, target, renderTargetProperties, renderTarget);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWicBitmapRenderTarget(IWICBitmap* target, RenderTargetProperties* renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1RenderTarget** renderTargetPtr = &renderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, IWICBitmap*, RenderTargetProperties*, ID2D1RenderTarget**, int>)LpVtbl[13])(@this, target, renderTargetProperties, renderTargetPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWicBitmapRenderTarget(IWICBitmap* target, ref RenderTargetProperties renderTargetProperties, ID2D1RenderTarget** renderTarget)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, IWICBitmap*, RenderTargetProperties*, ID2D1RenderTarget**, int>)LpVtbl[13])(@this, target, renderTargetPropertiesPtr, renderTarget);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWicBitmapRenderTarget(IWICBitmap* target, ref RenderTargetProperties renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                fixed (ID2D1RenderTarget** renderTargetPtr = &renderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, IWICBitmap*, RenderTargetProperties*, ID2D1RenderTarget**, int>)LpVtbl[13])(@this, target, renderTargetPropertiesPtr, renderTargetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWicBitmapRenderTarget(ref IWICBitmap target, RenderTargetProperties* renderTargetProperties, ID2D1RenderTarget** renderTarget)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmap* targetPtr = &target)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, IWICBitmap*, RenderTargetProperties*, ID2D1RenderTarget**, int>)LpVtbl[13])(@this, targetPtr, renderTargetProperties, renderTarget);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWicBitmapRenderTarget(ref IWICBitmap target, RenderTargetProperties* renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmap* targetPtr = &target)
            {
                fixed (ID2D1RenderTarget** renderTargetPtr = &renderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, IWICBitmap*, RenderTargetProperties*, ID2D1RenderTarget**, int>)LpVtbl[13])(@this, targetPtr, renderTargetProperties, renderTargetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWicBitmapRenderTarget(ref IWICBitmap target, ref RenderTargetProperties renderTargetProperties, ID2D1RenderTarget** renderTarget)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmap* targetPtr = &target)
            {
                fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, IWICBitmap*, RenderTargetProperties*, ID2D1RenderTarget**, int>)LpVtbl[13])(@this, targetPtr, renderTargetPropertiesPtr, renderTarget);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWicBitmapRenderTarget(ref IWICBitmap target, ref RenderTargetProperties renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmap* targetPtr = &target)
            {
                fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
                {
                    fixed (ID2D1RenderTarget** renderTargetPtr = &renderTarget)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, IWICBitmap*, RenderTargetProperties*, ID2D1RenderTarget**, int>)LpVtbl[13])(@this, targetPtr, renderTargetPropertiesPtr, renderTargetPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHwndRenderTarget(RenderTargetProperties* renderTargetProperties, HwndRenderTargetProperties* hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)LpVtbl[14])(@this, renderTargetProperties, hwndRenderTargetProperties, hwndRenderTarget);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHwndRenderTarget(RenderTargetProperties* renderTargetProperties, HwndRenderTargetProperties* hwndRenderTargetProperties, ref ID2D1HwndRenderTarget* hwndRenderTarget)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1HwndRenderTarget** hwndRenderTargetPtr = &hwndRenderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)LpVtbl[14])(@this, renderTargetProperties, hwndRenderTargetProperties, hwndRenderTargetPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHwndRenderTarget(RenderTargetProperties* renderTargetProperties, ref HwndRenderTargetProperties hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HwndRenderTargetProperties* hwndRenderTargetPropertiesPtr = &hwndRenderTargetProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)LpVtbl[14])(@this, renderTargetProperties, hwndRenderTargetPropertiesPtr, hwndRenderTarget);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHwndRenderTarget(RenderTargetProperties* renderTargetProperties, ref HwndRenderTargetProperties hwndRenderTargetProperties, ref ID2D1HwndRenderTarget* hwndRenderTarget)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HwndRenderTargetProperties* hwndRenderTargetPropertiesPtr = &hwndRenderTargetProperties)
            {
                fixed (ID2D1HwndRenderTarget** hwndRenderTargetPtr = &hwndRenderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)LpVtbl[14])(@this, renderTargetProperties, hwndRenderTargetPropertiesPtr, hwndRenderTargetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHwndRenderTarget(ref RenderTargetProperties renderTargetProperties, HwndRenderTargetProperties* hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)LpVtbl[14])(@this, renderTargetPropertiesPtr, hwndRenderTargetProperties, hwndRenderTarget);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHwndRenderTarget(ref RenderTargetProperties renderTargetProperties, HwndRenderTargetProperties* hwndRenderTargetProperties, ref ID2D1HwndRenderTarget* hwndRenderTarget)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                fixed (ID2D1HwndRenderTarget** hwndRenderTargetPtr = &hwndRenderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)LpVtbl[14])(@this, renderTargetPropertiesPtr, hwndRenderTargetProperties, hwndRenderTargetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHwndRenderTarget(ref RenderTargetProperties renderTargetProperties, ref HwndRenderTargetProperties hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                fixed (HwndRenderTargetProperties* hwndRenderTargetPropertiesPtr = &hwndRenderTargetProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)LpVtbl[14])(@this, renderTargetPropertiesPtr, hwndRenderTargetPropertiesPtr, hwndRenderTarget);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHwndRenderTarget(ref RenderTargetProperties renderTargetProperties, ref HwndRenderTargetProperties hwndRenderTargetProperties, ref ID2D1HwndRenderTarget* hwndRenderTarget)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                fixed (HwndRenderTargetProperties* hwndRenderTargetPropertiesPtr = &hwndRenderTargetProperties)
                {
                    fixed (ID2D1HwndRenderTarget** hwndRenderTargetPtr = &hwndRenderTarget)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)LpVtbl[14])(@this, renderTargetPropertiesPtr, hwndRenderTargetPropertiesPtr, hwndRenderTargetPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDxgiSurfaceRenderTarget(Silk.NET.DXGI.IDXGISurface* dxgiSurface, RenderTargetProperties* renderTargetProperties, ID2D1RenderTarget** renderTarget)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)LpVtbl[15])(@this, dxgiSurface, renderTargetProperties, renderTarget);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDxgiSurfaceRenderTarget(Silk.NET.DXGI.IDXGISurface* dxgiSurface, RenderTargetProperties* renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1RenderTarget** renderTargetPtr = &renderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)LpVtbl[15])(@this, dxgiSurface, renderTargetProperties, renderTargetPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDxgiSurfaceRenderTarget(Silk.NET.DXGI.IDXGISurface* dxgiSurface, ref RenderTargetProperties renderTargetProperties, ID2D1RenderTarget** renderTarget)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)LpVtbl[15])(@this, dxgiSurface, renderTargetPropertiesPtr, renderTarget);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDxgiSurfaceRenderTarget(Silk.NET.DXGI.IDXGISurface* dxgiSurface, ref RenderTargetProperties renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                fixed (ID2D1RenderTarget** renderTargetPtr = &renderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)LpVtbl[15])(@this, dxgiSurface, renderTargetPropertiesPtr, renderTargetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDxgiSurfaceRenderTarget(ref Silk.NET.DXGI.IDXGISurface dxgiSurface, RenderTargetProperties* renderTargetProperties, ID2D1RenderTarget** renderTarget)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGISurface* dxgiSurfacePtr = &dxgiSurface)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)LpVtbl[15])(@this, dxgiSurfacePtr, renderTargetProperties, renderTarget);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDxgiSurfaceRenderTarget(ref Silk.NET.DXGI.IDXGISurface dxgiSurface, RenderTargetProperties* renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGISurface* dxgiSurfacePtr = &dxgiSurface)
            {
                fixed (ID2D1RenderTarget** renderTargetPtr = &renderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)LpVtbl[15])(@this, dxgiSurfacePtr, renderTargetProperties, renderTargetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDxgiSurfaceRenderTarget(ref Silk.NET.DXGI.IDXGISurface dxgiSurface, ref RenderTargetProperties renderTargetProperties, ID2D1RenderTarget** renderTarget)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGISurface* dxgiSurfacePtr = &dxgiSurface)
            {
                fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)LpVtbl[15])(@this, dxgiSurfacePtr, renderTargetPropertiesPtr, renderTarget);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDxgiSurfaceRenderTarget(ref Silk.NET.DXGI.IDXGISurface dxgiSurface, ref RenderTargetProperties renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGISurface* dxgiSurfacePtr = &dxgiSurface)
            {
                fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
                {
                    fixed (ID2D1RenderTarget** renderTargetPtr = &renderTarget)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)LpVtbl[15])(@this, dxgiSurfacePtr, renderTargetPropertiesPtr, renderTargetPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDCRenderTarget(RenderTargetProperties* renderTargetProperties, ID2D1DCRenderTarget** dcRenderTarget)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, RenderTargetProperties*, ID2D1DCRenderTarget**, int>)LpVtbl[16])(@this, renderTargetProperties, dcRenderTarget);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDCRenderTarget(RenderTargetProperties* renderTargetProperties, ref ID2D1DCRenderTarget* dcRenderTarget)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1DCRenderTarget** dcRenderTargetPtr = &dcRenderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, RenderTargetProperties*, ID2D1DCRenderTarget**, int>)LpVtbl[16])(@this, renderTargetProperties, dcRenderTargetPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDCRenderTarget(ref RenderTargetProperties renderTargetProperties, ID2D1DCRenderTarget** dcRenderTarget)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, RenderTargetProperties*, ID2D1DCRenderTarget**, int>)LpVtbl[16])(@this, renderTargetPropertiesPtr, dcRenderTarget);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDCRenderTarget(ref RenderTargetProperties renderTargetProperties, ref ID2D1DCRenderTarget* dcRenderTarget)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                fixed (ID2D1DCRenderTarget** dcRenderTargetPtr = &dcRenderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, RenderTargetProperties*, ID2D1DCRenderTarget**, int>)LpVtbl[16])(@this, renderTargetPropertiesPtr, dcRenderTargetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDevice(Silk.NET.DXGI.IDXGIDevice* dxgiDevice, ID2D1Device** d2dDevice)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Silk.NET.DXGI.IDXGIDevice*, ID2D1Device**, int>)LpVtbl[17])(@this, dxgiDevice, d2dDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDevice(Silk.NET.DXGI.IDXGIDevice* dxgiDevice, ref ID2D1Device* d2dDevice)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Device** d2dDevicePtr = &d2dDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Silk.NET.DXGI.IDXGIDevice*, ID2D1Device**, int>)LpVtbl[17])(@this, dxgiDevice, d2dDevicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDevice(ref Silk.NET.DXGI.IDXGIDevice dxgiDevice, ID2D1Device** d2dDevice)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGIDevice* dxgiDevicePtr = &dxgiDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Silk.NET.DXGI.IDXGIDevice*, ID2D1Device**, int>)LpVtbl[17])(@this, dxgiDevicePtr, d2dDevice);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDevice(ref Silk.NET.DXGI.IDXGIDevice dxgiDevice, ref ID2D1Device* d2dDevice)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGIDevice* dxgiDevicePtr = &dxgiDevice)
            {
                fixed (ID2D1Device** d2dDevicePtr = &d2dDevice)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Silk.NET.DXGI.IDXGIDevice*, ID2D1Device**, int>)LpVtbl[17])(@this, dxgiDevicePtr, d2dDevicePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiMetafile(Silk.NET.Core.Native.IStream* metafileStream, ID2D1GdiMetafile** metafile)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Silk.NET.Core.Native.IStream*, ID2D1GdiMetafile**, int>)LpVtbl[18])(@this, metafileStream, metafile);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiMetafile(Silk.NET.Core.Native.IStream* metafileStream, ref ID2D1GdiMetafile* metafile)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1GdiMetafile** metafilePtr = &metafile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Silk.NET.Core.Native.IStream*, ID2D1GdiMetafile**, int>)LpVtbl[18])(@this, metafileStream, metafilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiMetafile(ref Silk.NET.Core.Native.IStream metafileStream, ID2D1GdiMetafile** metafile)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IStream* metafileStreamPtr = &metafileStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Silk.NET.Core.Native.IStream*, ID2D1GdiMetafile**, int>)LpVtbl[18])(@this, metafileStreamPtr, metafile);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiMetafile(ref Silk.NET.Core.Native.IStream metafileStream, ref ID2D1GdiMetafile* metafile)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IStream* metafileStreamPtr = &metafileStream)
            {
                fixed (ID2D1GdiMetafile** metafilePtr = &metafile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Silk.NET.Core.Native.IStream*, ID2D1GdiMetafile**, int>)LpVtbl[18])(@this, metafileStreamPtr, metafilePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterEffectFromStream(Guid* classId, Silk.NET.Core.Native.IStream* propertyXml, PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, Silk.NET.Core.Native.IStream*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)LpVtbl[19])(@this, classId, propertyXml, bindings, bindingsCount, effectFactory);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterEffectFromStream(Guid* classId, Silk.NET.Core.Native.IStream* propertyXml, ref PropertyBinding bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PropertyBinding* bindingsPtr = &bindings)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, Silk.NET.Core.Native.IStream*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)LpVtbl[19])(@this, classId, propertyXml, bindingsPtr, bindingsCount, effectFactory);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterEffectFromStream(Guid* classId, ref Silk.NET.Core.Native.IStream propertyXml, PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IStream* propertyXmlPtr = &propertyXml)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, Silk.NET.Core.Native.IStream*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)LpVtbl[19])(@this, classId, propertyXmlPtr, bindings, bindingsCount, effectFactory);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterEffectFromStream(Guid* classId, ref Silk.NET.Core.Native.IStream propertyXml, ref PropertyBinding bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IStream* propertyXmlPtr = &propertyXml)
            {
                fixed (PropertyBinding* bindingsPtr = &bindings)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, Silk.NET.Core.Native.IStream*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)LpVtbl[19])(@this, classId, propertyXmlPtr, bindingsPtr, bindingsCount, effectFactory);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterEffectFromStream(ref Guid classId, Silk.NET.Core.Native.IStream* propertyXml, PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* classIdPtr = &classId)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, Silk.NET.Core.Native.IStream*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)LpVtbl[19])(@this, classIdPtr, propertyXml, bindings, bindingsCount, effectFactory);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterEffectFromStream(ref Guid classId, Silk.NET.Core.Native.IStream* propertyXml, ref PropertyBinding bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* classIdPtr = &classId)
            {
                fixed (PropertyBinding* bindingsPtr = &bindings)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, Silk.NET.Core.Native.IStream*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)LpVtbl[19])(@this, classIdPtr, propertyXml, bindingsPtr, bindingsCount, effectFactory);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterEffectFromStream(ref Guid classId, ref Silk.NET.Core.Native.IStream propertyXml, PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* classIdPtr = &classId)
            {
                fixed (Silk.NET.Core.Native.IStream* propertyXmlPtr = &propertyXml)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, Silk.NET.Core.Native.IStream*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)LpVtbl[19])(@this, classIdPtr, propertyXmlPtr, bindings, bindingsCount, effectFactory);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterEffectFromStream(ref Guid classId, ref Silk.NET.Core.Native.IStream propertyXml, ref PropertyBinding bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* classIdPtr = &classId)
            {
                fixed (Silk.NET.Core.Native.IStream* propertyXmlPtr = &propertyXml)
                {
                    fixed (PropertyBinding* bindingsPtr = &bindings)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, Silk.NET.Core.Native.IStream*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)LpVtbl[19])(@this, classIdPtr, propertyXmlPtr, bindingsPtr, bindingsCount, effectFactory);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterEffectFromString(Guid* classId, char* propertyXml, PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, char*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)LpVtbl[20])(@this, classId, propertyXml, bindings, bindingsCount, effectFactory);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterEffectFromString(Guid* classId, char* propertyXml, ref PropertyBinding bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PropertyBinding* bindingsPtr = &bindings)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, char*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)LpVtbl[20])(@this, classId, propertyXml, bindingsPtr, bindingsCount, effectFactory);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterEffectFromString(Guid* classId, ref char propertyXml, PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* propertyXmlPtr = &propertyXml)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, char*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)LpVtbl[20])(@this, classId, propertyXmlPtr, bindings, bindingsCount, effectFactory);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterEffectFromString(Guid* classId, ref char propertyXml, ref PropertyBinding bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* propertyXmlPtr = &propertyXml)
            {
                fixed (PropertyBinding* bindingsPtr = &bindings)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, char*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)LpVtbl[20])(@this, classId, propertyXmlPtr, bindingsPtr, bindingsCount, effectFactory);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterEffectFromString(Guid* classId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string propertyXml, PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var propertyXmlPtr = (byte*) SilkMarshal.StringToPtr(propertyXml, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, byte*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)LpVtbl[20])(@this, classId, propertyXmlPtr, bindings, bindingsCount, effectFactory);
            SilkMarshal.Free((nint)propertyXmlPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterEffectFromString(Guid* classId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string propertyXml, ref PropertyBinding bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var propertyXmlPtr = (byte*) SilkMarshal.StringToPtr(propertyXml, NativeStringEncoding.UTF8);
            fixed (PropertyBinding* bindingsPtr = &bindings)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, byte*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)LpVtbl[20])(@this, classId, propertyXmlPtr, bindingsPtr, bindingsCount, effectFactory);
            }
            SilkMarshal.Free((nint)propertyXmlPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterEffectFromString(ref Guid classId, char* propertyXml, PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* classIdPtr = &classId)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, char*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)LpVtbl[20])(@this, classIdPtr, propertyXml, bindings, bindingsCount, effectFactory);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterEffectFromString(ref Guid classId, char* propertyXml, ref PropertyBinding bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* classIdPtr = &classId)
            {
                fixed (PropertyBinding* bindingsPtr = &bindings)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, char*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)LpVtbl[20])(@this, classIdPtr, propertyXml, bindingsPtr, bindingsCount, effectFactory);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterEffectFromString(ref Guid classId, ref char propertyXml, PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* classIdPtr = &classId)
            {
                fixed (char* propertyXmlPtr = &propertyXml)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, char*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)LpVtbl[20])(@this, classIdPtr, propertyXmlPtr, bindings, bindingsCount, effectFactory);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterEffectFromString(ref Guid classId, ref char propertyXml, ref PropertyBinding bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* classIdPtr = &classId)
            {
                fixed (char* propertyXmlPtr = &propertyXml)
                {
                    fixed (PropertyBinding* bindingsPtr = &bindings)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, char*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)LpVtbl[20])(@this, classIdPtr, propertyXmlPtr, bindingsPtr, bindingsCount, effectFactory);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterEffectFromString(ref Guid classId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string propertyXml, PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* classIdPtr = &classId)
            {
            var propertyXmlPtr = (byte*) SilkMarshal.StringToPtr(propertyXml, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, byte*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)LpVtbl[20])(@this, classIdPtr, propertyXmlPtr, bindings, bindingsCount, effectFactory);
            SilkMarshal.Free((nint)propertyXmlPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterEffectFromString(ref Guid classId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string propertyXml, ref PropertyBinding bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* classIdPtr = &classId)
            {
            var propertyXmlPtr = (byte*) SilkMarshal.StringToPtr(propertyXml, NativeStringEncoding.UTF8);
                fixed (PropertyBinding* bindingsPtr = &bindings)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, byte*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)LpVtbl[20])(@this, classIdPtr, propertyXmlPtr, bindingsPtr, bindingsCount, effectFactory);
                }
            SilkMarshal.Free((nint)propertyXmlPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UnregisterEffect(Guid* classId)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, int>)LpVtbl[21])(@this, classId);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int UnregisterEffect(ref Guid classId)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* classIdPtr = &classId)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, int>)LpVtbl[21])(@this, classIdPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRegisteredEffects(Guid* effects, uint effectsCount, uint* effectsReturned, uint* effectsRegistered)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, uint, uint*, uint*, int>)LpVtbl[22])(@this, effects, effectsCount, effectsReturned, effectsRegistered);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRegisteredEffects(Guid* effects, uint effectsCount, uint* effectsReturned, ref uint effectsRegistered)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* effectsRegisteredPtr = &effectsRegistered)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, uint, uint*, uint*, int>)LpVtbl[22])(@this, effects, effectsCount, effectsReturned, effectsRegisteredPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRegisteredEffects(Guid* effects, uint effectsCount, ref uint effectsReturned, uint* effectsRegistered)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* effectsReturnedPtr = &effectsReturned)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, uint, uint*, uint*, int>)LpVtbl[22])(@this, effects, effectsCount, effectsReturnedPtr, effectsRegistered);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRegisteredEffects(Guid* effects, uint effectsCount, ref uint effectsReturned, ref uint effectsRegistered)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* effectsReturnedPtr = &effectsReturned)
            {
                fixed (uint* effectsRegisteredPtr = &effectsRegistered)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, uint, uint*, uint*, int>)LpVtbl[22])(@this, effects, effectsCount, effectsReturnedPtr, effectsRegisteredPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRegisteredEffects(ref Guid effects, uint effectsCount, uint* effectsReturned, uint* effectsRegistered)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* effectsPtr = &effects)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, uint, uint*, uint*, int>)LpVtbl[22])(@this, effectsPtr, effectsCount, effectsReturned, effectsRegistered);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRegisteredEffects(ref Guid effects, uint effectsCount, uint* effectsReturned, ref uint effectsRegistered)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* effectsPtr = &effects)
            {
                fixed (uint* effectsRegisteredPtr = &effectsRegistered)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, uint, uint*, uint*, int>)LpVtbl[22])(@this, effectsPtr, effectsCount, effectsReturned, effectsRegisteredPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRegisteredEffects(ref Guid effects, uint effectsCount, ref uint effectsReturned, uint* effectsRegistered)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* effectsPtr = &effects)
            {
                fixed (uint* effectsReturnedPtr = &effectsReturned)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, uint, uint*, uint*, int>)LpVtbl[22])(@this, effectsPtr, effectsCount, effectsReturnedPtr, effectsRegistered);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRegisteredEffects(ref Guid effects, uint effectsCount, ref uint effectsReturned, ref uint effectsRegistered)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* effectsPtr = &effects)
            {
                fixed (uint* effectsReturnedPtr = &effectsReturned)
                {
                    fixed (uint* effectsRegisteredPtr = &effectsRegistered)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, uint, uint*, uint*, int>)LpVtbl[22])(@this, effectsPtr, effectsCount, effectsReturnedPtr, effectsRegisteredPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEffectProperties(Guid* effectId, ID2D1Properties** properties)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, ID2D1Properties**, int>)LpVtbl[23])(@this, effectId, properties);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEffectProperties(Guid* effectId, ref ID2D1Properties* properties)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Properties** propertiesPtr = &properties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, ID2D1Properties**, int>)LpVtbl[23])(@this, effectId, propertiesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEffectProperties(ref Guid effectId, ID2D1Properties** properties)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* effectIdPtr = &effectId)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, ID2D1Properties**, int>)LpVtbl[23])(@this, effectIdPtr, properties);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEffectProperties(ref Guid effectId, ref ID2D1Properties* properties)
        {
            var @this = (ID2D1Factory2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* effectIdPtr = &effectId)
            {
                fixed (ID2D1Properties** propertiesPtr = &properties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory2*, Guid*, ID2D1Properties**, int>)LpVtbl[23])(@this, effectIdPtr, propertiesPtr);
                }
            }
            return ret;
        }

    }
}
