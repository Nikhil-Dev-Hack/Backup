SELECT * FROM PersonalDetails
ORDER BY Active, 
       CASE Active 
			WHEN 1 THEN FirstName END 
			ASC,
       CASE 
			WHEN Active = 0 THEN LastName
			ELSE FirstName END 
			DESC


	