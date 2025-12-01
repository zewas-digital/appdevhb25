-- Erstelle eine neue “Organization” mit dem Namen “DCV-Grundkurs”. 
-- Suche dir ein paar Länder aus, die Mitglied in dieser "Organization" 
-- sind und speichere die Mitgliedschaft in die Datenbank.
INSERT INTO organization (Abbreviation, Name) VALUES('DCV', 'DCV-Grundkurs');

INSERT INTO isMember VALUES ('A', 'DCV', 'member');
INSERT INTO isMember VALUES ('B', 'DCV', 'member');
INSERT INTO isMember VALUES ('NL', 'DCV', 'member');