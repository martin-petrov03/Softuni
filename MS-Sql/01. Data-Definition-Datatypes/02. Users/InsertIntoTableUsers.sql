USE Minions

INSERT INTO Users(Username,	[Password], ProfilePicture, LastLoginTime, IsDeleted) 
	VALUES
	('Pesho', '123', NULL, NULL, 0),
	('Gosho', '123', NULL, NULL, 0),
	('Ivan', '123', NULL, NULL, 1),
	('Test', '123', NULL, NULL, 1)

SELECT * FROM Users