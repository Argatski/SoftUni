USE TouristAgency

/*9.Tourists booked in Hotels*/
SELECT h.[Name] AS HotelName
		,r.Price AS RoomPrice
		FROM Tourists AS t
JOIN Bookings AS b ON t.Id = b.TouristId
JOIN Hotels AS h ON b.HotelId=h.Id
JOIN Rooms AS r ON b.RoomId= R.Id
WHERE RIGHT(t.[Name],2) !='EZ' -- Select tourists whose names do not end in "EZ"
ORDER BY r.Price DESC 