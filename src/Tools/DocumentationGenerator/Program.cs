﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using Roslynator.Documentation.Markdown;
using Roslynator.Utilities;

namespace Roslynator.Documentation
{
    internal static class Program
    {
        private static readonly UTF8Encoding _utf8NoBom = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);

        [SuppressMessage("Redundancy", "RCS1163")]
        private static void Main(string[] args)
        {
            GenerateDocumentation(@"..\..\..\..\..\..\docs\api\", "Roslynator API", "Roslynator.CSharp.dll", "Roslynator.CSharp.Workspaces.dll");
            GenerateDocumentation(@"..\..\..\..\..\..\docs\apitest\", "Foo API", "Roslynator.Documentation.DocumentationTest.dll");
        }

        private static void GenerateDocumentation(string directoryPath, string heading, params string[] assemblyNames)
        {
            ImmutableArray<AssemblyDocumentationInfo> assemblies = assemblyNames
                .Select(AssemblyDocumentationInfo.CreateFromAssemblyName)
                .ToImmutableArray();

            var compilationInfo = new CompilationDocumentationInfo(TrustedPlatformAssemblies.Compilation, assemblies);

            var options = new DocumentationOptions(
                parts: DocumentationParts.All,
                formatBaseList: true,
                formatConstraints: true);

            var generator = new DocumentationMarkdownGenerator(compilationInfo, options);

            foreach (DocumentationFile documentationFile in generator.GenerateFiles(
                heading,
                objectModelHeading: heading + " Object Model",
                extendedTypesHeading: "External Types Extended by " + heading))
            {
                string path = directoryPath + documentationFile.Path;

                Directory.CreateDirectory(Path.GetDirectoryName(path));

                FileHelper.WriteAllText(path, documentationFile.Content, _utf8NoBom, onlyIfChanges: true, fileMustExists: false);
            }
        }
    }
}
