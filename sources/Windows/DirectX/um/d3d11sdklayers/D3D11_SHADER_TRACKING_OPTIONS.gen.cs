// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11sdklayers.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D11_SHADER_TRACKING_OPTIONS.xml' path='doc/member[@name="D3D11_SHADER_TRACKING_OPTIONS"]/*'/>
[Flags]
[SupportedOSPlatform("windows6.2")]
public enum D3D11_SHADER_TRACKING_OPTIONS
{
    /// <include file='D3D11_SHADER_TRACKING_OPTIONS.xml' path='doc/member[@name="D3D11_SHADER_TRACKING_OPTIONS.D3D11_SHADER_TRACKING_OPTION_IGNORE"]/*'/>
    D3D11_SHADER_TRACKING_OPTION_IGNORE = 0,
    /// <include file='D3D11_SHADER_TRACKING_OPTIONS.xml' path='doc/member[@name="D3D11_SHADER_TRACKING_OPTIONS.D3D11_SHADER_TRACKING_OPTION_TRACK_UNINITIALIZED"]/*'/>
    D3D11_SHADER_TRACKING_OPTION_TRACK_UNINITIALIZED = 0x1,
    /// <include file='D3D11_SHADER_TRACKING_OPTIONS.xml' path='doc/member[@name="D3D11_SHADER_TRACKING_OPTIONS.D3D11_SHADER_TRACKING_OPTION_TRACK_RAW"]/*'/>
    D3D11_SHADER_TRACKING_OPTION_TRACK_RAW = 0x2,
    /// <include file='D3D11_SHADER_TRACKING_OPTIONS.xml' path='doc/member[@name="D3D11_SHADER_TRACKING_OPTIONS.D3D11_SHADER_TRACKING_OPTION_TRACK_WAR"]/*'/>
    D3D11_SHADER_TRACKING_OPTION_TRACK_WAR = 0x4,
    /// <include file='D3D11_SHADER_TRACKING_OPTIONS.xml' path='doc/member[@name="D3D11_SHADER_TRACKING_OPTIONS.D3D11_SHADER_TRACKING_OPTION_TRACK_WAW"]/*'/>
    D3D11_SHADER_TRACKING_OPTION_TRACK_WAW = 0x8,
    /// <include file='D3D11_SHADER_TRACKING_OPTIONS.xml' path='doc/member[@name="D3D11_SHADER_TRACKING_OPTIONS.D3D11_SHADER_TRACKING_OPTION_ALLOW_SAME"]/*'/>
    D3D11_SHADER_TRACKING_OPTION_ALLOW_SAME = 0x10,
    /// <include file='D3D11_SHADER_TRACKING_OPTIONS.xml' path='doc/member[@name="D3D11_SHADER_TRACKING_OPTIONS.D3D11_SHADER_TRACKING_OPTION_TRACK_ATOMIC_CONSISTENCY"]/*'/>
    D3D11_SHADER_TRACKING_OPTION_TRACK_ATOMIC_CONSISTENCY = 0x20,
    /// <include file='D3D11_SHADER_TRACKING_OPTIONS.xml' path='doc/member[@name="D3D11_SHADER_TRACKING_OPTIONS.D3D11_SHADER_TRACKING_OPTION_TRACK_RAW_ACROSS_THREADGROUPS"]/*'/>
    D3D11_SHADER_TRACKING_OPTION_TRACK_RAW_ACROSS_THREADGROUPS = 0x40,
    /// <include file='D3D11_SHADER_TRACKING_OPTIONS.xml' path='doc/member[@name="D3D11_SHADER_TRACKING_OPTIONS.D3D11_SHADER_TRACKING_OPTION_TRACK_WAR_ACROSS_THREADGROUPS"]/*'/>
    D3D11_SHADER_TRACKING_OPTION_TRACK_WAR_ACROSS_THREADGROUPS = 0x80,
    /// <include file='D3D11_SHADER_TRACKING_OPTIONS.xml' path='doc/member[@name="D3D11_SHADER_TRACKING_OPTIONS.D3D11_SHADER_TRACKING_OPTION_TRACK_WAW_ACROSS_THREADGROUPS"]/*'/>
    D3D11_SHADER_TRACKING_OPTION_TRACK_WAW_ACROSS_THREADGROUPS = 0x100,
    /// <include file='D3D11_SHADER_TRACKING_OPTIONS.xml' path='doc/member[@name="D3D11_SHADER_TRACKING_OPTIONS.D3D11_SHADER_TRACKING_OPTION_TRACK_ATOMIC_CONSISTENCY_ACROSS_THREADGROUPS"]/*'/>
    D3D11_SHADER_TRACKING_OPTION_TRACK_ATOMIC_CONSISTENCY_ACROSS_THREADGROUPS = 0x200,
    /// <include file='D3D11_SHADER_TRACKING_OPTIONS.xml' path='doc/member[@name="D3D11_SHADER_TRACKING_OPTIONS.D3D11_SHADER_TRACKING_OPTION_UAV_SPECIFIC_FLAGS"]/*'/>
    D3D11_SHADER_TRACKING_OPTION_UAV_SPECIFIC_FLAGS = (((D3D11_SHADER_TRACKING_OPTION_TRACK_RAW_ACROSS_THREADGROUPS | D3D11_SHADER_TRACKING_OPTION_TRACK_WAR_ACROSS_THREADGROUPS) | D3D11_SHADER_TRACKING_OPTION_TRACK_WAW_ACROSS_THREADGROUPS) | D3D11_SHADER_TRACKING_OPTION_TRACK_ATOMIC_CONSISTENCY_ACROSS_THREADGROUPS),
    /// <include file='D3D11_SHADER_TRACKING_OPTIONS.xml' path='doc/member[@name="D3D11_SHADER_TRACKING_OPTIONS.D3D11_SHADER_TRACKING_OPTION_ALL_HAZARDS"]/*'/>
    D3D11_SHADER_TRACKING_OPTION_ALL_HAZARDS = (((((((D3D11_SHADER_TRACKING_OPTION_TRACK_RAW | D3D11_SHADER_TRACKING_OPTION_TRACK_WAR) | D3D11_SHADER_TRACKING_OPTION_TRACK_WAW) | D3D11_SHADER_TRACKING_OPTION_TRACK_ATOMIC_CONSISTENCY) | D3D11_SHADER_TRACKING_OPTION_TRACK_RAW_ACROSS_THREADGROUPS) | D3D11_SHADER_TRACKING_OPTION_TRACK_WAR_ACROSS_THREADGROUPS) | D3D11_SHADER_TRACKING_OPTION_TRACK_WAW_ACROSS_THREADGROUPS) | D3D11_SHADER_TRACKING_OPTION_TRACK_ATOMIC_CONSISTENCY_ACROSS_THREADGROUPS),
    /// <include file='D3D11_SHADER_TRACKING_OPTIONS.xml' path='doc/member[@name="D3D11_SHADER_TRACKING_OPTIONS.D3D11_SHADER_TRACKING_OPTION_ALL_HAZARDS_ALLOWING_SAME"]/*'/>
    D3D11_SHADER_TRACKING_OPTION_ALL_HAZARDS_ALLOWING_SAME = (D3D11_SHADER_TRACKING_OPTION_ALL_HAZARDS | D3D11_SHADER_TRACKING_OPTION_ALLOW_SAME),
    /// <include file='D3D11_SHADER_TRACKING_OPTIONS.xml' path='doc/member[@name="D3D11_SHADER_TRACKING_OPTIONS.D3D11_SHADER_TRACKING_OPTION_ALL_OPTIONS"]/*'/>
    D3D11_SHADER_TRACKING_OPTION_ALL_OPTIONS = (D3D11_SHADER_TRACKING_OPTION_ALL_HAZARDS_ALLOWING_SAME | D3D11_SHADER_TRACKING_OPTION_TRACK_UNINITIALIZED),
}