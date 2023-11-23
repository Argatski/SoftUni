USE Accounting

/*11.Product with Clients*/
CREATE OR ALTER FUNCTION udf_ProductWithClients(@name NVARCHAR(30)) 
RETURNS INT
BEGIN
	DECLARE @totalProductClient INT=
	(
		SELECT 
				COUNT(PC.ClientId)
				FROM Products AS P
				JOIN ProductsClients AS pc ON P.Id = pc.ProductId
				WHERE P.[Name] =  @name
	)
	RETURN @totalProductClient
END

/*RESULT*/
SELECT dbo.udf_ProductWithClients('DAF FILTER HU12103X')