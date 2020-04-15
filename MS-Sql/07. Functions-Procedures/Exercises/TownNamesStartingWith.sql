USE SoftUni
GO
CREATE PROC usp_GetTownsStartingWith (@Input NVARCHAR(30))
AS
	SELECT [Name]
	FROM Towns
	WHERE [Name] LIKE @Input + '%';

EXEC dbo.usp_GetTownsStartingWith 'b';