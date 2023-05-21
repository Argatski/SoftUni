USE Minions

--07.Create Table People
CREATE TABLE People
(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(200) NOT NULL,
Picture BIT,
Height DECIMAL (3,2),
[Weight] DECIMAL(5,2),
Gender CHAR(1) NOT NULL,
Birthdate DATE NOT NULL,
Biography NVARCHAR(MAX),
)

INSERT INTO People([Name],Picture,Height,[Weight],Gender,Birthdate,Biography)
VALUES('Kiro Kirov',2,1.85,35.5,'m','1992-05-20','Zdr'),
	  ('Ivanka Ivanova',1,NULL,40.0,'f','1952-12-30','Zdrr'),
	  ('Ivan Ivanov',2,2.10,NULL,'m','1952-01-01',NULL),
	  ('Stamat Stamatov',1,1.35,81.0,'m','1952-02-02','ZDR'),
	  ('Ivan Ivanov',1,2.75,75.8,'m','2011-06-30','ZDRRR')

	  GO

--RESULT TABLE
SELECT * FROM [People]
