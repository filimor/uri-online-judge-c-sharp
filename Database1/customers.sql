CREATE TABLE [dbo].[customers]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [name] VARCHAR(50) NULL, 
    [street] VARCHAR(50) NULL, 
    [city] VARCHAR(50) NULL, 
    [state] CHAR(2) NULL, 
    [cretit_limit] MONEY NULL
)
