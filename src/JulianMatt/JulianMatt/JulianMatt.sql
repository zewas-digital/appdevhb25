use Mondial;

Select Distinct gr.river, gr.country, r.length
From geo_river gr
Left Join River r On r.name = gr.river
Where gr.country = "A"
Order by r.length DESC;