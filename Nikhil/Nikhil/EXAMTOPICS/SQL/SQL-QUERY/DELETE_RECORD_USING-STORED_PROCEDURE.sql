USE [employees]
GO
/****** Object:  StoredProcedure [dbo].[UPS_DeleteEmployeeProcedure]    Script Date: 12/9/2020 10:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[UPS_DeleteEmployeeProcedure]
	-- Add the parameters for the stored procedure here
	@EmployeeDetailsId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE employees WHERE emp_no = @EmployeeDetailsId
END

EXEC [dbo].[UPS_DeleteEmployeeProcedure] 2
SELECT * FROM employees
