-- Drop  Database zoo;
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
    ZooID INT,
    Foreign Key(ZooID) References Zoo(ZooID)
);

-- Tabelle Gattung
Create Table Gattung(
    GattungID INT Auto_Increment Primary Key,
    Name Varchar(50)
);

-- Tabelle Tiere
Create Table Tiere(
	TierID INT Auto_Increment Primary Key,
    Name Varchar(50),
    GattungID INT,
    GehegeID INT,
    Foreign Key(GehegeID) References Gehege(GehegeID),
    Foreign Key(GattungID) References Gattung(GattungID)
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
	TierID INT,
    FutterID INT,
    Menge Decimal(10,2),
    Primary Key (TierID, FutterID),
    Foreign Key (TierID) References Tiere(TierID),
    Foreign Key (FutterID) References Futter(FutterID)
);

-- Tabelle Gehege_Pfleger
Create Table Gehege_Pfleger(
	GehegeID INT,
    PflegerID INT,
    Primary Key (GehegeID, PflegerID),
    Foreign Key (GehegeID) References Gehege(GehegeID),
    Foreign Key (PflegerID) References Pfleger(PflegerID)
);

