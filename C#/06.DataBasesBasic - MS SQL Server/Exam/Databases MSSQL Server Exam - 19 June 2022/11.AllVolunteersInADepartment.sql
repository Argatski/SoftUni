USE Zoo
/*11.All Volunteers in a Department*/
CREATE OR ALTER FUNCTION udf_GetVolunteersCountFromADepartment
						(@VolunteersDepartment VARCHAR(30))
RETURNS INT
AS
BEGIN
	RETURN(
		SELECT COUNT(V.Id)
				FROM Volunteers AS V
				JOIN VolunteersDepartments AS VD ON V.DepartmentId =VD.Id
				WHERE VD.DepartmentName = @VolunteersDepartment
	)
END

SELECT dbo.udf_GetVolunteersCountFromADepartment('Education program assistant')

SELECT dbo.udf_GetVolunteersCountFromADepartment('Guest engagement')

SELECT dbo.udf_GetVolunteersCountFromADepartment('Zoo events')