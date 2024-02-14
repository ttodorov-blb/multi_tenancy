# 1. Initial backend create

```
dotnet new sln --name MultiTenancy

dotnet new webapi --name MultiTenancy.WebApi
dotnet sln "MultiTenancy.sln" add "./MultiTenancy.WebApi/MultiTenancy.WebApi.csproj"

dotnet new classlib --name MultiTenancy.Infrastructure
dotnet sln "MultiTenancy.sln" add "./MultiTenancy.Infrastructure/MultiTenancy.Infrastructure.csproj"

dotnet add ./MultiTenancy.WebApi/MultiTenancy.WebApi.csproj reference ./MultiTenancy.Infrastructure

dotnet new gitignore
```