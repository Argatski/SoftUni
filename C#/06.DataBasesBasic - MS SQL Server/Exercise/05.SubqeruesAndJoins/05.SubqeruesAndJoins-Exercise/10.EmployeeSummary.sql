USE SoftUni
/*Problem 10.Employee Summary*/
SELECT TOP(50) emp.EmployeeID,
	emp.FirstName + ' ' + emp.LastName AS [EmployeeName],
	mng.FirstName + ' ' + mng.LastName AS [ManagerName],
	dp.[Name] AS [DepartmentName]
	FROM Employees AS emp
	JOIN Employees AS mng
	ON mng.EmployeeID = emp.ManagerID
	JOIN Departments AS dp
	ON emp.DepartmentID = dp.DepartmentID
	ORDER BY EmployeeID
