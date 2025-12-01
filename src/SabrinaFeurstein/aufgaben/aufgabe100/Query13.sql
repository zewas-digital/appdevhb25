-- Das Unabhängigkeitsdatum von Ländern die eine Wüste haben und die ethnische Gruppe African
SELECT country.Name, politics.Independence FROM country
JOIN ethnicGroup ON country.Code = ethnicGroup.Country
JOIN politics ON country.Code = politics.Country
JOIN geo_desert On country.Code = geo_desert.Country
WHERE ethnicGroup.Name = 'African'
GROUP BY country.Name, politics.Independence;