-- 18) Wie viele Bücher sind von den einzelnen Verlagen in der Datenbank? Geben Sie den Verlag mit der Anzahl seiner Bücher aus. (Diogenes und Diogenes Verlag sollen jeweils mit einem Buch vorkommen.)

select verlag as v, count(*) as anzahl_buecher
from buch 
group by verlag
order by anzahl_buecher desc;
