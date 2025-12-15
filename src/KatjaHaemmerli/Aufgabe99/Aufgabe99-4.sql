-- 4) Welche Bücher hat der Autor mit der Id=2 geschrieben? 
Das Ergebnis soll nach dem Erscheinungsjahr aufsteigend sortiert sein.

SELECT * 
FROM Buch
WHERE Autor = 2
ORDER BY Erscheinungsjahr ASC;