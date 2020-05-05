USE School
GO

CREATE FUNCTION udf_ExamGradesToUpdate(@studentId INT, @grade DECIMAL(10, 2))
RETURNS NVARCHAR(MAX)
AS
BEGIN
	DECLARE @studentWithInputId INT = (SELECT TOP(1) Id FROM Students
							  WHERE Id = @studentId)
	IF(@studentWithInputId IS NULL)
	BEGIN
		RETURN 'The student with provided id does not exist in the school!';
	END

	IF(@grade > 6.00)
	BEGIN
		RETURN 'Grade cannot be above 6.00!';
	END

	DECLARE @upBorder DECIMAL = 6.00;
	IF(@grade + 0.5 < 6.00)
	BEGIN
		SET @upBorder = @grade + 0.5;
	END
	
	DECLARE @countGrades INT = (SELECT COUNT(se.Grade) FROM Students AS s
								JOIN StudentsExams AS se
								ON s.Id = se.StudentId
								WHERE se.Grade BETWEEN @grade AND @upBorder
								AND s.Id = @studentId);

	DECLARE @firstName NVARCHAR(30) =  (SELECT TOP(1) FirstName FROM Students								
										WHERE Id = @studentId);

	RETURN CONCAT('You have to update ', @countGrades, ' grades for the student ', @firstName);
END
GO

SELECT dbo.udf_ExamGradesToUpdate(12, 6.20);
SELECT dbo.udf_ExamGradesToUpdate(12, 5.50);
SELECT dbo.udf_ExamGradesToUpdate(121, 5.50);