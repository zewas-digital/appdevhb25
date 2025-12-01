-- Thailand hat eine neue Hauptstadt: Nusantara. Speichere das in die Datenbank.
UPDATE country
SET Capital = 'Nusantara'
WHERE Code = 'THA';

SELECT * FROM country 
WHERE country.Code = 'THA';