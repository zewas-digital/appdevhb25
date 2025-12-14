-- Welches sind die 3 größten Städte von Amerika (Kontinent)?
SELECT city.Name, city.Population FROM city
JOIN encompasses ON city.Country = encompasses.Country
WHERE encompasses.Continent = 'America'
ORDER BY city.Population DESC
LIMIT 3;