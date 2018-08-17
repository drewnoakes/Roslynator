<a name="_Top"></a>

# WorkspaceExtensions\.WithTextChangeAsync\(Document, TextChange, CancellationToken\) Method

[Home](../../../README.md#_Top)

**Containing Type**: [Roslynator](../../README.md#_Top)\.[WorkspaceExtensions](../README.md#_Top)

**Assembly**: Roslynator\.CSharp\.Workspaces\.dll

## Summary

Creates a new document updated with the specified text change\.

```csharp
public static Task<Document> WithTextChangeAsync(this Document document, TextChange textChange, CancellationToken cancellationToken = default(CancellationToken))
```

### Parameters

#### document

#### textChange

#### cancellationToken

### Returns

System\.Threading\.Tasks\.[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)\<Microsoft\.CodeAnalysis\.[Document](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.document)>

