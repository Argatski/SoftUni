/*Section 1. DDL (30 pts)*/
CREATE DATABASE Boardgames
USE Boardgames
/*1.Database design*/
/*Create Table Categories */
CREATE TABLE Categories
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(50) NOT NULL
)

/*Create Table Addresses */
CREATE TABLE Addresses
(
	Id INT PRIMARY KEY IDENTITY,
	StreetName NVARCHAR(100) NOT NULL,
	StreetNumber INT NOT NULL,
	Town NVARCHAR(30) NOT NULL,
	Country NVARCHAR(50) NOT NULL,
	ZIP INT NOT NULL,
)

/*Create Table Publishers */
CREATE TABLE Publishers
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(30) NOT NULL,
	AddressId INT NOT NULL 
	FOREIGN KEY REFERENCES Addresses(Id),
	Website NVARCHAR(40),
	Phone NVARCHAR(20)
)

/*Create Table PlayersRanges */
CREATE TABLE PlayersRanges
(
	Id INT PRIMARY KEY IDENTITY,
	PlayersMin INT NOT NULL,
	PlayersMax INT NOT NULL 
)

/*Create Table Boardgames */
CREATE TABLE Boardgames
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(30) NOT NULL,
	YearPublished INT NOT NULL,
	Rating DECIMAL (3,2),
	CategoryId INT NOT NULL 
	FOREIGN KEY REFERENCES Categories(Id),
	PublisherId INT NOT NULL 
	FOREIGN KEY REFERENCES Publishers(Id),
	PlayersRangeId INT NOT NULL  
	FOREIGN KEY REFERENCES PlayersRanges(Id)
)

/*Create Table Creators*/
CREATE TABLE Creators
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(30) NOT NULL,
	LastName NVARCHAR(30) NOT NULL,
	Email NVARCHAR(30) NOT NULL
)


/*Create Table Creators*/
CREATE TABLE CreatorsBoardgames
(
	CreatorId INT NOT NULL,
	BoardgameId INT NOT NULL,
	CONSTRAINT PK_CreatorsBoardgames PRIMARY KEY (CreatorId,BoardgameId),
	CONSTRAINT FK_CreatorsBoardgames_Creators FOREIGN KEY(CreatorId) REFERENCES Creators(Id),
	CONSTRAINT FK_CreatorsBoardgames_BoardgameId FOREIGN KEY (BoardgameId) REFERENCES Boardgames(Id),
)
