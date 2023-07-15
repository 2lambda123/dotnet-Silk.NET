// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Msi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='INSTALLFEATUREATTRIBUTE.xml' path='doc/member[@name="INSTALLFEATUREATTRIBUTE"]/*'/>
public enum INSTALLFEATUREATTRIBUTE
{
    /// <include file='INSTALLFEATUREATTRIBUTE.xml' path='doc/member[@name="INSTALLFEATUREATTRIBUTE.INSTALLFEATUREATTRIBUTE_FAVORLOCAL"]/*'/>
    INSTALLFEATUREATTRIBUTE_FAVORLOCAL = 1 << 0,
    /// <include file='INSTALLFEATUREATTRIBUTE.xml' path='doc/member[@name="INSTALLFEATUREATTRIBUTE.INSTALLFEATUREATTRIBUTE_FAVORSOURCE"]/*'/>
    INSTALLFEATUREATTRIBUTE_FAVORSOURCE = 1 << 1,
    /// <include file='INSTALLFEATUREATTRIBUTE.xml' path='doc/member[@name="INSTALLFEATUREATTRIBUTE.INSTALLFEATUREATTRIBUTE_FOLLOWPARENT"]/*'/>
    INSTALLFEATUREATTRIBUTE_FOLLOWPARENT = 1 << 2,
    /// <include file='INSTALLFEATUREATTRIBUTE.xml' path='doc/member[@name="INSTALLFEATUREATTRIBUTE.INSTALLFEATUREATTRIBUTE_FAVORADVERTISE"]/*'/>
    INSTALLFEATUREATTRIBUTE_FAVORADVERTISE = 1 << 3,
    /// <include file='INSTALLFEATUREATTRIBUTE.xml' path='doc/member[@name="INSTALLFEATUREATTRIBUTE.INSTALLFEATUREATTRIBUTE_DISALLOWADVERTISE"]/*'/>
    INSTALLFEATUREATTRIBUTE_DISALLOWADVERTISE = 1 << 4,
    /// <include file='INSTALLFEATUREATTRIBUTE.xml' path='doc/member[@name="INSTALLFEATUREATTRIBUTE.INSTALLFEATUREATTRIBUTE_NOUNSUPPORTEDADVERTISE"]/*'/>
    INSTALLFEATUREATTRIBUTE_NOUNSUPPORTEDADVERTISE = 1 << 5,
}