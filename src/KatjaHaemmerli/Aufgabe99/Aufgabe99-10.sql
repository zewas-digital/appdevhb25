-- 10) Welche Bücher sind in den Jahren 1997 und 2008 erschienen? Antwort:

SELECT *
From Buch
Where Erscheinungsjahr = 1997 OR Erscheinungsjahr = 2008;

-- oder noch besser:
SELECT *
From Buch
Where Erscheinungsjahr IN(1997, 2008);