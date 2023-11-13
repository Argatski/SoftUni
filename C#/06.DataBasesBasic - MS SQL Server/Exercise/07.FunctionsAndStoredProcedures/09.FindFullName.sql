USE Bank

/*Problem 9. Find Full Name*/
CREATE OR ALTER PROC usp_GetHoldersFullName 
AS
BEGIN
	SELECT CONCAT(ah.FirstName , ' ' , ah.LastName ) AS [Full Name]
	FROM AccountHolders AS ah
END

EXEC usp_GetHoldersFullName