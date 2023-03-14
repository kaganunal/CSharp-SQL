-- 1.SORU Her �r�n i�in �r�nler tablosundan �r�n Ad�, Kategoriler tablosundan Kategori Ad� bilgilerini listeleyiniz...

SELECT ProductName, CategoryName FROM Products

JOIN Categories

ON Products.CategoryID = Categories.CategoryID

-- 2.SORU Hangi sipari�in, hangi �al��an taraf�ndan al�nd���n�, hangi m��teriye g�nderilece�ini listeleyiniz..

SELECT OrderDate, CompanyName, FirstName, LastName, ContactName FROM Orders
JOIN Employees
ON Orders.EmployeeID = Employees.EmployeeID
JOIN Customers
ON Customers.CustomerID = Orders.CustomerID

-- 3.SORU Products tablosundan T�M KAYITLARI, Categories tablosundan ili�kili kay�tlar� listeleyelim. (ProductName, CategoryName)

SELECT P.ProductName, C.CategoryName FROM Products P
LEFT JOIN Categories C
ON P.CategoryID=C.CategoryID

SELECT * From Products
SELECT * From Categories
