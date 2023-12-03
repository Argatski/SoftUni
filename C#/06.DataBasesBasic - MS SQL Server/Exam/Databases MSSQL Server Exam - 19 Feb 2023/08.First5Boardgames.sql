USE Boardgames
/*8.First 5 Boardgames*/
SELECT TOP(5)
			B.[Name]
			,B.Rating
			,CAT.[Name] AS CategoryName
			FROM Boardgames AS B
			LEFT JOIN Categories AS CAT
			ON B.CategoryId =CAT.Id
			LEFT JOIN  PlayersRanges AS R
			ON B.PlayersRangeId =R.Id
			WHERE B.Rating>7.00
				AND PlayersMin>=2
				AND PlayersMax<=5
				ORDER BY B.[Name],
						B.Rating DESC