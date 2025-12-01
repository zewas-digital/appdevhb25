-- 17) In welchen Jahren sind 2 oder mehr Bücher erschienen?
SELECT Erscheinungsjahr, COUNT(*) AS Anzahl FROM Buch 
GROUP BY Erscheinungsjahr
HAVING COUNT(*) >= 2;