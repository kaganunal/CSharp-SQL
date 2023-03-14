USE SirketDB

CREATE TABLE Birim (
BirimNo INT IDENTITY(1,1),
BirimAd NVARCHAR(50) UNIQUE,
CONSTRAINT PK_Birim PRIMARY KEY (BirimNo)
)

CREATE TABLE Unvan (
UnvanId INT IDENTITY(1,1),
Unvan NVARCHAR(50) NOT NULL,
CONSTRAINT PK_Unvan PRIMARY KEY (UnvanId)
)

CREATE TABLE Il (
IlId INT ,
IlAd NVARCHAR(50),
CONSTRAINT PK_Il PRIMARY KEY (IlId)
)

CREATE TABLE Ilce (
IlceNo INT IDENTITY(1,1),
IlceAd NVARCHAR(50),
IlId INT,
CONSTRAINT PK_Ilce PRIMARY KEY (IlceNo),
CONSTRAINT FK_Il_Ilce FOREIGN KEY (IlId)
    REFERENCES Il(IlId)
)

CREATE TABLE Proje (
ProjeAd NVARCHAR(50),
IlId INT,
BaslamaTarihi DATE,
BitisTarihi DATE,
CONSTRAINT PK_Proje PRIMARY KEY (ProjeAd),
CONSTRAINT FK_Il_Proje FOREIGN KEY (IlId)
    REFERENCES Il(IlId)
)

CREATE TABLE Personel(
PersonelTC BIGINT,
PersonelAdi NVARCHAR(50),
PersonelSoyadi NVARCHAR(50),
Cinsiyet NVARCHAR(50),
DogumTarihi DATE,
DogumYeri NVARCHAR(50),
BaslamaTarihi DATE,
ProjeAd NVARCHAR(50),
BirimNo INT,
UnvanId INT,
Maas MONEY,
Prim MONEY,
CONSTRAINT PK_Personel PRIMARY KEY (PersonelTC),
CONSTRAINT FK_Unvan_Personel FOREIGN KEY (UnvanId)
    REFERENCES Unvan(UnvanId),
CONSTRAINT FK_Birim_Personel FOREIGN KEY (BirimNo)
    REFERENCES Birim(BirimNo),
CONSTRAINT FK_Proje_Personel FOREIGN KEY (ProjeAd)
    REFERENCES Proje(ProjeAd)
)

INSERT INTO Birim (BirimAd)
VALUES 
('Hukuk'), 
('Finans'), 
('Pazarlama'), 
('Planlama'), 
('Proje Yönetimi');

INSERT INTO Unvan(Unvan)
VALUES 
('Mühendis'), 
('IK Uzmaný'), 
('Teknisyen'), 
('Mimar'), 
('Temizlik Görevlisi'),
('Müdür Yardýmcýsý'),
('Asistan'),
('Sekreter'),
('Denetmen'),
('Müdür');

INSERT INTO Il(IlId, IlAd)
VALUES 
(06,'Ankara'), 
(16,'Bursa'), 
(07,'Antalya'), 
(26,'Eskiþehir'), 
(34,'Ýstanbul'),
(35,'Ýzmir'),
(48,'Muðla'),
(10,'Balýkesir'),
(45,'Manisa'),
(09,'Aydýn');

INSERT INTO Ilce(IlceAd, IlId)
VALUES 
('Polatlý', 06), 
('MustafaKemalPaþa', 16), 
('Edremit', 10), 
('Kadýköy', 34), 
('Bornova', 35 ),
('Ortaca', 48),
('Didim',09),
('Odun Pazarý', 26),
('Manavgat', 07),
('Soma', 45);

INSERT INTO Proje(ProjeAd, IlId, BaslamaTarihi, BitisTarihi)
VALUES 
('AkýllýÞehir Ankara', 06, '2020-10-21', '2023-08-15'), 
('AkýllýÞehir Bursa', 16 , '2020-10-21', '2023-08-15'), 
('AkýllýÞehir Balýkesir', 10, '2020-10-21', '2023-08-15'), 
('AkýllýÞehir Ýstanbul', 34, '2020-10-21', '2023-08-15'), 
('AkýllýÞehir Muðla', 48, '2020-10-21', '2023-08-15'),
('AkýllýÞehir Aydýn', 09, '2020-10-21', '2023-08-15' ),
('AkýllýÞehir Eskiþehir', 26, '2020-10-21', '2023-08-15'),
('AkýllýÞehir Antalya', 07, '2020-10-21', '2023-08-15'),
('AkýllýÞehir Manisa', 45, '2020-10-21', '2023-08-15');


INSERT INTO Personel(PersonelTC ,PersonelAdi ,PersonelSoyadi ,Cinsiyet ,DogumTarihi ,DogumYeri ,BaslamaTarihi ,ProjeAd ,BirimNo, UnvanId, Maas, Prim)
VALUES 
('12345678910', 'Ahmet', 'Huneroz', 'Erkek', '1967-8-10', 'Çorum', '2000-10-15', 'AkýllýÞehir Ankara', 4, 1, 13000, 600 ),
('12345678912', 'Caglar', 'Huneroz', 'Erkek', '1999-03-10', 'Ankara', '2022-10-05', 'AkýllýÞehir Bursa', 2, 1, 21000, 1000 ),
('12345678922', 'Oðuz Kaðan', 'Ünal', 'Erkek', '1998-10-21', 'Karabük', '2023-03-05', 'AkýllýÞehir Balýkesir', 3, 3, 14000, 700 ),
('1234567333', 'Yelda', 'Arlý', 'Kadýn', '2000-02-14', 'Kýrklareli', '2021-03-05', 'AkýllýÞehir Ýstanbul', 1, 2, 10000, 800 ),
('12345672345', 'Helin', 'Kayabaþ', 'Kadýn', '1998-11-27', 'Ankara', '2021-02-05', 'AkýllýÞehir Muðla', 4, 10, 48000, 2500 ),
('12345675689', 'Berfin Deniz', 'Akkoç', 'Kadýn', '1998-08-07', 'Ankara', '2021-02-05', 'AkýllýÞehir Manisa', 4, 5, 8500, 200 ),
('12345625478', 'Sena', 'Açýkalýn', 'Kadýn', '1998-03-15', 'Çankýrý', '2019-02-05', 'AkýllýÞehir Aydýn', 5, 2, 20000, 800 ),
('12345665245', 'Ýpek', 'Aydoðan', 'Kadýn', '1997-03-15', 'Ýzmir', '2015-02-05', 'AkýllýÞehir Eskiþehir', 3, 8, 8500, 100 ),
('12345675368', 'Mehmet Erdem', 'Oran', 'Erkek', '1998-01-04', 'Adana', '2022-02-05', 'AkýllýÞehir Antalya', 4, 9, 40000, 500 );