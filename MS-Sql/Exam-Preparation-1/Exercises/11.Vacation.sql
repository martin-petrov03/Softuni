USE Airport
GO

CREATE FUNCTION udf_CalculateTickets(@origin VARCHAR(50), @destination VARCHAR(50), @peopleCount INT)
RETURNS VARCHAR(50)
AS
BEGIN
	IF(@peopleCount <= 0)
	BEGIN
		RETURN 'Invalid people count!';
	END
	
	DECLARE @flightId INT = (SELECT TOP(1) Id FROM Flights
							 WHERE Origin = @origin AND Destination = @destination);

	IF(@flightId IS NULL)
	BEGIN
		RETURN 'Invalid flight!';
	END

	DECLARE @pricePerPerson DECIMAL(18, 2) =
		(SELECT Price FROM Tickets
		WHERE FlightId = @flightId);
	
	DECLARE @totalPrice DECIMAL(24, 2) = @pricePerPerson * @peopleCount;
	RETURN CONCAT('Total price ', @totalPrice);
END
GO

SELECT dbo.udf_CalculateTickets('Kolyshley','Rancabolang', 33);
SELECT dbo.udf_CalculateTickets('Kolyshley','Rancabolang', -1);
SELECT dbo.udf_CalculateTickets('Invalid','Rancabolang', 33);
