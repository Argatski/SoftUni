USE Gringotts
/*12.*Rich Wizard, Poor Wizard*/
SELECT SUM(K.Diff) AS [SumDifferences]
	FROM	(
			SELECT w.DepositAmount 
				-(	
					SELECT DepositAmount 
					FROM WizzardDeposits AS f
					WHERE f.Id =  w.Id +1) 
					AS Diff
			FROM WizzardDeposits AS w
			)AS k