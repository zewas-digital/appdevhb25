Select Erscheinungsjahr, Count(*) as AnzahlBuecher
From Buch
GROUP BY Erscheinungsjahr
Having AnzahlBuecher >= 2

'1997', '2'
'1998', '2'
'2013', '2'
'2008', '2'
'2019', '3'



