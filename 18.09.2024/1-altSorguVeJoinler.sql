--insert into fakulte values(3,'İibf')

--insert into bolum values(8,'Metalurji',1)

--select count(*),fakulte.ad from bolum inner join fakulte on bolum."fakulteId" = fakulte.id group by fakulte.ad

--PostgreSQL'de sütun ve tablo adlarında büyük/küçük harf duyarlılığı ile ilgili bir kural vardır: 
--eğer bir sütun adı çift tırnak içinde yazılırsa("fakulteId" gibi), büyük/küçük harf duyarlılığı korunur. 
--Aksi takdirde, PostgreSQL sütun ve tablo adlarını otomatik olarak küçük harfe çevirir ve sütun bulunamazsa hata verir.

Kodda "fakulteId" sütunu çift tırnak içinde yazıldığı için, bu sütun adı büyük/küçük harfe duyarlıdır ve veritabanında tam olarak "fakulteId" olarak tanımlanmıştır. Eğer çift tırnak kullanılmasaydı, PostgreSQL bu sütun adını otomatik olarak küçük harfe dönüştürerek fakulteid olarak yorumlardı.

select count(*),fakulte.ad from bolum 
inner join fakulte on bolum."fakulteId" = fakulte.id 
group by fakulte.ad order by count(*) desc limit 1 -- en fazla bölümü olan fakulte nedir