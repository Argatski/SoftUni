USE NationalTouristSitesOfBulgaria
/*12. Annual Reward Lottery*/
CREATE OR ALTER PROC usp_AnnualRewardLottery(@TouristName VARCHAR(50))
AS
BEGIN
	IF(
		SELECT COUNT(S.Id)
				FROM Sites AS S
				JOIN SitesTourists AS ST ON S.Id=ST.SiteId
				JOIN Tourists AS T ON ST.TouristId =T.Id
				WHERE T.[Name]=@TouristName)>=100
			
		BEGIN
			UPDATE Tourists
			SET Reward='Gold badge'
			WHERE [Name] = @TouristName
		END
	ELSE IF(SELECT COUNT(S.Id)
				FROM Sites AS S
				JOIN SitesTourists AS ST ON S.Id=ST.SiteId
				JOIN Tourists AS T ON ST.TouristId =T.Id
				WHERE T.[Name]=@TouristName)>=50

		BEGIN
			UPDATE Tourists
			SET Reward='Silver badge'
			WHERE [Name] = @TouristName
		END

		ELSE IF(SELECT COUNT(S.Id)
				FROM Sites AS S
				JOIN SitesTourists AS ST ON S.Id=ST.SiteId
				JOIN Tourists AS T ON ST.TouristId =T.Id
				WHERE T.[Name]=@TouristName)>=25

		BEGIN
			UPDATE Tourists
			SET Reward='Silver badge'
			WHERE [Name] = @TouristName
			
		END
		SELECT [Name], Reward FROM Tourists
		WHERE [Name] = @TouristName
END

EXEC usp_AnnualRewardLottery 'Gerhild Lutgard'	
EXEC usp_AnnualRewardLottery 'Teodor Petrov'
EXEC usp_AnnualRewardLottery 'Zac Walsh'