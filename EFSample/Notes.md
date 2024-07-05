dotnet tool install --global dotnet-ef
dotnet tool update --global dotnet-ef
dotnet tool list --global
dotnet ef dbcontext scaffold "Data Source=chinook.db;" Microsoft.EntityFrameworkCore.Sqlite -o EntityModels