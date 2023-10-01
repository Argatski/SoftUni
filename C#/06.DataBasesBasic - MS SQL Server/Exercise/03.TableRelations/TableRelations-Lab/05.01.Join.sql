USE Geography

SELECT M.MountainRange, P.PeakName,P.Elevation
	FROM Mountains AS M
	JOIN Peaks AS P ON P.MountainId = M.Id
	WHERE M.MountainRange = 'Rila'
	ORDER BY P.Elevation DESC