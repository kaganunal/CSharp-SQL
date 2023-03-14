-- 1.SORU �al��anlar�m�n aras�nda ad�n�n ilk harfi A veya R olanlar� listeleyiniz...

SELECT * FROM Employees
WHERE FirstName LIKE 'A%' OR FirstName LIKE 'R%'

SELECT * FROM Employees
WHERE FirstName LIKE '[AR]%'

-- 2.SORU �al��anlar�m�n aras�nda soyad�n�n i�inde A harfi ge�enleri listeleyelim...

SELECT * FROM Employees AS a
WHERE a.LastName LIKE '%A%'

-- 3.SORU �al��anlar�m�n aras�nda ad� alfabetik olarak B ile S aras�nda olanlar� listeleyiniz...

SELECT * FROM Employees
WHERE FirstName LIKE '[B C D E F G H I J K L M N O P R S]%'
ORDER BY FirstName ASC

SELECT * FROM Employees
WHERE FirstName BETWEEN 'B' AND 'S'
ORDER BY FirstName DESC

-- 4.SORU �al��anlar�m�n aras�nda ad�n�n i�inde A ve E harfi olan ve bu karakterler aras�nda yaln�zca 1 karakter olanlar� listeleyiniz...

SELECT * FROM Employees
WHERE FirstName LIKE '%A_E%'

-- 5.SORU �al��anlar�m�n aras�nda ad�n�n i�inde A ve E harfi olan ve bu karakterler aras�nda yaln�zca 2 karakter olanlar� listeleyiniz... (�rnek: AyfEr, AskEr gibi)
 
 SELECT * FROM Employees
WHERE FirstName LIKE '%A__E%'

 -- 6.SORU Employees tablosundan ID'si 2 ile 8 aras�nda olan �al��anlar�n bilgilerini, FirstName kolonuna g�re ARTAN s�rada s�ralay�n�z (A'dan Z'ye)
  SELECT * FROM Employees
  --WHERE EmployeeID > 2 AND EmployeeID < 8 
    WHERE EmployeeID BETWEEN 2 AND 8
  ORDER BY FirstName ASC

  -- 7.SORU Employees tablosundan, �al��anlar�n, Ad�, Soyad�, Do�um tarihi bilgilerini, BirthDate kolonuna g�re ARTAN s�rada s�ralayarak listeleyiniz...

    SELECT FirstName, LastName, BirthDate FROM Employees
	ORDER BY BirthDate DESC

	-- 8.SORU Kategoriler tablosuna 'Meyveler' kategorisini, 'Mevsim meyveleri taze t�ketilirse faydal� olur.' a��klamas�yla birlikte ekleyiniz...
--	ALTER TABLE Categories
--INSERT INTO Categories	(CategoryName, Description) VALUES ('Meyveler', 'Mevsim meyveleri taze t�ketilirse faydal� olur.')

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
	  VALUES ('Unal', 'Oguz Kagan', 'CTO', 'Mr.', '1998-10-21', '2021-10-15', 'IsciBloklari Mah.',  'Ankara', 'Cankaya', '06030', 'TR', '(505) 4755445', '+090',NULL, 'Kagan has a BA degree in C�vil Engineering from Hacettepe Universtiy.  He is fluent in English and German.', NULL, NULL   )

	  -- 10.SORU Tek bir INSERT komutu ile Employees tablosuna 3 ki�i ekleyiniz... FirstName, LastName, TitleOfCourtesy, Title
	  INSERT INTO Employees (FirstName, LastName, TitleOfCourtesy, Title)
	  VALUES 
	  ('Gokcehan', 'Gucuk', 'Mr.', '�mam' ),
	  ('Atakan', 'Bektas', 'Mr.', 'Soldier' ),
	  ('Mustafa', 'Ozcan', 'Mr.', 'CEO' )

	  -- 11.SORU �al��anlar tablosundan ID'si 7 olan �al��an�n soyad�n� g�ncelleyiniz...
	  SELECT * FROM Employees 
	  UPDATE Employees
	  SET LastName = 'King'
	  WHERE EmployeeID = 7; 

	  -- 12.SORU �al��anlar tablosundaki b�t�n �al��anlar�n soyad�n� g�ncelleyiniz...
	  UPDATE Employees
	  SET LastName = 'Unal'

	  -- 13.SORU �al��anlar tablosunda Unvan� 'Mr.' olanlar� 'Bay' olarak g�ncelleyiniz...
	  UPDATE Employees
	  SET TitleOfCourtesy = 'Bay'
	  WHERE TitleOfCourtesy LIKE 'Mr.'
	  SELECT * FROM Employees 

	  -- 14.SORU Kad�n �al��anlar i�erisinde g�revi Sales Representative olanlar� Sat�� Temsilcisi olarak g�ncelleyiniz...
	  UPDATE Employees
	  SET Title = 'Sat�� Temsilcisi'
	  WHERE Title LIKE 'Sales Representative' AND TitleOfCourtesy = 'Ms.' OR TitleOfCourtesy = 'Mrs.'
	  SELECT * FROM Employees

	  -- 15.SORU �al��anlar tablosundan ID'si 5 olan �al��an� silelim...
	  --Employees tablosunu kopyalay�p Calisanlar tablosu olu�tural�m
	  DELETE FROM Employees 
	  WHERE EmployeeID = '5'
	  SELECT * FROM Employees


	  SELECT *
	  INTO Calisanlar 
	  FROM Employees

	  DELETE FROM Calisanlar 
	  WHERE EmployeeID = '5'
	  SELECT * FROM Calisanlar

	  -- 16.SORU �al��anlar tablosundan unvan� bayan olan �al��anlar� silmek istersek;

	  DELETE FROM Calisanlar 
	  WHERE TitleOfCourtesy = 'Ms.' AND TitleOfCourtesy = 'Mrs.'
	  SELECT * FROM Calisanlar

	  -- 17.SORU �al��anlar tablosundaki T�M verileri silelim...
	  	  DELETE TABLE Calisanlar
	  	  SELECT * FROM Calisanlar

		  -- 18.SORU Calisanlar tablosunu veritaban�ndan silmek i�in:
	  DROP TABLE Calisanlar