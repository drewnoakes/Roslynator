
# How to Generate Documentation for .NET Project

1) Install package [Roslynator.Documentation.Build](http://www.nuget.org/packages/Roslynator.Documentation.Build/)&ensp;[![NuGet](https://img.shields.io/nuget/v/Roslynator.Documentation.Build.svg)](https://nuget.org/packages/Roslynator.Documentation.Build)

2) Add MSBuild Target to your csproj (vbproj) file

```xml
<Target Name="RoslynatorDocumentation" AfterTargets="RoslynatorDocumentationInitialize" Condition=" '$(Configuration)' == 'Release'">

  <PropertyGroup>

    <!-- One or more assembly paths you want generator documentation for, for example: A.dll B.dll -->
    <RoslynatorDocumentationAssemblies>&quot;$(TargetPath)&quot;</RoslynatorDocumentationAssemblies>

  </PropertyGroup>

    <!-- Execute 'doc' command. This command will generate documentation files from specified assemblies -->
  <Exec Command="$(RoslynatorDocumentationExe) doc ^
    -a $(RoslynatorDocumentationAssemblies) ^
    -r &quot;$(RoslynatorDocumentationAssemblyReferencesPath)&quot; ^
    -o &quot;$(SolutionDir)docs&quot; ^
    -h &quot;API Reference&quot;"
        LogStandardErrorAsError="true"
        ConsoleToMSBuild="true">
    <Output TaskParameter="ConsoleOutput" PropertyName="OutputOfExec" />
  </Exec>

    <!-- Execute 'declarations' command. This command will generate a single file that contains all declarations from specified assemblies -->
  <Exec Command="$(RoslynatorDocumentationExe) declarations ^
    -a $(RoslynatorDocumentationAssemblies) ^
    -r &quot;$(RoslynatorDocumentationAssemblyReferencesPath)&quot; ^
    -o &quot;$(SolutionDir)docs\api.cs&quot;"
        LogStandardErrorAsError="true"
        ConsoleToMSBuild="true">
    <Output TaskParameter="ConsoleOutput" PropertyName="OutputOfExec" />
  </Exec>

</Target>
```

### Commands

* [`doc`](../src/Documentation.Build/README.md#doc-command)
* [`declarations`](../src/Documentation.Build/README.md#declarations-command)
* [`root`](../src/Documentation.Build/README.md#root-command)

3) Build project in **Release** configuration

4) Publish documentation to GitHub