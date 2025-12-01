-- 22) Bei dem Buchtitel 'Der Herr der Ringe. Die Gefährten' 
-- hat sich ein Rechtschreibfehler eingeschlichen. 
-- Korrigieren Sie das Wort 'Gefähren' auf 'Gefährten'.
UPDATE Buch
SET Titel = REPLACE(Titel, 'Gefähren', 'Gefährten') 
WHERE ISBN = '978-3908934011';