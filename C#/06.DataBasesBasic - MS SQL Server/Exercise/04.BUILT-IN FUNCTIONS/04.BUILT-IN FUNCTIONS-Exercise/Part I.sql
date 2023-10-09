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

/*Problem 4.Find All Employees Except Engineers*/
SELECT FirstName, LastName
	FROM Employees
	WHERE JobTitle NOT LIKE '%engineer%'

/*Problem 5.Find Towns with Name Length*/
SELECT [Name] 
	FROM Towns 
	WHERE LEN([Name]) IN (5,6)
	ORDER BY [Name]

/*Problem 6.Find Towns Starting With*/
SELECT TownID,[Name]
	FROM Towns
	WHERE [Name] LIKE '[MKBE]%'
	ORDER BY [Name]

/*Problem 7.Find Towns Not Starting With*/
SELECT TownID,[Name]
	FROM Towns
	WHERE [Name] NOT LIKE '[RBD]%'
	ORDER BY [Name]

/*Problem 8.Create View Employees Hired After 2000 Year*/
CREATE VIEW V_EmployeesHiredAfter2000 AS
SELECT FirstName,LastName
	 FROM Employees
	 WHERE HireDate>= '2001'

/*Problem 9.Length of Last Name*/
SELECT FirstName,LastName
	FROM Employees
	WHERE LEN(LastName) IN (5)

/*Problem 10.Rank Employees by Salary*/
SELECT EmployeeID,FirstName,LastName,Salary,
	DENSE_RANK() OVER (PARTITION BY Salary ORDER BY EmployeeID) AS [Rank]
	FROM Employees
	WHERE Salary BETWEEN 10000 AND 50000
	ORDER BY Salary DESC

/*Problem 11.Find All Employees with Rank 2 */
SELECT R.EmployeeID,R.FirstName,R.LastName,R.Salary,R.[Rank]
	FROM ( SELECT EmployeeID,
			 FirstName,
	         LastName,
	         Salary,
	         DENSE_RANK() OVER (PARTITION BY Salary ORDER BY EmployeeID) AS [Rank]
            FROM Employees
	WHERE Salary BETWEEN 10000 AND 50000) AS R
	WHERE [Rank] = 2
	ORDER BY R.Salary DESC