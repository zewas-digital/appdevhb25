CREATE TABLE Buecherliste
[Autor, Buch]
CREATE TABLE Autor(
    id INTEGER NOT NULL,
    Vorname VARCHAR(20), Nachname VARCHAR(20)
)
CREATE TABLE Buch(
    ISBN INTEGER NOT NULL PRIMARY KEY,
    Title VARCHAR(20), Erscheinungsjahr CHAR(4), Sprache VARCHAR(20), Verlag VARCHAR(20)
) 
