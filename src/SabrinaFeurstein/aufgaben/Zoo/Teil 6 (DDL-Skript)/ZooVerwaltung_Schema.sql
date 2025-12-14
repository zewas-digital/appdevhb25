drop database if exists ZooVerwaltung;
create database ZooVerwaltung;
use ZooVerwaltung;

create table Zoo
(ID int auto_increment primary key,
Name varchar(30) not null,
Gruendungsjahr year not null);

create table Pfleger
(Personalnummer int primary key,
Vorname varchar(30) not null,
Nachname varchar(30) not null,
Zoo int not null,
foreign key (Zoo) references Zoo(ID));

create table Gehege
(ID int auto_increment primary key,
Name varchar(30) not null,
Zoo int not null,
foreign key (Zoo) references Zoo(ID));

create table Verpflegung
(Pfleger int not null,
Gehege int not null,
primary key (Pfleger, Gehege));

create table Gattung
(ID int auto_increment primary key,
Bezeichnung varchar(30) not null);

create table Tier
(ID int auto_increment primary key,
Name varchar(30) not null,
Gehege int not null,
Gattung int not null,
foreign key (Gehege) references Gehege(ID),
foreign key (Gattung) references Gattung(ID));

create table Futter
(ID int auto_increment primary key,
Name varchar(30) not null,
Einheit varchar(5) not null,
Einheitspreis decimal(2) not null);

create table Futterbedarf
(Futter int not null,
Tier int not null,
Menge double not null,
primary key (Futter, Tier));