DECLARE @startIndex int, @nthHighest int
SET @startIndex = 6
SET @nthHighest = 1

	SELECT Salary FROM Accounts ORDER BY Salary DESC
	OFFSET @startIndex ROWS FETCH NEXT @nthHighest ROWS ONLY



