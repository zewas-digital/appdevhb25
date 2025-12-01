-- Alle Länder mit mindestens einem See mit mindestens 100 Meter Tiefe 
-- und mindestens einem Berg mit mindestens 1500 Höhenmeter
SELECT country.Name FROM country
JOIN geo_lake ON country.Code = geo_lake.Country
JOIN lake ON geo_lake.Lake = lake.Name
JOIN geo_mountain ON country.Code = geo_mountain.Country
JOIN mountain ON geo_mountain.Mountain = mountain.Name
WHERE lake.Depth >= 100 AND mountain.Height >= 1500
GROUP BY country.Name;