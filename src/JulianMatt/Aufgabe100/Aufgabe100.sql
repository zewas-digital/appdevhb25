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

Das Unabhängigkeitsdatum von Ländern die eine Wüste haben und die ethnische Gruppe African

Welche Länder haben genau 3 Städte? Welche Länder sind dies?

Welche Organisationen haben deren Hauptsitz in Österreich? Wie viele Mitglieder haben diese Organisationen?

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
