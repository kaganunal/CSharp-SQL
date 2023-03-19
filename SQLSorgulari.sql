USE Northwind
--1-En çok satýþ yaptýðým müþterim hangisi

SELECT TOP 1 C.CustomerID, COUNT(OrderID) AS 'OrderCount', C.CompanyName FROM Customers C
JOIN Orders O ON O.CustomerID = C.CustomerID
GROUP BY C.CustomerID, C.CompanyName
ORDER BY 2 DESC

--2-En çok hangi sipariþten para kazanmýþým?

SELECT TOP 1 OD.OrderID, SUM(Quantity * UnitPrice * (1-Discount)) FROM [Order Details] OD
GROUP BY OD.OrderID
ORDER BY 2 DESC

--3-2 ay önce yaptýðým satýþlarýnýn london þehrinde ki x ürünün satýþ miktari

SELECT * FROM Orders O

--4-son 2 yýl içinde en çok satýlan ürün ve en az satýlan ürün

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

--5-yýlýn çalýþaný kim en çok satýþ yapan

SELECT E.EmployeeID, E.FirstName, E.LastName, COUNT(E.EmployeeID) AS 'OrderCount' FROM Employees E
JOIN Orders O ON O.EmployeeID = E.EmployeeID
GROUP BY E.EmployeeID, E.FirstName, E.LastName
ORDER BY 4 DESC

--6: Tedarikçi id si 1 ile 5 olan tedarikçilerden alýnan ürünlerin adýný ve stok sayýsýný gösteren sorgu.

SELECT P.ProductID, P.ProductName, P.UnitsInStock, S.SupplierID FROM Products P
JOIN Suppliers S ON S.SupplierID = P.SupplierID
WHERE S.SupplierID = 1 OR S.SupplierID = 5


--7: Stok sayýsý kritik olan 10 ürünün tedarikçilerinin adýný yazdýrýn.

SELECT P.SupplierID, S.CompanyName, (P.UnitsInStock + P.ReorderLevel) AS NumberOfUnitsInStock, P.Discontinued FROM Products P
JOIN Suppliers S ON S.SupplierID = P.SupplierID
WHERE (P.UnitsInStock + P.ReorderLevel) < 30 AND P.Discontinued != 1
ORDER BY 3 ASC

--8:Esparta bölgesine gönderilen en çok 5 ürünü listele.

SELECT OD.ProductID, SUM(OD.Quantity) FROM Orders O
JOIN [Order Details] OD ON OD.OrderID = O.OrderID
--JOIN Products P ON P.ProductID = OD.ProductID
WHERE O.ShipRegion = 'Nueva Esparta'
GROUP BY OD.ProductID
ORDER BY 2 DESC

SELECT * FROM Orders O
JOIN [Order Details] OD ON OD.OrderID = O.OrderID
WHERE ProductID = 70 AND O.ShipRegion = 'Nueva Esparta'

--9: En çok ürün alan müþteriye satýþ yapan personeller kimdir listele.

SELECT C.CustomerID, E.EmployeeID, SUM(OD.Quantity) NumberOfTotalSoldProducts FROM Orders O
JOIN [Order Details] OD ON OD.OrderID = O.OrderID
JOIN Customers C ON C.CustomerID = O.CustomerID
JOIN Employees E ON E.EmployeeID = O.EmployeeID
GROUP BY E.EmployeeID,C.CustomerID
ORDER BY 3 DESC

--10: En çok hangi kategori türünde satýþ olmustur.

SELECT C.CategoryID, SUM(OD.Quantity) TotalSoldProducts FROM Categories C
JOIN Products P ON P.CategoryID = C.CategoryID
JOIN [Order Details] OD ON OD.ProductID = P.CategoryID
GROUP BY C.CategoryID
ORDER BY 2 DESC

--11- Ship PostalCode'u sadece sayýlardan oluþmayan sipariþler

SELECT * FROM Orders O 
WHERE O.ShipPostalCode IN (SELECT ShipPostalCode WHERE ShipPostalCode LIKE '%[A B C D E F G H I J K L M N O  P R S  T U V Y Z]%')

