CREATE DATABASE Shop;

USE Shop;

CREATE TABLE Products (
	Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ProductName NVARCHAR(100) NOT NULL
);

CREATE TABLE Categories (
	Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	CategoryName NVARCHAR(100) NOT NULL
);

CREATE TABLE ProductCategories (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO Products VALUES ('apple'),
			    ('banana'),
			    ('orange'),
			    ('limon'),
			    ('grape')

INSERT INTO Categories VALUES ('red'),
			      ('green'),
			      ('yellow'),
			      ('purple')

INSERT INTO ProductCategories VALUES (1, 1),
				     (1, 2),
				     (1, 3),
				     (4, 3),
				     (5, 2),
				     (5, 4)

SELECT Products.ProductName, Categories.CategoryName
FROM Products
LEFT JOIN ProductCategories PC
	ON Products.Id = PC.ProductId
LEFT JOIN Categories
	ON PC.CategoryId = Categories.Id;
