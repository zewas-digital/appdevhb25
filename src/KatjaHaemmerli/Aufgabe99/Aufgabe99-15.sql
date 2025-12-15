-- 15) Welche Bücher hat der Autor Marc Elsberg geschrieben? Geben Sie die ISBN, 
-- den Buchtitel, den Vor- und Nachnamen des Autors und das Erscheinungsjahr aus (in dieser Reihenfolge). 
-- Sortieren Sie das Ergebnis so, dass das aktuellste Buch ganz oben steht.

-- zum testen in SQL Fiddle https://sqlfiddle.com/mysql/online-compiler?id=3b6ef75f-236a-4212-bdaf-036cc84fc5dd
-- ab Zeile 7 Eintrag in File Bibliotheksverwaltung in SQL Fiddle kopieren

Select * 
From Buch
JOIN Autor ON id
WHERE Nachname = 'Elsberg'
Order by Erscheinungsjahr;