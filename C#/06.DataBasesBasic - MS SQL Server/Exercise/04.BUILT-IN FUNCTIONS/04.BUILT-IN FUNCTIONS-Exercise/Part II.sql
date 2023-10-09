/*Problem 12.Countries Holding ‘A’ 3 or More Times*/
USE Geography
SELECT CountryName AS [Country Name],
	IsoCode AS [Iso Code]
	FROM Countries
	WHERE [CountryName] LIKE '%a%a%a%'
	ORDER BY IsoCode

/*Problem 13.Mix of Peak and River Names*/
SELECT PeakName,RiverName,
	LOWER
	(
		CONCAT
		(
			PeakName,RIGHT(RiverName,LEN(RiverName)-1)
		)
	)AS MIX
	FROM Rivers,Peaks
	WHERE RIGHT(PeakName,1)=LEFT(RiverNamE,1)
	ORDER BY MIX

