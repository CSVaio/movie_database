CREATE TABLE [dbo].[Movies]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Title] NVARCHAR(100) NULL, 
    [Director] NVARCHAR(100) NULL, 
    [DateReleased] DATETIME NULL
)
