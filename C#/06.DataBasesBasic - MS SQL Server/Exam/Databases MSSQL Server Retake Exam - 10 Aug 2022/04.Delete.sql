USE NationalTouristSitesOfBulgaria
/*04.Delete*/

SELECT * FROM BonusPrizes

DELETE FROM TouristsBonusPrizes WHERE BonusPrizeId = 5
DELETE FROM BonusPrizes WHERE Id=5

SELECT * FROM TouristsBonusPrizes