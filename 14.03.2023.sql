USE Northwind

--1- Customers tablosundan CustomerID’sinin 2. harfi A, 4. harfi T olanlarýn %15 lik kýsmýný getiren sorguyu yazýnýz.

SELECT TOP 15 PERCENT * FROM Customers C
WHERE C.CustomerID LIKE '_A_T%'

--2. En çok ürün alan müþteri

SELECT TOP 1 C.CustomerID ,SUM(Quantity)  FROM [Order Details] OD
JOIN Orders O ON OD.OrderID = O.OrderID
JOIN Customers C ON C.CustomerID = O.CustomerID
GROUP BY C.CustomerID
ORDER BY 2 DESC

SELECT * FROM Orders
SELECT * FROM [Order Details]
SELECT * FROM Customers
SELECT * FROM Employees


--3. En yüksek ücreti ödeyen müþteri

SELECT TOP 1 C.CustomerID ,SUM(Quantity * UnitPrice * (1-Discount)),  COUNT(DISTINCT OD.OrderID) FROM [Order Details] OD
JOIN Orders O ON OD.OrderID = O.OrderID
JOIN Customers C ON C.CustomerID = O.CustomerID
GROUP BY C.CustomerID
ORDER BY 2 DESC

--4. En çok ürün satan ilk 5 çalýþan

SELECT TOP 5 E.EmployeeID, SUM(Quantity) AS TotalSoldProducts FROM Employees E

JOIN Orders O ON O.EmployeeID = E.EmployeeID
JOIN [Order Details] OD ON OD.OrderID = O.OrderID

GROUP BY E.EmployeeID
ORDER BY 2 DESC

--5. Fransýzca konuþabilen çalýþaným hangisi ?

SELECT E.EmployeeID, E.FirstName, E.LastName, Notes FROM Employees E
WHERE E.Notes LIKE '%French%'

-- 6.SORU vw_SiparisRaporlari adý altýnda view oluþturulacak
-- Bir sipariþin, hangi çalýþan tarafýndan, hangi müþteriye, hangi kategorideki üründen, hangi fiyattan, kaç adet satýldýðýný lisleteliyiniz... 
-- Yukarýdaki sorgu için; (Orders orta tablo gibi düþünülebilir, ilgili ID'leri eþleþtirmek için)
-- Çalýþanýn: FirstName, LastName, TitleOfCourtesy, Title kolonlarý
-- Müþterinin: CompanyName, ContactName, Phone,
-- Ürünün: ProductName, UnitsInStock,
-- Kategorinin: CategoryName kolonlarý,
-- Sipariþ Detayýnýn: UnitPrice, Quantity kolonlarý,
-- tek bir sorguda yazýlacak.
-- bu view üzerinden sorgularýmýz ekrana yazdýrýlabilecek

CREATE VIEW vw_SiparisRaporlari AS
SELECT E.FirstName, E.LastName, E.TitleOfCourtesy, E.Title, C.CompanyName, C.ContactName, C.Phone, P.ProductName, P.UnitsInStock, CA.CategoryName, OD.UnitPrice, OD.Quantity FROM [Order Details] OD
JOIN Orders O ON O.OrderID = OD.OrderID
JOIN Employees E ON E.EmployeeID = O.EmployeeID
JOIN Customers C ON C.CustomerID = O.CustomerID
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Categories CA ON CA.CategoryID = P.CategoryID


SELECT * FROM  vw_SiparisRaporlari

--v2 Bu view a HireDate kolonunu ekleyelim

ALTER VIEW vw_SiparisRaporlari AS
SELECT E.FirstName, E.LastName, E.TitleOfCourtesy, E.Title, C.CompanyName, C.ContactName, C.Phone, P.ProductName, P.UnitsInStock, CA.CategoryName, OD.UnitPrice, OD.Quantity, E.HireDate FROM [Order Details] OD
JOIN Orders O ON O.OrderID = OD.OrderID
JOIN Employees E ON E.EmployeeID = O.EmployeeID
JOIN Customers C ON C.CustomerID = O.CustomerID
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Categories CA ON CA.CategoryID = P.CategoryID

--v3 Bu viewi droplayalým

DROP VIEW vw_SiparisRaporlari

-- 7.SORU @fiyat adýnda bir function tanýmlayalým bu function taþýma ücretlerine Yüzde 18 lik kdv uygulasýn

ALTER FUNCTION Fun_KDVEkle (@fiyat MONEY, @CategoryID int)
RETURNS money AS
	BEGIN
		DECLARE @kdvliFiyat MONEY;
		IF @CategoryID = 1
			BEGIN
				SET @kdvliFiyat += (@fiyat * 0.08)
			END
		ELSE
			BEGIN
				SET @kdvliFiyat = (@fiyat*(1.18))
			END
		RETURN @kdvliFiyat
	END;

SELECT CAST(O.Freight AS decimal(10,4)) AS KDVsizFiyat, dbo.Fun_KDVEkle(O.Freight) AS 'KDV''li Fiyat' FROM Orders O

-- 8.SORU oluþturdðumuz bu function ile ProductName, CategoryName, UnitPrice, ve UnitPrice*functionýmýz

SELECT P.ProductName, C.CategoryName, P.UnitPrice, (dbo.Fun_KDVEkle(P.UnitPrice)) AS 'KDV''li Fiyat' FROM Products P

JOIN Categories C ON C.CategoryID = P.CategoryID
JOIN [Order Details] OD ON OD.ProductID = P.ProductID

-- Sadece Beverages kategorisinde ürünlerin KDV oraný %8 olsun, diðer kategorilerdeki ürünlerin KDV oraný %18 olsun. ProductNmae, CategoryName, UnitPrice, KDVLi Fiyat tablolarý oluþturulcak

SELECT P.ProductName, C.CategoryName, OD.UnitPrice, (dbo.Fun_KDVEkle(OD.UnitPrice, C.CategoryID)) AS 'KDV''li Fiyat' 	FROM Products P
JOIN Categories C ON C.CategoryID = P.CategoryID
JOIN [Order Details] OD ON OD.ProductID = P.ProductID







