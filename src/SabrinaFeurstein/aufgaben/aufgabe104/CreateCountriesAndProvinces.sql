drop database if exists CountriesAndProvinces;
create database CountriesAndProvinces;
use CountriesAndProvinces;

create table Country
(Code varchar(4) primary key not null,
Name varchar(30) unique not null,
Capital varchar(30) not null,
Continent varchar(30) not null);

create table Province
(Name varchar(30) not null,
Capital varchar(30) not null,
Population int not null,
Country varchar(4) not null,
primary key (Name, Country),
foreign key (Country) references Country(Code));