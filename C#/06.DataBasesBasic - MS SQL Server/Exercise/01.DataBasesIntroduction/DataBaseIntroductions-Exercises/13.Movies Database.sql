CREATE DATABASE Movies
GO

USE Movies


--•	Directors (Id, DirectorName, Notes)
CREATE TABLE Directors
(
	Id INT NOT NULL PRIMARY KEY,
	DirectorName NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
);

INSERT INTO Directors(Id,DirectorName)
VALUES
(
	1,
	'Director One'
),
(
	2,
	'Director Two'
),
(
	3,
	'Director Three'
),
(
	4,
	'Director Four'
),
(
	5,
	'Director Five'
);

--•	Genres (Id, GenreName, Notes)
CREATE TABLE Genres
(
	Id INT NOT NULL PRIMARY KEY,
	GenreName NVARCHAR(50) NOT NULL,
	Notes NVARCHAR (MAX)
)

INSERT INTO Genres(Id,GenreName)
VALUES
(
	1,
	'Genre One'
),
(
	2,
	'Genre Two'
),
(
	3,
	'Genre Three'
),
(
	4,
	'Genre Four'
),
(
	5,
	'Genre Five'
);

--•	Categories (Id, CategoryName, Notes)
CREATE TABLE Categories
(
	Id INT NOT NULL  PRIMARY KEY,
	CategoryName NVARCHAR (50) NOT NULL,
	Notes NVARCHAR (MAX)
)

INSERT INTO Categories(Id,CategoryName)
VALUES
(
       1,
       'Category One'
),
(
       2,
       'Category Two'
),
(
       3,
       'Category Three'
),
(
       4,
       'Category Four'
),
(
       5,
       'Category Five'
);

--•	Movies (Id, Title, DirectorId, CopyrightYear, Length, GenreId, CategoryId, Rating, Notes)
CREATE TABLE Movies
(
	Id INT NOT NULL PRIMARY KEY,
	Title NVARCHAR(255) NOT NULL,
	DirectorId INT FOREIGN KEY REFERENCES Directors(Id),
	CopyrightYear INT,
	Length  NVARCHAR(50),
	GenreId INT FOREIGN KEY REFERENCES Genres(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	Rating INT,
	Notes NVARCHAR (MAX)
);

INSERT INTO Movies(Id,Title,DirectorId,GenreId,CategoryId)
VALUES
(
       1,
       'Title One',
       2,
       3,
       4
),
(
       2,
       'Title Two',
       3,
       4,
       5
),
(
       3,
       'Title Three',
       1,
       2,
       3
),
(
       4,
       'Title Four',
       5,
       1,
       3
),
(
       5,
       'Title Five',
       3,
       5,
       2
);

