USE Airport

DELETE Tickets
WHERE FlightId IN (SELECT Id FROM Flights
					WHERE Destination = 'Ayn Halagim')
DELETE Flights
WHERE Destination = 'Ayn Halagim';
