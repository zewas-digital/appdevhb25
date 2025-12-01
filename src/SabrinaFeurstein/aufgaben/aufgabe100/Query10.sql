-- Alle 3000er, welche in einem Land sind, welches zu mindestens 60% römisch Katholisch ist
SELECT Mountain FROM geo_mountain 
JOIN religion ON geo_mountain.Country = religion.Country
JOIN mountain ON geo_mountain.Mountain = mountain.Name
WHERE religion.Name LIKE '%catholic%' AND religion.Percentage >= 60
AND mountain.Height >= 3000 AND mountain.Height < 4000
GROUP BY Mountain;