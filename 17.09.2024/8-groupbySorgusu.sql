--group by : verileri gruplandırmada kullanılır.

select sehir,count(*) from musteri group by sehir -- o şehirlerdeki kişi sayısı

select sehir,sum(bakiye) from musteri group by sehir 