-- 2.SORU Çalýþanlarýmýn yapmýþ olduklarý sipariþ sayýsýna göre gruplandýrarak azalan sýrada sýralayýnýz.

SELECT * FROM Employees

SELECT COUNT(OrderID) AS SiparisSayisi, EmployeeID FROM Orders
GROUP BY EmployeeID
ORDER BY SiparisSayisi DESC


-- 3.SORU Hangi kategoride kaç ürün var, gruplandýrarak azalan sýrada sýralayýnýz...

SELECT * FROM Categories
SELECT * FROM Products

SELECT COUNT(*) AS UrunSayisi, CategoryID FROM Products
GROUP BY CategoryID
ORDER BY UrunSayisi DESC

--4.SORU Her bir sipariþteki toplam ürün sayýsýný gruplandýrarak artan sýrada sýralayýnýz...

SELECT * FROM Orders
SELECT * FROM [Order Details]

SELECT SUM(Quantity) AS ToplamUrunSayisi, OrderID FROM [Order Details]
GROUP BY OrderID
ORDER BY 1 ASC

--5.SORU Birim fiyatý ortalamanýn üzerinde olan ürünleri listeleyelim.

SELECT * FROM Products
SELECT UnitPrice, ProductName  FROM Products
WHERE UnitPrice > (SELECT AVG(UnitPrice) FROM Products)
ORDER BY UnitPrice ASC 

--6.SORU Maksimum fiyata sahip olan ürünün adý ve birim fiyatýný getiriniz.

SELECT TOP 1 ProductName, UnitPrice FROM Products
ORDER BY UnitPrice DESC

SELECT ProductName, UnitPrice FROM Products
WHERE UnitPrice = (SELECT MAX(UnitPrice) FROM Products)

--7.SORU Ürünler tablosundaki ürünlerden SATILAN ürünleri listeleyiniz... 

SELECT * FROM Products
WHERE UnitsOnOrder > 0

--8.SORU Ürünler tablosundaki ürünlerden SATILMAYAN ürünleri listeleyiniz...

SELECT * FROM Products
WHERE UnitsOnOrder = 0

--9.SORU Ürünler tablosundaki her bir ürünü, ürün adý, birim fiyatý, stok miktarý ve ürünün kategori adý bilgisiyle listeleyiniz...

SELECT ProductName, UnitPrice, UnitsInStock, (SELECT CategoryName FROM Categories WHERE Products.ProductID = Categories.CategoryID) AS CategoryName FROM Products


