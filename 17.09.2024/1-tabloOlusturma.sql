-- yorum satırı yapmak için bu şekilde 

-- tablo oluşturma
-- create table urun (
-- 	id integer primary key not null GENERATED ALWAYS AS IDENTITY, -- bu şekilde de identity oluyor.
-- 	ad varchar(15) not null,
-- 	marka varchar(20),
-- 	stok integer,
-- 	kategori varchar(15)
-- )

create table kategori (
	id integer primary key not null generated always as identity,
	ad text
)

-- DELETE sadece veri temizlemek için, DROP ise tablo veya diğer veritabanı nesnelerini tamamen kaldırmak için kullanılır.
-- drop table kategori
