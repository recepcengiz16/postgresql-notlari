--Alt sorgu örnekleri

--select * from musteri where bakiye= (select max(bakiye) from musteri); -- bakiyesi en yüksek oln müşteriyi getir.

--select * from musteri where bakiye=(select max(bakiye) from musteri where sehir='Bursa')

-- create table meslekler (
-- 	id integer primary key not null,
-- 	ad varchar(15) not null
-- )

--insert into meslekler values(3,'Mühendis')

select * from musteri where meslek=(select id from meslekler where ad='Öğretmen')

select * from musteri where sehir='Bursa' and meslek=(select id from meslekler where ad='Öğretmen')
