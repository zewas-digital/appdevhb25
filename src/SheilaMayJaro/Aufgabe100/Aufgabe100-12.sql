Select city.name, city.Population
From encompasses 
Left Outer Join continent on continent.name = encompasses.continent
Left Outer Join country on country.code = encompasses.country
Left Outer Join city on city.country = encompasses.country
Where Continent = 'America'
Order By city.Population DESC
Limit 3;

# name, Population
'Mexico City', '9815795'
'Sao Paulo', '9811776'
'New York', '7322564'




