--12- ContactTitle'a göre sýralanmýþ ve Kendi içinde de sýralanmýþ tedarikçilerin adres þehir ve bölgeleri tek kolonda, kolon adý Adres

SELECT S.ContactTitle, S.CompanyName,
CASE
    WHEN S.[Address] IS NULL THEN S.City + ', ' + S.Region 
    WHEN S.City IS NULL THEN S.[Address] + ', ' + S.Region
    WHEN S.Region IS NULL THEN S.[Address] + ', ' + S.City
    ELSE S.[Address] + ', ' + S.City + ', ' + S.Region
END AS Adres
FROM Suppliers S
ORDER BY 1, 3


--13- En ucuz sipariþ kaleminin tutarý

SELECT TOP 1 OD.OrderID, MIN(Quantity * UnitPrice * (1-Discount)) OrderPrice FROM [Order Details] OD
GROUP BY OD.OrderID
ORDER BY 2 ASC

--14- Adýnda a ve e harfi birlikte bulunan çalýþanlarýn yaþa göre sýralanmýþ halde bilgileri, adý ve soyadý Ad Soyad kolon adýyla gelecek

SELECT E.FirstName + ' ' + E.LastName AS FullName, DATEDIFF(YEAR,BirthDate,GETDATE()) Age FROM Employees E
WHERE E.FirstName LIKE '%A%' AND E.FirstName LIKE '%E%'
ORDER BY 2 DESC

--15- Ýþe girdiðinde yaþý en genç olan top 3 çalýþan

SELECT TOP 3 E.FirstName, E.LastName ,DATEDIFF(YEAR,BirthDate,HireDate) AgeWhenHired FROM Employees E
ORDER BY 3 ASC

--16 5 numaralý çalýþanýn yaptýðý satýþlarýn toplam ücreti ne kadardýr.

SELECT E.EmployeeID, SUM(Quantity * UnitPrice * (1-Discount)) TotalPrice FROM Employees E
JOIN Orders O ON O.EmployeeID = E.EmployeeID
JOIN [Order Details] OD ON OD.OrderID = O.OrderID
WHERE E.EmployeeID = 5
GROUP BY E.EmployeeID

--17:Kategorisi 1,3,5,7 olan ürünleri ürün isimlerine göre listeleyiniz.

SELECT P.ProductName, C.CategoryID FROM Categories C
JOIN Products P ON P.CategoryID = C.CategoryID
WHERE C.CategoryID %2 = 1

--18: 5 numaralý ürünü 2 numaralý kargocuya taþýtan müþterileri gösteriniz

SELECT C.CustomerID, C.CompanyName, S.ShipperID, P.ProductID FROM Products P
JOIN [Order Details] OD ON OD.ProductID =P.ProductID
JOIN Orders O ON O.OrderID = OD.OrderID
JOIN Customers C ON C.CustomerID = O.CustomerID
JOIN Shippers S ON S.ShipperID = O.ShipVia
WHERE P.ProductID = 5 AND S.ShipperID = 2


--19: Chai ürününü en çok alan müþterileri ve ödenen fiyatý azalan þekilde listeleyiniz.

SELECT C.CustomerID, C.CompanyName, SUM(Quantity) TotalBoughtChai, SUM(P.UnitPrice * Quantity * (1-Discount)) TotalPrice  FROM Customers C
JOIN Orders O ON O.CustomerID = C.CustomerID
JOIN [Order Details] OD ON OD.OrderID = O.OrderID
JOIN Products P ON P.ProductID = OD.ProductID
WHERE P.ProductName = 'Chai'
GROUP BY C.CustomerID, C.CompanyName
ORDER BY 3 DESC


--20:ürün adý cha ile baþlayan ve 4 harften oluþan ürünleri sorgusunu yazýnýz.

SELECT * FROM Products P
WHERE P.ProductName LIKE 'CHA%' AND P.ProductName LIKE '____'

--21-Tekrar sipariþ etme seviyesi 25'ten fazla olan ürünlerden birim fiyatý en yüksek olan ilk 3 ürünün ürün adý ve birim fiyatýný gösterin

