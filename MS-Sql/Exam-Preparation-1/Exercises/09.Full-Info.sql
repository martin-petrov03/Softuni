USE Airport

SELECT CONCAT(p.FirstName, ' ', p.LastName) AS [Full Name],
	pl.[Name] AS [Plane Name],
	CONCAT(f.Origin, ' - ', f.Destination) AS [Trip],
	lt.[Type]
FROM Passengers AS p
JOIN Tickets AS t
ON p.Id = t.PassengerId
JOIN Luggages AS l
ON t.LuggageId = l.Id
JOIN LuggageTypes AS lt
ON l.LuggageTypeId = lt.Id
JOIN Flights AS f
ON t.FlightId = f.Id
JOIN Planes AS pl
ON f.PlaneId = pl.Id
ORDER BY [Full Name],
	pl.[Name],
	f.Origin,
	f.Destination,
	lt.[Type];