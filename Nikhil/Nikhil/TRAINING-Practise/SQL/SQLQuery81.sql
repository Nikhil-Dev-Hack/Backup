
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE EmployeeTrans
	-- Add the parameters for the stored procedure here
	@EmployeeId nvarchar(50),
	@EmployeeFName nvarchar(50),
	@EmployeeLName nvarchar(50),
	@Salary money,
	@StudentId nvarchar(50),
	@studentName nvarchar(50),
	@studentAge nvarchar(50),
	@studentMarks nvarchar(50)

AS
BEGIN 
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	
	BEGIN TRAN
			BEGIN TRY
    -- Insert statements for procedure here
	INSERT INTO dbo.Employees ( EmployeeId,EmployeeFname,EmployeeLname,Salary) VALUES (@EmployeeFName,@EmployeeLName,@EmployeeId,@Salary)

	INSERT INTO dbo.student (studentId,studentName,studentAge,studentMarks) VALUES (@StudentId,@studentAge,@studentMarks,@studentName)
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END
GO
