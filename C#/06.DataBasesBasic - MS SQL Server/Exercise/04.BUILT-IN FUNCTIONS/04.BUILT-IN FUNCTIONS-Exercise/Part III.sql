/*Problem 14.Games from 2011 and 2012 year*/
USE Diablo
SELECT TOP(50) [Name],
	FORMAT([Start], 'yyyy-MM-dd') AS [Start]
  FROM Games
  WHERE [Start] BETWEEN '2011' AND '2013'
  ORDER BY [Start],[Name]

/*Problem 15.User Email Providers*/
SELECT Username,
		SUBSTRING(Email,CHARINDEX('@',Email)+1,LEN(Email))AS [Email Provider]
	FROM Users
	ORDER BY [Email Provider], Username

/*Problem 16.Get Users with IPAdress Like Pattern*/
SELECT  Username,
	IpAddress AS [IP Address]
	FROM Users
	WHERE IpAddress LIKE '___.1%.%.___'
	ORDER BY Username

/*Problem 17.Show All Games with Duration and Part of the Day*/