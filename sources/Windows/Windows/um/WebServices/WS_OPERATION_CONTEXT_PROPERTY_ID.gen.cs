// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WS_OPERATION_CONTEXT_PROPERTY_ID.xml' path='doc/member[@name="WS_OPERATION_CONTEXT_PROPERTY_ID"]/*'/>
public enum WS_OPERATION_CONTEXT_PROPERTY_ID
{
    /// <include file='WS_OPERATION_CONTEXT_PROPERTY_ID.xml' path='doc/member[@name="WS_OPERATION_CONTEXT_PROPERTY_ID.WS_OPERATION_CONTEXT_PROPERTY_CHANNEL"]/*'/>
    WS_OPERATION_CONTEXT_PROPERTY_CHANNEL = 0,
    /// <include file='WS_OPERATION_CONTEXT_PROPERTY_ID.xml' path='doc/member[@name="WS_OPERATION_CONTEXT_PROPERTY_ID.WS_OPERATION_CONTEXT_PROPERTY_CONTRACT_DESCRIPTION"]/*'/>
    WS_OPERATION_CONTEXT_PROPERTY_CONTRACT_DESCRIPTION = 1,
    /// <include file='WS_OPERATION_CONTEXT_PROPERTY_ID.xml' path='doc/member[@name="WS_OPERATION_CONTEXT_PROPERTY_ID.WS_OPERATION_CONTEXT_PROPERTY_HOST_USER_STATE"]/*'/>
    WS_OPERATION_CONTEXT_PROPERTY_HOST_USER_STATE = 2,
    /// <include file='WS_OPERATION_CONTEXT_PROPERTY_ID.xml' path='doc/member[@name="WS_OPERATION_CONTEXT_PROPERTY_ID.WS_OPERATION_CONTEXT_PROPERTY_CHANNEL_USER_STATE"]/*'/>
    WS_OPERATION_CONTEXT_PROPERTY_CHANNEL_USER_STATE = 3,
    /// <include file='WS_OPERATION_CONTEXT_PROPERTY_ID.xml' path='doc/member[@name="WS_OPERATION_CONTEXT_PROPERTY_ID.WS_OPERATION_CONTEXT_PROPERTY_INPUT_MESSAGE"]/*'/>
    WS_OPERATION_CONTEXT_PROPERTY_INPUT_MESSAGE = 4,
    /// <include file='WS_OPERATION_CONTEXT_PROPERTY_ID.xml' path='doc/member[@name="WS_OPERATION_CONTEXT_PROPERTY_ID.WS_OPERATION_CONTEXT_PROPERTY_OUTPUT_MESSAGE"]/*'/>
    WS_OPERATION_CONTEXT_PROPERTY_OUTPUT_MESSAGE = 5,
    /// <include file='WS_OPERATION_CONTEXT_PROPERTY_ID.xml' path='doc/member[@name="WS_OPERATION_CONTEXT_PROPERTY_ID.WS_OPERATION_CONTEXT_PROPERTY_HEAP"]/*'/>
    WS_OPERATION_CONTEXT_PROPERTY_HEAP = 6,
    /// <include file='WS_OPERATION_CONTEXT_PROPERTY_ID.xml' path='doc/member[@name="WS_OPERATION_CONTEXT_PROPERTY_ID.WS_OPERATION_CONTEXT_PROPERTY_LISTENER"]/*'/>
    WS_OPERATION_CONTEXT_PROPERTY_LISTENER = 7,
    /// <include file='WS_OPERATION_CONTEXT_PROPERTY_ID.xml' path='doc/member[@name="WS_OPERATION_CONTEXT_PROPERTY_ID.WS_OPERATION_CONTEXT_PROPERTY_ENDPOINT_ADDRESS"]/*'/>
    WS_OPERATION_CONTEXT_PROPERTY_ENDPOINT_ADDRESS = 8,
}