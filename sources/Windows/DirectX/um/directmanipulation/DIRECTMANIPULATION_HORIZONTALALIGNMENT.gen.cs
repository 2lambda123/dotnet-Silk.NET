// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;
/// <include file='DIRECTMANIPULATION_HORIZONTALALIGNMENT.xml' path='doc/member[@name="DIRECTMANIPULATION_HORIZONTALALIGNMENT"]/*'/>
[Flags]
[SupportedOSPlatform("windows6.2")]
public enum DIRECTMANIPULATION_HORIZONTALALIGNMENT
{
    /// <include file='DIRECTMANIPULATION_HORIZONTALALIGNMENT.xml' path='doc/member[@name="DIRECTMANIPULATION_HORIZONTALALIGNMENT.DIRECTMANIPULATION_HORIZONTALALIGNMENT_NONE"]/*'/>
    DIRECTMANIPULATION_HORIZONTALALIGNMENT_NONE = 0,
    /// <include file='DIRECTMANIPULATION_HORIZONTALALIGNMENT.xml' path='doc/member[@name="DIRECTMANIPULATION_HORIZONTALALIGNMENT.DIRECTMANIPULATION_HORIZONTALALIGNMENT_LEFT"]/*'/>
    DIRECTMANIPULATION_HORIZONTALALIGNMENT_LEFT = 0x1,
    /// <include file='DIRECTMANIPULATION_HORIZONTALALIGNMENT.xml' path='doc/member[@name="DIRECTMANIPULATION_HORIZONTALALIGNMENT.DIRECTMANIPULATION_HORIZONTALALIGNMENT_CENTER"]/*'/>
    DIRECTMANIPULATION_HORIZONTALALIGNMENT_CENTER = 0x2,
    /// <include file='DIRECTMANIPULATION_HORIZONTALALIGNMENT.xml' path='doc/member[@name="DIRECTMANIPULATION_HORIZONTALALIGNMENT.DIRECTMANIPULATION_HORIZONTALALIGNMENT_RIGHT"]/*'/>
    DIRECTMANIPULATION_HORIZONTALALIGNMENT_RIGHT = 0x4,
    /// <include file='DIRECTMANIPULATION_HORIZONTALALIGNMENT.xml' path='doc/member[@name="DIRECTMANIPULATION_HORIZONTALALIGNMENT.DIRECTMANIPULATION_HORIZONTALALIGNMENT_UNLOCKCENTER"]/*'/>
    DIRECTMANIPULATION_HORIZONTALALIGNMENT_UNLOCKCENTER = 0x8,
}