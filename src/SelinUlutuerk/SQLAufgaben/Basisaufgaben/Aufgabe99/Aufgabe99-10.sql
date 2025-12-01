--  10) Welche Bücher sind in den Jahren 1997 und 2008 erschienen?

USE Bibliotheksverwaltung;
SELECT * FROM buch 
WHERE Erscheinungsjahr IN (2008, 1997);

-- 978-0201896831	The Art of Computer Programming: Volume 1: Fundamental Algorithms	1997	Addison-Wesley	Englisch	6
-- 978-0201896848	The Art of Computer Programming: Volume 2: Seminumerical Algorithms	1997	Prentice Hall	Englisch	6
-- 978-3257237276	Der Alchimist	2008	Diogenes	Deutsch	4
-- 978-3608955385	Der Herr der Ringe. Die Rückkehr des Königs.	2008	Klett Cotta	Deutsch	7