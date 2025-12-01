-- 19) Geben Sie den Vornamen, den Nachnamen und die Anzahl Bücher aus, die der jeweilige Autor geschrieben hat. 
-- Sortieren Sie das Ergebnis nach der Anzahl Bücher absteigend. 
-- Die Spalte mit der Anzahl soll 'Anzahl Bücher' heißen.


USE Bibliotheksverwaltung;
SELECT autor.vorname, autor.nachname, Count(buch.isbn) AS AnzahlBuecher FROM buch
Join autor ON buch.autor = autor.id
GROUP BY autor.id;

-- Marc	Elsberg	4
-- Stephen	King	3
-- Khalil	Gibran	1
-- Paulo	Coelho	1
-- Thomas H.	Cormen	1
-- Donald E.	Knuth	3
-- J.R.R.	Tolkien	3
-- Ulrich	Kaiser	1
-- Friedrich	Dürrenmatt	1