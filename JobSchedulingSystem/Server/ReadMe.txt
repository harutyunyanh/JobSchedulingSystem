Add-Migration InitialIdentityServerMigration -c PersistedGrantDbContext
Add-Migration InitialIdentityServerMigration -c ConfigurationDbContext


Update-Database -Context PersistedGrantDbContext
Update-Database -Context ConfigurationDbContext

Add-Migration InitialAspNetIdentityMigration -Context AspNetIdentityDbContext
Update-Database -Context AspNetIdentityDbContext

 dotnet run Server/bin/Debug/net6.0/Server /seed --project Server
https://localhost:5443/.well-known/openid-configuration