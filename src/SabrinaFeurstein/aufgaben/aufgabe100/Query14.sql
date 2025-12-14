-- Welche Länder haben genau 3 Städte? Welche Länder sind dies?
SELECT country.Name FROM country
JOIN city ON country.Code = city.Country
GROUP BY country.Code
HAVING COUNT(country.Code) = 3;

-- Länder mit den Städten
SELECT country.Name, city.Name FROM country
JOIN city ON country.Code = city.Country
WHERE country.Code IN 
(SELECT Country FROM city 
GROUP BY Country
HAVING COUNT(Name) = 3)
ORDER BY country.Code;