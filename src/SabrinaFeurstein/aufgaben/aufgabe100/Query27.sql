-- Es gibt eine weitere "Organization", 
-- die nicht in unserer Datenbank vorhanden ist: die Visegrad Gruppe. 
-- Erstelle die "Organization" und ordne ihr Mitglieder zu. 
-- Die Hauptstadt dieses Bündnisses ist die ungarische Stadt Visegrad.
INSERT INTO organization (Abbreviation, Name, City, Country) 
VALUES('VG', 'Visegrad Gruppe', 'Visegrad', 'H');

INSERT INTO isMember VALUES ('CZ', 'VG', 'member');
INSERT INTO isMember VALUES ('H', 'VG', 'member');
INSERT INTO isMember VALUES ('PL', 'VG', 'member');
INSERT INTO isMember VALUES ('SK', 'VG', 'member');

SELECT * FROM organization 
WHERE Abbreviation = 'VG';

SELECT * FROM isMember 
WHERE Organization = 'VG';