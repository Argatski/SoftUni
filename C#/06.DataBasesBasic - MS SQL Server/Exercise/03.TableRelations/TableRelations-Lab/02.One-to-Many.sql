/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[CourseName]
      ,[TownId]
  FROM [Schooll].[dbo].[Courses]

  USE Schooll
  ALTER TABLE Courses 
	ADD CONSTRAINT FK_Courses_Towns 
	FOREIGN KEY (TownId)
	REFERENCES Towns(Id)