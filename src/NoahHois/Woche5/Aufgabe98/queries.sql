
-- create
CREATE TABLE AUTOR (
  AutorID INTEGER PRIMARY KEY,
  Vorname TEXT NOT NULL,
  Nachname TEXT NOT NULL
);
CREATE TABLE BUECHER (
BuchID INTEGER PRIMARY KEY,
Titel TEXT NOT NULL,
Erscheinungsjahr INTEGER NOT NULL,
Sprache TEXT NOT NULL,
Verlag TEXT NOT NULL
);
-- insert
INSERT INTO AUTOR VALUES (0001, 'Albert', 'Einstein');
INSERT INTO AUTOR VALUES (0002, 'Benjamin', 'Hauser');
INSERT INTO BUECHER VALUES (0001, 'MORE 4', 2011, 'Englisch', 'hebling');
INSERT INTO BUECHER VALUES (0290, 'Noahs Pommes Eistee', 2025, 'Chinesisch', 'Hauser Verlag');
INSERT INTO BUECHER VALUES (5923, 'Der Herr der Ringe. Die Gefähren.',2001 , 'Deutsch', 'Hauser Verlag');			
-- fetch 
SELECT * FROM BUECHER WHERE Sprache = 'Englisch';
