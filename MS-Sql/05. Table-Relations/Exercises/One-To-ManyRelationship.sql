USE TableRelations

CREATE TABLE Manufacturers(
	ManufacturerID INT NOT NULL PRIMARY KEY,
	Name VARCHAR(50),
	[EstablishedOn] DATE
)

CREATE TABLE Models(
	ModelID INT NOT NULL,
	[Name] NVARCHAR(50),
	[ManufacturerID] INT FOREIGN KEY REFERENCES Manufacturers(ManufacturerID),
	CONSTRAINT PK_CompositeStudentIDExamID
	PRIMARY KEY(ManufacturerID)
)