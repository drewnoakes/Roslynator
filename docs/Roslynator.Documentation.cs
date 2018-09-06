﻿// --------------------------------------------------
// <auto-generated>
//     This file was generated by Roslynator.Documentation, Version=0.1.0.0, Culture=neutral, PublicKeyToken=14b2ed2c2cb945dc
//     Assemblies:
//         Roslynator.Documentation, Version=0.1.0.0, Culture=neutral, PublicKeyToken=14b2ed2c2cb945dc
// </auto-generated>
// --------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection;
using System.Runtime.Versioning;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.CodeAnalysis;

// Roslynator.Documentation
[assembly: AssemblyCompany("Josef Pihrt")]
[assembly: AssemblyCopyright("Copyright (c) 2017-2018 Josef Pihrt")]
[assembly: AssemblyDescription("This API enables to generate documentation for your .NET library\r\n\r\nCommonly Used Types:\r\nRoslynator.Documentation.DocumentationWriter\r\nRoslynator.Documentation.DocumentationGenerator")]
[assembly: AssemblyFileVersion("0.1.0.0")]
[assembly: AssemblyInformationalVersion("0.1.0.0")]
[assembly: AssemblyProduct("Roslynator.Documentation")]
[assembly: AssemblyTitle("Roslynator.Documentation")]
[assembly: TargetFramework(".NETStandard,Version=v1.3", FrameworkDisplayName = "")]

namespace Roslynator
{
  // Roslynator.Documentation
  namespace Documentation
  {
    public static class DeclarationListGenerator
    {
      public static Task<string> GenerateAsync(
        DocumentationModel documentationModel,
        DeclarationListOptions options = null,
        IComparer<INamespaceSymbol> namespaceComparer = null,
        IComparer<INamedTypeSymbol> typeComparer = null,
        IComparer<ISymbol> memberComparer = null);
    }

    public class DeclarationListOptions
    {
      public DeclarationListOptions(
        IEnumerable<string> ignoredNames = null,
        bool indent = true,
        string indentChars = "    ",
        bool nestNamespaces = false,
        bool newLineBeforeOpenBrace = true,
        bool emptyLineBetweenMembers = false,
        bool formatBaseList = false,
        bool formatConstraints = false,
        bool formatParameters = false,
        bool splitAttributes = true,
        bool includeAttributeArguments = true,
        bool omitIEnumerable = true,
        bool useDefaultLiteral = true,
        bool fullyQualifiedNames = false,
        DocumentationDepth depth = DocumentationDepth.Member,
        DeclarationListParts ignoredParts = DeclarationListParts.None);

      public static DeclarationListOptions Default { get; }

      public DocumentationDepth Depth { get; }

      public bool EmptyLineBetweenMembers { get; }

      public bool FormatBaseList { get; }

      public bool FormatConstraints { get; }

      public bool FormatParameters { get; }

      public bool FullyQualifiedNames { get; }

      public ImmutableArray<string> IgnoredNames { get; }

      public DeclarationListParts IgnoredParts { get; }

      public bool IncludeAttributeArguments { get; }

      public bool Indent { get; }

      public string IndentChars { get; }

      public bool NestNamespaces { get; }

      public bool NewLineBeforeOpenBrace { get; }

      public bool OmitIEnumerable { get; }

      public bool SplitAttributes { get; }

      public bool UseDefaultLiteral { get; }
    }

    public abstract class DocumentationGenerator
    {
      protected DocumentationGenerator(
        DocumentationModel documentationModel,
        DocumentationUrlProvider urlProvider,
        DocumentationOptions options = null,
        DocumentationResources resources = null);

      public DocumentationModel DocumentationModel { get; }

      public virtual IComparer<MemberDocumentationParts> MemberPartComparer { get; }

      public virtual IComparer<NamespaceDocumentationParts> NamespacePartComparer { get; }

      public DocumentationOptions Options { get; }

      public DocumentationResources Resources { get; }

      public virtual IComparer<RootDocumentationParts> RootPartComparer { get; }

