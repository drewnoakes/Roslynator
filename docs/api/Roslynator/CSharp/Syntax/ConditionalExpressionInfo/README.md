# ConditionalExpressionInfo Struct <a name="_Top"></a>

[Home](../../../../README.md) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods) &#x2022; [Operators](#operators)

**Namespace**: [Roslynator.CSharp.Syntax](../README.md#_Top)

**Assembly**: Roslynator\.CSharp\.dll

## Summary

Provides information about conditional expression\.

```csharp
public readonly struct ConditionalExpressionInfo : System.IEquatable<ConditionalExpressionInfo>
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) &#x2192; ConditionalExpressionInfo

### Implements

* System\.[IEquatable](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)\<[ConditionalExpressionInfo](#_Top)>

## Properties

| Property | Summary |
| -------- | ------- |
| [ColonToken](ColonToken/README.md#_Top) | The token representing the colon\. |
| [Condition](Condition/README.md#_Top) | The condition expression\. |
| [ConditionalExpression](ConditionalExpression/README.md#_Top) | The conditional expression\. |
| [QuestionToken](QuestionToken/README.md#_Top) | The token representing the question mark\. |
| [Success](Success/README.md#_Top) | Determines whether this struct was initialized with an actual syntax\. |
| [WhenFalse](WhenFalse/README.md#_Top) | The expression to be executed when the expression is false\. |
| [WhenTrue](WhenTrue/README.md#_Top) | The expression to be executed when the expression is true\. |

## Methods

| Method | Summary |
| ------ | ------- |
| [Equals(ConditionalExpressionInfo)](Equals/README.md#Roslynator_CSharp_Syntax_ConditionalExpressionInfo_Equals_Roslynator_CSharp_Syntax_ConditionalExpressionInfo_) | Determines whether this instance is equal to another object of the same type\. \(Implements [IEquatable\<ConditionalExpressionInfo>.Equals](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1.equals)\) |
| [Equals(Object)](Equals/README.md#Roslynator_CSharp_Syntax_ConditionalExpressionInfo_Equals_System_Object_) | Determines whether this instance and a specified object are equal\. \(Overrides [ValueType.Equals](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype.equals)\) |
| [GetHashCode()](GetHashCode/README.md#_Top) | Returns the hash code for this instance\. \(Overrides [ValueType.GetHashCode](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype.gethashcode)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](ToString/README.md#_Top) | Returns the string representation of the underlying syntax, not including its leading and trailing trivia\. \(Overrides [ValueType.ToString](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype.tostring)\) |

## Operators

| Operator | Summary |
| -------- | ------- |
| [Equality(ConditionalExpressionInfo, ConditionalExpressionInfo)](op_Equality/README.md#_Top) | |
| [Inequality(ConditionalExpressionInfo, ConditionalExpressionInfo)](op_Inequality/README.md#_Top) | |

