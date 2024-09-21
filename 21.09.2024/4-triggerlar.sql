-- triggerlar 

-- bir tabloda bir crud işlemi yapıldığında bir başka tablonun veya aynı tablonun bundan etkilenmesidir.
-- triggerda önce bir fonksiyon oluşturuluyor. Bu fonksiyonda yapılacak işlem belirleniyor. Sonrasında da trigger oluşturuluyor.

create or replace function trigger_test()
returns trigger -- trigger dönsün
as
$$
begin
	update toplamfakulte set sayi = sayi +1;
	return new; --yeni değeri döndürsün bize
end
$$
language plpgsql;

create trigger test_trigger
after insert -- trigger ne zaman çalışacak
on fakulte--hangi tabloda insert işlemi yapıldıktan sonra çalışsın peki
for each row -- her satır için
execute procedure trigger_test(); -- bunu çalıştır.

select * from fakulte
select * from toplamfakulte

insert into fakulte values(7,'Eğitim')