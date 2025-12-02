1. Wie viele Einwohner hat Österreich?

use mondial;
select sum(population), country from city
WHERE country = 'AUS';

Ausgabe: 12153500	AUS

2. Welche Flüsse fließen durch Österreich?

use mondial;

select r.river
From city c 
	Join geo_river r 
    on c.country = r.country
where c.country = "A";

Ausgabe: Rhein
Lech
Iller
Donau
Donau
Lech
Isar
Inn
Raab
...

3. Alle Länder die mit einem A anfangen

use mondial;
select name from Country
where name Like '%A%';

Ausgabe: 
Afghanistan
Albania
Algeria
American Samoa
Andorra
Angola
Anguilla
Antigua and Barbuda
Argentina
Armenia
Aruba
Australia
Austria
Azerbaijan
Bahamas
Bahrain
Bangladesh
Barbados
...

4. Wie viele Einwohner hat der Kontinent Europa?

use mondial;
select sum(c.population)
from city c
	join encompasses e
    on e.country = c.country
    where e.continent like "Europ%";

Ausgabe: 267644944

5. Welche Flüsse fließen durch Europa (nur den Flussnamen)?

use mondial;
select l.river
from located l
	join encompasses e
    on e.country = l.country
    where e.continent like "Europe%";

Ausgabe: Rhein
Po
Ohio River
Weser
Inn
Isar
Jenissej
Amur
Mississippi
Zaire
Nile
White Nile
...


6. Alle Flüsse die durch Europa fließen (nur Flüsse und deren Länge), sortiert nach Länge

use mondial;
select l.river, r.length
from located l
	join encompasses e
    on e.country = l.country
    join river r
    on r.river = l.river
    where e.continent like "Europe%"
    order by r.length desc;

Ausgabe: 
Irtysch	2450
Jenissej	1779
Jenissej	1779
Jenissej	1779
Amur	1620
Amur	1620
Amur	1620
Volga	1480
Volga	1480
Volga	1480
Volga	1480
Volga	1480
Volga	1480
Volga	1480
Volga	1480
Volga	1480
Volga	1480
...


7. Alle Länder die mit einem A anfangen und deren Bundesländer mit Einwohnerzahl, sortiert nach Einwohnerzahl

use mondial;
select province, country, population from city
where country Like "A%"
order by population desc;

Ausgabe: 

New South Wales	AUS	3657000
Victoria	AUS	3081000
Azerbaijan	AZ	1740000
Vienna	A	1583000
Queensland	AUS	1302000
Armenia	ARM	1200000
Western Australia	AUS	1193000
South Australia	AUS	1050000
Afghanistan	AFG	892000
...

8. Was ist der größte Berg von Österreich? Wie hoch ist er?

use mondial;
select max(m.height)
from mountain m
	join geo_mountain g
    on g.mountain = m.name
    join city c
    on c.country = g.country
where g.country = "A";

Ausgabe: 3797


9. Alle Inseln im Pazifik mit >50% islamischem Bekenntnis

use mondial;
select g.island
from geo_island g
	join religion r 
    on r.country = g.country
    join islandIn i 
    on i.island = g.island
where r.name Like "Muslim"
and r. percentage > 50
and i.sea Like "Pacific%";

Ausgabe: New Guinea

10. Alle 3000er, welche in einem Land sind, welches zu mindestens 60% römisch Katholisch ist (Berge >= 3000m)

use mondial;
select m.name
from mountain m
	join geo_mountain g 
    on g.mountain = m.name
    join religion r 
    on r.country = g.country
where m.height >= 3000 and r.name Like "Roman Catholic" and r.percentage >= 60;

Ausgabe:
Alpamayo
Huascaran
Pico Rocarre
Mulhacen
Pico de Aneto
Vignemale
Ampato
...




11. Einwohnerzahl pro Religion

use mondial;
select sum(c.population), r.name
from city c
	join religion r 
    on r.country = c.country
    group by r.name;

Ausgabe 83893675	Jains
        129965484	Hindu
        187080168	Buddhist
        23495818	Bahai
        16076000	Coptic Christian
        2100	Mormon
        ...



12. Welches sind die 3 größten Städte von Amerika (Kontinent)?

use mondial;
select e.country, c.population
from encompasses e
	join city c 
    on e.country = c.country
    where e.continent = "America"
    order by c.population desc
    limit 0,3;

Ausgabe: 
        MEX	9815795
        BR	9811776
        USA	7322564

13. Das Unabhängigkeitsdatum von Ländern die eine Wüste haben und die ethnische Gruppe African

use mondial;
select distinct p.independence
	from politics p
join geo_desert d
	on d.country = p.country
join ethnicGroup e 
	on e.country = p.country
