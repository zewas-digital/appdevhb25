--  15) Welche Bücher hat der Autor Marc Elsberg geschrieben? 
-- Geben Sie die ISBN, den Buchtitel, den Vor- und Nachnamen des Autors und das Erscheinungsjahr aus (in dieser Reihenfolge). 
-- Sortieren Sie das Ergebnis so, dass das aktuellste Buch ganz oben steht.


USE Bibliotheksverwaltung;
SELECT buch.ISBN, autor.vorname, autor.nachname, buch.erscheinungsjahr FROM buch
Join autor ON buch.autor = autor.id
WHERE autor.vorname = "Marc"
AND autor.nachname = "Elsberg"
ORDER BY buch.erscheinungsjahr DESC;

-- 978-3764506322	Marc	Elsberg	2019
-- 978-3734105579	Marc	Elsberg	2018
-- 978-3734100932	Marc	Elsberg	2016
-- 978-3442380299	Marc	Elsberg	2013