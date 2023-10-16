USE Geography
/*Problem 12.Highest Peaks in Bulgaria*/
SELECT mc.CountryCode,
	M.MountainRange,
	p.PeakName,
	p.Elevation
	FROM Mountains AS m
	JOIN Peaks AS p
	ON p.MountainId = m.Id
	JOIN MountainsCountries AS mc
	ON  mc.MountainId= p.MountainId
	WHERE mc.CountryCode = 'BG' AND p.Elevation>2835
	ORDER BY p.Elevation DESC


/*ANOTHER SOLUTION*/
  SELECT mc.CountryCode,
         m.MountainRange,
	 p.PeakName,
	 p.Elevation
    FROM Peaks AS p
    JOIN Mountains AS m
      ON m.Id = p.MountainId
    JOIN MountainsCountries AS mc
      ON mc.MountainId = m.Id
     AND mc.CountryCode = 'BG'
   WHERE p.Elevation > 2835
ORDER BY p.Elevation DESC