USE Bibliotheksverwaltung;
SELECT Sprache, COUNT(Sprache) FROM Buch
GROUP BY Sprache;

# Sprache, COUNT(Sprache)
'Englisch', '4'
'Deutsch', '14'

