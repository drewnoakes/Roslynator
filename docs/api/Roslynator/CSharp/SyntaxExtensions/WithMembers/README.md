# SyntaxExtensions\.WithMembers Method

**Containing Type**: [Roslynator.CSharp](../../README.md)\.[SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [WithMembers(ClassDeclarationSyntax, IEnumerable\<MemberDeclarationSyntax>)](#Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_ClassDeclarationSyntax_System_Collections_Generic_IEnumerable_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax__) | Creates a new [ClassDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.classdeclarationsyntax) with the members updated\. |
| [WithMembers(ClassDeclarationSyntax, MemberDeclarationSyntax)](#Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_ClassDeclarationSyntax_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax_) | Creates a new [ClassDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.classdeclarationsyntax) with the members updated\. |
| [WithMembers(CompilationUnitSyntax, IEnumerable\<MemberDeclarationSyntax>)](#Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_CompilationUnitSyntax_System_Collections_Generic_IEnumerable_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax__) | Creates a new [CompilationUnitSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.compilationunitsyntax) with the members updated\. |
| [WithMembers(CompilationUnitSyntax, MemberDeclarationSyntax)](#Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_CompilationUnitSyntax_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax_) | Creates a new [CompilationUnitSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.compilationunitsyntax) with the members updated\. |
| [WithMembers(InterfaceDeclarationSyntax, IEnumerable\<MemberDeclarationSyntax>)](#Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_InterfaceDeclarationSyntax_System_Collections_Generic_IEnumerable_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax__) | Creates a new [InterfaceDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.interfacedeclarationsyntax) with the members updated\. |
| [WithMembers(InterfaceDeclarationSyntax, MemberDeclarationSyntax)](#Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_InterfaceDeclarationSyntax_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax_) | Creates a new [InterfaceDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.interfacedeclarationsyntax) with the members updated\. |
| [WithMembers(NamespaceDeclarationSyntax, IEnumerable\<MemberDeclarationSyntax>)](#Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_NamespaceDeclarationSyntax_System_Collections_Generic_IEnumerable_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax__) | Creates a new [NamespaceDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.namespacedeclarationsyntax) with the members updated\. |
| [WithMembers(NamespaceDeclarationSyntax, MemberDeclarationSyntax)](#Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_NamespaceDeclarationSyntax_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax_) | Creates a new [NamespaceDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.namespacedeclarationsyntax) with the members updated\. |
| [WithMembers(StructDeclarationSyntax, IEnumerable\<MemberDeclarationSyntax>)](#Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_StructDeclarationSyntax_System_Collections_Generic_IEnumerable_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax__) | Creates a new [StructDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.structdeclarationsyntax) with the members updated\. |
| [WithMembers(StructDeclarationSyntax, MemberDeclarationSyntax)](#Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_StructDeclarationSyntax_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax_) | Creates a new [StructDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.structdeclarationsyntax) with the members updated\. |

## WithMembers\(ClassDeclarationSyntax, IEnumerable\<MemberDeclarationSyntax>\)<a name="Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_ClassDeclarationSyntax_System_Collections_Generic_IEnumerable_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax__"></a>

### Summary

Creates a new [ClassDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.classdeclarationsyntax) with the members updated\.

```csharp
public static ClassDeclarationSyntax WithMembers(this ClassDeclarationSyntax classDeclaration, IEnumerable<MemberDeclarationSyntax> members)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| classDeclaration | |
| members | |

#### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[ClassDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.classdeclarationsyntax)

## WithMembers\(ClassDeclarationSyntax, MemberDeclarationSyntax\)<a name="Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_ClassDeclarationSyntax_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax_"></a>

### Summary

Creates a new [ClassDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.classdeclarationsyntax) with the members updated\.

```csharp
public static ClassDeclarationSyntax WithMembers(this ClassDeclarationSyntax classDeclaration, MemberDeclarationSyntax member)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| classDeclaration | |
| member | |

#### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[ClassDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.classdeclarationsyntax)

## WithMembers\(CompilationUnitSyntax, IEnumerable\<MemberDeclarationSyntax>\)<a name="Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_CompilationUnitSyntax_System_Collections_Generic_IEnumerable_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax__"></a>

### Summary

Creates a new [CompilationUnitSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.compilationunitsyntax) with the members updated\.

```csharp
public static CompilationUnitSyntax WithMembers(this CompilationUnitSyntax compilationUnit, IEnumerable<MemberDeclarationSyntax> members)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| compilationUnit | |
| members | |

#### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[CompilationUnitSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.compilationunitsyntax)

## WithMembers\(CompilationUnitSyntax, MemberDeclarationSyntax\)<a name="Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_CompilationUnitSyntax_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax_"></a>

### Summary

Creates a new [CompilationUnitSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.compilationunitsyntax) with the members updated\.

```csharp
public static CompilationUnitSyntax WithMembers(this CompilationUnitSyntax compilationUnit, MemberDeclarationSyntax member)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| compilationUnit | |
| member | |

#### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[CompilationUnitSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.compilationunitsyntax)

## WithMembers\(InterfaceDeclarationSyntax, IEnumerable\<MemberDeclarationSyntax>\)<a name="Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_InterfaceDeclarationSyntax_System_Collections_Generic_IEnumerable_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax__"></a>

### Summary

Creates a new [InterfaceDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.interfacedeclarationsyntax) with the members updated\.

```csharp
public static InterfaceDeclarationSyntax WithMembers(this InterfaceDeclarationSyntax interfaceDeclaration, IEnumerable<MemberDeclarationSyntax> members)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| interfaceDeclaration | |
| members | |

#### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[InterfaceDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.interfacedeclarationsyntax)

## WithMembers\(InterfaceDeclarationSyntax, MemberDeclarationSyntax\)<a name="Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_InterfaceDeclarationSyntax_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax_"></a>

### Summary

Creates a new [InterfaceDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.interfacedeclarationsyntax) with the members updated\.

```csharp
public static InterfaceDeclarationSyntax WithMembers(this InterfaceDeclarationSyntax interfaceDeclaration, MemberDeclarationSyntax member)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| interfaceDeclaration | |
| member | |

#### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[InterfaceDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.interfacedeclarationsyntax)

## WithMembers\(NamespaceDeclarationSyntax, IEnumerable\<MemberDeclarationSyntax>\)<a name="Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_NamespaceDeclarationSyntax_System_Collections_Generic_IEnumerable_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax__"></a>

### Summary

Creates a new [NamespaceDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.namespacedeclarationsyntax) with the members updated\.

```csharp
public static NamespaceDeclarationSyntax WithMembers(this NamespaceDeclarationSyntax namespaceDeclaration, IEnumerable<MemberDeclarationSyntax> members)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| namespaceDeclaration | |
| members | |

#### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[NamespaceDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.namespacedeclarationsyntax)

## WithMembers\(NamespaceDeclarationSyntax, MemberDeclarationSyntax\)<a name="Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_NamespaceDeclarationSyntax_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax_"></a>

### Summary

Creates a new [NamespaceDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.namespacedeclarationsyntax) with the members updated\.

```csharp
public static NamespaceDeclarationSyntax WithMembers(this NamespaceDeclarationSyntax namespaceDeclaration, MemberDeclarationSyntax member)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| namespaceDeclaration | |
| member | |

#### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[NamespaceDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.namespacedeclarationsyntax)

## WithMembers\(StructDeclarationSyntax, IEnumerable\<MemberDeclarationSyntax>\)<a name="Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_StructDeclarationSyntax_System_Collections_Generic_IEnumerable_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax__"></a>

### Summary

Creates a new [StructDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.structdeclarationsyntax) with the members updated\.

```csharp
public static StructDeclarationSyntax WithMembers(this StructDeclarationSyntax structDeclaration, IEnumerable<MemberDeclarationSyntax> members)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| structDeclaration | |
| members | |

#### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[StructDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.structdeclarationsyntax)

## WithMembers\(StructDeclarationSyntax, MemberDeclarationSyntax\)<a name="Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_StructDeclarationSyntax_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax_"></a>

### Summary

Creates a new [StructDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.structdeclarationsyntax) with the members updated\.

```csharp
public static StructDeclarationSyntax WithMembers(this StructDeclarationSyntax structDeclaration, MemberDeclarationSyntax member)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| structDeclaration | |
| member | |

#### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[StructDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.structdeclarationsyntax)
