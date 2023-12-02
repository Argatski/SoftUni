USE Zoo
/*07.Owners and Their Animals.*/
SELECT TOP(5)
	O.[Name] AS Owner
	,COUNT(*) AS CountOfAnimals
	FROM Owners AS O
	JOIN Animals AS A ON A.OwnerId=O.Id
	GROUP BY O.[Name]
	ORDER BY CountOfAnimals DESC, Owner ASC
