USE Bibliotheksverwaltung;
SELECT Erscheinungsjahr FROM Buch GROUP BY Erscheinungsjahr HAVING COUNT(*) >= 2;

# Erscheinungsjahr
'1997'
'1998'
'2013'
'2008'
'2019'
