USE TouristAgency
/*11.Rooms with Tourists*/
CREATE OR ALTER FUNCTION udf_RoomsWithTourists(@roomType NVARCHAR(30))
RETURNS  INT
AS
BEGIN
		DECLARE @TotalTourists INT;

		-- Calculate the total number of tourists for the specified room type
		SELECT @TotalTourists = SUM(AdultsCount+ChildrenCount)
				FROM Bookings AS B
				JOIN Rooms AS R ON B.RoomId= R.Id
				WHERE R.[Type] =  @roomType;

		RETURN @TotalTourists
END;

SELECT dbo.udf_RoomsWithTourists('Double Room')
SELECT dbo.udf_RoomsWithTourists('VIP Apartment')


