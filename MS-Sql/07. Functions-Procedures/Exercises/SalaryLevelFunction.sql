USE SoftUni
GO

CREATE FUNCTION ufn_GetSalaryLevel (@Salary DECIMAL(18, 4))
RETURNS VARCHAR(7)
AS
BEGIN
	DECLARE @salaryLevel VARCHAR(7) = CASE
		WHEN @Salary < 30000 THEN 'Low'
		WHEN @Salary BETWEEN 30000 AND 50000  THEN 'Average'
		ELSE 'High'
	END
	RETURN @salaryLevel;
END

GO

SELECT Salary, dbo.ufn_GetSalaryLevel(Salary)
FROM Employees