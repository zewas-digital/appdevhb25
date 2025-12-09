Use Bibliotheksverwaltung;
Select * 
From Buch 
Inner Join Autor on Autor.Id = Buch.Autor
Where Autor.Vorname = 'Marc' AND Autor.Nachname = 'Elsberg'
Order by Erscheinungsjahr;

# ISBN, Titel, Erscheinungsjahr, Verlag, Sprache, Autor, Id, Nachname, Vorname
'978-3442380299', 'BLACKOUT - Morgen ist es zu spät', '2013', 'Blanvalet Taschenbuch Verlag', 'Deutsch', '1', '1', 'Elsberg', 'Marc'
'978-3734100932', 'ZERO - Sie wissen, was du tust', '2016', 'Blanvalet Taschenbuch Verlag', 'Deutsch', '1', '1', 'Elsberg', 'Marc'
'978-3734105579', 'HELIX - Sie werden uns ersetzen', '2018', 'Blanvalet Taschenbuch Verlag', 'Deutsch', '1', '1', 'Elsberg', 'Marc'
'978-3764506322', 'GIER - Wie weit würdest du gehen?', '2019', 'Blanvalet Taschenbuch Verlag', 'Deutsch', '1', '1', 'Elsberg', 'Marc'

