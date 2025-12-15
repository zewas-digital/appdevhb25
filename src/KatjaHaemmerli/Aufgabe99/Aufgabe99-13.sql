-- 13) Wie heißt der Autor, der das Buch 'Introduction to Algorithms' geschrieben hat? 
-- Antwort: Cormen Thomas H.

SELECT Autor.Nachname, Autor.Vorname
From Buch
LEFT OUTER JOIN Autor ON Autor.Id = Buch.Autor
Where Titel = 'Introduction to Algorithms';