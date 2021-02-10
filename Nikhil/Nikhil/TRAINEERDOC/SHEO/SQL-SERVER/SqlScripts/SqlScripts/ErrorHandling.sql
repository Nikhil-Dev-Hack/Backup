BEGIN TRY
	SELECT 20/0
END TRY
BEGIN CATCH
	SELECT ERROR_NUMBER(), ERROR_MESSAGE();
	-- Do not use RAISEERROR, it is being deprecated
	THROW 50001, 'Ooooooops, you can''t divide by 0', 1;
END CATCH