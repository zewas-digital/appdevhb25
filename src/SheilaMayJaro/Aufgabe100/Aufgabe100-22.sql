Select *
From country 
Inner join geo_mountain on geo_mountain.country = country.code
Inner join mountain on geo_mountain.mountain = mountain.name
Where geo_mountain.mountain = 'Grossglockner'; 

Update mountain
Set height = 3798
Where height = 3797 AND name = 'Grossglockner';

# Name, Code, Capital, Province, Area, Population, Mountain, Country, Province, Name, Mountains, Height, Type, Longitude, Latitude
'Austria', 'A', 'Vienna', 'Vienna', '83850', '8023244', 'Grossglockner', 'A', 'Carinthia', 'Grossglockner', 'Alps', '3798', NULL, '12.5', '47'
























