-- karar yapıları

do $$
declare
	sinav1 integer:=85;
	sinav2 integer:=72;
	sinav3 integer:=60;
	ortalama integer;
begin
	ortalama:= (sinav1+sinav2+sinav3)/3;
	raise notice 'Ortalama sonucu: %',ortalama;

	if ortalama>50 then -- parantez yok ve if den sonra then yazıyoruz
		raise notice 'Öğrenci dersten geçti';
	else
		raise notice 'Öğrenci dersten kaldı';
	end if; -- if else bloğu bittikten sonra end if ekleniyor. Yoksa uygulama hata verir.
end
$$;

do $$
declare
	adet integer;
begin 
	adet:= (select count(*) from dersler);
	raise notice 'Ders adet: %',adet;
end
$$;


