<a name="_Top"></a>

# WorkspaceExtensions\.RemoveNodesAsync\(Document, IEnumerable\<SyntaxNode>, SyntaxRemoveOptions, CancellationToken\) Method

[Home](../../../README.md#_Top)

**Containing Type**: [Roslynator](../../README.md#_Top)\.[WorkspaceExtensions](../README.md#_Top)

**Assembly**: Roslynator\.CSharp\.Workspaces\.dll

## Summary

Creates a new document with the specified nodes removed\.

```csharp
public static Task<Document> RemoveNodesAsync(this Document document, IEnumerable<SyntaxNode> nodes, SyntaxRemoveOptions options, CancellationToken cancellationToken = default(CancellationToken))
```

### Parameters

#### document

#### nodes

#### options

#### cancellationToken

### Returns

System\.Threading\.Tasks\.[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)\<Microsoft\.CodeAnalysis\.[Document](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.document)>

