CREATE DATABASE TouristAgency
USE TouristAgency

/*Section 1. DDL (30 pts)*/
/*Create Countries*/
CREATE TABLE Countries(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(50) NOT NULL
);


/*Create Destinations*/
CREATE TABLE Destinations(
Id INT PRIMARY KEY IDENTITY,
[Name] VARCHAR(50) NOT NULL,
CountryId INT NOT NULL FOREIGN KEY REFERENCES Countries(Id)
);

/*Create Rooms*/
CREATE TABLE Rooms(
Id INT PRIMARY KEY IDENTITY,
[Type] VARCHAR(40) NOT NULL,
Price DECIMAL(18,2) NOT NULL,
BedCount INT NOT NULL
	CHECK(BedCount >0 AND BedCount <=10)
);

/*Create Hotels*/
CREATE TABLE Hotels(
Id INT PRIMARY KEY IDENTITY,
[Name] VARCHAR(50) NOT NULL,
DestinationId INT NOT NULL FOREIGN KEY REFERENCES Destinations(Id)
);

/*Create Tourists*/
CREATE TABLE Tourists(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(80) NOT NULL,
PhoneNumber VARCHAR(20) NOT NULL,
Email VARCHAR(80),
CountryId INT NOT NULL FOREIGN KEY REFERENCES Countries(Id)
);

/*Create Bookings*/
CREATE TABLE Bookings(
Id INT PRIMARY KEY IDENTITY,
ArrivalDate DATETIME2 NOT NULL,
DepartureDate DATETIME2 NOT NULL,
AdultsCount INT NOT NULL
	CHECK(AdultsCount >= 1 AND AdultsCount <= 10),
ChildrenCount INT NOT NULL
	CHECK(ChildrenCount >=0 AND ChildrenCount <= 9),
TouristId INT NOT NULL FOREIGN KEY REFERENCES Tourists(Id),
HotelId INT NOT NULL FOREIGN KEY REFERENCES Hotels(Id),
RoomId INT NOT NULL FOREIGN KEY REFERENCES Rooms(Id)
);

/*Create HotelsRooms*/

CREATE TABLE HotelsRooms
(
	HotelId INT NOT NULL,
	RoomId INT NOT NULL,
	CONSTRAINT PK_HotelsRooms PRIMARY KEY (HotelId,RoomId),
	CONSTRAINT FK_HotelsRooms_Hotels FOREIGN KEY (HotelId) REFERENCES Hotels(Id),
	CONSTRAINT FK_HotelsRooms_Rooms FOREIGN KEY (RoomId) REFERENCES Rooms(Id),
)