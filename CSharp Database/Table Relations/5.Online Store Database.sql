CREATE DATABASE [Online Store]
go
USE [Online Store]
go
CREATE TABLE Cities
(
	CityID INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(85) NOT NULL
)
go
CREATE TABLE Customers
(
	CustomerID INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(50) NOT NULL,
	Birthday DATE,
	CityID INT REFERENCES Cities(CityID)
)
go
CREATE TABLE Orders
(
	OrderID INT PRIMARY KEY IDENTITY,
	CustomerID INT REFERENCES Customers(CustomerID)
)
go
CREATE TABLE ItemTypes
(
	ItemTypeID INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(50) NOT NULL
)
go
CREATE TABLE Items
(
	ItemID INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(100) NOT NULL,
	ItemTypeID INT REFERENCES ItemTypes(ItemTypeID)
)
go
CREATE TABLE OrderItems
(
	OrderID INT REFERENCES Orders(OrderID),
	ItemID INT REFERENCES Items(ItemID)
	CONSTRAINT PK_Order_Items PRIMARY KEY (OrderID, ItemID)
)