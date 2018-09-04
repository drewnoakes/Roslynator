<a name="_top"></a>

# ModifierKinds Enum

[Home](../../../README.md#_top) &#x2022; [Fields](#fields)

**Namespace**: [Roslynator.CSharp](../README.md#_top)

**Assembly**: Roslynator\.CSharp\.dll

## Summary

Specifies C\# modifier\.

```csharp
[System.FlagsAttribute]
public enum ModifierKinds
```

### Inheritance

System\.[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\
&emsp;System\.[ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype)\
&emsp;&emsp;System\.[Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum)\
&emsp;&emsp;&emsp;ModifierKinds

### Attributes

* System\.[FlagsAttribute](https://docs.microsoft.com/en-us/dotnet/api/system.flagsattribute)

## Fields

| Name | Value | Combination of | Summary |
| ---- | ----- | -------------- | ------- |
| None | 0 | | None modifier\. |
| New | 1 | | A "new" modifier\. |
| Public | 2 | | A "public" modifier\. |
| Private | 4 | | A "private" modifier\. |
| Protected | 8 | | A "protected" modifier\. |
| Internal | 16 | | An "internal" modifier\. |
| Accessibility | 30 | Public \| Private \| Protected \| Internal | An accessibility modifier\. |
| Const | 32 | | A "const" modifier\. |
| Static | 64 | | A "static" modifier\. |
| Virtual | 128 | | A "virtual" modifier\. |
| Sealed | 256 | | A "sealed" modifier\. |
| Override | 512 | | An "override" modifier\. |
| Abstract | 1024 | | An "abstract" modifier\. |
| AbstractVirtualOverride | 1664 | Virtual \| Override \| Abstract | "abstract", "virtual" or "override" modifier\. |
| ReadOnly | 2048 | | A "readonly" modifier\. |
| Extern | 4096 | | An "extern" modifier\. |
| Unsafe | 8192 | | A "unsafe" modifier\. |
| Volatile | 16384 | | A "volatile" modifier\. |
| Async | 32768 | | An "async" modifier\. |
| Partial | 65536 | | A "partial" modifier\. |
| Ref | 131072 | | A "ref" modifier\. |
| Out | 262144 | | An "out" modifier\. |
| In | 524288 | | An "in" modifier\. |
| Params | 1048576 | | A "params" modifier\. |
| This | 2097152 | | A "this" modifier\. |

