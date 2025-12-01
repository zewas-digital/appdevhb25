-- 19) Geben Sie den Vornamen, den Nachnamen und die Anzahl Bücher aus, 
-- die der jeweilige Autor geschrieben hat. Sortieren Sie das Ergebnis nach der Anzahl Bücher absteigend. 
-- Die Spalte mit der Anzahl soll 'Anzahl Bücher' heißen.
SELECT Autor.Vorname, Autor.Nachname, COUNT(*)as 'Anzahl Bücher' FROM Autor 
JOIN Buch ON Buch.Autor = Autor.Id 
GROUP BY Autor.Id
ORDER BY COUNT(*) DESC;