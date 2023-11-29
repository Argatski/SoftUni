USE TouristAgency
/*10.Hotels Revenue*/
SELECT H.[Name] AS HotelName
		,SUM(R.Price*DATEDIFF(DAY,B.ArrivalDate,B.DepartureDate)) AS TotalBookingPrice
		FROM Bookings AS B
	JOIN Hotels AS H ON B.HotelId = H.Id
	JOIN Rooms AS R ON B.RoomId = R.Id
	GROUP BY H.[Name]
	ORDER BY TotalBookingPrice DESC
