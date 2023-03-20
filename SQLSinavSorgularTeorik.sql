USE Northwind

--“Federal Shipping” ile taþýnmýþ ve Nancy'nin almýþ olduðu sipariþleri gösteriniz.

SELECT * FROM Orders O
WHERE ShipVia = (SELECT ShipperID FROM Shippers WHERE CompanyName = 'Federal Shipping') AND EmployeeID = (SELECT EmployeeID FROM Employees WHERE FirstName = 'Nancy')

--Batý konumundaki bölgeleri listeleyiniz.

SELECT * FROM Territories T
JOIN Region R ON R.RegionID = T.RegionID
WHERE R.RegionID = 2

--Adet olarak en az sipariþ verilen ürünün adýný getiriniz

SELECT TOP 1 P.ProductID, P.ProductName, SUM(Quantity) FROM [Order Details] OD 
JOIN Products P ON P.ProductID = OD.ProductID
GROUP BY P.ProductName, P.ProductID
ORDER BY 3 ASC

--Satýþý durdurulmuþ ve ayný zamanda stoðu kalmamýþ ürünlerimin tedarikçilerinin isimlerini ve telefon numaralarýný listeleyiniz

SELECT S.ContactName, S.CompanyName, S.Phone FROM Products P
JOIN Suppliers S ON S.SupplierID = P.SupplierID
WHERE Discontinued = 1 AND UnitsInStock = 0

-- 1 Ocak 1998 tarihinden sonra sipariþ veren müþterilerimin isimlerini artan olarak sýralayýnýz.

SELECT C.CompanyName FROM Customers C
JOIN Orders O ON C.CustomerID = O.CustomerID
WHERE OrderDate >= '1998-01-01'
ORDER BY 1 ASC

--Meksikalý müþterilerimden þirket sahibi ile iletiþime geçtiðim, kargo ücreti 30 dolarýn altýnda olan sipariþlerle hangi çalýþanlarým ilgilenmiþtir?

SELECT O.OrderID, E.EmployeeID, E.FirstName + ' ' + E.LastName AS FullName FROM Customers C
JOIN Orders O ON O.CustomerID = C.CustomerID
JOIN Employees E ON E.EmployeeID = O.EmployeeID
WHERE Freight < 30 AND C.Country = 'Mexico'  AND C.ContactTitle = 'Owner'

--Personelli Ad ve Soyadlarýný tek alan olarak birleþtirip soyadýna göre sýralayýn.

SELECT E.FirstName + ' ' + E.LastName AS FullName FROM Employees E
ORDER BY E.LastName ASC

--Gelecek yýl 70 yaþýný geçen personeli doðduðu aya göre sýralayýn.

SELECT FirstName, LastName, BirthDate, MONTH(BirthDate), DATEDIFF(YEAR, BirthDate, GETDATE()) AS Age FROM Employees E
WHERE DATEDIFF(YEAR, BirthDate, DATEADD(YEAR, 1, GETDATE())) > 70
ORDER BY 4, Age DESC;

--Tedarikçilerimden aldýðým ürünlerimden toplam stok miktarý 150 ten fazla olanlar hangi ülkelerden listeleyiniz

SELECT S.Country, SUM(P.UnitsInStock) FROM Products P
JOIN Suppliers S ON S.SupplierID = P.SupplierID
GROUP BY S.Country
HAVING SUM(P.UnitsInStock) > 150
ORDER BY 2 ASC

--Condiments kategorisinde en pahalý 10 ürünü ProductID, ürün adý, tedarikçi adý þeklinde listelenen bir VIEW oluþturunuz

CREATE VIEW vw_CondimentsMostExpensive AS 
SELECT TOP 10 P.ProductID, P.ProductName, S.CompanyName FROM Products P
JOIN Categories C ON C.CategoryID = P.CategoryID
JOIN Suppliers S ON S.SupplierID = P.SupplierID
WHERE C.CategoryName = 'Condiments'
ORDER BY P.UnitPrice DESC

--Kritik seviyede olan ve gelecek sipariþi olmayan ürünlerimin tedarikçilerini, kategorilerini, minimum ne kadar sipariþ vermem gerektiðini listeleyen bir view oluþturunuz VIEW ismi “KritikSeviyeUrunBilgileri”

CREATE VIEW vw_KritikSeviyeUrunBilgileri AS
SELECT S.CompanyName, C.CategoryName, P.ProductID, P.ProductName, P.UnitsInStock, (P.UnitsOnOrder + P.ReorderLevel - P.UnitsInStock) AS MinOrderCount FROM Products P 
JOIN Categories C ON C.CategoryID = P.CategoryID
JOIN Suppliers S ON S.SupplierID = P.SupplierID
WHERE P.Discontinued = 0 AND P.UnitsInStock <= 10 AND (P.ReorderLevel IS NULL OR P.UnitsInStock < P.ReorderLevel)

-- Klavyeden Girilen Shipvia numarasýna göre 300'den az veya fazla olduðunu gösteren prosedürü yazýnýz. Eðer Shipvia deðeri yoksa Hata mesajý versin
  --Kayýt Çýktýsý Þu Þekilde Olacak: 300den fazla kayýt var. Kayýt Sayýsý= 330

CREATE PROCEDURE sp_ShipViaCount @shipvia INT
AS
BEGIN
  DECLARE @count INT
  SELECT @count = COUNT(*) FROM Orders WHERE ShipVia = @shipvia
  
  IF @count < 300
    BEGIN
      PRINT '300den az kayýt var. Kayýt sayýsý = ' + CAST(@count AS VARCHAR)
    END
  ELSE IF @count > 300
    BEGIN
      PRINT '300den fazla kayýt var. Kayýt sayýsý = ' + CAST(@count AS VARCHAR)
    END
  ELSE
    BEGIN
      RAISERROR('Girilen Shipvia numarasýna sahip sipariþ yok.', 16, 1)
    END
END

EXEC sp_ShipViaCount @shipvia = 3

--Günlük olarak rapor almak istiyorum. Girdiðim kategoriye göre ürün adý ve stok miktarýný getiren bir PROCEDURE oluþturunuz.

CREATE PROCEDURE sp_DailyProductAndCategoryReport @categoryChoice INT AS

SELECT P.ProductName, P.UnitsInStock FROM Products P
JOIN Categories C ON C.CategoryID = P.CategoryID
WHERE C.CategoryID =  @categoryChoice

EXEC sp_DailyProductAndCategoryReport @categoryChoice = 4



  --Girilen iki tarih arasýndaki günler için toplam ciromu veren bir FUNCTION oluþturunuz.

CREATE FUNCTION fn_TotalEndorsement (@IlkTarih DATE, @SonTarih DATE)
RETURNS DECIMAL(10,2)

BEGIN 
	DECLARE @totalEndorsement DECIMAL(10,2)
	SELECT @totalEndorsement = SUM(OD.Quantity * OD.UnitPrice * (1- Discount)) FROM [Order Details] OD
	JOIN Orders O On O.OrderID = OD.OrderID
	WHERE O.OrderDate BETWEEN @IlkTarih AND @SonTarih
RETURN @totalEndorsement
END

	
