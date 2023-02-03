CREATE DATABASE SoftUni
GO
USE SOFTUNI
GO

CREATE TABLE Passports
(
PassportID INT PRIMARY KEY  IDENTITY(101,1) ,
PassportNumber NVARCHAR(8) not null
)

CREATE TABLE Persons
(
PersonID INT PRIMARY KEY  IDENTITY,
[FirstName]NVARCHAR(50) not null,
Salary Decimal(8,2) not null,
PassportID INT FOREIGN KEY REFERENCES Passports(PassportID) Unique not null

)

INSERT INTO Passports(PassportNumber)
VALUES ('N34FG21B'),
('K65LO4R7'),
('ZE657QP2')

INSERT INTO Persons(FirstName,Salary,PassportID)
VALUES ('Roberto',43300.00,102),
('Tom',56100.00,103),
('Yana',60200.00,101)

alter table passports
add unique(PassportNumber)


