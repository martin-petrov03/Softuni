USE Service

SELECT CONCAT(e.FirstName , ' ', LastName) AS [FullName],
	   COUNT(u.Id) AS [UsersCount]
FROM Employees AS e
LEFT OUTER JOIN Reports AS r
ON r.EmployeeId = e.Id
LEFT OUTER JOIN Users AS u
ON r.UserId = u.Id
GROUP BY CONCAT(e.FirstName , ' ', LastName)
ORDER BY [UsersCount] DESC, [FullName];