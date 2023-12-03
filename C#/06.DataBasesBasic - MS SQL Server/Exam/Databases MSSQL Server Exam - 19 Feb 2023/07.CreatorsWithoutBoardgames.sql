USE Boardgames
/*07.CreatorsWithoutBoardgames*/
SELECT C.Id
		,CONCAT(C.FirstName,+' ', C.LastName) AS CreatorName
		,C.Email
		FROM Creators AS C
		LEFT JOIN CreatorsBoardgames AS CB ON C.Id=CB.CreatorId
		WHERE CB.CreatorId IS NULL

