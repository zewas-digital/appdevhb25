-- Alle Länder die mit einem A anfangen und deren Bundesländer 
-- mit Einwohnerzahl, sortiert nach Einwohnerzahl
SELECT country.Name AS Country, province.Name AS Province, province.Population FROM country 
JOIN province ON country.Code = province.Country
WHERE country.Name LIKE 'A%'
ORDER BY province.Population;