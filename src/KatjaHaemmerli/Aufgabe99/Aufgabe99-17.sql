-- 17) In welchen Jahren sind 2 oder mehr Bücher erschienen?
-- Antwort: 1997, 1998, 2008, 2013, 2018

SELECT Erscheinungsjahr, COUNT(*) AS Anzahl_Buecher
FROM Buch
GROUP BY Erscheinungsjahr
HAVING COUNT(*) >= 2
ORDER BY Erscheinungsjahr;