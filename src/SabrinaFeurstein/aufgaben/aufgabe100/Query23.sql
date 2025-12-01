-- Erstelle das Land Transnistrien. 
-- Es liegt in Europa. Wenn du anschließend 
-- alle europäischen Staaten inkl. Namen selektierst, 
-- soll auch Transnistrien in der Ergebnisliste sein.
INSERT INTO country 
VALUES ('Transnistria', 'PMR', 'Tiraspol', 'Transnistria', 4163, 450000);
INSERT INTO encompasses (Country, Continent)
VALUES ('PMR', 'Europe');

SELECT * FROM encompasses 
JOIN country ON country.Code = encompasses.Country 
WHERE Continent = 'Europe';