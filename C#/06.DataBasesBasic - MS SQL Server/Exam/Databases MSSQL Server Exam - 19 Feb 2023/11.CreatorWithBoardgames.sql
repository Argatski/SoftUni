USE Boardgames
/*11.Creator with Boardgames*/
CREATE OR ALTER FUNCTION udf_CreatorWithBoardgames(@name NVARCHAR(30))
RETURNS INT 
AS 
BEGIN 
	DECLARE @totalBoardgamesCreator INT =
	(
		SELECT 
				COUNT(CB.BoardgameId) 
		FROM Creators AS C
		JOIN CreatorsBoardgames AS CB
		ON C.Id = CB.CreatorId
		WHERE C.FirstName=@name
	)
	RETURN @totalBoardgamesCreator
END

SELECT dbo.udf_CreatorWithBoardgames('Bruno')
SELECT *FROM Creators