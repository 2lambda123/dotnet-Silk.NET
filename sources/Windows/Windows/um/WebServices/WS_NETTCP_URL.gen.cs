// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WS_NETTCP_URL.xml' path='doc/member[@name="WS_NETTCP_URL"]/*'/>
public partial struct WS_NETTCP_URL
{
    /// <include file='WS_NETTCP_URL.xml' path='doc/member[@name="WS_NETTCP_URL.url"]/*'/>
    public WS_URL url;
    /// <include file='WS_NETTCP_URL.xml' path='doc/member[@name="WS_NETTCP_URL.host"]/*'/>
    public WS_STRING host;
    /// <include file='WS_NETTCP_URL.xml' path='doc/member[@name="WS_NETTCP_URL.port"]/*'/>
    public ushort port;
    /// <include file='WS_NETTCP_URL.xml' path='doc/member[@name="WS_NETTCP_URL.portAsString"]/*'/>
    public WS_STRING portAsString;
    /// <include file='WS_NETTCP_URL.xml' path='doc/member[@name="WS_NETTCP_URL.path"]/*'/>
    public WS_STRING path;
    /// <include file='WS_NETTCP_URL.xml' path='doc/member[@name="WS_NETTCP_URL.query"]/*'/>
    public WS_STRING query;
    /// <include file='WS_NETTCP_URL.xml' path='doc/member[@name="WS_NETTCP_URL.fragment"]/*'/>
    public WS_STRING fragment;
}