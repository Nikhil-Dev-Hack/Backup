USE [employees]
GO
/****** Object:  StoredProcedure [dbo].[UPS_InsertEmployeeDetails]    Script Date: 12/9/2020 5:38:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[UPS_InsertEmployeeDetails]
	-- Add the parameters for the stored procedure here
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
	INSERT INTO employees (first_name,last_name,birth_date,gender,hire_date) VALUES (@FirstName,@LastName,@DateOfBirth,@Gender,@HireDate)
END

EXEC [dbo].[UPS_InsertEmployeeDetails] 'NIKHIL','BANURI','MALE','1998/08/29','2020/10/19'

SELECT * FROM employees
