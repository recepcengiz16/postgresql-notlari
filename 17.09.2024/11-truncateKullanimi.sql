--truncate kullanımı: Veritabanındaki tabloda bütün değerleri silmek için kullanılır
--Eğer tabloda bir AUTO_INCREMENT sütunu varsa (örneğin, otomatik artan bir ID sütunu), TRUNCATE komutu bu değeri sıfırlar.

truncate table urun
restart identity; -- bu şekilde de ilerleyen autoincrement değerini sıfıra çekiyoruz.
