--- Problem 01: DDL
--- Table: Countries
CREATE TABLE Countries(
	Id INT PRIMARY KEY IDENTITY
	, [Name] VARCHAR(10) NOT NULL
);

--- Table: Addresses
CREATE TABLE Addresses(
	Id INT PRIMARY KEY IDENTITY
	, StreetName NVARCHAR(20) NOT NULL
	, StreetNumber INT 
	, PostCode INT NOT NULL
	, City VARCHAR(25) NOT NULL
	, CountryId INT NOT NULL
	, CONSTRAINT FK_Addresses_Countries FOREIGN KEY (CountryId) REFERENCES Countries(Id)
);

--- Table: Vendors
CREATE TABLE Vendors(
	Id INT PRIMARY KEY IDENTITY
	, [Name] NVARCHAR(25) NOT NULL
	, NumberVAT NVARCHAR(15) NOT NULL
	, AddressId INT NOT NULL
	, CONSTRAINT FK_Vendors_Addresses FOREIGN KEY (AddressId) REFERENCES Addresses(Id)
);

--- Table: Clients
CREATE TABLE Clients(
	Id INT PRIMARY KEY IDENTITY
	, [Name] NVARCHAR(25) NOT NULL
	, NumberVAT NVARCHAR(15) NOT NULL
	, AddressId INT NOT NULL
	, CONSTRAINT FK_Clients_Addresses FOREIGN KEY (AddressId) REFERENCES Addresses(Id)
);

--- Table: Categories
CREATE TABLE Categories(
	Id INT PRIMARY KEY IDENTITY
	, [Name] VARCHAR(10) NOT NULL
);

--- Table: Products
CREATE TABLE Products(
	Id INT PRIMARY KEY IDENTITY
	, [Name] NVARCHAR(35) NOT NULL
	, Price DECIMAL(18,2) NOT NULL
	, CategoryId INT NOT NULL
	, VendorId INT NOT NULL
	, CONSTRAINT FK_Products_Categories FOREIGN KEY (CategoryId) REFERENCES Categories(Id)
	, CONSTRAINT FK_Products_Vendors FOREIGN KEY (VendorId) REFERENCES Vendors(Id)
);

--- Table: Invoices
CREATE TABLE Invoices(
	Id INT PRIMARY KEY IDENTITY
	, Number INT NOT NULL
	, IssueDate DATETIME2 NOT NULL
	, DueDate DATETIME2 NOT NULL
	, Amount DECIMAL(18,2) NOT NULL
	, Currency VARCHAR(5) NOT NULL
	, ClientId INT NOT NULL
	, CONSTRAINT FK_Invoices_Clients FOREIGN KEY (ClientId) REFERENCES Clients(Id)
);

--- Table: ProductsClients
CREATE TABLE ProductsClients(
	ProductId INT NOT NULL
	, ClientId INT NOT NULL
	, CONSTRAINT PK_ProductsClients PRIMARY KEY (ProductId, ClientId)
	, CONSTRAINT FK_ProductsClients_Products  FOREIGN KEY (ProductId) REFERENCES Products(Id)
	, CONSTRAINT FK_ProductsClients_Clients  FOREIGN KEY (ClientId) REFERENCES Clients(Id)
);



--- Problem 02: Insert
INSERT INTO Products ([Name], Price, CategoryId, VendorId) VALUES 
('SCANIA Oil Filter XD01', 78.69, 1, 1),
('MAN Air Filter XD01', 97.38, 1, 5),
('DAF Light Bulb 05FG87', 55.00, 2, 13),
('ADR Shoes 47-47.5', 49.85, 3, 5),
('Anti-slip pads S', 5.87, 5, 7)

INSERT INTO Invoices (Number, Amount, IssueDate, DueDate, Currency, ClientId) VALUES
(1219992181, 180.96, '2023-03-01', '2023-04-30', 'BGN', 3),
(1729252340, 158.18, '2022-11-06', '2023-01-04', 'EUR', 13),
(1950101013, 615.15, '2023-02-17', '2023-04-18', 'USD', 19)



--- Problem 03: Update
UPDATE Invoices
SET DueDate = '2023-04-01'
WHERE Year(IssueDate) = 2022 AND Month(IssueDate) = 11

