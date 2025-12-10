CREATE TABLE Author(
    AuthorID INT PRIMARY KEY,
    Firstname VARCHAR(50),
    Lastname VARCHAR(50)
);

CREATE TABLE Book( 
    BookID INT PRIMARY KEY,
    AuthorID INT,
    Title VARCHAR(50),
    Publisher VARCHAR(50),
    Releaseyear INT,
    Language VARCHAR(50),
    FOREIGN KEY (AuthorID) REFERENCES Author(AuthorID)
);