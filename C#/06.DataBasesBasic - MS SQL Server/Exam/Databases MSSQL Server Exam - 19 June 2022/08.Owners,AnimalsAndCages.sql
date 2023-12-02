USE Zoo
/*8.Owners, Animals and Cages*/
SELECT	CONCAT(O.[Name], + '-' + A.[Name] ) AS OwnersAnimals
		, O.PhoneNumber
		,C.Id AS CageId
		FROM Owners AS O
		JOIN Animals AS A ON A.OwnerId=O.Id
		JOIN AnimalTypes AS at ON at.Id = A.AnimalTypeId
		JOIN AnimalsCages AS AC ON AC.AnimalId= A.Id
		JOIN Cages AS C ON C.Id=AC.CageId
		WHERE AnimalType = 'Mammals'
		ORDER BY O.[Name],A.[Name] DESC
