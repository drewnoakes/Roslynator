# SimpleIfStatementInfo Struct

Namespace: [Roslynator.CSharp.Syntax](../README.md)

Assembly: Roslynator\.CSharp\.dll

## Summary

Provides information about a simple if statement\.
Simple if statement is defined as follows: it is not a child of an else clause and it has no else clause\.

#### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) &#x2192; SimpleIfStatementInfo

#### Implements

* [IEquatable\<SimpleIfStatementInfo>](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)

## Properties

| Property | Summary |
| -------- | ------- |
| [Condition](Condition/README.md) | The condition\. |
| [IfStatement](IfStatement/README.md) | The if statement\. |
| [Statement](Statement/README.md) | The statement\. |
| [Success](Success/README.md) | Determines whether this struct was initialized with an actual syntax\. |

## Methods

| Method | Summary |
| ------ | ------- |
| [Equals(Object)](Equals/README.md) | Determines whether this instance and a specified object are equal\. |
| [Equals(SimpleIfStatementInfo)](Equals/README.md) | Determines whether this instance is equal to another object of the same type\. |
| [GetHashCode()](GetHashCode/README.md) | Returns the hash code for this instance\. |
| [ToString()](ToString/README.md) | Returns the string representation of the underlying syntax, not including its leading and trailing trivia\. |

## Operators

| Operator | Summary |
| -------- | ------- |
| [operator !=(SimpleIfStatementInfo, SimpleIfStatementInfo)](op_Inequality/README.md) | |
| [operator ==(SimpleIfStatementInfo, SimpleIfStatementInfo)](op_Equality/README.md) | |
