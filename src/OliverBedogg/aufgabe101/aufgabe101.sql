USE Mondial;

-- 1. Wie viel Prozent der Menschen leben im Kontinent Europa? -----------------------

-- Sub-Select: Gesamt-Population
SELECT SUM(Population) as world 
    FROM Country;
    
-- Sub-Select: Population von Europa 
SELECT SUM(Population) as europe 
	FROM Country,encompasses 
	WHERE Country.Code=encompasses.Country AND encompasses.Continent ='Europe';

-- Select aus dem Ergebnis beider Sub-Selects
-- Rechne wie viel Prozent die Europa-Population von der Gesamt-Population sind
SELECT 
	ROUND(world/100000) as 'Gesamt-Population in Mio',
	ROUND(europe/1000000) as 'Population Europa in Mio', 
    ROUND(europe/(world/100), 2) as Prozent
FROM (
	SELECT SUM(Population) as world 
    FROM Country
    ) as w, 
    (
	SELECT SUM(Population) as europe 
	FROM Country,encompasses 
	WHERE Country.Code=encompasses.Country AND encompasses.Continent ='Europe'
	) as e;
