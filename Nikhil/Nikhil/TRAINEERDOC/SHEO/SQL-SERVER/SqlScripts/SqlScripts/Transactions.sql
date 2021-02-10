-- SELECT * FROM Departments;SELECT * FROM Subjects
-- EXEC [dbo].[InsertDepartmentSubject] 'Sample2', 'Subject2', 'SubSubject2'

ALTER PROCEDURE [dbo].[InsertDepartmentSubject]
	-- Add the parameters for the stored procedure here
	@departmentName varchar(50),
	@subject varchar(50),
	@subSubject varchar(50)
AS
BEGIN
-- SET NOCOUNT ON added to prevent extra result sets from
-- interfering with SELECT statements.
SET NOCOUNT ON;

	BEGIN TRAN
		BEGIN TRY
			
			-- first statement
			INSERT INTO Departments (Name) VALUES (@departmentName)

			-- SELECT 'ITFunda'/0

			-- second statement
			INSERT INTO Subjects (Subject, SubSubject) VALUES (@subject, @subSubject)

			COMMIT TRANSACTION
		END TRY
	BEGIN CATCH
	-- if error, roll back any chanegs done by any of the sql statements
		ROLLBACK TRANSACTION
	END CATCH

END