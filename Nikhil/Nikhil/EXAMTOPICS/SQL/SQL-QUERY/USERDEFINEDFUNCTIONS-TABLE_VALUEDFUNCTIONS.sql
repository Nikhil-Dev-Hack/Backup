USE [TollPlusLocal]
GO
/****** Object:  UserDefinedFunction [dbo].[EmployeeTVF]    Script Date: 12/9/2020 4:44:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER FUNCTION [dbo].[EmployeeTVF]
(	
	-- Add the parameters for the function here
	@Salary money
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT * FROM Employees WHERE Salary >= @Salary
)

SELECT * FROM [dbo].[EmployeeTVF] (10000000)
