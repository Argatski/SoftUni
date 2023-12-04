CREATE DATABASE NationalTouristSitesOfBulgaria
USE NationalTouristSitesOfBulgaria
/*Section 1. DDL (30 pts)*/
/*Create Table Categories*/
CREATE TABLE Categories
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL
)

/*Create Table Locations*/
CREATE TABLE Locations
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL,
	Municipality VARCHAR(50),
	Province VARCHAR(50)
)

/*Create Table Sites*/
CREATE TABLE Sites
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(100) NOT NULL,
	LocationId INT NOT NULL FOREIGN KEY REFERENCES Locations(Id),
	CategoryId INT NOT NULL FOREIGN KEY REFERENCES Categories(Id),
	Establishment VARCHAR (15)
)


/*Create Table Tourists*/
CREATE TABLE Tourists
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL,
	Age INT NOT NULL CHECK(Age>=0 AND Age<=120),
	PhoneNumber VARCHAR(20) NOT NULL,
	Nationality VARCHAR(30) NOT NULL,
	Reward VARCHAR(20)--
)

/*Create Table SitesTourists*/
CREATE TABLE SitesTourists
(
	TouristId INT NOT NULL FOREIGN KEY REFERENCES Tourists(Id),
	SiteId INT NOT NULL  FOREIGN KEY REFERENCES Sites(Id),
	PRIMARY KEY(TouristId,SiteId)
)

/*Create Table BonusPrizes*/
CREATE TABLE BonusPrizes
(
	Id INT PRIMARY KEY IDENTITY,--
	[Name] VARCHAR(50) NOT NULL
)

/*Create Table BonusPrizes*/
CREATE TABLE TouristsBonusPrizes
(
	TouristId INT NOT NULL FOREIGN KEY REFERENCES Tourists(Id),
	BonusPrizeId INT NOT NULL FOREIGN KEY REFERENCES BonusPrizes(Id),
	PRIMARY KEY (TouristId,BonusPrizeId)
)
