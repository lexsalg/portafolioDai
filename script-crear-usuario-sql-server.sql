USE [master]
GO
CREATE LOGIN [user] WITH PASSWORD=N'user' 
    MUST_CHANGE, 
    DEFAULT_DATABASE=[master], 
    CHECK_EXPIRATION=ON, 
    CHECK_POLICY=ON
GO

ALTER SERVER ROLE [sysadmin] ADD MEMBER [user]
GO

USE [master]
GO

CREATE USER [user] FOR LOGIN [user]
GO

USE [master]
GO

ALTER ROLE [db_securityadmin] ADD MEMBER [user]
GO