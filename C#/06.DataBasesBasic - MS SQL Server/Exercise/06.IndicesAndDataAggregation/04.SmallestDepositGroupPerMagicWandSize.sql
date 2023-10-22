USE Gringotts
/*04. Smallest Deposit Group per Magic Wand Size*/
SELECT TOP(2) W.DepositGroup
	FROM WizzardDeposits AS W
	GROUP BY W.DepositGroup
	ORDER BY AVG(W.MagicWandSize)

