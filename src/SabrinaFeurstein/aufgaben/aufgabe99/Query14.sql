-- 14) Geben Sie eine Liste aller Bücher (Titel) mit dem jeweiligen Autor aus. 
-- Die Bücher sollen nach dem Nachnamen und Vornamen des Autors aufsteigend sortiert sein.
SELECT Buch.Titel, Autor.Vorname, Autor.Nachname FROM Autor 
JOIN Buch ON Buch.Autor = Autor.Id 
ORDER BY Autor.Nachname ASC, Autor.Vorname ASC;