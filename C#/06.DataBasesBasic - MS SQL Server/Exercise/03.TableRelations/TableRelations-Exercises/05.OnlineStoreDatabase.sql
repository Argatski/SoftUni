CREATE TABLE Cities
(
	CityID INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR (50) NOT NULL,
)

CREATE TABLE Customers
(
	CustomerID INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(50) NOT NULL,
	Birthday DATE NOT NULL,

	CityID INT NOT NULL,
	CONSTRAINT FK_Customers_CityID
	FOREIGN KEY (CityID) REFERENCES Cities(CityID)
)

CREATE TABLE Orders
(
	OrderID INT PRIMARY KEY IDENTITY,
	CustomerID INT NOT NULL,

	CONSTRAINT FK_Orders_CustomerID
	FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)

)

CREATE TABLE ItemTypes
(
	ItemTypeID INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(50),

)

CREATE TABLE Items
(
	ItemID INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(50),
	ItemTypeID INT NOT NULL,

	CONSTRAINT FK_Items_ItemTypeID
	FOREIGN KEY (ItemTypeID) REFERENCES ItemTypes(ItemTypeID)
)

CREATE TABLE OrderItems
(
	OrderID INT NOT NULL,
	ItemID INT NOT NULL,

	CONSTRAINT PK_OrderItemsID
	PRIMARY KEY(OrderID,ItemID),

	CONSTRAINT FK_OrderItems_OrderID
	FOREIGN KEY(OrderID) REFERENCES Orders(OrderID),

	CONSTRAINT FK_OrderItems_ItemID
	FOREIGN KEY (ItemID) REFERENCES Items(ItemID)

)
