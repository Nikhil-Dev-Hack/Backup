--JOINS

SELECT * FROM Employees1 AS E,EmployeeDetails AS DE WHERE E.EmployeeID = DE.EmpID

--JOINS USING 'JOIN' KEY WORD

SELECT * FROM Employees1 AS E JOIN EmployeeDetails AS DE ON E.EmployeeID = DE.EmpID

--JOINS USING 'INNER JOIN' KEY WORD

SELECT * FROM Employees1 AS E INNER JOIN EmployeeDetails AS DE ON E.EmployeeID = DE.EmpID

--JOINS USING 'LEFT JOIN' KEY WORD

SELECT * FROM Employees1 AS E LEFT JOIN EmployeeDetails AS DE ON E.EmployeeID = DE.EmpID

--JOINS USING 'RIGHT JOIN' KEY WORD

SELECT * FROM Employees1 AS E RIGHT JOIN EmployeeDetails AS DE ON E.EmployeeID = DE.EmpID
