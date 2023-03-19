USE Northwind
--1-En �ok sat�� yapt���m m��terim hangisi

SELECT TOP 1 C.CustomerID, COUNT(OrderID) AS 'OrderCount', C.CompanyName FROM Customers C
JOIN Orders O ON O.CustomerID = C.CustomerID
GROUP BY C.CustomerID, C.CompanyName
ORDER BY 2 DESC

--2-En �ok hangi sipari�ten para kazanm���m?

SELECT TOP 1 OD.OrderID, SUM(Quantity * UnitPrice * (1-Discount)) FROM [Order Details] OD
GROUP BY OD.OrderID
ORDER BY 2 DESC

--3-2 ay �nce yapt���m sat��lar�n�n london �ehrinde ki x �r�n�n sat�� miktari

SELECT * FROM Orders O

--4-son 2 y�l i�inde en �ok sat�lan �r�n ve en az sat�lan �r�n

SELECT TOP 1 OD.ProductID, P.ProductName, SUM(Quantity) TotalSell FROM [Order Details] OD
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Orders O ON O.OrderID = OD.OrderID
WHERE O.OrderDate BETWEEN DATEADD(year, -2, GETDATE()) AND GETDATE()
GROUP BY OD.ProductID, P.ProductName
ORDER BY 3 DESC

SELECT TOP 1 OD.ProductID, P.ProductName, SUM(Quantity) TotalSell FROM [Order Details] OD
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Orders O ON O.OrderID = OD.OrderID
WHERE O.OrderDate BETWEEN DATEADD(year, -2, GETDATE()) AND GETDATE()
GROUP BY OD.ProductID, P.ProductName
ORDER BY 3 ASC

--5-y�l�n �al��an� kim en �ok sat�� yapan

SELECT E.EmployeeID, E.FirstName, E.LastName, COUNT(E.EmployeeID) AS 'OrderCount' FROM Employees E
JOIN Orders O ON O.EmployeeID = E.EmployeeID
GROUP BY E.EmployeeID, E.FirstName, E.LastName
ORDER BY 4 DESC

--6: Tedarik�i id si 1 ile 5 olan tedarik�ilerden al�nan �r�nlerin ad�n� ve stok say�s�n� g�steren sorgu.

SELECT P.ProductID, P.ProductName, P.UnitsInStock, S.SupplierID FROM Products P
JOIN Suppliers S ON S.SupplierID = P.SupplierID
WHERE S.SupplierID = 1 OR S.SupplierID = 5


--7: Stok say�s� kritik olan 10 �r�n�n tedarik�ilerinin ad�n� yazd�r�n.

SELECT P.SupplierID, S.CompanyName, (P.UnitsInStock + P.ReorderLevel) AS NumberOfUnitsInStock, P.Discontinued FROM Products P
JOIN Suppliers S ON S.SupplierID = P.SupplierID
WHERE (P.UnitsInStock + P.ReorderLevel) < 30 AND P.Discontinued != 1
ORDER BY 3 ASC

--8:Esparta b�lgesine g�nderilen en �ok 5 �r�n� listele.

SELECT OD.ProductID, SUM(OD.Quantity) FROM Orders O
JOIN [Order Details] OD ON OD.OrderID = O.OrderID
--JOIN Products P ON P.ProductID = OD.ProductID
WHERE O.ShipRegion = 'Nueva Esparta'
GROUP BY OD.ProductID
ORDER BY 2 DESC

SELECT * FROM Orders O
JOIN [Order Details] OD ON OD.OrderID = O.OrderID
WHERE ProductID = 70 AND O.ShipRegion = 'Nueva Esparta'

--9: En �ok �r�n alan m��teriye sat�� yapan personeller kimdir listele.

SELECT C.CustomerID, E.EmployeeID, SUM(OD.Quantity) NumberOfTotalSoldProducts FROM Orders O
JOIN [Order Details] OD ON OD.OrderID = O.OrderID
JOIN Customers C ON C.CustomerID = O.CustomerID
JOIN Employees E ON E.EmployeeID = O.EmployeeID
GROUP BY E.EmployeeID,C.CustomerID
ORDER BY 3 DESC

--10: En �ok hangi kategori t�r�nde sat�� olmustur.

