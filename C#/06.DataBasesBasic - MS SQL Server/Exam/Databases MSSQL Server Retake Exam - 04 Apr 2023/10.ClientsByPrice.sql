USE Accounting
/*10.Clients by Price*/
SELECT 
	C.[Name] AS Client
	,FLOOR(AVG(p.Price))AS [Average Price]
	FROM Clients AS c
	JOIN ProductsClients AS pc ON c.Id=pc.ClientId
	JOIN Products AS p ON pc.ProductId=p.Id
	JOIN Vendors AS v ON p.VendorId = v.Id
	WHERE pc.ClientId IS NOT NULL
	AND v.NumberVAT LIKE '%FR%'
	GROUP BY c.[Name]
	ORDER BY AVG(p.Price) ASC,c.[Name] DESC
 	