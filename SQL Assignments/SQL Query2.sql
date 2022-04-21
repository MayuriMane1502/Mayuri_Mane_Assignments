INSERT INTO Customer(id, FirstName, LastName, City, Country, Phone)
VALUES(123, 'Mayuri', 'Mane','Kolhapur','India',123456789),
(124,'Manali','Patil','Rajarampuri','India',987655555),
(125,'Poonam', 'Chougle','Shahupuri','India',1111233345),
(126,'Tushar','Sankpal','Fulewadi',2222333344),
(127,'Sumedh','Patil','Bawada','India',7788559900);

SELECT * FROM Customer;

INSERT INTO Order1(id, OrderDate, OrderNumber, CustomerId, TotalAmount)
VALUES(121,09/03/2022,2,123,210),(122,09/04/2022,3,124,250),(123,09/05/2022,4,125,225),
(124,09/06/2022,5,126,275),(125,09/07/2022,6,127,510);

SELECT * FROM Order1;

INSERT INTO Product(id,ProductName, UnitPrice, Package, IsDiscontinued)
VALUES (101,'Pro1',48,'yes',0),(102,'Pro2',49,'yes',1),(103,'Pro3',50,'yes',0),
(104,'Pro4',48,'yes',1),(105,'Pro5',49,'No',1);

SELECT *FROM Product;

INSERT INTO OrderItem(id, OrderId,ProductId,UnitPrice,Quantity)
VALUES(1,121,101,48,2),(2,122,102,49,2),(3,123,103,50,2),(4,124,104,48,2),(5,125,105,49,2);

SELECT * FROM OrderItem;