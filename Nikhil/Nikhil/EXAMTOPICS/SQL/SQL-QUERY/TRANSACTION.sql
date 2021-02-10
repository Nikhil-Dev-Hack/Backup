USE [employees]
GO
/****** Object:  StoredProcedure [dbo].[TransactionsOfEmployeeSalary]    Script Date: 12/9/2020 11:19:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[TransactionsOfEmployeeSalary]
	-- Add the parameters for the stored procedure here
	@FirstName varchar(14),
	@LastName varchar(16),
	@Gender varchar(50),
	@BirthDate date,
	@HireDate date,
	@Salary int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	BEGIN TRAN
			BEGIN TRY
					INSERT INTO employees
								(first_name,last_name,gender,birth_date,hire_date)
					VALUES
								(@FirstName,@LastName,@Gender,@BirthDate,@HireDate)
					
					INSERT INTO salaries
								(salary)
					VALUES	
								(@Salary)
				COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
			ROLLBACK TRANSACTION
	END CATCH
END

EXEC [dbo].[TransactionsOfEmployeeSalary] 'SWAPNA','N','FEMALE','1999/05/29','2020/10/19',500000
SELECT * FROM employees 
SELECT * FROM salaries