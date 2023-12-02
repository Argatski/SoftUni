USE Zoo
/*09. Volunteers in Sofia*/
SELECT V.[Name]
		,V.PhoneNumber
		,SUBSTRING(Address,CHARINDEX(', ',Address)+2,LEN(V.Address)) AS Address
		FROM Volunteers AS V
		JOIN VolunteersDepartments AS VD ON V.DepartmentId=VD.Id
		WHERE VD.DepartmentName ='Education program assistant' 
		AND V.Address LIKE('%Sofia%')
		ORDER BY V.[Name]