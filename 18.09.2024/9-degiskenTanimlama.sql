-- değişken tanımlama
--PostgreSQL'de doğrudan PL/pgSQL dilini kullanarak bir değişken tanımlayabilirsiniz. 
--Bu, genellikle bir fonksiyon veya bir blok (anonim blok) içinde yapılır.

--Değişken tanımlayabilmek için DO$$ ile başlamamız gerekiyor.
--Declare kısmında ya da begin end blokları arasında değişkenimizin adını ve  veri tipini yazıyor ve değerini := ile tanımlıyoruz.
--RAISE NOTICE dan  sonra ‘%’ işareti tanımlanan değişken yazılarak değişkenin çıktısı ekrana yazdırılabilir.

DO $$ --Anonim bir PL/pgSQL bloğu çalıştırır.
DECLARE --Değişkenleri burada tanımlarsınız.
    my_variable INTEGER := 10; --my_variable adında bir tam sayı değişkeni tanımlanıyor ve başlangıç değeri 10 olarak atanıyor.
BEGIN
    RAISE NOTICE 'Değişkenin değeri: %', my_variable; -- değişkenin çıktısı ekrana yazdırır.
END $$; -- anonim kod bloğu bitişi

do $$
declare
	x integer := 20;
	y integer := 15;
	toplam integer;
	fark integer;
	carpim integer;
	bolum integer;
begin
	toplam := x+y;
	fark := x-y;
	carpim := x*y;
	bolum := x/y;

	raise notice 'Toplam: %', toplam;
	raise notice 'Fark: %', fark;
	raise notice 'Çarpım: %', carpim;
	raise notice 'Bölüm: %', bolum;
end $$
	
