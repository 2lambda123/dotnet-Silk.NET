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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV;

[Extension("NV_point_sprite")]
public unsafe partial class NVPointSprite : NativeExtension<GL>
{
    public const string ExtensionName = "NV_point_sprite";
    [NativeApi(EntryPoint = "glPointParameteriNV")]
    public partial void PointParameter([Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] int param);

    [NativeApi(EntryPoint = "glPointParameteriNV")]
    public partial void PointParameter([Flow(FlowDirection.In)] PointParameterNameARB pname, [Flow(FlowDirection.In)] int param);

    [NativeApi(EntryPoint = "glPointParameterivNV")]
    public unsafe partial void PointParameter([Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

    [NativeApi(EntryPoint = "glPointParameterivNV")]
    public partial void PointParameter([Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

    [NativeApi(EntryPoint = "glPointParameterivNV")]
    public unsafe partial void PointParameter([Flow(FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

    [NativeApi(EntryPoint = "glPointParameterivNV")]
    public partial void PointParameter([Flow(FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

    public NVPointSprite(INativeContext ctx)
        : base(ctx)
    {
    }
}

