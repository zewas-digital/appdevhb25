# Wie viele Einwohner hat Österreich?

select population from country where country.Name = 'Austria';

Welche Flüsse fließen durch Österreich?

SELECT DISTINCT r.name FROM country c
INNER JOIN province p 
ON c.code = p.country
INNER JOIN geo_river gr
ON p.name = gr.province AND p.country = gr.country
INNER JOIN river r
ON gr.river = r.name
AND c.name = "Austria";

Alle Länder die mit einem A anfangen

SELECT * FROM country
WHERE name LIKE 'A%';

Wie viele Einwohner hat der Kontinent Europa?

select sum(population * percentage / 100) AS Einwohner
from country
join encompasses on country.code = encompasses.Country
where encompasses.continent = 'Europe';

Welche Flüsse fließen durch Europa (nur den Flussnamen)?

SELECT DISTINCT River.name
FROM continent
JOIN encompasses ON Continent.name = encompasses.continent
JOIN country ON encompasses.Country = Country.code
JOIN province ON Country.code = province.Country
JOIN geo_river ON Province.country = geo_river.country AND province.name = geo_river.province
JOIN River ON geo_river.River = River.name
WHERE Continent.name = 'Europe';

Alle Flüsse die durch Europa fließen (nur Flüsse und deren Länge), sortiert nach Länge

SELECT DISTINCT River.name, river.length
FROM continent
JOIN encompasses ON Continent.name = encompasses.continent
JOIN country ON encompasses.Country = Country.code
JOIN province ON Country.code = province.Country
JOIN geo_river ON Province.country = geo_river.country AND province.name = geo_river.province
JOIN River ON geo_river.River = River.name
WHERE Continent.name = 'Europe' order by river.Length DESC

Alle Länder die mit einem A anfangen und deren Bundesländer mit Einwohnerzahl, sortiert nach Einwohnerzahl

SELECT province.name, province.population
FROM country
JOIN province ON country.code = province.country
WHERE country.name LIKE 'A%' order by province.population;

Was ist der größte Berg von Österreich? Wie hoch ist er?

FROM country
JOIN province ON Country.code = province.country
JOIN geo_mountain ON province.country = geo_mountain.country AND province.name = geo_mountain.province
JOIN mountain ON geo_mountain.mountain = mountain.Name AND mountain.Height
WHERE country.Name = 'Austria' order by Mountain.height desc limit 1;

Alle Inseln im Pazifik mit >50% islamischem Bekenntnis

SELECT country.name, island.name, religion.Percentage, religion.name
FROM sea
JOIN islandin ON sea.Name = islandin.sea
JOIN island ON islandin.Island = island.name
JOIN geo_island ON Island.name = geo_island.island
JOIN Province ON geo_island.Province = province.name AND geo_island.country = province.country
JOIN Country ON province.Country = country.code
JOIN religion ON country.code = religion.country
WHERE sea.name = 'Pacific Ocean'
AND religion.name = 'Muslim'
AND religion.Percentage > 50;

Alle 3000er, welche in einem Land sind, welches zu mindestens 60% römisch Katholisch ist

SELECT DISTINCT mountain.name, mountain.Height, Religion.Percentage, country.name
FROM mountain
JOIN geo_mountain ON mountain.Name = geo_mountain.Mountain
JOIN province on geo_mountain.country = province.Country
JOIN Country ON Province.country = country.code
JOIN Religion ON Country.code = Religion.Country
WHERE Mountain.Height > 3000 AND religion.Percentage > 60 AND religion.name = 'Roman Catholic';

Einwohnerzahl pro Religion

SELECT sum(country.population), religion.name
FROM country
JOIN religion ON country.code = Religion.Country group by religion.name;

Welches sind die 3 größten Städte von Amerika (Kontinent)?

SELECT City.name
FROM Continent
JOIN encompasses ON Continent.name = encompasses.continent
JOIN country ON encompasses.Country = Country.code
JOIN province ON Country.code = province.Country
JOIN City ON province.name = city.name
WHERE Continent.name = 'America'
ORDER BY city.Population desc limit 3

Das Unabhängigkeitsdatum von Ländern die eine Wüste haben und die ethnische Gruppe African

SELECT distinct politics.Independence
FROM Country
JOIN politics ON country.code = politics.Country
JOIN ethnicgroup ON Country.code = ethnicgroup.Country
JOIN province ON Country.code = province.Country
JOIN geo_desert ON province.country = geo_desert.country
JOIN desert ON geo_desert.desert = desert.Name
WHERE ethnicgroup.name = 'African'

Welche Länder haben genau 3 Städte? Welche Länder sind dies?

SELECT country.name
FROM Country
JOIN City ON country.Code = city.country
GROUP BY country.name
HAVING count(city.name) = 3;

Welche Organisationen haben deren Hauptsitz in Österreich? Wie viele Mitglieder haben diese Organisationen?

SELECT organization.Country
FROM country
JOIN ismember ON country.Code = ismember.Country
JOIN organization ON ismember.Organization = organization.Country
WHERE organization.Country = 'Austria';

Alle Länder mit mindestens einem See mit mindestens 100 Meter Tiefe und mindestens einem Berg mit mindestens 1500 Höhenmeter

Alle Länder, nur die Namen, und wenn sie haben, das Meer dazu

Erstelle eine neue “Organization” mit dem Namen “DCV-Grundkurs”. Suche dir ein paar Länder aus, die Mitglied in dieser "Organization" sind und speichere die Mitgliedschaft in die Datenbank.

Gib alle Mitglieder der neuen Organization aus. Sind alle Mitglieder dabei, die du hinzugefügt hast?

Wir gehen 2 Monate in die Zukunft: Der Kurs ist vorbei. Jetzt gibt es eine neue internationale Organisation: “Alumni DCV-Grundkurs”. Alle Mitglieder von “DCV-Grundkurs” werden nun automatisch Mitglied in der Organisation “Alumni DCV Grundkurs”. Die Mitgliedschaft bei "DCV-Grundkurs" endet im selben Moment.

Nachdem die Organisation “DCV-Grundkurs” keine Mitglieder mehr hat, soll diese gelöscht werden.

Aktualisiere die Höhe des Großglockners.

Erstelle das Land Transnistrien. Es liegt in Europa. Wenn du anschließend einen alle europäischen Staaten inkl. Namen selektierst, soll auch Transnistrien in der Ergebnisliste sein.

Speichere den höchsten Berg und die Hauptstadt in die Datenbank. Prüfe die Ergebnisse mit einem SELECT.

Ändere den Namen der Türkei auf "Türkiye".

Thailand hat eine neue Hauptstadt: Nusantara. Speichere das in die Datenbank.

Es gibt eine weitere "Organization", die nicht in unserer Datenbank vorhanden ist: die Visegrad Gruppe. Erstelle die "Organization" und ordne ihr Mitglieder zu. Die Hauptstadt dieses Bündnisses ist die ungarische Stadt Visegrad.

Gib eine Liste der Mitglieder EU und deren Hauptstädte aus. Vergleiche deine Ergebnisse mit der aktuellen Mitgliederliste.

DELETE: Großbritannien hat die EU verlassen.