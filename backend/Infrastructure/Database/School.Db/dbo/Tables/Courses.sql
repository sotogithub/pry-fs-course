CREATE TABLE [dbo].[Courses]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT (newid()), 
    [CourseName] VARCHAR(100) NOT NULL, 
    [CourseDescription] VARCHAR(MAX) NULL
)
