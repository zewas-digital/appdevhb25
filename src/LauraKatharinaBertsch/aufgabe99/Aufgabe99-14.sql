USE Bibliotheksverwaltung;
SELECT Autor.Nachname, Autor.Vorname, Buch.Titel FROM Autor JOIN Buch ON Autor.Id = Buch.Autor ORDER BY Autor.Nachname, Autor.Vorname ASC;

# Nachname, Vorname, Titel
'Coelho', 'Paulo', 'Der Alchimist'
'Cormen', 'Thomas H.', 'Introduction to Algorithms'
'Dürrenmatt', 'Friedrich', 'Die Physiker. Eine Komödie in zwei Akten'
'Elsberg', 'Marc', 'BLACKOUT - Morgen ist es zu spät'
'Elsberg', 'Marc', 'GIER - Wie weit würdest du gehen?'
'Elsberg', 'Marc', 'HELIX - Sie werden uns ersetzen'
'Elsberg', 'Marc', 'ZERO - Sie wissen, was du tust'
'Gibran', 'Khalil', 'Der Prophet'
'Kaiser', 'Ulrich', 'C/C++: Das umfassende Lehrbuch'
'King', 'Stephen', 'Shining'
'King', 'Stephen', 'Friedhof der Kuscheltiere'
'King', 'Stephen', 'Es'
'Knuth', 'Donald E.', 'The Art of Computer Programming: Volume 2: Seminumerical Algorithms'
'Knuth', 'Donald E.', 'The Art of Computer Programming: Volume 3: Sorting and Searching'
'Knuth', 'Donald E.', 'The Art of Computer Programming: Volume 1: Fundamental Algorithms'
'Tolkien', 'J.R.R.', 'Der Herr der Ringe. Die Rückkehr des Königs.'
'Tolkien', 'J.R.R.', 'Der Herr der Ringe. Die zwei Türme.'
'Tolkien', 'J.R.R.', 'Der Herr der Ringe. Die Gefähren.'
