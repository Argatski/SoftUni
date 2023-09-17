/*WHERE KEY WORD*/
/*SALARY >= 40000 (ARITMETIC)*/
SELECT* 
	FROM Employees
	WHERE Salary >= 40000

/*USE WHERE STRING HAVE SYMBOL (USE LIKE)*/
SELECT *
	FROM Employees
	WHERE FirstName LIKE '%ris' /*USE % WHEN WE SAY EVERY THINK HAVE RIS*/

SELECT *
	FROM Employees
	WHERE FirstName LIKE 'Pet%' 

SELECT *
	FROM Employees
	WHERE FirstName LIKE '%ete%' -- CONTAINS

SELECT *
	FROM Employees
	WHERE FirstName LIKE '%e%t%e%'

/*USE NOT*/
SELECT *
	FROM Employees
	WHERE NOT (Salary = 10000) /*EQUAL FOR THIS SALARY != 10000*/

/*AND*/
SELECT * 
	FROM Employees
	WHERE Salary>=10000 AND Salary<20000 /*IF 2 ARE TRUE*/

SELECT * 
	FROM Employees
	WHERE Salary>=10000 
	AND Salary<20000
	AND JobTitle ='Production Technician'
	AND FirstName = 'Alice' /*IF ARE TRUE*/

/*BETWEEN*/
SELECT * 
	FROM Employees
	WHERE Salary BETWEEN 10000 AND 20000 /*IF 2 ARE TRUE*/

/*OR USE PRIORITET*/
SELECT *
	FROM Employees
	WHERE FirstName = 'Alice' OR  LastName = 'Li' /*IF ONE ARE TRUE*/

SELECT *
	FROM Employees
	WHERE (FirstName = 'Alice' OR  LastName = 'Li') 
			AND Salary > 10000	/*CHECK FIRST IF FIRST IS TRUE THE CHECK SECOND*/

/*REGULAR EXPRECION IS WORK*/ 
SELECT * 
	FROM Employees
	WHERE FirstName LIKE '[A-Z]%'
	 
/*IN*/
SELECT * 
	FROM Employees
	WHERE Salary IN (10000, 20000, 30000 ,40000, 50000)

SELECT *
	 FROM Employees
	 WHERE DepartmentID IN (3,6,9)

SELECT *
	 FROM Employees
	 WHERE DepartmentID NOT IN (3,6,9)

/*NULL*/
SELECT *
	FROM Employees
	WHERE MiddleName IS NULL /*WHEN WE USE NULL WE USE IS BEFORE*/

SELECT * 
	FROM Employees
	WHERE MiddleName IS NOT NULL
	AND MiddleName != ''