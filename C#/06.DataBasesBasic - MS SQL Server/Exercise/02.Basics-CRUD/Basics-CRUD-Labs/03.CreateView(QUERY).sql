/*SAVE QUERY (VIEW)*/
CREATE VIEW v_GetHireDateAndDayOfWeek AS /*CREATE QUERY (VIEW)*/
-- PLEACE OF OUY QUERY IS A DATABASE->VIEWS(FOLDER)
-- THIS QUERY WE CAN USE IN ANOTHER FILE
-- WE CAN GET PERMISSIONS
SELECT HireDate, DATENAME(DW,HireDate) AS DayOfWeek
	FROM Employees

--SELECT * FROM [v_GetHireDateAndDayOfWeek]  IN ANOTHER QUERY 