// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "COLORMAP"/> struct.</summary>
public static unsafe partial class COLORMAPTests
{
    /// <summary>Validates that the <see cref = "COLORMAP"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<COLORMAP>(), Is.EqualTo(sizeof(COLORMAP)));
    }

    /// <summary>Validates that the <see cref = "COLORMAP"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(COLORMAP).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "COLORMAP"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(COLORMAP), Is.EqualTo(8));
    }
}