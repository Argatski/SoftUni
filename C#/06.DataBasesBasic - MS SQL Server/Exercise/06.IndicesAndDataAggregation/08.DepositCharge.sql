USE Gringotts
/*08. Deposit Charge*/
SELECT w.DepositGroup,
		w.MagicWandCreator,
		MIN(W.DepositCharge) AS [MinDepositCharge]
	FROM WizzardDeposits AS w
	GROUP BY w.DepositGroup,
			 w.MagicWandCreator
	ORDER BY w.MagicWandCreator,
			 w.DepositGroup