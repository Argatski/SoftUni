USE NationalTouristSitesOfBulgaria
/*06. Sites with Their Location and Category*/
SELECT S.[Name] AS [Site]
		,L.[Name] AS [Location]
		,S.Establishment
		,C.[Name] AS Category
		FROM Sites AS S
		JOIN Locations AS L  ON S.LocationId=L.Id
		JOIN Categories AS C ON S.CategoryId=C.Id
		ORDER BY C.[Name] DESC
				 ,L.[Name] 
				 ,S.[Name]

		