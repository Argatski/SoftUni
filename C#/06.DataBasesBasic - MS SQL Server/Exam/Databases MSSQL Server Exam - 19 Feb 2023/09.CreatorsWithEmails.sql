USE Boardgames
/*09. Creators with Emails*/
SELECT CONCAT(C.FirstName,' ',C.LastName) AS FullName
		,C.Email
		,MAX(B.Rating) AS Rating
		FROM CreatorsBoardgames AS CB
		JOIN Creators AS C
		ON CB.CreatorId=C.Id
		JOIN Boardgames AS B
		ON CB.BoardgameId = B.Id
		WHERE Email LIKE '%.com'
		GROUP BY CONCAT(C.FirstName,' ',C.LastName),Email
		ORDER BY CONCAT(C.FirstName, ' ',C.LastName)
		