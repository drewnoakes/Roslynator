﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Roslynator.Documentation.Markdown
{
    public class MarkdownDocumentationGenerator : DocumentationGenerator
    {
        public MarkdownDocumentationGenerator(
            CompilationDocumentationInfo compilationInfo,
            DocumentationUriProvider uriProvider,
            DocumentationOptions options = null,
            DocumentationResources resources = null) : base(compilationInfo, uriProvider: uriProvider, options: options, resources: resources)
        {
        }

        protected override DocumentationWriter CreateWriterCore(SymbolDocumentationInfo symbolInfo, SymbolDocumentationInfo directoryInfo)
        {
            return new MarkdownDocumentationWriter(
                symbolInfo,
                directoryInfo,
                uriProvider: UriProvider,
                options: Options,
                resources: Resources);
        }
    }
}