-- ================================================
-- Template generated from Template Explorer using:
-- Create Scalar Function (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION GetSalary
(
	-- Add the parameters for the function here
	@fullName varchar(50)
)
RETURNS money
AS
BEGIN
	-- Declare the return variable here
	DECLARE @salary money

	-- Add the T-SQL statements to compute the return value here
	SELECT @salary = Salary FROM Accounts WHERE FullName = @fullName

	-- Return the result of the function
	RETURN @salary

END
GO

