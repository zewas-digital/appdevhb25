-- 12) Suchen Sie nach den Büchern von Stephen King. Geben Sie die Buchtitel aus.
SELECT Buch.Titel FROM Buch JOIN Autor ON Buch.Autor = Autor.Id 
WHERE Autor.Vorname = 'Stephen' AND Autor.Nachname = 'King';