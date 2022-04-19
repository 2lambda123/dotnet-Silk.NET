// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Moq;
using Moq.Protected;
using Xunit;

namespace Silk.NET.SilkTouch.Symbols.Tests.SymbolVisitorTests;

public class StructTests
{
    [Fact]
    public void StructSymbolIsVisitedAsType()
    {
        var symbol = new StructSymbol(new IdentifierSymbol(""));
        var visitor = new Mock<SymbolVisitor>
        {
            CallBase = true
        };

        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<TypeSymbol>("VisitType", Times.Once(), ItExpr.IsAny<TypeSymbol>());
    }

    [Fact]
    public void StructSymbolIsVisitedAsStruct()
    {
        var symbol = new StructSymbol(new IdentifierSymbol(""));
        var visitor = new Mock<SymbolVisitor>
        {
            CallBase = true
        };

        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<StructSymbol>("VisitStruct", Times.Once(), ItExpr.IsAny<StructSymbol>());
    }

    [Fact]
    public void StructIdentifierIsVisitedAsIdentifier()
    {
        var symbol = new StructSymbol(new IdentifierSymbol(""));
        var visitor = new Mock<SymbolVisitor>
        {
            CallBase = true
        };

        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<IdentifierSymbol>("VisitIdentifier", Times.Once(), ItExpr.IsAny<IdentifierSymbol>());
    }

    [Fact]
    public void StructMemberIsVisited()
    {
        var member = new FieldSymbol(new StructSymbol(new IdentifierSymbol("int")), new IdentifierSymbol("Test1"));
        var symbol = new StructSymbol(new IdentifierSymbol("Test"), new[]
        {
            member
        });
        var visitor = new Mock<SymbolVisitor>
        {
            CallBase = true
        };

        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<Symbol>("Visit", Times.Once(), ItExpr.Is<Symbol>(x => x == member));
    }

    [Fact]
    public void StructMembersAreVisited()
    {
        var member1 = new FieldSymbol(new StructSymbol(new IdentifierSymbol("int")), new IdentifierSymbol("Test1"));
        var member2 = new FieldSymbol(new StructSymbol(new IdentifierSymbol("int")), new IdentifierSymbol("Test2"));
        var symbol = new StructSymbol(new IdentifierSymbol("Test"), new[]
        {
            member1,
            member2
        });
        var visitor = new Mock<SymbolVisitor>
        {
            CallBase = true
        };

        visitor.Object.Visit(symbol);
        
        visitor.Protected()
            .Verify<Symbol>("Visit", Times.Once(), ItExpr.Is<Symbol>(x => x == member1));
        
        visitor.Protected()
            .Verify<Symbol>("Visit", Times.Once(), ItExpr.Is<Symbol>(x => x == member2));
    }
}
