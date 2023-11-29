USE TouristAgency
/*8.First 10 Bookings*/
SELECT TOP(10) 
		h.[Name] AS HotelName
		,d.[Name] AS DestinationName
		,c.[Name] AS CountryName
 	FROM Bookings AS b
	JOIN Tourists AS t ON b.TouristId=t.Id
	JOIN Hotels AS h ON b.HotelId = h.Id
	JOIN Destinations AS d ON h.DestinationId=d.Id
	JOIN Countries AS c  ON d.CountryId=c.Id
	WHERE b.ArrivalDate<'2023-12-31'
			AND b.HotelId%2<>0
	ORDER BY
		c.[Name] ASC
		,b.ArrivalDate ASC

