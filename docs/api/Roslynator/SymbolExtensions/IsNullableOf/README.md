# SymbolExtensions\.IsNullableOf Method

**Containing Type**: [Roslynator](../../README.md)\.[SymbolExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [IsNullableOf(INamedTypeSymbol, ITypeSymbol)](#Roslynator_SymbolExtensions_IsNullableOf_Microsoft_CodeAnalysis_INamedTypeSymbol_Microsoft_CodeAnalysis_ITypeSymbol_) | Returns true if the type is [Nullable\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1) and it has specified type argument\. |
| [IsNullableOf(INamedTypeSymbol, SpecialType)](#Roslynator_SymbolExtensions_IsNullableOf_Microsoft_CodeAnalysis_INamedTypeSymbol_Microsoft_CodeAnalysis_SpecialType_) | Returns true if the type is [Nullable\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1) and it has specified type argument\. |
| [IsNullableOf(ITypeSymbol, ITypeSymbol)](#Roslynator_SymbolExtensions_IsNullableOf_Microsoft_CodeAnalysis_ITypeSymbol_Microsoft_CodeAnalysis_ITypeSymbol_) | Returns true if the type is [Nullable\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1) and it has specified type argument\. |
| [IsNullableOf(ITypeSymbol, SpecialType)](#Roslynator_SymbolExtensions_IsNullableOf_Microsoft_CodeAnalysis_ITypeSymbol_Microsoft_CodeAnalysis_SpecialType_) | Returns true if the type is [Nullable\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1) and it has specified type argument\. |

## IsNullableOf\(INamedTypeSymbol, ITypeSymbol\)<a name="Roslynator_SymbolExtensions_IsNullableOf_Microsoft_CodeAnalysis_INamedTypeSymbol_Microsoft_CodeAnalysis_ITypeSymbol_"></a>

### Summary

Returns true if the type is [Nullable\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1) and it has specified type argument\.

```csharp
public static bool IsNullableOf(this INamedTypeSymbol namedTypeSymbol, ITypeSymbol typeArgument)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| namedTypeSymbol | |
| typeArgument | |

#### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsNullableOf\(INamedTypeSymbol, SpecialType\)<a name="Roslynator_SymbolExtensions_IsNullableOf_Microsoft_CodeAnalysis_INamedTypeSymbol_Microsoft_CodeAnalysis_SpecialType_"></a>

### Summary

Returns true if the type is [Nullable\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1) and it has specified type argument\.

```csharp
public static bool IsNullableOf(this INamedTypeSymbol namedTypeSymbol, SpecialType specialType)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| namedTypeSymbol | |
| specialType | |

#### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsNullableOf\(ITypeSymbol, ITypeSymbol\)<a name="Roslynator_SymbolExtensions_IsNullableOf_Microsoft_CodeAnalysis_ITypeSymbol_Microsoft_CodeAnalysis_ITypeSymbol_"></a>

### Summary

Returns true if the type is [Nullable\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1) and it has specified type argument\.

```csharp
public static bool IsNullableOf(this ITypeSymbol typeSymbol, ITypeSymbol typeArgument)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| typeSymbol | |
| typeArgument | |

#### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsNullableOf\(ITypeSymbol, SpecialType\)<a name="Roslynator_SymbolExtensions_IsNullableOf_Microsoft_CodeAnalysis_ITypeSymbol_Microsoft_CodeAnalysis_SpecialType_"></a>

### Summary

Returns true if the type is [Nullable\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1) and it has specified type argument\.

```csharp
public static bool IsNullableOf(this ITypeSymbol typeSymbol, SpecialType specialType)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| typeSymbol | |
| specialType | |

#### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)
