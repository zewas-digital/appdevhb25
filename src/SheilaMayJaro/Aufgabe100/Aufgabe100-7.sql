Select Distinct Name, Length
from geo_river 
Inner Join river on geo_river.river = river.name
Inner Join encompasses on geo_river.country = encompasses.country
Where continent = 'Europe'
Order by Length 

# name, province, population
'Anguilla', 'Anguilla', '14436'
'American Samoa', 'American Samoa', '65628'
'Antigua and Barbuda', 'Antigua and Barbuda', '65647'
'Andorra', 'Andorra', '72766'
'Aruba', 'Aruba', '103065'
'Albania', 'Albania', '3249136'
'Armenia', 'Armenia', '3463574'
'Azerbaijan', 'Azerbaijan', '7676953'
'Afghanistan', 'Afghanistan', '22664136'
'Algeria', 'Algeria', '29183032'











