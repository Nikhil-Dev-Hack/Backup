-- Declare variables to hold cursor data for each record
DECLARE @AutoIdC int
DECLARE @FirstNameC varchar(50)
DECLARE @LastNameC varchar(50)

-- declare table to hold temporary data
DECLARE @myTable as TABLE
(
	PersonId int,
	FullName varchar(100)
)

-- declare
DECLARE myCursor CURSOR FOR 
	SELECT PersonalDetailsId, FirstName, LastName FROM PersonalDetails WHERE PersonalDetailsId > 50 -- put where clause if any
	-- SELECT * FROM PersonalDetails

-- open
OPEN myCursor

-- fetch records from the cursor
FETCH NEXT FROM myCursor 
	INTO @AutoIdC, @FirstNameC, @LastNameC

WHILE @@FETCH_STATUS = 0
BEGIN
	-- PRINT @AutoIdC 

	INSERT INTO @myTable(PersonId, FullName) VALUES (@AutoIdC, @FirstNameC + ' ' + @LastNameC)

	FETCH NEXT FROM myCursor
		INTO @AutoIdC, @FirstNameC, @LastNameC
END
CLOSE myCursor -- must to close
DEALLOCATE myCursor -- must to deallocate

SELECT * FROM @myTable WHERE FullName LIKE 'H%'