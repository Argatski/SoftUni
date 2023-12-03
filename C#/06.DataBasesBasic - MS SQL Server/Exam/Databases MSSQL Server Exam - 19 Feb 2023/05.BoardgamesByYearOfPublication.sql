USE Boardgames
/*05.Boardgames by Year of Publication*/
SELECT [Name]
		,Rating
	FROM Boardgames
	ORDER BY YearPublished
			,[Name] DESC

