Select Sum(Population), Continent
from country 
Left Outer join encompasses on country.code = encompasses.country
Where Continent = 'Europe'
Group By Continent;

# Sum(Population), Continent
'791243404', 'Europe'







