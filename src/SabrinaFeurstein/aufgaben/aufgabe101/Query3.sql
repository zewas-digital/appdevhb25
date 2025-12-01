-- 3. Ändere die Einwohnerzahl der Deutschen Bundesländer: 
-- In jedem Bundesland wohnt zukünftig jeweils 1/16 der Gesamtbevölkerung Deutschlands
update province 
join (
	select country, count(*) as amount
	from province where country = 'D'
) as CountryProvinces
on province.country = CountryProvinces.country
set population = 
(select country.population from country 
where country.code = 'D') / 
CountryProvinces.amount
where province.country = 'D';

select * from province
where country = 'D';