-- 7) Wie viele Bücher vom Diogenes-Verlag befinden sich in der Tabelle 'Bücher'? (Erwartetes Ergebnis=2)

USE Bibliotheksverwaltung;
SELECT COUNT(Verlag) FROM buch 
WHERE Verlag LIKE 'Diogenes%';

-- 2