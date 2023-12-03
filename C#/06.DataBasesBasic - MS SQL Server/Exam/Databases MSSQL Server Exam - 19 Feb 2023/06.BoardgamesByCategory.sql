USE Boardgames
/*06.Boardgames by Category*/
SELECT B.Id
		,B.[Name]
		,B.YearPublished
		,C.[Name] AS CategoryName
		FROM Boardgames AS B
		JOIN Categories AS C ON B.CategoryId=C.Id
		WHERE C.[Name]='Strategy Games' OR C.[Name] ='Wargames'
		ORDER BY B.YearPublished DESC
