/*7.Tourists without Bookings*/
SELECT T.Id, T.[Name], T.PhoneNumber
	FROM Tourists T
	LEFT JOIN Bookings B ON T.Id = B.TouristId
	WHERE B.TouristId IS NULL	
	ORDER BY T.Name ASC;