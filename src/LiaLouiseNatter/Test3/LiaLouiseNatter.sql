use mondial;
select distinct river.Length, river.name
from river 
	join geo_river gr 
		on river.name = gr.river
	join province p
		on gr.province = p.name
			And gr.country = p.country
	join country c 
		on p.country = c.code
where c.code = @code
order by river.length desc;




    



