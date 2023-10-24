USE SoftUni
/*19. **Salary Challenge*/
SELECT TOP(10)
	e.FirstName,
	e.LastName,
	e.DepartmentID
	
	FROM 
		(
			SELECT DepartmentID,
					AVG(Salary) AS [AverageSalary]
					FROM Employees
					GROUP BY DepartmentID
		)AS g,Employees AS e
WHERE e.DepartmentID = g.DepartmentID
AND e.Salary > g.AverageSalary