USE Zoo
/*10.Animals for Adoption*/
SELECT A.[Name]
		,YEAR(A.BirthDate) AS BirthYear
		,ANT.AnimalType
		FROM Animals AS A
		JOIN AnimalTypes AS ANT ON A.AnimalTypeId=ANT.Id
		WHERE A.OwnerId IS NULL
		AND ANT.AnimalType!='Birds'
		AND DATEDIFF(YEAR,BirthDate,'01/01/2022')<5
		ORDER BY Name
