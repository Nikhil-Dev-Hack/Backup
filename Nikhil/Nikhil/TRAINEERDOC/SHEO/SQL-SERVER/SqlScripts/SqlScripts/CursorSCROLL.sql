SELECT PersonalDetailsId, FirstName, LastName FROM PersonalDetails
--
DECLARE myCursor SCROLL CURSOR FOR
	SELECT PersonalDetailsId, FirstName, LastName FROM PersonalDetails

OPEN myCursor
-- 1st row
FETCH NEXT FROM myCursor

-- last row
FETCH LAST FROM myCursor

-- 2nd row
FETCH ABSOLUTE 2 FROM myCursor

-- 3 row after current row
FETCH RELATIVE 2 FROM myCursor

-- 1st
FETCH FIRST FROM myCursor

-- prior
FETCH NEXT FROM myCursor
FETCH PRIOR FROM myCursor

CLOSE myCursor
DEALLOCATE myCursor