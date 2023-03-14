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
('Proje Y�netimi');

INSERT INTO Unvan(Unvan)
VALUES 
('M�hendis'), 
('IK Uzman�'), 
('Teknisyen'), 
('Mimar'), 
('Temizlik G�revlisi'),
('M�d�r Yard�mc�s�'),
('Asistan'),
('Sekreter'),
('Denetmen'),
('M�d�r');

INSERT INTO Il(IlId, IlAd)
VALUES 
(06,'Ankara'), 
(16,'Bursa'), 
(07,'Antalya'), 
(26,'Eski�ehir'), 
(34,'�stanbul'),
(35,'�zmir'),
(48,'Mu�la'),
(10,'Bal�kesir'),
(45,'Manisa'),
(09,'Ayd�n');

INSERT INTO Ilce(IlceAd, IlId)
VALUES 
('Polatl�', 06), 
('MustafaKemalPa�a', 16), 
('Edremit', 10), 
('Kad�k�y', 34), 
('Bornova', 35 ),
('Ortaca', 48),
('Didim',09),
('Odun Pazar�', 26),
('Manavgat', 07),
('Soma', 45);

INSERT INTO Proje(ProjeAd, IlId, BaslamaTarihi, BitisTarihi)
VALUES 
('Ak�ll��ehir Ankara', 06, '2020-10-21', '2023-08-15'), 
('Ak�ll��ehir Bursa', 16 , '2020-10-21', '2023-08-15'), 
('Ak�ll��ehir Bal�kesir', 10, '2020-10-21', '2023-08-15'), 
('Ak�ll��ehir �stanbul', 34, '2020-10-21', '2023-08-15'), 
('Ak�ll��ehir Mu�la', 48, '2020-10-21', '2023-08-15'),
('Ak�ll��ehir Ayd�n', 09, '2020-10-21', '2023-08-15' ),
('Ak�ll��ehir Eski�ehir', 26, '2020-10-21', '2023-08-15'),
('Ak�ll��ehir Antalya', 07, '2020-10-21', '2023-08-15'),
('Ak�ll��ehir Manisa', 45, '2020-10-21', '2023-08-15');


INSERT INTO Personel(PersonelTC ,PersonelAdi ,PersonelSoyadi ,Cinsiyet ,DogumTarihi ,DogumYeri ,BaslamaTarihi ,ProjeAd ,BirimNo, UnvanId, Maas, Prim)
VALUES 
('12345678910', 'Ahmet', 'Huneroz', 'Erkek', '1967-8-10', '�orum', '2000-10-15', 'Ak�ll��ehir Ankara', 4, 1, 13000, 600 ),
('12345678912', 'Caglar', 'Huneroz', 'Erkek', '1999-03-10', 'Ankara', '2022-10-05', 'Ak�ll��ehir Bursa', 2, 1, 21000, 1000 ),
('12345678922', 'O�uz Ka�an', '�nal', 'Erkek', '1998-10-21', 'Karab�k', '2023-03-05', 'Ak�ll��ehir Bal�kesir', 3, 3, 14000, 700 ),
('1234567333', 'Yelda', 'Arl�', 'Kad�n', '2000-02-14', 'K�rklareli', '2021-03-05', 'Ak�ll��ehir �stanbul', 1, 2, 10000, 800 ),
('12345672345', 'Helin', 'Kayaba�', 'Kad�n', '1998-11-27', 'Ankara', '2021-02-05', 'Ak�ll��ehir Mu�la', 4, 10, 48000, 2500 ),
('12345675689', 'Berfin Deniz', 'Akko�', 'Kad�n', '1998-08-07', 'Ankara', '2021-02-05', 'Ak�ll��ehir Manisa', 4, 5, 8500, 200 ),
('12345625478', 'Sena', 'A��kal�n', 'Kad�n', '1998-03-15', '�ank�r�', '2019-02-05', 'Ak�ll��ehir Ayd�n', 5, 2, 20000, 800 ),
('12345665245', '�pek', 'Aydo�an', 'Kad�n', '1997-03-15', '�zmir', '2015-02-05', 'Ak�ll��ehir Eski�ehir', 3, 8, 8500, 100 ),
('12345675368', 'Mehmet Erdem', 'Oran', 'Erkek', '1998-01-04', 'Adana', '2022-02-05', 'Ak�ll��ehir Antalya', 4, 9, 40000, 500 );