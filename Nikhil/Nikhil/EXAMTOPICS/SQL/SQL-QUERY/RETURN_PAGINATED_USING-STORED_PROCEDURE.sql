USE [employees]
GO
/****** Object:  StoredProcedure [dbo].[UPS_EmployeePaginated]    Script Date: 12/9/2020 10:43:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[UPS_EmployeePaginated]
	-- Add the parameters for the stored procedure here
	@StartRowIndex int,
	@PageSize int,
	@TotalCount int OUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT first_name,last_name,gender,hire_date,birth_date FROM employees

	ORDER BY emp_no OFFSET @StartRowIndex ROWS FETCH NEXT @PageSize ROWS ONLY

	SELECT @TotalCount = COUNT(emp_no) FROM employees
END



