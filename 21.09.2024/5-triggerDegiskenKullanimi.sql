-- triggerda değişken kullanımı
-- create table toplamfakulte2 (
-- 	sayi integer
-- )

--select * from toplamfakulte2

create or replace function testTriggerFakulte()
returns trigger
as
$$
	declare 
		uzunluk integer;
begin
	uzunluk:= (select length(ad) from fakulte order by id desc limit 1);
	update toplamfakulte2 set sayi= sayi + uzunluk;
	return new;
end
$$
language plpgsql;

create trigger testTrig
after insert
on fakulte
for each row
execute procedure testTriggerFakulte();



