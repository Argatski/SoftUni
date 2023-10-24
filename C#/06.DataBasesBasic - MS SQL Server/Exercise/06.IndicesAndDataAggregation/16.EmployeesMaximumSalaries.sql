USE SoftUni
/*16. Employees Maximum Salaries*/
SELECT e.DepartmentID
	,MAX(Salary) AS [MaxSalary]
	FROM Employees AS e
	GROUP BY DepartmentID
	HAVING MAX(e.Salary) NOT BETWEEN 30000 AND 70000