USE Service

CREATE PROC usp_AssignEmployeeToReport(@EmployeeId INT, @ReportId INT)
AS
	DECLARE @firstDepartmentId INT = (SELECT TOP(1) d.Id FROM Employees AS e
								JOIN Departments AS d
								ON e.DepartmentId = d.Id
								WHERE e.Id = @EmployeeId);
	DECLARE @secondDepartmentId INT = (SELECT TOP(1) d.Id FROM Reports AS r
									JOIN Categories AS c
									ON r.CategoryId = c.ID
									JOIN Departments AS d
									ON c.DepartmentId = d.Id
									WHERE r.Id = @ReportId);
	IF(@firstDepartmentId = @secondDepartmentId)
	BEGIN
		UPDATE Reports
		SET EmployeeId = @EmployeeId
		WHERE Id = @ReportId		
	END
	ELSE
	BEGIN		
		THROW 51000, 'Employee doesn''t belong to the appropriate department!', 1;
	END
GO

EXEC usp_AssignEmployeeToReport 30, 1
EXEC usp_AssignEmployeeToReport 17, 2

EXEC usp_AssignEmployeeToReport 17,2
SELECT Id, CategoryId, EmployeeId
  FROM Reports
 WHERE Id = 2
