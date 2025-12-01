-- 18) Wie viele Bücher sind von den einzelnen Verlagen in der Datenbank? 
-- Geben Sie den Verlag mit der Anzahl seiner Bücher aus. 
-- (Diogenes und Diogenes Verlag sollen jeweils mit einem Buch vorkommen.)

USE Bibliotheksverwaltung;
SELECT Verlag, COUNT(*) AS AnzahlBuecher FROM buch
GROUP BY Verlag;

-- Addison-Wesley	2
-- Prentice Hall	1
-- The MIT Press	1
-- Diogenes Verlag	1
-- Diogenes	1
-- Lübbe	1
-- Blanvalet Taschenbuch Verlag	4
-- Heyne Verlag	2
-- Klett Cotta	3
-- Galileo Computing	1
-- Patmos Verlag	1