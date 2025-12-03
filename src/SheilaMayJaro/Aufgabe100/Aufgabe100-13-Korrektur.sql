Select Independence
From country 
Left Outer Join politics on politics.country = country.code
Inner Join geo_desert on geo_desert.country = country.code -- weil das Land an eine Wüste angrenzen soll
AND geo_desert.province = country.province
Left Outer Join ethnicGroup on ethnicGroup.country = country.code
Where ethnicGroup.name = 'African';

-- kein Ergebnis 