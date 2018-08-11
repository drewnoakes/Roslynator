# SyntaxListSelection\<TNode> Class

[Constructors](#constructors) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods) &#x2022; [Explicit Interface Implementations](#explicit-interface-implementations) &#x2022; [Structs](#structs)

**Namespace**: [Roslynator](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Summary

Represents selected nodes in a [SyntaxList\<TNode>](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxlist-1)\.

```csharp
public class SyntaxListSelection<TNode> : ISelection<TNode>,
    System.Collections.Generic.IEnumerable<TNode>,
    System.Collections.Generic.IReadOnlyCollection<TNode>,
    System.Collections.Generic.IReadOnlyList<TNode>
    where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

| Name | Summary |
| ---- | ------- |
| TNode | |

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; SyntaxListSelection\<TNode>

### Derived

* Roslynator\.CSharp\.[MemberDeclarationListSelection](../CSharp/MemberDeclarationListSelection/README.md)
* Roslynator\.CSharp\.[StatementListSelection](../CSharp/StatementListSelection/README.md)

### Implements

* System\.Collections\.Generic\.[IEnumerable\<TNode>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)
* System\.Collections\.Generic\.[IReadOnlyCollection\<TNode>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1)
* System\.Collections\.Generic\.[IReadOnlyList\<TNode>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)
* Roslynator\.[ISelection\<TNode>](../ISelection-1/README.md)

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [SyntaxListSelection(SyntaxList\<TNode>, TextSpan, Int32, Int32)](-ctor/README.md) | Initializes a new instance of the [SyntaxListSelection\<TNode>](./README.md)\. |

## Properties

| Property | Summary |
| -------- | ------- |
| [Count](Count/README.md) | Gets a number of selected nodes\. \(Implements [IReadOnlyCollection\<TNode>.Count](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1.count)\) |
| [FirstIndex](FirstIndex/README.md) | Gets an index of the first selected node\. \(Implements [ISelection\<TNode>.FirstIndex](../ISelection-1/FirstIndex/README.md)\) |
| [Item\[Int32\]](Item/README.md) | Gets the selected node at the specified index\. \(Implements [IReadOnlyList\<TNode>.Item](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1.item)\) |
| [LastIndex](LastIndex/README.md) | Gets an index of the last selected node\. \(Implements [ISelection\<TNode>.LastIndex](../ISelection-1/LastIndex/README.md)\) |
| [OriginalSpan](OriginalSpan/README.md) | Gets the original span that was used to determine selected nodes\. |
| [UnderlyingList](UnderlyingList/README.md) | Gets an underlying list that contains selected nodes\. |

## Methods

| Method | Summary |
| ------ | ------- |
| [Create(SyntaxList\<TNode>, TextSpan)](Create/README.md) | Creates a new [SyntaxListSelection\<TNode>](./README.md) based on the specified list and span\. |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [First()](First/README.md) | Gets the first selected node\. \(Implements [ISelection\<TNode>.First](../ISelection-1/First/README.md)\) |
| [GetEnumerator()](GetEnumerator/README.md) | Returns an enumerator that iterates through selected nodes\. |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [Last()](Last/README.md) | Gets the last selected node\. \(Implements [ISelection\<TNode>.Last](../ISelection-1/Last/README.md)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [TryCreate(SyntaxList\<TNode>, TextSpan, SyntaxListSelection\<TNode>)](TryCreate/README.md) | Creates a new [SyntaxListSelection\<TNode>](./README.md) based on the specified list and span\. |

## Explicit Interface Implementations

| Member | Summary |
| ------ | ------- |
| [IEnumerable.GetEnumerator()](System-Collections-IEnumerable-GetEnumerator/README.md) | |
| [IEnumerable\<TNode>.GetEnumerator()](System-Collections-Generic-IEnumerable-TNode--GetEnumerator/README.md) | |

## Structs

| Struct | Summary |
| ------ | ------- |
| [Enumerator](Enumerator/README.md) | |
