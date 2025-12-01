-- 5) Welche ISBN hat das Buch 'Der Alchimist'?

USE Bibliotheksverwaltung;
SELECT ISBN FROM buch 
WHERE titel = 'Der Alchimist';

-- 978-3257237276