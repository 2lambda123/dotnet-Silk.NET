// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "WSAMSG"/> struct.</summary>
public static unsafe partial class WSAMSGTests
{
    /// <summary>Validates that the <see cref = "WSAMSG"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WSAMSG>(), Is.EqualTo(sizeof(WSAMSG)));
    }

    /// <summary>Validates that the <see cref = "WSAMSG"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WSAMSG).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WSAMSG"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(WSAMSG), Is.EqualTo(56));
        }
        else
        {
            Assert.That(sizeof(WSAMSG), Is.EqualTo(28));
        }
    }
}