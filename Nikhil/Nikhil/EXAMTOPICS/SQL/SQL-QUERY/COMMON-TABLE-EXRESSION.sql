WITH EmployeeCTE ([Name])
AS
(
	SELECT last_name FROM employees
	WHERE last_name LIKE '%N%'
	GROUP BY last_name
)

SELECT * FROM EmployeeCTE

SELECT * FROM employees
