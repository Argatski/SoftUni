USE NationalTouristSitesOfBulgaria
/*03.Update*/

SELECT * FROM Sites

UPDATE Sites
SET Establishment='(not defined)'
WHERE Establishment IS NULL

SELECT * FROM Sites
