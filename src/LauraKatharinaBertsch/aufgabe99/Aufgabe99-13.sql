USE Bibliotheksverwaltung;
SELECT Autor.Nachname, Autor.Vorname FROM Autor JOIN Buch ON Autor.Id = Buch.Autor WHERE Buch.Titel = 'Introduction to Algorithms';

# Nachname, Vorname
'Cormen', 'Thomas H.'

