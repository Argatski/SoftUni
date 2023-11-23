USE Accounting
/*6.Products by Category*/
SELECT
	p.Id
	,p.[Name]
	,p.Price
	,c.[Name] AS CategoryName
FROM Products AS p
JOIN Categories AS c
ON p.CategoryId=c.Id
WHERE c.[Name]='ADR' OR c.[Name]='Others'
ORDER BY Price DESC

	
