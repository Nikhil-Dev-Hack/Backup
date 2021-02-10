USE [employees]
GO
/****** Object:  StoredProcedure [dbo].[UPS_INSERTANDRETURNIDENTITY]    Script Date: 12/9/2020 10:36:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[UPS_INSERTANDRETURNIDENTITY]
	-- Add the parameters for the stored procedure here
	@FirstName varchar(14),
	@LastName varchar(16),
	@Gender varchar(50),
	@BirthDate date,
	@HireDate date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO employees
			(first_name,last_name,gender,hire_date,birth_date )
	VALUES 
			(@FirstName,@LastName,@Gender,@HireDate,@BirthDate)
	RETURN SCOPE_IDENTITY()
END
