USE Bank

CREATE TABLE Logs
(
  LogID INT NOT NULL IDENTITY,
  AccountID INT FOREIGN KEY REFERENCES Accounts(Id),
  OldSum MONEY,
  NewSum MONEY,
)

/*Problem 14. Create Table Logs*/
CREATE OR ALTER TRIGGER tr_AccountChanges ON Accounts FOR UPDATE
AS
BEGIN
	DECLARE @accountId INT;
	DECLARE @oldSum DECIMAL(15, 2);
	DECLARE @newSum DECIMAL(15, 2);

	SET @accountId = (SELECT i.Id
		            FROM inserted AS i)

	SET @oldSum = (SELECT d.Balance
		         FROM deleted AS d)

	SET @newSum = (SELECT i.Balance
		         FROM inserted AS i)

	INSERT INTO Logs(AccountId, OldSum, NewSum)
	VALUES		(@accountId, @oldSum, @newSum)
END