      public virtual IComparer<TypeDocumentationParts> TypePartComparer { get; }

      public DocumentationUrlProvider UrlProvider { get; }

      protected abstract DocumentationWriter CreateWriterCore();

      public IEnumerable<DocumentationGeneratorResult> Generate(string heading = null);

      public DocumentationGeneratorResult GenerateRoot(
        string heading,
        bool addExtensionsLink = false);
    }

    public sealed class DocumentationModel
    {
      public DocumentationModel(
        Compilation compilation,
        IEnumerable<IAssemblySymbol> assemblies,
        DocumentationVisibility visibility = DocumentationVisibility.Publicly,
        IEnumerable<string> additionalXmlDocumentationPaths = null);

      public ImmutableArray<IAssemblySymbol> Assemblies { get; }

      public Compilation Compilation { get; }

      public string Language { get; }

      public IEnumerable<MetadataReference> References { get; }

      public IEnumerable<INamedTypeSymbol> Types { get; }

      public DocumentationVisibility Visibility { get; }

      public IEnumerable<INamedTypeSymbol> GetExtendedExternalTypes();

      public IEnumerable<IMethodSymbol> GetExtensionMethods();

      public IEnumerable<IMethodSymbol> GetExtensionMethods(INamedTypeSymbol typeSymbol);

      public TypeDocumentationModel GetTypeModel(INamedTypeSymbol typeSymbol);

      public SymbolXmlDocumentation GetXmlDocumentation(
        ISymbol symbol,
        string preferredCultureName = null);

      public bool IsExternal(ISymbol symbol);

      public bool IsVisible(ISymbol symbol);
    }

    public class DocumentationOptions
    {
      public DocumentationOptions(
        IEnumerable<string> ignoredNames = null,
        string preferredCultureName = null,
        string rootDirectoryUrl = null,
        int maxDerivedTypes = 5,
        bool includeClassHierarchy = true,
        bool placeSystemNamespaceFirst = true,
        bool formatDeclarationBaseList = true,
        bool formatDeclarationConstraints = true,
        bool markObsolete = true,
        bool includeMemberInheritedFrom = true,
        bool includeMemberOverrides = true,
        bool includeMemberImplements = true,
        bool includeMemberConstantValue = true,
        bool includeInheritedInterfaceMembers = false,
        bool includeAllDerivedTypes = false,
        bool includeAttributeArguments = true,
        bool includeInheritedAttributes = true,
        bool omitIEnumerable = true,
        DocumentationDepth depth = DocumentationDepth.Member,
        InheritanceStyle inheritanceStyle = InheritanceStyle.Horizontal,
        RootDocumentationParts ignoredRootParts = RootDocumentationParts.None,
        NamespaceDocumentationParts ignoredNamespaceParts = NamespaceDocumentationParts.None,
        TypeDocumentationParts ignoredTypeParts = TypeDocumentationParts.None,
        MemberDocumentationParts ignoredMemberParts = MemberDocumentationParts.None,
        OmitContainingNamespaceParts omitContainingNamespaceParts = OmitContainingNamespaceParts.None);

      public static DocumentationOptions Default { get; }

      public DocumentationDepth Depth { get; }

      public bool FormatDeclarationBaseList { get; }

      public bool FormatDeclarationConstraints { get; }

      public MemberDocumentationParts IgnoredMemberParts { get; }

      public ImmutableArray<string> IgnoredNames { get; }

      public NamespaceDocumentationParts IgnoredNamespaceParts { get; }

      public RootDocumentationParts IgnoredRootParts { get; }

      public TypeDocumentationParts IgnoredTypeParts { get; }

      public bool IncludeAllDerivedTypes { get; }

      public bool IncludeAttributeArguments { get; }

      public bool IncludeClassHierarchy { get; }

      public bool IncludeInheritedAttributes { get; }

      public bool IncludeInheritedInterfaceMembers { get; }

      public bool IncludeMemberConstantValue { get; }

