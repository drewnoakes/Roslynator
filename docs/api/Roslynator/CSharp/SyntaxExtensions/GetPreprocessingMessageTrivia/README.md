# SyntaxExtensions\.GetPreprocessingMessageTrivia Method <a name="_Top"></a>

[Home](../../../../README.md)

**Containing Type**: [Roslynator.CSharp](../../README.md#_Top)\.[SyntaxExtensions](../README.md#_Top)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [GetPreprocessingMessageTrivia(EndRegionDirectiveTriviaSyntax)](#Roslynator_CSharp_SyntaxExtensions_GetPreprocessingMessageTrivia_Microsoft_CodeAnalysis_CSharp_Syntax_EndRegionDirectiveTriviaSyntax_) | Gets preprocessing message for the specified endregion directive if such message exists\. |
| [GetPreprocessingMessageTrivia(RegionDirectiveTriviaSyntax)](#Roslynator_CSharp_SyntaxExtensions_GetPreprocessingMessageTrivia_Microsoft_CodeAnalysis_CSharp_Syntax_RegionDirectiveTriviaSyntax_) | Gets preprocessing message for the specified region directive if such message exists\. |

## GetPreprocessingMessageTrivia\(EndRegionDirectiveTriviaSyntax\) <a name="Roslynator_CSharp_SyntaxExtensions_GetPreprocessingMessageTrivia_Microsoft_CodeAnalysis_CSharp_Syntax_EndRegionDirectiveTriviaSyntax_"></a>

### Summary

Gets preprocessing message for the specified endregion directive if such message exists\.

```csharp
public static SyntaxTrivia GetPreprocessingMessageTrivia(this EndRegionDirectiveTriviaSyntax endRegionDirective)
```

### Parameters

#### endRegionDirective

### Returns

Microsoft\.CodeAnalysis\.[SyntaxTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivia)

## GetPreprocessingMessageTrivia\(RegionDirectiveTriviaSyntax\) <a name="Roslynator_CSharp_SyntaxExtensions_GetPreprocessingMessageTrivia_Microsoft_CodeAnalysis_CSharp_Syntax_RegionDirectiveTriviaSyntax_"></a>

### Summary

Gets preprocessing message for the specified region directive if such message exists\.

```csharp
public static SyntaxTrivia GetPreprocessingMessageTrivia(this RegionDirectiveTriviaSyntax regionDirective)
```

### Parameters

#### regionDirective

### Returns

Microsoft\.CodeAnalysis\.[SyntaxTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivia)

