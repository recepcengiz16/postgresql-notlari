-- intersect ve except nedir?

--intersect: iki veya daha fazla sorgudan dönen sonuç kümeleri arasında ortak olan satırları bulmak için kullanılır.
--İki tablodaki ortak kesişim yerlerini getiriyor. 
--yalnızca aynı sütun sayısına ve uyumlu veri türlerine sahip sorgular arasında kullanılabilir. 

--Örnek:
--Bir şirketin iki farklı projesinde çalışmış personel listesini bulmak için kullanılabilir. 
--Örneğin, hem "Proje A" hem de "Proje B" üzerinde çalışmış çalışanları bulmak için.
SELECT calisan_id FROM proje_a
INTERSECT
SELECT calisan_id FROM proje_b;

--except: intersect in tersi olarak farklı olanları getirir, önde yazılı olan sorgunun farkını getirir, kesişenleri değil.

select calisan_id from proje_a
except
select calisan_id from proje_b