      public bool IncludeMemberImplements { get; }

      public bool IncludeMemberInheritedFrom { get; }

      public bool IncludeMemberOverrides { get; }

      public InheritanceStyle InheritanceStyle { get; }

      public bool MarkObsolete { get; }

      public int MaxDerivedTypes { get; }

      public OmitContainingNamespaceParts OmitContainingNamespaceParts { get; }

      public bool OmitIEnumerable { get; }

      public bool PlaceSystemNamespaceFirst { get; }

      public string PreferredCultureName { get; }

      public string RootDirectoryUrl { get; }
    }

    public abstract class DocumentationResources
    {
      protected DocumentationResources();

      public abstract string AssemblyTitle { get; }

      public abstract string AttributesTitle { get; }

      public abstract string ClassTitle { get; }

      public abstract string ClassesTitle { get; }

      public virtual string CloseParenthesis { get; }

      public virtual string Colon { get; }

      public abstract string CombinationOfTitle { get; }

      public virtual string Comma { get; }

      public abstract string ConstructorTitle { get; }

      public abstract string ConstructorsTitle { get; }

      public abstract string ContainingNamespaceTitle { get; }

      public abstract string ContainingTypeTitle { get; }

      public static DocumentationResources Default { get; }

      public abstract string DelegateTitle { get; }

      public abstract string DelegatesTitle { get; }

      public abstract string DeprecatedTitle { get; }

      public abstract string DerivedAllTitle { get; }

      public abstract string DerivedTitle { get; }

      public virtual string DllExtension { get; }

      public virtual string Ellipsis { get; }

      public abstract string EnumTitle { get; }

      public abstract string EnumsTitle { get; }

      public virtual string EqualsSign { get; }

      public abstract string EventTitle { get; }

      public abstract string EventsTitle { get; }

      public abstract string ExamplesTitle { get; }

      public abstract string ExceptionsTitle { get; }

      public abstract string ExplicitInterfaceImplementationTitle { get; }

      public abstract string ExplicitInterfaceImplementationsTitle { get; }

      public abstract string ExtensionMethodTitle { get; }

      public abstract string ExtensionMethodsTitle { get; }

      public abstract string ExtensionsOfExternalTypesTitle { get; }

      public abstract string ExtensionsTitle { get; }

      public virtual string FalseValue { get; }

      public abstract string FieldTitle { get; }

      public abstract string FieldValueTitle { get; }

      public abstract string FieldsTitle { get; }

      public abstract string HomeTitle { get; }

      public abstract string ImplementsTitle { get; }

      public abstract string IndexerTitle { get; }

      public abstract string IndexersTitle { get; }

      public virtual char InheritanceChar { get; }

      public abstract string InheritanceTitle { get; }

      public abstract string InheritedFrom { get; }

      public virtual char InlineSeparatorChar { get; }

      public abstract string InterfaceTitle { get; }

      public abstract string InterfacesTitle { get; }

      public abstract string MemberTitle { get; }

      public abstract string MethodTitle { get; }

      public abstract string MethodsTitle { get; }

      public abstract string NameTitle { get; }

      public abstract string NamespaceTitle { get; }

      public abstract string NamespacesTitle { get; }

      public abstract string ObjectModelTitle { get; }

      public abstract string ObsoleteMessage { get; }

      public virtual string OpenParenthesis { get; }

      public abstract string OperatorTitle { get; }

      public abstract string OperatorsTitle { get; }

      public abstract string OtherTitle { get; }

      public abstract string OverloadsTitle { get; }

      public abstract string OverridesTitle { get; }

      public abstract string ParametersTitle { get; }

      public abstract string PropertiesTitle { get; }

      public abstract string PropertyTitle { get; }

      public abstract string PropertyValueTitle { get; }

      public abstract string RemarksTitle { get; }

      public abstract string ReturnValueTitle { get; }

      public abstract string ReturnsTitle { get; }

      public abstract string SeeAllDerivedTypes { get; }

