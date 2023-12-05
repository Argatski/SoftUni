USE NationalTouristSitesOfBulgaria

/*09.TouristsWithTheirBonusPrizes*/
SELECT T.[Name]
		,T.Age
		,T.PhoneNumber
		,T.Nationality
		,ISNULL (BP.[NAME],'(no bonus prize)') AS Reward
		FROM Tourists AS T
		LEFT JOIN TouristsBonusPrizes AS TBP ON T.Id=TBP.TouristId
		LEFT JOIN BonusPrizes AS BP ON BP.Id=TBP.BonusPrizeId
		ORDER BY T.[Name]
