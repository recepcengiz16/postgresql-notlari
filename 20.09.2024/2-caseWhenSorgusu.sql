-- case when kullanımı
--akış kontrolü için vardır

select dersadi,bolumid,
	case
		when bolumid=1 then 'Yazılım'
		when bolumid=2 then 'Mekatronik'
		when bolumid=3 then 'Elektronik'
		when bolumid=4 then 'Makine'
		else 'Tıp' --else kullanımı, yani bu şartlar dışındakiler Tıp olacak demiş olduk.
	end duration -- bunu eklememiz lazım, işlem tamamlandı demek
from dersler;