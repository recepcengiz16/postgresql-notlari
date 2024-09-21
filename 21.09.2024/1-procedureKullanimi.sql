-- procedure yazılımı
-- procedure veri tabanında belirli işlemler yaptırdığımız işlemler bütünü

create procedure ekranaYazdir() -- parametre olsa da olmasa da parantez eklemen lazım
language plpgsql
as $$
begin
	raise notice 'İlk procedure ü yazdım.';
end
$$;

-- procedure ü çağırmak için
call ekranaYazdir() 

-- procedure ün güncellenmesi
create or replace procedure ekranaYazdir()
language plpgsql
as $$
begin
	raise notice 'İlk procedure ü yazdım.';
	raise notice '2. satır yazıldı';
end
$$;

-- parametreli procedure oluşturma
create procedure fakulte_ekle(p1 int,p2 text)
language SQL -- sql de diyebiliriz plpgsql de diyebiliriz.
as $$
insert into fakulte values(p1,p2); -- istersek begin end içinde de yazabiliriz.
$$
select * from fakulte

call fakulte_ekle(6,'Besyo');




