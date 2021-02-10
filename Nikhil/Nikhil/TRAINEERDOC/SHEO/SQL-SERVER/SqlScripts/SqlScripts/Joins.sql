SELECT * FROM PersonalDetails
SELECT * FROM Files

-- INSERT INTO Files VALUES (108, 'KaushikPdf', 'pdf', 1)

-- INNER JOIN
SELECT p.PersonalDetailsId, p.FirstName, p.LastName, p.Age, p.Active, 
		f.FileName, f.FileType, f.Active, f.FileId FROM PersonalDetails p, Files f
		WHERE p.PersonalDetailsId = f.PersonalDetailsId
		AND
		p.FirstName LIKE 'Y%'

-- INNER JOIN
SELECT p.PersonalDetailsId, p.FirstName, p.LastName, p.Age, p.Active,
		f.FileName, f.FileType, f.Active, f.FileId FROM PersonalDetails p
		JOIN Files f on p.PersonalDetailsId = f.PersonalDetailsId

-- LEFT JOIN / LEFT OUTER JOIN
SELECT p.PersonalDetailsId, p.FirstName, p.LastName, p.Age, p.Active,
		f.FileName, f.FileType, f.Active, f.FileId FROM PersonalDetails p
		LEFT OUTER JOIN Files f on p.PersonalDetailsId = f.PersonalDetailsId

-- RIGHT JOIN
SELECT p.PersonalDetailsId, p.FirstName, p.LastName, p.Age, p.Active,
		f.FileName, f.FileType, f.Active, f.FileId FROM PersonalDetails p
		RIGHT OUTER JOIN Files f on p.PersonalDetailsId = f.PersonalDetailsId
		WHERE f.Active = 1