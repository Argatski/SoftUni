USE SoftUni
/*13. Departments Total Salaries*/
SELECT e.DepartmentID
	  , SUM(e.Salary) AS [TotalSalarY]
	FROM  Employees AS e
	GROUP BY DepartmentID