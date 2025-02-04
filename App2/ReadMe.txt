
örneği pc'de çalışması için bu kodu sql server ortamında çalıştırınız.. 

use Northwind
go
create table Kategori
(
	KategoriId int identity(1,1) primary key,
	KategoriAdi nvarchar(50),
	Aciklama nvarchar(max)
)
go
insert Kategori
(KategoriAdi,Aciklama)
select CategoryName,Description from Categories
go
select* from Kategori
go
-- tablomuza alan ekleyelim...
alter table Kategori
  add Sira tinyint 