      public abstract string SeeAlsoTitle { get; }

      public abstract string StaticClassesTitle { get; }

      public abstract string StructTitle { get; }

      public abstract string StructsTitle { get; }

      public abstract string SummaryTitle { get; }

      public virtual string TrueValue { get; }

      public abstract string TypeParametersTitle { get; }

      public abstract string ValueTitle { get; }

      public abstract string ValuesTitle { get; }

      public string GetName(ISymbol symbol);

      public string GetName(TypeKind typeKind);

      public string GetPluralName(TypeKind typeKind);
    }

    public abstract class DocumentationUrlProvider
    {
      protected DocumentationUrlProvider(IEnumerable<ExternalUrlProvider> externalProviders = null);

      public ImmutableArray<ExternalUrlProvider> ExternalProviders { get; }

      public DocumentationUrlInfo GetExternalUrl(ImmutableArray<string> folders);

      public abstract string GetFileName(DocumentationFileKind kind);

      public virtual ImmutableArray<string> GetFolders(ISymbol symbol);

      public abstract string GetFragment(string value);

      public abstract DocumentationUrlInfo GetLocalUrl(
        ImmutableArray<string> folders,
        ImmutableArray<string> containingFolders = default,
        string fragment = null);
    }

    public abstract class DocumentationWriter : IDisposable
    {
      protected DocumentationWriter(
        DocumentationModel documentationModel,
        DocumentationUrlProvider urlProvider,
        DocumentationOptions options = null,
        DocumentationResources resources = null);

      public DocumentationModel DocumentationModel { get; }

      public DocumentationOptions Options { get; }

      public DocumentationResources Resources { get; }

      public DocumentationUrlProvider UrlProvider { get; }

      public virtual void Close();

      public void Dispose();

      protected virtual void Dispose(bool disposing);

      public abstract void Flush();

      public virtual void WriteAttributes(
        ISymbol symbol,
        int headingLevelBase = 0);

      public virtual void WriteBlockQuote(string text);

      public virtual void WriteBold(string text);

      public virtual void WriteBulletItem(string text);

      public abstract void WriteCharEntity(char value);

      public abstract void WriteCodeBlock(
        string text,
        string language = null);

      public abstract void WriteComment(string text);

      public virtual void WriteConstructors(IEnumerable<IMethodSymbol> constructors);

      public virtual void WriteContainingAssembly(
        ISymbol symbol,
        string title);

      public virtual void WriteContainingNamespace(
        INamespaceSymbol namespaceSymbol,
        string title);

      public virtual void WriteContainingType(
        INamedTypeSymbol typeSymbol,
        string title);

      public virtual void WriteContent(
        IEnumerable<string> names,
        bool addLinkToRoot = false,
        bool beginWithSeparator = false);

      public virtual void WriteDeclaration(ISymbol symbol);

      public virtual void WriteDerivedTypes(IEnumerable<INamedTypeSymbol> derivedTypes);

      public abstract void WriteEndBlockQuote();

      public abstract void WriteEndBold();

      public abstract void WriteEndBulletItem();

      public abstract void WriteEndBulletList();

      public abstract void WriteEndDocument();

      public abstract void WriteEndHeading();

      public abstract void WriteEndItalic();

      public abstract void WriteEndLink(
        string url,
        string title = null);

      public abstract void WriteEndOrderedItem();

      public abstract void WriteEndOrderedList();

      public abstract void WriteEndStrikethrough();

      public abstract void WriteEndTable();

      public abstract void WriteEndTableCell();

      public abstract void WriteEndTableRow();

      public abstract void WriteEntityRef(string name);

      public virtual void WriteEnumFields(
        IEnumerable<IFieldSymbol> fields,
        INamedTypeSymbol containingType);

      public virtual void WriteEvents(
        IEnumerable<IEventSymbol> events,
        INamedTypeSymbol containingType);

      public virtual void WriteExamples(
        ISymbol symbol,
        SymbolXmlDocumentation xmlDocumentation,
        int headingLevelBase = 0);

