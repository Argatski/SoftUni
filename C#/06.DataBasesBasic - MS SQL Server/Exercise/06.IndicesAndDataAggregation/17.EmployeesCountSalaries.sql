USE SoftUni
/*17. Employees Count Salaries*/
SELECT COUNT(Salary) AS [Count]
	FROM Employees AS e
	GROUP BY ManagerID
	HAVING ManagerID IS NULL