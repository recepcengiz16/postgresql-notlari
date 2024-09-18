--insert into fakulte values(3,'İibf')

--insert into bolum values(8,'Metalurji',1)

--select count(*),fakulte.ad from bolum inner join fakulte on bolum."fakulteId" = fakulte.id group by fakulte.ad

select count(*),fakulte.ad from bolum 
inner join fakulte on bolum."fakulteId" = fakulte.id 
group by fakulte.ad order by count(*) desc limit 1 -- en fazla bölümü olan fakulte nedir