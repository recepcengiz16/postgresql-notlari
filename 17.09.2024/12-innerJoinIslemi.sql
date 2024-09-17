-- join: iki tabloyu birleştirmede kullanılır. 

--inner join: iki tabloyu birleştirmede kullanılır. Kesişim kümesine göre birleştirir.

select musteri.ad,soyad,sehir,meslekler.ad from musteri inner join meslekler on musteri.meslek = meslekler.id