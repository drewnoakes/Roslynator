<a name="_Top"></a>

# SemanticModelExtensions Class

[Home](../../README.md#_Top) &#x2022; [Methods](#methods)

**Namespace**: [Roslynator](../README.md#_Top)

**Assembly**: Roslynator\.CSharp\.dll

## Summary

A set of extension methods for a [SemanticModel](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.semanticmodel)\.

```csharp
public static class SemanticModelExtensions
```

## Methods

| Method | Summary |
| ------ | ------- |
| [GetEnclosingNamedType(SemanticModel, Int32, CancellationToken)](GetEnclosingNamedType/README.md#_Top) | Returns the innermost named type symbol that the specified position is considered inside of\. |
| [GetEnclosingSymbol\<TSymbol>(SemanticModel, Int32, CancellationToken)](GetEnclosingSymbol-1/README.md#_Top) | Returns the innermost symbol of type **TSymbol** that the specified position is considered inside of\. |
| [GetSymbol(SemanticModel, SyntaxNode, CancellationToken)](GetSymbol/README.md#_Top) | Returns what symbol, if any, the specified node bound to\. |
| [GetTypeByMetadataName(SemanticModel, String)](GetTypeByMetadataName/README.md#_Top) | Returns the type within the compilation's assembly using its canonical CLR metadata name\. |
| [GetTypeSymbol(SemanticModel, SyntaxNode, CancellationToken)](GetTypeSymbol/README.md#_Top) | Returns type information about the specified node\. |

