USE NationalTouristSitesOfBulgaria

/*11. Tourists Count on a Tourist Site*/
CREATE OR ALTER FUNCTION udf_GetTouristsCountOnATouristSite (@Site VARCHAR(100))
RETURNS INT
AS
BEGIN
	RETURN
	(
		SELECT COUNT(T.Id)
				FROM Tourists AS T
				JOIN SitesTourists AS ST ON T.Id=ST.TouristId
				JOIN Sites AS S ON ST.SiteId=S.Id
				WHERE S.[Name] = @Site
	)
END

SELECT dbo.udf_GetTouristsCountOnATouristSite ('Regional History Museum – Vratsa')
SELECT dbo.udf_GetTouristsCountOnATouristSite ('Samuil’s Fortress')
SELECT dbo.udf_GetTouristsCountOnATouristSite ('Gorge of Erma River')