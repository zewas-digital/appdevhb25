Select mountain.name, mountain.height
From geo_mountain 
Left Outer Join mountain on geo_mountain.mountain = mountain.name
Where geo_mountain.country = 'A'
Order by height DESC
Limit 1;

# name, height
'Grossglockner', '3797'


















