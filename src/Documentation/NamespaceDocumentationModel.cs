﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis;

namespace Roslynator.Documentation
{
    public sealed class NamespaceDocumentationModel : SymbolDocumentationModel, IDocumentationFile
    {
        private ImmutableArray<TypeDocumentationModel> _types;

        private NamespaceDocumentationModel(
            INamespaceSymbol namespaceSymbol,
            ImmutableArray<string> nameAndBaseNamesAndNamespaceNames,
            DocumentationModel documentationModel) : base(namespaceSymbol, documentationModel)
        {
            NamespaceSymbol = namespaceSymbol;
            Names = nameAndBaseNamesAndNamespaceNames;
        }

        public INamespaceSymbol NamespaceSymbol { get; }

        public ImmutableArray<TypeDocumentationModel> Types
        {
            get
            {
                if (_types.IsDefault)
                {
                    _types = DocumentationModel.Types
                        .Where(f => MetadataNameEqualityComparer<INamespaceSymbol>.Instance.Equals(f.Symbol.ContainingNamespace, NamespaceSymbol))
                        .ToImmutableArray();
                }

                return _types;
            }
        }

        public ImmutableArray<string> Names { get; }

        public DocumentationKind Kind => DocumentationKind.Namespace;

        internal IEnumerable<IGrouping<TypeKind, TypeDocumentationModel>> GetTypesByKind(NamespaceDocumentationParts parts, IComparer<NamespaceDocumentationParts> comparer)
        {
            return Types
                .Where(f => IsNamespacePartEnabled(f.TypeKind))
                .GroupBy(f => f.TypeKind)
                .OrderBy(f => f.Key.ToNamespaceDocumentationPart(), comparer ?? NamespaceDocumentationPartComparer.Instance);

            bool IsNamespacePartEnabled(TypeKind typeKind)
            {
                switch (typeKind)
                {
                    case TypeKind.Class:
                        return IsPartEnabled(NamespaceDocumentationParts.Classes);
                    case TypeKind.Delegate:
                        return IsPartEnabled(NamespaceDocumentationParts.Delegates);
                    case TypeKind.Enum:
                        return IsPartEnabled(NamespaceDocumentationParts.Enums);
                    case TypeKind.Interface:
                        return IsPartEnabled(NamespaceDocumentationParts.Interfaces);
                    case TypeKind.Struct:
                        return IsPartEnabled(NamespaceDocumentationParts.Structs);
                    default:
                        return false;
                }
            }

            bool IsPartEnabled(NamespaceDocumentationParts part)
            {
                return (parts & part) != 0;
            }
        }

        internal static NamespaceDocumentationModel Create(INamespaceSymbol namespaceSymbol, DocumentationModel documentationModel)
        {
            ImmutableArray<string>.Builder names = ImmutableArray.CreateBuilder<string>();

            if (namespaceSymbol.IsGlobalNamespace)
            {
                names.Add(WellKnownNames.GlobalNamespaceName);
            }
            else
            {
                names.Add(namespaceSymbol.Name);
            }

            INamespaceSymbol containingNamespace = namespaceSymbol.ContainingNamespace;

            while (containingNamespace?.IsGlobalNamespace == false)
            {
                names.Add(containingNamespace.Name);

                containingNamespace = containingNamespace.ContainingNamespace;
            }

            return new NamespaceDocumentationModel(
                namespaceSymbol,
                names.ToImmutableArray(),
                documentationModel);
        }

        public override bool Equals(object obj)
        {
            return obj is NamespaceDocumentationModel other
                && MetadataNameEqualityComparer<INamespaceSymbol>.Instance.Equals(NamespaceSymbol, other.NamespaceSymbol);
        }

        public override int GetHashCode()
        {
            return MetadataNameEqualityComparer<INamespaceSymbol>.Instance.GetHashCode(NamespaceSymbol);
        }

        public bool Equals(IDocumentationFile other)
        {
            return DocumentationFileEqualityComparer.Instance.Equals(this, other);
        }
    }
}