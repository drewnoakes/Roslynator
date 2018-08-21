﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Simplification;
using Microsoft.CodeAnalysis.Text;
using Roslynator.CSharp;

namespace Roslynator.Documentation
{
    public static class DeclarationListGenerator
    {
        public static async Task<string> GenerateAsync(DocumentationModel documentationModel, DeclarationListOptions options = null)
        {
            options = options ?? DeclarationListOptions.Default;

            var builder = new DeclarationListBuilder(options: options);

            builder.Append(documentationModel);

            StringBuilder sb = StringBuilderCache.GetInstance();

            foreach (INamespaceSymbol namespaceSymbol in builder.Namespaces.OrderBy(f => f, builder.NamespaceComparer))
            {
                sb.Append("using ");
                sb.Append(namespaceSymbol.ToDisplayString(SymbolDisplayFormats.TypeNameAndContainingTypesAndNamespaces));
                sb.AppendLine(";");
            }

            sb.AppendLine();
            sb.Append(builder);

            string content = sb.ToString();

            Project project = new AdhocWorkspace()
                .CurrentSolution
                .AddProject("AdHocProject", "AdHocProject", documentationModel.Language)
                .WithMetadataReferences(documentationModel.Compilation.References);

            if (project.ParseOptions is CSharpParseOptions csharpParseOptions)
            {
                project = project.WithParseOptions(csharpParseOptions.WithLanguageVersion(LanguageVersion.Latest));
            }
            else
            {
                Debug.Fail(project.ParseOptions.GetType().FullName);
            }

            Document document = project.AddDocument("AdHocFile.cs", SourceText.From(content));

            SemanticModel semanticModel = await document.GetSemanticModelAsync().ConfigureAwait(false);

            SyntaxNode root = await document.GetSyntaxRootAsync().ConfigureAwait(false);

            var rewriter = new Rewriter(options, semanticModel);

            root = rewriter.Visit(root);

            document = document.WithSyntaxRoot(root);

            document = await Simplifier.ReduceAsync(document).ConfigureAwait(false);

            root = await document.GetSyntaxRootAsync().ConfigureAwait(false);

            return root.ToFullString();
        }

        private class Rewriter : CSharpSyntaxRewriter
        {
            private static readonly SyntaxAnnotation[] _simplifierAnnotationAsArray = new SyntaxAnnotation[] { Simplifier.Annotation };

            private ITypeSymbol _enumTypeSymbol;

            public Rewriter(DeclarationListOptions options, SemanticModel semanticModel, CancellationToken cancellationToken = default)
            {
                Options = options;
                SemanticModel = semanticModel;
                CancellationToken = cancellationToken;
            }

            public SemanticModel SemanticModel { get; }

            public CancellationToken CancellationToken { get; }

            public DeclarationListOptions Options { get; }

            public override SyntaxNode VisitQualifiedName(QualifiedNameSyntax node)
            {
                if (SemanticModel.GetSymbol(node.Left, CancellationToken)?.Kind == SymbolKind.Namespace)
                {
                    return node
                        .WithRight((SimpleNameSyntax)Visit(node.Right))
                        .WithAdditionalAnnotations(_simplifierAnnotationAsArray);
                }

                return base.VisitQualifiedName(node);
            }

            public override SyntaxNode VisitParameter(ParameterSyntax node)
            {
                EqualsValueClauseSyntax @default = node.Default;

                if (@default != null)
                {
                    ExpressionSyntax value = @default?.Value;

                    if (value != null)
                    {
                        ITypeSymbol typeSymbol = SemanticModel.GetTypeSymbol(node.Type, CancellationToken);

                        if (typeSymbol?.TypeKind == TypeKind.Enum)
                        {
                            node = (ParameterSyntax)base.VisitParameter(node);

                            try
                            {
                                _enumTypeSymbol = typeSymbol;
                                value = (ExpressionSyntax)Visit(value);
                            }
                            finally
                            {
                                _enumTypeSymbol = null;
                            }

                            return node.WithDefault(node.Default.WithValue(value));
                        }
                    }
                }

                return base.VisitParameter(node);
            }

            public override SyntaxNode VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
            {
                if (node.IsKind(SyntaxKind.SimpleMemberAccessExpression))
                {
                    ISymbol symbol = SemanticModel.GetSymbol(node, CancellationToken);

                    if (symbol?.Kind == SymbolKind.Field
                        && symbol.ContainingType?.TypeKind == TypeKind.Enum)
                    {
                        return node.WithAdditionalAnnotations(_simplifierAnnotationAsArray);
                    }
                }

                return base.VisitMemberAccessExpression(node);
            }

            public override SyntaxNode VisitIdentifierName(IdentifierNameSyntax node)
            {
                if (_enumTypeSymbol != null
                    && !node.IsParentKind(SyntaxKind.SimpleMemberAccessExpression))
                {
                    MemberAccessExpressionSyntax newNode = CSharpFactory.SimpleMemberAccessExpression(
                        SyntaxFactory.ParseExpression(_enumTypeSymbol.ToDisplayString(SymbolDisplayFormats.TypeNameAndContainingTypesAndNamespaces)),
                        node);

                    return newNode.WithAdditionalAnnotations(_simplifierAnnotationAsArray);
                }

                return base.VisitIdentifierName(node);
            }

            public override SyntaxNode VisitDefaultExpression(DefaultExpressionSyntax node)
            {
                if (Options.UseDefaultLiteral)
                {
                    Debug.Assert(node.IsParentKind(SyntaxKind.EqualsValueClause)
                        && node.Parent.IsParentKind(SyntaxKind.Parameter), node.ToString());

                    if (node.IsParentKind(SyntaxKind.EqualsValueClause)
                        && node.Parent.IsParentKind(SyntaxKind.Parameter))
                    {
                        return CSharpFactory.DefaultLiteralExpression();
                    }
                }

                return base.VisitDefaultExpression(node);
            }
        }
    }
}
