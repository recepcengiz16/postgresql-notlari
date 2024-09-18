-- create table kitaplar (
-- 	id integer primary key not null,
-- 	ad varchar(50) not null,
-- 	yazar varchar(40) not null,
-- 	tarih date not null
-- )

--insert into kitaplar values(5,'İki Şehrin Hikayesi','Charles Dickes','2024-09-17')

--select * from kitaplar

--current_date: bugünün tarih değerini getiriyor.
select current_date;

--current_time: şu anki çalıştığı zamanı veriyor
select current_time;

--now: şu anı tarih ve zaman şeklinde veriyor
select now();

--age: iki tarih arasındaki farkı veriyor yıl, ay ve gün bazında verebiliyor. timestamp vermen gerekli
select age(timestamp '2023-08-10');
--Kodunda timestamp '2023-08-10' ifadesi, belirtilen tarihin saat kısmı olmadan tam tarih ve zaman biçiminde ele alınmasını sağlar. Yani, 10 Ağustos 2023 tarihini tam bir zaman damgası olarak kullanıyorsun. age() fonksiyonu bu zaman damgasını alarak, geçerli tarih ile 10 Ağustos 2023 arasındaki farkı hesaplar.
select ad,tarih,age(now(),tarih) from kitaplar
SELECT age('2024-09-12', '1990-05-15');