SELECT TOP 3 P.ProductName, P.UnitPrice FROM Orders O
JOIN [Order Details] OD ON OD.OrderID = O.OrderID
JOIN Products P ON P.ProductID = OD.ProductID
WHERE P.ReorderLevel > 25
GROUP BY P.ProductName, P.UnitPrice
ORDER BY 2 DESC

--22-sipariþ tarihi 01.01.1997 den önce olan sipariþlerden bölge bilgisi boþ olmayan ve ülkesi Meksika olan sipariþlerin sipariþ idsi tarihi ve ülkesini listeleyin

SELECT * FROM Orders O
WHERE O.OrderDate < '1997-01-01' AND O.ShipRegion IS NOT NULL AND O.ShipCountry ='Mexico'

--23-stoklarý 10 ve 50 arasýnda olan ürünlerin indirim yapýlmayanlarýnýn birim fiyatlarýný azdan çoða doðru listeleyin.

SELECT P.ProductID, P.ProductName, P.UnitPrice, Discount FROM Products P
JOIN [Order Details] OD ON OD.ProductID = P.ProductID
WHERE UnitsInStock BETWEEN 10 AND 50 AND OD.Discount = 0
GROUP BY P.ProductID, P.ProductName, P.UnitPrice, Discount
ORDER BY 3 ASC

--24-4 numaralý kategoriye ait olan birim fiyatý 10'dan büyük olan ürünlerin ismini ve fiyatýný fiyat çoktan aza sýralanacak þekilde listeleyin

SELECT P.ProductName, P.UnitPrice, C.CategoryID FROM Categories C
JOIN Products P ON P.CategoryID = C.CategoryID
WHERE P.UnitPrice > 10 AND C.CategoryID = 4
ORDER BY 2 DESC

--25-müþteri ismi T ile baþlayan ve ülkesi USA olan müþterilerin müþteri ismi ve telefon numaralarýný listeleyin

SELECT C.ContactName, C.Phone FROM Customers C
WHERE C.ContactName LIKE 'T%' AND (C.Country = 'USA' OR Country =  'CANADA')

--26-En çok sipariþ veren müþteri bilgileri listele

SELECT COUNT(OrderID) TotalOrderCount, C.CustomerID, C.CompanyName, C.ContactName, C.[Address], C.Phone FROM Customers C
JOIN Orders O ON C.CustomerID = O.CustomerID
GROUP BY C.CustomerID, C.CompanyName, C.ContactName, C.[Address], C.Phone
ORDER BY COUNT(OrderID) DESC

--27-UnitPrice ý 15 ile 100 arasýnda olan, devam ettirilen ürünlerin adý ve fiyat bilgilerini fiyata göre artan sekilde sýralayýn

SELECT P.ProductName, P.UnitPrice FROM Products P
WHERE P.UnitPrice BETWEEN 15 AND 100 AND Discontinued = 0
ORDER BY 2 ASC

--28-1 numaralý kargo ile Cork sehrine gönderilen veya taþýma ücreti 111 den küçük olanlarýn siparis tarihini ve gönderim tarihlerini listeleyin

SELECT O.OrderDate, O.ShippedDate, O.Freight, ShipVia, ShipCity FROM Orders O
WHERE (O.ShipVia = 1 AND O.ShipCity LIKE 'Cork') OR (O.ShipVia = 1 AND O.Freight < 111)
ORDER BY 3 DESC

--29-Tedarikci adýnýn 2. harfi a veya e olan ve sonu n veya s ile bitmeyenlerin listesi

SELECT * FROM Suppliers S
WHERE (S.ContactName LIKE '_[AE]%') AND (S.ContactName NOT LIKE '%[NS]')

--30-Sales Representative  lerin ad ve soyadlarýný bir kolonda, iþe girisinden sonra geçen günü 'Geçen Gün' kolonunda gösterip sýralamayý geçen güne göre artan yapýn

SELECT E.FirstName + ' ' + E.LastName AS FullName, DATEDIFF(DAY, HireDate,GETDATE()) 'NumberOfDaysPassed' FROM Employees E
ORDER BY 2 ASC

--31-personelleri yaþ sýralamasý yapýp 25ten büyük olanlarýn ünvan kolonu açýp usta küçükse çýrak yazsýn

