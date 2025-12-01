-- 6) Geben Sie alle Buchtitel der englischsprachigen Bücher aus?

USE Bibliotheksverwaltung;
SELECT Titel FROM buch 
WHERE sprache = 'Englisch';

-- The Art of Computer Programming: Volume 1: Fundamental Algorithms
-- The Art of Computer Programming: Volume 2: Seminumerical Algorithms
-- The Art of Computer Programming: Volume 3: Sorting and Searching
