-- union ve union all: İki tabloyu birleştirip verileri tek tabloda göstermek için kullanılır.
-- union tabloda birden fazla geçen isimleri de bir kez alıyor, duplicate veri yapmıyor
-- union all ise duplicate verilere de izin veriyor

select * from a
union
select * from b