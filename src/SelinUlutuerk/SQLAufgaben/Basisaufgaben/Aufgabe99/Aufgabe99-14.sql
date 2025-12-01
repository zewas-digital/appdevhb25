-- 14) Geben Sie eine Liste aller Bücher (Titel) mit dem jeweiligen Autor aus. 
-- Die Bücher sollen nach dem Nachnamen und Vornamen des Autors aufsteigend sortiert sein.

USE Bibliotheksverwaltung;
SELECT buch.Titel, autor.nachname, autor.vorname FROM buch
Join autor ON buch.autor = autor.id
ORDER BY  autor.nachname DESC, autor.vorname;

-- Der Herr der Ringe. Die zwei Türme.	Tolkien	J.R.R.
-- Der Herr der Ringe. Die Rückkehr des Königs.	Tolkien	J.R.R.
-- Der Herr der Ringe. Die Gefähren.	Tolkien	J.R.R.
-- The Art of Computer Programming: Volume 1: Fundamental Algorithms	Knuth	Donald E.
-- The Art of Computer Programming: Volume 2: Seminumerical Algorithms	Knuth	Donald E.
-- The Art of Computer Programming: Volume 3: Sorting and Searching	Knuth	Donald E.
-- Shining	King	Stephen
-- Friedhof der Kuscheltiere	King	Stephen
-- Es	King	Stephen
-- C/C++: Das umfassende Lehrbuch	Kaiser	Ulrich
-- Der Prophet	Gibran	Khalil
-- BLACKOUT - Morgen ist es zu spät	Elsberg	Marc
-- ZERO - Sie wissen, was du tust	Elsberg	Marc
-- HELIX - Sie werden uns ersetzen	Elsberg	Marc
-- GIER - Wie weit würdest du gehen?	Elsberg	Marc
-- Die Physiker. Eine Komödie in zwei Akten	Dürrenmatt	Friedrich
-- Introduction to Algorithms	Cormen	Thomas H.
-- Der Alchimist	Coelho	Paulo