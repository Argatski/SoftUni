USE Bank

/*Problem 18. Money Transfer*/
CREATE OR ALTER PROC usp_TransferMoney(@senderId INT, @receiverId INT, @amount DECIMAL(15,4)) 
AS 
BEGIN TRANSACTION
					IF(@amount<0OR @amount IS NULL)
					BEGIN
						ROLLBACK
						RAISERROR('Invalid amount of money',16,1)
						RETURN
					END

					IF(NOT EXISTS(
						SELECT *FROM Accounts AS a
						WHERE a.Id=@senderId) OR @senderId IS NULL)
					BEGIN
						ROLLBACK 
						RAISERROR('Invalid senderId',16,2)
						RETURN
					END

					IF(NOT EXISTS
								(SELECT * FROM Accounts a
								WHERE a.Id=@receiverId) OR @receiverId IS NULL)
					BEGIN
						ROLLBACK
						RAISERROR('Invalid recieverId',16,3)
						RETURN
					END
					
					EXEC dbo.usp_DepositMoney @receiverId,@amount
					EXEC dbo.usp_WithdrawMoney @senderId,@amount
COMMIT 