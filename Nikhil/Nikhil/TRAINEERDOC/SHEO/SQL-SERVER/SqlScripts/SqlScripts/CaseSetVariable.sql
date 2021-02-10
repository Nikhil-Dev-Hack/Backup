 DECLARE @pdId int
SET @pdId = 31

DECLARE @isExists varchar(55)
SET @isExists =
       CASE
              WHEN EXISTS (SELECT PersonalDetailsId FROM Accounts
                                          WHERE PersonalDetailsId = @pdId)
                                   THEN 'Accounts detials exists.'
              WHEN EXISTS (SELECT PersonalDetailsId FROM PersonalDetails
                                          WHERE PersonalDetailsId = @pdId)
                                   THEN 'Personal Details Exists but Accounts
                                         Details do not'
              ELSE
                     'N/A'
       END;
print @isExists