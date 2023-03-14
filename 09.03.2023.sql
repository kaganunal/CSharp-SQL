-- 2.SORU �al��anlar�m�n yapm�� olduklar� sipari� say�s�na g�re grupland�rarak azalan s�rada s�ralay�n�z.

SELECT * FROM Employees

SELECT COUNT(OrderID) AS SiparisSayisi, EmployeeID FROM Orders
GROUP BY EmployeeID
ORDER BY SiparisSayisi DESC


-- 3.SORU Hangi kategoride ka� �r�n var, grupland�rarak azalan s�rada s�ralay�n�z...

SELECT * FROM Categories
SELECT * FROM Products

SELECT COUNT(*) AS UrunSayisi, CategoryID FROM Products
GROUP BY CategoryID
ORDER BY UrunSayisi DESC

--4.SORU Her bir sipari�teki toplam �r�n say�s�n� grupland�rarak artan s�rada s�ralay�n�z...

SELECT * FROM Orders
SELECT * FROM [Order Details]

SELECT SUM(Quantity) AS ToplamUrunSayisi, OrderID FROM [Order Details]
GROUP BY OrderID
ORDER BY 1 ASC

--5.SORU Birim fiyat� ortalaman�n �zerinde olan �r�nleri listeleyelim.

SELECT * FROM Products
SELECT UnitPrice, ProductName  FROM Products
WHERE UnitPrice > (SELECT AVG(UnitPrice) FROM Products)
ORDER BY UnitPrice ASC 

--6.SORU Maksimum fiyata sahip olan �r�n�n ad� ve birim fiyat�n� getiriniz.

SELECT TOP 1 ProductName, UnitPrice FROM Products
ORDER BY UnitPrice DESC

SELECT ProductName, UnitPrice FROM Products
WHERE UnitPrice = (SELECT MAX(UnitPrice) FROM Products)

--7.SORU �r�nler tablosundaki �r�nlerden SATILAN �r�nleri listeleyiniz... 

SELECT * FROM Products
WHERE UnitsOnOrder > 0

--8.SORU �r�nler tablosundaki �r�nlerden SATILMAYAN �r�nleri listeleyiniz...

SELECT * FROM Products
WHERE UnitsOnOrder = 0

--9.SORU �r�nler tablosundaki her bir �r�n�, �r�n ad�, birim fiyat�, stok miktar� ve �r�n�n kategori ad� bilgisiyle listeleyiniz...

SELECT ProductName, UnitPrice, UnitsInStock, (SELECT CategoryName FROM Categories WHERE Products.ProductID = Categories.CategoryID) AS CategoryName FROM Products


