-- Speichere den höchsten Berg und die Hauptstadt 
-- in die Datenbank. Prüfe die Ergebnisse mit einem SELECT.
INSERT INTO city 
VALUES ('Tiraspol', 'PMR', 'Transnistria', 126306, 29.6, 46.85);
INSERT INTO geo_mountain
VALUES ('Chervonka', 'PMR', 'Transnistria');
INSERT INTO mountain
VALUES ('Chervonka', NULL, 190, NULL, 28.84, 47.95);

SELECT * FROM country 
JOIN city ON country.Code = city.Country 
JOIN geo_mountain ON country.Code = geo_mountain.Country
JOIN mountain ON geo_mountain.Mountain = mountain.Name
WHERE country.Code = 'PMR';