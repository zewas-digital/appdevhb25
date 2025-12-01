Select Vorname, Nachname, Count(Buch.ISBN) `Anzahl Bücher`
From Autor Left Outer Join Buch On Buch.Autor = Autor.Id
Group By Vorname, Nachname
Order by `Anzahl Bücher`
 
# Vorname, Nachname, Anzahl Bücher
'Jostein', 'Gaarder', '0'
'Khalil', 'Gibran', '1'
'Paulo', 'Coelho', '1'
'Thomas H.', 'Cormen', '1'
'Ulrich', 'Kaiser', '1'
'Friedrich', 'Dürrenmatt', '1'
'Stephen', 'King', '3'
'Donald E.', 'Knuth', '3'
'J.R.R.', 'Tolkien', '3'
'Marc', 'Elsberg', '4'


