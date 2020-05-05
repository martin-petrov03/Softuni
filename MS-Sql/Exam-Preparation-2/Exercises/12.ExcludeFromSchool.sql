USE School
GO

CREATE PROC usp_ExcludeFromSchool(@StudentId INT)
AS
	DECLARE @studentWithInputId INT = (SELECT TOP(1) Id FROM Students
							  WHERE Id = @StudentId);
	IF(@studentWithInputId IS NULL)
	BEGIN
		RAISERROR('This school has no student with the provided id!', 16, 1);
	END
	
	DELETE StudentsTeachers
	WHERE StudentId = @StudentId;

	DELETE StudentsExams
	WHERE StudentId = @StudentId;

	DELETE StudentsSubjects
	WHERE StudentId = @StudentId;

	DELETE Students
	WHERE Id = @StudentId;
GO

EXEC usp_ExcludeFromSchool 301;

EXEC usp_ExcludeFromSchool 1
SELECT COUNT(*) FROM Students