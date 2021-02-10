-- Handle error in stored procedures in SQL Server 
BEGIN TRY
	SELECT 'IT'/2
END TRY
BEGIN CATCH

END CATCH
--How to catch and throw errors
BEGIN TRY 
	SELECT 'IT'/2
END TRY
BEGIN CATCH
	THROW
END CATCH
--Custom error messages
BEGIN TRY
	SELECT 'IT'*2
END TRY
BEGIN CATCH
	THROW 50001,'Always use integer to multiply',1
END CATCH
--GET MORE DETAILS ABOUT ERROR USING INBUILT FUNCTIONS
BEGIN TRY
	SELECT 'IT'*2
END TRY
BEGIN CATCH
	SELECT ERROR_MESSAGE(),ERROR_NUMBER(),ERROR_LINE(),ERROR_PROCEDURE(),ERROR_SEVERITY(),ERROR_STATE();
END CATCH