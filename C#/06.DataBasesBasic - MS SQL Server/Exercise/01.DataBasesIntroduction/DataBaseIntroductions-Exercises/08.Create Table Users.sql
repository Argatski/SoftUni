--08.Create Table Users
CREATE TABLE Users
(
Id INT PRIMARY KEY IDENTITY,
Username VARCHAR(30),
[Password] VARCHAR (26),
ProfilePicture BIT,
LastLoginTime DATETIME,
IsDeleted BIT DEFAULT 'false'
)
GO

INSERT INTO Users
(Username,[Password],ProfilePicture,LastLoginTime,IsDeleted)
VALUES('Kiro Kirkov', '1234567', 2, '1989-05-20', 0),
		('Ivan Ivanov', '1234567', 2, '1969-02-21', 1),
		('Pesho Peshov', '1234567', 1, '1999-05-16', 1),
		('Stamat Stamatov', '1234567', 1, '1976-02-09', 0),
		('Vanko Vankov', '1234567', 2 , '1999-05-05', 0)
GO
	

SELECT * FROM Users
USE Minions
GO

ALTER TABLE Users
DROP CONSTRAINT PK_Users;

ALTER TABLE Users
ADD CONSTRAINT PK_Users PRIMARY KEY (Id,Username);
GO

--10.Add Check Constraint
ALTER TABLE Users ADD CONSTRAINT CHK_PasswordLength CHECK (LEN(Password) >=5);

--11.Set Default Value of a Field
ALTER TABLE Users
ADD CONSTRAINT DF_LastLoginTime
DEFAULT GETDATE() FOR LastLoginTime

--12.Set Unique Field
ALTER TABLE Users
DROP CONSTRAINT PK_Users

ALTER TABLE Users
ADD CONSTRAINT PK_Users PRIMARY KEY(Id);

ALTER TABLE Users
ADD CONSTRAINT UQ_Username UNIQUE (Username);

ALTER TABLE UserS
ADD CONSTRAINT CHK_User CHECK(LEN(Password)>=3);