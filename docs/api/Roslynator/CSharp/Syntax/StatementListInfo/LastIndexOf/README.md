# StatementListInfo\.LastIndexOf Method <a name="_Top"></a>

[Home](../../../../../README.md)

**Containing Type**: [Roslynator.CSharp.Syntax](../../README.md#_Top)\.[StatementListInfo](../README.md#_Top)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [LastIndexOf(Func\<StatementSyntax, Boolean>)](#Roslynator_CSharp_Syntax_StatementListInfo_LastIndexOf_System_Func_Microsoft_CodeAnalysis_CSharp_Syntax_StatementSyntax_System_Boolean__) | Searches for a statement that matches the predicate and returns returns zero\-based index of the last occurrence in the list\. |
| [LastIndexOf(StatementSyntax)](#Roslynator_CSharp_Syntax_StatementListInfo_LastIndexOf_Microsoft_CodeAnalysis_CSharp_Syntax_StatementSyntax_) | Searches for a statement and returns zero\-based index of the last occurrence in the list\. |

## LastIndexOf\(Func\<StatementSyntax, Boolean>\) <a name="Roslynator_CSharp_Syntax_StatementListInfo_LastIndexOf_System_Func_Microsoft_CodeAnalysis_CSharp_Syntax_StatementSyntax_System_Boolean__"></a>

### Summary

Searches for a statement that matches the predicate and returns returns zero\-based index of the last occurrence in the list\.

```csharp
public int LastIndexOf(Func<StatementSyntax, bool> predicate)
```

### Parameters

#### predicate

### Returns

System\.[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

## LastIndexOf\(StatementSyntax\) <a name="Roslynator_CSharp_Syntax_StatementListInfo_LastIndexOf_Microsoft_CodeAnalysis_CSharp_Syntax_StatementSyntax_"></a>

### Summary

Searches for a statement and returns zero\-based index of the last occurrence in the list\.

```csharp
public int LastIndexOf(StatementSyntax statement)
```

### Parameters

#### statement

### Returns

System\.[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

