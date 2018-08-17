<a name="_Top"></a>

# WorkspaceSyntaxExtensions\.WithRenameAnnotation\(SyntaxToken\) Method

[Home](../../../../README.md#_Top)

**Containing Type**: [Roslynator.CSharp](../../README.md#_Top)\.[WorkspaceSyntaxExtensions](../README.md#_Top)

**Assembly**: Roslynator\.CSharp\.Workspaces\.dll

## Summary

Adds "rename" annotation to the specified token, creating a new token of the same type with the "rename" annotation on it\.
"Rename" annotation is specified by [RenameAnnotation.Kind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.codeactions.renameannotation.kind)\.

```csharp
public static SyntaxToken WithRenameAnnotation(this SyntaxToken token)
```

### Parameters

#### token

### Returns

Microsoft\.CodeAnalysis\.[SyntaxToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtoken)

