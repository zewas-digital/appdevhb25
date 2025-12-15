-- 16) Wie viele Bücher die in deutscher Sprache und wie viele Bücher die in englischer Sprache geschrieben sind befinden sich in der Datenbank?
-- Antwort: zusammen: 17, Deutsch: 13, Englisch: 4

Select * 
From Buch
WHERE Sprache IN ('Deutsch', 'Englisch')