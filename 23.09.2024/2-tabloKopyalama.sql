-- sorgularla tablo kopyalama

create table new_table as table kategoriler -- as table diyerek hangi tabloyu kopyalacak demiş olduk. verileri ile birlikte yeni tabloya atanmış olacak.

--select * from new_table

create table new_table2 as table kategoriler with no data --sadece tasarım kısmını alıyor. içindeki verileri almıyor. 