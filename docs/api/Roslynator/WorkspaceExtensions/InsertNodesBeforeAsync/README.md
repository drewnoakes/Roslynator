# WorkspaceExtensions\.InsertNodesBeforeAsync\(Document, SyntaxNode, IEnumerable\<SyntaxNode>, CancellationToken\) Method

**Containing Type**: [Roslynator](../../README.md)\.[WorkspaceExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.Workspaces\.dll

## Summary

Creates a new document with new nodes inserted before the specified node\.

```csharp
public static Task<Document> InsertNodesBeforeAsync(this Document document, SyntaxNode nodeInList, IEnumerable<SyntaxNode> newNodes, CancellationToken cancellationToken = default(CancellationToken))
```

### Parameters

| Name | Summary |
| ---- | ------- |
| document | |
| nodeInList | |
| newNodes | |
| cancellationToken | |

### Returns

System\.Threading\.Tasks\.[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)\<Microsoft\.CodeAnalysis\.[Document](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.document)>
