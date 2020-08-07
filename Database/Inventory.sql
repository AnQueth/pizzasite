CREATE TABLE [dbo].[Inventory]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Value] MONEY NOT NULL, 
    [Description] NVARCHAR(50) NOT NULL
)
