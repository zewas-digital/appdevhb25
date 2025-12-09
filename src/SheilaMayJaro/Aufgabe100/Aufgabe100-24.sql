Insert into city (Name, Country, Province) values ('Tiraspol', 'TRN', 'Tiraspol');
Update country 
Set country.Capital = 'Tiraspol'
Where country.code = 'TRN';

Select * 
From country 
Where country.code = 'TRN';

Insert into mountain (name) values ('Nameless'); 
Insert into geo_mountain (mountain, country, province) values ('Nameless', 'TRN', 'Plot'); 

Select *
From country 
Inner Join geo_mountain on geo_mountain.country = country.code
Inner Join mountain on mountain.name = geo_mountain.mountain
Where country.code = 'TRN'; 

# Name, Code, Capital, Province, Area, Population, Mountain, Country, Province, Name, Mountains, Height, Type, Longitude, Latitude
'Transnistrien', 'TRN', 'Tiraspol', NULL, NULL, NULL, 'Nameless', 'TRN', 'Plot', 'Nameless', NULL, NULL, NULL, NULL, NULL


























