USE Gringotts

SELECT DepositGroup, SUM(DepositAmount) AS TotalSum
FROM WizzardDeposits
WHERE  MagicWandCreator = 'Ollivander family'
AND DepositAmount < 15000
GROUP BY DepositGroup
ORDER BY TotalSum DESC;