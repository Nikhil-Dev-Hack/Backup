SELECT * FROM dbo.GetJohnDetails('Martin Sak')

DECLARE @salary money
 SET @salary = dbo.GetSalary('Martin Sak')
 print @salary
SELECT * FROm Accounts