UPDATE Clients
SET AddressId = 3
WHERE [Name] LIKE '%CO%'



--- Problem 04: Delete
DELETE FROM ProductsClients WHERE ClientId = 11
DELETE FROM Invoices WHERE ClientId = 11
DELETE FROM Clients WHERE SUBSTRING(NumberVat, 1, 2) = 'IT'



--- Problem 05: Invoices by Amount and Date
SELECT 
	Number
	,Currency
FROM Invoices
ORDER BY Amount DESC, DueDate ASC



--- Problem 06: Products by Category
SELECT
	p.Id
	,p.[Name]
	,p.Price
	,c.[Name] AS CategoryName
FROM Products AS p
JOIN Categories AS c
ON p.CategoryId=c.Id
WHERE c.[Name]='ADR' OR c.[Name]='Others'
ORDER BY Price DESC



--- Problem 07: Clients without Products
SELECT c.Id
	, c.[Name] AS Client
	, CONCAT(a.StreetName, ' ', a.StreetNumber, ', ', a.City, ', ', a.PostCode, ', ', cc.[Name]) AS [Address]
FROM Clients AS c
LEFT JOIN ProductsClients AS pc ON c.Id = pc.ClientId
JOIN Addresses AS a ON c.AddressId = a.Id
JOIN Countries AS cc ON a.CountryId = cc.Id
WHERE pc.ProductId IS NULL
ORDER BY c.Id



--- Problem 08: First 7 Invoices
SELECT TOP(7)
	i.Number
	, i.Amount
	, c.[Name] AS Client
FROM Invoices AS i
LEFT JOIN Clients AS c ON i.ClientId = c.Id
WHERE i.IssueDate < CONVERT(DATETIME2, '2023-01-01') AND i.Currency = 'EUR'
OR i.Amount > 500 AND SUBSTRING(c.NumberVAT, 1, 2) = 'DE'
ORDER BY i.Number ASC, i.Amount DESC



--- Problem 09: Clients with Name
SELECT
	c.[Name] AS Client
	, MAX(p.Price) AS Price
	, c.NumberVAT AS [VAT Number]
FROM ProductsClients AS pc
JOIN Clients AS c ON pc.ClientId = c.Id
JOIN Products AS p ON pc.ProductId = p.Id
WHERE c.Name NOT LIKE '%KG%'
GROUP BY c.[Name], c.NumberVAT
ORDER BY MAX(p.Price) DESC



--- Problem 10: Clients by Price
SELECT
	c.[Name] AS Client
	,FLOOR(AVG(p.Price)) AS [Average Price]
FROM Clients AS c
JOIN ProductsClients AS pc ON c.Id = pc.ClientId
JOIN Products AS p ON pc.ProductId = p.Id
JOIN Vendors AS v ON p.VendorId = v.Id
WHERE pc.ClientId IS NOT NULL 
AND v.NumberVAT LIKE '%FR%'
GROUP BY c.[Name]
ORDER BY AVG(p.Price) ASC, c.[Name] DESC



--- Problem 11: Products with Clients
CREATE FUNCTION udf_ProductWithClients(@name NVARCHAR(30))
RETURNS INT
AS
BEGIN
	DECLARE @totalProductClient INT = 
	(
		SELECT
			COUNT(pc.ClientId)
		FROM Products AS p
		INNER JOIN ProductsClients AS pc ON p.Id = pc.ProductId
		WHERE p.[Name] = @name
	)
	RETURN @totalProductClient
END



--- Problem 12: Search for Vendors from a Specific Country
CREATE OR ALTER PROC usp_SearchByCountry(@country VARCHAR(10))
AS
	SELECT 
	    v.[Name] AS Vendor
		,v.NumberVAT AS VAT
		, CONCAT(a.StreetName, ' ', a.StreetNumber) AS [Street Info]
		, CONCAT(a.City, ' ', a.PostCode) AS [City Info]
	FROM Vendors AS v
	JOIN Addresses AS a ON v.AddressId = a.Id
	JOIN Countries AS c ON c.Id = a.CountryId
	WHERE c.[Name] = @country
	ORDER BY v.[Name], a.City
