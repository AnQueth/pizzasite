CREATE TABLE [dbo].[Order]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [DeliveryTo] NVARCHAR(50) NOT NULL, 
    [DeliveryAddress] NVARCHAR(50) NOT NULL, 
    [DeliveryPhone] NVARCHAR(50) NOT NULL, 
    [DeliveryEmail] NVARCHAR(50) NOT NULL, 
    [CreditCard] NVARCHAR(16) NOT NULL, 
    [CreditCardExpires] SMALLDATETIME NOT NULL, 
    [CreditCardCCV] INT NOT NULL
)
