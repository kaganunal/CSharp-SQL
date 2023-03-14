USE Northwind

--1- Customers tablosundan CustomerID�sinin 2. harfi A, 4. harfi T olanlar�n %15 lik k�sm�n� getiren sorguyu yaz�n�z.

SELECT TOP 15 PERCENT * FROM Customers C
WHERE C.CustomerID LIKE '_A_T%'

--2. En �ok �r�n alan m��teri

SELECT TOP 1 C.CustomerID ,SUM(Quantity)  FROM [Order Details] OD
JOIN Orders O ON OD.OrderID = O.OrderID
JOIN Customers C ON C.CustomerID = O.CustomerID
GROUP BY C.CustomerID
ORDER BY 2 DESC

SELECT * FROM Orders
SELECT * FROM [Order Details]
SELECT * FROM Customers
SELECT * FROM Employees


--3. En y�ksek �creti �deyen m��teri

SELECT TOP 1 C.CustomerID ,SUM(Quantity * UnitPrice * (1-Discount)),  COUNT(DISTINCT OD.OrderID) FROM [Order Details] OD
JOIN Orders O ON OD.OrderID = O.OrderID
JOIN Customers C ON C.CustomerID = O.CustomerID
GROUP BY C.CustomerID
ORDER BY 2 DESC

--4. En �ok �r�n satan ilk 5 �al��an

SELECT TOP 5 E.EmployeeID, SUM(Quantity) AS TotalSoldProducts FROM Employees E

JOIN Orders O ON O.EmployeeID = E.EmployeeID
JOIN [Order Details] OD ON OD.OrderID = O.OrderID

GROUP BY E.EmployeeID
ORDER BY 2 DESC

--5. Frans�zca konu�abilen �al��an�m hangisi ?

SELECT E.EmployeeID, E.FirstName, E.LastName, Notes FROM Employees E
WHERE E.Notes LIKE '%French%'

-- 6.SORU vw_SiparisRaporlari ad� alt�nda view olu�turulacak
-- Bir sipari�in, hangi �al��an taraf�ndan, hangi m��teriye, hangi kategorideki �r�nden, hangi fiyattan, ka� adet sat�ld���n� lisleteliyiniz...�
-- Yukar�daki sorgu i�in; (Orders orta tablo gibi d���n�lebilir, ilgili ID'leri e�le�tirmek i�in)
-- �al��an�n: FirstName, LastName, TitleOfCourtesy, Title kolonlar�
-- M��terinin: CompanyName, ContactName, Phone,
-- �r�n�n: ProductName, UnitsInStock,
-- Kategorinin: CategoryName kolonlar�,
-- Sipari� Detay�n�n: UnitPrice, Quantity kolonlar�,
-- tek bir sorguda yaz�lacak.
-- bu view �zerinden sorgular�m�z ekrana yazd�r�labilecek

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

--v3 Bu viewi droplayal�m

DROP VIEW vw_SiparisRaporlari

-- 7.SORU @fiyat ad�nda bir function tan�mlayal�m bu function ta��ma �cretlerine Y�zde 18 lik kdv uygulas�n

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

-- 8.SORU olu�turd�umuz bu function ile ProductName, CategoryName, UnitPrice, ve UnitPrice*function�m�z

SELECT P.ProductName, C.CategoryName, P.UnitPrice, (dbo.Fun_KDVEkle(P.UnitPrice)) AS 'KDV''li Fiyat' FROM Products P

JOIN Categories C ON C.CategoryID = P.CategoryID
JOIN [Order Details] OD ON OD.ProductID = P.ProductID

-- Sadece Beverages kategorisinde �r�nlerin KDV oran� %8 olsun, di�er kategorilerdeki �r�nlerin KDV oran� %18 olsun. ProductNmae, CategoryName, UnitPrice, KDVLi Fiyat tablolar� olu�turulcak

SELECT P.ProductName, C.CategoryName, OD.UnitPrice, (dbo.Fun_KDVEkle(OD.UnitPrice, C.CategoryID)) AS 'KDV''li Fiyat' 	FROM Products P
JOIN Categories C ON C.CategoryID = P.CategoryID
JOIN [Order Details] OD ON OD.ProductID = P.ProductID







