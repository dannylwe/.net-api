## Get sql server
docker pull mcr.microsoft.com/mssql/server:2017-latest  

## Run sql server  
docker pull mcr.microsoft.com/mssql/server:2017-latest

Note: Use sql server management studio for ease of use (Windows only), otherwise use CLI.

## Get all commands
curl -XGET https://localhost:5001/api/commands --insecure  

## Get single command
curl -XGET https://localhost:5001/api/commands/0 --insecure  