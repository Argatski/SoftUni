USE Accounting

/*Section 3. Querying (40 pts)*/
/*5.Invoices by Amount and Date*/
SELECT Number
	   ,Currency
		FROM Invoices
		ORDER BY Amount DESC
		,DueDate 
		