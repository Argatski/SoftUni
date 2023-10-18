USE Geography
/*Problem 13.Count Mountain Ranges*/
SELECT mc.CountryCode,
	  COUNT(m.MountainRange) AS [MountainRanges]
	FROM Mountains AS m
	JOIN MountainsCountries AS mc
	ON mc.MountainId =  m.Id
	WHERE mc.CountryCode IN ('US','RU','BG')
	GROUP BY mc.CountryCode

