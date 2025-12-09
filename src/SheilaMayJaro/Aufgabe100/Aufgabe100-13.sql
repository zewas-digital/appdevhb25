Select Independence
From country 
Left Outer Join politics on politics.country = country.code
Inner Join geo_desert on geo_desert.country = country.code
Left Outer Join ethnicGroup on ethnicGroup.country = country.code
Where ethnicGroup.name = 'African'

# Independence
'1964-10-24'
'1964-10-24'




















