# SyntaxExtensions\.TryGetContainingList\(StatementSyntax, SyntaxList\<StatementSyntax>\) Method

**Containing Type**: [Roslynator.CSharp](../../README.md)\.[SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Summary

Gets a list the specified statement is contained in\.
This method succeeds if the statement is in a block's statements or a switch section's statements\.

```csharp
public static bool TryGetContainingList(this StatementSyntax statement, out SyntaxList<StatementSyntax> statements)
```

### Parameters

| Name | Summary |
| ---- | ------- |
| statement | |
| statements | |

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

True if the statement is contained in the list; otherwise, false\.