-- 1. Wie viel Prozent der Menschen leben im Kontinent Europa?
-- Sum von Global und Sum Europe  - 2 subselects
Select (
    (
        Select SUM(population)
        From country
        Join encompasses ON country.code = encompasses.country
        Where encompasses.continent = 'Europe') / (
            Select Sum(population) 
            From country
            )
)*100 AS Prozentsatz;
-- 13.7152


-- 2. Was ist der größte Berg pro Kontinent? Wie hoch sind diese?
-- DISTINCT = „Zeige jede Zeile nur einmal“.
Select DISTINCT mountain.name, mountain.height, encompasses.continent
From mountain
Join geo_mountain ON mountain.name = geo_mountain.mountain
Join encompasses  ON geo_mountain.country = encompasses.country
Where mountain.height = 
    (Select MAX(mountain.height)
    From mountain
    Join geo_mountain ON mountain.name = geo_mountain.mountain
    Join encompasses e ON geo_mountain.country = e.country
    Where encompasses.continent = e.continent)
Order By encompasses.continent;

-- Kilimanjaro	    5895	Africa
-- Aconcagua	    6962	America
-- Mount Everest	8848	Asia
-- Puncak Jaya	    4884	Australia/Oceania
-- Elbrus	        5642	Europe


-- 3. Ändere die Einwohnerzahl der Deutschen Bundesländer: 
-- In jedem Bundesland wohnt zukünftig jeweils 1/16 der Gesamtbevölkerung Deutschlands

-- With provincen (name, country)
-- AS (
--     Select name, country
--     From province
--     Where country = (
-- 	    Select country.code 
--         From country 
--         Where country.name = 'Germany')
--     )
-- Select *
-- From province;

Update province
Set population = (
	Select country.population / 16
    From country 
    Where country.name = 'Germany')
Where country = (
	Select country.code 
    From country 
    Where country.name = 'Germany');

WITH provincen (name, country)
AS (
    Select name, country
    From province
    Where country = (
	    Select country.code 
        From country 
        Where country.name = 'Germany')
    )
Update p
Set population = (
	Select country.population / 16
    From country 
    Where country.name = 'Germany')
-- FROM province as p
-- Join provincen ON p.country = provincen.country
-- AND p.name = provincen.name;



