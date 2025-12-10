Create Database zoo;
use zoo;

-- Tabelle Zoo
Create Table Zoo (
	ZooID INT Auto_Increment Primary Key,
    Name Varchar(50),
    Jahr Year
);
    
-- Tabelle Gehege
Create Table Gehege(
	GehegeID INT Auto_Increment Primary Key,
    Name Varchar(50),
    Zoo_ZooID_FK INT,
    Foreign Key(Zoo_ZooID_FK) References Zoo(ZooID)
);

-- Tabelle Tiere
Create Table Tiere(
	TierID INT Auto_Increment Primary Key,
    Name Varchar(50),
    Gattung Varchar(50),
    Gehege_GehegeID_FK INT,
    Foreign Key(Gehege_GehegeID_FK) References Gehege(GehegeID)
);

-- Tabelle Futter
Create Table Futter(
	FutterID INT Auto_Increment Primary Key,
    Name Varchar(50),
    Einheit Varchar(20),
    Einheitspreis Decimal(10,2)
);

-- Tabelle Pfleger
Create Table Pfleger(
	PflegerID INT Auto_Increment Primary Key,
    Name Varchar(50)
);

-- Tabelle Futterbedarf
Create Table Futterbedarf(
	Tier_TierID_FK INT,
    Futter_FutterID_FK INT,
    Menge Decimal(10,2),
    Primary Key (Tier_TierID_FK, Futter_FutterID_FK),
    Foreign Key (Tier_TierID_FK) References Tiere(TierID),
    Foreign Key (Futter_FutterID_FK) References Futter(FutterID)
);

-- Tabelle Gehege_Pfleger
Create Table Gehege_Pfleger(
	Gehege_GehegeID_FK INT,
    Pfleger_PflegerID_FK INT,
    Primary Key (Gehege_GehegeID_FK, Pfleger_PflegerID_FK),
    Foreign Key (Gehege_GehegeID_FK) References Gehege(GehegeID),
    Foreign Key (Pfleger_PflegerID_FK) References Pfleger(PflegerID)
);