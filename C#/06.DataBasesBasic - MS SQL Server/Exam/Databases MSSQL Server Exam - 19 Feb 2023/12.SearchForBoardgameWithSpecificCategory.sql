USE Boardgames
/*12. Search for Boardgame with Specific Category*/
CREATE OR ALTER PROC usp_SearchByCategory(@category NVARCHAR(50))
AS 
BEGIN
		SELECT B.[Name]
				,B.YearPublished
				,B.Rating
				,CAT.[Name] AS CategoryName
				,P.[Name] AS PublisherName
				,CONCAT(PR.PlayersMin, ' people') AS MinPlayers
				,CONCAT(PR.PlayersMax, ' people') AS MaxPlayers
				FROM Boardgames AS B
				JOIN Publishers AS P
				ON B.PublisherId=P.Id
				JOIN Categories AS CAT
				ON CAT.Id= B.CategoryId
				LEFT JOIN PlayersRanges AS PR
				ON PR.Id=B.Id
				WHERE CAT.[Name]=@category
				ORDER BY PublisherName,YearPublished DESC
END


EXEC usp_SearchByCategory 'WARGAMES'