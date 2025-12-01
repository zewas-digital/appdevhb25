-- Gib eine Liste der Mitglieder EU und deren Hauptstädte aus. 
-- Vergleiche deine Ergebnisse mit der aktuellen Mitgliederliste.
SELECT country.Name, country.Capital FROM isMember
JOIN country ON isMember.Country = country.Code
WHERE Organization = 'EU'
ORDER BY country.Name;