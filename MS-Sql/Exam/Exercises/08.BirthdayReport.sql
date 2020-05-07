USE Service

SELECT u.Username, c.[Name] AS [CategoryName]
FROM Users AS u
JOIN Reports AS r
ON u.Id = r.UserId
JOIN Categories AS c
ON r.CategoryId = c.Id
WHERE DAY(r.OpenDate) = DAY(u.Birthdate)
	  AND MONTH(r.OpenDate) = MONTH(u.Birthdate)
ORDER BY u.Username, [CategoryName];