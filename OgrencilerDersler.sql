CREATE TABLE Ogrenciler (

OgrenciID int IDENTITY(1,1) PRIMARY KEY (OgrenciID) NOT NULL,
OgrenciAdi nvarchar(50) NOT NULL,
OgrenciSoyadi nvarchar(50) NOT NULL
)

CREATE TABLE Dersler (
DersID int IDENTITY(1,1) PRIMARY KEY (DersID) NOT NULL,
DersAdi nvarchar(50) NOT NULL,

)

CREATE TABLE OgrencilerDersler (
    OgrenciID int NOT NULL,
    DersID int NOT NULL,
    PRIMARY KEY (OgrenciID, DersID)
)

INSERT INTO Ogrenciler (OgrenciAdi, OgrenciSoyadi) VALUES
('Oguz Kagan', 'Unal'),
('Burak', 'Ozgur'),
('Atakan', 'Bektas'),
('Gokcehan', 'Gucuk')

INSERT INTO Dersler (DersAdi) VALUES
('Matematik'),
('Betonarme'),
('Çelik'),
('Kýyý Liman')

INSERT INTO OgrencilerDersler (OgrenciID, DersID) VALUES
(1,2),
(2,4),
(3,1),
(4,3)

SELECT * FROM Ogrenciler
SELECT * FROM Dersler
SELECT * FROM OgrencilerDersler
