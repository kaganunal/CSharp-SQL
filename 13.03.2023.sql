-- 1.SORU Toplam tutar� 2500 ile 3500 aras�nda olan sipari�leri listeleyelim.
USE Northwind
SELECT CAST(SUM((Quantity * UnitPrice * (1 - Discount))) AS decimal(7,2)) AS 'Toplam Tutar', OrderID FROM [Order Details]
GROUP BY OrderID
HAVING SUM(Quantity * UnitPrice * (1 - Discount)) >= 2500 AND SUM(Quantity * UnitPrice * (1 - Discount)) <= 3500
ORDER BY OrderID DESC

-- 2.SORU Ayn� �rne�i sorguda filtre �art� olarak sipari� kodu 10500 ile 11000 olan �r�nleri getirelim

--DECLARE @ToplamTutar = SUM((Quantity * UnitPrice * (1 - Discount)) 

SELECT OrderID, CAST(SUM((Quantity * UnitPrice * (1 - Discount)))  AS decimal(7,2)) AS 'Toplam Tutar' FROM [Order Details]
GROUP BY OrderID
HAVING OrderID >= 10500 AND OrderID <= 11000 AND SUM(Quantity * UnitPrice * (1 - Discount)) >= 2500 AND SUM(Quantity * UnitPrice * (1 - Discount)) <= 3500
ORDER BY 1 DESC

-- 3.SORU Her bir sipari�teki toplam �r�n say�s� 220'den fazla olan sipari�leri grupland�rarak, adet bilgisi artan s�rada s�ralay�n�z.

SELECT * FROM [Order Details]

SELECT OrderID, SUM(Quantity) AS 'Toplam �r�n' FROM [Order Details]
GROUP BY OrderID
HAVING SUM(Quantity) > 220
ORDER BY SUM(Quantity) ASC


--4- En �ok �al��t���m�z kargo firmas� ile en �ok g�nderdi�imiz �r�n

SELECT * FROM [Order Details] 
SELECT * FROM Orders
SELECT * FROM Customers

SELECT TOP 1 S.ShipperID, S.CompanyName, ProductName, SUM(Quantity)  AS ToplamUrun  FROM [Order Details] OD
JOIN Products P 
ON  P.ProductID = OD.ProductID
JOIN Orders O 
ON  OD.OrderID = O.[OrderID] 
JOIN Shippers S 
ON  O.ShipVia = S.ShipperID

GROUP BY O.OrderID, S.CompanyName, P.ProductName, S.ShipperID
ORDER BY 4 DESC

--5- B�lgelere G�re en �ok hangi nakliye firmas� ile �al��t�k

SELECT * FROM [Order Details] 
SELECT * FROM Orders
SELECT * FROM Customers
SELECT * FROM Shippers
SELECT * FROM Region

SELECT S.CompanyName, COUNT(*), R.RegionDescription  FROM Region R

JOIN Territories T ON R.RegionID = T.RegionID
JOIN EmployeeTerritories ET ON ET.TerritoryID =  T.TerritoryID
JOIN Employees E ON E.EmployeeID = ET.EmployeeID
JOIN Orders O ON O.EmployeeID = E.EmployeeID
JOIN Shippers S On S.ShipperID = O.ShipVia

GROUP BY RegionDescription , S.CompanyName
ORDER BY 2 DESC

--6- Hangi kargo �irketine toplam ne kadar �deme yapm���m?

SELECT S.CompanyName, SUM(Freight) AS TotalPayment FROM Orders O

JOIN Shippers S ON S.ShipperID = O.ShipVia

GROUP BY S.CompanyName
ORDER BY 2 DESC

--7- En de�erli m��terim hangisi?

SELECT SUM(Quantity * UnitPrice * (1 - Discount)) AS TotalPayment, C.CustomerID, C.ContactName, C.CompanyName  FROM Orders O

JOIN Customers C ON C.CustomerID = O.CustomerID
JOIN [Order Details] OD ON OD.OrderID =O.OrderID

GROUP BY C.CustomerID, C.ContactName, C.CompanyName
ORDER BY 1 DESC

--8 Zaman�nda teslim edemedi�im sipari�lerim ID�leri  nelerdir ve ka� g�n ge� g�ndermi�im?

SELECT  DATEDIFF(DAY,RequiredDate, ShippedDate) AS DelayedDays, O.OrderID, O.RequiredDate, O.ShippedDate FROM Orders O
WHERE ShippedDate > RequiredDate 
ORDER BY 1 DESC

--9- Sat��lar�m� ka� g�nde teslim etmi�im?

SELECT DATEDIFF(DAY,OrderDate, ShippedDate) AS DayDifference, O.OrderID, O.RequiredDate, O.ShippedDate FROM Orders O

ORDER BY 1 DESC















