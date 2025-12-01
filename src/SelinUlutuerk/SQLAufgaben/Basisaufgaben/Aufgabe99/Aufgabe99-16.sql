-- 16) Wie viele Bücher die in deutscher Sprache und 
-- wie viele Bücher die in englischer Sprache geschrieben sind befinden sich in der Datenbank?

USE Bibliotheksverwaltung;
SELECT sprache, Count(sprache) FROM buch
GROUP BY sprache;

-- Englisch	4
-- Deutsch	14