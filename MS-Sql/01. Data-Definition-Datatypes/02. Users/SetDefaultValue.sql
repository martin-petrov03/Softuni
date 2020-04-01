ALTER TABLE Users
ADD CONSTRAINT DF_LastLoginTime
DEFAULT GETDATE() FOR LastLoginTime

INSERT INTO Users(Username, [Password], ProfilePicture, IsDeleted)
VALUES
('Tosho', '123', NULL, 1)

SELECT * FROM Users