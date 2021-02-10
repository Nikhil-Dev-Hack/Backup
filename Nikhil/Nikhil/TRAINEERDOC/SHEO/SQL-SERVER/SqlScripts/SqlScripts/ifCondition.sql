DECLARE @empId varchar(5)
SET @empId = 'TS33' -- change here

IF (EXISTS(SELECT EmpId FROM Employees WHERE EmpId = @empId))
BEGIN
	SELECT * FROM Employees WHERE EmpId = @empId
	SELECT * FROM EmployeesDetails WHERE EmpId = @empId
END
ELSE IF @empId = 'TS33'
	BEGIN
		SELECT 'You are crazy' as Results
	END
ELSE
	BEGIN
		SELECT 'No record found.' as Results
	END