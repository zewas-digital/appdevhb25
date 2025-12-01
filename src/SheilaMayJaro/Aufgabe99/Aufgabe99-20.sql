Select Vorname, Nachname, Buch.*
From Autor Left Outer Join Buch On Buch.Autor = Autor.Id
Where Buch.Isbn Is null

'Jostein', 'Gaarder', NULL, NULL, NULL, NULL, NULL, NULL

