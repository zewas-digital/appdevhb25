-- 22) Bei dem Buchtitel 'Der Herr der Ringe. Die Gefährten' hat sich ein Rechtschreibfehler eingeschlichen. 
-- Korrigieren Sie das Wort 'Gefähren' auf 'Gefährten'.

USE Bibliotheksverwaltung;
UPDATE Buch
SET Titel = 'Der Herr der Ringe. Die Gefährten'
WHERE ISBN = '978-3908934011';