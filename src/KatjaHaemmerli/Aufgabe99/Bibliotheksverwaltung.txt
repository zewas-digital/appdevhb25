DROP DATABASE IF EXISTS Bibliotheksverwaltung;

CREATE DATABASE IF NOT EXISTS Bibliotheksverwaltung;

USE Bibliotheksverwaltung;

CREATE TABLE Autor (
    Id int AUTO_INCREMENT PRIMARY KEY
    , Nachname varchar(255) NOT NULL
    , Vorname varchar(255) NOT NULL
);

CREATE TABLE Buch (
    ISBN varchar(255) PRIMARY KEY
    , Titel varchar(255) NOT NULL
    , Erscheinungsjahr int NOT NULL
    , Verlag varchar(255) NOT NULL
    , Sprache varchar(32) NOT NULL
    , Autor int 
    , FOREIGN KEY (Autor) REFERENCES Autor(Id)
);

insert into Autor (Nachname, Vorname) values ('Elsberg', 'Marc');
insert into Autor (Nachname, Vorname) values ('King', 'Stephen');
insert into Autor (Nachname, Vorname) values ('Gibran', 'Khalil');
insert into Autor (Nachname, Vorname) values ('Coelho', 'Paulo');
insert into Autor (Nachname, Vorname) values ('Cormen', 'Thomas H.');
insert into Autor (Nachname, Vorname) values ('Knuth', 'Donald E.');
insert into Autor (Nachname, Vorname) values ('Tolkien', 'J.R.R.');
insert into Autor (Nachname, Vorname) values ('Kaiser', 'Ulrich');
insert into Autor (Nachname, Vorname) values ('Gaarder', 'Jostein');
insert into Autor (Nachname, Vorname) values ('Dürrenmatt', 'Friedrich');

insert into Buch (ISBN, Titel, Erscheinungsjahr, Verlag, Sprache, Autor) values ('978-3442380299', 'BLACKOUT - Morgen ist es zu spät', 2013, 'Blanvalet Taschenbuch Verlag', 'Deutsch', 1 );
insert into Buch (ISBN, Titel, Erscheinungsjahr, Verlag, Sprache, Autor) values ('978-3734100932', 'ZERO - Sie wissen, was du tust', 2016, 'Blanvalet Taschenbuch Verlag', 'Deutsch', 1 );
insert into Buch (ISBN, Titel, Erscheinungsjahr, Verlag, Sprache, Autor) values ('978-3764506322', 'GIER - Wie weit würdest du gehen?', 2019, 'Blanvalet Taschenbuch Verlag', 'Deutsch', 1 );
insert into Buch (ISBN, Titel, Erscheinungsjahr, Verlag, Sprache, Autor) values ('978-3734105579', 'HELIX - Sie werden uns ersetzen', 2018, 'Blanvalet Taschenbuch Verlag', 'Deutsch', 1 );

insert into Buch (ISBN, Titel, Erscheinungsjahr, Verlag, Sprache, Autor) values ('978-3404130894', 'Shining', 2019, 'Lübbe', 'Deutsch', 2 );
insert into Buch (ISBN, Titel, Erscheinungsjahr, Verlag, Sprache, Autor) values ('978-3453504080', 'Es', 2019, 'Heyne Verlag', 'Deutsch', 2 );
insert into Buch (ISBN, Titel, Erscheinungsjahr, Verlag, Sprache, Autor) values ('978-3453435797', 'Friedhof der Kuscheltiere', 2011, 'Heyne Verlag', 'Deutsch', 2 );

insert into Buch (ISBN, Titel, Erscheinungsjahr, Verlag, Sprache, Autor) values ('978-3843601757', 'Der Prophet', 2012, 'Patmos Verlag', 'Deutsch', 3 );

insert into Buch (ISBN, Titel, Erscheinungsjahr, Verlag, Sprache, Autor) values ('978-3257237276', 'Der Alchimist', 2008, 'Diogenes', 'Deutsch', 4 );

insert into Buch (ISBN, Titel, Erscheinungsjahr, Verlag, Sprache, Autor) values ('978-0262033848', 'Introduction to Algorithms', 2013, 'The MIT Press', 'Englisch', 5 );

insert into Buch (ISBN, Titel, Erscheinungsjahr, Verlag, Sprache, Autor) values ('978-0201896831', 'The Art of Computer Programming: Volume 1: Fundamental Algorithms', 1997, 'Addison-Wesley', 'Englisch', 6 );
insert into Buch (ISBN, Titel, Erscheinungsjahr, Verlag, Sprache, Autor) values ('978-0201896848', 'The Art of Computer Programming: Volume 2: Seminumerical Algorithms', 1997, 'Prentice Hall', 'Englisch', 6 );
insert into Buch (ISBN, Titel, Erscheinungsjahr, Verlag, Sprache, Autor) values ('978-0201896855', 'The Art of Computer Programming: Volume 3: Sorting and Searching', 1998, 'Addison-Wesley', 'Englisch', 6 );

insert into Buch (ISBN, Titel, Erscheinungsjahr, Verlag, Sprache, Autor) values ('978-3908934011', 'Der Herr der Ringe. Die Gefähren.', 2001, 'Klett Cotta', 'Deutsch', 7 );
insert into Buch (ISBN, Titel, Erscheinungsjahr, Verlag, Sprache, Autor) values ('978-3608953107', 'Der Herr der Ringe. Die zwei Türme.', 1987, 'Klett Cotta', 'Deutsch', 7 );
insert into Buch (ISBN, Titel, Erscheinungsjahr, Verlag, Sprache, Autor) values ('978-3608955385', 'Der Herr der Ringe. Die Rückkehr des Königs.', 2008, 'Klett Cotta', 'Deutsch', 7 );

insert into Buch (ISBN, Titel, Erscheinungsjahr, Verlag, Sprache, Autor) values ('978-3836227575', 'C/C++: Das umfassende Lehrbuch', 2014, 'Galileo Computing', 'Deutsch', 8 );

insert into Buch (ISBN, Titel, Erscheinungsjahr, Verlag, Sprache, Autor) values ('978-3257230475', 'Die Physiker. Eine Komödie in zwei Akten', 1998, 'Diogenes Verlag', 'Deutsch', 10 );