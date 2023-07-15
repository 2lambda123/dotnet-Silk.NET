// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "NMKEY"/> struct.</summary>
public static unsafe partial class NMKEYTests
{
    /// <summary>Validates that the <see cref = "NMKEY"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<NMKEY>(), Is.EqualTo(sizeof(NMKEY)));
    }

    /// <summary>Validates that the <see cref = "NMKEY"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(NMKEY).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "NMKEY"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(NMKEY), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(NMKEY), Is.EqualTo(20));
        }
    }
}