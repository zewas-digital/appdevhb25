-- Alle Inseln im Pazifik mit >50% islamischem Bekenntnis
SELECT * FROM islandIn 
JOIN geo_island ON islandIn.Island = geo_island.Island
JOIN religion ON geo_island.Country = religion.Country
WHERE islandIn.Sea LIKE '%Pacific%' AND religion.Name = 'Muslim'
AND religion.Percentage > 50;