# SyntaxExtensions\.IsEmbedded\(StatementSyntax, Boolean, Boolean, Boolean\) Method <a name="_Top"></a>

[Home](../../../../README.md)

**Containing Type**: [Roslynator.CSharp](../../README.md#_Top)\.[SyntaxExtensions](../README.md#_Top)

**Assembly**: Roslynator\.CSharp\.dll

## Summary

Returns true if the specified statement is an embedded statement\.

```csharp
public static bool IsEmbedded(this StatementSyntax statement, bool canBeBlock = false, bool canBeIfInsideElse = true, bool canBeUsingInsideUsing = true)
```

### Parameters

#### statement

#### canBeBlock

Block can be considered as embedded statement

#### canBeIfInsideElse

If statement that is a child of an else statement can be considered as an embedded statement\.

#### canBeUsingInsideUsing

Using statement that is a child of an using statement can be considered as en embedded statement\.

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

