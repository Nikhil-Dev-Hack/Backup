-- SELECT * FROM PersonalDetails
DECLARE @AGE int
SET @AGE = 26
IF @AGE > SOME(
SELECT Age FROM PersonalDetails WHERE Age > 2000
)
PRINT 'Yes, all ages are greater than 25'
ELSE
PRINT 'No, all ages are NOT greater than 25'

