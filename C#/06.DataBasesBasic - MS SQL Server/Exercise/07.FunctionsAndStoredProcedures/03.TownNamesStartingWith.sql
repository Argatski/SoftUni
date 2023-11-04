USE SoftUni
/*Problem 3. Town Names Starting With*/

CREATE OR ALTER PROC usp_GetTownsStartingWith (@string NVARCHAR(MAX))
AS
	BEGIN
		SELECT t.[Name]
			FROM Towns AS t
			WHERE LEFT(t.[Name],LEN(@string)) = @string
	END
GO

EXEC usp_GetTownsStartingWith Sa