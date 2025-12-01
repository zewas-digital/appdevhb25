-- 15) Welche Bücher hat der Autor Marc Elsberg geschrieben? 
-- Geben Sie die ISBN, den Buchtitel, den Vor- und Nachnamen des Autors 
-- und das Erscheinungsjahr aus (in dieser Reihenfolge). 
-- Sortieren Sie das Ergebnis so, dass das aktuellste Buch ganz oben steht.
SELECT Buch.ISBN, Buch.Titel, Autor.Vorname, Autor.Nachname, Buch.Erscheinungsjahr FROM Autor 
JOIN Buch ON Buch.Autor = Autor.Id 
WHERE Autor.Vorname = 'Marc' AND Autor.Nachname = 'Elsberg'
ORDER BY Buch.Erscheinungsjahr DESC;