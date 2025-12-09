Select *
From located
Left Outer Join country on country.code = located.country
AND country.capital = located.city 
AND country.province = located.province
Left Outer Join religion on religion.country = country.code 
Where sea = 'Pacific Ocean' AND religion.name = 'Muslim' AND religion.percentage > 50;

-- Kein Ergebnis