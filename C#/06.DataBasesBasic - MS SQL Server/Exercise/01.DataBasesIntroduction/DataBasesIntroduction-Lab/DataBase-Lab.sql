/* **********************************************
	1.	Create a Database
*************************************************/
CREATE DATABASE Bank COLLATE Cyrillic_General_100_CI_AS;

GO

USE Bank;
GO

/* **********************************************
	2.	Create Tables
*************************************************/
CREATE TABLE Clients
(
Id INT PRIMARY KEY IDENTITY,
FirstName NVARCHAR(50) NOT NULL,
LastName NVARCHAR(50) NOT NULL
)

CREATE TABLE AccountType
(
Id INT PRIMARY KEY IDENTITY,
[Name] VARCHAR(50) NOT NULL
)

CREATE TABLE Accounts
(
Id INT PRIMARY KEY IDENTITY,
AccountTypeId INT FOREIGN KEY REFERENCES AccountType(Id),
Balance DECIMAL(15,2) NOT NULL DEFAULT(0),
ClientId INT FOREIGN KEY REFERENCES Clients(Id)
)

/* **********************************************
	3.	Insert Sample Data into Database
*************************************************/

INSERT INTO Clients (FirstName,LastName) VALUES
('Gosho','Ivanov'),
('Pesho','Petrov'),
('Ivan','Iliev'),
('Merry','Ivanova')
GO

INSERT INTO AccountType(Name) VALUES
('Checking'),
('Saving')
GO

INSERT INTO Accounts(ClientId,AccountTypeid,Balance) VALUES
(1, 1, 175),
(2, 1, 275.56),
(3, 1, 138.01),
(4, 1, 40.30),
(4, 2, 375.50);
GO


/* **********************************************
	4.	Create a View
*************************************************/

CREATE VIEW v_ClientBalances
AS
     SELECT(FirstName + ' ' + LastName) AS [Name],
           (AccountType.Name) AS [Account Type],
           Balance
     FROM Clients
          JOIN Accounts ON Clients.Id = Accounts.ClientId
          JOIN AccountType ON AccountType.Id = Accounts.AccounttypeId;
GO

SELECT *
FROM v_ClientBalances;
GO


/* **********************************************
	5.	Create a Function
*************************************************/
CREATE FUNCTION f_CaclculateTotalBalance(@ClientId INT)
RETURNS DECIMAL(15,2)
BEGIN
	DECLARE @result AS DECIMAL(15,2) = 
	(SELECT SUM(Balance)
	FROM Accounts WHERE ClientId = @ClientId)

	RETURN @result
END;
GO

SELECT dbo.f_CaclculateTotalBalance(4) AS Balance;
GO

/* **********************************************
	6.	Create Procedures
*************************************************/
CREATE PROCEDURE p_AddAccount @ClientId INT, @AccountTypeId int
AS
	BEGIN
		INSERT INTO Accounts(ClientId,AccountTypeId)
		VALUES (@ClientId,@AccountTypeId);
	END;
GO

p_AddAccount
 2,
 2;
GO

p_AddAccount
 2,
 2;
GO

p_AddAccount
 2,
 2;
GO

SELECT * FROM Accounts;
GO

--Deposit Procedure
CREATE PROC p_Deposit
@AccountId INT, @Amount DECIMAl(15,2)
AS
	BEGIN
	UPDATE Accounts SET Balance += @Amount WHERE Id = @AccountId;
	END;
GO

--Withdraw Procedure
CREATE PROC p_Withdraw
@AccountId INT , @Amount DECIMAL(15,2)
AS
	BEGIN
	BEGIN
	DECLARE @OldBalance DECIMAL(15,2);

	SELECT @OldBalance = Balance
	FROM Accounts 
	WHERE Id = @AccountId;

	IF(@OldBalance - @Amount>=0)
		BEGIN
			UPDATE Accounts
				SET
				Balance-=@Amount
			WHERE Id = @AccountId;
	END;
		ELSE
		BEGIN
			RAISERROR('Insufficient funds', 10, 1)
		END
	END;
END;

/* **********************************************
	7.	Create Transactions Table and a Trigger
*************************************************/

CREATE TABLE Transactions
(
	Id INT PRIMARY KEY IDENTITY,
	AccountId INT FOREIGN KEY REFERENCES Accounts(Id),
	OldBalance DECIMAL(15,2) NOT NULL,
	NewBalance  DECIMAL(15,2) NOT NULL,
	Amount AS NewBalance - OldBalance,
	[DateTime] DATETIME2
);
GO

CREATE TRIGGER tr_Transaction ON Accounts
AFTER UPDATE
AS
     INSERT INTO Transactions(AccountId,
                              OldBalance,
                              NewBalance,
                              [DateTime]
                             )
            SELECT inserted.Id,
                   deleted.Balance,
                   inserted.Balance,
                   GETDATE()
            FROM inserted
                 JOIN deleted ON inserted.Id = deleted.Id;
GO

p_Deposit
 1,
 25.00;
GO

p_Deposit
 2,
 40.00;
GO

p_Withdraw
 3,
 200.00;
GO

p_Withdraw
 4,
 180.00;
GO

SELECT *
FROM Transactions;