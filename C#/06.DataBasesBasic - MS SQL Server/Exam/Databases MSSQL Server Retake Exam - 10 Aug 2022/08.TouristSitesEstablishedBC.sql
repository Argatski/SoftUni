USE NationalTouristSitesOfBulgaria

/*8.Tourist Sites established BC*/
SELECT S.[Name]
		,L.[Name]
		,L.Municipality
		,L.Province
		,S.Establishment
		FROM Sites AS S
		JOIN Locations AS L ON S.LocationId=L.Id
		WHERE LEFT(L.[Name],1) NOT LIKE'[B,M,D]'
		AND S.Establishment LIKE '%BC'
		ORDER BY S.[Name] ASC


