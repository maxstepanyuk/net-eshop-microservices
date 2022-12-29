# new webapi
dotnet new webapi -n CustomerService --framework "net6.0" 

# packages
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.InMemory

dotnet add package MongoDB.Driver