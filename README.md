# WardManagement.Clean
 Use Visual Studio Code and .Net 6.0

## Visual Studio Code
 Microsoft Visual Studio Code (64-bit) - Current
 Version 1.74.3

## .Net 6.0
 Microsoft .NET SDK 6.0.405

## Running the code
 Check the gode out
 Open in Visual Studio
 Change appsettings.json to your SQL/SQLExpress DB

 ## Clean Architeture

``` 
  MVC - API - Application - Domain - Presisence - DB
  |       |   |                   |  |             |
  +-------+   +-------------------+  +-------------+
     Web              Core            Infrastructure
```
  MVC: (Web)

  API: (Web)

  Application: (Core)
  - DTOs
  - Command
  - Queries

  MediatR
  read Queries
  write Commands
  AutoMapper
  DTOs - Entities

  Domain: (Core)
  - Entities
  - Interfaces
  - Resouces

  Presistence: (Infrastructure)
  - Repositories
  - DBContext
  - Configurations(Seed)
  - Migrations

  Infrastructure (Infrastructure)


 ## Steps

 1. Create a blank soloution
    - Folder structure: src and tests
    ```
    dotnet new sln -o WardManagement.Clean
    cd WardManagement.Clean
    mkdir doc
    mkdir src
    mkdir test
    ```    

 2. Setup some Clean archtecture projects
    - WardManagement.CleanApplication (Core)
       Class Library .NET 6.0
       ```
       dotnet new classlib -f net6.0 -n WardManagement.Clean.Application -o src/Core/WardManagement.Clean.Application
       dotnet sln add src/Core/WardManagement.Clean.Application/WardManagement.Clean.Application.csproj
       dotnet add src/Core/WardManagement.Clean.Application package Microsoft.Extensions.DependencyInjection
       dotnet add src/Core/WardManagement.Clean.Application package Microsoft.Extensions.Configuration
       ```
    - WardManagement.Clean.Domain (Core)
       Class Library .NET 6.0
       ```
       dotnet new classlib -f net6.0 -n WardManagement.Clean.Domain -o src/Core/WardManagement.Clean.Domain
       dotnet sln add src/Core/WardManagement.Clean.Domain/WardManagement.Clean.Domain.csproj
       dotnet add src/Core/WardManagement.Clean.Domain package Microsoft.Extensions.DependencyInjection
       dotnet add src/Core/WardManagement.Clean.Domain package Microsoft.Extensions.Configuration
       ```       
    - WardManagement.CleanInfrastructure (Infrastructure)
       Class Library .NET 6.0
       ```
       dotnet new classlib -f net6.0 -n WardManagement.Clean.Infrastructure -o src/Infrastructure/WardManagement.Clean.Infrastructure
       dotnet sln add src/Infrastructure/WardManagement.Clean.Infrastructure/WardManagement.Clean.Infrastructure.csproj
       dotnet add src/Infrastructure/WardManagement.Clean.Infrastructure package Microsoft.Extensions.DependencyInjection
       dotnet add src/Infrastructure/WardManagement.Clean.Infrastructure package Microsoft.Extensions.Configuration
       ```              
    - WardManagement.Clean.Presistence (Infrastructure)
       Class Library .NET 6.0
       ```
       dotnet new classlib -f net6.0 -n WardManagement.Clean.Presistence -o src/Infrastructure/WardManagement.Clean.Presistence
       dotnet sln add src/Infrastructure/WardManagement.Clean.Presistence/WardManagement.Clean.Presistence.csproj
       dotnet add src/Infrastructure/WardManagement.Clean.Presistence package Microsoft.Extensions.DependencyInjection
       dotnet add src/Infrastructure/WardManagement.Clean.Presistence package Microsoft.Extensions.Configuration
       ```   




















       
