/*SELECT*/
/*WHEN WE WANT TO GET INF OF ANOTHER DATABES(NOT CURENT DATABASE)*/
SELECT [NAME] 
	FROM SoftUni.dbo.Towns

/*USE SELECT FUNC*/
SELECT TownID ,[NAME] 
	FROM Towns;

SELECT  TownID, [Name] , LEN([Name])/*GET STRING LENGHT*/  
	FROM Towns; /*FIRST METHODS TO GET TABLE FORM DATABASE*/

SELECT  TownID, [Name] , SUBSTRING([Name],1,1)/*GET FIRST CHAR NAME*/  
	FROM Towns; /*FIRST METHODS TO GET TABLE FORM DATABASE*/

SELECT  TownID, [Name] , LEFT([Name],1)/*GET FIRST CHAR NAME*/ 
	FROM Towns; /*FIRST METHODS TO GET TABLE FORM DATABASE*/

/*SELECT AND SET NAME OF COLUM US KEY WORD 'AS'*/
SELECT TownID,[Name], LEN([Name]) AS Lenght/*SET NAME OF COLUM*/
	FROM Towns
/*SELECT AND SET NAME OF COLUM*/
SELECT  TownID, [Name] ,LEN([Name]) AS Lenght, SUBSTRING([Name],1,1) AS FirstLetter
	FROM Towns; /*FIRST METHODS TO GET TABLE FORM DATABASE*/

/*SELECT ALL COL OF TABLE*/
SELECT * FROM Towns;

/*ORDER BY NAME*/
SELECT TownID,[Name] ,LEFT([NAME],1)
	FROM Towns
	ORDER BY [Name];

/*SELECT AND WHERE*/
SELECT *
	FROM Towns
	WHERE Name = 'Sofia'

/*WHERE WITH EXPRESSION*/
SELECT *
	FROM Towns
	WHERE LEFT([NAME],1) = 'S'

/*USE SELECT, JOIN*/
 SELECT * 
	FROM Towns
	JOIN Addresses ON Towns.TownID = Addresses.TownID

/*USE SELECT, JOIN, WHERE*/
 SELECT * 
	FROM Towns
	JOIN Addresses ON Towns.TownID = Addresses.TownID
	WHERE Name = 'Seattle'

/*NESTED SELECT*/
SELECT * FROM
	(SELECT [Name],LEN([Name]) AS Lenght,LEFT([Name],1) AS FirstLetter
	FROM Towns) AS towns /*CREATE TEMP TABLE*/
	WHERE FirstLetter ='S'

/*CONCATENATE COLUMS*/
SELECT [FirstName] + ' ' + [LastName] 
	FROM [Employees]

/*01.PROBLEM-LAB*/
/*FIND INF ABOUT ALL EMPLOYEES, LISTING THEIR FULL NAME,JOBS AND SALARY*/
SELECT [FirstName] + ' ' + [LastName] AS FullName, JobTitle, Salary
	FROM [Employees]

/*FIRST 10 RESULT*/
SELECT TOP(10) /*FIRST 10 RESULT */
	[FirstName] + ' ' + [LastName] AS FullName, JobTitle, Salary
	FROM [Employees]

/*SELEC UNIQ JOBS TITLE USE (DISTINCT) THEY ARE SORT */
SELECT DISTINCT JobTitle
	FROM [Employees]

/*WHEN WE USE DISTINCT FOR 2 OR MANY COMPONET DISTINCT COMBINEITE THIS 2 */
SELECT DISTINCT JobTitle,FirstName
	FROM [Employees]

/*COUNT OF UNIQ JOBTITEL*/
SELECT COUNT(DISTINCT JobTitle) AS [COUNT]
	FROM [Employees]

/*SEARCH ALL PERSON IN JOBTITELE*/
/*FIRST SOLUTION*/
SELECT DISTINCT
	JobTitle,
	(SELECT COUNT(*) FROM Employees AS e2 WHERE e2.JobTitle = e1.JobTitle) AS [Count]
	FROM [Employees] AS e1

/*SECOND SOLUTION*/
SELECT JobTitle, COUNT (*) AS [Count]
	FROM [Employees]
	GROUP BY JobTitle

/*GET MAX SALARY, MIN SALARY, COUNT*/
SELECT JobTitle, MAX(Salary) AS [Max Salary], MIN(Salary) AS [Min Salary] ,	
	COUNT(*) AS [Count], AVG(Salary) AS [Avg] /*THIS FUNC WORK WHEN WE HAVE ONLY GROUP BY*/
	FROM [Employees]
	GROUP BY JobTitle /*WORK CELL BY CELL */
