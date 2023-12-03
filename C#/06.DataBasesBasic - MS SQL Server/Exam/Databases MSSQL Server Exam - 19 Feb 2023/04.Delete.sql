USE Boardgames
/*04.Delete*/
DELETE FROM CreatorsBoardgames WHERE BoardgameId IN(1,16,31,47)
DELETE FROM Boardgames WHERE PublisherId IN (1,16)
DELETE FROM Publishers WHERE AddressId IN(5)
DELETE FROM Addresses WHERE SUBSTRING(Town,1,1)='L'