SELECT C.CategoryID, SUM(OD.Quantity) TotalSoldProducts FROM Categories C
JOIN Products P ON P.CategoryID = C.CategoryID
JOIN [Order Details] OD ON OD.ProductID = P.CategoryID
GROUP BY C.CategoryID
ORDER BY 2 DESC

--11- Ship PostalCode'u sadece say�lardan olu�mayan sipari�ler

SELECT * FROM Orders O 
WHERE O.ShipPostalCode IN (SELECT ShipPostalCode WHERE ShipPostalCode LIKE '%[A B C D E F G H I J K L M N O  P R S  T U V Y Z]%')

--12- ContactTitle'a g�re s�ralanm�� ve Kendi i�inde de s�ralanm�� tedarik�ilerin adres �ehir ve b�lgeleri tek kolonda, kolon ad� Adres

SELECT S.ContactTitle, S.CompanyName,
CASE
    WHEN S.[Address] IS NULL THEN S.City + ', ' + S.Region 
    WHEN S.City IS NULL THEN S.[Address] + ', ' + S.Region
    WHEN S.Region IS NULL THEN S.[Address] + ', ' + S.City
    ELSE S.[Address] + ', ' + S.City + ', ' + S.Region
END AS Adres
FROM Suppliers S
ORDER BY 1, 3


--13- En ucuz sipari� kaleminin tutar�

SELECT TOP 1 OD.OrderID, MIN(Quantity * UnitPrice * (1-Discount)) OrderPrice FROM [Order Details] OD
GROUP BY OD.OrderID
ORDER BY 2 ASC

--14- Ad�nda a ve e harfi birlikte bulunan �al��anlar�n ya�a g�re s�ralanm�� halde bilgileri, ad� ve soyad� Ad Soyad kolon ad�yla gelecek

SELECT E.FirstName + ' ' + E.LastName AS FullName, DATEDIFF(YEAR,BirthDate,GETDATE()) Age FROM Employees E
WHERE E.FirstName LIKE '%A%' AND E.FirstName LIKE '%E%'
ORDER BY 2 DESC

--15- ��e girdi�inde ya�� en gen� olan top 3 �al��an

SELECT TOP 3 E.FirstName, E.LastName ,DATEDIFF(YEAR,BirthDate,HireDate) AgeWhenHired FROM Employees E
ORDER BY 3 ASC

--16 5 numaral� �al��an�n yapt��� sat��lar�n toplam �creti ne kadard�r.

SELECT E.EmployeeID, SUM(Quantity * UnitPrice * (1-Discount)) TotalPrice FROM Employees E
JOIN Orders O ON O.EmployeeID = E.EmployeeID
JOIN [Order Details] OD ON OD.OrderID = O.OrderID
WHERE E.EmployeeID = 5
GROUP BY E.EmployeeID

--17:Kategorisi 1,3,5,7 olan �r�nleri �r�n isimlerine g�re listeleyiniz.

SELECT P.ProductName, C.CategoryID FROM Categories C
JOIN Products P ON P.CategoryID = C.CategoryID
WHERE C.CategoryID %2 = 1

--18: 5 numaral� �r�n� 2 numaral� kargocuya ta��tan m��terileri g�steriniz

SELECT C.CustomerID, C.CompanyName, S.ShipperID, P.ProductID FROM Products P
JOIN [Order Details] OD ON OD.ProductID =P.ProductID
JOIN Orders O ON O.OrderID = OD.OrderID
JOIN Customers C ON C.CustomerID = O.CustomerID
JOIN Shippers S ON S.ShipperID = O.ShipVia
WHERE P.ProductID = 5 AND S.ShipperID = 2


--19: Chai �r�n�n� en �ok alan m��terileri ve �denen fiyat� azalan �ekilde listeleyiniz.

SELECT C.CustomerID, C.CompanyName, SUM(Quantity) TotalBoughtChai, SUM(P.UnitPrice * Quantity * (1-Discount)) TotalPrice  FROM Customers C
JOIN Orders O ON O.CustomerID = C.CustomerID
JOIN [Order Details] OD ON OD.OrderID = O.OrderID
JOIN Products P ON P.ProductID = OD.ProductID
WHERE P.ProductName = 'Chai'
GROUP BY C.CustomerID, C.CompanyName
ORDER BY 3 DESC


--20:�r�n ad� cha ile ba�layan ve 4 harften olu�an �r�nleri sorgusunu yaz�n�z.

