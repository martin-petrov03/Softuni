USE Airport
GO

CREATE PROC usp_CancelFlights
AS
	UPDATE Flights
	SET ArrivalTime = NULL, DepartureTime = NULL
	--WHERE ArrivalTime > DepartureTime;
	WHERE DATEDIFF(SECOND, DepartureTime, ArrivalTime) > 0;
GO
  
EXEC dbo.usp_CancelFlights
SELECT COUNT(*)
 FROM Flights
 WHERE DepartureTime IS NULL;