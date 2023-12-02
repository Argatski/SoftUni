USE Zoo
/*Section 3. Querying (40 pts)*/
/*5.Volunteers*/
SELECT [Name]
		,PhoneNumber
		,[Address]
		,AnimalId
		,DepartmentId
	FROM Volunteers  
	ORDER BY [Name] ASC,
			AnimalId ASC,
			DepartmentId ASC
			

