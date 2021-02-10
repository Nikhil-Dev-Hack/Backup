--SELECT *, GenderName = CASE Gender
--						WHEN 'M' THEN 'Male'
--						WHEN 'F' THEN 'Female'
--						ELSE 'N/A'
--					END 
--	FROM Employees

SELECT * FROM Employees

SELECT * FROM Employees
ORDER BY
	CASE Gender 
	WHEN 'M' THEN Gender END ASC,
	CASE WHEN Gender = 'F' THEN Name 
	ELSE Location END ASC