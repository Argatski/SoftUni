USE Zoo
/*12.	Animals with Owner or Not*/
CREATE OR ALTER PROC usp_AnimalsWithOwnersOrNot(@AnimalName VARCHAR(30))
AS
BEGIN
	IF(SELECT OwnerId
				FROM Animals
				WHERE [Name]=@AnimalName) IS NULL
				BEGIN
					SELECT A.[Name]
							,'For adoption' AS OwnerName
							FROM Animals AS A
							WHERE Name=@AnimalName
				END
	ELSE
	BEGIN
		SELECT A.[Name]
				,O.[Name] AS OwnerName
				FROM Animals AS A
			JOIN Owners AS O ON O.Id = A.OwnerId
			WHERE A.[Name] = @AnimalName
	END
END

EXEC usp_AnimalsWithOwnersOrNot 'Pumpkinseed Sunfish'

EXEC usp_AnimalsWithOwnersOrNot 'Hippo'

EXEC usp_AnimalsWithOwnersOrNot 'Brown bear'



