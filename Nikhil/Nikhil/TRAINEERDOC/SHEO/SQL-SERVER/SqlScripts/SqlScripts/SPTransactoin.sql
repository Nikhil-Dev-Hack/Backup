USE [SqlHowTo]
GO
/****** Object:  StoredProcedure [dbo].[InsertPersonalDetailsAndAccount]    Script Date: 3/18/2015 11:54:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[InsertPersonalDetailsAndAccount]
	-- Add the parameters for the stored procedure here
	@FirstName varchar(50),
	@LastName varchar(50),
	@Age smallint,
	@Active bit,
	@Salary money,
	@PPFDeduction money
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	BEGIN TRAN 
		BEGIN TRY
			-- Insert into PersonalDetails table first
			INSERT INTO PersonalDetails 
				(FirstName, LastName, Age, Active)
			VALUES
				(@FirstName, @LastName, @Age, @Active)

		
			DECLARE @pdId int
			SET @pdId = SCOPE_IDENTITY()
			-- now insert into Accounts table
			INSERT INTO Accounts 
				(Salary, PPFDeduction, PersonalDetailsId) 
			VALUES
				(@Salary, @PPFDeduction, @pdId)

			-- if not error, commit the transcation 
			COMMIT TRANSACTION 
		END TRY
	BEGIN CATCH
		-- if error, roll back any chanegs done by any of the sql statements
		ROLLBACK TRANSACTION 
	END CATCH

END
