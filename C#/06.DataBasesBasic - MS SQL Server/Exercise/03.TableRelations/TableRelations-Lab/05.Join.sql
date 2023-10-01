SELECT * 
	FROM Schooll.DBO.Courses AS C
	JOIN Towns AS T ON T.Id=C.TownId

---------
SELECT C.CourseName, T.Name,T.Population
	FROM Courses AS C
	JOIN Towns AS T ON C.TownId=T.Id
	WHERE Population >=300000
	ORDER BY C.CourseName