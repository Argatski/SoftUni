USE NationalTouristSitesOfBulgaria
/*07.Count of Sites in Sofia Province*/
SELECT L.Province
		,L.Municipality
		,L.[Name] AS [Location]
		,COUNT(S.[Name]) AS CountOfSites
		FROM Locations AS L
		JOIN Sites AS S ON L.Id=S.LocationId
		WHERE L.Province ='Sofia'
		GROUP BY L.[Name],L.Municipality,L.Province
		ORDER BY CountOfSites DESC
				,L.[Name]