Select mountain.name
From mountain
Left Outer Join geo_mountain on geo_mountain.mountain = mountain.name
Left Outer Join religion on religion.country = geo_mountain.country
where height >= 3000 AND religion.name = 'Roman Catholic' AND religion.Percentage >= 60

# name
'Alpamayo'
'Huascaran'
'Pico Rocarre'
'Mulhacen'
'Pico de Aneto'
'Vignemale'
'Ampato'
'Coropuna'
'Illampu'
'Illimani'
'Licancabur'
'Sajama'
'Pico de Teide'
'Grossglockner'
'Cerro Chirripo'
'Irazu'
'Licancabur'
'Llullaillaco'
'Ojos del Salado'
'Nevado del Ruiz'
'Ausangate'
'Pico Duarte'
'Cayambe'
'Chimborazo'
'Cotopaxi'
'Pico Basile'
'Nevado del Huila'
'Nevado de Colima'
'Monte Pissis'
'Cerro Chirripo'
'Monte Rosa'
'Piz Bernina'
'Pico Cristobal Colon'
'Aconcagua'
'Tupungato'
'Pico Bolivar'
'Nevado de Toluca'
'Popocatepetl'
'Vignemale'
'Popocatepetl'
'GranParadiso'
'Citlaltepetl (Pico de Orizaba)'
'Iztaccihuatl'
'Popocatepetl'
'Piton des Neiges'
'Barre des Ecrins'
'Mont Blanc'
'Nevado del Ruiz'
'Karisimbi'
'Etna'
'Marmolata'
'Llullaillaco'
'Monte Pissis'
'Ojos del Salado'
'GranParadiso'
'Matterhorn'
'Mont Blanc'
'Monte Rosa'
'Marmolata'
'Citlaltepetl (Pico de Orizaba)'















