USE School

DELETE StudentsTeachers
WHERE TeacherId IN (SELECT Id FROM Teachers
		  WHERE Phone LIKE '%72%');

DELETE Teachers
WHERE Phone LIKE '%72%';