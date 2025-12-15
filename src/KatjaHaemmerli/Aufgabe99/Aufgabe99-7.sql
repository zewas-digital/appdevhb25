-- 7) Wie viele Bücher vom Diogenes-Verlag befinden sich in der Tabelle 'Bücher'? (Erwartetes Ergebnis=2) 
-- Antwort: 

SELECT COUNT(ISBN)
From Buch
Where Verlag LIKE 'Diogenes%';

-- oder

SELECT COUNT(ISBN)
From Buch
Where Verlag BETWEEN 'Diogenes' AND 'Diogenes Verlag';