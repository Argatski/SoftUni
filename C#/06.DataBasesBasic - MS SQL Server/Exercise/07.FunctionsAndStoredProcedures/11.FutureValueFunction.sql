USE Bank

/*Problem 11. Future Value Function*/
CREATE FUNCTION ufn_CalculateFutureValue (@sum DECIMAL(8, 4), @interestRate FLOAT, @numberOfYears INT)
RETURNS DECIMAL (8, 4)
AS
BEGIN
	DECLARE @result DECIMAL(8, 4)
	SET @result = @sum * (POWER((1 + @interestRate), @numberOfYears)) 
	RETURN @result
END

SELECT dbo.ufn_CalculateFutureValue(1000,0.1,5)
	FROM AccountHolders