USE Geography

SELECT TOP(5) k.Country,
		k.[Highest Peak Name],
		k.[Highest Peak Elevation],
		k.[Mountain]
FROM (
	SELECT c.CountryName AS [Country],
		ISNULL(p.PeakName, '(no highest peak)') AS [Highest Peak Name],
		ISNULL(p.Elevation, 0) AS [Highest Peak Elevation],
		ISNULL(m.MountainRange, '(no mountain)') AS [Mountain],
		DENSE_RANK() OVER (PARTITION BY c.CountryName 
			ORDER BY p.Elevation DESC) AS [ElevationRank]
	FROM Countries AS c
		LEFT JOIN MountainsCountries AS mc
		ON mc.CountryCode = c.CountryCode
		LEFT JOIN Mountains AS m
		ON mc.MountainId = m.Id
		LEFT JOIN Peaks AS p
		ON mc.MountainId = p.MountainId) AS k
WHERE k.ElevationRank = 1
ORDER BY [Country], [Highest Peak Name] DESC;