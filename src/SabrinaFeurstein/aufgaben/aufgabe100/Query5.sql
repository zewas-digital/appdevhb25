-- Welche Flüsse fließen durch Europa (nur den Flussnamen)?
SELECT river FROM geo_river 
JOIN encompasses ON geo_river.country = encompasses.country
WHERE Continent = 'Europe'
GROUP BY river;