CREATE DATABASE Employee
GO

USE Employee
GO

CREATE TABLE Users
(id int PRIMARY KEY NOT NULL IDENTITY(1, 1),
name varchar(50),
email varchar(255),
password varchar(50))
GO

INSERT INTO Users
(name, email, password)
VALUES
('Mihir Karandikar', 'karandikar.mihir@outlook.com', 'mmmmmm')
GO

SELECT * FROM Users
GO