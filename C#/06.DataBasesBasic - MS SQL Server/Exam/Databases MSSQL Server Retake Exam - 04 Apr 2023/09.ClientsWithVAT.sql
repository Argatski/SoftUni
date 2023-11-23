USE Accounting
/*09. Clients with VAT*/
SELECT	C.[Name] AS Client
		, MAX(P.Price) AS Price
		, C.NumberVAT AS [VAT Number]
		FROM ProductsClients AS pc
		JOIN Clients AS c ON pc.ClientId=c.Id
		JOIN Products AS p ON pc.ProductId=p.Id
		WHERE c.[Name] NOT LIKE '%KG%'
		GROUP BY c.[Name], c.NumberVAT
		ORDER BY MAX(p.Price) DESC
