CREATE TABLE [dbo].[OrderItems]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [InventoryId] INT NOT NULL, 
    [Quantity] INT NOT NULL, 
    [Value] MONEY NOT NULL
)
