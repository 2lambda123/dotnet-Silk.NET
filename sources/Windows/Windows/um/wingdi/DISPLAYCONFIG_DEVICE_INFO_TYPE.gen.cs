// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DISPLAYCONFIG_DEVICE_INFO_TYPE.xml' path='doc/member[@name="DISPLAYCONFIG_DEVICE_INFO_TYPE"]/*'/>
public enum DISPLAYCONFIG_DEVICE_INFO_TYPE
{
    /// <include file='DISPLAYCONFIG_DEVICE_INFO_TYPE.xml' path='doc/member[@name="DISPLAYCONFIG_DEVICE_INFO_TYPE.DISPLAYCONFIG_DEVICE_INFO_GET_SOURCE_NAME"]/*'/>
    DISPLAYCONFIG_DEVICE_INFO_GET_SOURCE_NAME = 1,
    /// <include file='DISPLAYCONFIG_DEVICE_INFO_TYPE.xml' path='doc/member[@name="DISPLAYCONFIG_DEVICE_INFO_TYPE.DISPLAYCONFIG_DEVICE_INFO_GET_TARGET_NAME"]/*'/>
    DISPLAYCONFIG_DEVICE_INFO_GET_TARGET_NAME = 2,
    /// <include file='DISPLAYCONFIG_DEVICE_INFO_TYPE.xml' path='doc/member[@name="DISPLAYCONFIG_DEVICE_INFO_TYPE.DISPLAYCONFIG_DEVICE_INFO_GET_TARGET_PREFERRED_MODE"]/*'/>
    DISPLAYCONFIG_DEVICE_INFO_GET_TARGET_PREFERRED_MODE = 3,
    /// <include file='DISPLAYCONFIG_DEVICE_INFO_TYPE.xml' path='doc/member[@name="DISPLAYCONFIG_DEVICE_INFO_TYPE.DISPLAYCONFIG_DEVICE_INFO_GET_ADAPTER_NAME"]/*'/>
    DISPLAYCONFIG_DEVICE_INFO_GET_ADAPTER_NAME = 4,
    /// <include file='DISPLAYCONFIG_DEVICE_INFO_TYPE.xml' path='doc/member[@name="DISPLAYCONFIG_DEVICE_INFO_TYPE.DISPLAYCONFIG_DEVICE_INFO_SET_TARGET_PERSISTENCE"]/*'/>
    DISPLAYCONFIG_DEVICE_INFO_SET_TARGET_PERSISTENCE = 5,
    /// <include file='DISPLAYCONFIG_DEVICE_INFO_TYPE.xml' path='doc/member[@name="DISPLAYCONFIG_DEVICE_INFO_TYPE.DISPLAYCONFIG_DEVICE_INFO_GET_TARGET_BASE_TYPE"]/*'/>
    DISPLAYCONFIG_DEVICE_INFO_GET_TARGET_BASE_TYPE = 6,
    /// <include file='DISPLAYCONFIG_DEVICE_INFO_TYPE.xml' path='doc/member[@name="DISPLAYCONFIG_DEVICE_INFO_TYPE.DISPLAYCONFIG_DEVICE_INFO_GET_SUPPORT_VIRTUAL_RESOLUTION"]/*'/>
    DISPLAYCONFIG_DEVICE_INFO_GET_SUPPORT_VIRTUAL_RESOLUTION = 7,
    /// <include file='DISPLAYCONFIG_DEVICE_INFO_TYPE.xml' path='doc/member[@name="DISPLAYCONFIG_DEVICE_INFO_TYPE.DISPLAYCONFIG_DEVICE_INFO_SET_SUPPORT_VIRTUAL_RESOLUTION"]/*'/>
    DISPLAYCONFIG_DEVICE_INFO_SET_SUPPORT_VIRTUAL_RESOLUTION = 8,
    /// <include file='DISPLAYCONFIG_DEVICE_INFO_TYPE.xml' path='doc/member[@name="DISPLAYCONFIG_DEVICE_INFO_TYPE.DISPLAYCONFIG_DEVICE_INFO_GET_ADVANCED_COLOR_INFO"]/*'/>
    DISPLAYCONFIG_DEVICE_INFO_GET_ADVANCED_COLOR_INFO = 9,
    /// <include file='DISPLAYCONFIG_DEVICE_INFO_TYPE.xml' path='doc/member[@name="DISPLAYCONFIG_DEVICE_INFO_TYPE.DISPLAYCONFIG_DEVICE_INFO_SET_ADVANCED_COLOR_STATE"]/*'/>
    DISPLAYCONFIG_DEVICE_INFO_SET_ADVANCED_COLOR_STATE = 10,
    /// <include file='DISPLAYCONFIG_DEVICE_INFO_TYPE.xml' path='doc/member[@name="DISPLAYCONFIG_DEVICE_INFO_TYPE.DISPLAYCONFIG_DEVICE_INFO_GET_SDR_WHITE_LEVEL"]/*'/>
    DISPLAYCONFIG_DEVICE_INFO_GET_SDR_WHITE_LEVEL = 11,
    /// <include file='DISPLAYCONFIG_DEVICE_INFO_TYPE.xml' path='doc/member[@name="DISPLAYCONFIG_DEVICE_INFO_TYPE.DISPLAYCONFIG_DEVICE_INFO_GET_MONITOR_SPECIALIZATION"]/*'/>
    DISPLAYCONFIG_DEVICE_INFO_GET_MONITOR_SPECIALIZATION = 12,
    /// <include file='DISPLAYCONFIG_DEVICE_INFO_TYPE.xml' path='doc/member[@name="DISPLAYCONFIG_DEVICE_INFO_TYPE.DISPLAYCONFIG_DEVICE_INFO_SET_MONITOR_SPECIALIZATION"]/*'/>
    DISPLAYCONFIG_DEVICE_INFO_SET_MONITOR_SPECIALIZATION = 13,
    /// <include file='DISPLAYCONFIG_DEVICE_INFO_TYPE.xml' path='doc/member[@name="DISPLAYCONFIG_DEVICE_INFO_TYPE.DISPLAYCONFIG_DEVICE_INFO_FORCE_UINT32"]/*'/>
    DISPLAYCONFIG_DEVICE_INFO_FORCE_UINT32 = unchecked((int)(0xFFFFFFFF)),
}