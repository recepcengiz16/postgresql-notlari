-- union ve union all: İki tabloyu birleştirip verileri tek tabloda göstermek için kullanılır.
-- union tabloda birden fazla geçen isimleri de bir kez alıyor, duplicate veri yapmıyor
-- union all ise duplicate verilere de izin veriyor

--İki farklı veri kaynağını birleştirirken kullanılır. 
--Örneğin, bir şirkette hem aktif hem de eski çalışanların listesini birleştirip raporlamak istersen:

SELECT isim FROM aktif_calisanlar
UNION
SELECT isim FROM eski_calisanlar;
