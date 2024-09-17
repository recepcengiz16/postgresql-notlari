-- having: group by kullanırken şart yazmak için vardır. where ile yazamazsın group by kullandığında
select sehir,count(*) from musteri group by sehir having count(*)>1;

select avg(bakiye) as ortalama,sehir from musteri group by sehir having avg(bakiye)>7000 and sehir like '%a%'