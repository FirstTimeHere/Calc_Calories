CREATE TABLE [dbo].[Alcoholic_drinks]
(
	[IdMilk] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Weight] INT NOT NULL DEFAULT 100, 
    [Fats] NCHAR(10) NOT NULL, 
    [Cholesterol] NCHAR(10) NULL, 
    [Carbohydrates] FLOAT NOT NULL, 
    [Kilocalories] INT NOT NULL
)