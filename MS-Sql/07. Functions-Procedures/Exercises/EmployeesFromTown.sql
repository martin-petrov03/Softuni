USE SoftUni
GO
CREATE PROC usp_GetEmployeesFromTown (@TownName NVARCHAR(50))
AS
	SELECT e.FirstName, e.LastName
	FROM Employees AS e
	JOIN Addresses AS a
	ON e.AddressID = a.AddressID
	JOIN Towns AS t
	ON a.TownID = t.TownID
	WHERE e.AddressID = a.AddressID
		AND t.[Name] = @TownName;

EXEC dbo.usp_GetEmployeesFromTown 'Sofia';