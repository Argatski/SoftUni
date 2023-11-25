/*06.Hotels by Count of Bookings*/
SELECT h.Id
		,h.[Name]
		FROM Hotels AS h
		JOIN HotelsRooms AS hr ON h.Id=hr.HotelId
		JOIN Rooms AS r ON r.Id=hr.RoomId
		JOIN Bookings AS b ON h.Id =b.HotelId AND r.[Type] = 'VIP Apartment'
		GROUP BY h.Id,h.[Name]
		ORDER BY COUNT(*) DESC
