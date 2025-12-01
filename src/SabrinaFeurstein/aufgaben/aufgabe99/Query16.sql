-- 16) Wie viele Bücher die in deutscher Sprache und wie viele Bücher 
-- die in englischer Sprache geschrieben sind befinden sich in der Datenbank?
SELECT COUNT(CASE Sprache WHEN 'Englisch' THEN 1 ELSE NULL END) AS 'Englische Bücher', 
COUNT(CASE Sprache WHEN 'Deutsch' THEN 1 ELSE NULL END) AS 'Deutsche Bücher' FROM Buch;

-- Alternative Lösung
SELECT Sprache, COUNT(*) AS 'Anzahl Bücher' FROM Buch
GROUP BY Sprache;