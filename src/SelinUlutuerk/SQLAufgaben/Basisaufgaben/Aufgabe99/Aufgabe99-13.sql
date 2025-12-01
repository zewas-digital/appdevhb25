--  13) Wie heißt der Autor, der das Buch 'Introduction to Algorithms' geschrieben hat?

USE Bibliotheksverwaltung;
SELECT * FROM buch
Join autor ON buch.autor = autor.id
WHERE buch.titel = 'Introduction to Algorithms';

-- 978-0262033848	Introduction to Algorithms	2013	The MIT Press	Englisch	5	5	Cormen	Thomas H.