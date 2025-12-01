-- 13) Wie heißt der Autor, der das Buch 'Introduction to Algorithms' geschrieben hat?
SELECT Autor.Vorname, Autor.Nachname FROM Autor 
JOIN Buch ON Buch.Autor = Autor.Id 
WHERE Buch.Titel = 'Introduction to Algorithms';