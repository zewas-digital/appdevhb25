USE Bibliotheksverwaltung;
SELECT Autor.Vorname, Autor.Nachname FROM Autor LEFT JOIN Buch ON Autor.Id = Buch.Autor
WHERE Buch.Autor IS NULL;

# Vorname, Nachname
'Jostein', 'Gaarder'
