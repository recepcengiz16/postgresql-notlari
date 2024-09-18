-- intersect ve except nedir?

--intersect: iki veya daha fazla sorgudan dönen sonuç kümeleri arasında ortak olan satırları bulmak için kullanılır.
--İki tablodaki ortak kesişim yerlerini getiriyor. 
--yalnızca aynı sütun sayısına ve uyumlu veri türlerine sahip sorgular arasında kullanılabilir. 
select bolumAdi from a
intersect
select bolumAdi from b

--except: intersect in tersi olarak farklı olanları getirir, önde yazılı olan sorgunun farkını getirir, kesişenleri değil.

select bolumAdi from a
except
select bolumAdi from b
