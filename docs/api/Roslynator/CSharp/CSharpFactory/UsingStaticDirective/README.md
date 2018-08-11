# CSharpFactory\.UsingStaticDirective Method

**Containing Type**: [Roslynator.CSharp](../../README.md)\.[CSharpFactory](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [UsingStaticDirective(NameSyntax)](#Roslynator_CSharp_CSharpFactory_UsingStaticDirective_Microsoft_CodeAnalysis_CSharp_Syntax_NameSyntax_) | |
| [UsingStaticDirective(SyntaxToken, SyntaxToken, NameSyntax, SyntaxToken)](#Roslynator_CSharp_CSharpFactory_UsingStaticDirective_Microsoft_CodeAnalysis_SyntaxToken_Microsoft_CodeAnalysis_SyntaxToken_Microsoft_CodeAnalysis_CSharp_Syntax_NameSyntax_Microsoft_CodeAnalysis_SyntaxToken_) | |

## UsingStaticDirective\(NameSyntax\)<a name="Roslynator_CSharp_CSharpFactory_UsingStaticDirective_Microsoft_CodeAnalysis_CSharp_Syntax_NameSyntax_"></a>

```csharp
public static UsingDirectiveSyntax UsingStaticDirective(NameSyntax name)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| name | |

#### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[UsingDirectiveSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.usingdirectivesyntax)

## UsingStaticDirective\(SyntaxToken, SyntaxToken, NameSyntax, SyntaxToken\)<a name="Roslynator_CSharp_CSharpFactory_UsingStaticDirective_Microsoft_CodeAnalysis_SyntaxToken_Microsoft_CodeAnalysis_SyntaxToken_Microsoft_CodeAnalysis_CSharp_Syntax_NameSyntax_Microsoft_CodeAnalysis_SyntaxToken_"></a>

```csharp
public static UsingDirectiveSyntax UsingStaticDirective(SyntaxToken usingKeyword, SyntaxToken staticKeyword, NameSyntax name, SyntaxToken semicolonToken)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| usingKeyword | |
| staticKeyword | |
| name | |
| semicolonToken | |

#### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[UsingDirectiveSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.usingdirectivesyntax)
