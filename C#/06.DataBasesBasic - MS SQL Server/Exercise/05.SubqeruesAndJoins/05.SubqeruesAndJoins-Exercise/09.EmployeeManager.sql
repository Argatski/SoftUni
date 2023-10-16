USE SoftUni
/*Problem 9.Employee Manager*/
SELECT e.EmployeeID,
	   e.FirstName,
	   e.ManagerID,
	   mng.FirstName AS [ManagerName]
	FROM Employees AS e
	JOIN Employees AS mng
	ON mng.EmployeeID =e.ManagerID
	WHERE e.ManagerID=3 OR e.ManagerID=7
	ORDER BY e.EmployeeID
