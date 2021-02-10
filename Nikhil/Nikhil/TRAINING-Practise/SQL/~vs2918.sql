-- Trim unnecessary space from the string in SQL Server

DECLARE @myName varchar(50)
SET @myName = ' ITFunda.com '
SELECT @myName
SELECT LTRIM(@myName), RTRIM(@myName), LTRIM(RTRIM(@myName))

-- Get the length of the string in SQL Server

SELECT LEN('NIKHIL')

--Convert the data type of the SQL Server variables

DECLARE @year int
SELECT @year = 1975
SELECT CAST(@year as varchar(5)) + ' year'

-- Get the difference between two dates in SQL Server

SELECT
DATEDIFF(YY, '08/29/1998', GETDATE()) AgeInYears,
DATEDIFF(MM, '08/29/1998', GETDATE()) AgeInMonths,
DATEDIFF(DD, '08/29/1998', GETDATE()) AgeInDays

-- Check for validate date in SQL Server

SELECT
ISDATE('08/29/2015') InValidDate,
ISDATE(GETDATE()) ValidDate

-- Return Day name of the week, day of the week, and month name in SQL Server

SELECT
DATENAME(WEEKDAY, GETDATE()) as DayName,
DATEPART(WEEKDAY, GETDATE()) as DayOfTheWeek,
DATENAME(MONTH, GETDATE()) As MonthName

-- Concatenate more than one columns in SQL Server

SELECT CONCAT(
Customer_Name,
SPACE(1),
Customer_Mobile_Number,
SPACE(1),
Customer_EmailID,
space(2)
)
FROM [nbanuri].[dbo].[Customer]

--Concatenate two string types columns separated by a string in SQL Server

SELECT Customer_Name + SPACE(1) + Customer_EmailID
FROM [nbanuri].[dbo].[Customer]

-- User aggregate functions like AVG, MIN, MAX, SUM etc in SQL Server

SELECT SUM(Salary) TotalSalary,
AVG(Salary) AverageSalary,
MIN(Salary) LowestSalary,
MAX(Salary) HighestSalary
FROM [nbanuri].[dbo].[EmployeeData]

--Transfer data from one table to another in SQL Server

INSERT INTO MyDetails (FullName, City)
 SELECT FirstName, LastName FROM [nbanuri].[dbo].[Products]

 --Get records from the table that contains a specific word in SQL Server

 SELECT * FROM [nbanuri].[dbo].[EmployeeData]
WHERE EmployeeName + ' ' + Email LIKE '%v%'

--Retrieve random records from the database table in SQL Server

SELECT TOP 2 * FROM [nbanuri].[dbo].[EmployeeData] ORDER BY NEWID()

--Filter result returned from Group by clause in SQL Server

SELECT
EmployeeID,EmployeeName,Email,
SUM(Salary) AS NetSalary,
SUM(Salary) AS PPFDeduction
FROM [nbanuri].[dbo].[EmployeeData]
GROUP BY EmployeeID,EmployeeName,Email
HAVING EmployeeID = 'TP01'

--