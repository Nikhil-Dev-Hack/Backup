USE [employees]
GO
/****** Object:  StoredProcedure [dbo].[UPS_UpdateEmployeeDetails]    Script Date: 12/9/2020 6:10:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[UPS_UpdateEmployeeDetails]
	-- Add the parameters for the stored procedure here
	@EmployeeNumber int,
	@FirstName varchar(14),
	@LastName varchar(16),
	@Gender varchar(50),
	@DateOfBirth date,
	@HireDate date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE employees SET first_name = @FirstName, last_name = @LastName,gender = @Gender,birth_date = @DateOfBirth,hire_date = @HireDate WHERE emp_no = @EmployeeNumber
END


EXEC [dbo].[UPS_UpdateEmployeeDetails]1,'BANURI','NIKHIL','MALE','1998/08/29','2020/10/19'

SELECT * FROM employees