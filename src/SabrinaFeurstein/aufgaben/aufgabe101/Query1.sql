-- 1. Wie viel Prozent der Menschen leben im Kontinent Europa?
select Continent,
round((select sum(population) from country 
join encompasses on country.code = encompasses.country
where continent = 'Europe') * 100.0 /
(select sum(population) from Country), 2) as 'Population Percentage' 
from encompasses
where continent = 'Europe'
group by continent;