SELECT * FROM Products P
WHERE P.ProductName LIKE 'CHA%' AND P.ProductName LIKE '____'

--21-Tekrar sipari� etme seviyesi 25'ten fazla olan �r�nlerden birim fiyat� en y�ksek olan ilk 3 �r�n�n �r�n ad� ve birim fiyat�n� g�sterin

SELECT TOP 3 P.ProductName, P.UnitPrice FROM Orders O
JOIN [Order Details] OD ON OD.OrderID = O.OrderID
JOIN Products P ON P.ProductID = OD.ProductID
WHERE P.ReorderLevel > 25
GROUP BY P.ProductName, P.UnitPrice
ORDER BY 2 DESC

--22-sipari� tarihi 01.01.1997 den �nce olan sipari�lerden b�lge bilgisi bo� olmayan ve �lkesi Meksika olan sipari�lerin sipari� idsi tarihi ve �lkesini listeleyin

SELECT * FROM Orders O
WHERE O.OrderDate < '1997-01-01' AND O.ShipRegion IS NOT NULL AND O.ShipCountry ='Mexico'

--23-stoklar� 10 ve 50 aras�nda olan �r�nlerin indirim yap�lmayanlar�n�n birim fiyatlar�n� azdan �o�a do�ru listeleyin.

SELECT P.ProductID, P.ProductName, P.UnitPrice, Discount FROM Products P
JOIN [Order Details] OD ON OD.ProductID = P.ProductID
WHERE UnitsInStock BETWEEN 10 AND 50 AND OD.Discount = 0
GROUP BY P.ProductID, P.ProductName, P.UnitPrice, Discount
ORDER BY 3 ASC

--24-4 numaral� kategoriye ait olan birim fiyat� 10'dan b�y�k olan �r�nlerin ismini ve fiyat�n� fiyat �oktan aza s�ralanacak �ekilde listeleyin

SELECT P.ProductName, P.UnitPrice, C.CategoryID FROM Categories C
JOIN Products P ON P.CategoryID = C.CategoryID
WHERE P.UnitPrice > 10 AND C.CategoryID = 4
ORDER BY 2 DESC

--25-m��teri ismi T ile ba�layan ve �lkesi USA olan m��terilerin m��teri ismi ve telefon numaralar�n� listeleyin

SELECT C.ContactName, C.Phone FROM Customers C
WHERE C.ContactName LIKE 'T%' AND (C.Country = 'USA' OR Country =  'CANADA')

--26-En �ok sipari� veren m��teri bilgileri listele

SELECT COUNT(OrderID) TotalOrderCount, C.CustomerID, C.CompanyName, C.ContactName, C.[Address], C.Phone FROM Customers C
JOIN Orders O ON C.CustomerID = O.CustomerID
GROUP BY C.CustomerID, C.CompanyName, C.ContactName, C.[Address], C.Phone
ORDER BY COUNT(OrderID) DESC

--27-UnitPrice � 15 ile 100 aras�nda olan, devam ettirilen �r�nlerin ad� ve fiyat bilgilerini fiyata g�re artan sekilde s�ralay�n

SELECT P.ProductName, P.UnitPrice FROM Products P
WHERE P.UnitPrice BETWEEN 15 AND 100 AND Discontinued = 0
ORDER BY 2 ASC

--28-1 numaral� kargo ile Cork sehrine g�nderilen veya ta��ma �creti 111 den k���k olanlar�n siparis tarihini ve g�nderim tarihlerini listeleyin

SELECT O.OrderDate, O.ShippedDate, O.Freight, ShipVia, ShipCity FROM Orders O
WHERE (O.ShipVia = 1 AND O.ShipCity LIKE 'Cork') OR (O.ShipVia = 1 AND O.Freight < 111)
ORDER BY 3 DESC

--29-Tedarikci ad�n�n 2. harfi a veya e olan ve sonu n veya s ile bitmeyenlerin listesi

SELECT * FROM Suppliers S
WHERE (S.ContactName LIKE '_[AE]%') AND (S.ContactName NOT LIKE '%[NS]')

--30-Sales Representative  lerin ad ve soyadlar�n� bir kolonda, i�e girisinden sonra ge�en g�n� 'Ge�en G�n' kolonunda g�sterip s�ralamay� ge�en g�ne g�re artan yap�n

