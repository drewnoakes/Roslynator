# UsingDirectiveListInfo\.Item\[Int32\] Property

**Containing Type**: [Roslynator.CSharp.Syntax](../../README.md)\.[UsingDirectiveListInfo](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Summary

Gets the using directive at the specified index in the list\.

```csharp
public UsingDirectiveSyntax this[int index] { get; }
```

### Parameters

| Name | Summary |
| ---- | ------- |
| index | The zero\-based index of the using directive to get\.  |

### Property Value

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[UsingDirectiveSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.usingdirectivesyntax)

The using directive at the specified index in the list\.

### Implements

* [IReadOnlyList\<UsingDirectiveSyntax>.Item](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1.item)