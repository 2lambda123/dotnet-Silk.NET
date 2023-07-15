// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE"]/*'/>
[SupportedOSPlatform("windows10.0.19041.0")]
public enum D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE
{
    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE.D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_CREATION"]/*'/>
    D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_CREATION = 0,
    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE.D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_INITIALIZATION"]/*'/>
    D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_INITIALIZATION = 1,
    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE.D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_EXECUTION"]/*'/>
    D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_EXECUTION = 2,
    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE.D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_CAPS_INPUT"]/*'/>
    D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_CAPS_INPUT = 3,
    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE.D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_CAPS_OUTPUT"]/*'/>
    D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_CAPS_OUTPUT = 4,
    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE.D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_DEVICE_EXECUTE_INPUT"]/*'/>
    D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_DEVICE_EXECUTE_INPUT = 5,
    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE.D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_DEVICE_EXECUTE_OUTPUT"]/*'/>
    D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_DEVICE_EXECUTE_OUTPUT = 6,
}