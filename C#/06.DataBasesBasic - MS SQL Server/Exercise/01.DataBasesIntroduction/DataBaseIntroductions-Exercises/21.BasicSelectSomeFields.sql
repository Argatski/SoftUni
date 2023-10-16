USE SoftUni

/*SELECT ALL RECORDS FROM THE TOWNS*/
SELECT [Name] FROM Towns ORDER BY [Name]

/*SELECT ALL RECORDS FROM DEPARTMENTS*/
SELECT [Name] FROM Departments ORDER BY [Name]

/*SELECT ALL RECORDS FROM EMPLOYEES*/
SELECT	[FirstName],[LastName],[JobTitle],[Salary] 
FROM	Employees 
ORDER BY Salary DESC