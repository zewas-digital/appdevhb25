-- 1. Wie viele Einwohner hat Österreich?
Select population FROM Country
WHERE name = "Austria";

-- 8023244


-- 2. Welche Flüsse fließen durch Österreich?
Select river FROM geo_river
Where country = "A"
Group BY river;

-- Raab
-- Drau
-- Donau
-- March
-- Enns
-- Mur
-- Salzach
-- Inn
-- Isar
-- Lech
-- Iller
-- Rhein


-- 3. Alle Länder die mit einem A anfangen
Select name FROM country
Where name like "A%";

-- Afghanistan
-- Albania
-- Algeria
-- American Samoa
-- Andorra
-- Angola
-- Anguilla
-- Antigua and Barbuda
-- Argentina
-- Armenia
-- Aruba
-- Australia
-- Austria
-- Azerbaijan


--4. Wie viele Einwohner hat der Kontinent Europa?
Select encompasses.continent, sum(Country.population) AS Population From encompasses
Join country on encompasses.country = country.code
Where continent = 'Europe';

-- Europe	791243404


-- 5. Welche Flüsse fließen durch Europa (nur den Flussnamen)?

Select country.name, geo_river.river From country
Join geo_river on country.code = geo_river.country
Join encompasses on country.code = encompasses.country 
Where continent = 'Europe';


-- 6. Alle Flüsse die durch Europa fließen (nur Flüsse und deren Länge), sortiert nach Länge
Select geo_river.river, river.length From geo_river
Join encompasses on geo_river.country = encompasses.country
Join river on geo_river.river = river.name 
Where continent = 'Europe'
Group By geo_river.river;


-- 7. Alle Länder die mit einem A anfangen und deren Bundesländer mit Einwohnerzahl, sortiert nach Einwohnerzahl
Select country.name, province.name, province.population FROM country
join province ON country.code = province.country
Where country.name like "A%"
Order By province.population DESC;


-- 8. Was ist der größte Berg von Österreich? Wie hoch ist er?
Select mountain.name, mountain.height FROM geo_mountain
join Mountain ON geo_mountain.mountain = mountain.name
Where geo_mountain.country = 'A'
Order By mountain.height DESC
Limit 1;

-- Grossglockner	3797


-- 9. Alle Inseln im Pazifik mit >50% islamischem Bekenntnis
Select * from geo_island
Join islandin on geo_island.island = islandin.island 
join religion on geo_island.country = religion.country
Where sea LIKE "Pacific%"
AND percentage >50
AND name = "muslim";

-- New Guinea	RI	Indonesia	New Guinea	Pacific Ocean			RI	Muslim	87


-- 10. Alle 3000er, welche in einem Land sind, welches zu mindestens 60% römisch Katholisch ist
Select geo_mountain.country, geo_mountain.mountain, mountain.height from geo_mountain
Join mountain on geo_mountain.mountain = mountain.name 
join religion on geo_mountain.country = religion.country
Where height > 2999 
AND height < 3999
And religion.name = "Roman Catholic"
And religion.percentage >= 60;