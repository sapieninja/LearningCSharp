# dotnetTemplate
Template Repository for dotnet projects
In order to start a new c# project with tests run the following commands
mkdir Project
mkdir Project.tests
cd Project
dotnet new (console)
cd ..
cd Project.tests
dotnet new MSTest
dotnet new reference ../Project
