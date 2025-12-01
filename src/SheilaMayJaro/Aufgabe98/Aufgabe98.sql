CREATE DATABASE Bibliothek; 
USE Bibliothek; 
CREATE TABLE Author(
    Vorname VARCHAR(20) NULL,
    Nachname VARCHAR(20) NULL, 
    ID INT NOT NULL PRIMARY KEY
); 
drop table Book;
CREATE TABLE Book(
    Titel VARCHAR(20) NOT NULL DEFAULT 'Titel',
    Erscheinungsjahr CHAR(4) NULL,
    Sprache VARCHAR(15) NULL,
    ISBNNummer VARCHAR(13) NULL, 
    Verlag VARCHAR(20) NULL,
    Signatur CHAR(5) NOT NULL PRIMARY KEY,
    Author_ID INT NOT NULL,
    FOREIGN KEY (Author_ID) REFERENCES Author(ID)
); 