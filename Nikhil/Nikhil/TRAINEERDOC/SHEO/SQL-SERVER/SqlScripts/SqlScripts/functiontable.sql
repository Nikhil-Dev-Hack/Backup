USE [IHaveBeenRenamed]
GO
/****** Object:  UserDefinedFunction [dbo].[GetJohnDetails]    Script Date: 3/19/2015 12:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER FUNCTION [dbo].[GetJohnDetails]
(	
	-- Add the parameters for the function here
	@fullName varchar(50)
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT * FROM Accounts WHERE FullName = @fullName
)
