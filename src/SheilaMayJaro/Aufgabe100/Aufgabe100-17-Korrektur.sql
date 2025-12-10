Select country.name, geo_sea.sea
From country
Left Outer Join geo_sea on geo_sea.country = country.code
And geo_sea.province = country.province;

# name, sea
'Austria', NULL
'Afghanistan', NULL
'Antigua and Barbuda', 'Atlantic Ocean'
'Antigua and Barbuda', 'Caribbean Sea'
'Albania', 'Mediterranean Sea'
'American Samoa', 'Pacific Ocean'
'Andorra', NULL
'Angola', 'Atlantic Ocean'
'Armenia', NULL
'Aruba', 'Caribbean Sea'
'Australia', NULL
'Anguilla', 'Atlantic Ocean'
'Anguilla', 'Caribbean Sea'
'Azerbaijan', NULL
'Belgium', NULL
'Bangladesh', 'Gulf of Bengal'
'Barbados', 'Atlantic Ocean'
'Benin', 'Atlantic Ocean'
'Bermuda', 'Atlantic Ocean'
'Burkina Faso', NULL
'Bulgaria', 'Black Sea'
'Bhutan', NULL
'Burundi', NULL
'Bosnia and Herzegovina', 'Mediterranean Sea'
'Bolivia', NULL
'Brazil', NULL
'Bahrain', 'Persian Gulf'
'Brunei', 'South China Sea'
'Bahamas', 'Atlantic Ocean'
'British Virgin Islands', 'Atlantic Ocean'
'British Virgin Islands', 'Caribbean Sea'
'Belarus', NULL
'Belize', 'Caribbean Sea'
'Cuba', 'Gulf of Mexico'
'Cameroon', 'Atlantic Ocean'
'Cayman Islands', 'Caribbean Sea'
'Canada', 'Atlantic Ocean'
'Switzerland', NULL
'Cote dIvoire', 'Atlantic Ocean'
'Sri Lanka', 'Gulf of Bengal'
'Sri Lanka', 'Indian Ocean'
'Colombia', NULL
'Cocos Islands', 'Indian Ocean'
'Comoros', 'Indian Ocean'
'Cook Islands', 'Pacific Ocean'
'Costa Rica', NULL
'Cape Verde', 'Atlantic Ocean'
'Cyprus', 'Mediterranean Sea'
'Czech Republic', NULL
'Germany', NULL
'Djibouti', 'Gulf of Aden'
'Djibouti', 'Red Sea'
'Denmark', 'Baltic Sea'
'Denmark', 'Kattegat'
'Denmark', 'North Sea'
'Denmark', 'Skagerrak'
'Dominican Republic', 'Atlantic Ocean'
'Dominican Republic', 'Caribbean Sea'
'Algeria', 'Mediterranean Sea'
'Spain', NULL
'Kenya', NULL
'Tanzania', 'Indian Ocean'
'Uganda', NULL
'Ecuador', 'Pacific Ocean'
'Eritrea', 'Red Sea'
'El Salvador', 'Pacific Ocean'
'Egypt', NULL
'Ethiopia', NULL
'Estonia', 'Baltic Sea'
'France', NULL
'Falkland Islands', 'Atlantic Ocean'
'Faroe Islands', 'Atlantic Ocean'
'Faroe Islands', 'Norwegian Sea'
'French Guiana', 'Atlantic Ocean'
'Fiji', 'Pacific Ocean'
'Liechtenstein', NULL
'French Polynesia', 'Pacific Ocean'
'Micronesia', 'Pacific Ocean'
'Gabon', 'Atlantic Ocean'
'Gaza Strip', NULL
'Guernsey', 'The Channel'
'Jersey', 'The Channel'
'Man', 'Irish Sea'
'Gibraltar', 'Atlantic Ocean'
'Gibraltar', 'Mediterranean Sea'
'Guatemala', 'Caribbean Sea'
'Guatemala', 'Pacific Ocean'
'Georgia', 'Black Sea'
'Ghana', 'Atlantic Ocean'
'Guinea-Bissau', 'Atlantic Ocean'
'Equatorial Guinea', 'Atlantic Ocean'
'Greece', 'Mediterranean Sea'
'Greenland', 'Arctic Ocean'
'Greenland', 'Atlantic Ocean'
'Greenland', 'Norwegian Sea'
'Guadeloupe', 'Atlantic Ocean'
'Guadeloupe', 'Caribbean Sea'
'Guam', 'Pacific Ocean'
'Guyana', 'Atlantic Ocean'
'Hungary', NULL
'Honduras', NULL
'Saint Helena', 'Atlantic Ocean'
'Hong Kong', 'South China Sea'
'Croatia', 'Mediterranean Sea'
'Italy', 'Mediterranean Sea'
'Israel', 'Mediterranean Sea'
'India', NULL
'Iran', NULL
'Ireland', 'Atlantic Ocean'
'Ireland', 'Irish Sea'
'Iraq', NULL
'Iceland', 'Atlantic Ocean'
'Iceland', 'Norwegian Sea'
'Japan', NULL
'Jamaica', 'Caribbean Sea'
'Jordan', 'Red Sea'
'Cambodia', 'South China Sea'
'Kazakstan', NULL
'Kyrgyzstan', NULL
'Kiribati', 'Pacific Ocean'
'Saint Kitts and Nevis', 'Atlantic Ocean'
'Saint Kitts and Nevis', 'Caribbean Sea'
'Kosovo', NULL
'Kuwait', 'Persian Gulf'
'Luxembourg', NULL
'Laos', NULL
'Libya', 'Mediterranean Sea'
'Liberia', 'Atlantic Ocean'
'Lesotho', NULL
'Lithuania', 'Baltic Sea'
'Latvia', 'Baltic Sea'
'Malta', 'Mediterranean Sea'
'Morocco', 'Atlantic Ocean'
'Morocco', 'Mediterranean Sea'
'Macau', 'South China Sea'
'Malaysia', NULL
'Martinique', 'Atlantic Ocean'
'Martinique', 'Caribbean Sea'
'Mayotte', 'Indian Ocean'
'Monaco', 'Mediterranean Sea'
'Moldova', NULL
'Mexico', NULL
'Marshall Islands', 'Pacific Ocean'
'Macedonia', NULL
'Montenegro', 'Mediterranean Sea'
'Mongolia', NULL
'Montserrat', 'Atlantic Ocean'
'Montserrat', 'Caribbean Sea'
'Mozambique', 'Indian Ocean'
'Mauritius', 'Indian Ocean'
'Maldives', 'Indian Ocean'
'Maldives', 'Pacific Ocean'
'Malawi', NULL
'Myanmar', 'Andaman Sea'
'Norway', 'Skagerrak'
'Netherlands Antilles', 'Atlantic Ocean'
'Netherlands Antilles', 'Caribbean Sea'
'Namibia', 'Atlantic Ocean'
'Nauru', 'Pacific Ocean'
'New Caledonia', 'Pacific Ocean'
'Nepal', NULL
'Nicaragua', 'Caribbean Sea'
'Nicaragua', 'Pacific Ocean'
'Niue', 'Pacific Ocean'
'Netherlands', 'North Sea'
'Northern Mariana Islands', 'Pacific Ocean'
'North Korea', 'Sea of Japan'
'North Korea', 'Yellow Sea'
'Norfolk Island', 'Pacific Ocean'
'New Zealand', 'Pacific Ocean'
'Oman', 'Arabian Sea'
'Oman', 'Gulf of Oman'
'Oman', 'Persian Gulf'
'Portugal', 'Atlantic Ocean'
'Panama', 'Pacific Ocean'
'Palau', 'Pacific Ocean'
'Peru', 'Pacific Ocean'
'Pitcairn Islands', 'Pacific Ocean'
'Pakistan', 'Arabian Sea'
'Pakistan', 'Gulf of Oman'
'Pakistan', 'Indian Ocean'
'Poland', NULL
'Papua New Guinea', 'Pacific Ocean'
'Puerto Rico', 'Atlantic Ocean'
'Puerto Rico', 'Caribbean Sea'
'Paraguay', NULL
'Qatar', 'Persian Gulf'
'Russia', NULL
'Argentina', NULL
'Botswana', NULL
'Taiwan', 'East China Sea'
'Taiwan', 'Pacific Ocean'
'Taiwan', 'South China Sea'
'Central African Republic', NULL
'Congo', 'Atlantic Ocean'
'Chile', 'Atlantic Ocean'
'Chile', 'Pacific Ocean'
'Reunion', 'Indian Ocean'
'Guinea', 'Atlantic Ocean'
'Haiti', 'Atlantic Ocean'
'Haiti', 'Caribbean Sea'
'Indonesia', 'Andaman Sea'
'Indonesia', 'Indian Ocean'
'Indonesia', 'Malakka Strait'
'Indonesia', 'Pacific Ocean'
'Indonesia', 'South China Sea'
'Indonesia', 'Sulawesi Sea'
'Indonesia', 'Sunda Sea'
'Mauritania', 'Atlantic Ocean'
'Lebanon', 'Mediterranean Sea'
'Madagascar', 'Indian Ocean'
'Mali', NULL
'Niger', NULL
'Romania', NULL
'South Korea', 'East China Sea'
'South Korea', 'Sea of Japan'
'South Korea', 'Yellow Sea'
'Uruguay', 'Atlantic Ocean'
'Philippines', 'Pacific Ocean'
'Philippines', 'South China Sea'
'Philippines', 'Sulawesi Sea'
'South Africa', NULL
'San Marino', NULL
'Togo', 'Atlantic Ocean'
'Rwanda', NULL
'Sweden', 'Baltic Sea'
'Saudi Arabia', 'Persian Gulf'
'Saudi Arabia', 'Red Sea'
'Swaziland', NULL
'Finland', 'Baltic Sea'
'Singapore', 'Indian Ocean'
'Singapore', 'Malakka Strait'
'Singapore', 'South China Sea'
'Slovakia', NULL
'Solomon Islands', 'Pacific Ocean'
'Slovenia', 'Mediterranean Sea'
'Saint Martin', 'Atlantic Ocean'
'Saint Martin', 'Caribbean Sea'
'Suriname', 'Atlantic Ocean'
'Senegal', 'Atlantic Ocean'
'Somalia', 'Gulf of Aden'
'Somalia', 'Indian Ocean'
'Saint Pierre and Miquelon', 'Atlantic Ocean'
'Serbia', NULL
'Sao Tome and Principe', 'Atlantic Ocean'
'Sudan', NULL
'Svalbard', 'Arctic Ocean'
'Svalbard', 'Atlantic Ocean'
'Svalbard', 'Norwegian Sea'
'Seychelles', 'Indian Ocean'
'Syria', 'Mediterranean Sea'
'Tajikistan', NULL
'Chad', NULL
'Thailand', 'Andaman Sea'
'Thailand', 'Malakka Strait'
'Thailand', 'South China Sea'
'China', NULL
'Timor-Leste', 'Indian Ocean'
'Timor-Leste', 'Sunda Sea'
'Turkmenistan', NULL
'Tunisia', 'Mediterranean Sea'
'Tonga', 'Pacific Ocean'
'Türkiye', NULL
'Transnistrien', NULL
'Trinidad and Tobago', 'Atlantic Ocean'
'Trinidad and Tobago', 'Caribbean Sea'
'Turks and Caicos Islands', 'Atlantic Ocean'
'Tuvalu', 'Pacific Ocean'
'Ukraine', NULL
'United Arab Emirates', 'Persian Gulf'
'United States', NULL
'Uzbekistan', NULL
'Holy See', NULL
'Virgin Islands', 'Atlantic Ocean'
'Virgin Islands', 'Caribbean Sea'
'Vietnam', 'South China Sea'
'Vanuatu', 'Pacific Ocean'
'Wallis and Futuna', 'Pacific Ocean'
'Gambia', 'Atlantic Ocean'
'Sierra Leone', 'Atlantic Ocean'
'Nigeria', 'Atlantic Ocean'
'Dominica', 'Atlantic Ocean'
'Dominica', 'Caribbean Sea'
'West Bank', NULL
'Grenada', 'Atlantic Ocean'
'Grenada', 'Caribbean Sea'
'Saint Lucia', 'Atlantic Ocean'
'Saint Lucia', 'Caribbean Sea'
'Samoa', 'Pacific Ocean'
'Western Sahara', 'Atlantic Ocean'
'Saint Vincent and the Grenadines', 'Atlantic Ocean'
'Saint Vincent and the Grenadines', 'Caribbean Sea'
'Christmas Island', 'Indian Ocean'
'Yemen', 'Gulf of Aden'
'Yemen', 'Indian Ocean'
'Yemen', 'Red Sea'
'Venezuela', 'Caribbean Sea'
'Zambia', NULL
'Zaire', NULL
'Zimbabwe', NULL
