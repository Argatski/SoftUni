/*
Problem 1.	Create Database
*/
CREATE DATABASE Minions

GO

USE Minions
GO

/*
Problem 2.	Create Tables
*/
CREATE TABLE Minions
(
	Id INT NOT NULL,
	[Name] NVARCHAR(50) NOT NULL,
	Age INT NOT NULL
);
GO

CREATE TABLE Towns
(
	Id INT NOT NULL,
	[NAME] NVARCHAR(50) NOT NULL,
);
Go

ALTER TABLE Minions
ADD CONSTRAINT PK_Id
PRIMARY KEY(Id)
GO

ALTER TABLE Towns
ADD CONSTRAINT PK_TownId
PRIMARY KEY(Id)
GO

ALTER TABLE Minions
ADD TownId INT
GO

/*
Problem 3.	Alter Minions Table
*/
ALTER TABLE Minions
ADD CONSTRAINT FK_MinionTownId
FOREIGN KEY (TownId) REFERENCES Towns(Id);
GO

/*
Problem 4.	Insert Records in Both Tables
*/
INSERT INTO Towns(Id,[NAME])
VALUES
(1,'Sofia'),
(2,'Plovdiv'),
(3,'Varna')



INSERT INTO Minions (Id,[Name],Age,TownId)
VALUES
(1,'Kevin',22,1),
(2,'Bob',15,3),
(3,'Steward',NULL,2)


/*
	Problem 5.	Truncate Table Minions
*/
TRUNCATE TABLE Minions;

/*
	Problem 6.	Drop All Tables
*/
DROP TABLE Minions;

DROP TABLE Towns;

GO