SELECT E.FirstName + ' ' + E.LastName AS FullName, DATEDIFF(DAY, HireDate,GETDATE()) 'NumberOfDaysPassed' FROM Employees E
ORDER BY 2 ASC

--31-personelleri ya� s�ralamas� yap�p 25ten b�y�k olanlar�n �nvan kolonu a��p usta k���kse ��rak yazs�n

SELECT FirstName, LastName, BirthDate, 
       CASE 
           WHEN (DATEDIFF(YEAR, BirthDate, GETDATE())) > 25 THEN 'Usta'
           ELSE '��rak'
       END AS Unvan
FROM Employees
ORDER BY BirthDate ASC

--32-personellerin ya��n� hesaplay�p ayr� bir ya� kolonunda yaz�n

SELECT E.EmployeeID, E.FirstName, E.LastName, DATEDIFF(YEAR, BirthDate, GETDATE()) Age FROM Employees E

--33-�r�n tablosundan categorisi 2 olanlar�n stoklar�n� 10 ar artt�rarak yenileyelim ve indirim uygulayal�m

SELECT ProductName, CategoryID, UnitsInStock + 10 AS UpdatedStock, UnitPrice * 0.9 AS DiscountedPrice FROM Products
WHERE CategoryID = 2;

--34-�r�n stoklar� 100�n �zerinde olanlar�a indirim uygulay�p birim fiyat�n�da 1$ d���relim

SELECT ProductName, UnitPrice - 1 AS NewUnitPrice, UnitPrice * 0.9 AS DiscountedPrice FROM Products 
WHERE UnitsInStock > 100 

--35-costumers tablosundaki country kolonunda mexico yerine siesta yazal�m

SELECT C.CompanyName, C.ContactName, C.City, C.CustomerID, REPLACE(Country,'Mexico','Siesta') Country
FROM Customers C

--36-En �ok satilan 10 �r�n�n kategorileri

SELECT TOP 10 ProductName, C.CategoryName, SUM(Quantity) NumberOfSoldProducts FROM [Order Details] OD
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Categories C ON C.CategoryID = P.CategoryID
GROUP BY ProductName, C.CategoryName
ORDER BY 3 DESC

--37-1997 Ocak ay�nda en �ok al��veri� yapan m��terinin en �ok ald��� �r�n�n indirim oran�

SELECT O.CustomerID ,SUM(Quantity) TotalProduct, OD.Discount FROM Orders O
JOIN [Order Details] OD ON O.OrderID = OD.OrderID
WHERE O.OrderDate BETWEEN '1997-01-01 00:00:00.000' AND '1997-02-01 00:00:00.000'
GROUP BY ProductID, OD.Discount, O.CustomerID
ORDER BY 2 DESC

--38-1997 y�l�n�n en �ok satilan �r�n�n �lkesi ve totalprice

SELECT OD.ProductID,  FROM [Order Details] OD
JOIN Orders O ON O.OrderID = OD.OrderID
WHERE OrderDate BETWEEN '1997-01-01 00:00:00.000' AND '1998-01-01 00:00:00.000'

--39-Stok miktari 20 alt�na d��en �r�nlerin tedarik�ilerinin telefon numalar�

SELECT P.ProductID, P.ProductName, S.SupplierID, S.CompanyName, S.ContactName ,S.Phone, P.UnitsInStock FROM Suppliers S
JOIN Products P ON P.SupplierID = S.SupplierID
WHERE P.UnitsInStock < 20 AND P.Discontinued = 0
GROUP BY S.SupplierID, S.CompanyName, S.ContactName ,S.Phone, P.ProductID, P.ProductName, P.UnitsInStock

--40-bu ay en �ok sat�� yapan �al��an�n en fazla sat�� yapt��� �r�n�n devam� var m�

SELECT TOP 1 E.EmployeeID, E.FirstName + ' ' +  E.LastName AS EmployeeName, P.ProductName, SUM(OD.Quantity) AS TotalSoldProducts, P.Discontinued FROM Orders Ord 
JOIN [Order Details] OD ON OD.OrderID = Ord.OrderID
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Employees E ON E.EmployeeID = Ord.EmployeeID
WHERE Ord.OrderDate BETWEEN '1997-01-01 00:00:00.000' AND '1997-02-01 00:00:00.000' 
GROUP BY E.EmployeeID, P.ProductName, P.Discontinued, E.FirstName, E.LastName
ORDER BY SUM(OD.Quantity) DESC

