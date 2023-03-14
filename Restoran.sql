CREATE TABLE MusterilerTablosu(
MusteriID int IDENTITY(1,1) NOT NULL,
MusteriAdi nvarchar(50) NOT NULL,
MusteriSoyadi nvarchar(50) NOT NULL,

PRIMARY KEY (MusteriID)
);


CREATE TABLE MusteriDetaylariTablosu(
MusteriID int UNIQUE ,
CONSTRAINT FK_PersonOrder FOREIGN KEY (MusteriID) REFERENCES MusterilerTablosu(MusteriID),
Adres nvarchar(100), 
TelefonNo nvarchar(15) NOT NULL,
Sehir nvarchar(50),
Ulke varchar(50) DEFAULT 'Türkiye'
);

CREATE TABLE SiparislerTablosu(
SiparisID int IDENTITY(1,1) NOT NULL,
MusteriID int CONSTRAINT FK_PersonTable  FOREIGN KEY (MusteriID) REFERENCES MusterilerTablosu(MusteriID),
YemekSirketi varchar(50) NOT NULL,
Urun varchar(50) NOT NULL,
Adet int NOT NULL,
BirimFiyat money NOT NULL,
ToplamTutar AS (BirimFiyat * Adet),
SiparisTarihi AS GETDATE(),

PRIMARY KEY (SiparisID)
);

INSERT INTO MusterilerTablosu ( MusteriAdi, MusteriSoyadi) VALUES 
('Fatih', 'Bagcioglu'),
('Oguz Kagan', 'Unal'),
('Gokcehan', 'Gucuk'),
('Burak', 'Ozgur'),
('Atakan', 'Bektas')


INSERT INTO MusteriDetaylariTablosu (MusteriID, Adres, TelefonNo, Sehir) VALUES
(1,'Seval Cad. Ayseki Sok. 15/7', '5054755445', 'Ankara'),
(2,'Ankara Cad. 45/2', '5055489865', 'Ankara'),
(3,'Ýran Cad. Kalaba Sok. 8/7', '5054758462', 'Ankara'),
(4,'Seval Cad. Ayseki Sok. 15/7', '5054755445', 'Ankara'),
(5,'Seval Cad. Ayseki Sok. 15/7', '5054755445', 'Ankara')

SELECT * FROM MusterilerTablosu
SELECT * FROM MusteriDetaylariTablosu
SELECT * FROM SiparislerTablosu