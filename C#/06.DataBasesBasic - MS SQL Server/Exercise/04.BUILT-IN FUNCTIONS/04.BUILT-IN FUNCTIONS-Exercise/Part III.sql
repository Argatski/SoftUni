/*Problem 14.Games from 2011 and 2012 year*/
USE Diablo
SELECT TOP(50) [Name],
	FORMAT([Start], 'yyyy-MM-dd') AS [Start]
  FROM Games
  WHERE [Start] BETWEEN '2011' AND '2013'
  ORDER BY [Start],[Name]

/*Problem 15.User Email Providers*/