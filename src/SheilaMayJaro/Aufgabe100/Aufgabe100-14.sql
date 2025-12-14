Select Count(city.name), country.name
From city
Inner Join country on country.code = city.country
Group By country.name
Having Count(city.name) = 3

# Count(city.name), name
'3', 'Syria'
'3', 'New Zealand'
'3', 'Bolivia'
'3', 'Qatar'
'3', 'Guatemala'





















