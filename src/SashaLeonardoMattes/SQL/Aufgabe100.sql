--1.	Wie viele Einwohner hat Österreich?
select population from country where name = "Austria"
--2.	Welche Flüsse fließen durch Österreich?
select river from geo_river where country = "A"
--3.	Alle Länder die mit einem A anfangen
select name from country where name like "A%"
--4.	Wie viele Einwohner hat der Kontinent Europa?
select Sum(population) 
from encompasses e 
left join country c on e.Country = c.Code
where Continent = "Europe"
--5.	Welche Flüsse fließen durch Europa (nur den Flussnamen)?
select r.river
from encompasses e 
join country c on e.Country = c.Code
join geo_river r on r.Country = c.Code
where Continent = "Europe"
--6.	Alle Flüsse die durch Europa fließen (nur Flüsse und deren Länge), sortiert nach Länge
select gr.river, r.Length
from encompasses e 
join country c on e.Country = c.Code
join geo_river gr on gr.Country = c.Code
join river r on r.Name = gr.River
where Continent = "Europe"
order by r.Length
--7.	Alle Länder die mit einem A anfangen und deren Bundesländer mit Einwohnerzahl, sortiert nach Einwohnerzahl
select c.Name, p.Name, p.Population
from country c
join province p on c.Code = p.Country
where c.Name like "A%"
order by p.Population
--8.	Was ist der größte Berg von Österreich? Wie hoch ist er?
select m.Name, max(m.Height)
from country c
join geo_mountain gm on c.Code = gm.Country
join mountain m on gm.Mountain = m.Name
where c.Name = "Austria"
group by m.Name
order by height desc
limit 1
--9.	Alle Inseln im Pazifik mit >50% islamischem Bekenntnis
select iI.island
from islandIn iI
join geo_island gI on iI.Island = gI.Island
join religion r on r.Country = gI.Country
join country c on c.Code = r.Country
where iI.Sea = "Pacific Ocean" and r.Name = "Muslim" and r.percentage > 50
--10.	Alle 3000er, welche in einem Land sind, welches zu mindestens 60% römisch Katholisch ist
select m.Name
from mountain m
join geo_mountain gm on m.Name = gm.Mountain
join country c on gm.Country = c.Code
join religion r on r.Country = c.Code
where m.Height > 2999 and r.Name = "Roman Catholic" and r.Percentage > 59
--11.	Einwohnerzahl pro Religion
select r.Name, sum(c.population/100*r.Percentage)as populationOfReligion
from religion r
join country c on r.Country = c.Code
group by r.Name 
--12.	Welches sind die 3 größten Städte von Amerika (Kontinent)?
select c.Name, c.population
from city c
join encompasses e on c.Country = e.Country
where continent = "America"
order by c.population desc
limit 3
--13.	Das Unabhängigkeitsdatum von Ländern die eine Wüste haben und die ethnische Gruppe African
select c.Name, p.Independence
from country c
join geo_desert d on d.Country = c.Code
join EthnicGroup e on e.Country = c.Code
join politics p on p.Country = c.Code
where e.Name = "African" and p.independence is not null
--14.	Welche Länder haben genau 3 Städte? Welche Länder sind dies?
select co.Name
from country co
join city ci on ci.Country = co.Code
group by co.name
having Count(ci.Name) = 3
--15.	Welche Organisationen haben deren Hauptsitz in Österreich? Wie viele Mitglieder haben diese Organisationen?
select o.Name, count(i.Country)
from organization o
join isMember i on o.Abbreviation = i.Organization
join country c on c.Code = o.country
where i.Type = "member" and o.Country = "A"
group by o.Name
--16.	Alle Länder mit mindestens einem See mit mindestens 100 Meter Tiefe und mindestens einem Berg mit mindestens 1500 Höhenmeter
select distinct c.name
from country c
join geo_lake gl on gl.Country = c.Code
join lake l on l.Name = gl.Lake
join geo_mountain gm on gm.Country = c.Code
join mountain m on m.Name = gm.Mountain
where l.Depth > 99 and m.Height > 1499
--17.	Alle Länder, nur die Namen, und wenn sie haben, das Meer dazu
select c.Name, s.Sea
from country c
left join geo_sea s on c.Code = s.Country
--18.	Erstelle eine neue “Organization” mit dem Namen “DCV-Grundkurs”. Suche dir ein paar Länder aus, die Mitglied in dieser "Organization" sind und speichere die Mitgliedschaft in die Datenbank.
insert into organization (abbreviation, name, established)
values ("DCV-GK", "DCV-Grundkurs", "2025-12-01")

