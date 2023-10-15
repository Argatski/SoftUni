USE SoftUni
/*Problem 3.SalesEmployee*/
SELECT e.EmployeeID,
	   e.FirstName,
	   e.LastName,
	   d.[Name]
	FROM Employees AS e
	JOIN Departments AS d
	ON D.DepartmentID = E.DepartmentID
	WHERE D.[Name] = 'Sales'
	ORDER BY e.EmployeeID

