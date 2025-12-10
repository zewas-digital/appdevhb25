USE Bibliotheksverwaltung;
SELECT Verlag, COUNT(Titel) FROM Buch
GROUP BY Verlag;

# Verlag, COUNT(Titel)
'Addison-Wesley', '2'
'Prentice Hall', '1'
'The MIT Press', '1'
'Diogenes Verlag', '1'
'Diogenes', '1'
'Lübbe', '1'
'Blanvalet Taschenbuch Verlag', '4'
'Heyne Verlag', '2'
'Klett Cotta', '3'
'Galileo Computing', '1'
'Patmos Verlag', '1'