--41-en fazla �r�n� bulunan tedarik�inin ka� adet �r�n� vard�r.

SELECT TOP 1 SupplierID, SUM(UnitsInStock) TotalStock FROM Products P
GROUP BY SupplierID
ORDER BY 2 DESC

--42-�r�nlerden en az bir kere sat�lm�� olanlar�n listesi

SELECT P.ProductName, P.ProductID, SUM(Quantity) TotalSold FROM Products P
JOIN [Order Details] OD ON OD.ProductID = P.ProductID
GROUP BY P.ProductName, P.ProductID
HAVING SUM(Quantity) > 0
ORDER BY 3 ASC

--43-Hi� al��veri� yapmam�� kullan�c�lar�n listesi

SELECT C.CustomerID, C.CompanyName FROM Customers C
LEFT JOIN Orders O ON O.CustomerID = C.CustomerID
WHERE O.CustomerID IS NULL

--44-�ehri londra olan m��terilerin �r�nlerinden an �ok satanlar

SELECT C.CustomerID, P.ProductID, SUM(Quantity) TotalSell FROM Customers C
JOIN Orders O ON O.CustomerID = C.CustomerID
JOIN [Order Details] OD ON OD.OrderID = O.OrderID
JOIN Products P ON P.ProductID = OD.ProductID
WHERE C.City = 'London'
GROUP BY C.CustomerID, P.ProductID
ORDER BY 3 DESC

--45-Tedarik�i Id'si 1 olan �r�nleri en �ok sipari� eden 3 m��teri

SELECT C.CustomerID, S.SupplierID, SUM(Quantity) TotalOrderCount FROM Customers C
JOIN Orders O ON O.CustomerID = C.CustomerID
JOIN [Order Details] OD ON OD.OrderID = O.OrderID
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Suppliers S ON S.SupplierID = P.SupplierID
WHERE S.SupplierID = 1
GROUP BY C.CustomerID, S.SupplierID 
ORDER BY 3 DESC

--46- Toplam kargo ya �dedi�imiz �cret toplam� ciromuzun %'de ka��d�r ?

SELECT  (CAST((SUM(Freight)/SUM(OD.UnitPrice * OD.Quantity * (1-OD.Discount)) * 100) AS varchar) + '%') AS RatioOfFreightAndEndorsement FROM Orders O
JOIN [Order Details] OD ON OD.OrderID = O.OrderID

--47-En �ok satt���m�z �r�n ile en az satt���m�z �r�n aras�ndaki adet fark ka�t�r ?

SELECT
	(SELECT SUM(Quantity) FROM [Order Details] OD 
	WHERE ProductID IN 
		(SELECT TOP 1 ProductID FROM [Order Details] GROUP BY ProductID ORDER BY SUM(Quantity) DESC)) -
	(SELECT SUM(Quantity)  FROM [Order Details] OD 
	WHERE ProductID IN 
		(SELECT TOP 1 ProductID FROM [Order Details] GROUP BY ProductID ORDER BY SUM(Quantity) ASC)) 
	AS SalesDifference

--48-  �ndirim yap�lan �r�nler ile indirim yap�lmam�� halleri aras�ndaki fiyat fark� nedir hepsi i�in gruplayarak?

SELECT OrderID, P.ProductID, OD.UnitPrice NormalPrice, Discount,(OD.UnitPrice * (1-Discount)) DiscountedPrice, (OD.UnitPrice - (OD.UnitPrice * (1-Discount))) PriceDifference  FROM [Order Details] OD
JOIN Products P ON P.ProductID = OD.ProductID
WHERE Discount > 0
GROUP BY P.ProductID, OD.UnitPrice, Discount, OrderID


--49- En �ok hangi �lkelere sat�� yapm���z top 5 s�ralay�n ?

SELECT TOP 5 ShipCountry, COUNT(ShipCountry) FROM Orders O
GROUP BY ShipCountry
ORDER BY 2 DESC

--50- En �ok �r�n� hangi city deki m��teri alm��t�r

SELECT TOP 1 O.CustomerID, C.City, SUM(Quantity) TotalBoughtProducts FROM [Order Details] OD
JOIN Orders O ON O.OrderID = OD.OrderID
JOIN Customers C ON C.CustomerID = O.CustomerID
GROUP BY C.City, O.CustomerID
ORDER BY 3 DESC