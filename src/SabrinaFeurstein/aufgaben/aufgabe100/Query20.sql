-- Wir gehen 2 Monate in die Zukunft: Der Kurs ist vorbei. 
-- Jetzt gibt es eine neue internationale Organisation: 
-- “Alumni DCV-Grundkurs”. Alle Mitglieder von “DCV-Grundkurs” 
-- werden nun automatisch Mitglied in der Organisation “Alumni DCV Grundkurs”. 
-- Die Mitgliedschaft bei "DCV-Grundkurs" endet im selben Moment.
INSERT INTO organization (Abbreviation, Name) 
VALUES('A-DCV', 'Alumni DCV-Grundkurs');

INSERT INTO isMember (country, organization, type)
SELECT country, 'A-DCV', type
FROM isMember
WHERE organization = 'DCV';
 
DELETE FROM isMember
WHERE organization = 'DCV';