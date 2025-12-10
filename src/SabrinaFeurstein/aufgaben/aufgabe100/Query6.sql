-- Alle Flüsse die durch Europa fließen (nur Flüsse und deren Länge), sortiert nach Länge
SELECT geo_river.River, river.Length AS Length FROM geo_river 
JOIN encompasses ON geo_river.Country = encompasses.Country
JOIN river ON geo_river.River = river.Name
WHERE continent = 'Europe'
GROUP BY geo_river.River
ORDER BY river.Length;