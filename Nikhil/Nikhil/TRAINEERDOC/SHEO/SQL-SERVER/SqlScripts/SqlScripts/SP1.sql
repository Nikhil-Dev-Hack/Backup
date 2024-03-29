USE [SqlHowTo]
GO
/****** Object:  StoredProcedure [dbo].[LoadAllMyDetails]    Script Date: 3/18/2015 11:37:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Munna
-- Create date: 18-Mar-2015
-- Description:	Get all records from MyDetails table
-- =============================================
ALTER PROCEDURE [dbo].[LoadAllMyDetails]
	-- Add the parameters for the stored procedure here
	@FullName varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT AutoId, FullName, City FROM MyDetails
	WHERE FullName = @FullName
	 ORDER BY FullName

	DECLARE @Count int
	SELECT @Count = Count(AutoId) FROM MyDetails WHERE FullName = @FullName

	RETURN @Count

END
