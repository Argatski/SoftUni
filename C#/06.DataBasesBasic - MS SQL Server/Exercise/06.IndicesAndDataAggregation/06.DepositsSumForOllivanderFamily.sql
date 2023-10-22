USE Gringotts
/*06.Deposits Sum for Ollivander Family*/
SELECT w.DepositGroup,
	SUM(w.DepositAmount) AS [TotalSum]
	FROM WizzardDeposits AS w
	WHERE w.MagicWandCreator = 'Ollivander family'
	GROUP BY w.DepositGroup


