-- 1.SORU Çalýþanlarýmýn arasýnda adýnýn ilk harfi A veya R olanlarý listeleyiniz...

SELECT * FROM Employees
WHERE FirstName LIKE 'A%' OR FirstName LIKE 'R%'

SELECT * FROM Employees
WHERE FirstName LIKE '[AR]%'

-- 2.SORU Çalýþanlarýmýn arasýnda soyadýnýn içinde A harfi geçenleri listeleyelim...

SELECT * FROM Employees AS a
WHERE a.LastName LIKE '%A%'

-- 3.SORU Çalýþanlarýmýn arasýnda adý alfabetik olarak B ile S arasýnda olanlarý listeleyiniz...

SELECT * FROM Employees
WHERE FirstName LIKE '[B C D E F G H I J K L M N O P R S]%'
ORDER BY FirstName ASC

SELECT * FROM Employees
WHERE FirstName BETWEEN 'B' AND 'S'
ORDER BY FirstName DESC

-- 4.SORU Çalýþanlarýmýn arasýnda adýnýn içinde A ve E harfi olan ve bu karakterler arasýnda yalnýzca 1 karakter olanlarý listeleyiniz...

SELECT * FROM Employees
WHERE FirstName LIKE '%A_E%'

-- 5.SORU Çalýþanlarýmýn arasýnda adýnýn içinde A ve E harfi olan ve bu karakterler arasýnda yalnýzca 2 karakter olanlarý listeleyiniz... (Örnek: AyfEr, AskEr gibi)
 
 SELECT * FROM Employees
WHERE FirstName LIKE '%A__E%'

 -- 6.SORU Employees tablosundan ID'si 2 ile 8 arasýnda olan çalýþanlarýn bilgilerini, FirstName kolonuna göre ARTAN sýrada sýralayýnýz (A'dan Z'ye)
  SELECT * FROM Employees
  --WHERE EmployeeID > 2 AND EmployeeID < 8 
    WHERE EmployeeID BETWEEN 2 AND 8
  ORDER BY FirstName ASC

  -- 7.SORU Employees tablosundan, çalýþanlarýn, Adý, Soyadý, Doðum tarihi bilgilerini, BirthDate kolonuna göre ARTAN sýrada sýralayarak listeleyiniz...

    SELECT FirstName, LastName, BirthDate FROM Employees
	ORDER BY BirthDate DESC

	-- 8.SORU Kategoriler tablosuna 'Meyveler' kategorisini, 'Mevsim meyveleri taze tüketilirse faydalý olur.' açýklamasýyla birlikte ekleyiniz...
--	ALTER TABLE Categories
--INSERT INTO Categories	(CategoryName, Description) VALUES ('Meyveler', 'Mevsim meyveleri taze tüketilirse faydalý olur.')

-- 9.SORU Employees tablosuna kendi bilgilerinizi ekleyiniz...

INSERT INTO Employees ([LastName]
      ,[FirstName]
      ,[Title]
      ,[TitleOfCourtesy]
      ,[BirthDate]
      ,[HireDate]
      ,[Address]
      ,[City]
      ,[Region]
      ,[PostalCode]
      ,[Country]
      ,[HomePhone]
      ,[Extension]
      ,[Photo]
      ,[Notes]
      ,[ReportsTo]
      ,[PhotoPath])
	  VALUES ('Unal', 'Oguz Kagan', 'CTO', 'Mr.', '1998-10-21', '2021-10-15', 'IsciBloklari Mah.',  'Ankara', 'Cankaya', '06030', 'TR', '(505) 4755445', '+090',NULL, 'Kagan has a BA degree in CÝvil Engineering from Hacettepe Universtiy.  He is fluent in English and German.', NULL, NULL   )

	  -- 10.SORU Tek bir INSERT komutu ile Employees tablosuna 3 kiþi ekleyiniz... FirstName, LastName, TitleOfCourtesy, Title
	  INSERT INTO Employees (FirstName, LastName, TitleOfCourtesy, Title)
	  VALUES 
	  ('Gokcehan', 'Gucuk', 'Mr.', 'Ýmam' ),
	  ('Atakan', 'Bektas', 'Mr.', 'Soldier' ),
	  ('Mustafa', 'Ozcan', 'Mr.', 'CEO' )

	  -- 11.SORU Çalýþanlar tablosundan ID'si 7 olan çalýþanýn soyadýný güncelleyiniz...
	  SELECT * FROM Employees 
	  UPDATE Employees
	  SET LastName = 'King'
	  WHERE EmployeeID = 7; 

	  -- 12.SORU Çalýþanlar tablosundaki bütün çalýþanlarýn soyadýný güncelleyiniz...
	  UPDATE Employees
	  SET LastName = 'Unal'

	  -- 13.SORU Çalýþanlar tablosunda Unvaný 'Mr.' olanlarý 'Bay' olarak güncelleyiniz...
	  UPDATE Employees
	  SET TitleOfCourtesy = 'Bay'
	  WHERE TitleOfCourtesy LIKE 'Mr.'
	  SELECT * FROM Employees 

	  -- 14.SORU Kadýn çalýþanlar içerisinde görevi Sales Representative olanlarý Satýþ Temsilcisi olarak güncelleyiniz...
	  UPDATE Employees
	  SET Title = 'Satýþ Temsilcisi'
	  WHERE Title LIKE 'Sales Representative' AND TitleOfCourtesy = 'Ms.' OR TitleOfCourtesy = 'Mrs.'
	  SELECT * FROM Employees

	  -- 15.SORU Çalýþanlar tablosundan ID'si 5 olan çalýþaný silelim...
	  --Employees tablosunu kopyalayýp Calisanlar tablosu oluþturalým
	  DELETE FROM Employees 
	  WHERE EmployeeID = '5'
	  SELECT * FROM Employees


	  SELECT *
	  INTO Calisanlar 
	  FROM Employees

	  DELETE FROM Calisanlar 
	  WHERE EmployeeID = '5'
	  SELECT * FROM Calisanlar

	  -- 16.SORU Çalýþanlar tablosundan unvaný bayan olan çalýþanlarý silmek istersek;

	  DELETE FROM Calisanlar 
	  WHERE TitleOfCourtesy = 'Ms.' AND TitleOfCourtesy = 'Mrs.'
	  SELECT * FROM Calisanlar

	  -- 17.SORU Çalýþanlar tablosundaki TÜM verileri silelim...
	  	  DELETE TABLE Calisanlar
	  	  SELECT * FROM Calisanlar

		  -- 18.SORU Calisanlar tablosunu veritabanýndan silmek için:
	  DROP TABLE Calisanlar