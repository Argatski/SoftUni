USE SoftUni
/*Problem 4.EmployeeDepartments*/
SELECT TOP (5) e.EmployeeID,
	   e.FirstName,
	   e.Salary,
	   d.Name AS [DepartmentName]
	FROM Employees AS e
	JOIN Departments AS d
	ON D.DepartmentID = E.DepartmentID
	WHERE e.Salary>15000
	ORDER BY d.DepartmentID
