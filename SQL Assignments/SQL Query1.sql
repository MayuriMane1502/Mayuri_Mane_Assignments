CREATE DATABASE mydatabase;
use mydatabase;

CREATE TABLE customer(
id INT PRIMARY KEY, FirstName VARCHAR(40) NOT NULL,
LastName VARCHAR(40),
City VARCHAR(40),
Country VARCHAR(40),
Phone INT(20));

CREATE TABLE Order1(
id INT PRIMARY KEY, OrderDate DATETIME NOT NULL,
OrderNumber INT(10),
Customerid INT FOREIGN KEY REFERENCES Customer(id),
TotalAmount DECIMAL(12,2));

ALTER TABLE Order1
DROP COLUMN OrderDate;

ALTER TABLE Order1
Add OrderDate DateTime NOT NULL;

CREATE TABLE Product(
id INT PRIMARY KEY, ProductName VARCHAR(50),
UnitPrice DECIMAL(12,2),
Package VARCHAR(30),
IsDiscontinued BIT);

CREATE TABLE OrderTime(
id INT PRIMARY KEY, OrderId INT FOREIGN KEY REFERNCES Order1(id),
ProductId INT FOREIGN KEY REFERNCES Product(id),
UnitPrice DECIMAL(12,2),
Quantity INT);
