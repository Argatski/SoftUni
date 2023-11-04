USE SoftUni
/*Problem 4. Employees from Town*/
CREATE OR ALTER PROC usp_GetEmployeesFromTown (@townName NVARCHAR(MAX))
	AS
	BEGIN
		SELECT e.FirstName,e.LastName
			FROM Employees AS e
			JOIN Addresses AS a
			ON a.AddressID =e.AddressID
			JOIN Towns AS t
			ON t.TownID =  a.TownID
			WHERE t.[Name] = @townName
	END
GO

EXEC usp_GetEmployeesFromTown Sofia