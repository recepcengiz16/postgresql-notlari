-- metinsel fonksiyonlar
--asci: ascii karşılığını getirir.
select ASCII ('A')

--concat: girilen parametreleri birleştiren fonks.
select concat ('Günaydın','Recep','Nasılsın?')

--concat_ws: girilen parametreleri birleştirirken aralarına ilk parametredeki değeri yazar
select concat_ws('-','Günaydın','Recep')

--left: soldan başlayıp kaç karakter alacağını söylüyor
select left('Merhaba Dünya',3) 

--right: sağdan başlayıp kaç karakter alacağını söylüyor
select right('Merhaba',3)

--length: Girilen parametrenin kaç karakter olduğunu söylüyor.
select length('Hayat zannettiğin halat; yalnız bulunduğun dakikadır.')

--replace: Girilen veride istenilen karakterle değiştirir verilen karakteri.
select replace('Merhaba','a','e')

--reverse: Girilen veriyi tersten yazmaya yarıyor
select reverse('Deneme')

--substring: istediğimiz karakterden başlayıp, istediğimiz karakter sayısı kadar bize getiriyor
select SUBSTRING('Recep Cengiz',4,2) --saymaya sıfırdan değil 1 den başlıyor.