      public virtual void WriteExceptions(
        ISymbol symbol,
        SymbolXmlDocumentation xmlDocumentation,
        int headingLevelBase = 0);

      public virtual void WriteExplicitInterfaceImplementations(IEnumerable<ISymbol> explicitInterfaceImplementations);

      public virtual void WriteExtensionMethods(IEnumerable<IMethodSymbol> extensionMethods);

      public virtual void WriteFields(
        IEnumerable<IFieldSymbol> fields,
        INamedTypeSymbol containingType);

      public virtual void WriteHeading(
        int level,
        string text);

      public virtual void WriteHeading1(string text);

      public virtual void WriteHeading2(string text);

      public virtual void WriteHeading3(string text);

      public virtual void WriteHeading4(string text);

      public virtual void WriteHeading5(string text);

      public virtual void WriteHeading6(string text);

      public abstract void WriteHorizontalRule();

      public abstract void WriteImage(
        string text,
        string url,
        string title = null);

      public virtual void WriteImplementedInterfaces(IEnumerable<INamedTypeSymbol> interfaceTypes);

      public virtual void WriteIndexers(
        IEnumerable<IPropertySymbol> indexers,
        INamedTypeSymbol containingType);

      public virtual void WriteInheritance(INamedTypeSymbol typeSymbol);

      public abstract void WriteInlineCode(string text);

      public virtual void WriteItalic(string text);

      public abstract void WriteLine();

      public abstract void WriteLineBreak();

      public abstract void WriteLink(
        string text,
        string url,
        string title = null);

      public abstract void WriteLinkDestination(string name);

      public void WriteLinkOrText(
        string text,
        string url = null,
        string title = null);

      public virtual void WriteMethods(
        IEnumerable<IMethodSymbol> methods,
        INamedTypeSymbol containingType);

      public virtual void WriteObsoleteMessage(ISymbol symbol);

      public virtual void WriteOperators(
        IEnumerable<IMethodSymbol> operators,
        INamedTypeSymbol containingType);

      public virtual void WriteOrderedItem(
        int number,
        string text);

      public virtual void WriteParameters(ISymbol symbol);

      public virtual void WriteProperties(
        IEnumerable<IPropertySymbol> properties,
        INamedTypeSymbol containingType);

      public abstract void WriteRaw(string data);

      public virtual void WriteRemarks(
        ISymbol symbol,
        SymbolXmlDocumentation xmlDocumentation,
        int headingLevelBase = 0);

      public virtual void WriteReturnType(
        ISymbol symbol,
        SymbolXmlDocumentation xmlDocumentation);

      public virtual void WriteSeeAlso(
        ISymbol symbol,
        SymbolXmlDocumentation xmlDocumentation,
        int headingLevelBase = 0);

      public abstract void WriteStartBlockQuote();

      public abstract void WriteStartBold();

      public abstract void WriteStartBulletItem();

      public abstract void WriteStartBulletList();

      public abstract void WriteStartDocument();

      public abstract void WriteStartHeading(int level);

      public abstract void WriteStartItalic();

      public abstract void WriteStartLink();

      public abstract void WriteStartOrderedItem(int number);

      public abstract void WriteStartOrderedList();

      public abstract void WriteStartStrikethrough();

      public abstract void WriteStartTable(int columnCount);

      public abstract void WriteStartTableCell();

      public abstract void WriteStartTableRow();

      public virtual void WriteStrikethrough(string text);

      public abstract void WriteString(string text);

      public virtual void WriteSummary(
        ISymbol symbol,
        SymbolXmlDocumentation xmlDocumentation,
        int headingLevelBase = 0);

      public abstract void WriteTableCell(string text);

      public abstract void WriteTableHeaderSeparator();

      public virtual void WriteTypeParameters(ISymbol symbol);

      public virtual void WriteValue(bool value);

      public virtual void WriteValue(decimal value);

      public virtual void WriteValue(double value);

      public virtual void WriteValue(float value);