SELECT FirstName, LastName, BirthDate, 
       CASE 
           WHEN (DATEDIFF(YEAR, BirthDate, GETDATE())) > 25 THEN 'Usta'
           ELSE 'Çýrak'
       END AS Unvan
FROM Employees
ORDER BY BirthDate ASC

--32-personellerin yaþýný hesaplayýp ayrý bir yaþ kolonunda yazýn

SELECT E.EmployeeID, E.FirstName, E.LastName, DATEDIFF(YEAR, BirthDate, GETDATE()) Age FROM Employees E

--33-ürün tablosundan categorisi 2 olanlarýn stoklarýný 10 ar arttýrarak yenileyelim ve indirim uygulayalým

SELECT ProductName, CategoryID, UnitsInStock + 10 AS UpdatedStock, UnitPrice * 0.9 AS DiscountedPrice FROM Products
WHERE CategoryID = 2;

--34-ürün stoklarý 100ün üzerinde olanlarýa indirim uygulayýp birim fiyatýnýda 1$ düþürelim

SELECT ProductName, UnitPrice - 1 AS NewUnitPrice, UnitPrice * 0.9 AS DiscountedPrice FROM Products 
WHERE UnitsInStock > 100 

--35-costumers tablosundaki country kolonunda mexico yerine siesta yazalým

SELECT C.CompanyName, C.ContactName, C.City, C.CustomerID, REPLACE(Country,'Mexico','Siesta') Country
FROM Customers C

--36-En çok satilan 10 ürünün kategorileri

SELECT TOP 10 ProductName, C.CategoryName, SUM(Quantity) NumberOfSoldProducts FROM [Order Details] OD
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Categories C ON C.CategoryID = P.CategoryID
GROUP BY ProductName, C.CategoryName
ORDER BY 3 DESC

--37-1997 Ocak ayýnda en çok alýþveriþ yapan müþterinin en çok aldýðý ürünün indirim oraný

SELECT O.CustomerID ,SUM(Quantity) TotalProduct, OD.Discount FROM Orders O
JOIN [Order Details] OD ON O.OrderID = OD.OrderID
WHERE O.OrderDate BETWEEN '1997-01-01 00:00:00.000' AND '1997-02-01 00:00:00.000'
GROUP BY ProductID, OD.Discount, O.CustomerID
ORDER BY 2 DESC

--38-1997 yýlýnýn en çok satilan ürünün ülkesi ve totalprice

SELECT OD.ProductID,  FROM [Order Details] OD
JOIN Orders O ON O.OrderID = OD.OrderID
WHERE OrderDate BETWEEN '1997-01-01 00:00:00.000' AND '1998-01-01 00:00:00.000'

--39-Stok miktari 20 altýna düþen ürünlerin tedarikçilerinin telefon numalarý

SELECT P.ProductID, P.ProductName, S.SupplierID, S.CompanyName, S.ContactName ,S.Phone, P.UnitsInStock FROM Suppliers S
JOIN Products P ON P.SupplierID = S.SupplierID
WHERE P.UnitsInStock < 20 AND P.Discontinued = 0
GROUP BY S.SupplierID, S.CompanyName, S.ContactName ,S.Phone, P.ProductID, P.ProductName, P.UnitsInStock

--40-bu ay en çok satýþ yapan çalýþanýn en fazla satýþ yaptýðý ürünün devamý var mý

SELECT TOP 1 E.EmployeeID, E.FirstName + ' ' +  E.LastName AS EmployeeName, P.ProductName, SUM(OD.Quantity) AS TotalSoldProducts, P.Discontinued FROM Orders Ord 
JOIN [Order Details] OD ON OD.OrderID = Ord.OrderID
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Employees E ON E.EmployeeID = Ord.EmployeeID
WHERE Ord.OrderDate BETWEEN '1997-01-01 00:00:00.000' AND '1997-02-01 00:00:00.000' 
GROUP BY E.EmployeeID, P.ProductName, P.Discontinued, E.FirstName, E.LastName
ORDER BY SUM(OD.Quantity) DESC

--41-en fazla ürünü bulunan tedarikçinin kaç adet ürünü vardýr.

