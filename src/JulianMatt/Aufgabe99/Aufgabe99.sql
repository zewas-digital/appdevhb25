1) Wie viele Autoren befinden sich in der Tabelle 'Autor'?
    SELECT * FROM bibliotheksverwaltung2.Autor;
    10

 
2) Welche Id hat der Autor mit dem Namen J.R.R. Tolkien?
    SELECT * FROM bibliotheksverwaltung2.Autor a
    Where a.Vorname = "J.R.R.";

    Id = 7
 
3) Geben Sie die gesamte Bücherliste aus (Tabelle 'Bücher').
    SELECT * FROM bibliotheksverwaltung2.buch b;
 
4) Welche Bücher hat der Autor mit der Id=2 geschrieben? Das Ergebnis soll nach dem Erscheinungsjahr aufsteigend sortiert sein.
    SELECT * 
    FROM bibliotheksverwaltung2.buch AS b
    Where  b.Autor = 2
    ORDER BY b.Erscheinungsjahr ASC;

 
5) Welche ISBN hat das Buch 'Der Alchimist'?
    SELECT * 
    FROM bibliotheksverwaltung2.buch AS b
    Where Titel = 'Der Alchimist';
 
6) Geben Sie alle Buchtitel der englischsprachigen Bücher aus?
    SELECT * 
    FROM bibliotheksverwaltung2.buch AS b
    Where Sprache = 'Englisch';
 
7) Wie viele Bücher vom Diogenes-Verlag befinden sich in der Tabelle 'Bücher'? (Erwartetes Ergebnis=2)
    SELECT * 
    FROM bibliotheksverwaltung2.buch AS b
    Where b.Verlag LIKE 'Diogenes%';

    Ergebnis = 2

 
8) Welche Bücher sind 2019 erschienen?
    SELECT * 
    FROM bibliotheksverwaltung2.buch AS b
    Where b.Erscheinungsjahr = 2019;

 
9) Welche Bücher sind seit 2015 erschienen?
    SELECT * 
    FROM bibliotheksverwaltung2.buch AS b
    Where b.Erscheinungsjahr >= 2015;
 
10) Welche Bücher sind in den Jahren 1997 und 2008 erschienen?
    SELECT * 
    FROM bibliotheksverwaltung2.buch AS b
    Where b.Erscheinungsjahr = 1997 
    OR b.Erscheinungsjahr = 2008;
 
11) Geben Sie die neuesten 3 Buchtitel aus.
    SELECT * 
    FROM bibliotheksverwaltung2.buch AS b
    order by b.Erscheinungsjahr DESC
    Limit 3;
 
12) Suchen Sie nach den Büchern von Stephen King. Geben Sie die Buchtitel aus.
    SELECT b.Titel
    FROM bibliotheksverwaltung2.buch AS b
    LEFT OUTER JOIN bibliotheksverwaltung2.Autor a ON b.Autor = a.Id
    Where a.Nachname = 'King' 
    AND a.Vorname = 'Stephen';
 
13) Wie heißt der Autor, der das Buch 'Introduction to Algorithms' geschrieben hat?
    SELECT a.Vorname, a.Nachname
    FROM bibliotheksverwaltung2.buch AS b
    LEFT OUTER JOIN bibliotheksverwaltung2.Autor a ON b.Autor = a.Id
    Where b.Titel = 'Introduction to Algorithms';
 
14) Geben Sie eine Liste aller Bücher (Titel) mit dem jeweiligen Autor aus. Die Bücher sollen nach dem Nachnamen und Vornamen des Autors aufsteigend sortiert sein.
    SELECT a.Vorname, a.Nachname, b.Titel
    FROM bibliotheksverwaltung2.buch AS b
    LEFT OUTER JOIN bibliotheksverwaltung2.Autor a ON b.Autor = a.Id
    order by a.Vorname ASC, a.Nachname;
    
15) Welche Bücher hat der Autor Marc Elsberg geschrieben? Geben Sie die ISBN, den Buchtitel, den Vor- und Nachnamen des Autors und das Erscheinungsjahr aus (in dieser Reihenfolge). Sortieren Sie das Ergebnis so, dass das aktuellste Buch ganz oben steht.
    SELECT b.ISBN, b.Titel, a.Vorname, a.Nachname, b.Erscheinungsjahr
    FROM bibliotheksverwaltung2.buch AS b
    LEFT OUTER JOIN bibliotheksverwaltung2.Autor a ON b.Autor = a.Id
    Where a.Vorname = 'Marc' 
    AND a.Nachname = 'Elsberg'
    order by b.Erscheinungsjahr DESC;

16) Wie viele Bücher die in deutscher Sprache und wie viele Bücher die in englischer Sprache geschrieben sind befinden sich in der Datenbank?
    SELECT b.Sprache,
		    COUNT(*)
    FROM buch AS b
    group by b.Sprache

17) In welchen Jahren sind 2 oder mehr Bücher erschienen?
    SELECT b.Erscheinungsjahr,
		    COUNT(*)
    FROM buch AS b
    group by b.Erscheinungsjahr
    having count(*) >= 2;
 
18) Wie viele Bücher sind von den einzelnen Verlagen in der Datenbank? Geben Sie den Verlag mit der Anzahl seiner Bücher aus. (Diogenes und Diogenes Verlag sollen jeweils mit einem Buch vorkommen.)
    SELECT b.Verlag,
		    COUNT(*) As "Geschriebene Bücher"
    FROM buch AS b
    group by b.Verlag
    Order by COUNT(*) DESC;

19) Geben Sie den Vornamen, den Nachnamen und die Anzahl Bücher aus, die der jeweilige Autor geschrieben hat. Sortieren Sie das Ergebnis nach der Anzahl Bücher absteigend. Die Spalte mit der Anzahl soll 'Anzahl Bücher' heißen.
    select  a.Vorname,
		    a.Nachname,
            Count(*) AS "Anzahl Bücher"
    From Autor a
    JOIN buch b ON a.ID = b.Autor

    Group By a.Vorname, a.Nachname
    Order by COUNT(*) DESC;

20) Von welchen Autor scheint kein Buch in der Datenbank zu sein?
    use bibliotheksverwaltung2;
    select  a.Vorname,
		    a.Nachname,
            Count(b.ISBN) AS "Anzahl Bücher"
		
    From Autor a
    LEFT JOIN buch b
		    ON  a.ID = b.Autor
          
    Group By a.Vorname, a.Nachname
    having COUNT(b.ISBN) = 0;

 
21) Fügen Sie der Datenbank ein Buch hinzu: ISBN: 978-3423620000, Titel: Sofies Welt, Erscheinungsjahr: 2000, Verlag: dtv Verlagsgesellschaft, Autor: Jostein Gaarder
    INSERT INTO buch (ISBN, Titel, Erscheinungsjahr, Verlag, Sprache, Autor)
    Values ('978-3423620000', 'Sofies Welt', 2000, 'dtv Verlagsgesellschaft', '', 9);
22) Bei dem Buchtitel 'Der Herr der Ringe. Die Gefährten' hat sich ein Rechtschreibfehler eingeschlichen. Korrigieren Sie das Wort 'Gefähren' auf 'Gefährten'.
    UPDATE buch
    SET Titel = 'Der Herr der Ringe. Die Gefährten'
    WHERE ISBN = '978-3908934011';