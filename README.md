# Code First Approach for Database Creation


*Install EF Core: Install the necessary EF Core packages:

Microsoft.EntityFrameworkCore

Microsoft.EntityFrameworkCore.SqlServer

Microsoft.EntityFrameworkCore.Tools


/////////////////////////////////**\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\


Create DbContext: Define PatikaFirstDbContext to include Movies and Games tables.

Create Migration: Generate the migration:

*Add-Migration InitialCreate (NuGet) or dotnet ef migrations add InitialCreate (CLI)

Update Database: Apply the migration:

*Update-Database (NuGet) or dotnet ef database update (CLI)

The database PatikaCodeFirstDb1 is created with Movies and Games tables.
