CREATE TABLE Users (
    Id SERIAL PRIMARY KEY,
    FirstName VARCHAR(100),
    LastName VARCHAR(100),
    Email VARCHAR(100),
    Username VARCHAR(100),
    Gender VARCHAR(10),
    DateOfBirth DATE,
    Country VARCHAR(100)
);
