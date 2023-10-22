USE Gringotts
/*05. Deposits Sum*/
SELECT w.DepositGroup
		,SUM(DepositAmount)
	FROM WizzardDeposits AS w
	GROUP BY w.DepositGroup

