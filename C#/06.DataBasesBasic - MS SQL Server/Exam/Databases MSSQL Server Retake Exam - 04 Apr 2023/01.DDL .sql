/*Section 1. DDL (30 pts)*/
CREATE DATABASE Accounting
USE Accounting

/*Create Countries Table*/
CREATE TABLE Countries
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR (10) NOT NULL
)

/*Create Addresses Table*/
CREATE  TABLE Addresses
(
	Id INT PRIMARY KEY IDENTITY
	,StreetName NVARCHAR(20) NOT NULL
	,StreetNumber INT
	,PostCode INT NOT NULL
	,City NVARCHAR(25) NOT NULL
	,CountryId INT NOT NULL CONSTRAINT FK_Addresses_Countries FOREIGN KEY(CountryId) REFERENCES Countries(Id)
)

/*Create Vendors Table*/
CREATE TABLE Vendors
(
	Id INT PRIMARY KEY IDENTITY
	,[Name] NVARCHAR(25) NOT NULL
	,NumberVAT NVARCHAR(15) NOT NULL
	,AddressId INT NOT NULL 
	CONSTRAINT FK_Vendors_Addresses FOREIGN KEY (AddressId) REFERENCES Addresses(Id)
)

/*Create Clients Table*/
CREATE TABLE Clients
(
	Id INT PRIMARY KEY IDENTITY
	,[Name] NVARCHAR(25)
	,NumberVAT NVARCHAR (15)
	,AddressId INT NOT NULL
	CONSTRAINT FK_Clients_Addresses FOREIGN KEY (AddressId) REFERENCES Addresses(Id)
)

/*Create Categories Table*/
CREATE TABLE Categories
(
	Id INT PRIMARY KEY IDENTITY
	,[Name] NVARCHAR (10) NOT NULL
)

/*Create Products Table*/
CREATE TABLE Products
(
	Id INT PRIMARY KEY IDENTITY
	,[Name] NVARCHAR(35) NOT NULL
	,Price DECIMAL(18,2) NOT NULL
	,CategoryId INT NOT NULL
	CONSTRAINT FK_Products_Categories FOREIGN KEY (CategoryId) REFERENCES Categories(Id)
	,VendorId INT NOT NULL
	CONSTRAINT FK_Products_Vendors FOREIGN KEY (VendorId) REFERENCES Vendors(Id)
)

/*Create Invoices Table*/
CREATE TABLE Invoices
(
	Id INT PRIMARY KEY IDENTITY
	,Number INT NOT NULL
	,IssueDate DATETIME2 NOT NULL
	,DueDate DATETIME2 NOT NULL
	,Amount DECIMAL(18,2) NOT NULL
	,Currency NVARCHAR(5) NOT NULL
	,ClientId INT NOT NULL
	CONSTRAINT FK_Invoices_Clients FOREIGN KEY (ClientId) REFERENCES Clients(Id)
)

/*Create ProductsClients Table*/
CREATE TABLE ProductsClients
(
	ProductId INT NOT NULL
	,ClientId INT NOT NULL
	,CONSTRAINT PK_ProductsClients PRIMARY KEY (ProductId,ClientId)
	,CONSTRAINT FK_ProductsClients_Products FOREIGN KEY (ProductId) REFERENCES Products(Id)
	,CONSTRAINT FK_ProductsClients_Clients FOREIGN KEY (ClientId) REFERENCES Clients(Id)
)