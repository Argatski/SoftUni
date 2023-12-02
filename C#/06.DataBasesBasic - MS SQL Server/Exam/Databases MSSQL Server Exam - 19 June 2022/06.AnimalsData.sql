USE ZOO
/*06.Animals data*/
SELECT	a.[Name]
		,T.AnimalType
		,FORMAT(a.BirthDate, 'dd.MM.yyyy') AS BirthDate
		FROM Animals AS a
		JOIN AnimalTypes AS t ON a.AnimalTypeId=T.Id
		ORDER BY a.[Name]