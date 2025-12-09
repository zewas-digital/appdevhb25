-- Wie viele Einwohner hat der Kontinent Europa?
SELECT encompasses.Continent, SUM(country.Population)
AS Einwohneranzahl FROM encompasses 
JOIN Country ON encompasses.country = Country.code
WHERE Continent = 'Europe'
GROUP BY encompasses.Continent;

-- Mit Berücksichtigung von Ländern, die nicht zu 100% in Europa liegen
SELECT encompasses.Continent, 
ROUND(SUM(country.Population * (encompasses.Percentage / 100)))
AS Einwohneranzahl FROM encompasses 
JOIN Country ON encompasses.country = Country.code
WHERE Continent = 'Europe'
GROUP BY encompasses.Continent;