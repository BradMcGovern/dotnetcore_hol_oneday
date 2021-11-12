rem dotnet new globaljson --sdk-version 6.0.100
dotnet new nugetconfig --nuget-source https://api.nuget.org/v3/index.json

rem create the solution
dotnet new sln -n AutoLot
rem create the class library for the Models and add it to the solution
dotnet new classlib -lang c# -n AutoLot.Models -o .\AutoLot.Models -f net6.0 
dotnet sln AutoLot.sln add AutoLot.Models
dotnet add AutoLot.Models package Microsoft.EntityFrameworkCore --prerelease
dotnet add AutoLot.Models package Microsoft.EntityFrameworkCore.SqlServer --prerelease
dotnet add AutoLot.Models package System.Text.Json --prerelease


rem create the Data Access Layer class library, and add to the solution
dotnet new classlib -lang c# -n AutoLot.Dal -o .\AutoLot.Dal -f net6.0 
dotnet sln AutoLot.sln add AutoLot.Dal
dotnet add AutoLot.Dal reference AutoLot.Models
dotnet add AutoLot.Dal package Microsoft.EntityFrameworkCore --prerelease
dotnet add AutoLot.Dal package Microsoft.EntityFrameworkCore.Design --prerelease
dotnet add AutoLot.Dal package Microsoft.EntityFrameworkCore.SqlServer --prerelease
dotnet add AutoLot.Dal package Microsoft.EntityFrameworkCore.Tools --prerelease


rem create the Data Access Layer XUnit project and add it to the solution
dotnet new xunit -lang c# -n AutoLot.Dal.Tests -o .\AutoLot.Dal.Tests -f net6.0
dotnet sln AutoLot.sln add AutoLot.Dal.Tests
dotnet add AutoLot.Dal.Tests package Microsoft.EntityFrameworkCore --prerelease
dotnet add AutoLot.Dal.Tests package Microsoft.EntityFrameworkCore.Design --prerelease
dotnet add AutoLot.Dal.Tests package Microsoft.EntityFrameworkCore.SqlServer --prerelease
dotnet add AutoLot.Dal.Tests package Microsoft.Extensions.Configuration.Json
rem remove older, templated version 
rem dotnet remove AutoLot.Dal.Tests package Microsoft.NET.Test.Sdk 
rem get latest version
dotnet add AutoLot.Dal.Tests package Microsoft.NET.Test.Sdk --prerelease

dotnet add AutoLot.Dal.Tests reference AutoLot.Dal
dotnet add AutoLot.Dal.Tests reference AutoLot.Models

rem create the class library for the application services and add it to the solution
dotnet new classlib -lang c# -n AutoLot.Services -o .\AutoLot.Services -f net6.0
dotnet sln AutoLot.sln add AutoLot.Services
dotnet add AutoLot.Services package Microsoft.Extensions.Hosting.Abstractions --prerelease 
dotnet add AutoLot.Services package Microsoft.Extensions.Options --prerelease 
dotnet add AutoLot.Services package Serilog.AspNetCore
dotnet add AutoLot.Services package Serilog.Enrichers.Environment
dotnet add AutoLot.Services package Serilog.Settings.Configuration
dotnet add AutoLot.Services package Serilog.Sinks.Console
dotnet add AutoLot.Services package Serilog.Sinks.File
dotnet add AutoLot.Services package Serilog.Sinks.MSSqlServer
dotnet add AutoLot.Services package System.Text.Json --prerelease 

dotnet add AutoLot.Services reference AutoLot.Models
dotnet add AutoLot.Dal.Tests reference AutoLot.Dal

rem create the ASP.NET Core Web App (MVC) project and add it to the solution
dotnet new mvc -lang c# -n AutoLot.Mvc -au none -o .\AutoLot.Mvc -f net6.0
dotnet sln AutoLot.sln add AutoLot.Mvc
dotnet add AutoLot.Mvc package AutoMapper
dotnet add AutoLot.Mvc package System.Text.Json --prerelease 
dotnet add AutoLot.Mvc package LigerShark.WebOptimizer.Core
dotnet add AutoLot.Mvc package Microsoft.Web.LibraryManager.Build
dotnet add AutoLot.Mvc package Microsoft.EntityFrameworkCore --prerelease 
dotnet add AutoLot.Mvc package Microsoft.EntityFrameworkCore.Design --prerelease 
dotnet add AutoLot.Mvc package Microsoft.EntityFrameworkCore.SqlServer --prerelease 
dotnet add AutoLot.Mvc package Microsoft.VisualStudio.Web.CodeGeneration.Design --prerelease 

dotnet add AutoLot.Mvc reference AutoLot.Models
dotnet add AutoLot.Mvc reference AutoLot.Dal
dotnet add AutoLot.Mvc reference AutoLot.Services

pause
