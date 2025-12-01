--  11) Geben Sie die neuesten 3 Buchtitel aus.

USE Bibliotheksverwaltung;
SELECT Titel FROM buch 
WHERE Erscheinungsjahr IN (2008, 1997)
Limit 0,3;

-- The Art of Computer Programming: Volume 1: Fundamental Algorithms
-- The Art of Computer Programming: Volume 2: Seminumerical Algorithms
-- Der Alchimist