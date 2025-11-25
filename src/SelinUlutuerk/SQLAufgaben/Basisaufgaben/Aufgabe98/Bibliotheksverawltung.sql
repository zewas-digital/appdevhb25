Create Database Bibliotheksverwaltung;
USE Bibliotheksverwaltung;
create table Autor (AutorID integer Primary Key auto_increment, Vorname varchar(20), Nachname varchar(20));
create table Buch (BuchID integer Primary Key auto_increment, Titel varchar(20), Erscheinungsjahr date, Sprache varchar(20), Verlag varchar(20), Autor_AutorID_FK integer Foreigen Key)