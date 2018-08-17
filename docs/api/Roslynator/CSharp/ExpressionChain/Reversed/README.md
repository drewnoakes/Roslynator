<a name="_Top"></a>

# ExpressionChain\.Reversed Struct

[Home](../../../../README.md#_Top) &#x2022; [Constructors](#constructors) &#x2022; [Methods](#methods) &#x2022; [Operators](#operators) &#x2022; [Explicit Interface Implementations](#explicit-interface-implementations) &#x2022; [Structs](#structs)

**Namespace**: [Roslynator.CSharp](../../README.md#_Top)

**Assembly**: Roslynator\.CSharp\.dll

## Summary

Enables to enumerate expressions of [ExpressionChain](../README.md#_Top) in a reversed order\.

```csharp
public readonly struct ExpressionChain.Reversed : System.IEquatable<ExpressionChain.Reversed>,
    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) &#x2192; ExpressionChain\.Reversed

### Implements

* System\.[IEquatable](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)\<[ExpressionChain.Reversed](#_Top)>
* System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[ExpressionSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.expressionsyntax)>

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [Reversed(ExpressionChain)](-ctor/README.md#_Top) | |

## Methods

| Method | Summary |
| ------ | ------- |
| [Equals(Object)](Equals/README.md#Roslynator_CSharp_ExpressionChain_Reversed_Equals_System_Object_) |  \(Overrides [ValueType.Equals](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype.equals)\) |
| [Equals(Reversed)](Equals/README.md#Roslynator_CSharp_ExpressionChain_Reversed_Equals_Roslynator_CSharp_ExpressionChain_Reversed_) |  \(Implements [IEquatable\<Reversed>.Equals](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1.equals)\) |
| [GetEnumerator()](GetEnumerator/README.md#_Top) | |
| [GetHashCode()](GetHashCode/README.md#_Top) |  \(Overrides [ValueType.GetHashCode](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype.gethashcode)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](ToString/README.md#_Top) |  \(Overrides [ValueType.ToString](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype.tostring)\) |

## Operators

| Operator | Summary |
| -------- | ------- |
| [Equality(Reversed, Reversed)](op_Equality/README.md#_Top) | |
| [Inequality(Reversed, Reversed)](op_Inequality/README.md#_Top) | |

## Explicit Interface Implementations

| Member | Summary |
| ------ | ------- |
| [IEnumerable.GetEnumerator()](System-Collections-IEnumerable-GetEnumerator/README.md#_Top) | |
| [IEnumerable\<ExpressionSyntax>.GetEnumerator()](System-Collections-Generic-IEnumerable-Microsoft-CodeAnalysis-CSharp-Syntax-ExpressionSyntax--GetEnumerator/README.md#_Top) | |

## Structs

| Struct | Summary |
| ------ | ------- |
| [Enumerator](Enumerator/README.md#_Top) | |

