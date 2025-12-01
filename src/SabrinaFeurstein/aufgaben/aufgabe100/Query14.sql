-- Welche Länder haben genau 3 Städte? Welche Länder sind dies?
SELECT country.Name FROM country
JOIN city ON country.Code = city.Country
GROUP BY country.Code
HAVING COUNT(country.Code) = 3;