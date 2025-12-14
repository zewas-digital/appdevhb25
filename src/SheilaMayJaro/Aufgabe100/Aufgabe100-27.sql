Insert into organization (abbreviation, name, city) values ('VGR', 'Visegrad Gruppe', 'Visegrad'); 
Insert into city (Name, Country, Province) values ('Visegrad', 'H', 'Mittelungarn'); 
Insert into isMember (Country, Organization) values ('H', 'VGR');
Insert into isMember (country, organization) values ('BF', 'VGR'),('D', 'VGR');

Select * 
From organization 
Where abbreviation = 'VGR'; 

# Abbreviation, Name, City, Country, Province, Established
'VGR', 'Visegrad Gruppe', 'Visegrad', NULL, NULL, NULL

Select * 
From isMember 
Where organization = 'VGR';

# Country, Organization, Type
'BF', 'VGR', 'member'
'D', 'VGR', 'member'
'H', 'VGR', 'member'

		


















