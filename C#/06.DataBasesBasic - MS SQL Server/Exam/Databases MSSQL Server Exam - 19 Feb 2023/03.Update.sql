USE Boardgames
/*3.Update*/
UPDATE PlayersRanges
SET PlayersMax+=1
WHERE ID=1

UPDATE Boardgames
SET [Name]=[Name]+'V2'
WHERE YearPublished >=2020