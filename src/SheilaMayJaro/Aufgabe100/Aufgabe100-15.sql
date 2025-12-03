Select organization.Name, Count(isMember.type = 'member')
From country 
Inner Join organization on organization.country = country.code
Inner Join isMember on isMember.country = country.code
Where country.name = 'Austria'
Group by organization.Name

# Name, Count(isMember.type = 'member')
'International Atomic Energy Agency', '69'
'Nuclear Suppliers Group', '69'
'Organization for Security and Cooperation in Europe', '69'
'Organization of Petroleum Exporting Countries', '69'
'United Nations Industrial Development Organization', '69'
'United Nations Relief and Works Agency for Palestine Refugees in the Near East', '69'





















