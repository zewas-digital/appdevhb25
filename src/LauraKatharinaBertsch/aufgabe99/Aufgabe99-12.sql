USE Bibliotheksverwaltung;
SELECT Buch.Titel FROM Autor JOIN Buch ON Autor.Id = Buch.Autor WHERE Autor.Nachname = 'King' AND Autor.Vorname = 'Stephen';

# Titel
'Shining'
'Friedhof der Kuscheltiere'
'Es'
