-- 14) Geben Sie eine Liste aller Bücher (Titel) mit dem jeweiligen Autor aus. 
-- Die Bücher sollen nach dem Nachnamen und Vornamen des Autors aufsteigend sortiert sein.

SELECT *
FROM Buch
JOIN Autor ON Buch.Autor = Autor.ID
ORDER BY Autor.Nachname;