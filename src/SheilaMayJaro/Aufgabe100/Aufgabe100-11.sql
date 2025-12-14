Select religion.name, Sum(population)
From religion
Left Outer Join country on country.code = religion.country
Group by religion.name

# name, Sum(population)
'African Methodist Episcopal', '67837'
'Anglican', '61104941'
'Armenian Apostolic', '5219810'
'Bahai', '66104410'
'Baptist', '4340314'
'Buddhist', '1568064018'
'Chondogyo', '45482291'
'Christian', '2813736231'
'Christian Congregationalist', '65628'
'Christian Orthodox', '216314822'
'Church Christ', '177504'
'Church of God', '331344'
'Church Tuvalu', '10146'
'Confucianism', '45482291'
'Coptic Christian', '63575107'
'Druze', '5421995'
'Ekalesia Niue', '1398'
'Episcopalian', '97120'
'Evangelical Alliance', '4394537'
'Hindu', '1388253633'
'Jains', '952107694'
'Jewish', '446449864'
'Judaism', '5421995'
'Kimbanguist', '46498539'
'Methodist', '3844728'
'Mormon', '82317'
'Muslim', '3913140828'
'Pentecostal', '8900954'
'Presbyterian', '8120024'
'Protestant', '1174372638'
'Roman Catholic', '1637266215'
'Seventh-Day Adventist', '5065183'
'Sikh', '952107694'
'Taoist', '21465881'
'United', '412902'
'United Church', '28869706'
'Uniting Church Australia', '2209'
















