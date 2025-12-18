-- 5) Welche ISBN hat das Buch 'Der Alchimist'? Antwort: 978-3257237276

SELECT ISBN
FROM Buch
WHERE Titel = 'Der Alchimist';