-- view kullanımı
--istenilen özelliklere göre verileri sanal tabloda toplayıp kullanıcıya gösterir.
-- uzun sql sorguları yerine kısaca çağırmamıza olanak sağlar
-- sorgu süreleri kısaltılır ve tabloların sorguda gözükmemesini sağlar


--PostgreSQL'de sütun veya tablo adları genellikle küçük harflerde saklanır. 
--Ancak, büyük harf, boşluk veya özel karakterler içeren sütun adları tanımlandığında, 
--bu sütunlara erişirken PostgreSQL'de sütun adı çift tırnak (") içine alınmalıdır. 
--Aksi halde PostgreSQL, sütun adlarını otomatik olarak küçük harfe dönüştürür.

--bolum."fakulteId" -- Büyük harf içerdiği için tırnak içinde
--bolum.fakulteid   -- Çift tırnak olmadan küçük harf olarak kabul edilir. Çevirdiğinde de bulamasa da hata verir.

-- create view DetaylariGetir 
-- as
-- select bolum.id as BolumId,bolum.ad as BolumAdi,fakulte.ad as FakulteAdi from bolum inner join fakulte on bolum."fakulteId" = fakulte.id

select * from detaylarigetir -- view in çağırılması

--alter view yok
--create or replace view detaylarigetir as select bolum.id .... diyip de yapabilirsin
drop view if exists detaylarigetir; --ya da önce silip daha sonra yeniden oluşturabilirsin.
create view DetaylariGetir
as
select bolum.id as BolumId,bolum.ad as BolumAdi,fakulte.ad as FakulteAdi, dersler.dersadi 
from 
bolum inner join fakulte on bolum."fakulteId" = fakulte.id
inner join dersler on bolum.id = dersler.bolumid


-- drop view
--drop view detaylarigetir view i silmek için