insert into isMember (country, organization, type)
values ("A", "DCV-GK", "member"),
("B", "DCV-GK", "member"),
("AUS", "DCV-GK", "member")
--19.	Gib alle Mitglieder der neuen Organization aus. Sind alle Mitglieder dabei, die du hinzugefügt hast?
select * from isMember
where organization = "DCV-GK"
--20.	Wir gehen 2 Monate in die Zukunft: Der Kurs ist vorbei. Jetzt gibt es eine neue internationale Organisation: “Alumni DCV-Grundkurs”. Alle Mitglieder von “DCV-Grundkurs” werden nun automatisch Mitglied in der Organisation “Alumni DCV Grundkurs”. Die Mitgliedschaft bei "DCV-Grundkurs" endet im selben Moment.
insert into organization (abbreviation, name, established)
values ("ADCV-GK", "Alumni DCV-Grundkurs", "2025-12-01");

insert into isMember (country, organization, type)
select iM.country, "ADCV-GK", type
from isMember iM
join organization o on o.Abbreviation = iM.Organization
where o.abbreviation = "DCV-GK";
--21.	Nachdem die Organisation “DCV-Grundkurs” keine Mitglieder mehr hat, soll diese gelöscht werden.
DELETE from organization
where abbreviation = "DCV-GK";
--22.	Aktualisiere die Höhe des Großglockners.
update mountain 
set height = 3800
where name = "Grossglockner"
--23.	Erstelle das Land Transnistrien. Es liegt in Europa. Wenn du anschließend einen alle europäischen Staaten inkl. Namen selektierst, soll auch Transnistrien in der Ergebnisliste sein.
insert into Country (Name, Code)
values ("Transnistrien", "TRN")
--24.	Speichere den höchsten Berg und die Hauptstadt in die Datenbank. Prüfe die Ergebnisse mit einem SELECT.
Update country
set capital = "Transnistrien City"
where code = "TRN"

Insert into geo_mountain (mountain, country, province)
values ("Mount Everest", "TRN", "TRN-Provinz")

select c.Name, capital, m.name, height
from mountain m
join geo_mountain gm on m.Name = gm.Mountain
join country c on gm.Country = c.Code
where height = (select max(height) from mountain) and c.Name = "Transnistrien"
--25.	Ändere den Namen der Türkei auf "Türkiye".
update country
set name = "Türkiye"
where name = "Turkey"
--26.	Thailand hat eine neue Hauptstadt: Nusantara. Speichere das in die Datenbank.
update country
set Capital = "Nusantara"
where name = "Thailand"
--27.	Es gibt eine weitere "Organization", die nicht in unserer Datenbank vorhanden ist: die Visegrad Gruppe. Erstelle die "Organization" und ordne ihr Mitglieder zu. Die Hauptstadt dieses Bündnisses ist die ungarische Stadt Visegrad.
insert into organization (abbreviation, name, City, Country)
values ("VG", "Visegrad Gruppe", "Visegrad", "H")

insert into isMember (country, organization, type)
values ("A", "VG", "member"),
("B", "VG", "member"),
("AUS", "VG", "member")
--28.	Gib eine Liste der Mitglieder EU und deren Hauptstädte aus. Vergleiche deine Ergebnisse mit der aktuellen Mitgliederliste.
select country, capital, type
from isMember iM
join Country c on im.Country = c.Code
where organization = "EU" and Type ="member" 

select * 
from isMember
where organization = "EU"
--29.	DELETE: Großbritannien hat die EU verlassen.
DELETE from isMember
where Country = "GB" and organization = "EU";