DECLARE @AutoId int
DECLARE @FullName varchar(100)

DECLARE MyDetailsCursor CURSOR FOR
SELECT PersonalDetailsId, FirstName + ' ' + LastName FROM PersonalDetails
WHERE PersonalDetailsId > 70;

OPEN MyDetailsCursor

FETCH NEXT FROM MyDetailsCursor INTO @AutoId, @FullName

WHILE @@FETCH_STATUS = 0
BEGIN
	PRINT CAST(@AutoId as varchar(20))+ ' -> ' + @FullName
	FETCH NEXT FROM MyDetailsCursor INTO @AutoId, @FullName
END
CLOSE MyDetailsCursor
DEALLOCATE MyDetailsCursor
