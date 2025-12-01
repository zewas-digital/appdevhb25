USE bibliotheksverwaltung;

CREATE TABLE Buch
(
	ISBN VARCHAR(30) NOT NULL,
    IntegerID INT NOT NULL,
    Verlag VARCHAR(20) NULL,
    Sprache VARCHAR(20) DEFAULT 'Deutsch',
    Erscheinungsjahr DATE NULL,
    Titel VARCHAR(20) Null,
    PRIMARY KEY(ISBN),
    foreign key (IntegerID) REFERENCES autor(IntegerID)
);