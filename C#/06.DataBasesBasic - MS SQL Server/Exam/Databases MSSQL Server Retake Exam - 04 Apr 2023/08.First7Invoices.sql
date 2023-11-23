USE Accounting
/*08. First 7 Invoices*/
SELECT TOP(7)
		i.Number
		,i.Amount
		,c.[Name] AS Client
		FROM Invoices AS i
		LEFT JOIN Clients AS c ON i.ClientId=c.Id
		WHERE i.IssueDate<CONVERT(DATETIME2,'2023-01-01 ') AND I.Currency='EUR'
		OR I.Amount>500 AND SUBSTRING(c.NumberVAT,1,2)='DE'
		ORDER BY i.Number ASC,i.Amount DESC