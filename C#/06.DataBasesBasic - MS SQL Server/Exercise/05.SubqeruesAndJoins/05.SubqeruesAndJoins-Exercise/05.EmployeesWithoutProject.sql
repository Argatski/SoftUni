USE SoftUni
/*Problem 5.Employees Without Project*/
SELECT TOP(3) e.EmployeeID,	
	   e.FirstName
	FROM Employees AS e
	LEFT JOIN EmployeesProjects AS ep
	ON ep.EmployeeID =e.EmployeeID
	WHERE ep.ProjectID IS NULL AND ep.ProjectID IS NULL
	ORDER BY e.EmployeeID


