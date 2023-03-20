USE Northwind

--�Federal Shipping� ile ta��nm�� ve Nancy'nin alm�� oldu�u sipari�leri g�steriniz.

SELECT * FROM Orders O
WHERE ShipVia = (SELECT ShipperID FROM Shippers WHERE CompanyName = 'Federal Shipping') AND EmployeeID = (SELECT EmployeeID FROM Employees WHERE FirstName = 'Nancy')

--Bat� konumundaki b�lgeleri listeleyiniz.

SELECT * FROM Territories T
JOIN Region R ON R.RegionID = T.RegionID
WHERE R.RegionID = 2

--Adet olarak en az sipari� verilen �r�n�n ad�n� getiriniz

SELECT TOP 1 P.ProductID, P.ProductName, SUM(Quantity) FROM [Order Details] OD 
JOIN Products P ON P.ProductID = OD.ProductID
GROUP BY P.ProductName, P.ProductID
ORDER BY 3 ASC

--Sat��� durdurulmu� ve ayn� zamanda sto�u kalmam�� �r�nlerimin tedarik�ilerinin isimlerini ve telefon numaralar�n� listeleyiniz

SELECT S.ContactName, S.CompanyName, S.Phone FROM Products P
JOIN Suppliers S ON S.SupplierID = P.SupplierID
WHERE Discontinued = 1 AND UnitsInStock = 0

-- 1 Ocak 1998 tarihinden sonra sipari� veren m��terilerimin isimlerini artan olarak s�ralay�n�z.

SELECT C.CompanyName FROM Customers C
JOIN Orders O ON C.CustomerID = O.CustomerID
WHERE OrderDate >= '1998-01-01'
ORDER BY 1 ASC

--Meksikal� m��terilerimden �irket sahibi ile ileti�ime ge�ti�im, kargo �creti 30 dolar�n alt�nda olan sipari�lerle hangi �al��anlar�m ilgilenmi�tir?

SELECT O.OrderID, E.EmployeeID, E.FirstName + ' ' + E.LastName AS FullName FROM Customers C
JOIN Orders O ON O.CustomerID = C.CustomerID
JOIN Employees E ON E.EmployeeID = O.EmployeeID
WHERE Freight < 30 AND C.Country = 'Mexico'  AND C.ContactTitle = 'Owner'

--Personelli Ad ve Soyadlar�n� tek alan olarak birle�tirip soyad�na g�re s�ralay�n.

SELECT E.FirstName + ' ' + E.LastName AS FullName FROM Employees E
ORDER BY E.LastName ASC

--Gelecek y�l 70 ya��n� ge�en personeli do�du�u aya g�re s�ralay�n.

SELECT FirstName, LastName, BirthDate, MONTH(BirthDate), DATEDIFF(YEAR, BirthDate, GETDATE()) AS Age FROM Employees E
WHERE DATEDIFF(YEAR, BirthDate, DATEADD(YEAR, 1, GETDATE())) > 70
ORDER BY 4, Age DESC;

--Tedarik�ilerimden ald���m �r�nlerimden toplam stok miktar� 150 ten fazla olanlar hangi �lkelerden listeleyiniz

SELECT S.Country, SUM(P.UnitsInStock) FROM Products P
JOIN Suppliers S ON S.SupplierID = P.SupplierID
GROUP BY S.Country
HAVING SUM(P.UnitsInStock) > 150
ORDER BY 2 ASC

--Condiments kategorisinde en pahal� 10 �r�n� ProductID, �r�n ad�, tedarik�i ad� �eklinde listelenen bir VIEW olu�turunuz

CREATE VIEW vw_CondimentsMostExpensive AS 
SELECT TOP 10 P.ProductID, P.ProductName, S.CompanyName FROM Products P
JOIN Categories C ON C.CategoryID = P.CategoryID
JOIN Suppliers S ON S.SupplierID = P.SupplierID
WHERE C.CategoryName = 'Condiments'
ORDER BY P.UnitPrice DESC

--Kritik seviyede olan ve gelecek sipari�i olmayan �r�nlerimin tedarik�ilerini, kategorilerini, minimum ne kadar sipari� vermem gerekti�ini listeleyen bir view olu�turunuz VIEW ismi �KritikSeviyeUrunBilgileri�

CREATE VIEW vw_KritikSeviyeUrunBilgileri AS
SELECT S.CompanyName, C.CategoryName, P.ProductID, P.ProductName, P.UnitsInStock, (P.UnitsOnOrder + P.ReorderLevel - P.UnitsInStock) AS MinOrderCount FROM Products P 
JOIN Categories C ON C.CategoryID = P.CategoryID
JOIN Suppliers S ON S.SupplierID = P.SupplierID
WHERE P.Discontinued = 0 AND P.UnitsInStock <= 10 AND (P.ReorderLevel IS NULL OR P.UnitsInStock < P.ReorderLevel)

-- Klavyeden Girilen Shipvia numaras�na g�re 300'den az veya fazla oldu�unu g�steren prosed�r� yaz�n�z. E�er Shipvia de�eri yoksa Hata mesaj� versin
  --Kay�t ��kt�s� �u �ekilde Olacak: 300den fazla kay�t var. Kay�t Say�s�= 330

CREATE PROCEDURE sp_ShipViaCount @shipvia INT
AS
BEGIN
  DECLARE @count INT
  SELECT @count = COUNT(*) FROM Orders WHERE ShipVia = @shipvia
  
  IF @count < 300
    BEGIN
      PRINT '300den az kay�t var. Kay�t say�s� = ' + CAST(@count AS VARCHAR)
    END
  ELSE IF @count > 300
    BEGIN
      PRINT '300den fazla kay�t var. Kay�t say�s� = ' + CAST(@count AS VARCHAR)
    END
  ELSE
    BEGIN
      RAISERROR('Girilen Shipvia numaras�na sahip sipari� yok.', 16, 1)
    END
END

EXEC sp_ShipViaCount @shipvia = 3

--G�nl�k olarak rapor almak istiyorum. Girdi�im kategoriye g�re �r�n ad� ve stok miktar�n� getiren bir PROCEDURE olu�turunuz.

CREATE PROCEDURE sp_DailyProductAndCategoryReport @categoryChoice INT AS

SELECT P.ProductName, P.UnitsInStock FROM Products P
JOIN Categories C ON C.CategoryID = P.CategoryID
WHERE C.CategoryID =  @categoryChoice

EXEC sp_DailyProductAndCategoryReport @categoryChoice = 4



  --Girilen iki tarih aras�ndaki g�nler i�in toplam ciromu veren bir FUNCTION olu�turunuz.

CREATE FUNCTION fn_TotalEndorsement (@IlkTarih DATE, @SonTarih DATE)
RETURNS DECIMAL(10,2)

BEGIN 
	DECLARE @totalEndorsement DECIMAL(10,2)
	SELECT @totalEndorsement = SUM(OD.Quantity * OD.UnitPrice * (1- Discount)) FROM [Order Details] OD
	JOIN Orders O On O.OrderID = OD.OrderID
	WHERE O.OrderDate BETWEEN @IlkTarih AND @SonTarih
RETURN @totalEndorsement
END

	
