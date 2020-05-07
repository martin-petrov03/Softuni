USE Service

SELECT e.FirstName + ' ' + e.LastName AS [Employee],
	   d.[Name] AS [Department],
	   c.[Name] AS [Category],
	   r.[Description] AS [Description],
	   FORMAT(r.OpenDate, 'dd.MM.yyyy') AS [OpenDate],
	   s.[Label] AS [Status],
	   u.[Name] AS [User]
FROM Reports AS r
FULL OUTER JOIN Employees AS e
ON r.EmployeeId = e.Id
JOIN Departments AS d
ON e.DepartmentId = d.Id
JOIN Categories AS c
ON d.Id = c.DepartmentId
JOIN [Status] AS s
ON r.StatusId = s.Id
JOIN Users AS u
ON r.UserId = u.Id
GROUP BY e.FirstName, e.LastName, e.FirstName + ' ' + e.LastName, d.[Name], c.[Name], r.[Description], FORMAT(r.OpenDate, 'dd.MM.yyyy'), s.[Label], u.[Name]
ORDER BY e.FirstName DESC, 
		 e.LastName DESC,
		 [Department],
		 [Category],
		 [Description],
		 [OpenDate],
		 [Status],
		 [User];