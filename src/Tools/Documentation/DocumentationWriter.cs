﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis;

namespace Roslynator.Documentation
{
    public abstract class DocumentationWriter : IDisposable
    {
        private bool _disposed;

        public abstract void WriteTitle(ITypeSymbol typeSymbol);

        public abstract void WriteNamespace(ITypeSymbol typeSymbol);

        public abstract void WriteAssemblies(ITypeSymbol typeSymbol);

        public abstract void WriteSummary(ITypeSymbol typeSymbol);

        public abstract void WriteTypeParameters(ITypeSymbol typeSymbol);

        public abstract void WriteInheritance(ITypeSymbol typeSymbol);

        public abstract void WriteDerived(ITypeSymbol typeSymbol);

        public abstract void WriteImplements(ITypeSymbol typeSymbol);

        public abstract void WriteExamples(ITypeSymbol typeSymbol);

        public abstract void WriteRemarks(ITypeSymbol typeSymbol);

        public abstract void WriteConstructors(IEnumerable<IMethodSymbol> constructors);

        public abstract void WriteConstructor(IMethodSymbol constructor);

        public abstract void WriteProperties(IEnumerable<IPropertySymbol> properties);

        public abstract void WriteProperty(IPropertySymbol propertySymbol);

        public abstract void WriteMethods(IEnumerable<IMethodSymbol> methods);

        public abstract void WriteMethod(IMethodSymbol methods);

        public abstract void WriteExplicitInterfaceImplementations(IEnumerable<IMethodSymbol> explicitInterfaceImplementations);

        public abstract void WriteOperators(IEnumerable<IMethodSymbol> operators);

        public abstract void WriteExtensionMethods(ITypeSymbol typeSymbol);

        public abstract void WriteSeeAlso(ITypeSymbol typeSymbol);

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                    Close();

                _disposed = true;
            }
        }

        public virtual void Close()
        {
        }
    }
}
