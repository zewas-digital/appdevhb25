-- 4) Welche Bücher hat der Autor mit der Id=2 geschrieben? Das Ergebnis soll nach dem Erscheinungsjahr aufsteigend sortiert sein.

USE Bibliotheksverwaltung;
SELECT * FROM buch 
WHERE Autor = 2
order by Erscheinungsjahr ASC;

-- 978-3453435797	Friedhof der Kuscheltiere	2011	Heyne Verlag	Deutsch	2
-- 978-3404130894	Shining	2019	Lübbe	Deutsch	2
-- 978-3453504080	Es	2019	Heyne Verlag	Deutsch	2