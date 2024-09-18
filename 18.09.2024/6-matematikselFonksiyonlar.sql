-- matematiksel fonksiyonlar

--abs: mutlak değer olarak getirir sayısal ifadeyi
select abs(-5);

--ceiling - ceil: parametre olarak gelen ondalıklı sayıyı bir üst sayıya yuvarlıyor.
select ceiling(7.85); select ceil(2.4); -- ikisi de aynı şey

--floor: parametre olarak gelen ondalıklı sayıyı bir alt sayıya yuvarlıyor.
select floor(2.4);

--pi:
select pi();

--power: kuvvet almaya yarıyor. power(taban,üst)
select power(2,4);

--random: 0-1 arasında rastgele ondalıklı sayı getirir.
select random();

--round: ondalıklı sayılarda istenilen basamak kadar yuvarlama işlemi
select round(12.45857567,3); -- virgülden sonra 3 basamaklı olsun

--sign: girilen değerlerin pozitif mi yoksa negatif mi olduğunu gösteriyor
select sign(-1);

--sqrt: karekök alır
select sqrt(16);

--log: logaritmik değerini verir
select log(10)



