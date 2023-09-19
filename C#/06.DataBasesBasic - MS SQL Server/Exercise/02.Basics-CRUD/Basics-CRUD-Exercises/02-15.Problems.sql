USE SoftUni
/*02.Find All Information About Departments*/
SELECT *
	FROM Departments

/*03.Find all Department Names*/
SELECT [Name]
	FROM Departments

/*04. Find Salary of Each Employee*/
SELECT	[FirstName], [LastName], [Salary] 
	FROM Employees

/*05. Find Full Name of Each Employee*/
SELECT [FirstName], [MiddleName], [LastName]
	FROM Employees

/*6.Find Email Address of Each Employee*/
SELECT e.FirstName + '.'+ e.LastName + '@softuni.bg'
	AS [Full Email Address]
	FROM Employees
	AS e

/*07.Find All Different Employee’s Salaries*/
SELECT DISTINCT Salary
	FROM Employees

/*08.Find all Information About Employees*/	
SELECT *
	FROM Employees
	WHERE JobTitle = 'Sales Representative'

/*09. Find Names of All Employees by Salary in Range*/
SELECT FirstName, LastName , JobTitle
	FROM Employees
	--WHERE Salary >=20000 AND Salary<=30000
	WHERE Salary BETWEEN 20000 AND 30000

/*10.Find Names of All Employees*/
SELECT FirstName + ' ' + MiddleName + ' ' + LastName
	AS [Full Name]
	FROM Employees
	WHERE Salary IN(25000,14000, 12500, 23600) 
	
/*11.Find All Employees Without Manager*/
SELECT FirstName,LastName
	FROM Employees
	WHERE ManagerID  IS NULL

/*12.Find All Employees with Salary More Than*/
SELECT FirstName, LastName, Salary
	FROM Employees
	WHERE Salary>50000
	ORDER BY Salary DESC

/*13.Find 5 Best Paid Employees*/
SELECT TOP(5) FirstName, LastName
	FROM Employees
	ORDER BY Salary DESC

/*14.Find All Employees Except Marketing*/
SELECT FirstName, LastName
	FROM Employees
	WHERE DepartmentID!=4

/*15.Sort Employees Table*/
SELECT *
	FROM Employees
	ORDER BY Salary DESC,
			FirstName,
			LastName DESC,
			MiddleName
			
