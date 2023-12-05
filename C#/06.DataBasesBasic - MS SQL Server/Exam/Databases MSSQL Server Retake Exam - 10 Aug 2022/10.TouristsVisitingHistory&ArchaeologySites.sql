USE NationalTouristSitesOfBulgaria

/*10. Tourists visiting History & Archaeology sites*/
SELECT  SUBSTRING(t.Name, CHARINDEX(' ', t.Name) + 1, LEN(t.Name)) AS 'LastName', 
		t.Nationality
		,t.Age
		,t.PhoneNumber
		FROM Tourists AS T
		JOIN SitesTourists AS ST ON ST.TouristId=T.Id
		JOIN Sites AS S ON ST.SiteId=S.Id
		JOIN Categories AS CT ON S.CategoryId=CT.Id
		WHERE CT.[Name] LIKE 'History and archaeology'
		GROUP BY T.[Name],T.Nationality,T.Age,T.PhoneNumber
		ORDER BY LastName
		