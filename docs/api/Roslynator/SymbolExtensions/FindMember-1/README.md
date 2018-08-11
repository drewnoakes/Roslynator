# SymbolExtensions\.FindMember Method

**Containing Type**: [Roslynator](../../README.md)\.[SymbolExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [FindMember\<TSymbol>(ITypeSymbol, Func\<TSymbol, Boolean>)](#Roslynator_SymbolExtensions_FindMember__1_Microsoft_CodeAnalysis_ITypeSymbol_System_Func___0_System_Boolean__) | Searches for a member that matches the conditions defined by the specified predicate, if any, and returns the first occurrence within the type's members\. |
| [FindMember\<TSymbol>(ITypeSymbol, String, Func\<TSymbol, Boolean>)](#Roslynator_SymbolExtensions_FindMember__1_Microsoft_CodeAnalysis_ITypeSymbol_System_String_System_Func___0_System_Boolean__) | Searches for a member that has the specified name and matches the conditions defined by the specified predicate, if any, and returns the first occurrence within the type's members\. |

## FindMember\<TSymbol>\(ITypeSymbol, Func\<TSymbol, Boolean>\)<a name="Roslynator_SymbolExtensions_FindMember__1_Microsoft_CodeAnalysis_ITypeSymbol_System_Func___0_System_Boolean__"></a>

### Summary

Searches for a member that matches the conditions defined by the specified predicate, if any, and returns the first occurrence within the type's members\.

```csharp
public static TSymbol FindMember<TSymbol>(this ITypeSymbol typeSymbol, Func<TSymbol, bool> predicate = null) where TSymbol : Microsoft.CodeAnalysis.ISymbol
```

#### Type Parameters

| Name | Summary |
| ---- | ------- |
| TSymbol | |

#### Parameters

| Name | Summary |
| ---- | ------- |
| typeSymbol | |
| predicate | |

#### Returns

TSymbol

## FindMember\<TSymbol>\(ITypeSymbol, String, Func\<TSymbol, Boolean>\)<a name="Roslynator_SymbolExtensions_FindMember__1_Microsoft_CodeAnalysis_ITypeSymbol_System_String_System_Func___0_System_Boolean__"></a>

### Summary

Searches for a member that has the specified name and matches the conditions defined by the specified predicate, if any, and returns the first occurrence within the type's members\.

```csharp
public static TSymbol FindMember<TSymbol>(this ITypeSymbol typeSymbol, string name, Func<TSymbol, bool> predicate = null) where TSymbol : Microsoft.CodeAnalysis.ISymbol
```

#### Type Parameters

| Name | Summary |
| ---- | ------- |
| TSymbol | |

#### Parameters

| Name | Summary |
| ---- | ------- |
| typeSymbol | |
| name | |
| predicate | |

#### Returns

TSymbol
