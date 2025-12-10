-- Einzelne Lösungen aus der Aufgabe 100 -------------------------------

-- 1. Wie viele Einwohner hat Österreich?
SELECT Population FROM country WHERE Code='A';

-- 2. Welche Flüsse fließen durch Österreich?
SELECT Country.Name, River.Name 
FROM Country, Geo_river, River
WHERE Country.Code = Geo_river.Country
AND Geo_river.River = River.Name
AND Country.Name = 'Austria';

-- 5. Welche Flüsse fließen durch Europa (nur den Flussnamen)?
/* 
Da Flüsse durch mehrere Regionen und/oder Länder fließen kann, 
erhalten wir mehrere Einträge für diese Flüsse
und müssen das Ergebnis durch DISTINCT oder GROUP BY 
auf ein eindeutiges Ergebnis zusammenführen
*/
SELECT DISTINCT river.Name 
FROM continent, encompasses, country, province, geo_river, river
WHERE 
continent.Name = encompasses.Continent
AND encompasses.Country = country.Code
AND country.Code = province.Country
AND province.Name = geo_river.Province
AND river.Name = geo_river.River
AND continent.Name LIKE 'Europe'
-- GROUP BY river.Name
ORDER by river.Name;

-- Zum Vergleich: Lösung mit JOINS
SELECT DISTINCT river.Name FROM continent
INNER JOIN encompasses ON continent.Name = encompasses.Continent
INNER JOIN country ON country.Code = encompasses.Country
INNER JOIN province ON province.Country = country.Code
INNER JOIN geo_river ON geo_river.Province = province.Name
INNER JOIN river ON river.Name = geo_river.River
WHERE continent.Name LIKE 'Europe'
ORDER BY river.Name;

-- 6. Alle Flüsse die durch Europa fließen (nur Flüsse und deren Länge), sortiert nach Länge
SELECT DISTINCT river.name, river.length FROM river
INNER JOIN geo_river ON geo_river.River = river.name
INNER JOIN encompasses ON encompasses.Country = geo_river.Country
WHERE encompasses.Continent LIKE 'Europe'
ORDER BY river.Length DESC;

-- 9. Alle Inseln im Pazifik mit >50% islamischem Bekenntnis
SELECT country.Name, island.name, religion.Percentage 
FROM island, islandin, geo_island, religion, country 
WHERE 
	island.Name = islandin.Island 
    AND islandin.Sea LIKE 'Pacific%' 
    AND geo_island.Island = island.name 
    AND geo_island.Country = religion.Country 
    AND country.code = geo_island.country 
    AND religion.Percentage > 50 
    AND religion.Name = 'Muslim';

-- 10. Alle 3000er, welche in einem Land sind, welches zu mindestens 60% römisch Katholisch ist
SELECT DISTINCT mountain.Name,mountain.Height,religion.Percentage
FROM mountain 
JOIN geo_mountain ON geo_mountain.Mountain = mountain.Name
JOIN religion ON religion.Country = geo_mountain.Country
WHERE 
    mountain.Height >= 3000 
    AND mountain.Height < 4000 
    AND religion.Name = 'Roman Catholic' 
    AND religion.Percentage >= 60  
ORDER BY mountain.Name ASC;