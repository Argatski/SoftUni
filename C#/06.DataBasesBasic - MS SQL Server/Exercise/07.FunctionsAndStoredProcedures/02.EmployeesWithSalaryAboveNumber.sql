USE SoftUni
/*Problem 2. Employees with Salary Above Number*/

CREATE OR ALTER PROC usp_GetEmployeesSalaryAboveNumber(@number DECIMAL(18,4))
	AS
	BEGIN
		SELECT e.FirstName,e.LastName 
			FROM Employees AS e
			WHERE e.Salary>=@number
	END
GO

EXEC usp_GetEmployeesSalaryAboveNumber 48100
