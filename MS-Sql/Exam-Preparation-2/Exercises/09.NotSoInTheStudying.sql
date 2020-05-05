USE School

SELECT CONCAT(s.FirstName, ' ', s.MiddleName + ' ', s.LastName) AS [Full Name]
FROM Students AS s
LEFT OUTER JOIN StudentsSubjects AS ss
ON ss.StudentId = s.Id
WHERE SS.StudentId IS NULL
ORDER BY [Full Name];