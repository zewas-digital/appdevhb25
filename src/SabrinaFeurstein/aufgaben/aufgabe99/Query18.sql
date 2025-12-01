-- 18) Wie viele Bücher sind von den einzelnen Verlagen in der Datenbank? 
-- Geben Sie den Verlag mit der Anzahl seiner Bücher aus. 
-- (Diogenes und Diogenes Verlag sollen jeweils mit einem Buch vorkommen.)
SELECT Verlag, COUNT(*) AS 'Anzahl Bücher' FROM Buch 
GROUP BY Verlag