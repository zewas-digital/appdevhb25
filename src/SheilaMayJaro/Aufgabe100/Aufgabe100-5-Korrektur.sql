Select Distinct river.name
From river
Inner Join geo_river on geo_river.river = river.Name
Inner Join country on country.code = geo_river.country
Inner Join encompasses on encompasses.country = geo_river.country
Where encompasses.continent = 'Europe'
Order by river.name ASC;

Select * 
From country
Inner Join encompasses on encompasses.country = country.code
Where name = 'Russia';
--nachgeschaut, ob Russland in zwei Kontinente aufgeteilt wird, ja wird es

# name
'Aare'
'Adda'
'Aller'
'Alz'
'Ammer'
'Amur'
'Angara'
'Argun'
'Arno'
'Black Drin'
'Breg'
'Brigach'
'Chatanga'
'Dalaelv'
'Dnepr'
'Dnjestr'
'Don'
'Donau'
'Doubs'
'Douro'
'Drau'
'Drin'
'Ebro'
'Elbe'
'Enns'
'Etsch'
'Euphrat'
'Fulda'
'Garonne'
'Glomma'
'Goetaaelv'
'Guadalquivir'
'Guadiana'
'Iller'
'Inn'
'Irtysch'
'Isar'
'Ischim'
'Isere'
'Jenissej'
'Joekulsa a Fjoellum'
'Karasu'
'Katun'
'Kemijoki'
'Klaraelv'
'Kokemaeenjoki'
'Kolyma'
'Kura'
'Kymijoki'
'Lagen'
'Lech'
'Leine'
'Lena'
'Limmat'
'Loire'
'Maas'
'Main'
'March'
'Marne'
'Mincio'
'Moldau'
'Morava'
'Mosel'
'Mur'
'Murat'
'Narva'
'Neckar'
'Newa'
'Northern Dwina'
'Ob'
'Oder'
'Oesterdalaelv'
'Oka'
'Olt'
'Oulujoki'
'Ounasjoki'
'Paatsjoki'
'Petschora'
'Po'
'Pruth'
'Raab'
'Reuss'
'Rhein'
'Rhone'
'Saar'
'Salzach'
'Saone'
'Save'
'Schilka'
'Seine'
'Southern Morava'
'Suchona'
'Swir'
'Tajo'
'Theiss'
'Thjorsa'
'Tiber'
'Ticino'
'Tigris'
'Tobol'
'Umeaelv'
'Ural'
'Vaesterdalaelv'
'Volga'
'Vuoksi'
'Waag'
'Weichsel'
'Werra'
'Weser'
'Western Dwina'
'Western Morava'
'White Drin'
'Wurm'