      public virtual void WriteValue(int value);

      public virtual void WriteValue(long value);
    }

    public abstract class ExternalUrlProvider
    {
      protected ExternalUrlProvider();

      public abstract string Name { get; }

      public abstract DocumentationUrlInfo CreateUrl(ImmutableArray<string> folders);
    }

    public sealed class MemberDocumentationModel : IEquatable<MemberDocumentationModel>
    {
      public bool IsOverloaded { get; }

      public ImmutableArray<ISymbol> Overloads { get; }

      public ISymbol Symbol { get; }

      public bool Equals(MemberDocumentationModel other);

      public override bool Equals(object obj);

      public override int GetHashCode();
    }

    public class SymbolXmlDocumentation
    {
      public string CommentId { get; }

      public ISymbol Symbol { get; }

      public XElement Element(string name);

      public IEnumerable<XElement> Elements(string name);

      public bool HasElement(string name);
    }

    public sealed class TypeDocumentationModel : IEquatable<TypeDocumentationModel>
    {
      public INamedTypeSymbol Symbol { get; }

      public TypeKind TypeKind { get; }

      public bool Equals(TypeDocumentationModel other);

      public override bool Equals(object obj);

      public IEnumerable<INamedTypeSymbol> GetAllDerivedTypes();

      public IEnumerable<IMethodSymbol> GetConstructors();

      public IEnumerable<INamedTypeSymbol> GetDerivedTypes();

      public IEnumerable<IEventSymbol> GetEvents(bool includeInherited = false);

      public IEnumerable<ISymbol> GetExplicitInterfaceImplementations();

      public IEnumerable<IMethodSymbol> GetExtensionMethods();

      public IEnumerable<IFieldSymbol> GetFields(bool includeInherited = false);

      public override int GetHashCode();

      public IEnumerable<INamedTypeSymbol> GetImplementedInterfaces(bool omitIEnumerable = false);

      public IEnumerable<IPropertySymbol> GetIndexers(bool includeInherited = false);

      public IEnumerable<IMethodSymbol> GetMethods(bool includeInherited = false);

      public IEnumerable<IMethodSymbol> GetOperators(
        bool includeInherited = false,
        bool includeConversion = true,
        bool includeUserDefinedOperator = true);

      public IEnumerable<IPropertySymbol> GetProperties(
        bool includeInherited = false,
        bool includeIndexers = false);
    }

    public static class WellKnownExternalUrlProviders
    {
      public static ExternalUrlProvider MicrosoftDocs { get; }
    }

    public static class WellKnownUrlProviders
    {
      public static DocumentationUrlProvider GitHub { get; }
    }

    public sealed class XmlDocumentation
    {
      public SymbolXmlDocumentation GetXmlDocumentation(ISymbol symbol);

      public static XmlDocumentation Load(string filePath);
    }

    public readonly struct DocumentationGeneratorResult : IEquatable<DocumentationGeneratorResult>
    {
      public DocumentationGeneratorResult(
        string content,
        string filePath,
        DocumentationFileKind kind);

      public string Content { get; }

      public string FilePath { get; }

      public DocumentationFileKind Kind { get; }

      public bool Equals(DocumentationGeneratorResult other);

      public override bool Equals(object obj);

      public override int GetHashCode();

      public static bool operator ==(
        in DocumentationGeneratorResult file1,
        in DocumentationGeneratorResult file2);

      public static bool operator !=(
        in DocumentationGeneratorResult file1,
        in DocumentationGeneratorResult file2);
    }

    public readonly struct DocumentationUrlInfo : IEquatable<DocumentationUrlInfo>
    {
      public DocumentationUrlInfo(
        string url,
        DocumentationUrlKind kind);

      public DocumentationUrlKind Kind { get; }

      public string Url { get; }

      public bool Equals(DocumentationUrlInfo other);

      public override bool Equals(object obj);

      public override int GetHashCode();

      public static bool operator ==(
        in DocumentationUrlInfo info1,
        in DocumentationUrlInfo info2);

      public static bool operator !=(
        in DocumentationUrlInfo info1,
        in DocumentationUrlInfo info2);
    }

