Select organization.Name, Count(isMember.type = 'member') `Anzahl Mitglieder`
From organization 
Inner Join isMember on isMember.organization = organization.abbreviation
Where organization.country = 'A'
Group by organization.Name;

# Name, Anzahl Mitglieder
'International Atomic Energy Agency', '123'
'Nuclear Suppliers Group', '34'
'Organization for Security and Cooperation in Europe', '55'
'United Nations Industrial Development Organization', '171'
'United Nations Relief and Works Agency for Palestine Refugees in the Near East', '10'
'Organization of Petroleum Exporting Countries', '12'

