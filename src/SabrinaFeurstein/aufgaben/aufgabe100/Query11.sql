-- Einwohnerzahl pro Religion
SELECT religion.Name, SUM(country.Population) AS Population FROM Country
JOIN religion ON country.Code = religion.Country
GROUP BY religion.Name;