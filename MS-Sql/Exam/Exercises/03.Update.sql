USE Service

UPDATE Reports
SET CloseDate = CONVERT(date, getdate())
WHERE CloseDate IS NULL;