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

namespace Silk.NET.OpenXR.Extensions.OCULUS
{
    [Extension("XR_OCULUS_audio_device_guid")]
    public unsafe partial class OculusAudioDeviceGuid : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_OCULUS_audio_device_guid";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetAudioInputDeviceGuidOculus")]
        public partial Result GetAudioInputDeviceGuidOcul([Count(Count = 0)] Instance instance, [Count(Count = 0)] wchar_t buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetAudioOutputDeviceGuidOculus")]
        public partial Result GetAudioOutputDeviceGuidOcul([Count(Count = 0)] Instance instance, [Count(Count = 0)] wchar_t buffer);

        public OculusAudioDeviceGuid(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

