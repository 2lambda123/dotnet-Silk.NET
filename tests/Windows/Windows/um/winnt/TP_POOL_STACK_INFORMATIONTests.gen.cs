// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "TP_POOL_STACK_INFORMATION"/> struct.</summary>
public static unsafe partial class TP_POOL_STACK_INFORMATIONTests
{
    /// <summary>Validates that the <see cref = "TP_POOL_STACK_INFORMATION"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TP_POOL_STACK_INFORMATION>(), Is.EqualTo(sizeof(TP_POOL_STACK_INFORMATION)));
    }

    /// <summary>Validates that the <see cref = "TP_POOL_STACK_INFORMATION"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TP_POOL_STACK_INFORMATION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "TP_POOL_STACK_INFORMATION"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(TP_POOL_STACK_INFORMATION), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(TP_POOL_STACK_INFORMATION), Is.EqualTo(8));
        }
    }
}