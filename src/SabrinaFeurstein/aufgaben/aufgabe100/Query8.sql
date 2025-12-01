-- Was ist der größte Berg von Österreich? Wie hoch ist er?
SELECT mountain.Name, mountain.Height FROM mountain 
JOIN geo_mountain ON mountain.Name = geo_mountain.Mountain
WHERE geo_mountain.Country = 'A'
GROUP BY mountain.Name
ORDER BY mountain.Height DESC
LIMIT 1;