SELECT TOP 1 SupplierID, SUM(UnitsInStock) TotalStock FROM Products P
GROUP BY SupplierID
ORDER BY 2 DESC

--42-Ürünlerden en az bir kere satýlmýþ olanlarýn listesi

SELECT P.ProductName, P.ProductID, SUM(Quantity) TotalSold FROM Products P
JOIN [Order Details] OD ON OD.ProductID = P.ProductID
GROUP BY P.ProductName, P.ProductID
HAVING SUM(Quantity) > 0
ORDER BY 3 ASC

--43-Hiç alýþveriþ yapmamýþ kullanýcýlarýn listesi

SELECT C.CustomerID, C.CompanyName FROM Customers C
LEFT JOIN Orders O ON O.CustomerID = C.CustomerID
WHERE O.CustomerID IS NULL

--44-Þehri londra olan müþterilerin ürünlerinden an çok satanlar

SELECT C.CustomerID, P.ProductID, SUM(Quantity) TotalSell FROM Customers C
JOIN Orders O ON O.CustomerID = C.CustomerID
JOIN [Order Details] OD ON OD.OrderID = O.OrderID
JOIN Products P ON P.ProductID = OD.ProductID
WHERE C.City = 'London'
GROUP BY C.CustomerID, P.ProductID
ORDER BY 3 DESC

--45-Tedarikçi Id'si 1 olan ürünleri en çok sipariþ eden 3 müþteri

SELECT C.CustomerID, S.SupplierID, SUM(Quantity) TotalOrderCount FROM Customers C
JOIN Orders O ON O.CustomerID = C.CustomerID
JOIN [Order Details] OD ON OD.OrderID = O.OrderID
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Suppliers S ON S.SupplierID = P.SupplierID
WHERE S.SupplierID = 1
GROUP BY C.CustomerID, S.SupplierID 
ORDER BY 3 DESC

--46- Toplam kargo ya ödediðimiz ücret toplamý ciromuzun %'de kaçýdýr ?

SELECT  (CAST((SUM(Freight)/SUM(OD.UnitPrice * OD.Quantity * (1-OD.Discount)) * 100) AS varchar) + '%') AS RatioOfFreightAndEndorsement FROM Orders O
JOIN [Order Details] OD ON OD.OrderID = O.OrderID

--47-En çok sattýðýmýz ürün ile en az sattýðýmýz ürün arasýndaki adet fark kaçtýr ?

SELECT
	(SELECT SUM(Quantity) FROM [Order Details] OD 
	WHERE ProductID IN 
		(SELECT TOP 1 ProductID FROM [Order Details] GROUP BY ProductID ORDER BY SUM(Quantity) DESC)) -
	(SELECT SUM(Quantity)  FROM [Order Details] OD 
	WHERE ProductID IN 
		(SELECT TOP 1 ProductID FROM [Order Details] GROUP BY ProductID ORDER BY SUM(Quantity) ASC)) 
	AS SalesDifference

--48-  Ýndirim yapýlan ürünler ile indirim yapýlmamýþ halleri arasýndaki fiyat farký nedir hepsi için gruplayarak?

SELECT OrderID, P.ProductID, OD.UnitPrice NormalPrice, Discount,(OD.UnitPrice * (1-Discount)) DiscountedPrice, (OD.UnitPrice - (OD.UnitPrice * (1-Discount))) PriceDifference  FROM [Order Details] OD
JOIN Products P ON P.ProductID = OD.ProductID
WHERE Discount > 0
GROUP BY P.ProductID, OD.UnitPrice, Discount, OrderID


--49- En çok hangi ülkelere satýþ yapmýþýz top 5 sýralayýn ?

SELECT TOP 5 ShipCountry, COUNT(ShipCountry) FROM Orders O
GROUP BY ShipCountry
ORDER BY 2 DESC

--50- En çok ürünü hangi city deki müþteri almýþtýr

SELECT TOP 1 O.CustomerID, C.City, SUM(Quantity) TotalBoughtProducts FROM [Order Details] OD
JOIN Orders O ON O.OrderID = OD.OrderID
JOIN Customers C ON C.CustomerID = O.CustomerID
GROUP BY C.City, O.CustomerID
ORDER BY 3 DESC