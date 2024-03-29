/*Datepart*/
SELECT DATEPART(DAY,'2019-01-21')

/*Datepart*/
SELECT DATEPART(QUARTER,'2019-01-21') /*trimesechie*/

/*Datepart*/
SELECT DATEPART(WEEKDAY,'2019-01-21') /*broi se ot nedelq*/

/*Datepart*/
SELECT DATEPART(WEEK,'2019-01-21') /*broi se ot nedelq*/

USE SoftUni
/*ALL PRODJECT*/
SELECT * FROM Projects 
		WHERE DATEPART(QUARTER,StartDate)=3

/*ALL PRODJECT*/
SELECT * FROM Projects 
		WHERE DATEPART(WEEKDAY,StartDate)<>2 /*NO START IN MONDAY*/

/*PREPARE SALES DATA FOR AGGREGATION BY DISPLAYING YEARLY QIARTER,MONTH,YEAR AND DAY OF SALE*/
USE Orders

SELECT
	ProductName,
	YEAR(OrderDate) AS [Year],
	MONTH(OrderDate) AS [Month],
	DAY(OrderDate) AS [Day],
	DATEPART(QUARTER,OrderDate) AS [QUARTER]
	FROM Orders


/*DATEDIFF DIFFERENCE BETWEEN TO DAY*/
SELECT 
	DATEDIFF(SECOND,'1970-01-01','2023-10-05') /*UNIX TIMESTAMP*/

SELECT 
	DATEDIFF(MINUTE,'1970-01-01','2023-10-05') /*UNIX TIMESTAMP*/

SELECT 
	DATEDIFF(YEAR,'1970-01-01','2023-10-05') /*UNIX TIMESTAMP*/

/*Slow employee experience*/
USE SoftUni
SELECT FirstName,LastName,
	DATEDIFF(YEAR,HireDate,'2023-10-05') AS [Year In Service]
	FROM Employees

SELECT 
	CONCAT_WS(' ',LastName,FirstName) AS Employee,
	DATEDIFF(YEAR,HireDate,GETDATE()) AS [YearsOfService]
	FROM Employees

/*DATENAME*/
SELECT DATENAME(WEEKDAY,GETDATE()) /*CURRENT DATE NAME*/

/*DATEADD*/
USE SoftUni

SELECT HireDate, 
	   DATEADD(YEAR,5,HireDate) AS Exp 
	FROM Employees

/*GETDATE*/
SELECT GETDATE() /*CURENT DATE*/

/*EOMONTH*/
SELECT EOMONTH(GETDATE()) /*CURREN LAST DATE OF MONTH*/