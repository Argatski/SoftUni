/*WILDCARDS = (REGEX)*/
USE SoftUni
SELECT EmployeeID,FirstName,LastName
	FROM Employees
	WHERE FirstName LIKE 'Ro%' /*GET NAME WITH START 'Ro'*/
	
/*WILDCARDS = (REGEX)*/
SELECT EmployeeID,FirstName,LastName
	FROM Employees
	WHERE FirstName LIKE '%ob%' /*GET NAME WITH START 'Ro'*/

/*WILDCARDS = (REGEX)*/
SELECT EmployeeID,FirstName,LastName
	FROM Employees
	WHERE FirstName LIKE '%ob_r%' /*GET NAME WITH START 'Ro'*/
/**/
SELECT EmployeeID,FirstName,LastName
	FROM Employees
	WHERE FirstName LIKE 'And[yr]%' /*GET NAME WITH START 'Ro'*/

SELECT EmployeeID,FirstName,LastName
	FROM Employees
	WHERE FirstName LIKE 'And[y]' /*GET NAME WITH START 'Ro'*/