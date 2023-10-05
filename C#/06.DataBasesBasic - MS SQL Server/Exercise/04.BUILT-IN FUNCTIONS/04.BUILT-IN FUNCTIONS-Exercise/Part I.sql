/*Problem 1.Find Names of All Employees by First Name*/
Use SoftUni

SELECT FirstName,LastName
	FROM Employees
	WHERE FirstName LIKE ('sa%')

/*Problem 2.Find Names of All employees by Last Name*/
SELECT FirstName,LastName
	FROM Employees
	WHERE LastName LIKE ('%EI%')

/*Problem 3.Find First Names of All Employees*/
SELECT /*EmployeeID,*/FirstName --,HireDate
	FROM Employees
	WHERE DepartmentID IN  (3, 10) AND
		HireDate BETWEEN CAST('1995' AS DATE) AND CAST('2006' AS DATE)