USE Bibliotheksverwaltung;
SELECT Autor.Vorname, Autor.Nachname, COUNT(Buch.Autor) AS Anzahl_Bücher FROM Autor JOIN Buch ON Autor.Id = Buch.Autor
GROUP BY Autor.Vorname, Autor.Nachname, Autor.Id
ORDER BY Anzahl_Bücher DESC;

# Vorname, Nachname, Anzahl_Bücher
'Marc', 'Elsberg', '4'
'Stephen', 'King', '3'
'Donald E.', 'Knuth', '3'
'J.R.R.', 'Tolkien', '3'
'Khalil', 'Gibran', '1'
'Paulo', 'Coelho', '1'
'Thomas H.', 'Cormen', '1'
'Ulrich', 'Kaiser', '1'
'Friedrich', 'Dürrenmatt', '1'
