CREATE DATABASE BankaMaratonDB

USE BankaMaratonDB

CREATE TABLE Sube (
SubeID INT PRIMARY KEY,
SubeAdi VARCHAR(50) NOT NULL,
);

CREATE TABLE Musteri (
MusteriID INT PRIMARY KEY,
MusteriAdiSoyadi VARCHAR(50) NOT NULL,
);

CREATE TABLE HesapParaBirimi(
HesapParaBirimiID INT PRIMARY KEY,
HesapParaBirimi NVARCHAR(50)
)

CREATE TABLE Hesap (
HesapID INT PRIMARY KEY IDENTITY(1,1),
HesapNo AS CONCAT(SubeID, ' ', MusteriID, ' ', HesapParaBirimiID), 
HesapParaBirimiID INT FOREIGN KEY REFERENCES HesapParaBirimi(HesapParaBirimiID),
MusteriID INT FOREIGN KEY REFERENCES Musteri(musteriID),
SubeID INT FOREIGN KEY REFERENCES Sube(SubeID),
);

CREATE TABLE IslemParaBirimi (
IslemTuruID INT IDENTITY(1,1) PRIMARY KEY,
IslemTuru NVARCHAR(50) NOT NULL
);

CREATE TABLE IslemLokasyon(
IslemLokasyonID INT IDENTITY(1,1) PRIMARY KEY,
IslemLokasyon NVARCHAR(50),
);

CREATE TABLE Islem (
IslemID INT PRIMARY KEY,
Miktar MONEY,
IslemTuruID INT FOREIGN KEY REFERENCES IslemParaBirimi(IslemTuruID),
IslemLokasyonID INT FOREIGN KEY REFERENCES IslemLokasyon(IslemLokasyonID),
Tarih DATE,
HesapID INT FOREIGN KEY REFERENCES Hesap(HesapID)
);

INSERT INTO Sube VALUES
(67, 'Zonguldak'),
(74, 'Bartın'),
(78, 'Karabük')

INSERT INTO Musteri (MusteriID, MusteriAdiSoyadi) VALUES 
(100, 'Ali Kara'),
(101, 'Ayşe Sarı')


INSERT INTO HesapParaBirimi(HesapParaBirimiID, HesapParaBirimi) VALUES
(10, 'TL'),
(11, 'Euro'),
(12, 'USD')

INSERT INTO Hesap(HesapParaBirimiID, MusteriID, SubeID) VALUES
(10, 100, 74),
(11, 100, 67),
(12, 101, 78),
(10, 101, 74)

INSERT INTO Islem(IslemID, Miktar,  Tarih) VALUES
(100001, 400, '2023-01-02'),
(100002, 200,  '2023-01-25'),
(100003, 89,  '2023-01-20'),
(100025, 200,   '2023-01-15'),
(100058, 100,   '2023-02-02'),
(101005, 200,  '2023-01-20'),
(101048, 115,   '2023-01-20')

INSERT INTO IslemParaBirimi(IslemTuru) VALUES
('Çekme'),
('Yatırma'),
('Fatura Ödeme')

INSERT INTO IslemLokasyon (IslemLokasyon) VALUES
('ATM'),
('Internet'),
('Sube')


CREATE VIEW HesapIslemBilgileri AS
SELECT
CONCAT(Sube.SubeID, ' ', Musteri.MusteriID, ' ', HesapParaBirimi.HesapParaBirimiID) AS HesapNo,
Musteri.MusteriAdiSoyadi AS Musteri,
Sube.SubeAdi AS Sube,
HesapParaBirimi.HesapParaBirimi AS ParaBirimi,
Islem.Miktar AS IslemMiktari,
IslemParaBirimi.IslemTuru AS IslemTuru,
IslemLokasyon.IslemLokasyon AS IslemLokasyonu,
Islem.Tarih AS IslemTarihi
FROM
Hesap
JOIN Musteri ON Hesap.MusteriID = Musteri.MusteriID
JOIN Sube ON Hesap.SubeID = Sube.SubeID
JOIN HesapParaBirimi ON Hesap.HesapParaBirimiID = HesapParaBirimi.HesapParaBirimiID
JOIN Islem ON Hesap.HesapID = Islem.HesapID
JOIN IslemParaBirimi ON Islem.IslemTuruID = IslemParaBirimi.IslemTuruID
JOIN IslemLokasyon ON Islem.IslemLokasyonID = IslemLokasyon.IslemLokasyonID;