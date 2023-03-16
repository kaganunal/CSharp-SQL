--1. En k�sa s�rede giden sipari�i hangi kargo firmas� yapt� ?

SELECT O.OrderID, S.CompanyName, ABS(DATEDIFF(DAY,ShippedDate, OrderDate)) AS DayCount FROM Orders O
JOIN Shippers S ON S.ShipperID = O.ShipVia
WHERE ABS(DATEDIFF(DAY,ShippedDate, OrderDate)) IS NOT NULL
--GROUP BY S.CompanyName, O.OrderID
ORDER BY 3 ASC

--2. �irketim, �imdiye kadar ne kadar ciro yapm�� ?

SELECT CAST(SUM(UnitPrice * Quantity * (1-Discount)) AS DECIMAL(10,2)) AS 'TotalEndorsement' FROM [Order Details]

--3. Kategori idsi 1 ve 6 olan sipari�lerden en �ok sat�lan �r�n�n fiyat� ?

SELECT TOP 1 OD.UnitPrice, P.ProductID, P.ProductName, SUM(OD.Quantity) AS TotalSoldProducts FROM [Order Details] OD
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Categories C ON C.CategoryID = P.CategoryID
WHERE C.CategoryID = 1 OR C.CategoryID = 6
GROUP BY P.ProductID, P.ProductName, OD.UnitPrice
ORDER BY 4 DESC

--4. En �ok sipari� veren �al��an�m�n ya��n� foto�raf�n� ve satt��� �r�n say�s�n� g�ster?

SELECT COUNT(*) AS SiparisSayisi ,DATEDIFF(YEAR, E.BirthDate, GETDATE()) AS Yas FROM Orders O
JOIN Employees E ON O.EmployeeID = E.EmployeeID
--JOIN [Order Details] OD ON OD.OrderID = O.OrderID
GROUP BY E.EmployeeID, DATEDIFF(YEAR, E.BirthDate, GETDATE())
ORDER BY 1 DESC

--5. Kargo �dsi 2 olan kargo �irketine en �ok hangi �r�nleri teslim ettim ?

SELECT OD.ProductID, SUM(Quantity)  FROM Orders O
JOIN [Order Details] OD ON OD.OrderID = O.OrderID
JOIN Shippers S ON S.ShipperID = O.ShipVia
WHERE S.ShipperID = 2 AND ShippedDate IS NOT NULL
GROUP BY ProductID
ORDER BY 2 DESC

--6: Fax numaras� olmayan ve posta kodu d ile biten tedarik�ilerden al�n�p 1 numaral� kargo firmas� ile ismi m ile ba�layan �al��an taraf�ndan g�nderilen fakat kargoya belirtilen tarihten ge� verilmi�, s ile biten kategoriye ait �r�nleri g�steriniz.

SELECT * FROM Suppliers SU
JOIN Products P ON P.SupplierID = SU.SupplierID
JOIN [Order Details] OD ON OD.ProductID = P.ProductID
JOIN Categories C On C.CategoryID = P.CategoryID
JOIN Orders O ON OD.OrderID = O.OrderID 
JOIN Employees E ON E.EmployeeID = O.EmployeeID
WHERE SU.Fax IS NULL AND SU.PostalCode LIKE '%d' AND O.ShipVia = 1 AND FirstName LIKE 'm%' AND ShippedDate > RequiredDate AND C.CategoryName LIKE '%S'




--7: �stenen tarihten 3 haftadan k�sa s�rede m��teriye g�nderilmesi i�in kargoya verilmi� olan sipari�lerin ilk 3 �(kargo tarihi ile s�rala) hangi kargo firmalar� ile g�nderilmi�tir.

SELECT O.OrderID, RequiredDate, ShippedDate ,DATEDIFF(DAY,ShippedDate, RequiredDate) AS KacGunOnceTeslimEdildi, S.CompanyName  FROM Orders O
JOIN Shippers S ON S.ShipperID = O.ShipVia
WHERE DATEDIFF(DAY,ShippedDate, RequiredDate) < 21 AND DATEDIFF(DAY,ShippedDate, RequiredDate) > 0
ORDER BY 4 DESC





--8: Amerika k�tas� d���ndan tedarik edilmi� olan �r�nlerin hangileri sipari� �zerine Amerika k�tas�n�n WA region a teslim edilmi�tir.

SELECT * FROM Suppliers S
JOIN Products P ON P.SupplierID = S.SupplierID 
JOIN [Order Details] OD ON OD.ProductID = P.ProductID
JOIN Orders O On O.OrderID = OD.OrderID 
WHERE S.Country != 'USA' AND O.ShipRegion = 'WA'


--9: ID'si 2 olan kategoriye ait �r�nlerin ilk 5 i ni birim fiyat� pahal�dan ucuza do�ru olacak �ekilde g�steriniz.

SELECT TOP 5 P.ProductName, P.UnitPrice, C.CategoryID FROM Products P
JOIN Categories C ON C.CategoryID = P.CategoryID
WHERE C.CategoryID = 2 
ORDER BY 2 DESC

--10: 10 kere den fazla sipari� edilmi� �r�nlerin stoklar� kritik d�zeyde olanlar� listeleyiniz.

SELECT P.ProductName, OD.ProductID, P.UnitsInStock, ReorderLevel, COUNT(*) AS VerilmisSiparisSayisi FROM Orders O
JOIN [Order Details] OD ON OD.OrderID = O.OrderID
JOIN Products P ON P.ProductID = OD.ProductID
WHERE (P.UnitsInStock + P.ReorderLevel) < 20 AND Discontinued = 0
GROUP BY OD.ProductID, P.UnitsInStock, P.ProductName, ReorderLevel
HAVING COUNT(*) > 10
ORDER BY 3 ASC 

