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

namespace Silk.NET.DirectComposition;

public unsafe static class DCompositionRotateTransform3DVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionRotateTransform3D> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform3D*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDCompositionRotateTransform3D> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform3D*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDCompositionRotateTransform3D> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform3D*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetAngle(this ComPtr<IDCompositionRotateTransform3D> thisVtbl, float angle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform3D*, float, int>)@this->LpVtbl[4])(@this, angle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetAxisX(this ComPtr<IDCompositionRotateTransform3D> thisVtbl, float axisX)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform3D*, float, int>)@this->LpVtbl[6])(@this, axisX);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetAxisY(this ComPtr<IDCompositionRotateTransform3D> thisVtbl, float axisY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform3D*, float, int>)@this->LpVtbl[8])(@this, axisY);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetAxisZ(this ComPtr<IDCompositionRotateTransform3D> thisVtbl, float axisZ)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform3D*, float, int>)@this->LpVtbl[10])(@this, axisZ);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetCenterX(this ComPtr<IDCompositionRotateTransform3D> thisVtbl, float centerX)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform3D*, float, int>)@this->LpVtbl[12])(@this, centerX);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetCenterY(this ComPtr<IDCompositionRotateTransform3D> thisVtbl, float centerY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform3D*, float, int>)@this->LpVtbl[14])(@this, centerY);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetCenterZ(this ComPtr<IDCompositionRotateTransform3D> thisVtbl, float centerZ)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform3D*, float, int>)@this->LpVtbl[16])(@this, centerZ);
        return ret;
    }

}