    [Flags]
    public enum DeclarationListParts
    {
      None = 0,
      AutoGeneratedComment = 1,
      AssemblyAttributes = 2,
      All = AutoGeneratedComment | AssemblyAttributes,
    }

    public enum DocumentationDepth
    {
      Member = 0,
      Type = 1,
      Namespace = 2,
    }

    public enum DocumentationFileKind
    {
      None = 0,
      Root = 1,
      Namespace = 2,
      Type = 3,
      Member = 4,
      Extensions = 5,
    }

    public enum DocumentationUrlKind
    {
      Local = 0,
      External = 1,
    }

    public enum DocumentationVisibility
    {
      Publicly = 0,
      PubliclyOrInternally = 1,
      All = 2,
    }

    public enum InheritanceStyle
    {
      Horizontal = 0,
      Vertical = 1,
    }

    public enum MemberDeclarationKind
    {
      None = 0,
      Const = 1,
      Field = 2,
      Constructor = 3,
      Event = 4,
      Indexer = 5,
      Property = 6,
      Method = 7,
      ConversionOperator = 8,
      Operator = 9,
    }

    [Flags]
    public enum MemberDocumentationParts
    {
      None = 0,
      Overloads = 1,
      ContainingType = 2,
      ContainingAssembly = 4,
      ObsoleteMessage = 8,
      Summary = 16,
      Declaration = 32,
      TypeParameters = 64,
      Parameters = 128,
      ReturnValue = 256,
      Implements = 512,
      Attributes = 1024,
      Exceptions = 2048,
      Examples = 4096,
      Remarks = 8192,
      SeeAlso = 16384,
      All = Overloads | ContainingType | ContainingAssembly | ObsoleteMessage | Summary | Declaration | TypeParameters | Parameters | ReturnValue | Implements | Attributes | Exceptions | Examples | Remarks | SeeAlso,
    }

    [Flags]
    public enum NamespaceDocumentationParts
    {
      None = 0,
      Content = 1,
      ContainingNamespace = 2,
      Summary = 4,
      Examples = 8,
      Remarks = 16,
      Classes = 32,
      Structs = 64,
      Interfaces = 128,
      Enums = 256,
      Delegates = 512,
      SeeAlso = 1024,
      All = Content | ContainingNamespace | Summary | Examples | Remarks | Classes | Structs | Interfaces | Enums | Delegates | SeeAlso,
    }

    [Flags]
    public enum OmitContainingNamespaceParts
    {
      None = 0,
      Root = 1,
      ContainingType = 2,
      ReturnType = 4,
      BaseType = 8,
      Attribute = 16,
      DerivedType = 32,
      ImplementedInterface = 64,
      ImplementedMember = 128,
      Exception = 256,
      SeeAlso = 512,
      All = Root | ContainingType | ReturnType | BaseType | Attribute | DerivedType | ImplementedInterface | ImplementedMember | Exception | SeeAlso,
    }

    [Flags]
    public enum RootDocumentationParts
    {
      None = 0,
      Content = 1,
      Namespaces = 2,
      Classes = 4,
      StaticClasses = 8,
      Structs = 16,
      Interfaces = 32,
      Enums = 64,
      Delegates = 128,
      Types = Classes | StaticClasses | Structs | Interfaces | Enums | Delegates,
      Other = 256,
      All = Content | Namespaces | Types | Other,
    }

    [Flags]
    public enum SymbolDisplayAdditionalMemberOptions
    {
      None = 0,
      UseItemPropertyName = 1,
      UseOperatorName = 2,
    }

    [Flags]
    public enum SymbolDisplayTypeDeclarationOptions
    {
      None = 0,
      IncludeModifiers = 1,
      IncludeAccessibility = 2,
    }

