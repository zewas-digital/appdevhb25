Select Distinct country.name
From country
Inner Join geo_lake on geo_lake.country = country.code
Inner Join geo_mountain on geo_mountain.country = country.code
Inner Join lake on lake.name = geo_lake.lake
Inner Join mountain on mountain.name = geo_mountain.mountain
Where lake.Depth >= 1 AND mountain.height >= 1500

# name
'Italy'
'Turkey'
'United States'
'Albania'
'Canada'
'Peru'
'Tanzania'
'France'
'Iran'
'Germany'
'Switzerland'
'Bolivia'
'Austria'
'Costa Rica'
'Chad'
'Sudan'
'Kenya'
'Ethiopia'
'Norway'
'Indonesia'
'Mexico'
'China'
'Russia'
'Greece'
'Zaire'
'Kyrgyzstan'
'Argentina'
'Macedonia'
'Venezuela'
'Australia'
'Nicaragua'
'Niger'
'Sweden'
'Rwanda'
'Kazakstan'
'Egypt'
'Cameroon'
'Uganda'
























