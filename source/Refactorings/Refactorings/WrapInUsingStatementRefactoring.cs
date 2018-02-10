﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslynator.CSharp.Syntax;

namespace Roslynator.CSharp.Refactorings
{
    internal static class WrapInUsingStatementRefactoring
    {
        public static async Task ComputeRefactoringAsync(RefactoringContext context, VariableDeclarationSyntax variableDeclaration)
        {
            if (!(variableDeclaration.Parent is LocalDeclarationStatementSyntax localDeclaration))
                return;

            if (!localDeclaration.Parent.Kind().CanContainStatements())
                return;

            SingleLocalDeclarationStatementInfo localInfo = SyntaxInfo.SingleLocalDeclarationStatementInfo(localDeclaration);

            if (!localInfo.Success)
                return;

            if (!context.Span.IsEmptyAndContainedInSpan(localInfo.Identifier))
                return;

            ExpressionSyntax value = localInfo.Initializer?.Value;

            if (value == null)
                return;

            if (value.Kind() == SyntaxKind.DefaultExpression)
                return;

            if (value is LiteralExpressionSyntax)
                return;

            SemanticModel semanticModel = await context.GetSemanticModelAsync().ConfigureAwait(false);

            var typeSymbol = semanticModel.GetTypeSymbol(localInfo.Type, context.CancellationToken) as INamedTypeSymbol;

            if (typeSymbol?.Implements(SpecialType.System_IDisposable, allInterfaces: true) != true)
                return;

            context.RegisterRefactoring(
                $"Using '{localInfo.IdentifierText}'",
                cancellationToken => RefactorAsync(context.Document, localInfo, semanticModel, cancellationToken));
        }

        private static Task<Document> RefactorAsync(
            Document document,
            SingleLocalDeclarationStatementInfo localInfo,
            SemanticModel semanticModel,
            CancellationToken cancellationToken)
        {
            StatementsInfo statementsInfo = SyntaxInfo.StatementsInfo(localInfo.Statement);

            var localSymbol = (ILocalSymbol)semanticModel.GetDeclaredSymbol(localInfo.Declarator, cancellationToken);

            IdentifierNameSyntax identifierName = FindLastReference(localSymbol, statementsInfo.Node, semanticModel, cancellationToken);

            TextSpan span;
            if (identifierName == null)
            {
                span = localInfo.Statement.Span;
            }
            else
            {
                int position = identifierName.SpanStart;
                span = TextSpan.FromBounds(localInfo.Statement.SpanStart, statementsInfo.First(f => f.Span.Contains(position)).Span.End);
            }

            StatementsSelection selectedStatements = StatementsSelection.Create(statementsInfo, span);

            var refactoring = new WrapStatements.WrapInUsingStatementRefactoring();

            return refactoring.RefactorAsync(document, selectedStatements, cancellationToken);
        }

        private static IdentifierNameSyntax FindLastReference(
            ILocalSymbol symbol,
            SyntaxNode node,
            SemanticModel semanticModel,
            CancellationToken cancellationToken)
        {
            IdentifierNameSyntax lastReference = null;

            foreach (SyntaxNode descendant in node.DescendantNodes())
            {
                if ((descendant is IdentifierNameSyntax identifierName)
                    && symbol.Equals(semanticModel.GetSymbol(identifierName, cancellationToken)))
                {
                    lastReference = identifierName;
                }
            }

            return lastReference;
        }
    }
}
