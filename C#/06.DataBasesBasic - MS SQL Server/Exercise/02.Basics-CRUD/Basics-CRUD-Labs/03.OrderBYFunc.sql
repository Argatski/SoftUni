/*ORDER BY*/
SELECT *
	FROM Employees
	ORDER BY Salary /*SORT THE TABLE OR DATABASE WITH ORDER BY (ASC)*/ 

/*ORDER BY DESCENDING*/
SELECT *
	FROM Employees
	ORDER BY Salary DESC/*SORT THE TABLE OR DATABASE WITH ORDER BY (DESC)*/ 

/*ORDER BY DATE*/
SELECT *
	FROM Employees
	ORDER BY HireDate /*WORK SAME*/

/*ORDER BY DATE*/
SELECT *
	FROM Employees
	ORDER BY HireDate DESC/*WORK SAME*/

/*ORDER BY FIRST NAME*/
SELECT *
	FROM Employees
	ORDER BY FirstName /*WORK SAME*/

/*ORDER BY FIRST NAME*/
SELECT *
	FROM Employees
	ORDER BY FirstName DESC /*WORK SAME*/

/*ORDER BY FIRST NAME WE NEED SECOND CRITERIA*/
SELECT *
	FROM Employees
	ORDER BY FirstName,LastName 

/*ORDER BY FIRST NAME WE NEED SECOND CRITERIA*/
SELECT *
	FROM Employees
	ORDER BY FirstName ASC ,LastName DESC

/*GET PERSON HIREDATE 2000y*/
SELECT * 
	FROM Employees
	WHERE YEAR(HireDate) = 2000 
	--WHERE HireDate >= '2000-01-01' AND HireDate< '2001-01-01'

SELECT * 
	FROM Employees
	WHERE DAY(HireDate) = 1

SELECT * 
	FROM Employees
	WHERE DATEPART(DW,HireDate) = 2 /*MONDEY*/

SELECT * 
	FROM Employees
	WHERE DATENAME(DW,HireDate) = 'Monday'

SELECT HireDate, DATENAME(DW,HireDate) AS [Name day]
	FROM Employees