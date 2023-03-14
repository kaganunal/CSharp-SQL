-- 1.SORU Her ürün için ürünler tablosundan Ürün Adý, Kategoriler tablosundan Kategori Adý bilgilerini listeleyiniz...

SELECT ProductName, CategoryName FROM Products

JOIN Categories

ON Products.CategoryID = Categories.CategoryID

-- 2.SORU Hangi sipariþin, hangi çalýþan tarafýndan alýndýðýný, hangi müþteriye gönderileceðini listeleyiniz..

SELECT OrderDate, CompanyName, FirstName, LastName, ContactName FROM Orders
JOIN Employees
ON Orders.EmployeeID = Employees.EmployeeID
JOIN Customers
ON Customers.CustomerID = Orders.CustomerID

-- 3.SORU Products tablosundan TÜM KAYITLARI, Categories tablosundan iliþkili kayýtlarý listeleyelim. (ProductName, CategoryName)

SELECT P.ProductName, C.CategoryName FROM Products P
LEFT JOIN Categories C
ON P.CategoryID=C.CategoryID

SELECT * From Products
SELECT * From Categories
