USE Bank

/*Problem 16. Deposit Money*/
CREATE OR ALTER PROC usp_DepositMoney (@accountId INT, @moneyAmount DECIMAL(15,4))
AS
BEGIN TRANSACTION
		IF(@moneyAmount<0 OR @moneyAmount IS NULL)
		BEGIN
			ROLLBACK
			RAISERROR('Invalid amount of money',16,1)
			RETURN
		END

		IF(NOT EXISTS
		(
			SELECT a.Id FROM AccountHolders AS a
			WHERE A.Id = @AccountId) OR @accountId IS NULL
		)
		BEGIN
			ROLLBACK
			RAISERROR('Invalid accountId',16,2)
			RETURN
		END
		UPDATE Accounts
		SET Balance+=@moneyAmount
		WHERE Id = @accountId
COMMIT 

EXEC dbo.usp_DepositMoney 1,10