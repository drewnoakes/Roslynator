# SyntaxExtensions\.TrimLeadingTrivia Method <a name="_Top"></a>

[Home](../../../../README.md)

**Containing Type**: [Roslynator.CSharp](../../README.md#_Top)\.[SyntaxExtensions](../README.md#_Top)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [TrimLeadingTrivia(SyntaxToken)](../TrimLeadingTrivia/README.md#Roslynator_CSharp_SyntaxExtensions_TrimLeadingTrivia_Microsoft_CodeAnalysis_SyntaxToken_) | Removes all leading whitespace from the leading trivia and returns a new token with the new leading trivia\. [SyntaxKind.WhitespaceTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind.whitespacetrivia) and [SyntaxKind.EndOfLineTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind.endoflinetrivia) is considered to be a whitespace\. Returns the same token if there is nothing to trim\. |
| [TrimLeadingTrivia\<TNode>(TNode)](#Roslynator_CSharp_SyntaxExtensions_TrimLeadingTrivia__1___0_) | Removes all leading whitespace from the leading trivia and returns a new node with the new leading trivia\. [SyntaxKind.WhitespaceTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind.whitespacetrivia) and [SyntaxKind.EndOfLineTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind.endoflinetrivia) is considered to be a whitespace\. Returns the same node if there is nothing to trim\. |

## TrimLeadingTrivia\(SyntaxToken\) <a name="Roslynator_CSharp_SyntaxExtensions_TrimLeadingTrivia_Microsoft_CodeAnalysis_SyntaxToken_"></a>

### Summary

Removes all leading whitespace from the leading trivia and returns a new token with the new leading trivia\.
[SyntaxKind.WhitespaceTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind.whitespacetrivia) and [SyntaxKind.EndOfLineTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind.endoflinetrivia) is considered to be a whitespace\.
Returns the same token if there is nothing to trim\.

```csharp
public static SyntaxToken TrimLeadingTrivia(this SyntaxToken token)
```

### Parameters

#### token

### Returns

Microsoft\.CodeAnalysis\.[SyntaxToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtoken)

## TrimLeadingTrivia\<TNode>\(TNode\) <a name="Roslynator_CSharp_SyntaxExtensions_TrimLeadingTrivia__1___0_"></a>

### Summary

Removes all leading whitespace from the leading trivia and returns a new node with the new leading trivia\.
[SyntaxKind.WhitespaceTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind.whitespacetrivia) and [SyntaxKind.EndOfLineTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind.endoflinetrivia) is considered to be a whitespace\.
Returns the same node if there is nothing to trim\.

```csharp
public static TNode TrimLeadingTrivia<TNode>(this TNode node) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

#### TNode

### Parameters

#### node

### Returns

TNode

