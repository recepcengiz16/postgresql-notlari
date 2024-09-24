-- fonksiyonlar

-- belirli bir işlemler yapıp geriye değer döndürdüğümüz yapılardır. procedurlere benzerler farkı geriye değer döndürmesidir.
create function toplam(p1 int,p2 int)
returns int -- geriye dönüş tipini belirledik
language plpgsql
as
$$
declare
	sonuc integer;
begin
	sonuc:= p1+p2;	
	return sonuc; -- sonuc return edildi
end
$$;

-- fonksiyon çağırımı
select toplam(5,10) -- fonksiyonlarda select kullanılır çağırılırken