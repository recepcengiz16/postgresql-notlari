--aggregate fonksiyonlar

-- COUNT(*): Tablo içerisindeki tüm satırları sayar, 
--satırdaki sütunlar dolu mu boş mu, değer var mı yok mu bakmaz. 
--Tabloda kaç satır olduğunu öğrenmek için kullanılır. 
select count(*) as Toplam from musteri; 

-- SUM(): Belirli bir sütundaki aritmetik ifadelerin toplanması
select sum(bakiye) from musteri where sehir='Ankara';

-- AVG(): Bir sütuna ait olan değerlerin ortalamasını verir.
select avg(bakiye) from musteri

-- MIN() MAX(): Bir tablodaki o sütuna ait min ve max değerleri getirir.
select min(bakiye) from musteri
select max(bakiye) from musteri

