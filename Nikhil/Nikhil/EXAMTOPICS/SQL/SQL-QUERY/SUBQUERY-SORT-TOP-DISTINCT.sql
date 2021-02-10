-- Return top n records from the database
USE employees
SELECT TOP(10)  * FROM Employees1 

--Retrieve distinct (unique) record from SQL Server 

SELECT DISTINCT ManagerID FROM Employees1

-- Sorted records from the SQL Server

SELECT * FROM Birds
				ORDER BY TypeOfBird ASC


--Use sub-query to return data from database

SELECT FullName = (SELECT FirstName+'.'+SPACE(1)+LastName FROM Employees1 WHERE EmployeeID = ED.EmpID),Mobile,Area,Country   FROM EmployeeDetails AS ED

