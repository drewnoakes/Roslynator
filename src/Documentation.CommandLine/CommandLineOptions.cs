﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using CommandLine;
using static Roslynator.Documentation.DocumentationOptions;

namespace Roslynator.Documentation
{
    //TODO: encoding
    public class CommandLineOptions
    {
        [Option(longName: "assemblyReferences", Required = true)]
        public string AssemblyReferences { get; set; }

        [Option(longName: "assemblies", Separator = ';', Required = true)]
        public IEnumerable<string> Assemblies { get; set; }

        [Option(longName: "outputDirectory", Required = true)]
        public string OutputDirectory { get; set; }

        [Option(longName: "heading", Required = true)]
        public string Heading { get; set; }

        [Option(longName: "environment", Required = true)]
        public string Environment { get; set; }

        [Option(longName: "documentationParts")]
        public IEnumerable<string> DocumentationParts { get; set; }

        [Option(longName: "namespaceParts")]
        public IEnumerable<string> NamespaceParts { get; set; }

        [Option(longName: "typeParts")]
        public IEnumerable<string> TypeParts { get; set; }

        [Option(longName: "memberParts")]
        public IEnumerable<string> MemberParts { get; set; }

        [Option(longName: "preferredCultureName")]
        public string PreferredCultureName { get; set; }

        [Option(longName: "baseLocalUrl")]
        public string BaseLocalUrl { get; set; }

        [Option(longName: "formatDefinitionBaseList", Default = DefaultValues.FormatDefinitionBaseList)]
        public bool FormatDefinitionBaseList { get; set; }

        [Option(longName: "formatDefinitionConstraints", Default = DefaultValues.FormatDefinitionConstraints)]
        public bool FormatDefinitionConstraints { get; set; }

        [Option(longName: "maxDerivedItems", Default = DefaultValues.MaxDerivedItems)]
        public int MaxDerivedItems { get; set; }

        [Option(longName: "indicateObsolete", Default = DefaultValues.IndicateObsolete)]
        public bool IndicateObsolete { get; set; }

        [Option(longName: "indicateInheritedMember", Default = DefaultValues.IndicateInheritedMember)]
        public bool IndicateInheritedMember { get; set; }

        [Option(longName: "indicateOverriddenMember", Default = DefaultValues.IndicateOverriddenMember)]
        public bool IndicateOverriddenMember { get; set; }

        [Option(longName: "indicateInterfaceImplementation", Default = DefaultValues.IndicateInterfaceImplementation)]
        public bool IndicateInterfaceImplementation { get; set; }

        [Option(longName: "attributeArguments", Default = DefaultValues.AttributeArguments)]
        public bool AttributeArguments { get; set; }

        [Option(longName: "inheritedInterfaceMembers", Default = DefaultValues.InheritedInterfaceMembers)]
        public bool InheritedInterfaceMembers { get; set; }

        [Option(longName: "omitIEnumerable", Default = DefaultValues.OmitIEnumerable)]
        public bool OmitIEnumerable { get; set; }
    }
}