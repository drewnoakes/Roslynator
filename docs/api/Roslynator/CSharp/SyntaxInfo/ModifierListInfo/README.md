# SyntaxInfo\.ModifierListInfo Method

**Containing Type**: [Roslynator.CSharp](../../README.md)\.[SyntaxInfo](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [ModifierListInfo(AccessorDeclarationSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_AccessorDeclarationSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified accessor declaration\. |
| [ModifierListInfo(ClassDeclarationSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_ClassDeclarationSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified class declaration\. |
| [ModifierListInfo(ConstructorDeclarationSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_ConstructorDeclarationSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified constructor declaration\. |
| [ModifierListInfo(ConversionOperatorDeclarationSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_ConversionOperatorDeclarationSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified conversion operator declaration\. |
| [ModifierListInfo(DelegateDeclarationSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_DelegateDeclarationSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified delegate declaration\. |
| [ModifierListInfo(DestructorDeclarationSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_DestructorDeclarationSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified destructor declaration\. |
| [ModifierListInfo(EnumDeclarationSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_EnumDeclarationSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified enum declaration\. |
| [ModifierListInfo(EventDeclarationSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_EventDeclarationSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified event declaration\. |
| [ModifierListInfo(EventFieldDeclarationSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_EventFieldDeclarationSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified event field declaration\. |
| [ModifierListInfo(FieldDeclarationSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_FieldDeclarationSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified field declaration\. |
| [ModifierListInfo(IncompleteMemberSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_IncompleteMemberSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified incomplete member\. |
| [ModifierListInfo(IndexerDeclarationSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_IndexerDeclarationSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified indexer declaration\. |
| [ModifierListInfo(InterfaceDeclarationSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_InterfaceDeclarationSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified interface declaration\. |
| [ModifierListInfo(LocalDeclarationStatementSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_LocalDeclarationStatementSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified local declaration statement\. |
| [ModifierListInfo(LocalFunctionStatementSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_LocalFunctionStatementSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified local function\. |
| [ModifierListInfo(MethodDeclarationSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_MethodDeclarationSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified method declaration\. |
| [ModifierListInfo(OperatorDeclarationSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_OperatorDeclarationSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified operator declaration\. |
| [ModifierListInfo(ParameterSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_ParameterSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified parameter\. |
| [ModifierListInfo(PropertyDeclarationSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_PropertyDeclarationSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified property declaration\. |
| [ModifierListInfo(StructDeclarationSyntax)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_StructDeclarationSyntax_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified struct declaration\. |
| [ModifierListInfo(SyntaxNode)](#Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_SyntaxNode_) | Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified node\. |

## ModifierListInfo\(AccessorDeclarationSyntax\)<a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_AccessorDeclarationSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified accessor declaration\.

```csharp
public static ModifierListInfo ModifierListInfo(AccessorDeclarationSyntax accessorDeclaration)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| accessorDeclaration | |

#### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(ClassDeclarationSyntax\)<a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_ClassDeclarationSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified class declaration\.

```csharp
public static ModifierListInfo ModifierListInfo(ClassDeclarationSyntax classDeclaration)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| classDeclaration | |

#### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(ConstructorDeclarationSyntax\)<a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_ConstructorDeclarationSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified constructor declaration\.

```csharp
public static ModifierListInfo ModifierListInfo(ConstructorDeclarationSyntax constructorDeclaration)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| constructorDeclaration | |

#### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(ConversionOperatorDeclarationSyntax\)<a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_ConversionOperatorDeclarationSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified conversion operator declaration\.

```csharp
public static ModifierListInfo ModifierListInfo(ConversionOperatorDeclarationSyntax conversionOperatorDeclaration)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| conversionOperatorDeclaration | |

#### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(DelegateDeclarationSyntax\)<a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_DelegateDeclarationSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified delegate declaration\.

```csharp
public static ModifierListInfo ModifierListInfo(DelegateDeclarationSyntax delegateDeclaration)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| delegateDeclaration | |

#### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(DestructorDeclarationSyntax\)<a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_DestructorDeclarationSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified destructor declaration\.

```csharp
public static ModifierListInfo ModifierListInfo(DestructorDeclarationSyntax destructorDeclaration)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| destructorDeclaration | |

#### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(EnumDeclarationSyntax\)<a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_EnumDeclarationSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified enum declaration\.

```csharp
public static ModifierListInfo ModifierListInfo(EnumDeclarationSyntax enumDeclaration)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| enumDeclaration | |

#### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(EventDeclarationSyntax\)<a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_EventDeclarationSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified event declaration\.

```csharp
public static ModifierListInfo ModifierListInfo(EventDeclarationSyntax eventDeclaration)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| eventDeclaration | |

#### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(EventFieldDeclarationSyntax\)<a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_EventFieldDeclarationSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified event field declaration\.

```csharp
public static ModifierListInfo ModifierListInfo(EventFieldDeclarationSyntax eventFieldDeclaration)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| eventFieldDeclaration | |

#### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(FieldDeclarationSyntax\)<a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_FieldDeclarationSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified field declaration\.

```csharp
public static ModifierListInfo ModifierListInfo(FieldDeclarationSyntax fieldDeclaration)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| fieldDeclaration | |

#### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(IncompleteMemberSyntax\)<a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_IncompleteMemberSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified incomplete member\.

```csharp
public static ModifierListInfo ModifierListInfo(IncompleteMemberSyntax incompleteMember)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| incompleteMember | |

#### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(IndexerDeclarationSyntax\)<a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_IndexerDeclarationSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified indexer declaration\.

```csharp
public static ModifierListInfo ModifierListInfo(IndexerDeclarationSyntax indexerDeclaration)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| indexerDeclaration | |

#### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(InterfaceDeclarationSyntax\)<a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_InterfaceDeclarationSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified interface declaration\.

```csharp
public static ModifierListInfo ModifierListInfo(InterfaceDeclarationSyntax interfaceDeclaration)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| interfaceDeclaration | |

#### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(LocalDeclarationStatementSyntax\)<a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_LocalDeclarationStatementSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified local declaration statement\.

```csharp
public static ModifierListInfo ModifierListInfo(LocalDeclarationStatementSyntax localDeclarationStatement)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| localDeclarationStatement | |

#### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(LocalFunctionStatementSyntax\)<a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_LocalFunctionStatementSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified local function\.

```csharp
public static ModifierListInfo ModifierListInfo(LocalFunctionStatementSyntax localFunctionStatement)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| localFunctionStatement | |

#### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(MethodDeclarationSyntax\)<a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_MethodDeclarationSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified method declaration\.

```csharp
public static ModifierListInfo ModifierListInfo(MethodDeclarationSyntax methodDeclaration)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| methodDeclaration | |

#### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(OperatorDeclarationSyntax\)<a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_OperatorDeclarationSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified operator declaration\.

```csharp
public static ModifierListInfo ModifierListInfo(OperatorDeclarationSyntax operatorDeclaration)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| operatorDeclaration | |

#### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(ParameterSyntax\)<a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_ParameterSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified parameter\.

```csharp
public static ModifierListInfo ModifierListInfo(ParameterSyntax parameter)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| parameter | |

#### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(PropertyDeclarationSyntax\)<a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_PropertyDeclarationSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified property declaration\.

```csharp
public static ModifierListInfo ModifierListInfo(PropertyDeclarationSyntax propertyDeclaration)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| propertyDeclaration | |

#### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(StructDeclarationSyntax\)<a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_CSharp_Syntax_StructDeclarationSyntax_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified struct declaration\.

```csharp
public static ModifierListInfo ModifierListInfo(StructDeclarationSyntax structDeclaration)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| structDeclaration | |

#### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)

## ModifierListInfo\(SyntaxNode\)<a name="Roslynator_CSharp_SyntaxInfo_ModifierListInfo_Microsoft_CodeAnalysis_SyntaxNode_"></a>

### Summary

Creates a new [ModifierListInfo](../../Syntax/ModifierListInfo/README.md) from the specified node\.

```csharp
public static ModifierListInfo ModifierListInfo(SyntaxNode node)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| node | |

#### Returns

Roslynator\.CSharp\.Syntax\.[ModifierListInfo](../../Syntax/ModifierListInfo/README.md)
