-- 20) Von welchen Autor scheint kein Buch in der Datenbank zu sein?

USE Bibliotheksverwaltung;
SELECT autor.vorname, autor.nachname FROM autor
LEFT Join buch ON autor.id = buch.autor
WHERE buch.autor is NULL;

-- Jostein	Gaarder