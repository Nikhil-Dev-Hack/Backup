USE [employees]
GO
/****** Object:  StoredProcedure [dbo].[UPS_OptionalParameters]    Script Date: 12/9/2020 10:49:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[UPS_OptionalParameters]
	-- Add the parameters for the stored procedure here
	@EmployeeId int = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF @EmployeeId IS NULL
		BEGIN
			SELECT * FROM employees
		END
	ELSE 
		BEGIN 
			SELECT* FROM employees WHERE emp_no = @EmployeeId
		END
END


EXEC [dbo].[UPS_OptionalParameters]

EXEC [dbo].[UPS_OptionalParameters] 1
