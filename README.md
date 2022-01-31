
## Develop Step 
- dotnet new sln -o webapp
- dotnet new tool-manifest
- cd webapp
### Web rest app: Create project 
- dotnet new webapi --name rest
- dotnet sln add ./rest/rest.csproj
- cd rest/
### Web rest app: add vendors 
- dotnet add package Microsoft.EntityFrameworkCore.Tools
- dotnet add package Microsoft.EntityFrameworkCore.Design

- dotnet add package Microsoft.EntityFrameworkCore.SqlServer
- dotnet add package MySql.EntityFrameworkCore
- dotnet add package MongoDB.Driver

- dotnet add package Microsoft.AspNetCore.Identity
- dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
- dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer
- dotnet add package System.IdentityModel.Tokens.Jwt
- dotnet add package Swashbuckle.AspNetCore
### Web rest app: fix certs
- dotnet dev-certs https --clean
- dotnet dev-certs https -t
- dotnet dev-certs https --check
- dotnet dev-certs https --trust

- dotnet restore 
- dotnet publish -c Release -o out 
- dotnet run --project rest
- https://localhost:7125/Swagger/index.html
- https://localhost:7125/api/WeatherForecast

## Entity Framework Core Command
- dotnet tool install --global dotnet-ef
- dotnet ef migrations add CreateDatabase --project rest
- dotnet ef database update --project rest