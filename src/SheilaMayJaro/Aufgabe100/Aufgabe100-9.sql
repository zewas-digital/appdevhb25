Select *
From geo_island 
Left Outer Join islandIn on geo_island.island = islandIn.island
Left Outer Join religion on geo_island.country = religion.country
Where (islandIn.sea = 'Pacific Ocean' AND religion.Percentage > 50  AND religion.Name = 'Muslim')

# Island, Country, Province, Island, Sea, Lake, River, Country, Name, Percentage
'New Guinea', 'RI', 'Indonesia', 'New Guinea', 'Pacific Ocean', NULL, NULL, 'RI', 'Muslim', '87'



















