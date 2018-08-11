# SymbolExtensions\.GetAttribute\(ISymbol, INamedTypeSymbol\) Method

**Containing Type**: [Roslynator](../../README.md)\.[SymbolExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Summary

Returns the attribute for the symbol that matches the specified attribute class, or null if the symbol does not have the specified attribute\.

```csharp
public static AttributeData GetAttribute(this ISymbol symbol, INamedTypeSymbol attributeClass)
```

### Parameters

| Name | Summary |
| ---- | ------- |
| symbol | |
| attributeClass | |

### Returns

Microsoft\.CodeAnalysis\.[AttributeData](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.attributedata)
