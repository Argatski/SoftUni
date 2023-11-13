USE Bank

/*Problem 10. People with Balance Higher Than*/
CREATE OR ALTER PROC	usp_GetHoldersWithBalanceHigherThan (@num DECIMAL(15,2))
AS
BEGIN
	SELECT ah.FirstName,
			ah.LastName
	FROM AccountHolders AS ah
	JOIN Accounts AS a
	ON a.AccountHolderId = ah.Id
	GROUP BY ah.FirstName,
			ah.LastName
	HAVING SUM(a.Balance)>@num
	ORDER BY ah.FirstName,
			 ah.LastName	
END


EXEC usp_GetHoldersWithBalanceHigherThan 543


SELECT *
	FROM AccountS