/*Section 3. Querying (40 pts)*/
/*5.Bookings by Price of Room and Arrival Date*/
SELECT CONVERT(VARCHAR(10),b.ArrivalDate,120 )
		,b.AdultsCount
		,b.ChildrenCount
	FROM Bookings AS b
	JOIN Rooms AS r ON b.RoomId=r.id
	ORDER BY r.Price DESC
			,b.ArrivalDate ASC
			

/*VARIANT 2*/
SELECT FORMAT(ArrivalDate, 'yyyy-MM-dd') AS ArrivalDate, AdultsCount, ChildrenCount
FROM Bookings AS b
JOIN Rooms AS r ON r.Id = b.RoomId
ORDER BY r.Price DESC, b.ArrivalDate