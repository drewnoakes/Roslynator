# SyntaxExtensions\.IsFirst Method <a name="_Top"></a>

[Home](../../../README.md)

**Containing Type**: [Roslynator](../../README.md#_Top)\.[SyntaxExtensions](../README.md#_Top)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [IsFirst\<TNode>(SeparatedSyntaxList\<TNode>, TNode)](#Roslynator_SyntaxExtensions_IsFirst__1_Microsoft_CodeAnalysis_SeparatedSyntaxList___0____0_) | Returns true if the specified node is a first node in the list\. |
| [IsFirst\<TNode>(SyntaxList\<TNode>, TNode)](#Roslynator_SyntaxExtensions_IsFirst__1_Microsoft_CodeAnalysis_SyntaxList___0____0_) | Returns true if the specified node is a first node in the list\. |

## IsFirst\<TNode>\(SeparatedSyntaxList\<TNode>, TNode\) <a name="Roslynator_SyntaxExtensions_IsFirst__1_Microsoft_CodeAnalysis_SeparatedSyntaxList___0____0_"></a>

### Summary

Returns true if the specified node is a first node in the list\.

```csharp
public static bool IsFirst<TNode>(this SeparatedSyntaxList<TNode> list, TNode node) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

#### TNode

### Parameters

#### list

#### node

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsFirst\<TNode>\(SyntaxList\<TNode>, TNode\) <a name="Roslynator_SyntaxExtensions_IsFirst__1_Microsoft_CodeAnalysis_SyntaxList___0____0_"></a>

### Summary

Returns true if the specified node is a first node in the list\.

```csharp
public static bool IsFirst<TNode>(this SyntaxList<TNode> list, TNode node) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

#### TNode

### Parameters

#### list

#### node

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

