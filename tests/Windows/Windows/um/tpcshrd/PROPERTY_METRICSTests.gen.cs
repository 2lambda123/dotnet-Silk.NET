// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/tpcshrd.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "PROPERTY_METRICS"/> struct.</summary>
public static unsafe partial class PROPERTY_METRICSTests
{
    /// <summary>Validates that the <see cref = "PROPERTY_METRICS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PROPERTY_METRICS>(), Is.EqualTo(sizeof(PROPERTY_METRICS)));
    }

    /// <summary>Validates that the <see cref = "PROPERTY_METRICS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PROPERTY_METRICS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PROPERTY_METRICS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(PROPERTY_METRICS), Is.EqualTo(16));
    }
}