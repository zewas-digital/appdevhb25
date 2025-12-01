-- Alle Länder, nur die Namen, und wenn sie haben, das Meer dazu
SELECT country.Name, geo_sea.sea FROM country
LEFT JOIN geo_sea ON country.Code = geo_sea.Country
GROUP BY country.Name, geo_sea.sea;