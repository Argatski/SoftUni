USE Bank

/*Problem 12. Calculating Interest*/
CREATE OR ALTER PROC usp_CalculateFutureValueForAccount(@accountId INT, @interestRate FLOAT) 
AS
BEGIN
		SELECT ah.Id AS [Account Id],
			   ah.FirstName AS [First Name],
			   ah.LastName as [Last Name],
			   a.Balance AS [Current Balance],
			   [dbo].[ufn_CalculateFutureValue](a.Balance,@interestRate, 5) AS [Balance in 5 years]
			FROM AccountHolders AS ah
			JOIN Accounts AS a
			ON a.Id=ah.Id
			WHERE a.Id= @accountId
END

EXEC usp_CalculateFutureValueForAccount 1,0.1
