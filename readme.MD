## Get sql server
docker pull mcr.microsoft.com/mssql/server:2017-latest  

## Run sql server  
docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=YourStrongPassw0rd(!)here' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2017-latest

Note: Use sql server management studio for ease of use (Windows only), otherwise use CLI. This will login with the `SA` account and your stated password.

## Add entity frameworkcore
dotnet add package Microsoft.EntityFrameworkCore

## Add entity framework design
dotnet add package Microsoft.EntityFrameworkCore.Design  

## Add sql server database provider 
dotnet add package Microsoft.EntityFrameworkCore.SqlServer

## Add dotnet migration tools
dotnet tool install --global dotnet-ef  
[connection string info](https://www.connectionstrings.com/sql-server-2017/)  
`run migrations`: dotnet-ef migrations add <nameOfMigration>  
`undo migrations`: dotnet ef migrations remove  
`run migrations`: dotnet-ef database update  

## Get all commands
curl -XGET https://localhost:5001/api/commands --insecure  

## Get single command
curl -XGET https://localhost:5001/api/commands/0 --insecure  