-- Welches sind die 3 größten Städte von Amerika (Kontinent)?
SELECT city.Name, city.Population FROM city
JOIN encompasses ON city.Country = encompasses.Country
JOIN country ON encompasses.Country = country.Code
WHERE encompasses.Continent = 'America'
ORDER BY city.Population DESC
LIMIT 3;