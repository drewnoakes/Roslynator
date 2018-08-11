# SyntaxExtensions\.IsLast\(SyntaxList\<StatementSyntax>, StatementSyntax, Boolean\) Method

**Containing Type**: [Roslynator.CSharp](../../README.md)\.[SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Summary

Returns true if the specified statement is a last statement in the list\.

```csharp
public static bool IsLast(this SyntaxList<StatementSyntax> statements, StatementSyntax statement, bool ignoreLocalFunctions)
```

### Parameters

| Name | Summary |
| ---- | ------- |
| statements | |
| statement | |
| ignoreLocalFunctions | Ignore local function statements at the end of the list\. |

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)