    [Flags]
    public enum TypeDocumentationParts
    {
      None = 0,
      Content = 1,
      ContainingNamespace = 2,
      ContainingAssembly = 4,
      ObsoleteMessage = 8,
      Summary = 16,
      Declaration = 32,
      TypeParameters = 64,
      Parameters = 128,
      ReturnValue = 256,
      Inheritance = 512,
      Attributes = 1024,
      Derived = 2048,
      Implements = 4096,
      Examples = 8192,
      Remarks = 16384,
      Constructors = 32768,
      Fields = 65536,
      Indexers = 131072,
      Properties = 262144,
      Methods = 524288,
      Operators = 1048576,
      Events = 2097152,
      ExplicitInterfaceImplementations = 4194304,
      ExtensionMethods = 8388608,
      Classes = 16777216,
      Structs = 33554432,
      Interfaces = 67108864,
      Enums = 134217728,
      Delegates = 268435456,
      NestedTypes = Classes | Structs | Interfaces | Enums | Delegates,
      SeeAlso = 536870912,
      AllExceptNestedTypes = Content | ContainingNamespace | ContainingAssembly | ObsoleteMessage | Summary | Declaration | TypeParameters | Parameters | ReturnValue | Inheritance | Attributes | Derived | Implements | Examples | Remarks | Constructors | Fields | Indexers | Properties | Methods | Operators | Events | ExplicitInterfaceImplementations | ExtensionMethods | SeeAlso,
      All = NestedTypes | AllExceptNestedTypes,
    }
    // Roslynator.Documentation.Markdown
    namespace Markdown
    {
      public class MarkdownDocumentationGenerator : DocumentationGenerator
      {
        public MarkdownDocumentationGenerator(
          DocumentationModel documentationModel,
          DocumentationUrlProvider urlProvider,
          DocumentationOptions options = null,
          DocumentationResources resources = null);

        protected override DocumentationWriter CreateWriterCore();
      }

      public class MarkdownDocumentationWriter : DocumentationWriter
      {
        public MarkdownDocumentationWriter(
          DocumentationModel documentationModel,
          DocumentationUrlProvider urlProvider,
          DocumentationOptions options = null,
          DocumentationResources resources = null);

        public override void Close();

        public override void Flush();

        public override string ToString();

        public override void WriteCharEntity(char value);

        public override void WriteCodeBlock(
          string text,
          string language = null);

        public override void WriteComment(string text);

        public override void WriteEndBlockQuote();

        public override void WriteEndBold();

        public override void WriteEndBulletItem();

        public override void WriteEndBulletList();

        public override void WriteEndDocument();

        public override void WriteEndHeading();

        public override void WriteEndItalic();

        public override void WriteEndLink(
          string url,
          string title = null);

        public override void WriteEndOrderedItem();

        public override void WriteEndOrderedList();

        public override void WriteEndStrikethrough();

        public override void WriteEndTable();

        public override void WriteEndTableCell();

        public override void WriteEndTableRow();

        public override void WriteEntityRef(string name);

        public override void WriteHorizontalRule();

        public override void WriteImage(
          string text,
          string url,
          string title = null);

        public override void WriteInlineCode(string text);

        public override void WriteLine();

        public override void WriteLineBreak();

        public override void WriteLink(
          string text,
          string url,
          string title = null);

        public override void WriteLinkDestination(string name);

        public override void WriteRaw(string data);

        public override void WriteStartBlockQuote();

        public override void WriteStartBold();

        public override void WriteStartBulletItem();

        public override void WriteStartBulletList();

        public override void WriteStartDocument();

        public override void WriteStartHeading(int level);

        public override void WriteStartItalic();

        public override void WriteStartLink();

        public override void WriteStartOrderedItem(int number);

        public override void WriteStartOrderedList();

        public override void WriteStartStrikethrough();

        public override void WriteStartTable(int columnCount);

        public override void WriteStartTableCell();

        public override void WriteStartTableRow();

        public override void WriteString(string text);

        public override void WriteTableCell(string text);

        public override void WriteTableHeaderSeparator();
      }
    }
  }
}

