USE DEMO /********/
/*USE COMMAND CONCAT */
SELECT CONCAT(FirstName, ' ' ,LastName ) FROM Customers

/*USE COMMAND CONCAT*/
SELECT CONCAT(FirstName, ',' ,LastName) FROM Customers

/*USE CONCAT_WS*/
SELECT CONCAT_WS(',',FirstName,LastName) FROM Customers AS [FullName]

/*USE CONCAT_WS*/
SELECT CONCAT_WS(' ', CustomerID ,FirstName,LastName,PaymentNumber) FROM Customers AS [FullName]

USE SoftUni /********/
/*SUBSTRING*/
SELECT SUBSTRING(FirstName, 1,3)FROM Employees /*GET 3 SYMBOL OF STRING*/
/*SUBSTRING*/
SELECT CONCAT_WS('. ', SUBSTRING(FirstName, 1,1), SUBSTRING(LastName,1,1),'') FROM Employees /*GET FIRST SYMBOL OF STRING*/

/*REPLACE*/
SELECT REPLACE('My Bad Text','bad','Awesome')

/*REPLACE*/
SELECT REPLACE(MiddleName,'R','PESHOV') FROM Employees

/*TRIM*/
SELECT CONCAT(TRIM('  R   '),'....') 
/*LTRIM*/
SELECT CONCAT(LTRIM('  R   '),'....') 
/*LTRIM*/
SELECT CONCAT(RTRIM('  R   '),'....') 

/*LEN*/
SELECT LEN(FirstName) FROM Employees

/*DATALENGTH*/
SELECT DATALENGTH(N'PESHO') FROM Employees /*THIS IS A LENGHT OF BITES*/

/*LEFT*/
SELECT LEFT(FirstName,2) FROM Employees /*GET FIRST 2 ELEMENT OF LEFT TO RIGHT*/

/*RIGHT*/
SELECT RIGHT(FirstName,2) FROM Employees/*GET LAST 2 ELEMENT OF RIGHT TO LEFT*/

USE Demo /********/

/*PROVIDE A SUMMARY WITHOUT REVEALING THE SERIAL NUMBERS*/
SELECT 
	CustomerID,
	FirstName,
	LastName,
	CONCAT(SUBSTRING(PaymentNumber,1,6),REPLICATE('*',LEN(PaymentNumber)-6)) AS PaymentNumber
	FROM Customers
/*ANOTHER SOLUTION*/
SELECT 
	CustomerID,
	FirstName,
	LastName,
	LEFT(PaymentNumber,6)+'**********'
	FROM Customers

/*LOWER STRING*/
SELECT 
	FirstName,
	LOWER(FirstName)
	FROM Customers
/*UPPER*/
SELECT
	FirstName,
	UPPER(FirstName)
	FROM Customers

/*REVERSE*/
SELECT
	FirstName,
	REVERSE(FirstName)
	FROM Customers

/*CHARINDEX*/
SELECT 
	FirstName,
	CHARINDEX('L',FirstName) AS [Position]
	FROM Customers

/*STUFF*/
SELECT 
	STUFF(FirstName, 3, 0, '12'),
	FirstName
	FROM Customers

/*FORMAT*/
SELECT 
	FORMAT(67.23,'C', 'bg-BG') /*GET FORMAT AN CULTURE*/

SELECT 
	FORMAT(67.23,'C', 'en-US') /*GET FORMAT AN CULTURE*/

SELECT 
	FORMAT(67.23,'C', 'de-DE') /*GET FORMAT AN CULTURE*/

SELECT 
	FORMAT(0.767,'P', 'de-DE') /*GET FORMAT AN CULTURE*/

SELECT 
	FORMAT(CAST('2019-01-21' AS DATE),'D','bg-BG') AS BG, /*GET FORMAT AN CULTURE*/
	FORMAT(CAST('2019-01-21' AS DATE),'D','de-DE') AS DE/*GET FORMAT AN CULTURE*/

/*TRANSLATE*/
SELECT 
	TRANSLATE(N'проба',N'абвгдежзикмнопрстуфхц', 'abvgdeziklmnoprstufhc') AS RESULT

SELECT TRANSLATE('2*[3+4]/{7-2}','[]{}','()()') 

 /*IIF*/
SELECT IIF(LEN(LastName)<6, LastName, 'Too long') FROM Customers /*TERNAREN OPERATOR*/