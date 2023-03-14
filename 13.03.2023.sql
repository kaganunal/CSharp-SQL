-- 1.SORU Toplam tutarý 2500 ile 3500 arasýnda olan sipariþleri listeleyelim.
USE Northwind
SELECT CAST(SUM((Quantity * UnitPrice * (1 - Discount))) AS decimal(7,2)) AS 'Toplam Tutar', OrderID FROM [Order Details]
GROUP BY OrderID
HAVING SUM(Quantity * UnitPrice * (1 - Discount)) >= 2500 AND SUM(Quantity * UnitPrice * (1 - Discount)) <= 3500
ORDER BY OrderID DESC

-- 2.SORU Ayný örneði sorguda filtre þartý olarak sipariþ kodu 10500 ile 11000 olan ürünleri getirelim

--DECLARE @ToplamTutar = SUM((Quantity * UnitPrice * (1 - Discount)) 

SELECT OrderID, CAST(SUM((Quantity * UnitPrice * (1 - Discount)))  AS decimal(7,2)) AS 'Toplam Tutar' FROM [Order Details]
GROUP BY OrderID
HAVING OrderID >= 10500 AND OrderID <= 11000 AND SUM(Quantity * UnitPrice * (1 - Discount)) >= 2500 AND SUM(Quantity * UnitPrice * (1 - Discount)) <= 3500
ORDER BY 1 DESC

-- 3.SORU Her bir sipariþteki toplam ürün sayýsý 220'den fazla olan sipariþleri gruplandýrarak, adet bilgisi artan sýrada sýralayýnýz.

SELECT * FROM [Order Details]

SELECT OrderID, SUM(Quantity) AS 'Toplam Ürün' FROM [Order Details]
GROUP BY OrderID
HAVING SUM(Quantity) > 220
ORDER BY SUM(Quantity) ASC


--4- En çok çalýþtýðýmýz kargo firmasý ile en çok gönderdiðimiz ürün

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

--5- Bölgelere Göre en çok hangi nakliye firmasý ile çalýþtýk

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

--6- Hangi kargo þirketine toplam ne kadar ödeme yapmýþým?

SELECT S.CompanyName, SUM(Freight) AS TotalPayment FROM Orders O

JOIN Shippers S ON S.ShipperID = O.ShipVia

GROUP BY S.CompanyName
ORDER BY 2 DESC

--7- En deðerli müþterim hangisi?

SELECT SUM(Quantity * UnitPrice * (1 - Discount)) AS TotalPayment, C.CustomerID, C.ContactName, C.CompanyName  FROM Orders O

JOIN Customers C ON C.CustomerID = O.CustomerID
JOIN [Order Details] OD ON OD.OrderID =O.OrderID

GROUP BY C.CustomerID, C.ContactName, C.CompanyName
ORDER BY 1 DESC

--8 Zamanýnda teslim edemediðim sipariþlerim ID’leri  nelerdir ve kaç gün geç göndermiþim?

SELECT  DATEDIFF(DAY,RequiredDate, ShippedDate) AS DelayedDays, O.OrderID, O.RequiredDate, O.ShippedDate FROM Orders O
WHERE ShippedDate > RequiredDate 
ORDER BY 1 DESC

--9- Satýþlarýmý kaç günde teslim etmiþim?

SELECT DATEDIFF(DAY,OrderDate, ShippedDate) AS DayDifference, O.OrderID, O.RequiredDate, O.ShippedDate FROM Orders O

ORDER BY 1 DESC















