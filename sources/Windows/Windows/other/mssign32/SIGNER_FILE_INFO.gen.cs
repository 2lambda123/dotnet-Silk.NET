// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
namespace TerraFX.Interop.Windows;
/// <include file='SIGNER_FILE_INFO.xml' path='doc/member[@name="SIGNER_FILE_INFO"]/*'/>
public unsafe partial struct SIGNER_FILE_INFO
{
    /// <include file='SIGNER_FILE_INFO.xml' path='doc/member[@name="SIGNER_FILE_INFO.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='SIGNER_FILE_INFO.xml' path='doc/member[@name="SIGNER_FILE_INFO.pwszFileName"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* pwszFileName;
    /// <include file='SIGNER_FILE_INFO.xml' path='doc/member[@name="SIGNER_FILE_INFO.hFile"]/*'/>
    public HANDLE hFile;
}