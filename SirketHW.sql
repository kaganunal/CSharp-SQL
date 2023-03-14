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
CONSTRAINT PK_Il PRIMARY KEY (IlID)
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
BaslamaTarihi DATE,
BitisTarihi DATE,
CONSTRAINT PK_Proje PRIMARY KEY (ProjeAd)
)

CREATE TABLE Personel(
PersonelTC BIGINT,
PersonelAdi NVARCHAR(50),
PersonelSoyadi NVARCHAR(50),
Cinsiyet NVARCHAR(50),
DogumTarihi DATE,
DogumYeri NVARCHAR(50),
BaslamaTarihi DATE,
BirimNo INT,
UnvanNo INT,
Maas MONEY,
Prim MONEY,
CONSTRAINT PK_Personel PRIMARY KEY (PersonelTC),
CONSTRAINT FK_Unvan_Personel FOREIGN KEY (UnvanNo)
    REFERENCES Unvan(UnvanNo),
CONSTRAINT FK_Birim_Personel FOREIGN KEY (BirimNo)
    REFERENCES Birim(BirimNo)
)

INSERT INTO Birim (BirimAd)
VALUES 
('Hukuk'), 
('Finans'), 
('Pazarlama'), 
('Planlama'), 
('Proje Yönetimi');


	

