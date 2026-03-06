--Database Oluþturduk
create database MiniERP;
Go
--Database içerisine girdik
Use MiniERP;
Go
--Tablolarý sýrayla oluþturuyoruz
Create Table Products
(
	Id int IDENTITY(1,1) PRIMARY KEY,
	Name nvarchar (200) not null,
	Price Decimal(18, 2) not null,
	Stock int not null,
	IsActive bit default 1
);
GO

Create Table Customers
(
	Id int IDENTITY(1,1) PRIMARY KEY,
	FullName nvarchar(200) not null,
	Phone nvarchar(50) not null,
	Email nvarchar(200) null,
	IsActive bit default 1
);
GO

Create Table Sales
(
	Id int identity(1,1) primary key,
	CustomerId int not null,
	SaleDate datetime not null,
	TotalAmount decimal(18,2) not null,

	Constraint FK_Sales_Customers
	Foreign Key (CustomerId) references Customers(Id)
);
Go

Create Table SalesItems
(
	Id int identity(1,1) primary key,
	SaleId int not null,
	ProductId int not null,
	Quantity int not null,
	UnitPrice decimal(18,2) not null,
	LineTotal decimal(18,2) not null,

	Constraint FK_SalesItems_Sales
	Foreign key (SaleId) references Sales(Id),
	Constraint FK_SalesItems_Products
	Foreign key (ProductId) references Products(Id)
);





 /*
MiniERP Veritabaný Tasarýmý Açýklamasý

Bu veritabaný, basit bir ERP sisteminin temel modüllerini simüle etmek amacýyla tasarlanmýþtýr.
Sistem ürün yönetimi, müþteri yönetimi ve satýþ iþlemlerini kapsayan dört temel tablo içerir.

Products
Ürün bilgilerini tutar. Ürün adý, fiyatý ve mevcut stok miktarý burada saklanýr.
IsActive alaný sayesinde ürünler sistemden silinmeden pasif hale getirilebilir.

Customers
Müþteri bilgilerini tutar. Müþterinin adý, telefon numarasý ve e-posta adresi gibi bilgiler saklanýr.
IsActive alaný müþterinin aktif olup olmadýðýný belirtmek için kullanýlýr.

Sales
Satýþ iþleminin genel bilgilerini tutar. Hangi müþteriye satýþ yapýldýðý, satýþ tarihi ve toplam tutar
bu tabloda yer alýr. Bu tablo satýþýn "baþlýk" bilgisini temsil eder.

SalesItems
Satýþýn detaylarýný tutar. Her satýþ birden fazla ürün içerebileceði için satýþýn içindeki ürünler
bu tabloda satýr satýr saklanýr. Satýlan ürün, adet, birim fiyat ve satýr toplamý burada bulunur.

Bu yapý sayesinde satýþýn genel bilgileri ile satýþýn ürün detaylarý birbirinden ayrýlarak
veri tekrarýnýn önüne geçilir ve iliþkisel veritabaný tasarým prensiplerine uygun bir yapý oluþturulur.

Bu tablolar foreign key iliþkileri ile birbirine baðlanarak veri bütünlüðü saðlanmýþtýr.
*/