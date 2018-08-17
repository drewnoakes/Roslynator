# ModifierList\.Remove Method <a name="_Top"></a>

[Home](../../../../README.md)

**Containing Type**: [Roslynator.CSharp](../../README.md#_Top)\.[ModifierList](../README.md#_Top)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Remove\<TNode>(TNode, SyntaxKind)](#Roslynator_CSharp_ModifierList_Remove__1___0_Microsoft_CodeAnalysis_CSharp_SyntaxKind_) | Creates a new node with a modifier of the specified kind removed\. |
| [Remove\<TNode>(TNode, SyntaxToken)](#Roslynator_CSharp_ModifierList_Remove__1___0_Microsoft_CodeAnalysis_SyntaxToken_) | Creates a new node with the specified modifier removed\. |

## Remove\<TNode>\(TNode, SyntaxKind\) <a name="Roslynator_CSharp_ModifierList_Remove__1___0_Microsoft_CodeAnalysis_CSharp_SyntaxKind_"></a>

### Summary

Creates a new node with a modifier of the specified kind removed\.

```csharp
public static TNode Remove<TNode>(TNode node, SyntaxKind kind) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

#### TNode

### Parameters

#### node

#### kind

### Returns

TNode

## Remove\<TNode>\(TNode, SyntaxToken\) <a name="Roslynator_CSharp_ModifierList_Remove__1___0_Microsoft_CodeAnalysis_SyntaxToken_"></a>

### Summary

Creates a new node with the specified modifier removed\.

```csharp
public static TNode Remove<TNode>(TNode node, SyntaxToken modifier) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

#### TNode

### Parameters

#### node

#### modifier

### Returns

TNode

