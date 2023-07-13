CREATE TABLE [dbo].[Enrollments]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT (newid()), 
    [CourseId] UNIQUEIDENTIFIER NOT NULL, 
    [StudentId] UNIQUEIDENTIFIER NOT NULL, 
    [EnrollmentDate] DATETIME NOT NULL,
    CONSTRAINT [FK_Course_Student] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Courses] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Student_Course] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Students] ([Id]) ON DELETE CASCADE
)
