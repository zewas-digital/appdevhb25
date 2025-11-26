DROP DATABASE IF EXISTS Bibliotheksverwaltung;
CREATE DATABASE IF NOT EXISTS Bibliotheksverwaltung;
USE Bibliotheksverwaltung;

CREATE TABLE Autor (
  AutorId int PRIMARY KEY,
  Vorname varchar(20),
  Nachname varchar(20)
);

CREATE TABLE Buch (
ISBN int PRIMARY key,
Titel varchar(20),
Verlag varchar(30),
Erscheinungsjahr char(4),
Sprache varchar(20),
Autor int,
foreign key (Autor) references Autor(AutorId)
);

INSERT INTO Autor VALUES (1,'Donna', 'Tart');
INSERT INTO Autor VALUES (2,'Suzanne', 'Collins');

INSERT INTO Buch VALUES (34556,'The Goldfinch','Little, Brown and Company','2013','Englisch',1);
INSERT INTO Buch VALUES (87694,'The Hunger Games','Scholastic Us','2008','Englisch',2);
INSERT INTO Buch VALUES (98679,'Catching Fire','Scholastic Us','2009','Englisch',2);

SELECT * FROM Autor;
SELECT ISBN,Titel,Verlag,Erscheinungsjahr,Sprache,Vorname,Nachname FROM Buch b LEFT OUTER JOIN Autor a ON a.AutorId = b.Autor;