where e.name = "African";

1964-10-24	Z

14. Welche Länder haben genau 3 Städte? Welche Länder sind dies?

use mondial;
select c.country
from city c
group by c.country
having count(c.name) = 3;

Ausgabe: SYR
        NZ
        BOL
        Q
        GCA


15. Welche Organisationen haben deren Hauptsitz in Österreich? Wie viele Mitglieder haben diese Organisationen?

use mondial;
select o.name, count(m.type)
from organization o
	join isMember m
	on m.organization = o.abbreviation
    join Country c 
    on c.code = o.country
where m.type = "member" and c.code = "A"
group by(o.name);

Ausgabe:
        International Atomic Energy Agency	123
        Nuclear Suppliers Group	34
        Organization for Security and Cooperation in Europe	55
        United Nations Industrial Development Organization	171
        United Nations Relief and Works Agency for Palestine Refugees in the Near East	10
        Organization of Petroleum Exporting Countries	12

16. Alle Länder mit mindestens einem See mit mindestens 100 Meter Tiefe und mindestens einem Berg mit mindestens 1500 Höhenmeter

use mondial;
SELECT gl.country
FROM geo_lake gl
JOIN Lake l
    ON l.name = gl.lake
JOIN geo_mountain gm
    ON gm.country = gl.country
JOIN Mountain m
    ON m.name = gm.mountain
WHERE l.depth >= 100
	AND m.height >= 1500
GROUP BY gl.country
	having count(l.name) >=1
	and count(m.name) >=1;

Ausgabe: 
        I
        TR
        USA
        AL
        CDN
        PE
        EAT
        F
        IR
        D
        CH


17. Alle Länder, nur die Namen, und wenn sie haben, das Meer dazu

use mondial;
SELECT co.name
from geo_lake gl
	join city c
		on gl.country = c.country
	join country co
		on co.code = gl.country
group by (co.name)
	having count(gl.lake) >= 1;

Ausgabe: 
        Germany
        Denmark
        Switzerland
        Nigeria
        Brazil
        Russia
        Peru

18. Erstelle eine neue “Organization” mit dem Namen “DCV-Grundkurs”. 
Suche dir ein paar Länder aus, die Mitglied in dieser "Organization" sind und speichere die Mitgliedschaft in die Datenbank.

use mondial;

INSERT INTO Organization 
(abbreviation,name, city, country, province, established)
VALUES 
('VDC', 'DCV-Grundkurs', 'Hamburg', 'D', 'HH', '2024-01-01');

INSERT INTO isMember (country, organization, type)
VALUES
    ('D','VDC' , 'member'),
    ('A', 'VDC', 'member'),
    ('CH', 'VDC', 'member');


Ausgabe: 
        DCV	DCV-Grundkurs	Hamburg	D	HH	2024-01-01

19. Gib alle Mitglieder der neuen Organization aus. Sind alle Mitglieder dabei, die du hinzugefügt hast?

select * from isMember
where organization = "VDC"

Ausgabe: 
        A	VDC	member
        CH	VDC	member
        D	VDC	member

20. Wir gehen 2 Monate in die Zukunft: Der Kurs ist vorbei. Jetzt gibt es eine neue internationale Organisation: “Alumni DCV-Grundkurs”. 
Alle Mitglieder von “DCV-Grundkurs” 
werden nun automatisch Mitglied in der Organisation “Alumni DCV Grundkurs”. Die Mitgliedschaft bei "DCV-Grundkurs" endet im selben Moment.



21. Nachdem die Organisation “DCV-Grundkurs” keine Mitglieder mehr hat, soll diese gelöscht werden.

22. Aktualisiere die Höhe des Großglockners.

23. Erstelle das Land Transnistrien. Es liegt in Europa. Wenn du anschließend einen alle europäischen Staaten inkl. Namen selektierst, soll auch Transnistrien in der Ergebnisliste sein.

24. Speichere den höchsten Berg und die Hauptstadt in die Datenbank. Prüfe die Ergebnisse mit einem SELECT.

25. Ändere den Namen der Türkei auf "Türkiye".

26. Thailand hat eine neue Hauptstadt: Nusantara. Speichere das in die Datenbank.

27. Es gibt eine weitere "Organization", die nicht in unserer Datenbank vorhanden ist: die Visegrad Gruppe. 
Erstelle die "Organization" und ordne ihr Mitglieder zu. Die Hauptstadt dieses Bündnisses ist die ungarische Stadt Visegrad.

28. Gib eine Liste der Mitglieder EU und deren Hauptstädte aus. Vergleiche deine Ergebnisse mit der aktuellen Mitgliederliste.

29. DELETE: Großbritannien hat die EU verlassen.


