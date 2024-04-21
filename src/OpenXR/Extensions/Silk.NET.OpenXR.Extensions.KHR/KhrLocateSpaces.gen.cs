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
using Silk.NET.OpenXR;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.KHR
{
    [Extension("XR_KHR_locate_spaces")]
    public unsafe partial class KhrLocateSpaces : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_KHR_locate_spaces";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateSpacesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateSpaces([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpacesLocateInfo* locateInfo, [Count(Count = 0)] SpaceLocations* spaceLocations);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateSpacesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateSpaces([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpacesLocateInfo* locateInfo, [Count(Count = 0)] ref SpaceLocations spaceLocations);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateSpacesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateSpaces([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpacesLocateInfo locateInfo, [Count(Count = 0)] SpaceLocations* spaceLocations);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateSpacesKHR", Convention = CallingConvention.Winapi)]
        public partial Result LocateSpaces([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpacesLocateInfo locateInfo, [Count(Count = 0)] ref SpaceLocations spaceLocations);

        public KhrLocateSpaces(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

