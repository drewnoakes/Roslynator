@echo off

"C:\Program Files\Microsoft Visual Studio\2017\Community\MSBuild\15.0\Bin\msbuild" "..\src\Roslynator.sln" ^
 /t:Clean,Build ^
 /p:Configuration=ReleaseDoc,TreatWarningsAsErrors=true,WarningsNotAsErrors="1591" ^
 /v:normal ^
 /m

if errorlevel 1 (
 pause
 exit
)

dotnet pack -c Release --no-build -v normal "..\src\Documentation\Documentation.csproj"
dotnet pack -c Release --no-build -v normal "..\src\Documentation.Build\Documentation.Build.csproj"

copy "..\src\Documentation\bin\Release\Roslynator.Documentation.0.1.0-beta.nupkg" "E:\Dokumenty\LocalNuGet"
copy "..\src\Documentation.Build\bin\Release\Roslynator.Documentation.Build.0.1.0-beta.nupkg" "E:\Dokumenty\LocalNuGet"

rd "C:\Users\Jojo\.nuget\packages\roslynator.documentation.build\" \S \Q

echo OK
pause
