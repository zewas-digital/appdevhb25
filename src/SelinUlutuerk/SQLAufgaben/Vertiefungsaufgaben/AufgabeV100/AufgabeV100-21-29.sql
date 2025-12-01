-- 21. Nachdem die Organisation “DCV-Grundkurs” keine Mitglieder mehr hat, soll diese gelöscht werden.
DELETE FROM isMember 
WHERE organization = "DCV";


-- 22. Aktualisiere die Höhe des Großglockners.
UPDATE mountain
SET height = 4000 
WHERE name = "Grossglockner";


-- 23. Erstelle das Land Transnistrien. Es liegt in Europa. Wenn du anschließend einen alle europäischen Staaten inkl. 
-- Namen selektierst, soll auch Transnistrien in der Ergebnisliste sein.
Insert Into Country
Values ('Transnistrien','T','Trate','Trate',39100,850000);
Insert Into encompasses
Values ('T','Europe',100);

Select country.name
From encompasses
Join Country On encompasses.country = Country.code
Where Continent = 'Europe';


-- 24. Speichere den höchsten Berg und die Hauptstadt in die Datenbank. Prüfe die Ergebnisse mit einem SELECT.
Insert Into city 
VALUES ('Trate','T','Transnistrien',22000,Null,Null);

Insert Into geo_mountain
Values ('Alpina','T', 'Transnistrien');

Insert Into mountain
Values ('Alpina', Null, 2452, 'volcano', -73.7,10.85);

Insert Into Province 
Values('Transnistrien','T',850000,Null,'Trate','Transnistrien');

Select *
From city
Where country = 'T';

Select mountain.name, mountain.height
From mountain
Join geo_mountain ON geo_mountain.mountain = mountain.name
Where geo_mountain.country = 'T';


-- 25. Ändere den Namen der Türkei auf "Türkiye".
UPDATE country
SET name = 'Türkiye' 
WHERE name = 'Turkey';


-- 26. Thailand hat eine neue Hauptstadt: Nusantara. Speichere das in die Datenbank.
UPDATE country
SET capital = 'Nusantara' 
WHERE name = 'Thailand';


-- 27. Es gibt eine weitere "Organization", die nicht in unserer Datenbank vorhanden ist: 
-- die Visegrad Gruppe. Erstelle die "Organization" und ordne ihr Mitglieder zu. 
-- Die Hauptstadt dieses Bündnisses ist die ungarische Stadt Visegrad.
INSERT INTO organization 
VALUES ('DVG', 'Die Visegrad Gruppe', 'Visegrad', 'H', 'Zala', '1999-01-10');

INSERT INTO isMember VALUES ('H', 'DVG', 'regional member');
INSERT INTO isMember VALUES ('D', 'DVG', 'member');
INSERT INTO isMember VALUES ('CH', 'DVG', 'member');
INSERT INTO isMember VALUES ('I', 'DVG', 'member');
INSERT INTO isMember VALUES ('F', 'DVG', 'member');


-- 28. Gib eine Liste der Mitglieder EU und deren Hauptstädte aus. 
-- Vergleiche deine Ergebnisse mit der aktuellen Mitgliederliste.
Select country.name, country.capital
From isMember
Join country ON ismember.country = country.code
Where organization = 'EU';


--29. DELETE: Großbritannien hat die EU verlassen.
DELETE FROM isMember 
WHERE organization = "DCV"
And country = 'United Kingdom';

