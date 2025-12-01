-- Ändere den Namen der Türkei auf "Türkiye".
UPDATE country
SET Name = 'Türkiye'
WHERE Code = 'TR';

SELECT * FROM country 
WHERE country.Code = 'TR';