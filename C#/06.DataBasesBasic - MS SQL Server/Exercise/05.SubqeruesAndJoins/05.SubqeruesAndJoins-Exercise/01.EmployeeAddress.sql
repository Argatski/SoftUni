USE SoftUni
/*Problem 1.Employee Address*/
SELECT TOP(5) E.EmployeeID,
			  E.JobTitle,
			  A.AddressID,
			  A.AddressText
	FROM Employees AS E
	JOIN Addresses AS A
	ON A.AddressID=E.AddressID
	ORDER BY A.AddressID
