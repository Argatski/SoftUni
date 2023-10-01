CREATE TABLE Drivers
(
	DriversID INT PRIMARY KEY,
	DriversName VARCHAR(50)
)

CREATE TABLE Cars
(
	CarID INT PRIMARY KEY,
	DriverID INT UNIQUE,-- use uniqie when we want one to one
	CONSTRAINT FK_Cars_Drivers FOREIGN KEY (DriverID) REFERENCES Drivers(DriversID)
)