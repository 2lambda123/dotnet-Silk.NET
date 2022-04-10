﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// Implements a base visitor to extend when rewriting or otherwise searching through a <see cref="Symbol"/>
/// </summary>
public abstract class SymbolVisitor
{
    /// <summary>
    /// Visit a <see cref="Symbol"/>. This will call the appropriate method based on the actual type of the <paramref name="symbol"/>
    /// </summary>
    /// <param name="symbol">The symbol to visit</param>
    /// <returns>The rewritten symbol. May be equal to the original symbol of no rewriting has taken place.</returns>
    public virtual Symbol Visit(Symbol symbol)
    {
        if (symbol is TypeSymbol ts) return VisitType(ts);

        return ThrowUnknownSymbol(nameof(Symbol), symbol);
    }

    /// <summary>
    /// Visit a <see cref="TypeSymbol"/>. This will call the appropriate method based on the actual type of the <paramref name="typeSymbol"/>
    /// </summary>
    /// <param name="typeSymbol">The type symbol to visit</param>
    /// <returns>The rewritten symbol. May or may not be a <see cref="TypeSymbol"/></returns>
    /// <seealso cref="VisitStruct"/>
    protected virtual Symbol VisitType(TypeSymbol typeSymbol)
    {
        if (typeSymbol is StructSymbol @struct) return VisitStruct(@struct);

        return ThrowUnknownSymbol(nameof(TypeSymbol), typeSymbol);
    }
    
    /// <summary>
    /// Visit a <see cref="StructSymbol"/>. Will call the appropriate methods to visit the different parts of the struct.
    /// </summary>
    /// <param name="structSymbol">The struct symbol to visit</param>
    /// <returns>The rewritten symbol. May or may not be a <see cref="StructSymbol"/></returns>
    /// <seealso cref="VisitType"/>
    /// <remarks>
    /// The order in which the parts of the struct are visited is kept as an implementation detail. Do not rely on this order.
    /// </remarks>
    protected virtual Symbol VisitStruct(StructSymbol structSymbol)
    {
        return new StructSymbol(VisitIdentifier(structSymbol.Identifier));
    }

    /// <summary>
    /// Visit an <see cref="IdentifierSymbol"/>.
    /// </summary>
    /// <param name="identifierSymbol">The Identifier to Visit</param>
    /// <returns>The rewritten symbol</returns>
    protected virtual IdentifierSymbol VisitIdentifier(IdentifierSymbol identifierSymbol)
    {
        return identifierSymbol;
    }

    private static Symbol ThrowUnknownSymbol(string type, Symbol symbol)
    {
        throw new NotImplementedException($"Unknown symbol of type {symbol.GetType().FullName} subclass of {type}");
    }
}
