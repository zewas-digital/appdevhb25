-- Welche Flüsse fließen durch Österreich?
SELECT river FROM geo_river 
WHERE country = 'A'
GROUP BY river;