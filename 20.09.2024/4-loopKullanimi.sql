-- loop kullanımı
-- döngüde kullanılır
do $$
declare
	sayac integer:=1;
begin
	loop
		exit when sayac=5;
		sayac:= sayac+1;
	end loop;
end
$$;