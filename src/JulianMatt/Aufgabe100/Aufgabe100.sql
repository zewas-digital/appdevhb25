Wie viele Einwohner hat Österreich?
    Use Mondial;

    Select *
    From Country
    Where Name = 'Austria';

    8023244
Welche Flüsse fließen durch Österreich?
    Use Mondial;

    Select *
    From geo_river
    Where Country = 'A';

Alle Länder die mit einem A anfangen
    Use Mondial;

    Select *
    From Country
    Where Name LIKE 'A%';

Wie viele Einwohner hat der Kontinent Europa?
    Use Mondial;

    Select c.Name, im.Organization
    From Country c
    Join isMember im ON c.Code = im.Country 
					    and im.Organization = 'EU';

Welche Flüsse fließen durch Europa (nur den Flussnamen)?
    Use Mondial;

    Select gr.river
    From Country c
    Join isMember im ON c.Code = im.Country 
					    and im.Organization = 'EU'
    JOIN geo_river gr ON c.Code = gr.Country;

Alle Flüsse die durch Europa fließen (nur Flüsse und deren Länge), sortiert nach Länge
    Use Mondial;

    Select gr.river, r.length
    From Country c
    Join isMember im ON c.Code = im.Country 
					    and im.Organization = 'EU'
    JOIN geo_river gr ON c.Code = gr.Country
    JOIN River r ON gr.river = r.name
    ORDER BY r.length ASC;
 
Alle Länder die mit einem A anfangen und deren Bundesländer mit Einwohnerzahl, sortiert nach Einwohnerzahl
    Use Mondial;

    Select c.Name, p.Name, p.Population
    From Country c
    Join Province p ON c.code = p.Country
    Where c.Name LIKE 'A%'
    ORDER BY p.Population;

Was ist der größte Berg von Österreich? Wie hoch ist er?
    Use Mondial;

    Select c.Name, gm.mountain
    From Country c
    Join geo_mountain gm ON c.code = gm.Country
    Where c.Name LIKE 'Austria';

Alle Inseln im Pazifik mit >50% islamischem Bekenntnis
    USE Mondial;

    Select r.Percentage, gl.Island, l.Sea
    From Country c
    Join Religion r ON c.code = r.country
				    and r.name = 'Muslim'
                    and r.percentage >50
    Join located l ON c.code = l.country
				    and l.Sea = 'Pacific Ocean'
    Join geo_island gl ON c.code = gl.country;

Alle 3000er, welche in einem Land sind, welches zu mindestens 60% römisch Katholisch ist
    USE Mondial;

    Select *
    From Country c
    JOIN geo_mountain gm ON c.code = gm.Country
    JOIN Mountain m ON gm.Mountain = m.name
	    			and m.Height > 3000
    JOIN Religion r ON c.code = r.country
				    and r.name = 'Roman Catholic'
                    and r.percentage >= 60;

Einwohnerzahl pro Religion
    USE Mondial;

    Select r.Name, sum(c.Population)
    From Country c
    JOIN Religion r ON c.code = r.country
    group by r.name;

Welches sind die 3 größten Städte von Amerika (Kontinent)?
    USE Mondial;

    Select c.name, p.name, p.area
    From Country c
    JOIN encompasses e ON c.code = e.country 
	    				AND e.continent = 'America'
    JOIN Province p ON c.code = p.country
    ORDER BY p.area DESC
    LIMIT 3;

Das Unabhängigkeitsdatum von Ländern die eine Wüste haben und die ethnische Gruppe African
    SELECT p.country, p.independence
    FROM Politics p
    JOIN geo_desert gd ON gd.country = p.country
    JOIN EthnicGroup e ON e.country = p.country
    WHERE e.name = 'African';

Welche Länder haben genau 3 Städte? Welche Länder sind dies?
    SELECT country
    FROM City
    GROUP BY country
    HAVING COUNT(*) = 3;

Welche Organisationen haben deren Hauptsitz in Österreich? Wie viele Mitglieder haben diese Organisationen?
    USE Mondial;

    Select o.name, im.organization, c.code, Count(im.type) AS Anzahl
    From Organization o
    JOIN isMember im ON o.abbreviation = im.organization
    JOIN Country c ON im.country = c.code AND c.code = 'A'
    Where o.country = 'A'
    GROUP BY o.name;


Alle Länder mit mindestens einem See mit mindestens 100 Meter Tiefe und mindestens einem Berg mit mindestens 1500 Höhenmeter
    Use Mondial;

    SELECT DISTINCT c.code, c.name, m.name
    FROM Country c
    JOIN geo_lake gl ON c.code = gl.country
    JOIN Lake l ON gl.lake = l.name 
    JOIN geo_mountain gm ON c.code = gm.country
    JOIN Mountain m ON gm.mountain = m.name 
    Where m.Height >= 1500 AND l.depth >= 100;

