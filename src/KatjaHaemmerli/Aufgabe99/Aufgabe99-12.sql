-- 12) Suchen Sie nach den Büchern von Stephen King. Geben Sie die Buchtitel aus.

SELECT Titel
From Buch
LEFT OUTER JOIN Autor ON Autor.Id = Buch.Autor
Where Autor.Nachname = 'King';