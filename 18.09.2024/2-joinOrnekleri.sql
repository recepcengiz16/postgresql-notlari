-- left join örnekleri
select bolum.id,bolum.ad as BolumAdi,fakulte.ad as FakulteAdi  from bolum left join fakulte on bolum."fakulteId"=fakulte.id;

--right join örnekleri
select bolum.id,bolum.ad as BolumAdi,fakulte.ad as FakulteAdi from bolum right join fakulte on fakulte.id = bolum."fakulteId"

--full join: İki tarafta da null olsa da kayıtları getiriyor.
select musteri.ad,soyad,sehir,meslekler.ad from musteri full join meslekler on musteri.meslek = meslekler.id

--cross join: çaprazlama ile verilerin bütün olasılıklarını yapıyor. Yani a tablosunda 5 veri b tablosunda 4 veri varsa cross joinle 20 veri getiriyor.
select bolum.ad as BolumAdi,fakulte.ad as FakulteAdi from bolum cross join fakulte