-- Wie viele Einwohner hat der Kontinent Europa?
SELECT SUM(Country.population) AS 'Einwohneranzahl in Europa' FROM encompasses 
JOIN Country ON encompasses.country = Country.code
WHERE Continent = 'Europe';