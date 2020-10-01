# dotnetTemplate

Template Repository for dotnet projects

In order to start a new C# project with tests run the following commands:

```
mkdir Project
mkdir Project.tests
cd Project
dotnet new console
cd ..
cd Project.tests
dotnet new MSTest
dotnet add reference ../Project
cd ..
dotnet new sln
dotnet sln add Project/Project.csproj
dotnet sln add Project.tests/Project.tests.csproj
rm README.md
```
