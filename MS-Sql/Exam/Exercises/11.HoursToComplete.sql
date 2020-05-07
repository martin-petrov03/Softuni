USE Service
GO

CREATE FUNCTION udf_HoursToComplete(@StartDate DATETIME, @EndDate DATETIME)
RETURNS INT
AS
BEGIN
	IF(@StartDate IS NULL)
	BEGIN
		RETURN 0
	END

	IF(@EndDate IS NULL)
	BEGIN
		RETURN 0
	END

	RETURN DATEDIFF(hour, @StartDate, @EndDate)
END
GO

SELECT dbo.udf_HoursToComplete(OpenDate, CloseDate) AS TotalHours
   FROM Reports