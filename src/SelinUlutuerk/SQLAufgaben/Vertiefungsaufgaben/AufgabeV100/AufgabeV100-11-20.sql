-- 11. Einwohnerzahl pro Religion
Select religion.name, SUM(religion.percentage/ 100 *country.population) AS PopulationPerReligion 
From religion
Join country on religion.country = country.code
Group By religion.name;


-- 12. Welches sind die 3 größten Städte von Amerika (Kontinent)?
Select city.name, city.population
From encompasses
Join city on encompasses.country = city.country
Where encompasses.continent = "america"
Order by city.population DESC
Limit 3;


-- 13. Das Unabhängigkeitsdatum von Ländern die eine Wüste haben und die ethnische Gruppe African
Select geo_desert.country, politics.independence
From geo_desert
Join politics on geo_desert.country = politics.country
Join EthnicGroup on geo_desert.country = EthnicGroup.country
Where EthnicGroup.name = "African"
group by geo_desert.country;


-- 14. Welche Länder haben genau 3 Städte? Welche Länder sind dies?
SELECT country.name, COUNT(city.name) AS AnzahlStaedte
FROM city
JOIN country ON city.country = country.code
GROUP BY country.name
HAVING COUNT(city.name) = 3;


-- 15. Welche Organisationen haben deren Hauptsitz in Österreich? Wie viele Mitglieder haben diese Organisationen?
SELECT Organization.name, COUNT(isMember.country)
FROM Organization 
JOIN isMember ON Organization.abbreviation = isMember.organization
WHERE Organization.country = 'A'
GROUP BY Organization.name;


-- 16. Alle Länder mit mindestens einem See mit mindestens 100 Meter Tiefe und mindestens einem Berg mit mindestens 1500 Höhenmeter
SELECT Country.name
FROM country 
JOIN geo_sea ON country.code = geo_sea.country
Join geo_mountain ON country.code = geo_mountain.country
Join sea ON geo_sea.sea = sea.name
Join mountain ON geo_mountain.mountain = mountain.name
WHERE sea.depth >= 100
AND mountain.height >= 1500
Group By country.name;


-- 17. Alle Länder, nur die Namen, und wenn sie haben, das Meer dazu
SELECT Country.name, sea.name
FROM country 
JOIN geo_sea ON country.code = geo_sea.country
Join sea ON geo_sea.sea = sea.name
Group By country.name, Sea.name;


-- 18. Erstelle eine neue “Organization” mit dem Namen “DCV-Grundkurs”. 
-- Suche dir ein paar Länder aus, die Mitglied in dieser "Organization" sind und speichere die Mitgliedschaft in die Datenbank.
INSERT INTO organization 
VALUES ('DCV', 'DCV-Grundkurs', 'Vienna', 'A', 'Vienna', '2024-01-01');

INSERT INTO isMember VALUES ('A', 'DCV', 'member');
INSERT INTO isMember VALUES ('D', 'DCV', 'member');
INSERT INTO isMember VALUES ('CH', 'DCV', 'member');
INSERT INTO isMember VALUES ('I', 'DCV', 'member');
INSERT INTO isMember VALUES ('F', 'DCV', 'member');


-- 19. Gib alle Mitglieder der neuen Organization aus. Sind alle Mitglieder dabei, die du hinzugefügt hast?
Select 	*
From isMember
Where organization = "DCV";


-- 20. Wir gehen 2 Monate in die Zukunft: Der Kurs ist vorbei. Jetzt gibt es eine neue internationale Organisation: “Alumni DCV-Grundkurs”. 
-- Alle Mitglieder von “DCV-Grundkurs” werden nun automatisch Mitglied in der Organisation “Alumni DCV Grundkurs”.
-- Die Mitgliedschaft bei "DCV-Grundkurs" endet im selben Moment.
INSERT INTO organization
VALUES ('AlumniDCV', 'Alumni DCV-Grundkurs', 'Vienna', 'A', 'Vienna', '2024-03-01');

INSERT INTO isMember (country, organization, type)
SELECT country, 'AlumniDCV', type
FROM isMember
WHERE organization = 'DCV';

DELETE FROM isMember
WHERE organization = 'DCV';