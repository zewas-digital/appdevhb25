USE Bibliotheksverwaltung;
SELECT Buch.ISBN, Buch.Titel, Autor.Nachname, Autor.Vorname, Buch.Erscheinungsjahr FROM Autor JOIN Buch ON Autor.Id = Buch.Autor 
WHERE Autor.Nachname = 'Elsberg' AND Autor.Vorname = 'Marc' 
ORDER BY Erscheinungsjahr DESC;

# ISBN, Titel, Nachname, Vorname, Erscheinungsjahr
'978-3764506322', 'GIER - Wie weit würdest du gehen?', 'Elsberg', 'Marc', '2019'
'978-3734105579', 'HELIX - Sie werden uns ersetzen', 'Elsberg', 'Marc', '2018'
'978-3734100932', 'ZERO - Sie wissen, was du tust', 'Elsberg', 'Marc', '2016'
'978-3442380299', 'BLACKOUT - Morgen ist es zu spät', 'Elsberg', 'Marc', '2013'
