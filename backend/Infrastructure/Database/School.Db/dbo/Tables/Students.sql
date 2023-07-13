CREATE TABLE [dbo].[Students]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT (newid()), 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [Age] INT NOT NULL, 
    [DateOfBirth] DATETIME NOT NULL, 
    [Address] VARCHAR(255) NOT NULL, 
    [Email] VARCHAR(50) NOT NULL, 
    [Phone] VARCHAR(50) NOT NULL
)
