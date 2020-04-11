USE Gringotts

SELECT DepositGroup, SUM(DepositAmount) 
FROM WizzardDeposits
WHERE  MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup;

SELECT * FROM WizzardDeposits