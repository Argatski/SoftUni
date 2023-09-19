/*16.Create View Employees with Salaries*/
CREATE VIEW V_EmployeesSalaries AS
	SELECT FirstName, LastName,Salary 
		FROM Employees

/*17.Create View Employees with Job Titles*/
CREATE VIEW V_EmployeeNameJobTitle  AS 
	SELECT FirstName+' '+ ISNULL(MiddleName,'') + ' '+ LastName AS [Full Name],
			JobTitle
		FROM Employees

/*18.Distinct Job Titles*/
SELECT DISTINCT JobTitle
	FROM Employees
		
/*19.Find First 10 Started Projects*/
SELECT TOP(10)*
	FROM Projects
	--WHERE StartDate IS NOT NULL
	ORDER BY StartDate,[Name]

/*20.Last 7 Hired Employees*/
SELECT TOP(7)
	FirstName, LastName, HireDate
	FROM Employees
	ORDER BY HireDate DESC

/*21.Increase Salaries*/
UPDATE Employees
	SET Salary+=Salary *0.12
	WHERE DepartmentID IN(1,2,4,11)
	
	SELECT Salary
		FROM Employees

SELECT * FROM Employees

	
