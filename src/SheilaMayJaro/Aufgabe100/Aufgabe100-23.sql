Insert into country (Name, Code) values ('Transnistrien', 'TRN');
Insert into encompasses(Country, Continent) values ('TRN', 'Europe');

Select *
From encompasses
Right Outer Join country on country.code = encompasses.country
Where continent = 'Europe'
Order By country.name;

# Country, Continent, Percentage, Name, Code, Capital, Province, Area, Population
'AL', 'Europe', '100', 'Albania', 'AL', 'Tirane', 'Albania', '28750', '3249136'
'AND', 'Europe', '100', 'Andorra', 'AND', 'Andorra la Vella', 'Andorra', '450', '72766'
'A', 'Europe', '100', 'Austria', 'A', 'Vienna', 'Vienna', '83850', '8023244'
'BY', 'Europe', '100', 'Belarus', 'BY', 'Minsk', 'Belarus', '207600', '10415973'
'B', 'Europe', '100', 'Belgium', 'B', 'Brussels', 'Brabant', '30510', '10170241'
'BIH', 'Europe', '100', 'Bosnia and Herzegovina', 'BIH', 'Sarajevo', 'Bosnia and Herzegovina', '51233', '2656240'
'BG', 'Europe', '100', 'Bulgaria', 'BG', 'Sofia', 'Bulgaria', '110910', '8612757'
'HR', 'Europe', '100', 'Croatia', 'HR', 'Zagreb', 'Croatia', '56538', '5004112'
'CY', 'Europe', '100', 'Cyprus', 'CY', 'Nicosia', 'Cyprus', '9251', '744609'
'CZ', 'Europe', '100', 'Czech Republic', 'CZ', 'Prague', 'Praha', '78703', '10321120'
'DK', 'Europe', '100', 'Denmark', 'DK', 'Copenhagen', 'Denmark', '43070', '5249632'
'EW', 'Europe', '100', 'Estonia', 'EW', 'Tallinn', 'Estonia', '45100', '1459428'
'FARX', 'Europe', '100', 'Faroe Islands', 'FARX', 'Torshavn', 'Faroe Islands', '1400', '43857'
'SF', 'Europe', '100', 'Finland', 'SF', 'Helsinki', 'Uusimaa', '337030', '5105230'
'F', 'Europe', '100', 'France', 'F', 'Paris', 'Ile de France', '547030', '58317450'
'D', 'Europe', '100', 'Germany', 'D', 'Berlin', 'Berlin', '356910', '83536115'
'GBZ', 'Europe', '100', 'Gibraltar', 'GBZ', 'Gibraltar', 'Gibraltar', '6.5', '28765'
'GR', 'Europe', '100', 'Greece', 'GR', 'Athens', 'Attiki', '131940', '10538594'
'GBG', 'Europe', '100', 'Guernsey', 'GBG', 'Saint Peter Port', 'Guernsey', '194', '62920'
'V', 'Europe', '100', 'Holy See', 'V', 'Vatican City', 'Holy See', '0.44', '840'
'H', 'Europe', '100', 'Hungary', 'H', 'Budapest', 'Budapest (munic.)', '93030', '10002541'
'IS', 'Europe', '100', 'Iceland', 'IS', 'Reykjavik', 'Iceland', '103000', '270292'
'IRL', 'Europe', '100', 'Ireland', 'IRL', 'Dublin', 'Ireland', '70280', '3566833'
'I', 'Europe', '100', 'Italy', 'I', 'Rome', 'Lazio', '301230', '57460274'
'GBJ', 'Europe', '100', 'Jersey', 'GBJ', 'Saint Helier', 'Jersey', '117', '87848'
'KOS', 'Europe', '100', 'Kosovo', 'KOS', 'Pristina', 'Kosovo', '10887', '1804838'
'LV', 'Europe', '100', 'Latvia', 'LV', 'Riga', 'Latvia', '64100', '2468982'
'FL', 'Europe', '100', 'Liechtenstein', 'FL', 'Vaduz', 'Liechtenstein', '160', '31122'
'LT', 'Europe', '100', 'Lithuania', 'LT', 'Vilnius', 'Lithuania', '65200', '3646041'
'L', 'Europe', '100', 'Luxembourg', 'L', 'Luxembourg', 'Luxembourg', '2586', '415870'
'MK', 'Europe', '100', 'Macedonia', 'MK', 'Skopje', 'Macedonia', '25333', '2104035'
'M', 'Europe', '100', 'Malta', 'M', 'Valletta', 'Malta', '320', '375576'
'GBM', 'Europe', '100', 'Man', 'GBM', 'Douglas', 'Man', '588', '73837'
'MD', 'Europe', '100', 'Moldova', 'MD', 'Chisinau', 'Moldova', '33700', '4463847'
'MC', 'Europe', '100', 'Monaco', 'MC', 'Monaco', 'Monaco', '1.9', '31719'
'MNE', 'Europe', '100', 'Montenegro', 'MNE', 'Podgorica', 'Montenegro', '14026', '672180'
'NL', 'Europe', '100', 'Netherlands', 'NL', 'Amsterdam', 'Noord Holland', '37330', '15568034'
'N', 'Europe', '100', 'Norway', 'N', 'Oslo', 'Oslo', '324220', '4383807'
'PL', 'Europe', '100', 'Poland', 'PL', 'Warsaw', 'Warszwaskie', '312683', '38642565'
'P', 'Europe', '100', 'Portugal', 'P', 'Lisbon', 'Lisbon', '92080', '9865114'
'RO', 'Europe', '100', 'Romania', 'RO', 'Bucharest', 'Bucuresti', '237500', '21657162'
'R', 'Europe', '20', 'Russia', 'R', 'Moscow', 'Moskva', '17075200', '148178487'
'RSM', 'Europe', '100', 'San Marino', 'RSM', 'San Marino', 'San Marino', '60', '24521'
'SRB', 'Europe', '100', 'Serbia', 'SRB', 'Belgrade', 'Serbia', '77474', '7379339'
'SK', 'Europe', '100', 'Slovakia', 'SK', 'Bratislava', 'Slovakia', '48845', '5374362'
'SLO', 'Europe', '100', 'Slovenia', 'SLO', 'Ljubljana', 'Slovenia', '20256', '1951443'
'E', 'Europe', '100', 'Spain', 'E', 'Madrid', 'Madrid', '504750', '39181114'
'SVAX', 'Europe', '100', 'Svalbard', 'SVAX', 'Longyearbyen', 'Svalbard', '62049', '2116'
'S', 'Europe', '100', 'Sweden', 'S', 'Stockholm', 'Stockholm', '449964', '8900954'
'CH', 'Europe', '100', 'Switzerland', 'CH', 'Bern', 'BE', '41290', '7207060'
'TRN', 'Europe', NULL, 'Transnistrien', 'TRN', NULL, NULL, NULL, NULL
'TR', 'Europe', '5', 'Turkey', 'TR', 'Ankara', 'Ankara', '780580', '62484478'
'UA', 'Europe', '100', 'Ukraine', 'UA', 'Kiev', 'Kyyivska', '603700', '50864009'
'GB', 'Europe', '100', 'United Kingdom', 'GB', 'London', 'Greater London', '244820', '58489975'




























