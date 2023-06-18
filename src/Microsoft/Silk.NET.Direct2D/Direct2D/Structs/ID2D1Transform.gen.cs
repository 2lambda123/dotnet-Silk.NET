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
    [Guid("ef1a287d-342a-4f76-8fdb-da0d6ea9f92b")]
    [NativeName("Name", "ID2D1Transform")]
    public unsafe partial struct ID2D1Transform : IComVtbl<ID2D1Transform>, IComVtbl<ID2D1TransformNode>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("ef1a287d-342a-4f76-8fdb-da0d6ea9f92b");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID2D1TransformNode(ID2D1Transform val)
            => Unsafe.As<ID2D1Transform, ID2D1TransformNode>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1Transform val)
            => Unsafe.As<ID2D1Transform, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1Transform
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
            var @this = (ID2D1Transform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Transform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1Transform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Transform*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1Transform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Transform*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetInputCount()
        {
            var @this = (ID2D1Transform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Transform*, uint>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapOutputRectToInputRects([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRect, Silk.NET.Maths.Box2D<int>* inputRects, uint inputRectsCount)
        {
            var @this = (ID2D1Transform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Transform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, int>)@this->LpVtbl[4])(@this, outputRect, inputRects, inputRectsCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapInputRectsToOutputRect([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
        {
            var @this = (ID2D1Transform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Transform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRects, inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapInvalidRect(uint inputIndex, Silk.NET.Maths.Box2D<int> invalidInputRect, Silk.NET.Maths.Box2D<int>* invalidOutputRect)
        {
            var @this = (ID2D1Transform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Transform*, uint, Silk.NET.Maths.Box2D<int>, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[6])(@this, inputIndex, invalidInputRect, invalidOutputRect);
            return ret;
        }

    }
}
