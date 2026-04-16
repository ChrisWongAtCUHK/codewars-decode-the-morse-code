# [Unit testing C# with NUnit and .NET Core](https://learn.microsoft.com/en-gb/dotnet/core/testing/unit-testing-csharp-with-nunit#adding-more-features)
1. in root directory
   ```
   dotnet new sln
   ```
2. create class library
   ```
   mkdir Kata && pushd Kata
   dotnet new classlib
   ```
3. rename Class1.cs
   ```
   mv Class1.cs RomanNumerals.cs
   ```
4. add project to sln
   ```
   popd
   dotnet sln add Kata/Kata.csproj
   ```
5. create Kata.Tests directory
   ```
   mkdir Kata.Tests && pushd Kata.Tests
   ```
6. new NUnit project
   ```
   dotnet new nunit
   dotnet add reference ../Kata/Kata.csproj
   ```
7. add nunit project to sln
   ```
   popd
   dotnet sln add Kata.Tests/Kata.Tests.csproj 
   ```
8. run test
   ```
   dotnet test
   ```
9. git
   ```
   dotnet new gitignore
   ```