Alle Länder, nur die Namen, und wenn sie haben, das Meer dazu
    Use Mondial;

    SELECT distinct c.name, gs.sea
    From Country c
    LEFT JOIN geo_sea gs ON c.code = gs.country
    ORDER BY c.name;

Erstelle eine neue “Organization” mit dem Namen “DCV-Grundkurs”. Suche dir ein paar Länder aus, die Mitglied in dieser "Organization" sind und speichere die Mitgliedschaft in die Datenbank.
    Use Mondial;

    INSERT INTO Organization (name, abbreviation, city, country, province, established) 
    VALUES 
    ('DCV-Grundkurs', 'DG', 'Feldkirch', 'A', 'Vorarlberg', '2010-04-03');

    INSERT INTO isMember (organization, country, type)
    VALUES
    ('DG', 'A', 'member'),
    ('DG', 'G', 'member'),
    ('DG', 'USA', 'member');
Gib alle Mitglieder der neuen Organization aus. Sind alle Mitglieder dabei, die du hinzugefügt hast?
    Use Mondial;

    Select *
    From isMember im
    Where organization = 'DG';
Wir gehen 2 Monate in die Zukunft: Der Kurs ist vorbei. Jetzt gibt es eine neue internationale Organisation: “Alumni DCV-Grundkurs”. Alle Mitglieder von “DCV-Grundkurs” werden nun automatisch Mitglied in der Organisation “Alumni DCV Grundkurs”. Die Mitgliedschaft bei "DCV-Grundkurs" endet im selben Moment.
    Use Mondial;

    Insert INTO Organization (name, abbreviation, city, country, province, established)
    Value 
    ('Alumni DCV-Grundkurs', 'ADG', 'Feldkirch', 'A','Vorarlberg', '2015-06-07');

 
    Use Mondial;
    SET SQL_SAFE_UPDATES = 0;

    UPDATE isMember
    SET organization = 'ADG' Where organization = 'DG';

Nachdem die Organisation “DCV-Grundkurs” keine Mitglieder mehr hat, soll diese gelöscht werden.
    Use Mondial;
    DELETE FROM Organization
    Where abbreviation = 'DG';

Aktualisiere die Höhe des Großglockners.
    Use Mondial;
    SET SQL_SAFE_UPDATES = 0;

    UPDATE Mountain
    SET Height = 3798
    WHERE name = 'Grossglockner';

Erstelle das Land Transnistrien. Es liegt in Europa. Wenn du anschließend einen alle europäischen Staaten inkl. Namen selektierst, soll auch Transnistrien in der Ergebnisliste sein.
    Use Mondial;
    SET SQL_SAFE_UPDATES = 0;
    
    INSERT INTO Country (name, code, capital, province, area, population)
    value
    ('Transnistrieren', 'TAN', 'Transania', 'Transa', 45644, 5353029);

    INSERT INTO encompasses (continent, country, percentage)
    value
    ('Europe', 'TAN', '100');

    Select *
    From Country c
    JOIN encompasses e ON c.code = e.country 
					    AND e.continent = 'Europe';

Speichere den längsten Fluss und die Hauptstadt von Transnistrien in die Datenbank. Prüfe die Ergebnisse mit einem SELECT.
    UPDATE Country
    SET capital = 'Tiraspol'
    Where code = 'TAN';




    Use Mondial;
SET SQL_SAFE_UPDATES = 0;

INSERT INTO Province (name, country, area, population, capital, capprov)
value
('Grigoriopol District', 'TAN', 822, 39795, 'Grigoriopol', 'Grigoriopol District');

INSERT INTO Province (name, country, area, population, capital, capprov)
value
('Dubăsari District', 'TAN', 381, 31000, 'Dubăsari', 'Dubăsari District');

INSERT INTO geo_river (river, country, province)
value
('Dnister', 'TAN', 'Grigoriopol District');

INSERT INTO geo_river (river, country, province)
value
('Dnister', 'TAN', 'Dubăsari District');

INSERT INTO River (name, river, length, area, source, sourceelevation, esuary, estuaryelevation)
VALUE
('DNTR', 'Dniester', 1362, 68600, 'Eastern Beskids, Ukrainian Carpathians', 911, 'Dniester Estuary (Black Sea)', 0);




Ändere den Namen der Türkei auf "Türkiye".

Thailand hat eine neue Hauptstadt: Nusantara. Speichere das in die Datenbank.

Es gibt eine weitere "Organization", die nicht in unserer Datenbank vorhanden ist: die Visegrad Gruppe. Erstelle die "Organization" und ordne ihr Mitglieder zu. Die Hauptstadt dieses Bündnisses ist die ungarische Stadt Visegrad.

Gib eine Liste der Mitglieder EU und deren Hauptstädte aus. Vergleiche deine Ergebnisse mit der aktuellen Mitgliederliste.

DELETE: Großbritannien hat die EU verlassen.
