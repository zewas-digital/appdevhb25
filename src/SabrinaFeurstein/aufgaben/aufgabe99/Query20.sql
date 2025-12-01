-- 20) Von welchen Autor scheint kein Buch in der Datenbank zu sein?
SELECT Autor.Vorname, Autor.Nachname AS 'Anzahl Bücher' FROM Autor 
LEFT JOIN Buch ON Buch.Autor = Autor.Id 
WHERE Buch.ISBN IS NULL;