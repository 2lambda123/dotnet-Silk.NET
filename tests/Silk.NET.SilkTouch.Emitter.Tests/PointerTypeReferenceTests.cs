// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SilkTouch.Symbols;
using Xunit;

namespace Silk.NET.SilkTouch.Emitter.Tests;

public class PointerTypeReferenceTests : EmitterTest
{
    [Fact, Trait("Category", "Symbols")]
    public void StringTest()
    {
        var symbol = new PointerTypeReference(new ExternalTypeReference(null, new IdentifierSymbol("ETR1")));

        var transformed = Transform(symbol);

        Assert.Equal("ETR1*", transformed.ToFullString());
    }
}
