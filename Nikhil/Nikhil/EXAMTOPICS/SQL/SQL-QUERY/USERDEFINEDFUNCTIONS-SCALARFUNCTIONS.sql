USE [TollPlusLocal]
GO
/****** Object:  UserDefinedFunction [dbo].[EmployeeSVF]    Script Date: 12/9/2020 4:34:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
ALTER FUNCTION  [dbo].[EmployeeSVF]
(
	-- Add the parameters for the function here
	@EmployeeId nvarchar(50)
)
RETURNS nvarchar(50)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @EmployeeFname nvarchar(50)

	-- Add the T-SQL statements to compute the return value here
	SELECT @EmployeeFname = EmployeeFname +''+EmployeeLname FROM Employees WHERE EmployeeId = @EmployeeId

	-- Return the result of the function
	RETURN @EmployeeFname

END

SELECT [dbo].[EmployeeSVF]('TS01')
