USE Boardgames
/*10.Creators by Rating*/
SELECT	
		C.LastName
		,CEILING(AVG(B.Rating))AS AverageRating
		,P.[Name]
		FROM Creators AS C
		JOIN CreatorsBoardgames AS CB
		ON C.Id=CB.CreatorId
		JOIN Boardgames AS B
		ON CB.BoardgameId=B.Id
		JOIN Publishers AS P
		ON B.PublisherId =P.Id
		WHERE CB.CreatorId IS NOT NULL
		AND P.[Name] = 'Stonemaier Games'
		GROUP BY C.LastName,P.[Name]
		ORDER BY AVG(B.Rating) DESC