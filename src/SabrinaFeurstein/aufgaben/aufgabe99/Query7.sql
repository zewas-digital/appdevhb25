-- 7) Wie viele Bücher vom Diogenes-Verlag befinden sich 
-- in der Tabelle 'Bücher'? (Erwartetes Ergebnis=2)
SELECT COUNT(*) FROM Buch WHERE Verlag LIKE '%Diogenes%';