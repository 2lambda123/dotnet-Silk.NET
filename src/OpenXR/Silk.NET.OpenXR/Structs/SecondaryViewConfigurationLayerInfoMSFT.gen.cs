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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSecondaryViewConfigurationLayerInfoMSFT")]
    public unsafe partial struct SecondaryViewConfigurationLayerInfoMSFT
    {
        public SecondaryViewConfigurationLayerInfoMSFT
        (
            StructureType? type = StructureType.TypeSecondaryViewConfigurationLayerInfoMsft,
            void* next = null,
            ViewConfigurationType? viewConfigurationType = null,
            EnvironmentBlendMode? environmentBlendMode = null,
            uint? layerCount = null,
            CompositionLayerBaseHeader** layers = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (viewConfigurationType is not null)
            {
                ViewConfigurationType = viewConfigurationType.Value;
            }

            if (environmentBlendMode is not null)
            {
                EnvironmentBlendMode = environmentBlendMode.Value;
            }

            if (layerCount is not null)
            {
                LayerCount = layerCount.Value;
            }

            if (layers is not null)
            {
                Layers = layers;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "XrViewConfigurationType")]
        [NativeName("Type.Name", "XrViewConfigurationType")]
        [NativeName("Name", "viewConfigurationType")]
        public ViewConfigurationType ViewConfigurationType;
/// <summary></summary>
        [NativeName("Type", "XrEnvironmentBlendMode")]
        [NativeName("Type.Name", "XrEnvironmentBlendMode")]
        [NativeName("Name", "environmentBlendMode")]
        public EnvironmentBlendMode EnvironmentBlendMode;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "layerCount")]
        public uint LayerCount;
/// <summary></summary>
        [NativeName("Type", "XrCompositionLayerBaseHeader**")]
        [NativeName("Type.Name", "XrCompositionLayerBaseHeader")]
        [NativeName("Name", "layers")]
        public CompositionLayerBaseHeader** Layers;
    }
}
