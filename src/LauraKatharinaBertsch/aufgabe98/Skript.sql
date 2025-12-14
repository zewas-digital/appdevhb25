CREATE DATABASE bibliothek;
USE bibliothek;
CREATE TABLE autor (
    id INT PRIMARY KEY AUTO_INCREMENT,
    lastname VARCHAR(20) NOT NULL,
    name VARCHAR(20) NOT NULL
);
CREATE TABLE book(
    isbn VARCHAR(20)PRIMARY KEY,
    title VARCHAR(20) NOT NULL,
    publisher VARCHAR(20) NOT NULL,
    languages VARCHAR(20) NOT NULL,
    yearOfPublication CHAR(4) NOT NULL
);
