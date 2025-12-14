Select Distinct country.name
From country
Inner Join geo_lake on geo_lake.country = country.code
AND geo_lake.province = country.province
Inner Join geo_mountain on geo_mountain.country = country.code
AND geo_mountain.province = country.province
Inner Join lake on lake.name = geo_lake.lake
Inner Join mountain on mountain.name = geo_mountain.mountain
Where lake.Depth >= 1 AND mountain.height >= 1500

# name
'Albania'
'Switzerland'
'Bolivia'
'Chad'
'Ethiopia'
'Indonesia'
'Kyrgyzstan'
'Macedonia'
'Nicaragua'
'Niger'
'Rwanda'
'Uganda'

