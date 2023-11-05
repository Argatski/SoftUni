USE SoftUni
/*Problem 6. Employees by Salary Level*/
CREATE OR ALTER PROC usp_EmployeesBySalaryLevel(@salaryLevel  NVARCHAR(10))
	AS
	BEGIN 
		SELECT e.FirstName,
				e.LastName
			FROM Employees AS e
			WHERE dbo.ufn_GetSalaryLevel(e.Salary) =  @salaryLevel
	END

GO

EXEC usp_EmployeesBySalaryLevel 'Low'