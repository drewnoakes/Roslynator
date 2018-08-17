# RegionInfo Struct <a name="_Top"></a>

[Home](../../../../README.md) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods) &#x2022; [Operators](#operators)

**Namespace**: [Roslynator.CSharp.Syntax](../README.md#_Top)

**Assembly**: Roslynator\.CSharp\.dll

## Summary

Provides information about a region\.

```csharp
public readonly struct RegionInfo : System.IEquatable<RegionInfo>
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) &#x2192; RegionInfo

### Implements

* System\.[IEquatable](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)\<[RegionInfo](#_Top)>

## Properties

| Property | Summary |
| -------- | ------- |
| [Directive](Directive/README.md#_Top) | \#region directive\. |
| [EndDirective](EndDirective/README.md#_Top) | \#endregion directive\. |
| [FullSpan](FullSpan/README.md#_Top) | The absolute span of this region, including its leading and trailing trivia\. |
| [IsEmpty](IsEmpty/README.md#_Top) | Determines whether this region is empty, i\.e\. contains only white\-space\. |
| [Span](Span/README.md#_Top) | The absolute span of this region, not including its leading and trailing trivia\. |
| [Success](Success/README.md#_Top) | Determines whether this struct was initialized with an actual syntax\. |

## Methods

| Method | Summary |
| ------ | ------- |
| [Equals(Object)](Equals/README.md#Roslynator_CSharp_Syntax_RegionInfo_Equals_System_Object_) | Determines whether this instance and a specified object are equal\. \(Overrides [ValueType.Equals](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype.equals)\) |
| [Equals(RegionInfo)](Equals/README.md#Roslynator_CSharp_Syntax_RegionInfo_Equals_Roslynator_CSharp_Syntax_RegionInfo_) | Determines whether this instance is equal to another object of the same type\. \(Implements [IEquatable\<RegionInfo>.Equals](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1.equals)\) |
| [GetHashCode()](GetHashCode/README.md#_Top) | Returns the hash code for this instance\. \(Overrides [ValueType.GetHashCode](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype.gethashcode)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](ToString/README.md#_Top) | Returns the string representation of the underlying syntax, not including its leading and trailing trivia\. \(Overrides [ValueType.ToString](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype.tostring)\) |

## Operators

| Operator | Summary |
| -------- | ------- |
| [Equality(RegionInfo, RegionInfo)](op_Equality/README.md#_Top) | |
| [Inequality(RegionInfo, RegionInfo)](op_Inequality/README.md#_Top) | |

