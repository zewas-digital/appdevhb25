--  12) Suchen Sie nach den Büchern von Stephen King. Geben Sie die Buchtitel aus.

USE Bibliotheksverwaltung;
SELECT buch.Titel FROM buch
Join autor ON buch.autor = autor.id
WHERE autor.vorname = "Stephen"
AND autor.nachname = "King";

-- Shining
-- Friedhof der Kuscheltiere
-- Es