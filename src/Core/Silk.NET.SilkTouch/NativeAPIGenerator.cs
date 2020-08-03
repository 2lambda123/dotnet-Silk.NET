// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Silk.NET.Core.Native;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch
{
    [Generator]
    public class NativeAPIGenerator : ISourceGenerator
    {
        private static volatile int _slot = 0;
        
        public void Initialize(InitializationContext context)
        {
            context.RegisterForSyntaxNotifications(() => new SyntaxReceiver());
        }

        public void Execute(SourceGeneratorContext context)
        {
            Debugger.Launch();
            if (!(context.SyntaxReceiver is SyntaxReceiver receiver))
                return;

            var nativeApiAttribute = context.Compilation.GetTypeByMetadataName("Silk.NET.Core.Native.NativeApiAttribute");
            
            if (nativeApiAttribute is null)
                return;

            foreach (var receiverClassDeclaration in receiver.ClassDeclarations)
            {
                var s = ProcessClassDeclaration(receiverClassDeclaration, context.Compilation, nativeApiAttribute);
                
                if (s is null) continue;

                var name = $"{receiverClassDeclaration.Identifier.Text}.gen.cs.gen";
                context.AddSource(name, SourceText.From(s, Encoding.UTF8));
                File.WriteAllText(name, s);
            }
        }

        private string ProcessClassDeclaration
            (ClassDeclarationSyntax classDeclaration, Compilation compilation, INamedTypeSymbol nativeApiAttributeSymbol)
        {
            if (!classDeclaration.Modifiers.Any(x => x.IsKind(SyntaxKind.PartialKeyword)))
                return null;

            if (!classDeclaration.Parent.IsKind(SyntaxKind.NamespaceDeclaration))
                return null;
            var namespaceDeclaration = (NamespaceDeclarationSyntax)classDeclaration.Parent;
            
            var classSymbol = ModelExtensions.GetDeclaredSymbol(compilation.GetSemanticModel(classDeclaration.SyntaxTree), classDeclaration);
            
            var classAttribute = classSymbol.GetAttributes()
                .FirstOrDefault(x => SymbolEqualityComparer.Default.Equals(x.AttributeClass, nativeApiAttributeSymbol));

            var classNativeApiAttribute = classAttribute == default ? new NativeApiAttribute() : ToNativeApiAttribute(classAttribute);

            var newMembers = new List<MemberDeclarationSyntax>();
            
            var methods = classDeclaration.Members
                .Where(x => x.IsKind(SyntaxKind.MethodDeclaration))
                .Select(x => (MethodDeclarationSyntax)x)
                .Select
                (
                    declaration => (declaration,
                        symbol: compilation.GetSemanticModel(declaration.SyntaxTree).GetDeclaredSymbol(declaration))
                )
                .Select
                (
                    x => (x.declaration, x.symbol,
                        attribute: x.symbol.GetAttributes()
                            .FirstOrDefault
                                (x2 => SymbolEqualityComparer.Default.Equals(x2.AttributeClass, nativeApiAttributeSymbol)))
                )
                .Where(x => x.attribute != default)
                .Select(x => (x.declaration, x.symbol, ToNativeApiAttribute(x.attribute))).ToArray();
            foreach (var (declaration, symbol, attribute) in methods)
            {
                if (!declaration.Modifiers.Any(x => x.IsKind(SyntaxKind.PartialKeyword)))
                    continue; // TODO: Diagnostic

                var entryPoint = NativeApiAttribute.GetEntryPoint(attribute, classNativeApiAttribute, symbol.Name);
                var callingConvention = NativeApiAttribute.GetCallingConvention(attribute, classNativeApiAttribute);

                var slot = Interlocked.Increment(ref _slot);

                var functionPointerTypeParams = new List<ParameterSyntax>();

                // in
                if (symbol.Parameters.Length > 0)
                    continue;
                // ...
                // out
                var returnMarshaller = MarshalReturnType(symbol.ReturnType);

                if (returnMarshaller is null)
                    continue;

                functionPointerTypeParams.Add(Parameter(returnMarshaller.ResultType));
                newMembers.Add
                (
                    declaration.WithBody
                        (
                            Block
                            (
                                returnMarshaller.Statement
                                (
                                    InvocationExpression
                                    (
                                        ParenthesizedExpression
                                        (
                                            CastExpression
                                            (
                                                FunctionPointerType
                                                (
                                                    Identifier(GetCallingConvention(callingConvention)),
                                                    SeparatedList(functionPointerTypeParams)
                                                ), InvocationExpression
                                                (
                                                    IdentifierName("Load"), ArgumentList
                                                    (
                                                        SeparatedList<ArgumentSyntax>
                                                        (
                                                            new[]
                                                            {
                                                                Argument
                                                                (
                                                                    LiteralExpression
                                                                    (
                                                                        SyntaxKind.StringLiteralExpression,
                                                                        Literal(entryPoint)
                                                                    )
                                                                ),
                                                                Argument
                                                                (
                                                                    LiteralExpression
                                                                    (
                                                                        SyntaxKind.NumericLiteralExpression,
                                                                        Literal(slot)
                                                                    )
                                                                )
                                                            }
                                                        )
                                                    )
                                                )
                                            )
                                        ),
                                        ArgumentList
                                        (
                                            SeparatedList
                                            (
                                                symbol.Parameters.Select
                                                        (x => x.Name)
                                                    .Select(x => Argument(IdentifierName(x)))
                                            )
                                        )
                                    )
                                )
                            )
                        )
                        .WithAttributeLists(default)
                        .WithSemicolonToken(default)
                );
            }

            if (newMembers.Count == 0)
                return null;

            return namespaceDeclaration.WithMembers(List(new MemberDeclarationSyntax[] {classDeclaration.WithMembers(List(newMembers))})).NormalizeWhitespace().ToFullString();
        }
        
        private static IReturnMarshaller MarshalReturnType(ITypeSymbol symbol)
        {
            if (symbol.SpecialType == SpecialType.System_Boolean)
                return new BoolReturnMarshaller();

            if (symbol.SpecialType == SpecialType.System_Void)
                return new VoidReturnMarshaller();

            return null;
        }
        
        private interface IReturnMarshaller
        {
            public SyntaxToken ResultType { get; }
            public StatementSyntax Statement(ExpressionSyntax argument);
        }
        
        private class VoidReturnMarshaller : IReturnMarshaller
        {
            public SyntaxToken ResultType => Identifier("void");
            public StatementSyntax Statement(ExpressionSyntax argument) => ExpressionStatement(argument);
        }
        
        private class BoolReturnMarshaller : IReturnMarshaller
        {
            public SyntaxToken ResultType => Identifier("byte");

            public StatementSyntax Statement
                (ExpressionSyntax argument)
                => ReturnStatement(BinaryExpression
                (
                    SyntaxKind.EqualsExpression, argument,
                    LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(1))
                ));
        }
        
        private static string GetCallingConvention(CallingConvention convention) =>
            convention switch
            {
                // CallingConvention.Winapi => "", netstandard2.0 doesn't allow this :(
                CallingConvention.Cdecl => "cdecl",
                CallingConvention.ThisCall => "thiscall",
                CallingConvention.StdCall => "stdcall",
                _ => throw new ArgumentException("convention is invalid", nameof(convention))
            };

        private static NativeApiAttribute ToNativeApiAttribute(AttributeData attributeData)
        {
            var v = new NativeApiAttribute();
            var dictionary = attributeData.NamedArguments.ToDictionary(x => x.Key, x => x.Value);

            if (dictionary.TryGetValue(nameof(NativeApiAttribute.EntryPoint), out var entryPointConstant))
                v.EntryPoint = (string) entryPointConstant.Value;
            
            if (dictionary.TryGetValue(nameof(NativeApiAttribute.Prefix), out var prefixConstant))
                v.Prefix = (string) prefixConstant.Value;
            
            if (dictionary.TryGetValue(nameof(NativeApiAttribute.Convention), out var conventionConstant))
                v.Convention = (CallingConvention) conventionConstant.Value;

            return v;
        }

        public class SyntaxReceiver : ISyntaxReceiver
        {
            public List<ClassDeclarationSyntax> ClassDeclarations = new List<ClassDeclarationSyntax>();
            
            public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
            {
                if (syntaxNode is ClassDeclarationSyntax cds) ClassDeclarations.Add(cds);
            }
        }
    }
}
