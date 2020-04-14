USE Softuni

SELECT MIN(dt.AverageSalary) AS MinAverageSalary
FROM
(SELECT AVG(Salary) AS AverageSalary, DepartmentID
FROM Employees
GROUP BY DepartmentID) AS dt