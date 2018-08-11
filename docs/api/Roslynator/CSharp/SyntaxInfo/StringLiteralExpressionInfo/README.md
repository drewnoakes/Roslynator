# SyntaxInfo\.StringLiteralExpressionInfo Method

**Containing Type**: [Roslynator.CSharp](../../README.md)\.[SyntaxInfo](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [StringLiteralExpressionInfo(LiteralExpressionSyntax)](#Roslynator_CSharp_SyntaxInfo_StringLiteralExpressionInfo_Microsoft_CodeAnalysis_CSharp_Syntax_LiteralExpressionSyntax_) | Creates a new [StringLiteralExpressionInfo](../../Syntax/StringLiteralExpressionInfo/README.md) from the specified literal expression\. |
| [StringLiteralExpressionInfo(SyntaxNode, Boolean)](#Roslynator_CSharp_SyntaxInfo_StringLiteralExpressionInfo_Microsoft_CodeAnalysis_SyntaxNode_System_Boolean_) | Creates a new [StringLiteralExpressionInfo](../../Syntax/StringLiteralExpressionInfo/README.md) from the specified node\. |

## StringLiteralExpressionInfo\(LiteralExpressionSyntax\)<a name="Roslynator_CSharp_SyntaxInfo_StringLiteralExpressionInfo_Microsoft_CodeAnalysis_CSharp_Syntax_LiteralExpressionSyntax_"></a>

### Summary

Creates a new [StringLiteralExpressionInfo](../../Syntax/StringLiteralExpressionInfo/README.md) from the specified literal expression\.

```csharp
public static StringLiteralExpressionInfo StringLiteralExpressionInfo(LiteralExpressionSyntax literalExpression)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| literalExpression | |

#### Returns

Roslynator\.CSharp\.Syntax\.[StringLiteralExpressionInfo](../../Syntax/StringLiteralExpressionInfo/README.md)

## StringLiteralExpressionInfo\(SyntaxNode, Boolean\)<a name="Roslynator_CSharp_SyntaxInfo_StringLiteralExpressionInfo_Microsoft_CodeAnalysis_SyntaxNode_System_Boolean_"></a>

### Summary

Creates a new [StringLiteralExpressionInfo](../../Syntax/StringLiteralExpressionInfo/README.md) from the specified node\.

```csharp
public static StringLiteralExpressionInfo StringLiteralExpressionInfo(SyntaxNode node, bool walkDownParentheses = true)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| node | |
| walkDownParentheses | |

#### Returns

Roslynator\.CSharp\.Syntax\.[StringLiteralExpressionInfo](../../Syntax/StringLiteralExpressionInfo/README.md)
