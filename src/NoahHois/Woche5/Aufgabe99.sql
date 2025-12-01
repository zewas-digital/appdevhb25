1) Wie viele Autoren befinden sich in der Tabelle 'Autor'?

SELECT Id FROM autor;
 
2) Welche Id hat der Autor mit dem Namen J.R.R. Tolkien?

SELECT id FROM autor Where Nachname = 'Tolkien' and Vorname = 'J.R.R.';
 
3) Geben Sie die gesamte Bücherliste aus (Tabelle 'Bücher').

SELECT * FROM buch;
 
4) Welche Bücher hat der Autor mit der Id=2 geschrieben? Das Ergebnis soll nach dem Erscheinungsjahr aufsteigend sortiert sein.

SELECT * FROM buch where Autor = 2 order by Erscheinungsjahr desc;
 
5) Welche ISBN hat das Buch 'Der Alchimist'?

SELECT ISBN FROM buch where titel = 'Der Alchimist';
 
6) Geben Sie alle Buchtitel der englischsprachigen Bücher aus?

SELECT Titel FROM buch where Sprache = 'Englisch';
 
7) Wie viele Bücher vom Diogenes-Verlag befinden sich in der Tabelle 'Bücher'? (Erwartetes Ergebnis=2)

SELECT count(*) FROM buch where Verlag = 'Diogenes Verlag';
 
8) Welche Bücher sind 2019 erschienen?

SELECT Titel FROM buch where Erscheinungsjahr = 2019;
 
9) Welche Bücher sind seit 2015 erschienen?

SELECT Titel FROM buch where Erscheinungsjahr >= 2015;
 
10) Welche Bücher sind in den Jahren 1997 und 2008 erschienen?

select Titel from buch where Erscheinungsjahr = 1997 or Erscheinungsjahr = 2008;

11) Geben Sie die neuesten 3 Buchtitel aus.

select Titel from buch order by Erscheinungsjahr desc limit 3;
 
12) Suchen Sie nach den Büchern von Stephen King. Geben Sie die Buchtitel aus.

select Titel from buch where Autor = 2;
 
13) Wie heißt der Autor, der das Buch 'Introduction to Algorithms' geschrieben hat?

select autor.Nachname, autor.Vorname from autor join buch on autor.id = buch.Autor where Titel = 'Introduction to Algorithms';
 
14) Geben Sie eine Liste aller Bücher (Titel) mit dem jeweiligen Autor aus. Die Bücher sollen nach dem Nachnamen und Vornamen des Autors aufsteigend sortiert sein.

select Titel, Vorname, Nachname from autor join buch on autor.id = buch.Autor order by Autor.Nachname, Autor.Vorname desc;
 
15) Welche Bücher hat der Autor Marc Elsberg geschrieben? Geben Sie die ISBN, den Buchtitel, den Vor- und Nachnamen des Autors und das Erscheinungsjahr aus (in dieser Reihenfolge). Sortieren Sie das Ergebnis so, dass das aktuellste Buch ganz oben steht.

select ISBN, Titel, Vorname, Nachname, Erscheinungsjahr from autor join buch on autor.id = buch.Autor where Vorname = 'Marc' and Nachname = 'Elsberg' order by Erscheinungsjahr desc;

16) Wie viele Bücher die in deutscher Sprache und wie viele Bücher die in englischer Sprache geschrieben sind befinden sich in der Datenbank?
 
select count(Sprache) from autor join buch on autor.id = buch.Autor where Sprache = 'Deutsch';
select count(Sprache) as anzahlEnglisch from autor join buch on autor.id = buch.Autor where Sprache = 'Englisch';
 
17) In welchen Jahren sind 2 oder mehr Bücher erschienen?

select count(*), Erscheinungsjahr from buch group by Erscheinungsjahr having count(*) >= 2;
 
18) Wie viele Bücher sind von den einzelnen Verlagen in der Datenbank? Geben Sie den Verlag mit der Anzahl seiner Bücher aus. (Diogenes und Diogenes Verlag sollen jeweils mit einem Buch vorkommen.)
 
select Verlag, count(*) from buch group by Verlag;

19) Geben Sie den Vornamen, den Nachnamen und die Anzahl Bücher aus, die der jeweilige Autor geschrieben hat. Sortieren Sie das Ergebnis nach der Anzahl Bücher absteigend. Die Spalte mit der Anzahl soll 'Anzahl Bücher' heißen.
 
select Vorname, Nachname, count(*) as anzahlBücher from buch join Autor on autor.id = buch.Autor group by vorname, nachname order by anzahlBücher desc;
 
20) Von welchen Autor scheint kein Buch in der Datenbank zu sein?

select vorname, nachname from buch right join autor on autor.id = buch.Autor where buch.Autor is null;
 
21) Fügen Sie der Datenbank ein Buch hinzu: ISBN: 978-3423620000, Titel: Sofies Welt, Erscheinungsjahr: 2000, Verlag: dtv Verlagsgesellschaft, Autor: Jostein Gaarder
 
insert into buch Values (978-3423620000, 'Sofies Welt', 2000, 'dtv Verlagsgesellschaft', 'japanisch', 9);

22) Bei dem Buchtitel 'Der Herr der Ringe. Die Gefährten' hat sich ein Rechtschreibfehler eingeschlichen. Korrigieren Sie das Wort 'Gefähren' auf 'Gefährten'.

update buch
SET titel = 'Der Herr der Ringe. Die Gefährten'
WHERE isbn = '978-3908934011';