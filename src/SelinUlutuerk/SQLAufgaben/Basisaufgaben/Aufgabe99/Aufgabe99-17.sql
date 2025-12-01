-- 17) In welchen Jahren sind 2 oder mehr Bücher erschienen?

USE Bibliotheksverwaltung;
SELECT Erscheinungsjahr, COUNT(*) AS Anzahl
FROM Buch
GROUP BY Erscheinungsjahr
HAVING COUNT(*) >= 2;

-- 1997	2
-- 1998	2
-- 2013	2
-- 2008	2
-- 2019	3