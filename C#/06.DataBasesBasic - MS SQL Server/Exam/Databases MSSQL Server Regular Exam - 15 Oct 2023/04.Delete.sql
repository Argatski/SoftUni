/*4.Delete*/
BEGIN TRANSACTION

DECLARE @TouristIdsToDelete TABLE (Id INT);

INSERT INTO @TouristIdsToDelete (Id)
SELECT Id
FROM Tourists
WHERE [Name] LIKE '%Smith%';

DELETE FROM Bookings
WHERE TouristId IN(SELECT Id FROM @TouristIdsToDelete);

DELETE FROM Tourists
WHERE Id IN (SELECT Id FROM @TouristIdsToDelete);

COMMIT;
