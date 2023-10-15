USE SoftUni
/*Problem 2.Addresses with Towns*/
SELECT TOP (50) E.FirstName,
			    E.LastName,
				T.[Name] AS [Town],
				A.AddressText	
	FROM Employees AS E
	JOIN Addresses AS A
	ON A.AddressID = E.AddressID
	JOIN Towns AS T
	ON T.TownID =A.TownID
	ORDER BY E.FirstName,E.LastName