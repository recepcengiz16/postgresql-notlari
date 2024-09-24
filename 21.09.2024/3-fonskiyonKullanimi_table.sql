--select sorgusu içerisinde function çağırılması
--select ad,yazar,fiyat, kdvlifiyat(fiyat) as kdvli from kitaplar

-- tablo döndüren fonksiyonlar
create function kitapgetir(param1 varchar)
returns table 
	(
		idsutun int,
		kitapadsutun varchar,
		kitapyazarsutun varchar
	)
as
$$
begin
	return query --geriye bir sorgu döndür
	select id,ad,yazar from kitaplar where ad like param1;
end
$$
language plpgsql;

select * from kitapgetir('%e%'); -- içinde e harfi geçenleri getir.